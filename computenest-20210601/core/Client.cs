// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ComputeNest20210601.Models;

namespace AlibabaCloud.SDK.ComputeNest20210601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("computenest", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 资源组转组
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 资源组转组
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 资源组转组
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 资源组转组
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 继续部署服务实例
         *
         * @param request ContinueDeployServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContinueDeployServiceInstanceResponse
         */
        public ContinueDeployServiceInstanceResponse ContinueDeployServiceInstanceWithOptions(ContinueDeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinueDeployServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueDeployServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 继续部署服务实例
         *
         * @param request ContinueDeployServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContinueDeployServiceInstanceResponse
         */
        public async Task<ContinueDeployServiceInstanceResponse> ContinueDeployServiceInstanceWithOptionsAsync(ContinueDeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinueDeployServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueDeployServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 继续部署服务实例
         *
         * @param request ContinueDeployServiceInstanceRequest
         * @return ContinueDeployServiceInstanceResponse
         */
        public ContinueDeployServiceInstanceResponse ContinueDeployServiceInstance(ContinueDeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinueDeployServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 继续部署服务实例
         *
         * @param request ContinueDeployServiceInstanceRequest
         * @return ContinueDeployServiceInstanceResponse
         */
        public async Task<ContinueDeployServiceInstanceResponse> ContinueDeployServiceInstanceAsync(ContinueDeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinueDeployServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq CreateServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceInstanceResponse
         */
        public CreateServiceInstanceResponse CreateServiceInstanceWithOptions(CreateServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceInstanceShrinkRequest request = new CreateServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstanceOps))
            {
                query["EnableInstanceOps"] = request.EnableInstanceOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUserPrometheus))
            {
                query["EnableUserPrometheus"] = request.EnableUserPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMetadata))
            {
                query["OperationMetadata"] = request.OperationMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAutoPay))
            {
                query["ResourceAutoPay"] = request.ResourceAutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationCode))
            {
                query["SpecificationCode"] = request.SpecificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialType))
            {
                query["TrialType"] = request.TrialType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq CreateServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceInstanceResponse
         */
        public async Task<CreateServiceInstanceResponse> CreateServiceInstanceWithOptionsAsync(CreateServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceInstanceShrinkRequest request = new CreateServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstanceOps))
            {
                query["EnableInstanceOps"] = request.EnableInstanceOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUserPrometheus))
            {
                query["EnableUserPrometheus"] = request.EnableUserPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMetadata))
            {
                query["OperationMetadata"] = request.OperationMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAutoPay))
            {
                query["ResourceAutoPay"] = request.ResourceAutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationCode))
            {
                query["SpecificationCode"] = request.SpecificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialType))
            {
                query["TrialType"] = request.TrialType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateServiceInstanceRequest
         * @return CreateServiceInstanceResponse
         */
        public CreateServiceInstanceResponse CreateServiceInstance(CreateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @param request CreateServiceInstanceRequest
         * @return CreateServiceInstanceResponse
         */
        public async Task<CreateServiceInstanceResponse> CreateServiceInstanceAsync(CreateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除服务实例
         *
         * @param request DeleteServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceInstancesResponse
         */
        public DeleteServiceInstancesResponse DeleteServiceInstancesWithOptions(DeleteServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除服务实例
         *
         * @param request DeleteServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceInstancesResponse
         */
        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesWithOptionsAsync(DeleteServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除服务实例
         *
         * @param request DeleteServiceInstancesRequest
         * @return DeleteServiceInstancesResponse
         */
        public DeleteServiceInstancesResponse DeleteServiceInstances(DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 删除服务实例
         *
         * @param request DeleteServiceInstancesRequest
         * @return DeleteServiceInstancesResponse
         */
        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesAsync(DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询服务实例详情
         *
         * @param request GetServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceInstanceResponse
         */
        public GetServiceInstanceResponse GetServiceInstanceWithOptions(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketInstanceId))
            {
                query["MarketInstanceId"] = request.MarketInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务实例详情
         *
         * @param request GetServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceInstanceResponse
         */
        public async Task<GetServiceInstanceResponse> GetServiceInstanceWithOptionsAsync(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketInstanceId))
            {
                query["MarketInstanceId"] = request.MarketInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务实例详情
         *
         * @param request GetServiceInstanceRequest
         * @return GetServiceInstanceResponse
         */
        public GetServiceInstanceResponse GetServiceInstance(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 查询服务实例详情
         *
         * @param request GetServiceInstanceRequest
         * @return GetServiceInstanceResponse
         */
        public async Task<GetServiceInstanceResponse> GetServiceInstanceAsync(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取ROS参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public GetServiceTemplateParameterConstraintsResponse GetServiceTemplateParameterConstraintsWithOptions(GetServiceTemplateParameterConstraintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePrivateVpcConnection))
            {
                query["EnablePrivateVpcConnection"] = request.EnablePrivateVpcConnection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialType))
            {
                query["TrialType"] = request.TrialType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceTemplateParameterConstraints",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceTemplateParameterConstraintsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取ROS参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public async Task<GetServiceTemplateParameterConstraintsResponse> GetServiceTemplateParameterConstraintsWithOptionsAsync(GetServiceTemplateParameterConstraintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePrivateVpcConnection))
            {
                query["EnablePrivateVpcConnection"] = request.EnablePrivateVpcConnection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialType))
            {
                query["TrialType"] = request.TrialType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceTemplateParameterConstraints",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceTemplateParameterConstraintsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取ROS参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public GetServiceTemplateParameterConstraintsResponse GetServiceTemplateParameterConstraints(GetServiceTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceTemplateParameterConstraintsWithOptions(request, runtime);
        }

        /**
         * @summary 获取ROS参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public async Task<GetServiceTemplateParameterConstraintsResponse> GetServiceTemplateParameterConstraintsAsync(GetServiceTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceTemplateParameterConstraintsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询服务实例部署升级以及应用日志
         *
         * @param request ListServiceInstanceLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstanceLogsResponse
         */
        public ListServiceInstanceLogsResponse ListServiceInstanceLogsWithOptions(ListServiceInstanceLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                query["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["Logstore"] = request.Logstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstanceLogs",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstanceLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务实例部署升级以及应用日志
         *
         * @param request ListServiceInstanceLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstanceLogsResponse
         */
        public async Task<ListServiceInstanceLogsResponse> ListServiceInstanceLogsWithOptionsAsync(ListServiceInstanceLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                query["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["Logstore"] = request.Logstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstanceLogs",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstanceLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务实例部署升级以及应用日志
         *
         * @param request ListServiceInstanceLogsRequest
         * @return ListServiceInstanceLogsResponse
         */
        public ListServiceInstanceLogsResponse ListServiceInstanceLogs(ListServiceInstanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceInstanceLogsWithOptions(request, runtime);
        }

        /**
         * @summary 查询服务实例部署升级以及应用日志
         *
         * @param request ListServiceInstanceLogsRequest
         * @return ListServiceInstanceLogsResponse
         */
        public async Task<ListServiceInstanceLogsResponse> ListServiceInstanceLogsAsync(ListServiceInstanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceInstanceLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 展示实例资源
         *
         * @param request ListServiceInstanceResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstanceResourcesResponse
         */
        public ListServiceInstanceResourcesResponse ListServiceInstanceResourcesWithOptions(ListServiceInstanceResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeEnd))
            {
                query["ExpireTimeEnd"] = request.ExpireTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeStart))
            {
                query["ExpireTimeStart"] = request.ExpireTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceResourceType))
            {
                query["ServiceInstanceResourceType"] = request.ServiceInstanceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstanceResources",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstanceResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 展示实例资源
         *
         * @param request ListServiceInstanceResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstanceResourcesResponse
         */
        public async Task<ListServiceInstanceResourcesResponse> ListServiceInstanceResourcesWithOptionsAsync(ListServiceInstanceResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeEnd))
            {
                query["ExpireTimeEnd"] = request.ExpireTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeStart))
            {
                query["ExpireTimeStart"] = request.ExpireTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceARN))
            {
                query["ResourceARN"] = request.ResourceARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceResourceType))
            {
                query["ServiceInstanceResourceType"] = request.ServiceInstanceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstanceResources",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstanceResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 展示实例资源
         *
         * @param request ListServiceInstanceResourcesRequest
         * @return ListServiceInstanceResourcesResponse
         */
        public ListServiceInstanceResourcesResponse ListServiceInstanceResources(ListServiceInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceInstanceResourcesWithOptions(request, runtime);
        }

        /**
         * @summary 展示实例资源
         *
         * @param request ListServiceInstanceResourcesRequest
         * @return ListServiceInstanceResourcesResponse
         */
        public async Task<ListServiceInstanceResourcesResponse> ListServiceInstanceResourcesAsync(ListServiceInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceInstanceResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstancesResponse
         */
        public ListServiceInstancesResponse ListServiceInstancesWithOptions(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstances",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstancesResponse
         */
        public async Task<ListServiceInstancesResponse> ListServiceInstancesWithOptionsAsync(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstances",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListServiceInstancesRequest
         * @return ListServiceInstancesResponse
         */
        public ListServiceInstancesResponse ListServiceInstances(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceInstancesWithOptions(request, runtime);
        }

        /**
         * @param request ListServiceInstancesRequest
         * @return ListServiceInstancesResponse
         */
        public async Task<ListServiceInstancesResponse> ListServiceInstancesAsync(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重启服务实例
         *
         * @param request RestartServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartServiceInstanceResponse
         */
        public RestartServiceInstanceResponse RestartServiceInstanceWithOptions(RestartServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重启服务实例
         *
         * @param request RestartServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartServiceInstanceResponse
         */
        public async Task<RestartServiceInstanceResponse> RestartServiceInstanceWithOptionsAsync(RestartServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重启服务实例
         *
         * @param request RestartServiceInstanceRequest
         * @return RestartServiceInstanceResponse
         */
        public RestartServiceInstanceResponse RestartServiceInstance(RestartServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 重启服务实例
         *
         * @param request RestartServiceInstanceRequest
         * @return RestartServiceInstanceResponse
         */
        public async Task<RestartServiceInstanceResponse> RestartServiceInstanceAsync(RestartServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 启动服务实例
         *
         * @param request StartServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartServiceInstanceResponse
         */
        public StartServiceInstanceResponse StartServiceInstanceWithOptions(StartServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动服务实例
         *
         * @param request StartServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartServiceInstanceResponse
         */
        public async Task<StartServiceInstanceResponse> StartServiceInstanceWithOptionsAsync(StartServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动服务实例
         *
         * @param request StartServiceInstanceRequest
         * @return StartServiceInstanceResponse
         */
        public StartServiceInstanceResponse StartServiceInstance(StartServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 启动服务实例
         *
         * @param request StartServiceInstanceRequest
         * @return StartServiceInstanceResponse
         */
        public async Task<StartServiceInstanceResponse> StartServiceInstanceAsync(StartServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 停止服务实例
         *
         * @param request StopServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopServiceInstanceResponse
         */
        public StopServiceInstanceResponse StopServiceInstanceWithOptions(StopServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 停止服务实例
         *
         * @param request StopServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopServiceInstanceResponse
         */
        public async Task<StopServiceInstanceResponse> StopServiceInstanceWithOptionsAsync(StopServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopServiceInstance",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 停止服务实例
         *
         * @param request StopServiceInstanceRequest
         * @return StopServiceInstanceResponse
         */
        public StopServiceInstanceResponse StopServiceInstance(StopServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 停止服务实例
         *
         * @param request StopServiceInstanceRequest
         * @return StopServiceInstanceResponse
         */
        public async Task<StopServiceInstanceResponse> StopServiceInstanceAsync(StopServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq UpdateServiceInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceSpecResponse
         */
        public UpdateServiceInstanceSpecResponse UpdateServiceInstanceSpecWithOptions(UpdateServiceInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceInstanceSpecShrinkRequest request = new UpdateServiceInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUserPrometheus))
            {
                query["EnableUserPrometheus"] = request.EnableUserPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                query["OperationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredefinedParametersName))
            {
                query["PredefinedParametersName"] = request.PredefinedParametersName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstanceSpec",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq UpdateServiceInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceSpecResponse
         */
        public async Task<UpdateServiceInstanceSpecResponse> UpdateServiceInstanceSpecWithOptionsAsync(UpdateServiceInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceInstanceSpecShrinkRequest request = new UpdateServiceInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUserPrometheus))
            {
                query["EnableUserPrometheus"] = request.EnableUserPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                query["OperationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredefinedParametersName))
            {
                query["PredefinedParametersName"] = request.PredefinedParametersName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstanceSpec",
                Version = "2021-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateServiceInstanceSpecRequest
         * @return UpdateServiceInstanceSpecResponse
         */
        public UpdateServiceInstanceSpecResponse UpdateServiceInstanceSpec(UpdateServiceInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceInstanceSpecWithOptions(request, runtime);
        }

        /**
         * @param request UpdateServiceInstanceSpecRequest
         * @return UpdateServiceInstanceSpecResponse
         */
        public async Task<UpdateServiceInstanceSpecResponse> UpdateServiceInstanceSpecAsync(UpdateServiceInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceInstanceSpecWithOptionsAsync(request, runtime);
        }

    }
}
