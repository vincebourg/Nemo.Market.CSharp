# Nemo.Market.CSharp
This Kata had been written to test candidates for a certain mission in the domain of the energy. It contains tests that are already written.
## Context
The goal here is to have a project that can handle Buildings and Plants linked by Pipes. These pipes are supposed to bring the generated power (that represents cooling or heating) from the Plants to the buildings. A Plant provides Power and a building consumes it.

The PipeDiameterCalculator allows to calculate the size of the pipe needed to transport the power needed. The bigger, the more power can be transported.

This Kata doesn't have an end, as it is just a reference for more discution.
## Rules
- You can't modify the already written tests !
- You can add more tests.
- You can modify everything else, as long as the tests compile and run.
- A green test should never go back to red.
## Steps
- Get all BuildingTests Green.
- Why is building_has_default_position_0_0 already green ?
- Get all PipeTests Green.
- Get all PlantTests Green.
- Take some time to think about the design of the code that you have modified.
- Get the PipeDiameterCalculatorTests Green.
- Get the ProjectTests Green.
