GiantKillerRobot robot = new GiantKillerRobot();
robot.Initialize();
robot.EyeLaserIntensity = Intensity.Kill;

robot.Targets.Add(Target.Human);
robot.Targets.Add(Target.Human);
robot.Targets.Add(Target.Animal);
robot.Targets.Add(Target.Animal);
robot.Targets.Add(Target.Superhero);
robot.Targets.Add(Target.Superhero);
robot.Targets.Add(Target.Superhero);

Planet earth = new Planet();
earth.Name = Planets.Earth.ToString();

while (robot.Active && earth.ContainsLife)
{
    if (robot.CurrentTarget < robot.Targets.Count && robot.IsAlive)
        robot.FireLaserAt(robot.CurrentTarget);
    else
        robot.AcquireNextTarget();
}