// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AssignRolesOperations.
    /// </summary>
    public static partial class AssignRolesOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            public static AssignRolesResponse Get(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string))
            {
                return operations.GetAsync(userName, permissions, roles).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssignRolesResponse> GetAsync(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(userName, permissions, roles, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static AssignRolesResponse Create(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string), AssignRoles body = default(AssignRoles))
            {
                return operations.CreateAsync(userName, permissions, roles, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssignRolesResponse> CreateAsync(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string), AssignRoles body = default(AssignRoles), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(userName, permissions, roles, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static AssignRolesResponse Post(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string), AssignRoles body = default(AssignRoles))
            {
                return operations.PostAsync(userName, permissions, roles, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssignRolesResponse> PostAsync(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string), AssignRoles body = default(AssignRoles), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(userName, permissions, roles, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            public static AssignRolesResponse Delete(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string))
            {
                return operations.DeleteAsync(userName, permissions, roles).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userName'>
            /// </param>
            /// <param name='permissions'>
            /// </param>
            /// <param name='roles'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssignRolesResponse> DeleteAsync(this IAssignRolesOperations operations, string userName = default(string), string permissions = default(string), string roles = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(userName, permissions, roles, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
