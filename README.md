# Nonlinear-MultiVariableNewtonMethod
solving a nonlinear problem with multi variable newton method

MULTI-VARIABLE NEWTON'S METHOD

In higher dimensions; the above iterative scheme can be generalized to several dimensions by replacing the derivative with the gradient, 
∇f (x), and the reciprocal of the second derivative with the inverse of the Hessian matrix, H f (x). One obtains the iterative scheme:

{\displaystyle \mathbf {x} _{n+1}=\mathbf {x} _{n}-[\mathbf {H} f(\mathbf {x} _{n})]^{-1}\nabla f(\mathbf {x} _{n}),\ n\geq 0.} \mathbf {x} _{n+1}=\mathbf {x} _{n}-[\mathbf {H} f(\mathbf {x} _{n})]^{-1}\nabla f(\mathbf {x} _{n}),\ n\geq 0.

Often Newton's method is modified to include a small step size γ ∈ (0,1) instead of γ = 1

{\displaystyle \mathbf {x} _{n+1}=\mathbf {x} _{n}-\gamma [\mathbf {H} f(\mathbf {x} _{n})]^{-1}\nabla f(\mathbf {x} _{n}).} \mathbf {x} _{n+1}=\mathbf {x} _{n}-\gamma [\mathbf {H} f(\mathbf {x} _{n})]^{-1}\nabla f(\mathbf {x} _{n}).

This is often done to ensure that the Wolfe conditions are satisfied at each step xn → xn+1 of the iteration. For step sizes other than 1, 
the method is often referred to as the relaxed Newton's method.

Where applicable, Newton's method converges much faster towards a local maximum or minimum than gradient descent. In fact, every local 
minimum has a neighborhood N such that, if we start with x0 ∈ N, Newton's method with step size γ = 1 converges quadratically (if the 
Hessian is invertible and a Lipschitz continuous function of x in that neighborhood).

Finding the inverse of the Hessian in high dimensions can be an expensive operation. In such cases, instead of directly inverting the 
Hessian it's better to calculate the vector Δx = xn + 1 - xn as the solution to the system of linear equations:

{\displaystyle [\mathbf {H} f(\mathbf {x} _{n})]\mathbf {\Delta x} =-\nabla f(\mathbf {x} _{n})} [\mathbf {H} f(\mathbf {x} _{n})]\mathbf {\Delta x} =-\nabla f(\mathbf {x} _{n})

which may be solved by various factorizations or approximately (but to great accuracy) using iterative methods.
