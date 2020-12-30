// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Gws20190618.Models;

namespace AlibabaCloud.SDK.Gws20190618
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-3", "gws.ap-northeast-3.aliyuncs.com"},
                {"cn-hangzhou-finance", "ecd.cn-hangzhou-finance.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("gws", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterResponse>(DoRPCRequest("CreateCluster", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterResponse>(await DoRPCRequestAsync("CreateCluster", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(DoRPCRequest("CreateImage", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(await DoRPCRequestAsync("CreateImage", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageWithOptions(request, runtime);
        }

        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(DoRPCRequest("CreateServiceLinkedRole", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await DoRPCRequestAsync("CreateServiceLinkedRole", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleWithOptions(runtime);
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleWithOptionsAsync(runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(DoRPCRequest("DeleteCluster", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await DoRPCRequestAsync("DeleteCluster", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(request, runtime);
        }

        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(request, runtime);
        }

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(DoRPCRequest("DeleteImage", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(await DoRPCRequestAsync("DeleteImage", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageWithOptions(request, runtime);
        }

        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRPCRequest("DescribeAvailableResource", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRPCRequestAsync("DescribeAvailableResource", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableResourceResponse DescribeAvailableResource()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(runtime);
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(runtime);
        }

        public DescribeClusterADDomainResponse DescribeClusterADDomainWithOptions(DescribeClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterADDomainResponse>(DoRPCRequest("DescribeClusterADDomain", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterADDomainResponse> DescribeClusterADDomainWithOptionsAsync(DescribeClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterADDomainResponse>(await DoRPCRequestAsync("DescribeClusterADDomain", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterADDomainResponse DescribeClusterADDomain(DescribeClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterADDomainWithOptions(request, runtime);
        }

        public async Task<DescribeClusterADDomainResponse> DescribeClusterADDomainAsync(DescribeClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterADDomainWithOptionsAsync(request, runtime);
        }

        public DescribeClusterConnectionsResponse DescribeClusterConnectionsWithOptions(DescribeClusterConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterConnectionsResponse>(DoRPCRequest("DescribeClusterConnections", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterConnectionsResponse> DescribeClusterConnectionsWithOptionsAsync(DescribeClusterConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterConnectionsResponse>(await DoRPCRequestAsync("DescribeClusterConnections", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterConnectionsResponse DescribeClusterConnections(DescribeClusterConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeClusterConnectionsResponse> DescribeClusterConnectionsAsync(DescribeClusterConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeClusterPolicyResponse DescribeClusterPolicyWithOptions(DescribeClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterPolicyResponse>(DoRPCRequest("DescribeClusterPolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterPolicyResponse> DescribeClusterPolicyWithOptionsAsync(DescribeClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterPolicyResponse>(await DoRPCRequestAsync("DescribeClusterPolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterPolicyResponse DescribeClusterPolicy(DescribeClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeClusterPolicyResponse> DescribeClusterPolicyAsync(DescribeClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeClustersResponse DescribeClustersWithOptions(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersResponse>(DoRPCRequest("DescribeClusters", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClustersResponse> DescribeClustersWithOptionsAsync(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersResponse>(await DoRPCRequestAsync("DescribeClusters", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClustersWithOptions(request, runtime);
        }

        public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClustersWithOptionsAsync(request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(DoRPCRequest("DescribeImages", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRPCRequestAsync("DescribeImages", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagesWithOptions(request, runtime);
        }

        public async Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagesWithOptionsAsync(request, runtime);
        }

        public DescribeInstancePolicyResponse DescribeInstancePolicyWithOptions(DescribeInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePolicyResponse>(DoRPCRequest("DescribeInstancePolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancePolicyResponse> DescribeInstancePolicyWithOptionsAsync(DescribeInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePolicyResponse>(await DoRPCRequestAsync("DescribeInstancePolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancePolicyResponse DescribeInstancePolicy(DescribeInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancePolicyWithOptions(request, runtime);
        }

        public async Task<DescribeInstancePolicyResponse> DescribeInstancePolicyAsync(DescribeInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancePolicyWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public GetConnectTicketResponse GetConnectTicketWithOptions(GetConnectTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnectTicketResponse>(DoRPCRequest("GetConnectTicket", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConnectTicketResponse> GetConnectTicketWithOptionsAsync(GetConnectTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConnectTicketResponse>(await DoRPCRequestAsync("GetConnectTicket", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConnectTicketResponse GetConnectTicket(GetConnectTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectTicketWithOptions(request, runtime);
        }

        public async Task<GetConnectTicketResponse> GetConnectTicketAsync(GetConnectTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectTicketWithOptionsAsync(request, runtime);
        }

        public IsUserAdminResponse IsUserAdminWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<IsUserAdminResponse>(DoRPCRequest("IsUserAdmin", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IsUserAdminResponse> IsUserAdminWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<IsUserAdminResponse>(await DoRPCRequestAsync("IsUserAdmin", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IsUserAdminResponse IsUserAdmin()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IsUserAdminWithOptions(runtime);
        }

        public async Task<IsUserAdminResponse> IsUserAdminAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IsUserAdminWithOptionsAsync(runtime);
        }

        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(DoRPCRequest("RestartInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await DoRPCRequestAsync("RestartInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartInstanceWithOptions(request, runtime);
        }

        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartInstanceWithOptionsAsync(request, runtime);
        }

        public SetClusterADDomainResponse SetClusterADDomainWithOptions(SetClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterADDomainResponse>(DoRPCRequest("SetClusterADDomain", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetClusterADDomainResponse> SetClusterADDomainWithOptionsAsync(SetClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterADDomainResponse>(await DoRPCRequestAsync("SetClusterADDomain", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetClusterADDomainResponse SetClusterADDomain(SetClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterADDomainWithOptions(request, runtime);
        }

        public async Task<SetClusterADDomainResponse> SetClusterADDomainAsync(SetClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterADDomainWithOptionsAsync(request, runtime);
        }

        public SetClusterDnatResponse SetClusterDnatWithOptions(SetClusterDnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterDnatResponse>(DoRPCRequest("SetClusterDnat", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetClusterDnatResponse> SetClusterDnatWithOptionsAsync(SetClusterDnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterDnatResponse>(await DoRPCRequestAsync("SetClusterDnat", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetClusterDnatResponse SetClusterDnat(SetClusterDnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterDnatWithOptions(request, runtime);
        }

        public async Task<SetClusterDnatResponse> SetClusterDnatAsync(SetClusterDnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterDnatWithOptionsAsync(request, runtime);
        }

        public SetClusterNameResponse SetClusterNameWithOptions(SetClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterNameResponse>(DoRPCRequest("SetClusterName", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetClusterNameResponse> SetClusterNameWithOptionsAsync(SetClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterNameResponse>(await DoRPCRequestAsync("SetClusterName", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetClusterNameResponse SetClusterName(SetClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterNameWithOptions(request, runtime);
        }

        public async Task<SetClusterNameResponse> SetClusterNameAsync(SetClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterNameWithOptionsAsync(request, runtime);
        }

        public SetClusterPolicyResponse SetClusterPolicyWithOptions(SetClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterPolicyResponse>(DoRPCRequest("SetClusterPolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetClusterPolicyResponse> SetClusterPolicyWithOptionsAsync(SetClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetClusterPolicyResponse>(await DoRPCRequestAsync("SetClusterPolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetClusterPolicyResponse SetClusterPolicy(SetClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterPolicyWithOptions(request, runtime);
        }

        public async Task<SetClusterPolicyResponse> SetClusterPolicyAsync(SetClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterPolicyWithOptionsAsync(request, runtime);
        }

        public SetImageNameResponse SetImageNameWithOptions(SetImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetImageNameResponse>(DoRPCRequest("SetImageName", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetImageNameResponse> SetImageNameWithOptionsAsync(SetImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetImageNameResponse>(await DoRPCRequestAsync("SetImageName", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetImageNameResponse SetImageName(SetImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetImageNameWithOptions(request, runtime);
        }

        public async Task<SetImageNameResponse> SetImageNameAsync(SetImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetImageNameWithOptionsAsync(request, runtime);
        }

        public SetInstanceNameResponse SetInstanceNameWithOptions(SetInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstanceNameResponse>(DoRPCRequest("SetInstanceName", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetInstanceNameResponse> SetInstanceNameWithOptionsAsync(SetInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstanceNameResponse>(await DoRPCRequestAsync("SetInstanceName", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetInstanceNameResponse SetInstanceName(SetInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceNameWithOptions(request, runtime);
        }

        public async Task<SetInstanceNameResponse> SetInstanceNameAsync(SetInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceNameWithOptionsAsync(request, runtime);
        }

        public SetInstancePolicyResponse SetInstancePolicyWithOptions(SetInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstancePolicyResponse>(DoRPCRequest("SetInstancePolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetInstancePolicyResponse> SetInstancePolicyWithOptionsAsync(SetInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstancePolicyResponse>(await DoRPCRequestAsync("SetInstancePolicy", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetInstancePolicyResponse SetInstancePolicy(SetInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstancePolicyWithOptions(request, runtime);
        }

        public async Task<SetInstancePolicyResponse> SetInstancePolicyAsync(SetInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstancePolicyWithOptionsAsync(request, runtime);
        }

        public SetInstanceUserResponse SetInstanceUserWithOptions(SetInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstanceUserResponse>(DoRPCRequest("SetInstanceUser", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetInstanceUserResponse> SetInstanceUserWithOptionsAsync(SetInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetInstanceUserResponse>(await DoRPCRequestAsync("SetInstanceUser", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetInstanceUserResponse SetInstanceUser(SetInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceUserWithOptions(request, runtime);
        }

        public async Task<SetInstanceUserResponse> SetInstanceUserAsync(SetInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceUserWithOptionsAsync(request, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(DoRPCRequest("StartInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(await DoRPCRequestAsync("StartInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(DoRPCRequest("StopInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(await DoRPCRequestAsync("StopInstance", "2019-06-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

    }
}
