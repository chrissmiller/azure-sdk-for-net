// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearningCompute.Models;

namespace Azure.ResourceManager.MachineLearningCompute
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _machineLearningComputeClientDiagnostics;
        private MachineLearningComputeRestOperations _machineLearningComputeRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MachineLearningComputeClientDiagnostics => _machineLearningComputeClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearningCompute", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private MachineLearningComputeRestOperations MachineLearningComputeRestClient => _machineLearningComputeRestClient ??= new MachineLearningComputeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all available operations.
        /// Request Path: /providers/Microsoft.MachineLearningCompute/operations
        /// Operation Id: MachineLearningCompute_ListAvailableOperations
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceOperation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceOperation> GetAvailableOperationsMachineLearningComputesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceOperation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MachineLearningComputeClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetAvailableOperationsMachineLearningComputes");
                scope.Start();
                try
                {
                    var response = await MachineLearningComputeRestClient.ListAvailableOperationsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets all available operations.
        /// Request Path: /providers/Microsoft.MachineLearningCompute/operations
        /// Operation Id: MachineLearningCompute_ListAvailableOperations
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceOperation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceOperation> GetAvailableOperationsMachineLearningComputes(CancellationToken cancellationToken = default)
        {
            Page<ResourceOperation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MachineLearningComputeClientDiagnostics.CreateScope("TenantResourceExtensionClient.GetAvailableOperationsMachineLearningComputes");
                scope.Start();
                try
                {
                    var response = MachineLearningComputeRestClient.ListAvailableOperations(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
