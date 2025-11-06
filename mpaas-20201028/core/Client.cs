// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MPaaS20201028.Models;

namespace AlibabaCloud.SDK.MPaaS20201028
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "mpaas.aliyuncs.com"},
                {"ap-northeast-1", "mpaas.aliyuncs.com"},
                {"ap-northeast-2-pop", "mpaas.aliyuncs.com"},
                {"ap-south-1", "mpaas.aliyuncs.com"},
                {"ap-southeast-1", "mpaas.aliyuncs.com"},
                {"ap-southeast-2", "mpaas.aliyuncs.com"},
                {"ap-southeast-3", "mpaas.aliyuncs.com"},
                {"ap-southeast-5", "mpaas.aliyuncs.com"},
                {"cn-beijing", "mpaas.aliyuncs.com"},
                {"cn-beijing-finance-1", "mpaas.aliyuncs.com"},
                {"cn-beijing-finance-pop", "mpaas.aliyuncs.com"},
                {"cn-beijing-gov-1", "mpaas.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "mpaas.aliyuncs.com"},
                {"cn-chengdu", "mpaas.aliyuncs.com"},
                {"cn-edge-1", "mpaas.aliyuncs.com"},
                {"cn-fujian", "mpaas.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "mpaas.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "mpaas.aliyuncs.com"},
                {"cn-hangzhou-finance", "mpaas.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "mpaas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "mpaas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "mpaas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "mpaas.aliyuncs.com"},
                {"cn-hangzhou-test-306", "mpaas.aliyuncs.com"},
                {"cn-hongkong", "mpaas.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "mpaas.aliyuncs.com"},
                {"cn-huhehaote", "mpaas.aliyuncs.com"},
                {"cn-north-2-gov-1", "mpaas.aliyuncs.com"},
                {"cn-qingdao", "mpaas.aliyuncs.com"},
                {"cn-qingdao-nebula", "mpaas.aliyuncs.com"},
                {"cn-shanghai", "mpaas.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "mpaas.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "mpaas.aliyuncs.com"},
                {"cn-shanghai-finance-1", "mpaas.aliyuncs.com"},
                {"cn-shanghai-inner", "mpaas.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "mpaas.aliyuncs.com"},
                {"cn-shenzhen", "mpaas.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "mpaas.aliyuncs.com"},
                {"cn-shenzhen-inner", "mpaas.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "mpaas.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "mpaas.aliyuncs.com"},
                {"cn-wuhan", "mpaas.aliyuncs.com"},
                {"cn-yushanfang", "mpaas.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "mpaas.aliyuncs.com"},
                {"cn-zhangjiakou", "mpaas.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "mpaas.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "mpaas.aliyuncs.com"},
                {"eu-central-1", "mpaas.aliyuncs.com"},
                {"eu-west-1", "mpaas.aliyuncs.com"},
                {"eu-west-1-oxs", "mpaas.aliyuncs.com"},
                {"me-east-1", "mpaas.aliyuncs.com"},
                {"rus-west-1-pop", "mpaas.aliyuncs.com"},
                {"us-east-1", "mpaas.aliyuncs.com"},
                {"us-west-1", "mpaas.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("mpaas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// AddMdsMiniConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMdsMiniConfigResponse
        /// </returns>
        public AddMdsMiniConfigResponse AddMdsMiniConfigWithOptions(AddMdsMiniConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMiniConfigAddJsonStr))
            {
                body["MpaasMappcenterMiniConfigAddJsonStr"] = request.MpaasMappcenterMiniConfigAddJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMdsMiniConfig",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMdsMiniConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddMdsMiniConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMdsMiniConfigResponse
        /// </returns>
        public async Task<AddMdsMiniConfigResponse> AddMdsMiniConfigWithOptionsAsync(AddMdsMiniConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMiniConfigAddJsonStr))
            {
                body["MpaasMappcenterMiniConfigAddJsonStr"] = request.MpaasMappcenterMiniConfigAddJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMdsMiniConfig",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMdsMiniConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddMdsMiniConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMdsMiniConfigResponse
        /// </returns>
        public AddMdsMiniConfigResponse AddMdsMiniConfig(AddMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMdsMiniConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddMdsMiniConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMdsMiniConfigResponse
        /// </returns>
        public async Task<AddMdsMiniConfigResponse> AddMdsMiniConfigAsync(AddMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMdsMiniConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CancelPushSchedulerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPushSchedulerResponse
        /// </returns>
        public CancelPushSchedulerResponse CancelPushSchedulerWithOptions(CancelPushSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueIds))
            {
                body["UniqueIds"] = request.UniqueIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPushScheduler",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPushSchedulerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelPushSchedulerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPushSchedulerResponse
        /// </returns>
        public async Task<CancelPushSchedulerResponse> CancelPushSchedulerWithOptionsAsync(CancelPushSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueIds))
            {
                body["UniqueIds"] = request.UniqueIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPushScheduler",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPushSchedulerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelPushSchedulerRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPushSchedulerResponse
        /// </returns>
        public CancelPushSchedulerResponse CancelPushScheduler(CancelPushSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPushSchedulerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CancelPushSchedulerRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPushSchedulerResponse
        /// </returns>
        public async Task<CancelPushSchedulerResponse> CancelPushSchedulerAsync(CancelPushSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPushSchedulerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeMcubeMiniTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeMiniTaskStatusResponse
        /// </returns>
        public ChangeMcubeMiniTaskStatusResponse ChangeMcubeMiniTaskStatusWithOptions(ChangeMcubeMiniTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMcubeMiniTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMcubeMiniTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMcubeMiniTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeMiniTaskStatusResponse
        /// </returns>
        public async Task<ChangeMcubeMiniTaskStatusResponse> ChangeMcubeMiniTaskStatusWithOptionsAsync(ChangeMcubeMiniTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMcubeMiniTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMcubeMiniTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMcubeMiniTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeMiniTaskStatusResponse
        /// </returns>
        public ChangeMcubeMiniTaskStatusResponse ChangeMcubeMiniTaskStatus(ChangeMcubeMiniTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMcubeMiniTaskStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeMcubeMiniTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeMiniTaskStatusResponse
        /// </returns>
        public async Task<ChangeMcubeMiniTaskStatusResponse> ChangeMcubeMiniTaskStatusAsync(ChangeMcubeMiniTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMcubeMiniTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeMcubeNebulaTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeNebulaTaskStatusResponse
        /// </returns>
        public ChangeMcubeNebulaTaskStatusResponse ChangeMcubeNebulaTaskStatusWithOptions(ChangeMcubeNebulaTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMcubeNebulaTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMcubeNebulaTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMcubeNebulaTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeNebulaTaskStatusResponse
        /// </returns>
        public async Task<ChangeMcubeNebulaTaskStatusResponse> ChangeMcubeNebulaTaskStatusWithOptionsAsync(ChangeMcubeNebulaTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMcubeNebulaTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMcubeNebulaTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMcubeNebulaTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeNebulaTaskStatusResponse
        /// </returns>
        public ChangeMcubeNebulaTaskStatusResponse ChangeMcubeNebulaTaskStatus(ChangeMcubeNebulaTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMcubeNebulaTaskStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeMcubeNebulaTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubeNebulaTaskStatusResponse
        /// </returns>
        public async Task<ChangeMcubeNebulaTaskStatusResponse> ChangeMcubeNebulaTaskStatusAsync(ChangeMcubeNebulaTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMcubeNebulaTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeMcubePublicTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubePublicTaskStatusResponse
        /// </returns>
        public ChangeMcubePublicTaskStatusResponse ChangeMcubePublicTaskStatusWithOptions(ChangeMcubePublicTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMcubePublicTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMcubePublicTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMcubePublicTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubePublicTaskStatusResponse
        /// </returns>
        public async Task<ChangeMcubePublicTaskStatusResponse> ChangeMcubePublicTaskStatusWithOptionsAsync(ChangeMcubePublicTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMcubePublicTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMcubePublicTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMcubePublicTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubePublicTaskStatusResponse
        /// </returns>
        public ChangeMcubePublicTaskStatusResponse ChangeMcubePublicTaskStatus(ChangeMcubePublicTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMcubePublicTaskStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeMcubePublicTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMcubePublicTaskStatusResponse
        /// </returns>
        public async Task<ChangeMcubePublicTaskStatusResponse> ChangeMcubePublicTaskStatusAsync(ChangeMcubePublicTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMcubePublicTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeMdsCubeTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMdsCubeTaskStatusResponse
        /// </returns>
        public ChangeMdsCubeTaskStatusResponse ChangeMdsCubeTaskStatusWithOptions(ChangeMdsCubeTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateTaskId))
            {
                body["TemplateTaskId"] = request.TemplateTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMdsCubeTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMdsCubeTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMdsCubeTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMdsCubeTaskStatusResponse
        /// </returns>
        public async Task<ChangeMdsCubeTaskStatusResponse> ChangeMdsCubeTaskStatusWithOptionsAsync(ChangeMdsCubeTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateTaskId))
            {
                body["TemplateTaskId"] = request.TemplateTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMdsCubeTaskStatus",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMdsCubeTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeMdsCubeTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMdsCubeTaskStatusResponse
        /// </returns>
        public ChangeMdsCubeTaskStatusResponse ChangeMdsCubeTaskStatus(ChangeMdsCubeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMdsCubeTaskStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeMdsCubeTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMdsCubeTaskStatusResponse
        /// </returns>
        public async Task<ChangeMdsCubeTaskStatusResponse> ChangeMdsCubeTaskStatusAsync(ChangeMdsCubeTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMdsCubeTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CopyMcdpGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyMcdpGroupResponse
        /// </returns>
        public CopyMcdpGroupResponse CopyMcdpGroupWithOptions(CopyMcdpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpGroupCopyJsonStr))
            {
                body["MpaasMappcenterMcdpGroupCopyJsonStr"] = request.MpaasMappcenterMcdpGroupCopyJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyMcdpGroup",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyMcdpGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CopyMcdpGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyMcdpGroupResponse
        /// </returns>
        public async Task<CopyMcdpGroupResponse> CopyMcdpGroupWithOptionsAsync(CopyMcdpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpGroupCopyJsonStr))
            {
                body["MpaasMappcenterMcdpGroupCopyJsonStr"] = request.MpaasMappcenterMcdpGroupCopyJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyMcdpGroup",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyMcdpGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CopyMcdpGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyMcdpGroupResponse
        /// </returns>
        public CopyMcdpGroupResponse CopyMcdpGroup(CopyMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyMcdpGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CopyMcdpGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyMcdpGroupResponse
        /// </returns>
        public async Task<CopyMcdpGroupResponse> CopyMcdpGroupAsync(CopyMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyMcdpGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLinkResponse
        /// </returns>
        public CreateLinkResponse CreateLinkWithOptions(CreateLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cors))
            {
                body["Cors"] = request.Cors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dynamicfield))
            {
                body["Dynamicfield"] = request.Dynamicfield;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUrl))
            {
                body["TargetUrl"] = request.TargetUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLink",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLinkResponse
        /// </returns>
        public async Task<CreateLinkResponse> CreateLinkWithOptionsAsync(CreateLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cors))
            {
                body["Cors"] = request.Cors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dynamicfield))
            {
                body["Dynamicfield"] = request.Dynamicfield;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUrl))
            {
                body["TargetUrl"] = request.TargetUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLink",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLinkResponse
        /// </returns>
        public CreateLinkResponse CreateLink(CreateLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLinkResponse
        /// </returns>
        public async Task<CreateLinkResponse> CreateLinkAsync(CreateLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLinkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcdpGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpGroupResponse
        /// </returns>
        public CreateMcdpGroupResponse CreateMcdpGroupWithOptions(CreateMcdpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpGroupCreateJsonStr))
            {
                body["MpaasMappcenterMcdpGroupCreateJsonStr"] = request.MpaasMappcenterMcdpGroupCreateJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcdpGroup",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcdpGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpGroupResponse
        /// </returns>
        public async Task<CreateMcdpGroupResponse> CreateMcdpGroupWithOptionsAsync(CreateMcdpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpGroupCreateJsonStr))
            {
                body["MpaasMappcenterMcdpGroupCreateJsonStr"] = request.MpaasMappcenterMcdpGroupCreateJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcdpGroup",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcdpGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpGroupResponse
        /// </returns>
        public CreateMcdpGroupResponse CreateMcdpGroup(CreateMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcdpGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpGroupResponse
        /// </returns>
        public async Task<CreateMcdpGroupResponse> CreateMcdpGroupAsync(CreateMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcdpMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpMaterialResponse
        /// </returns>
        public CreateMcdpMaterialResponse CreateMcdpMaterialWithOptions(CreateMcdpMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMaterialCreateJsonStr))
            {
                body["MpaasMappcenterMcdpMaterialCreateJsonStr"] = request.MpaasMappcenterMcdpMaterialCreateJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcdpMaterial",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpMaterialResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcdpMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpMaterialResponse
        /// </returns>
        public async Task<CreateMcdpMaterialResponse> CreateMcdpMaterialWithOptionsAsync(CreateMcdpMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMaterialCreateJsonStr))
            {
                body["MpaasMappcenterMcdpMaterialCreateJsonStr"] = request.MpaasMappcenterMcdpMaterialCreateJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcdpMaterial",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcdpMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpMaterialResponse
        /// </returns>
        public CreateMcdpMaterialResponse CreateMcdpMaterial(CreateMcdpMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpMaterialWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcdpMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpMaterialResponse
        /// </returns>
        public async Task<CreateMcdpMaterialResponse> CreateMcdpMaterialAsync(CreateMcdpMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpMaterialWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcdpZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpZoneResponse
        /// </returns>
        public CreateMcdpZoneResponse CreateMcdpZoneWithOptions(CreateMcdpZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpZoneCreateJsonStr))
            {
                body["MpaasMappcenterMcdpZoneCreateJsonStr"] = request.MpaasMappcenterMcdpZoneCreateJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcdpZone",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpZoneResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcdpZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpZoneResponse
        /// </returns>
        public async Task<CreateMcdpZoneResponse> CreateMcdpZoneWithOptionsAsync(CreateMcdpZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpZoneCreateJsonStr))
            {
                body["MpaasMappcenterMcdpZoneCreateJsonStr"] = request.MpaasMappcenterMcdpZoneCreateJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcdpZone",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcdpZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpZoneResponse
        /// </returns>
        public CreateMcdpZoneResponse CreateMcdpZone(CreateMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpZoneWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcdpZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcdpZoneResponse
        /// </returns>
        public async Task<CreateMcdpZoneResponse> CreateMcdpZoneAsync(CreateMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpZoneWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeMiniAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniAppResponse
        /// </returns>
        public CreateMcubeMiniAppResponse CreateMcubeMiniAppWithOptions(CreateMcubeMiniAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeMiniApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeMiniAppResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeMiniAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniAppResponse
        /// </returns>
        public async Task<CreateMcubeMiniAppResponse> CreateMcubeMiniAppWithOptionsAsync(CreateMcubeMiniAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeMiniApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeMiniAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeMiniAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniAppResponse
        /// </returns>
        public CreateMcubeMiniAppResponse CreateMcubeMiniApp(CreateMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeMiniAppWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeMiniAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniAppResponse
        /// </returns>
        public async Task<CreateMcubeMiniAppResponse> CreateMcubeMiniAppAsync(CreateMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeMiniAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeMiniTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniTaskResponse
        /// </returns>
        public CreateMcubeMiniTaskResponse CreateMcubeMiniTaskWithOptions(CreateMcubeMiniTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeMiniTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeMiniTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeMiniTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniTaskResponse
        /// </returns>
        public async Task<CreateMcubeMiniTaskResponse> CreateMcubeMiniTaskWithOptionsAsync(CreateMcubeMiniTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeMiniTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeMiniTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeMiniTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniTaskResponse
        /// </returns>
        public CreateMcubeMiniTaskResponse CreateMcubeMiniTask(CreateMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeMiniTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeMiniTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeMiniTaskResponse
        /// </returns>
        public async Task<CreateMcubeMiniTaskResponse> CreateMcubeMiniTaskAsync(CreateMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeMiniTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeNebulaAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaAppResponse
        /// </returns>
        public CreateMcubeNebulaAppResponse CreateMcubeNebulaAppWithOptions(CreateMcubeNebulaAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeNebulaApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeNebulaAppResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeNebulaAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaAppResponse
        /// </returns>
        public async Task<CreateMcubeNebulaAppResponse> CreateMcubeNebulaAppWithOptionsAsync(CreateMcubeNebulaAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeNebulaApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeNebulaAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeNebulaAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaAppResponse
        /// </returns>
        public CreateMcubeNebulaAppResponse CreateMcubeNebulaApp(CreateMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeNebulaAppWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeNebulaAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaAppResponse
        /// </returns>
        public async Task<CreateMcubeNebulaAppResponse> CreateMcubeNebulaAppAsync(CreateMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeNebulaAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeNebulaResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaResourceResponse
        /// </returns>
        public CreateMcubeNebulaResourceResponse CreateMcubeNebulaResourceWithOptions(CreateMcubeNebulaResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                body["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMax))
            {
                body["ClientVersionMax"] = request.ClientVersionMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMin))
            {
                body["ClientVersionMin"] = request.ClientVersionMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainName))
            {
                body["CustomDomainName"] = request.CustomDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Version))
            {
                body["H5Version"] = request.H5Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallType))
            {
                body["InstallType"] = request.InstallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainUrl))
            {
                body["MainUrl"] = request.MainUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatNebula))
            {
                body["RepeatNebula"] = request.RepeatNebula;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUrl))
            {
                body["SubUrl"] = request.SubUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                body["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeNebulaResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeNebulaResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeNebulaResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaResourceResponse
        /// </returns>
        public async Task<CreateMcubeNebulaResourceResponse> CreateMcubeNebulaResourceWithOptionsAsync(CreateMcubeNebulaResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                body["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMax))
            {
                body["ClientVersionMax"] = request.ClientVersionMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMin))
            {
                body["ClientVersionMin"] = request.ClientVersionMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainName))
            {
                body["CustomDomainName"] = request.CustomDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Version))
            {
                body["H5Version"] = request.H5Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallType))
            {
                body["InstallType"] = request.InstallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainUrl))
            {
                body["MainUrl"] = request.MainUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatNebula))
            {
                body["RepeatNebula"] = request.RepeatNebula;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUrl))
            {
                body["SubUrl"] = request.SubUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                body["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeNebulaResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeNebulaResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeNebulaResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaResourceResponse
        /// </returns>
        public CreateMcubeNebulaResourceResponse CreateMcubeNebulaResource(CreateMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeNebulaResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeNebulaResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaResourceResponse
        /// </returns>
        public async Task<CreateMcubeNebulaResourceResponse> CreateMcubeNebulaResourceAsync(CreateMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeNebulaResourceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeNebulaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaTaskResponse
        /// </returns>
        public CreateMcubeNebulaTaskResponse CreateMcubeNebulaTaskWithOptions(CreateMcubeNebulaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                body["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                body["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                body["GmtModified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedStr))
            {
                body["GmtModifiedStr"] = request.GmtModifiedStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtime))
            {
                body["GreyEndtime"] = request.GreyEndtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeStr))
            {
                body["GreyEndtimeStr"] = request.GreyEndtimeStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyUrl))
            {
                body["GreyUrl"] = request.GreyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                body["Modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Percent))
            {
                body["Percent"] = request.Percent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersion))
            {
                body["ProductVersion"] = request.ProductVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["ReleaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResIds))
            {
                body["ResIds"] = request.ResIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialVersionUID))
            {
                body["SerialVersionUID"] = request.SerialVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncMode))
            {
                body["SyncMode"] = request.SyncMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncResult))
            {
                body["SyncResult"] = request.SyncResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskVersion))
            {
                body["TaskVersion"] = request.TaskVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeNoticeNum))
            {
                body["UpgradeNoticeNum"] = request.UpgradeNoticeNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeProgress))
            {
                body["UpgradeProgress"] = request.UpgradeProgress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeNebulaTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeNebulaTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeNebulaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaTaskResponse
        /// </returns>
        public async Task<CreateMcubeNebulaTaskResponse> CreateMcubeNebulaTaskWithOptionsAsync(CreateMcubeNebulaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                body["AppCode"] = request.AppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                body["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                body["GmtModified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedStr))
            {
                body["GmtModifiedStr"] = request.GmtModifiedStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtime))
            {
                body["GreyEndtime"] = request.GreyEndtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeStr))
            {
                body["GreyEndtimeStr"] = request.GreyEndtimeStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyUrl))
            {
                body["GreyUrl"] = request.GreyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                body["Modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Percent))
            {
                body["Percent"] = request.Percent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersion))
            {
                body["ProductVersion"] = request.ProductVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["ReleaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResIds))
            {
                body["ResIds"] = request.ResIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialVersionUID))
            {
                body["SerialVersionUID"] = request.SerialVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncMode))
            {
                body["SyncMode"] = request.SyncMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncResult))
            {
                body["SyncResult"] = request.SyncResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskVersion))
            {
                body["TaskVersion"] = request.TaskVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeNoticeNum))
            {
                body["UpgradeNoticeNum"] = request.UpgradeNoticeNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeProgress))
            {
                body["UpgradeProgress"] = request.UpgradeProgress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeNebulaTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeNebulaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeNebulaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaTaskResponse
        /// </returns>
        public CreateMcubeNebulaTaskResponse CreateMcubeNebulaTask(CreateMcubeNebulaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeNebulaTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeNebulaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeNebulaTaskResponse
        /// </returns>
        public async Task<CreateMcubeNebulaTaskResponse> CreateMcubeNebulaTaskAsync(CreateMcubeNebulaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeNebulaTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeUpgradePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradePackageResponse
        /// </returns>
        public CreateMcubeUpgradePackageResponse CreateMcubeUpgradePackageWithOptions(CreateMcubeUpgradePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppstoreUrl))
            {
                body["AppstoreUrl"] = request.AppstoreUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainName))
            {
                body["CustomDomainName"] = request.CustomDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                body["DownloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyLabel))
            {
                body["HarmonyLabel"] = request.HarmonyLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconFileUrl))
            {
                body["IconFileUrl"] = request.IconFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallAmount))
            {
                body["InstallAmount"] = request.InstallAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosSymbolfileUrl))
            {
                body["IosSymbolfileUrl"] = request.IosSymbolfileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterprise))
            {
                body["IsEnterprise"] = request.IsEnterprise;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LargeIconUrl))
            {
                body["LargeIconUrl"] = request.LargeIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedCheck))
            {
                body["NeedCheck"] = request.NeedCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidDays))
            {
                body["ValidDays"] = request.ValidDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeUpgradePackage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeUpgradePackageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeUpgradePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradePackageResponse
        /// </returns>
        public async Task<CreateMcubeUpgradePackageResponse> CreateMcubeUpgradePackageWithOptionsAsync(CreateMcubeUpgradePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppstoreUrl))
            {
                body["AppstoreUrl"] = request.AppstoreUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                body["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainName))
            {
                body["CustomDomainName"] = request.CustomDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                body["DownloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmonyLabel))
            {
                body["HarmonyLabel"] = request.HarmonyLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconFileUrl))
            {
                body["IconFileUrl"] = request.IconFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallAmount))
            {
                body["InstallAmount"] = request.InstallAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosSymbolfileUrl))
            {
                body["IosSymbolfileUrl"] = request.IosSymbolfileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterprise))
            {
                body["IsEnterprise"] = request.IsEnterprise;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LargeIconUrl))
            {
                body["LargeIconUrl"] = request.LargeIconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedCheck))
            {
                body["NeedCheck"] = request.NeedCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidDays))
            {
                body["ValidDays"] = request.ValidDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeUpgradePackage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeUpgradePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeUpgradePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradePackageResponse
        /// </returns>
        public CreateMcubeUpgradePackageResponse CreateMcubeUpgradePackage(CreateMcubeUpgradePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeUpgradePackageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeUpgradePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradePackageResponse
        /// </returns>
        public async Task<CreateMcubeUpgradePackageResponse> CreateMcubeUpgradePackageAsync(CreateMcubeUpgradePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeUpgradePackageWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeUpgradeTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradeTaskResponse
        /// </returns>
        public CreateMcubeUpgradeTaskResponse CreateMcubeUpgradeTaskWithOptions(CreateMcubeUpgradeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryForce))
            {
                body["HistoryForce"] = request.HistoryForce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageInfoId))
            {
                body["PackageInfoId"] = request.PackageInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeContent))
            {
                body["UpgradeContent"] = request.UpgradeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeType))
            {
                body["UpgradeType"] = request.UpgradeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeUpgradeTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeUpgradeTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeUpgradeTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradeTaskResponse
        /// </returns>
        public async Task<CreateMcubeUpgradeTaskResponse> CreateMcubeUpgradeTaskWithOptionsAsync(CreateMcubeUpgradeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryForce))
            {
                body["HistoryForce"] = request.HistoryForce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageInfoId))
            {
                body["PackageInfoId"] = request.PackageInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeContent))
            {
                body["UpgradeContent"] = request.UpgradeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeType))
            {
                body["UpgradeType"] = request.UpgradeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeUpgradeTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeUpgradeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeUpgradeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradeTaskResponse
        /// </returns>
        public CreateMcubeUpgradeTaskResponse CreateMcubeUpgradeTask(CreateMcubeUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeUpgradeTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeUpgradeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeUpgradeTaskResponse
        /// </returns>
        public async Task<CreateMcubeUpgradeTaskResponse> CreateMcubeUpgradeTaskAsync(CreateMcubeUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeUpgradeTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeVhostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeVhostResponse
        /// </returns>
        public CreateMcubeVhostResponse CreateMcubeVhostWithOptions(CreateMcubeVhostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                body["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeVhost",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeVhostResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeVhostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeVhostResponse
        /// </returns>
        public async Task<CreateMcubeVhostResponse> CreateMcubeVhostWithOptionsAsync(CreateMcubeVhostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                body["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeVhost",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeVhostResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeVhostRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeVhostResponse
        /// </returns>
        public CreateMcubeVhostResponse CreateMcubeVhost(CreateMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeVhostWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeVhostRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeVhostResponse
        /// </returns>
        public async Task<CreateMcubeVhostResponse> CreateMcubeVhostAsync(CreateMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeVhostWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistResponse
        /// </returns>
        public CreateMcubeWhitelistResponse CreateMcubeWhitelistWithOptions(CreateMcubeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListName))
            {
                body["WhiteListName"] = request.WhiteListName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistType))
            {
                body["WhitelistType"] = request.WhitelistType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeWhitelist",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistResponse
        /// </returns>
        public async Task<CreateMcubeWhitelistResponse> CreateMcubeWhitelistWithOptionsAsync(CreateMcubeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListName))
            {
                body["WhiteListName"] = request.WhiteListName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistType))
            {
                body["WhitelistType"] = request.WhitelistType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeWhitelist",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistResponse
        /// </returns>
        public CreateMcubeWhitelistResponse CreateMcubeWhitelist(CreateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeWhitelistWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistResponse
        /// </returns>
        public async Task<CreateMcubeWhitelistResponse> CreateMcubeWhitelistAsync(CreateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeWhitelistWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeWhitelistForIdeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistForIdeResponse
        /// </returns>
        public CreateMcubeWhitelistForIdeResponse CreateMcubeWhitelistForIdeWithOptions(CreateMcubeWhitelistForIdeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistValue))
            {
                body["WhitelistValue"] = request.WhitelistValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeWhitelistForIde",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeWhitelistForIdeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeWhitelistForIdeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistForIdeResponse
        /// </returns>
        public async Task<CreateMcubeWhitelistForIdeResponse> CreateMcubeWhitelistForIdeWithOptionsAsync(CreateMcubeWhitelistForIdeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistValue))
            {
                body["WhitelistValue"] = request.WhitelistValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcubeWhitelistForIde",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcubeWhitelistForIdeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMcubeWhitelistForIdeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistForIdeResponse
        /// </returns>
        public CreateMcubeWhitelistForIdeResponse CreateMcubeWhitelistForIde(CreateMcubeWhitelistForIdeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeWhitelistForIdeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMcubeWhitelistForIdeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcubeWhitelistForIdeResponse
        /// </returns>
        public async Task<CreateMcubeWhitelistForIdeResponse> CreateMcubeWhitelistForIdeAsync(CreateMcubeWhitelistForIdeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeWhitelistForIdeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsCubeResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeResourceResponse
        /// </returns>
        public CreateMdsCubeResourceResponse CreateMdsCubeResourceWithOptions(CreateMdsCubeResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMaxVersion))
            {
                body["AndroidMaxVersion"] = request.AndroidMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMinVersion))
            {
                body["AndroidMinVersion"] = request.AndroidMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosMaxVersion))
            {
                body["IosMaxVersion"] = request.IosMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosMinVersion))
            {
                body["IosMinVersion"] = request.IosMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockDataUrl))
            {
                body["MockDataUrl"] = request.MockDataUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewPictureUrl))
            {
                body["PreviewPictureUrl"] = request.PreviewPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceDesc))
            {
                body["TemplateResourceDesc"] = request.TemplateResourceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceVersion))
            {
                body["TemplateResourceVersion"] = request.TemplateResourceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsCubeResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsCubeResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsCubeResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeResourceResponse
        /// </returns>
        public async Task<CreateMdsCubeResourceResponse> CreateMdsCubeResourceWithOptionsAsync(CreateMdsCubeResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMaxVersion))
            {
                body["AndroidMaxVersion"] = request.AndroidMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMinVersion))
            {
                body["AndroidMinVersion"] = request.AndroidMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosMaxVersion))
            {
                body["IosMaxVersion"] = request.IosMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosMinVersion))
            {
                body["IosMinVersion"] = request.IosMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockDataUrl))
            {
                body["MockDataUrl"] = request.MockDataUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewPictureUrl))
            {
                body["PreviewPictureUrl"] = request.PreviewPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceDesc))
            {
                body["TemplateResourceDesc"] = request.TemplateResourceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceVersion))
            {
                body["TemplateResourceVersion"] = request.TemplateResourceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsCubeResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsCubeResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsCubeResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeResourceResponse
        /// </returns>
        public CreateMdsCubeResourceResponse CreateMdsCubeResource(CreateMdsCubeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMdsCubeResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsCubeResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeResourceResponse
        /// </returns>
        public async Task<CreateMdsCubeResourceResponse> CreateMdsCubeResourceAsync(CreateMdsCubeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMdsCubeResourceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsCubeTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTaskResponse
        /// </returns>
        public CreateMdsCubeTaskResponse CreateMdsCubeTaskWithOptions(CreateMdsCubeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDesc))
            {
                body["TaskDesc"] = request.TaskDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsCubeTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsCubeTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsCubeTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTaskResponse
        /// </returns>
        public async Task<CreateMdsCubeTaskResponse> CreateMdsCubeTaskWithOptionsAsync(CreateMdsCubeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDesc))
            {
                body["TaskDesc"] = request.TaskDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsCubeTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsCubeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsCubeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTaskResponse
        /// </returns>
        public CreateMdsCubeTaskResponse CreateMdsCubeTask(CreateMdsCubeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMdsCubeTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsCubeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTaskResponse
        /// </returns>
        public async Task<CreateMdsCubeTaskResponse> CreateMdsCubeTaskAsync(CreateMdsCubeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMdsCubeTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsCubeTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTemplateResponse
        /// </returns>
        public CreateMdsCubeTemplateResponse CreateMdsCubeTemplateWithOptions(CreateMdsCubeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["TemplateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsCubeTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsCubeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsCubeTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTemplateResponse
        /// </returns>
        public async Task<CreateMdsCubeTemplateResponse> CreateMdsCubeTemplateWithOptionsAsync(CreateMdsCubeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["TemplateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsCubeTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsCubeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsCubeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTemplateResponse
        /// </returns>
        public CreateMdsCubeTemplateResponse CreateMdsCubeTemplate(CreateMdsCubeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMdsCubeTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsCubeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsCubeTemplateResponse
        /// </returns>
        public async Task<CreateMdsCubeTemplateResponse> CreateMdsCubeTemplateAsync(CreateMdsCubeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMdsCubeTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsMiniprogramTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsMiniprogramTaskResponse
        /// </returns>
        public CreateMdsMiniprogramTaskResponse CreateMdsMiniprogramTaskWithOptions(CreateMdsMiniprogramTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncMode))
            {
                body["SyncMode"] = request.SyncMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsMiniprogramTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsMiniprogramTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsMiniprogramTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsMiniprogramTaskResponse
        /// </returns>
        public async Task<CreateMdsMiniprogramTaskResponse> CreateMdsMiniprogramTaskWithOptionsAsync(CreateMdsMiniprogramTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyConfigInfo))
            {
                body["GreyConfigInfo"] = request.GreyConfigInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyEndtimeData))
            {
                body["GreyEndtimeData"] = request.GreyEndtimeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyNum))
            {
                body["GreyNum"] = request.GreyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["Memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishMode))
            {
                body["PublishMode"] = request.PublishMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishType))
            {
                body["PublishType"] = request.PublishType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncMode))
            {
                body["SyncMode"] = request.SyncMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistIds))
            {
                body["WhitelistIds"] = request.WhitelistIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMdsMiniprogramTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMdsMiniprogramTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMdsMiniprogramTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsMiniprogramTaskResponse
        /// </returns>
        public CreateMdsMiniprogramTaskResponse CreateMdsMiniprogramTask(CreateMdsMiniprogramTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMdsMiniprogramTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMdsMiniprogramTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMdsMiniprogramTaskResponse
        /// </returns>
        public async Task<CreateMdsMiniprogramTaskResponse> CreateMdsMiniprogramTaskAsync(CreateMdsMiniprogramTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMdsMiniprogramTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateOpenGlobalDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenGlobalDataResponse
        /// </returns>
        public CreateOpenGlobalDataResponse CreateOpenGlobalDataWithOptions(CreateOpenGlobalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMaxVersion))
            {
                body["AppMaxVersion"] = request.AppMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMinVersion))
            {
                body["AppMinVersion"] = request.AppMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtAttrStr))
            {
                body["ExtAttrStr"] = request.ExtAttrStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxUid))
            {
                body["MaxUid"] = request.MaxUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinUid))
            {
                body["MinUid"] = request.MinUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdMsgId))
            {
                body["ThirdMsgId"] = request.ThirdMsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uids))
            {
                body["Uids"] = request.Uids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeEnd))
            {
                body["ValidTimeEnd"] = request.ValidTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeStart))
            {
                body["ValidTimeStart"] = request.ValidTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpenGlobalData",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenGlobalDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateOpenGlobalDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenGlobalDataResponse
        /// </returns>
        public async Task<CreateOpenGlobalDataResponse> CreateOpenGlobalDataWithOptionsAsync(CreateOpenGlobalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMaxVersion))
            {
                body["AppMaxVersion"] = request.AppMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMinVersion))
            {
                body["AppMinVersion"] = request.AppMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtAttrStr))
            {
                body["ExtAttrStr"] = request.ExtAttrStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxUid))
            {
                body["MaxUid"] = request.MaxUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinUid))
            {
                body["MinUid"] = request.MinUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdMsgId))
            {
                body["ThirdMsgId"] = request.ThirdMsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uids))
            {
                body["Uids"] = request.Uids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeEnd))
            {
                body["ValidTimeEnd"] = request.ValidTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeStart))
            {
                body["ValidTimeStart"] = request.ValidTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpenGlobalData",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenGlobalDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateOpenGlobalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenGlobalDataResponse
        /// </returns>
        public CreateOpenGlobalDataResponse CreateOpenGlobalData(CreateOpenGlobalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOpenGlobalDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateOpenGlobalDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenGlobalDataResponse
        /// </returns>
        public async Task<CreateOpenGlobalDataResponse> CreateOpenGlobalDataAsync(CreateOpenGlobalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOpenGlobalDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateOpenSingleDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSingleDataResponse
        /// </returns>
        public CreateOpenSingleDataResponse CreateOpenSingleDataWithOptions(CreateOpenSingleDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMaxVersion))
            {
                body["AppMaxVersion"] = request.AppMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMinVersion))
            {
                body["AppMinVersion"] = request.AppMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOnline))
            {
                body["CheckOnline"] = request.CheckOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtAttrStr))
            {
                body["ExtAttrStr"] = request.ExtAttrStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkToken))
            {
                body["LinkToken"] = request.LinkToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdMsgId))
            {
                body["ThirdMsgId"] = request.ThirdMsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeEnd))
            {
                body["ValidTimeEnd"] = request.ValidTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeStart))
            {
                body["ValidTimeStart"] = request.ValidTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpenSingleData",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenSingleDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateOpenSingleDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSingleDataResponse
        /// </returns>
        public async Task<CreateOpenSingleDataResponse> CreateOpenSingleDataWithOptionsAsync(CreateOpenSingleDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMaxVersion))
            {
                body["AppMaxVersion"] = request.AppMaxVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppMinVersion))
            {
                body["AppMinVersion"] = request.AppMinVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOnline))
            {
                body["CheckOnline"] = request.CheckOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtAttrStr))
            {
                body["ExtAttrStr"] = request.ExtAttrStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkToken))
            {
                body["LinkToken"] = request.LinkToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdMsgId))
            {
                body["ThirdMsgId"] = request.ThirdMsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeEnd))
            {
                body["ValidTimeEnd"] = request.ValidTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTimeStart))
            {
                body["ValidTimeStart"] = request.ValidTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpenSingleData",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenSingleDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateOpenSingleDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSingleDataResponse
        /// </returns>
        public CreateOpenSingleDataResponse CreateOpenSingleData(CreateOpenSingleDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOpenSingleDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateOpenSingleDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSingleDataResponse
        /// </returns>
        public async Task<CreateOpenSingleDataResponse> CreateOpenSingleDataAsync(CreateOpenSingleDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOpenSingleDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescInfo))
            {
                body["DescInfo"] = request.DescInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrls))
            {
                body["IconUrls"] = request.IconUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["ImageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpAction))
            {
                body["JumpAction"] = request.JumpAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushStyle))
            {
                body["PushStyle"] = request.PushStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStyle))
            {
                body["ShowStyle"] = request.ShowStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["Variables"] = request.Variables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescInfo))
            {
                body["DescInfo"] = request.DescInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrls))
            {
                body["IconUrls"] = request.IconUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["ImageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpAction))
            {
                body["JumpAction"] = request.JumpAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushStyle))
            {
                body["PushStyle"] = request.PushStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStyle))
            {
                body["ShowStyle"] = request.ShowStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["Variables"] = request.Variables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteCubecardWhitelistContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCubecardWhitelistContentResponse
        /// </returns>
        public DeleteCubecardWhitelistContentResponse DeleteCubecardWhitelistContentWithOptions(DeleteCubecardWhitelistContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistId))
            {
                body["WhitelistId"] = request.WhitelistId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistValue))
            {
                body["WhitelistValue"] = request.WhitelistValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCubecardWhitelistContent",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCubecardWhitelistContentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCubecardWhitelistContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCubecardWhitelistContentResponse
        /// </returns>
        public async Task<DeleteCubecardWhitelistContentResponse> DeleteCubecardWhitelistContentWithOptionsAsync(DeleteCubecardWhitelistContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistId))
            {
                body["WhitelistId"] = request.WhitelistId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistValue))
            {
                body["WhitelistValue"] = request.WhitelistValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCubecardWhitelistContent",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCubecardWhitelistContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCubecardWhitelistContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCubecardWhitelistContentResponse
        /// </returns>
        public DeleteCubecardWhitelistContentResponse DeleteCubecardWhitelistContent(DeleteCubecardWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCubecardWhitelistContentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteCubecardWhitelistContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCubecardWhitelistContentResponse
        /// </returns>
        public async Task<DeleteCubecardWhitelistContentResponse> DeleteCubecardWhitelistContentAsync(DeleteCubecardWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCubecardWhitelistContentWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcdpAimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpAimResponse
        /// </returns>
        public DeleteMcdpAimResponse DeleteMcdpAimWithOptions(DeleteMcdpAimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpAimDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpAimDeleteJsonStr"] = request.MpaasMappcenterMcdpAimDeleteJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcdpAim",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpAimResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcdpAimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpAimResponse
        /// </returns>
        public async Task<DeleteMcdpAimResponse> DeleteMcdpAimWithOptionsAsync(DeleteMcdpAimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpAimDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpAimDeleteJsonStr"] = request.MpaasMappcenterMcdpAimDeleteJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcdpAim",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpAimResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcdpAimRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpAimResponse
        /// </returns>
        public DeleteMcdpAimResponse DeleteMcdpAim(DeleteMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpAimWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcdpAimRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpAimResponse
        /// </returns>
        public async Task<DeleteMcdpAimResponse> DeleteMcdpAimAsync(DeleteMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpAimWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcdpCrowdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpCrowdResponse
        /// </returns>
        public DeleteMcdpCrowdResponse DeleteMcdpCrowdWithOptions(DeleteMcdpCrowdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpCrowdDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpCrowdDeleteJsonStr"] = request.MpaasMappcenterMcdpCrowdDeleteJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcdpCrowd",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpCrowdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcdpCrowdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpCrowdResponse
        /// </returns>
        public async Task<DeleteMcdpCrowdResponse> DeleteMcdpCrowdWithOptionsAsync(DeleteMcdpCrowdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpCrowdDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpCrowdDeleteJsonStr"] = request.MpaasMappcenterMcdpCrowdDeleteJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcdpCrowd",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcdpCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpCrowdResponse
        /// </returns>
        public DeleteMcdpCrowdResponse DeleteMcdpCrowd(DeleteMcdpCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpCrowdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcdpCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpCrowdResponse
        /// </returns>
        public async Task<DeleteMcdpCrowdResponse> DeleteMcdpCrowdAsync(DeleteMcdpCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpCrowdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcdpZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpZoneResponse
        /// </returns>
        public DeleteMcdpZoneResponse DeleteMcdpZoneWithOptions(DeleteMcdpZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpZoneDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpZoneDeleteJsonStr"] = request.MpaasMappcenterMcdpZoneDeleteJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcdpZone",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpZoneResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcdpZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpZoneResponse
        /// </returns>
        public async Task<DeleteMcdpZoneResponse> DeleteMcdpZoneWithOptionsAsync(DeleteMcdpZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpZoneDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpZoneDeleteJsonStr"] = request.MpaasMappcenterMcdpZoneDeleteJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcdpZone",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcdpZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpZoneResponse
        /// </returns>
        public DeleteMcdpZoneResponse DeleteMcdpZone(DeleteMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpZoneWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcdpZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcdpZoneResponse
        /// </returns>
        public async Task<DeleteMcdpZoneResponse> DeleteMcdpZoneAsync(DeleteMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpZoneWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeMiniAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeMiniAppResponse
        /// </returns>
        public DeleteMcubeMiniAppResponse DeleteMcubeMiniAppWithOptions(DeleteMcubeMiniAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeMiniApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeMiniAppResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeMiniAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeMiniAppResponse
        /// </returns>
        public async Task<DeleteMcubeMiniAppResponse> DeleteMcubeMiniAppWithOptionsAsync(DeleteMcubeMiniAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeMiniApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeMiniAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeMiniAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeMiniAppResponse
        /// </returns>
        public DeleteMcubeMiniAppResponse DeleteMcubeMiniApp(DeleteMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeMiniAppWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeMiniAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeMiniAppResponse
        /// </returns>
        public async Task<DeleteMcubeMiniAppResponse> DeleteMcubeMiniAppAsync(DeleteMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeMiniAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeNebulaAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeNebulaAppResponse
        /// </returns>
        public DeleteMcubeNebulaAppResponse DeleteMcubeNebulaAppWithOptions(DeleteMcubeNebulaAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeNebulaApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeNebulaAppResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeNebulaAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeNebulaAppResponse
        /// </returns>
        public async Task<DeleteMcubeNebulaAppResponse> DeleteMcubeNebulaAppWithOptionsAsync(DeleteMcubeNebulaAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeNebulaApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeNebulaAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeNebulaAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeNebulaAppResponse
        /// </returns>
        public DeleteMcubeNebulaAppResponse DeleteMcubeNebulaApp(DeleteMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeNebulaAppWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeNebulaAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeNebulaAppResponse
        /// </returns>
        public async Task<DeleteMcubeNebulaAppResponse> DeleteMcubeNebulaAppAsync(DeleteMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeNebulaAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeUpgradeResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeUpgradeResourceResponse
        /// </returns>
        public DeleteMcubeUpgradeResourceResponse DeleteMcubeUpgradeResourceWithOptions(DeleteMcubeUpgradeResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeUpgradeResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeUpgradeResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeUpgradeResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeUpgradeResourceResponse
        /// </returns>
        public async Task<DeleteMcubeUpgradeResourceResponse> DeleteMcubeUpgradeResourceWithOptionsAsync(DeleteMcubeUpgradeResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeUpgradeResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeUpgradeResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeUpgradeResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeUpgradeResourceResponse
        /// </returns>
        public DeleteMcubeUpgradeResourceResponse DeleteMcubeUpgradeResource(DeleteMcubeUpgradeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeUpgradeResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeUpgradeResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeUpgradeResourceResponse
        /// </returns>
        public async Task<DeleteMcubeUpgradeResourceResponse> DeleteMcubeUpgradeResourceAsync(DeleteMcubeUpgradeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeUpgradeResourceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeWhitelistResponse
        /// </returns>
        public DeleteMcubeWhitelistResponse DeleteMcubeWhitelistWithOptions(DeleteMcubeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeWhitelist",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeWhitelistResponse
        /// </returns>
        public async Task<DeleteMcubeWhitelistResponse> DeleteMcubeWhitelistWithOptionsAsync(DeleteMcubeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcubeWhitelist",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcubeWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMcubeWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeWhitelistResponse
        /// </returns>
        public DeleteMcubeWhitelistResponse DeleteMcubeWhitelist(DeleteMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeWhitelistWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMcubeWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcubeWhitelistResponse
        /// </returns>
        public async Task<DeleteMcubeWhitelistResponse> DeleteMcubeWhitelistAsync(DeleteMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeWhitelistWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMdsCubeTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsCubeTemplateResponse
        /// </returns>
        public DeleteMdsCubeTemplateResponse DeleteMdsCubeTemplateWithOptions(DeleteMdsCubeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMdsCubeTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMdsCubeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMdsCubeTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsCubeTemplateResponse
        /// </returns>
        public async Task<DeleteMdsCubeTemplateResponse> DeleteMdsCubeTemplateWithOptionsAsync(DeleteMdsCubeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMdsCubeTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMdsCubeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMdsCubeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsCubeTemplateResponse
        /// </returns>
        public DeleteMdsCubeTemplateResponse DeleteMdsCubeTemplate(DeleteMdsCubeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMdsCubeTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMdsCubeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsCubeTemplateResponse
        /// </returns>
        public async Task<DeleteMdsCubeTemplateResponse> DeleteMdsCubeTemplateAsync(DeleteMdsCubeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMdsCubeTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMdsWhitelistContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsWhitelistContentResponse
        /// </returns>
        public DeleteMdsWhitelistContentResponse DeleteMdsWhitelistContentWithOptions(DeleteMdsWhitelistContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistId))
            {
                body["WhitelistId"] = request.WhitelistId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistValue))
            {
                body["WhitelistValue"] = request.WhitelistValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMdsWhitelistContent",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMdsWhitelistContentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMdsWhitelistContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsWhitelistContentResponse
        /// </returns>
        public async Task<DeleteMdsWhitelistContentResponse> DeleteMdsWhitelistContentWithOptionsAsync(DeleteMdsWhitelistContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistId))
            {
                body["WhitelistId"] = request.WhitelistId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistValue))
            {
                body["WhitelistValue"] = request.WhitelistValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMdsWhitelistContent",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMdsWhitelistContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMdsWhitelistContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsWhitelistContentResponse
        /// </returns>
        public DeleteMdsWhitelistContentResponse DeleteMdsWhitelistContent(DeleteMdsWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMdsWhitelistContentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMdsWhitelistContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMdsWhitelistContentResponse
        /// </returns>
        public async Task<DeleteMdsWhitelistContentResponse> DeleteMdsWhitelistContentAsync(DeleteMdsWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMdsWhitelistContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ExistMcubeRsaKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExistMcubeRsaKeyResponse
        /// </returns>
        public ExistMcubeRsaKeyResponse ExistMcubeRsaKeyWithOptions(ExistMcubeRsaKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExistMcubeRsaKey",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExistMcubeRsaKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ExistMcubeRsaKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExistMcubeRsaKeyResponse
        /// </returns>
        public async Task<ExistMcubeRsaKeyResponse> ExistMcubeRsaKeyWithOptionsAsync(ExistMcubeRsaKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExistMcubeRsaKey",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExistMcubeRsaKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ExistMcubeRsaKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ExistMcubeRsaKeyResponse
        /// </returns>
        public ExistMcubeRsaKeyResponse ExistMcubeRsaKey(ExistMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExistMcubeRsaKeyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ExistMcubeRsaKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ExistMcubeRsaKeyResponse
        /// </returns>
        public async Task<ExistMcubeRsaKeyResponse> ExistMcubeRsaKeyAsync(ExistMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExistMcubeRsaKeyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ExportMappCenterAppConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportMappCenterAppConfigResponse
        /// </returns>
        public ExportMappCenterAppConfigResponse ExportMappCenterAppConfigWithOptions(ExportMappCenterAppConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApkFileUrl))
            {
                body["ApkFileUrl"] = request.ApkFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRsaBase64))
            {
                body["CertRsaBase64"] = request.CertRsaBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportMappCenterAppConfig",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportMappCenterAppConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ExportMappCenterAppConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportMappCenterAppConfigResponse
        /// </returns>
        public async Task<ExportMappCenterAppConfigResponse> ExportMappCenterAppConfigWithOptionsAsync(ExportMappCenterAppConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApkFileUrl))
            {
                body["ApkFileUrl"] = request.ApkFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRsaBase64))
            {
                body["CertRsaBase64"] = request.CertRsaBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportMappCenterAppConfig",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportMappCenterAppConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ExportMappCenterAppConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportMappCenterAppConfigResponse
        /// </returns>
        public ExportMappCenterAppConfigResponse ExportMappCenterAppConfig(ExportMappCenterAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportMappCenterAppConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ExportMappCenterAppConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportMappCenterAppConfigResponse
        /// </returns>
        public async Task<ExportMappCenterAppConfigResponse> ExportMappCenterAppConfigAsync(ExportMappCenterAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportMappCenterAppConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetFileTokenForUploadToMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileTokenForUploadToMsaResponse
        /// </returns>
        public GetFileTokenForUploadToMsaResponse GetFileTokenForUploadToMsaWithOptions(GetFileTokenForUploadToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileTokenForUploadToMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileTokenForUploadToMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetFileTokenForUploadToMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileTokenForUploadToMsaResponse
        /// </returns>
        public async Task<GetFileTokenForUploadToMsaResponse> GetFileTokenForUploadToMsaWithOptionsAsync(GetFileTokenForUploadToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileTokenForUploadToMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileTokenForUploadToMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetFileTokenForUploadToMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileTokenForUploadToMsaResponse
        /// </returns>
        public GetFileTokenForUploadToMsaResponse GetFileTokenForUploadToMsa(GetFileTokenForUploadToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileTokenForUploadToMsaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetFileTokenForUploadToMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileTokenForUploadToMsaResponse
        /// </returns>
        public async Task<GetFileTokenForUploadToMsaResponse> GetFileTokenForUploadToMsaAsync(GetFileTokenForUploadToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileTokenForUploadToMsaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetLogUrlInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLogUrlInMsaResponse
        /// </returns>
        public GetLogUrlInMsaResponse GetLogUrlInMsaWithOptions(GetLogUrlInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogUrlInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogUrlInMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetLogUrlInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLogUrlInMsaResponse
        /// </returns>
        public async Task<GetLogUrlInMsaResponse> GetLogUrlInMsaWithOptionsAsync(GetLogUrlInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogUrlInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogUrlInMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetLogUrlInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLogUrlInMsaResponse
        /// </returns>
        public GetLogUrlInMsaResponse GetLogUrlInMsa(GetLogUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogUrlInMsaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetLogUrlInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLogUrlInMsaResponse
        /// </returns>
        public async Task<GetLogUrlInMsaResponse> GetLogUrlInMsaAsync(GetLogUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogUrlInMsaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeFileTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeFileTokenResponse
        /// </returns>
        public GetMcubeFileTokenResponse GetMcubeFileTokenWithOptions(GetMcubeFileTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeFileToken",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeFileTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeFileTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeFileTokenResponse
        /// </returns>
        public async Task<GetMcubeFileTokenResponse> GetMcubeFileTokenWithOptionsAsync(GetMcubeFileTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeFileToken",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeFileTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeFileTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeFileTokenResponse
        /// </returns>
        public GetMcubeFileTokenResponse GetMcubeFileToken(GetMcubeFileTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeFileTokenWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeFileTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeFileTokenResponse
        /// </returns>
        public async Task<GetMcubeFileTokenResponse> GetMcubeFileTokenAsync(GetMcubeFileTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeFileTokenWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeNebulaResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaResourceResponse
        /// </returns>
        public GetMcubeNebulaResourceResponse GetMcubeNebulaResourceWithOptions(GetMcubeNebulaResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeNebulaResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeNebulaResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeNebulaResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaResourceResponse
        /// </returns>
        public async Task<GetMcubeNebulaResourceResponse> GetMcubeNebulaResourceWithOptionsAsync(GetMcubeNebulaResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeNebulaResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeNebulaResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeNebulaResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaResourceResponse
        /// </returns>
        public GetMcubeNebulaResourceResponse GetMcubeNebulaResource(GetMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeNebulaResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeNebulaResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaResourceResponse
        /// </returns>
        public async Task<GetMcubeNebulaResourceResponse> GetMcubeNebulaResourceAsync(GetMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeNebulaResourceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeNebulaTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaTaskDetailResponse
        /// </returns>
        public GetMcubeNebulaTaskDetailResponse GetMcubeNebulaTaskDetailWithOptions(GetMcubeNebulaTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeNebulaTaskDetail",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeNebulaTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeNebulaTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaTaskDetailResponse
        /// </returns>
        public async Task<GetMcubeNebulaTaskDetailResponse> GetMcubeNebulaTaskDetailWithOptionsAsync(GetMcubeNebulaTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeNebulaTaskDetail",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeNebulaTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeNebulaTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaTaskDetailResponse
        /// </returns>
        public GetMcubeNebulaTaskDetailResponse GetMcubeNebulaTaskDetail(GetMcubeNebulaTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeNebulaTaskDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeNebulaTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeNebulaTaskDetailResponse
        /// </returns>
        public async Task<GetMcubeNebulaTaskDetailResponse> GetMcubeNebulaTaskDetailAsync(GetMcubeNebulaTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeNebulaTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeUpgradePackageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradePackageInfoResponse
        /// </returns>
        public GetMcubeUpgradePackageInfoResponse GetMcubeUpgradePackageInfoWithOptions(GetMcubeUpgradePackageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeUpgradePackageInfo",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeUpgradePackageInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeUpgradePackageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradePackageInfoResponse
        /// </returns>
        public async Task<GetMcubeUpgradePackageInfoResponse> GetMcubeUpgradePackageInfoWithOptionsAsync(GetMcubeUpgradePackageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeUpgradePackageInfo",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeUpgradePackageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeUpgradePackageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradePackageInfoResponse
        /// </returns>
        public GetMcubeUpgradePackageInfoResponse GetMcubeUpgradePackageInfo(GetMcubeUpgradePackageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeUpgradePackageInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeUpgradePackageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradePackageInfoResponse
        /// </returns>
        public async Task<GetMcubeUpgradePackageInfoResponse> GetMcubeUpgradePackageInfoAsync(GetMcubeUpgradePackageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeUpgradePackageInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeUpgradeTaskInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradeTaskInfoResponse
        /// </returns>
        public GetMcubeUpgradeTaskInfoResponse GetMcubeUpgradeTaskInfoWithOptions(GetMcubeUpgradeTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeUpgradeTaskInfo",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeUpgradeTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeUpgradeTaskInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradeTaskInfoResponse
        /// </returns>
        public async Task<GetMcubeUpgradeTaskInfoResponse> GetMcubeUpgradeTaskInfoWithOptionsAsync(GetMcubeUpgradeTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcubeUpgradeTaskInfo",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcubeUpgradeTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMcubeUpgradeTaskInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradeTaskInfoResponse
        /// </returns>
        public GetMcubeUpgradeTaskInfoResponse GetMcubeUpgradeTaskInfo(GetMcubeUpgradeTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeUpgradeTaskInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMcubeUpgradeTaskInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcubeUpgradeTaskInfoResponse
        /// </returns>
        public async Task<GetMcubeUpgradeTaskInfoResponse> GetMcubeUpgradeTaskInfoAsync(GetMcubeUpgradeTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeUpgradeTaskInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMdsMiniConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMdsMiniConfigResponse
        /// </returns>
        public GetMdsMiniConfigResponse GetMdsMiniConfigWithOptions(GetMdsMiniConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMdsMiniConfig",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMdsMiniConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMdsMiniConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMdsMiniConfigResponse
        /// </returns>
        public async Task<GetMdsMiniConfigResponse> GetMdsMiniConfigWithOptionsAsync(GetMdsMiniConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMdsMiniConfig",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMdsMiniConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMdsMiniConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMdsMiniConfigResponse
        /// </returns>
        public GetMdsMiniConfigResponse GetMdsMiniConfig(GetMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMdsMiniConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMdsMiniConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMdsMiniConfigResponse
        /// </returns>
        public async Task<GetMdsMiniConfigResponse> GetMdsMiniConfigAsync(GetMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMdsMiniConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetUserAppDonwloadUrlInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppDonwloadUrlInMsaResponse
        /// </returns>
        public GetUserAppDonwloadUrlInMsaResponse GetUserAppDonwloadUrlInMsaWithOptions(GetUserAppDonwloadUrlInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAppDonwloadUrlInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppDonwloadUrlInMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUserAppDonwloadUrlInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppDonwloadUrlInMsaResponse
        /// </returns>
        public async Task<GetUserAppDonwloadUrlInMsaResponse> GetUserAppDonwloadUrlInMsaWithOptionsAsync(GetUserAppDonwloadUrlInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAppDonwloadUrlInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppDonwloadUrlInMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUserAppDonwloadUrlInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppDonwloadUrlInMsaResponse
        /// </returns>
        public GetUserAppDonwloadUrlInMsaResponse GetUserAppDonwloadUrlInMsa(GetUserAppDonwloadUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserAppDonwloadUrlInMsaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetUserAppDonwloadUrlInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppDonwloadUrlInMsaResponse
        /// </returns>
        public async Task<GetUserAppDonwloadUrlInMsaResponse> GetUserAppDonwloadUrlInMsaAsync(GetUserAppDonwloadUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserAppDonwloadUrlInMsaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetUserAppEnhanceProcessInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppEnhanceProcessInMsaResponse
        /// </returns>
        public GetUserAppEnhanceProcessInMsaResponse GetUserAppEnhanceProcessInMsaWithOptions(GetUserAppEnhanceProcessInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAppEnhanceProcessInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppEnhanceProcessInMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUserAppEnhanceProcessInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppEnhanceProcessInMsaResponse
        /// </returns>
        public async Task<GetUserAppEnhanceProcessInMsaResponse> GetUserAppEnhanceProcessInMsaWithOptionsAsync(GetUserAppEnhanceProcessInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAppEnhanceProcessInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppEnhanceProcessInMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUserAppEnhanceProcessInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppEnhanceProcessInMsaResponse
        /// </returns>
        public GetUserAppEnhanceProcessInMsaResponse GetUserAppEnhanceProcessInMsa(GetUserAppEnhanceProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserAppEnhanceProcessInMsaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetUserAppEnhanceProcessInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppEnhanceProcessInMsaResponse
        /// </returns>
        public async Task<GetUserAppEnhanceProcessInMsaResponse> GetUserAppEnhanceProcessInMsaAsync(GetUserAppEnhanceProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserAppEnhanceProcessInMsaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetUserAppUploadProcessInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppUploadProcessInMsaResponse
        /// </returns>
        public GetUserAppUploadProcessInMsaResponse GetUserAppUploadProcessInMsaWithOptions(GetUserAppUploadProcessInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAppUploadProcessInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppUploadProcessInMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUserAppUploadProcessInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppUploadProcessInMsaResponse
        /// </returns>
        public async Task<GetUserAppUploadProcessInMsaResponse> GetUserAppUploadProcessInMsaWithOptionsAsync(GetUserAppUploadProcessInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAppUploadProcessInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAppUploadProcessInMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetUserAppUploadProcessInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppUploadProcessInMsaResponse
        /// </returns>
        public GetUserAppUploadProcessInMsaResponse GetUserAppUploadProcessInMsa(GetUserAppUploadProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserAppUploadProcessInMsaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetUserAppUploadProcessInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAppUploadProcessInMsaResponse
        /// </returns>
        public async Task<GetUserAppUploadProcessInMsaResponse> GetUserAppUploadProcessInMsaAsync(GetUserAppUploadProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserAppUploadProcessInMsaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisCoreIndexRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisCoreIndexResponse
        /// </returns>
        public ListAnalysisCoreIndexResponse ListAnalysisCoreIndexWithOptions(ListAnalysisCoreIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnalysisCoreIndex",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalysisCoreIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisCoreIndexRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisCoreIndexResponse
        /// </returns>
        public async Task<ListAnalysisCoreIndexResponse> ListAnalysisCoreIndexWithOptionsAsync(ListAnalysisCoreIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnalysisCoreIndex",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalysisCoreIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisCoreIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisCoreIndexResponse
        /// </returns>
        public ListAnalysisCoreIndexResponse ListAnalysisCoreIndex(ListAnalysisCoreIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnalysisCoreIndexWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisCoreIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisCoreIndexResponse
        /// </returns>
        public async Task<ListAnalysisCoreIndexResponse> ListAnalysisCoreIndexAsync(ListAnalysisCoreIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnalysisCoreIndexWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListCubecardAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCubecardAppsResponse
        /// </returns>
        public ListCubecardAppsResponse ListCubecardAppsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCubecardApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCubecardAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListCubecardAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCubecardAppsResponse
        /// </returns>
        public async Task<ListCubecardAppsResponse> ListCubecardAppsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCubecardApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCubecardAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListCubecardAppsResponse
        /// </returns>
        public ListCubecardAppsResponse ListCubecardApps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCubecardAppsWithOptions(runtime);
        }

        /// <returns>
        /// ListCubecardAppsResponse
        /// </returns>
        public async Task<ListCubecardAppsResponse> ListCubecardAppsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCubecardAppsWithOptionsAsync(runtime);
        }

        /// <param name="request">
        /// ListMappCenterAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMappCenterAppsResponse
        /// </returns>
        public ListMappCenterAppsResponse ListMappCenterAppsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMappCenterApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMappCenterAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMappCenterAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMappCenterAppsResponse
        /// </returns>
        public async Task<ListMappCenterAppsResponse> ListMappCenterAppsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMappCenterApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMappCenterAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListMappCenterAppsResponse
        /// </returns>
        public ListMappCenterAppsResponse ListMappCenterApps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMappCenterAppsWithOptions(runtime);
        }

        /// <returns>
        /// ListMappCenterAppsResponse
        /// </returns>
        public async Task<ListMappCenterAppsResponse> ListMappCenterAppsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMappCenterAppsWithOptionsAsync(runtime);
        }

        /// <param name="request">
        /// ListMappCenterWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMappCenterWorkspacesResponse
        /// </returns>
        public ListMappCenterWorkspacesResponse ListMappCenterWorkspacesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMappCenterWorkspaces",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMappCenterWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMappCenterWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMappCenterWorkspacesResponse
        /// </returns>
        public async Task<ListMappCenterWorkspacesResponse> ListMappCenterWorkspacesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMappCenterWorkspaces",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMappCenterWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListMappCenterWorkspacesResponse
        /// </returns>
        public ListMappCenterWorkspacesResponse ListMappCenterWorkspaces()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMappCenterWorkspacesWithOptions(runtime);
        }

        /// <returns>
        /// ListMappCenterWorkspacesResponse
        /// </returns>
        public async Task<ListMappCenterWorkspacesResponse> ListMappCenterWorkspacesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMappCenterWorkspacesWithOptionsAsync(runtime);
        }

        /// <param name="request">
        /// ListMcdpAimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcdpAimResponse
        /// </returns>
        public ListMcdpAimResponse ListMcdpAimWithOptions(ListMcdpAimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyTag))
            {
                body["EmptyTag"] = request.EmptyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcdpAim",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcdpAimResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcdpAimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcdpAimResponse
        /// </returns>
        public async Task<ListMcdpAimResponse> ListMcdpAimWithOptionsAsync(ListMcdpAimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmptyTag))
            {
                body["EmptyTag"] = request.EmptyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcdpAim",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcdpAimResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcdpAimRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcdpAimResponse
        /// </returns>
        public ListMcdpAimResponse ListMcdpAim(ListMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcdpAimWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcdpAimRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcdpAimResponse
        /// </returns>
        public async Task<ListMcdpAimResponse> ListMcdpAimAsync(ListMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcdpAimWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeMiniAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniAppsResponse
        /// </returns>
        public ListMcubeMiniAppsResponse ListMcubeMiniAppsWithOptions(ListMcubeMiniAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeMiniApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeMiniAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeMiniAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniAppsResponse
        /// </returns>
        public async Task<ListMcubeMiniAppsResponse> ListMcubeMiniAppsWithOptionsAsync(ListMcubeMiniAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeMiniApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeMiniAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeMiniAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniAppsResponse
        /// </returns>
        public ListMcubeMiniAppsResponse ListMcubeMiniApps(ListMcubeMiniAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeMiniAppsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeMiniAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniAppsResponse
        /// </returns>
        public async Task<ListMcubeMiniAppsResponse> ListMcubeMiniAppsAsync(ListMcubeMiniAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeMiniAppsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeMiniPackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniPackagesResponse
        /// </returns>
        public ListMcubeMiniPackagesResponse ListMcubeMiniPackagesWithOptions(ListMcubeMiniPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageTypes))
            {
                body["PackageTypes"] = request.PackageTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeMiniPackages",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeMiniPackagesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeMiniPackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniPackagesResponse
        /// </returns>
        public async Task<ListMcubeMiniPackagesResponse> ListMcubeMiniPackagesWithOptionsAsync(ListMcubeMiniPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageTypes))
            {
                body["PackageTypes"] = request.PackageTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeMiniPackages",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeMiniPackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeMiniPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniPackagesResponse
        /// </returns>
        public ListMcubeMiniPackagesResponse ListMcubeMiniPackages(ListMcubeMiniPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeMiniPackagesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeMiniPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniPackagesResponse
        /// </returns>
        public async Task<ListMcubeMiniPackagesResponse> ListMcubeMiniPackagesAsync(ListMcubeMiniPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeMiniPackagesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeMiniTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniTasksResponse
        /// </returns>
        public ListMcubeMiniTasksResponse ListMcubeMiniTasksWithOptions(ListMcubeMiniTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeMiniTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeMiniTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeMiniTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniTasksResponse
        /// </returns>
        public async Task<ListMcubeMiniTasksResponse> ListMcubeMiniTasksWithOptionsAsync(ListMcubeMiniTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeMiniTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeMiniTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeMiniTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniTasksResponse
        /// </returns>
        public ListMcubeMiniTasksResponse ListMcubeMiniTasks(ListMcubeMiniTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeMiniTasksWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeMiniTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeMiniTasksResponse
        /// </returns>
        public async Task<ListMcubeMiniTasksResponse> ListMcubeMiniTasksAsync(ListMcubeMiniTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeMiniTasksWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeNebulaAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaAppsResponse
        /// </returns>
        public ListMcubeNebulaAppsResponse ListMcubeNebulaAppsWithOptions(ListMcubeNebulaAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeNebulaApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeNebulaAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeNebulaAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaAppsResponse
        /// </returns>
        public async Task<ListMcubeNebulaAppsResponse> ListMcubeNebulaAppsWithOptionsAsync(ListMcubeNebulaAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeNebulaApps",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeNebulaAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeNebulaAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaAppsResponse
        /// </returns>
        public ListMcubeNebulaAppsResponse ListMcubeNebulaApps(ListMcubeNebulaAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeNebulaAppsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeNebulaAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaAppsResponse
        /// </returns>
        public async Task<ListMcubeNebulaAppsResponse> ListMcubeNebulaAppsAsync(ListMcubeNebulaAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeNebulaAppsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeNebulaResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaResourcesResponse
        /// </returns>
        public ListMcubeNebulaResourcesResponse ListMcubeNebulaResourcesWithOptions(ListMcubeNebulaResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeNebulaResources",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeNebulaResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeNebulaResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaResourcesResponse
        /// </returns>
        public async Task<ListMcubeNebulaResourcesResponse> ListMcubeNebulaResourcesWithOptionsAsync(ListMcubeNebulaResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeNebulaResources",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeNebulaResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeNebulaResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaResourcesResponse
        /// </returns>
        public ListMcubeNebulaResourcesResponse ListMcubeNebulaResources(ListMcubeNebulaResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeNebulaResourcesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeNebulaResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaResourcesResponse
        /// </returns>
        public async Task<ListMcubeNebulaResourcesResponse> ListMcubeNebulaResourcesAsync(ListMcubeNebulaResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeNebulaResourcesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeNebulaTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaTasksResponse
        /// </returns>
        public ListMcubeNebulaTasksResponse ListMcubeNebulaTasksWithOptions(ListMcubeNebulaTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeNebulaTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeNebulaTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeNebulaTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaTasksResponse
        /// </returns>
        public async Task<ListMcubeNebulaTasksResponse> ListMcubeNebulaTasksWithOptionsAsync(ListMcubeNebulaTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeNebulaTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeNebulaTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeNebulaTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaTasksResponse
        /// </returns>
        public ListMcubeNebulaTasksResponse ListMcubeNebulaTasks(ListMcubeNebulaTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeNebulaTasksWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeNebulaTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeNebulaTasksResponse
        /// </returns>
        public async Task<ListMcubeNebulaTasksResponse> ListMcubeNebulaTasksAsync(ListMcubeNebulaTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeNebulaTasksWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeUpgradePackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradePackagesResponse
        /// </returns>
        public ListMcubeUpgradePackagesResponse ListMcubeUpgradePackagesWithOptions(ListMcubeUpgradePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeUpgradePackages",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeUpgradePackagesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeUpgradePackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradePackagesResponse
        /// </returns>
        public async Task<ListMcubeUpgradePackagesResponse> ListMcubeUpgradePackagesWithOptionsAsync(ListMcubeUpgradePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeUpgradePackages",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeUpgradePackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeUpgradePackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradePackagesResponse
        /// </returns>
        public ListMcubeUpgradePackagesResponse ListMcubeUpgradePackages(ListMcubeUpgradePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeUpgradePackagesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeUpgradePackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradePackagesResponse
        /// </returns>
        public async Task<ListMcubeUpgradePackagesResponse> ListMcubeUpgradePackagesAsync(ListMcubeUpgradePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeUpgradePackagesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeUpgradeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradeTasksResponse
        /// </returns>
        public ListMcubeUpgradeTasksResponse ListMcubeUpgradeTasksWithOptions(ListMcubeUpgradeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeUpgradeTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeUpgradeTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeUpgradeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradeTasksResponse
        /// </returns>
        public async Task<ListMcubeUpgradeTasksResponse> ListMcubeUpgradeTasksWithOptionsAsync(ListMcubeUpgradeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                body["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeUpgradeTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeUpgradeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeUpgradeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradeTasksResponse
        /// </returns>
        public ListMcubeUpgradeTasksResponse ListMcubeUpgradeTasks(ListMcubeUpgradeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeUpgradeTasksWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeUpgradeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeUpgradeTasksResponse
        /// </returns>
        public async Task<ListMcubeUpgradeTasksResponse> ListMcubeUpgradeTasksAsync(ListMcubeUpgradeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeUpgradeTasksWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeWhitelistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeWhitelistsResponse
        /// </returns>
        public ListMcubeWhitelistsResponse ListMcubeWhitelistsWithOptions(ListMcubeWhitelistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistName))
            {
                body["WhitelistName"] = request.WhitelistName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeWhitelists",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeWhitelistsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeWhitelistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeWhitelistsResponse
        /// </returns>
        public async Task<ListMcubeWhitelistsResponse> ListMcubeWhitelistsWithOptionsAsync(ListMcubeWhitelistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistName))
            {
                body["WhitelistName"] = request.WhitelistName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcubeWhitelists",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcubeWhitelistsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMcubeWhitelistsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeWhitelistsResponse
        /// </returns>
        public ListMcubeWhitelistsResponse ListMcubeWhitelists(ListMcubeWhitelistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeWhitelistsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMcubeWhitelistsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcubeWhitelistsResponse
        /// </returns>
        public async Task<ListMcubeWhitelistsResponse> ListMcubeWhitelistsAsync(ListMcubeWhitelistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeWhitelistsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMdsCubeResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeResourcesResponse
        /// </returns>
        public ListMdsCubeResourcesResponse ListMdsCubeResourcesWithOptions(ListMdsCubeResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                body["test"] = request.Test;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMdsCubeResources",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMdsCubeResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMdsCubeResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeResourcesResponse
        /// </returns>
        public async Task<ListMdsCubeResourcesResponse> ListMdsCubeResourcesWithOptionsAsync(ListMdsCubeResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                body["test"] = request.Test;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMdsCubeResources",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMdsCubeResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMdsCubeResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeResourcesResponse
        /// </returns>
        public ListMdsCubeResourcesResponse ListMdsCubeResources(ListMdsCubeResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMdsCubeResourcesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMdsCubeResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeResourcesResponse
        /// </returns>
        public async Task<ListMdsCubeResourcesResponse> ListMdsCubeResourcesAsync(ListMdsCubeResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMdsCubeResourcesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMdsCubeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTasksResponse
        /// </returns>
        public ListMdsCubeTasksResponse ListMdsCubeTasksWithOptions(ListMdsCubeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMdsCubeTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMdsCubeTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMdsCubeTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTasksResponse
        /// </returns>
        public async Task<ListMdsCubeTasksResponse> ListMdsCubeTasksWithOptionsAsync(ListMdsCubeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMdsCubeTasks",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMdsCubeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMdsCubeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTasksResponse
        /// </returns>
        public ListMdsCubeTasksResponse ListMdsCubeTasks(ListMdsCubeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMdsCubeTasksWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMdsCubeTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTasksResponse
        /// </returns>
        public async Task<ListMdsCubeTasksResponse> ListMdsCubeTasksAsync(ListMdsCubeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMdsCubeTasksWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMdsCubeTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTemplatesResponse
        /// </returns>
        public ListMdsCubeTemplatesResponse ListMdsCubeTemplatesWithOptions(ListMdsCubeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMdsCubeTemplates",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMdsCubeTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMdsCubeTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTemplatesResponse
        /// </returns>
        public async Task<ListMdsCubeTemplatesResponse> ListMdsCubeTemplatesWithOptionsAsync(ListMdsCubeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMdsCubeTemplates",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMdsCubeTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMdsCubeTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTemplatesResponse
        /// </returns>
        public ListMdsCubeTemplatesResponse ListMdsCubeTemplates(ListMdsCubeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMdsCubeTemplatesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMdsCubeTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMdsCubeTemplatesResponse
        /// </returns>
        public async Task<ListMdsCubeTemplatesResponse> ListMdsCubeTemplatesAsync(ListMdsCubeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMdsCubeTemplatesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMgsApiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMgsApiResponse
        /// </returns>
        public ListMgsApiResponse ListMgsApiWithOptions(ListMgsApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiStatus))
            {
                body["ApiStatus"] = request.ApiStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEncrypt))
            {
                body["NeedEncrypt"] = request.NeedEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEtag))
            {
                body["NeedEtag"] = request.NeedEtag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSign))
            {
                body["NeedSign"] = request.NeedSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptFuzzy))
            {
                body["OptFuzzy"] = request.OptFuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysId))
            {
                body["SysId"] = request.SysId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysName))
            {
                body["SysName"] = request.SysName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMgsApi",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMgsApiResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMgsApiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMgsApiResponse
        /// </returns>
        public async Task<ListMgsApiResponse> ListMgsApiWithOptionsAsync(ListMgsApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiStatus))
            {
                body["ApiStatus"] = request.ApiStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEncrypt))
            {
                body["NeedEncrypt"] = request.NeedEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEtag))
            {
                body["NeedEtag"] = request.NeedEtag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSign))
            {
                body["NeedSign"] = request.NeedSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptFuzzy))
            {
                body["OptFuzzy"] = request.OptFuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysId))
            {
                body["SysId"] = request.SysId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysName))
            {
                body["SysName"] = request.SysName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMgsApi",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMgsApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMgsApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMgsApiResponse
        /// </returns>
        public ListMgsApiResponse ListMgsApi(ListMgsApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMgsApiWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMgsApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMgsApiResponse
        /// </returns>
        public async Task<ListMgsApiResponse> ListMgsApiAsync(ListMgsApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMgsApiWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatePageResponse
        /// </returns>
        public ListTemplatePageResponse ListTemplatePageWithOptions(ListTemplatePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplatePage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatePageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatePageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatePageResponse
        /// </returns>
        public async Task<ListTemplatePageResponse> ListTemplatePageWithOptionsAsync(ListTemplatePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplatePage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatePageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatePageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatePageResponse
        /// </returns>
        public ListTemplatePageResponse ListTemplatePage(ListTemplatePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatePageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatePageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatePageResponse
        /// </returns>
        public async Task<ListTemplatePageResponse> ListTemplatePageAsync(ListTemplatePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatePageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OCR通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MTRSOCRServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MTRSOCRServiceResponse
        /// </returns>
        public MTRSOCRServiceResponse MTRSOCRServiceWithOptions(MTRSOCRServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRaw))
            {
                body["ImageRaw"] = request.ImageRaw;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                body["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MTRSOCRService",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MTRSOCRServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OCR通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MTRSOCRServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MTRSOCRServiceResponse
        /// </returns>
        public async Task<MTRSOCRServiceResponse> MTRSOCRServiceWithOptionsAsync(MTRSOCRServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRaw))
            {
                body["ImageRaw"] = request.ImageRaw;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                body["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MTRSOCRService",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MTRSOCRServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OCR通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MTRSOCRServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// MTRSOCRServiceResponse
        /// </returns>
        public MTRSOCRServiceResponse MTRSOCRService(MTRSOCRServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MTRSOCRServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>OCR通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MTRSOCRServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// MTRSOCRServiceResponse
        /// </returns>
        public async Task<MTRSOCRServiceResponse> MTRSOCRServiceAsync(MTRSOCRServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MTRSOCRServiceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PushBindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushBindResponse
        /// </returns>
        public PushBindResponse PushBindWithOptions(PushBindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryToken))
            {
                body["DeliveryToken"] = request.DeliveryToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushBind",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushBindResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PushBindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushBindResponse
        /// </returns>
        public async Task<PushBindResponse> PushBindWithOptionsAsync(PushBindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryToken))
            {
                body["DeliveryToken"] = request.DeliveryToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushBind",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushBindResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PushBindRequest
        /// </param>
        /// 
        /// <returns>
        /// PushBindResponse
        /// </returns>
        public PushBindResponse PushBind(PushBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushBindWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PushBindRequest
        /// </param>
        /// 
        /// <returns>
        /// PushBindResponse
        /// </returns>
        public async Task<PushBindResponse> PushBindAsync(PushBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushBindWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// PushBroadcastRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushBroadcastResponse
        /// </returns>
        public PushBroadcastResponse PushBroadcastWithOptions(PushBroadcastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushBroadcastShrinkRequest request = new PushBroadcastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidChannel))
            {
                body["AndroidChannel"] = request.AndroidChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindEndTime))
            {
                body["BindEndTime"] = request.BindEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindPeriod))
            {
                body["BindPeriod"] = request.BindPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindStartTime))
            {
                body["BindStartTime"] = request.BindStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgkey))
            {
                body["Msgkey"] = request.Msgkey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushStatus))
            {
                body["PushStatus"] = request.PushStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeyValue))
            {
                body["TemplateKeyValue"] = request.TemplateKeyValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMode))
            {
                body["TimeMode"] = request.TimeMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindEndTime))
            {
                body["UnBindEndTime"] = request.UnBindEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindPeriod))
            {
                body["UnBindPeriod"] = request.UnBindPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindStartTime))
            {
                body["UnBindStartTime"] = request.UnBindStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushBroadcast",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushBroadcastResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// PushBroadcastRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushBroadcastResponse
        /// </returns>
        public async Task<PushBroadcastResponse> PushBroadcastWithOptionsAsync(PushBroadcastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushBroadcastShrinkRequest request = new PushBroadcastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidChannel))
            {
                body["AndroidChannel"] = request.AndroidChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindEndTime))
            {
                body["BindEndTime"] = request.BindEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindPeriod))
            {
                body["BindPeriod"] = request.BindPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindStartTime))
            {
                body["BindStartTime"] = request.BindStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msgkey))
            {
                body["Msgkey"] = request.Msgkey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushStatus))
            {
                body["PushStatus"] = request.PushStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeyValue))
            {
                body["TemplateKeyValue"] = request.TemplateKeyValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeMode))
            {
                body["TimeMode"] = request.TimeMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindEndTime))
            {
                body["UnBindEndTime"] = request.UnBindEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindPeriod))
            {
                body["UnBindPeriod"] = request.UnBindPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindStartTime))
            {
                body["UnBindStartTime"] = request.UnBindStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushBroadcast",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushBroadcastResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PushBroadcastRequest
        /// </param>
        /// 
        /// <returns>
        /// PushBroadcastResponse
        /// </returns>
        public PushBroadcastResponse PushBroadcast(PushBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushBroadcastWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PushBroadcastRequest
        /// </param>
        /// 
        /// <returns>
        /// PushBroadcastResponse
        /// </returns>
        public async Task<PushBroadcastResponse> PushBroadcastAsync(PushBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushBroadcastWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// PushMultipleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMultipleResponse
        /// </returns>
        public PushMultipleResponse PushMultipleWithOptions(PushMultipleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushMultipleShrinkRequest request = new PushMultipleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityContentState))
            {
                body["ActivityContentState"] = request.ActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEvent))
            {
                body["ActivityEvent"] = request.ActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissalDate))
            {
                body["DismissalDate"] = request.DismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetMsg))
            {
                body["TargetMsg"] = request.TargetMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMultiple",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMultipleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// PushMultipleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMultipleResponse
        /// </returns>
        public async Task<PushMultipleResponse> PushMultipleWithOptionsAsync(PushMultipleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushMultipleShrinkRequest request = new PushMultipleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityContentState))
            {
                body["ActivityContentState"] = request.ActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEvent))
            {
                body["ActivityEvent"] = request.ActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissalDate))
            {
                body["DismissalDate"] = request.DismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetMsg))
            {
                body["TargetMsg"] = request.TargetMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMultiple",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMultipleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PushMultipleRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMultipleResponse
        /// </returns>
        public PushMultipleResponse PushMultiple(PushMultipleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMultipleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PushMultipleRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMultipleResponse
        /// </returns>
        public async Task<PushMultipleResponse> PushMultipleAsync(PushMultipleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMultipleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushQueryDeviceStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushQueryDeviceStateResponse
        /// </returns>
        public PushQueryDeviceStateResponse PushQueryDeviceStateWithOptions(PushQueryDeviceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushQueryDeviceState",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushQueryDeviceStateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushQueryDeviceStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushQueryDeviceStateResponse
        /// </returns>
        public async Task<PushQueryDeviceStateResponse> PushQueryDeviceStateWithOptionsAsync(PushQueryDeviceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushQueryDeviceState",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushQueryDeviceStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushQueryDeviceStateRequest
        /// </param>
        /// 
        /// <returns>
        /// PushQueryDeviceStateResponse
        /// </returns>
        public PushQueryDeviceStateResponse PushQueryDeviceState(PushQueryDeviceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushQueryDeviceStateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备状态信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushQueryDeviceStateRequest
        /// </param>
        /// 
        /// <returns>
        /// PushQueryDeviceStateResponse
        /// </returns>
        public async Task<PushQueryDeviceStateResponse> PushQueryDeviceStateAsync(PushQueryDeviceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushQueryDeviceStateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PushReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushReportResponse
        /// </returns>
        public PushReportResponse PushReportWithOptions(PushReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectType))
            {
                body["ConnectType"] = request.ConnectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryToken))
            {
                body["DeliveryToken"] = request.DeliveryToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                body["Imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imsi))
            {
                body["Imsi"] = request.Imsi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushVersion))
            {
                body["PushVersion"] = request.PushVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannel))
            {
                body["ThirdChannel"] = request.ThirdChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelDeviceToken))
            {
                body["ThirdChannelDeviceToken"] = request.ThirdChannelDeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushReport",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushReportResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PushReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushReportResponse
        /// </returns>
        public async Task<PushReportResponse> PushReportWithOptionsAsync(PushReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectType))
            {
                body["ConnectType"] = request.ConnectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryToken))
            {
                body["DeliveryToken"] = request.DeliveryToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                body["Imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imsi))
            {
                body["Imsi"] = request.Imsi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushVersion))
            {
                body["PushVersion"] = request.PushVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannel))
            {
                body["ThirdChannel"] = request.ThirdChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelDeviceToken))
            {
                body["ThirdChannelDeviceToken"] = request.ThirdChannelDeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushReport",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PushReportRequest
        /// </param>
        /// 
        /// <returns>
        /// PushReportResponse
        /// </returns>
        public PushReportResponse PushReport(PushReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushReportWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PushReportRequest
        /// </param>
        /// 
        /// <returns>
        /// PushReportResponse
        /// </returns>
        public async Task<PushReportResponse> PushReportAsync(PushReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>极简推送</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushSimpleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushSimpleResponse
        /// </returns>
        public PushSimpleResponse PushSimpleWithOptions(PushSimpleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushSimpleShrinkRequest request = new PushSimpleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityContentState))
            {
                body["ActivityContentState"] = request.ActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEvent))
            {
                body["ActivityEvent"] = request.ActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissalDate))
            {
                body["DismissalDate"] = request.DismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrls))
            {
                body["IconUrls"] = request.IconUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["ImageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushStyle))
            {
                body["PushStyle"] = request.PushStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                body["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsStrategy))
            {
                body["SmsStrategy"] = request.SmsStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                body["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParam))
            {
                body["SmsTemplateParam"] = request.SmsTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetMsgkey))
            {
                body["TargetMsgkey"] = request.TargetMsgkey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushSimple",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushSimpleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>极简推送</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushSimpleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushSimpleResponse
        /// </returns>
        public async Task<PushSimpleResponse> PushSimpleWithOptionsAsync(PushSimpleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushSimpleShrinkRequest request = new PushSimpleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityContentState))
            {
                body["ActivityContentState"] = request.ActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEvent))
            {
                body["ActivityEvent"] = request.ActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissalDate))
            {
                body["DismissalDate"] = request.DismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrls))
            {
                body["IconUrls"] = request.IconUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["ImageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushStyle))
            {
                body["PushStyle"] = request.PushStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                body["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsStrategy))
            {
                body["SmsStrategy"] = request.SmsStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                body["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParam))
            {
                body["SmsTemplateParam"] = request.SmsTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetMsgkey))
            {
                body["TargetMsgkey"] = request.TargetMsgkey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushSimple",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushSimpleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>极简推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushSimpleRequest
        /// </param>
        /// 
        /// <returns>
        /// PushSimpleResponse
        /// </returns>
        public PushSimpleResponse PushSimple(PushSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushSimpleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>极简推送</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushSimpleRequest
        /// </param>
        /// 
        /// <returns>
        /// PushSimpleResponse
        /// </returns>
        public async Task<PushSimpleResponse> PushSimpleAsync(PushSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushSimpleWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// PushTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushTemplateResponse
        /// </returns>
        public PushTemplateResponse PushTemplateWithOptions(PushTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushTemplateShrinkRequest request = new PushTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityContentState))
            {
                body["ActivityContentState"] = request.ActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEvent))
            {
                body["ActivityEvent"] = request.ActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissalDate))
            {
                body["DismissalDate"] = request.DismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                body["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsStrategy))
            {
                body["SmsStrategy"] = request.SmsStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                body["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParam))
            {
                body["SmsTemplateParam"] = request.SmsTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetMsgkey))
            {
                body["TargetMsgkey"] = request.TargetMsgkey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeyValue))
            {
                body["TemplateKeyValue"] = request.TemplateKeyValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// PushTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushTemplateResponse
        /// </returns>
        public async Task<PushTemplateResponse> PushTemplateWithOptionsAsync(PushTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushTemplateShrinkRequest request = new PushTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyLevel))
            {
                request.NotifyLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyLevel, "NotifyLevel", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ThirdChannelCategory))
            {
                request.ThirdChannelCategoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ThirdChannelCategory, "ThirdChannelCategory", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityContentState))
            {
                body["ActivityContentState"] = request.ActivityContentState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEvent))
            {
                body["ActivityEvent"] = request.ActivityEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                body["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DismissalDate))
            {
                body["DismissalDate"] = request.DismissalDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredSeconds))
            {
                body["ExpiredSeconds"] = request.ExpiredSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedParams))
            {
                body["ExtendedParams"] = request.ExtendedParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiChannelId))
            {
                body["MiChannelId"] = request.MiChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevelShrink))
            {
                body["NotifyLevel"] = request.NotifyLevelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                body["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAction))
            {
                body["PushAction"] = request.PushAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Silent))
            {
                body["Silent"] = request.Silent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                body["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsStrategy))
            {
                body["SmsStrategy"] = request.SmsStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                body["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateParam))
            {
                body["SmsTemplateParam"] = request.SmsTemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                body["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                body["StrategyType"] = request.StrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetMsgkey))
            {
                body["TargetMsgkey"] = request.TargetMsgkey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeyValue))
            {
                body["TemplateKeyValue"] = request.TemplateKeyValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessagePayload))
            {
                body["TransparentMessagePayload"] = request.TransparentMessagePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentMessageUrgency))
            {
                body["TransparentMessageUrgency"] = request.TransparentMessageUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushTemplate",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PushTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PushTemplateResponse
        /// </returns>
        public PushTemplateResponse PushTemplate(PushTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PushTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PushTemplateResponse
        /// </returns>
        public async Task<PushTemplateResponse> PushTemplateAsync(PushTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PushUnBindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushUnBindResponse
        /// </returns>
        public PushUnBindResponse PushUnBindWithOptions(PushUnBindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryToken))
            {
                body["DeliveryToken"] = request.DeliveryToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushUnBind",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushUnBindResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PushUnBindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushUnBindResponse
        /// </returns>
        public async Task<PushUnBindResponse> PushUnBindWithOptionsAsync(PushUnBindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryToken))
            {
                body["DeliveryToken"] = request.DeliveryToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushUnBind",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushUnBindResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PushUnBindRequest
        /// </param>
        /// 
        /// <returns>
        /// PushUnBindResponse
        /// </returns>
        public PushUnBindResponse PushUnBind(PushUnBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushUnBindWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PushUnBindRequest
        /// </param>
        /// 
        /// <returns>
        /// PushUnBindResponse
        /// </returns>
        public async Task<PushUnBindResponse> PushUnBindAsync(PushUnBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushUnBindWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryCubecardFiletokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCubecardFiletokenResponse
        /// </returns>
        public QueryCubecardFiletokenResponse QueryCubecardFiletokenWithOptions(QueryCubecardFiletokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCubecardFiletoken",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCubecardFiletokenResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCubecardFiletokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCubecardFiletokenResponse
        /// </returns>
        public async Task<QueryCubecardFiletokenResponse> QueryCubecardFiletokenWithOptionsAsync(QueryCubecardFiletokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCubecardFiletoken",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCubecardFiletokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCubecardFiletokenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCubecardFiletokenResponse
        /// </returns>
        public QueryCubecardFiletokenResponse QueryCubecardFiletoken(QueryCubecardFiletokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCubecardFiletokenWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryCubecardFiletokenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCubecardFiletokenResponse
        /// </returns>
        public async Task<QueryCubecardFiletokenResponse> QueryCubecardFiletokenAsync(QueryCubecardFiletokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCubecardFiletokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Device+服务的</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInfoFromMdpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInfoFromMdpResponse
        /// </returns>
        public QueryInfoFromMdpResponse QueryInfoFromMdpWithOptions(QueryInfoFromMdpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileMd5))
            {
                body["MobileMd5"] = request.MobileMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileSha256))
            {
                body["MobileSha256"] = request.MobileSha256;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileSm3))
            {
                body["MobileSm3"] = request.MobileSm3;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskScene))
            {
                body["RiskScene"] = request.RiskScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInfoFromMdp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInfoFromMdpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Device+服务的</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInfoFromMdpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInfoFromMdpResponse
        /// </returns>
        public async Task<QueryInfoFromMdpResponse> QueryInfoFromMdpWithOptionsAsync(QueryInfoFromMdpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileMd5))
            {
                body["MobileMd5"] = request.MobileMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileSha256))
            {
                body["MobileSha256"] = request.MobileSha256;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileSm3))
            {
                body["MobileSm3"] = request.MobileSm3;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskScene))
            {
                body["RiskScene"] = request.RiskScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInfoFromMdp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInfoFromMdpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Device+服务的</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInfoFromMdpRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInfoFromMdpResponse
        /// </returns>
        public QueryInfoFromMdpResponse QueryInfoFromMdp(QueryInfoFromMdpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInfoFromMdpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Device+服务的</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInfoFromMdpRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInfoFromMdpResponse
        /// </returns>
        public async Task<QueryInfoFromMdpResponse> QueryInfoFromMdpAsync(QueryInfoFromMdpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInfoFromMdpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLinkResponse
        /// </returns>
        public QueryLinkResponse QueryLinkWithOptions(QueryLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLink",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLinkResponse
        /// </returns>
        public async Task<QueryLinkResponse> QueryLinkWithOptionsAsync(QueryLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLink",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLinkResponse
        /// </returns>
        public QueryLinkResponse QueryLink(QueryLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLinkResponse
        /// </returns>
        public async Task<QueryLinkResponse> QueryLinkAsync(QueryLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLinkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMappCenterAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMappCenterAppResponse
        /// </returns>
        public QueryMappCenterAppResponse QueryMappCenterAppWithOptions(QueryMappCenterAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMappCenterApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMappCenterAppResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMappCenterAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMappCenterAppResponse
        /// </returns>
        public async Task<QueryMappCenterAppResponse> QueryMappCenterAppWithOptionsAsync(QueryMappCenterAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMappCenterApp",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMappCenterAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMappCenterAppRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMappCenterAppResponse
        /// </returns>
        public QueryMappCenterAppResponse QueryMappCenterApp(QueryMappCenterAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMappCenterAppWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMappCenterAppRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMappCenterAppResponse
        /// </returns>
        public async Task<QueryMappCenterAppResponse> QueryMappCenterAppAsync(QueryMappCenterAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMappCenterAppWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMcdpAimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpAimResponse
        /// </returns>
        public QueryMcdpAimResponse QueryMcdpAimWithOptions(QueryMcdpAimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcdpAim",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcdpAimResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcdpAimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpAimResponse
        /// </returns>
        public async Task<QueryMcdpAimResponse> QueryMcdpAimWithOptionsAsync(QueryMcdpAimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcdpAim",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcdpAimResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcdpAimRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpAimResponse
        /// </returns>
        public QueryMcdpAimResponse QueryMcdpAim(QueryMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcdpAimWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMcdpAimRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpAimResponse
        /// </returns>
        public async Task<QueryMcdpAimResponse> QueryMcdpAimAsync(QueryMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcdpAimWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMcdpZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpZoneResponse
        /// </returns>
        public QueryMcdpZoneResponse QueryMcdpZoneWithOptions(QueryMcdpZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcdpZone",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcdpZoneResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcdpZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpZoneResponse
        /// </returns>
        public async Task<QueryMcdpZoneResponse> QueryMcdpZoneWithOptionsAsync(QueryMcdpZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcdpZone",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcdpZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcdpZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpZoneResponse
        /// </returns>
        public QueryMcdpZoneResponse QueryMcdpZone(QueryMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcdpZoneWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMcdpZoneRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcdpZoneResponse
        /// </returns>
        public async Task<QueryMcdpZoneResponse> QueryMcdpZoneAsync(QueryMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcdpZoneWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMcubeMiniPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniPackageResponse
        /// </returns>
        public QueryMcubeMiniPackageResponse QueryMcubeMiniPackageWithOptions(QueryMcubeMiniPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcubeMiniPackage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcubeMiniPackageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcubeMiniPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniPackageResponse
        /// </returns>
        public async Task<QueryMcubeMiniPackageResponse> QueryMcubeMiniPackageWithOptionsAsync(QueryMcubeMiniPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcubeMiniPackage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcubeMiniPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcubeMiniPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniPackageResponse
        /// </returns>
        public QueryMcubeMiniPackageResponse QueryMcubeMiniPackage(QueryMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcubeMiniPackageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMcubeMiniPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniPackageResponse
        /// </returns>
        public async Task<QueryMcubeMiniPackageResponse> QueryMcubeMiniPackageAsync(QueryMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcubeMiniPackageWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMcubeMiniTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniTaskResponse
        /// </returns>
        public QueryMcubeMiniTaskResponse QueryMcubeMiniTaskWithOptions(QueryMcubeMiniTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcubeMiniTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcubeMiniTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcubeMiniTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniTaskResponse
        /// </returns>
        public async Task<QueryMcubeMiniTaskResponse> QueryMcubeMiniTaskWithOptionsAsync(QueryMcubeMiniTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcubeMiniTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcubeMiniTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcubeMiniTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniTaskResponse
        /// </returns>
        public QueryMcubeMiniTaskResponse QueryMcubeMiniTask(QueryMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcubeMiniTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMcubeMiniTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeMiniTaskResponse
        /// </returns>
        public async Task<QueryMcubeMiniTaskResponse> QueryMcubeMiniTaskAsync(QueryMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcubeMiniTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMcubeVhostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeVhostResponse
        /// </returns>
        public QueryMcubeVhostResponse QueryMcubeVhostWithOptions(QueryMcubeVhostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcubeVhost",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcubeVhostResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcubeVhostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeVhostResponse
        /// </returns>
        public async Task<QueryMcubeVhostResponse> QueryMcubeVhostWithOptionsAsync(QueryMcubeVhostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMcubeVhost",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMcubeVhostResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMcubeVhostRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeVhostResponse
        /// </returns>
        public QueryMcubeVhostResponse QueryMcubeVhost(QueryMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcubeVhostWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMcubeVhostRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMcubeVhostResponse
        /// </returns>
        public async Task<QueryMcubeVhostResponse> QueryMcubeVhostAsync(QueryMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcubeVhostWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMdsUpgradeTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMdsUpgradeTaskDetailResponse
        /// </returns>
        public QueryMdsUpgradeTaskDetailResponse QueryMdsUpgradeTaskDetailWithOptions(QueryMdsUpgradeTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMdsUpgradeTaskDetail",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMdsUpgradeTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMdsUpgradeTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMdsUpgradeTaskDetailResponse
        /// </returns>
        public async Task<QueryMdsUpgradeTaskDetailResponse> QueryMdsUpgradeTaskDetailWithOptionsAsync(QueryMdsUpgradeTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMdsUpgradeTaskDetail",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMdsUpgradeTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMdsUpgradeTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMdsUpgradeTaskDetailResponse
        /// </returns>
        public QueryMdsUpgradeTaskDetailResponse QueryMdsUpgradeTaskDetail(QueryMdsUpgradeTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMdsUpgradeTaskDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMdsUpgradeTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMdsUpgradeTaskDetailResponse
        /// </returns>
        public async Task<QueryMdsUpgradeTaskDetailResponse> QueryMdsUpgradeTaskDetailAsync(QueryMdsUpgradeTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMdsUpgradeTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMgsApipageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApipageResponse
        /// </returns>
        public QueryMgsApipageResponse QueryMgsApipageWithOptions(QueryMgsApipageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiStatus))
            {
                body["ApiStatus"] = request.ApiStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEncrypt))
            {
                body["NeedEncrypt"] = request.NeedEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEtag))
            {
                body["NeedEtag"] = request.NeedEtag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSign))
            {
                body["NeedSign"] = request.NeedSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptFuzzy))
            {
                body["OptFuzzy"] = request.OptFuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysId))
            {
                body["SysId"] = request.SysId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysName))
            {
                body["SysName"] = request.SysName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMgsApipage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMgsApipageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMgsApipageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApipageResponse
        /// </returns>
        public async Task<QueryMgsApipageResponse> QueryMgsApipageWithOptionsAsync(QueryMgsApipageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiStatus))
            {
                body["ApiStatus"] = request.ApiStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                body["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                body["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEncrypt))
            {
                body["NeedEncrypt"] = request.NeedEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedEtag))
            {
                body["NeedEtag"] = request.NeedEtag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSign))
            {
                body["NeedSign"] = request.NeedSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptFuzzy))
            {
                body["OptFuzzy"] = request.OptFuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysId))
            {
                body["SysId"] = request.SysId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysName))
            {
                body["SysName"] = request.SysName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMgsApipage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMgsApipageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMgsApipageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApipageResponse
        /// </returns>
        public QueryMgsApipageResponse QueryMgsApipage(QueryMgsApipageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMgsApipageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMgsApipageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApipageResponse
        /// </returns>
        public async Task<QueryMgsApipageResponse> QueryMgsApipageAsync(QueryMgsApipageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMgsApipageWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMgsApirestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApirestResponse
        /// </returns>
        public QueryMgsApirestResponse QueryMgsApirestWithOptions(QueryMgsApirestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMgsApirest",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMgsApirestResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMgsApirestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApirestResponse
        /// </returns>
        public async Task<QueryMgsApirestResponse> QueryMgsApirestWithOptionsAsync(QueryMgsApirestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMgsApirest",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMgsApirestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMgsApirestRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApirestResponse
        /// </returns>
        public QueryMgsApirestResponse QueryMgsApirest(QueryMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMgsApirestWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMgsApirestRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsApirestResponse
        /// </returns>
        public async Task<QueryMgsApirestResponse> QueryMgsApirestAsync(QueryMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMgsApirestWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMgsTestreqbodyautogenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsTestreqbodyautogenResponse
        /// </returns>
        public QueryMgsTestreqbodyautogenResponse QueryMgsTestreqbodyautogenWithOptions(QueryMgsTestreqbodyautogenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMgsTestreqbodyautogenQueryJsonStr))
            {
                body["MpaasMappcenterMgsTestreqbodyautogenQueryJsonStr"] = request.MpaasMappcenterMgsTestreqbodyautogenQueryJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMgsTestreqbodyautogen",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMgsTestreqbodyautogenResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMgsTestreqbodyautogenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsTestreqbodyautogenResponse
        /// </returns>
        public async Task<QueryMgsTestreqbodyautogenResponse> QueryMgsTestreqbodyautogenWithOptionsAsync(QueryMgsTestreqbodyautogenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMgsTestreqbodyautogenQueryJsonStr))
            {
                body["MpaasMappcenterMgsTestreqbodyautogenQueryJsonStr"] = request.MpaasMappcenterMgsTestreqbodyautogenQueryJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMgsTestreqbodyautogen",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMgsTestreqbodyautogenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMgsTestreqbodyautogenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsTestreqbodyautogenResponse
        /// </returns>
        public QueryMgsTestreqbodyautogenResponse QueryMgsTestreqbodyautogen(QueryMgsTestreqbodyautogenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMgsTestreqbodyautogenWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMgsTestreqbodyautogenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMgsTestreqbodyautogenResponse
        /// </returns>
        public async Task<QueryMgsTestreqbodyautogenResponse> QueryMgsTestreqbodyautogenAsync(QueryMgsTestreqbodyautogenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMgsTestreqbodyautogenWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryMpsSchedulerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMpsSchedulerListResponse
        /// </returns>
        public QueryMpsSchedulerListResponse QueryMpsSchedulerListWithOptions(QueryMpsSchedulerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMpsSchedulerList",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMpsSchedulerListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMpsSchedulerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMpsSchedulerListResponse
        /// </returns>
        public async Task<QueryMpsSchedulerListResponse> QueryMpsSchedulerListWithOptionsAsync(QueryMpsSchedulerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMpsSchedulerList",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMpsSchedulerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryMpsSchedulerListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMpsSchedulerListResponse
        /// </returns>
        public QueryMpsSchedulerListResponse QueryMpsSchedulerList(QueryMpsSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMpsSchedulerListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryMpsSchedulerListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMpsSchedulerListResponse
        /// </returns>
        public async Task<QueryMpsSchedulerListResponse> QueryMpsSchedulerListAsync(QueryMpsSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMpsSchedulerListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryPushAnalysisCoreIndexRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisCoreIndexResponse
        /// </returns>
        public QueryPushAnalysisCoreIndexResponse QueryPushAnalysisCoreIndexWithOptions(QueryPushAnalysisCoreIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushAnalysisCoreIndex",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushAnalysisCoreIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushAnalysisCoreIndexRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisCoreIndexResponse
        /// </returns>
        public async Task<QueryPushAnalysisCoreIndexResponse> QueryPushAnalysisCoreIndexWithOptionsAsync(QueryPushAnalysisCoreIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushAnalysisCoreIndex",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushAnalysisCoreIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushAnalysisCoreIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisCoreIndexResponse
        /// </returns>
        public QueryPushAnalysisCoreIndexResponse QueryPushAnalysisCoreIndex(QueryPushAnalysisCoreIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushAnalysisCoreIndexWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryPushAnalysisCoreIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisCoreIndexResponse
        /// </returns>
        public async Task<QueryPushAnalysisCoreIndexResponse> QueryPushAnalysisCoreIndexAsync(QueryPushAnalysisCoreIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushAnalysisCoreIndexWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskDetailResponse
        /// </returns>
        public QueryPushAnalysisTaskDetailResponse QueryPushAnalysisTaskDetailWithOptions(QueryPushAnalysisTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushAnalysisTaskDetail",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushAnalysisTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskDetailResponse
        /// </returns>
        public async Task<QueryPushAnalysisTaskDetailResponse> QueryPushAnalysisTaskDetailWithOptionsAsync(QueryPushAnalysisTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushAnalysisTaskDetail",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushAnalysisTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskDetailResponse
        /// </returns>
        public QueryPushAnalysisTaskDetailResponse QueryPushAnalysisTaskDetail(QueryPushAnalysisTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushAnalysisTaskDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskDetailResponse
        /// </returns>
        public async Task<QueryPushAnalysisTaskDetailResponse> QueryPushAnalysisTaskDetailAsync(QueryPushAnalysisTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushAnalysisTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskListResponse
        /// </returns>
        public QueryPushAnalysisTaskListResponse QueryPushAnalysisTaskListWithOptions(QueryPushAnalysisTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushAnalysisTaskList",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushAnalysisTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskListResponse
        /// </returns>
        public async Task<QueryPushAnalysisTaskListResponse> QueryPushAnalysisTaskListWithOptionsAsync(QueryPushAnalysisTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushAnalysisTaskList",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushAnalysisTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskListResponse
        /// </returns>
        public QueryPushAnalysisTaskListResponse QueryPushAnalysisTaskList(QueryPushAnalysisTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushAnalysisTaskListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryPushAnalysisTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushAnalysisTaskListResponse
        /// </returns>
        public async Task<QueryPushAnalysisTaskListResponse> QueryPushAnalysisTaskListAsync(QueryPushAnalysisTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushAnalysisTaskListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryPushSchedulerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushSchedulerListResponse
        /// </returns>
        public QueryPushSchedulerListResponse QueryPushSchedulerListWithOptions(QueryPushSchedulerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushSchedulerList",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushSchedulerListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushSchedulerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPushSchedulerListResponse
        /// </returns>
        public async Task<QueryPushSchedulerListResponse> QueryPushSchedulerListWithOptionsAsync(QueryPushSchedulerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                body["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushSchedulerList",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushSchedulerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPushSchedulerListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushSchedulerListResponse
        /// </returns>
        public QueryPushSchedulerListResponse QueryPushSchedulerList(QueryPushSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushSchedulerListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryPushSchedulerListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPushSchedulerListResponse
        /// </returns>
        public async Task<QueryPushSchedulerListResponse> QueryPushSchedulerListAsync(QueryPushSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushSchedulerListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RevokePushMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokePushMessageResponse
        /// </returns>
        public RevokePushMessageResponse RevokePushMessageWithOptions(RevokePushMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePushMessage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePushMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RevokePushMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokePushMessageResponse
        /// </returns>
        public async Task<RevokePushMessageResponse> RevokePushMessageWithOptionsAsync(RevokePushMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                body["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePushMessage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePushMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RevokePushMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokePushMessageResponse
        /// </returns>
        public RevokePushMessageResponse RevokePushMessage(RevokePushMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokePushMessageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RevokePushMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokePushMessageResponse
        /// </returns>
        public async Task<RevokePushMessageResponse> RevokePushMessageAsync(RevokePushMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokePushMessageWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RevokePushTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokePushTaskResponse
        /// </returns>
        public RevokePushTaskResponse RevokePushTaskWithOptions(RevokePushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePushTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePushTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RevokePushTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokePushTaskResponse
        /// </returns>
        public async Task<RevokePushTaskResponse> RevokePushTaskWithOptionsAsync(RevokePushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePushTask",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePushTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RevokePushTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokePushTaskResponse
        /// </returns>
        public RevokePushTaskResponse RevokePushTask(RevokePushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokePushTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RevokePushTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokePushTaskResponse
        /// </returns>
        public async Task<RevokePushTaskResponse> RevokePushTaskAsync(RevokePushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokePushTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RunMsaDiffRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMsaDiffResponse
        /// </returns>
        public RunMsaDiffResponse RunMsaDiffWithOptions(RunMsaDiffRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMsaDiffRunJsonStr))
            {
                body["MpaasMappcenterMsaDiffRunJsonStr"] = request.MpaasMappcenterMsaDiffRunJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMsaDiff",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMsaDiffResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RunMsaDiffRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMsaDiffResponse
        /// </returns>
        public async Task<RunMsaDiffResponse> RunMsaDiffWithOptionsAsync(RunMsaDiffRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMsaDiffRunJsonStr))
            {
                body["MpaasMappcenterMsaDiffRunJsonStr"] = request.MpaasMappcenterMsaDiffRunJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMsaDiff",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMsaDiffResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RunMsaDiffRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMsaDiffResponse
        /// </returns>
        public RunMsaDiffResponse RunMsaDiff(RunMsaDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunMsaDiffWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RunMsaDiffRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMsaDiffResponse
        /// </returns>
        public async Task<RunMsaDiffResponse> RunMsaDiffAsync(RunMsaDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunMsaDiffWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveMgsApirestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveMgsApirestResponse
        /// </returns>
        public SaveMgsApirestResponse SaveMgsApirestWithOptions(SaveMgsApirestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMgsApirestSaveJsonStr))
            {
                body["MpaasMappcenterMgsApirestSaveJsonStr"] = request.MpaasMappcenterMgsApirestSaveJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveMgsApirest",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveMgsApirestResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveMgsApirestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveMgsApirestResponse
        /// </returns>
        public async Task<SaveMgsApirestResponse> SaveMgsApirestWithOptionsAsync(SaveMgsApirestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMgsApirestSaveJsonStr))
            {
                body["MpaasMappcenterMgsApirestSaveJsonStr"] = request.MpaasMappcenterMgsApirestSaveJsonStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveMgsApirest",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveMgsApirestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveMgsApirestRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveMgsApirestResponse
        /// </returns>
        public SaveMgsApirestResponse SaveMgsApirest(SaveMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveMgsApirestWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveMgsApirestRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveMgsApirestResponse
        /// </returns>
        public async Task<SaveMgsApirestResponse> SaveMgsApirestAsync(SaveMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveMgsApirestWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartUserAppAsyncEnhanceInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartUserAppAsyncEnhanceInMsaResponse
        /// </returns>
        public StartUserAppAsyncEnhanceInMsaResponse StartUserAppAsyncEnhanceInMsaWithOptions(StartUserAppAsyncEnhanceInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApkProtector))
            {
                body["ApkProtector"] = request.ApkProtector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsFileList))
            {
                body["AssetsFileList"] = request.AssetsFileList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classes))
            {
                body["Classes"] = request.Classes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DalvikDebugger))
            {
                body["DalvikDebugger"] = request.DalvikDebugger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmulatorEnvironment))
            {
                body["EmulatorEnvironment"] = request.EmulatorEnvironment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaHook))
            {
                body["JavaHook"] = request.JavaHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryDump))
            {
                body["MemoryDump"] = request.MemoryDump;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeDebugger))
            {
                body["NativeDebugger"] = request.NativeDebugger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeHook))
            {
                body["NativeHook"] = request.NativeHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageTampered))
            {
                body["PackageTampered"] = request.PackageTampered;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Root))
            {
                body["Root"] = request.Root;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                body["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoFileList))
            {
                body["SoFileList"] = request.SoFileList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSwitch))
            {
                body["TotalSwitch"] = request.TotalSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAShield))
            {
                body["UseAShield"] = request.UseAShield;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartUserAppAsyncEnhanceInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartUserAppAsyncEnhanceInMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// StartUserAppAsyncEnhanceInMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartUserAppAsyncEnhanceInMsaResponse
        /// </returns>
        public async Task<StartUserAppAsyncEnhanceInMsaResponse> StartUserAppAsyncEnhanceInMsaWithOptionsAsync(StartUserAppAsyncEnhanceInMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApkProtector))
            {
                body["ApkProtector"] = request.ApkProtector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsFileList))
            {
                body["AssetsFileList"] = request.AssetsFileList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classes))
            {
                body["Classes"] = request.Classes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DalvikDebugger))
            {
                body["DalvikDebugger"] = request.DalvikDebugger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmulatorEnvironment))
            {
                body["EmulatorEnvironment"] = request.EmulatorEnvironment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JavaHook))
            {
                body["JavaHook"] = request.JavaHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryDump))
            {
                body["MemoryDump"] = request.MemoryDump;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeDebugger))
            {
                body["NativeDebugger"] = request.NativeDebugger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeHook))
            {
                body["NativeHook"] = request.NativeHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageTampered))
            {
                body["PackageTampered"] = request.PackageTampered;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Root))
            {
                body["Root"] = request.Root;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                body["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoFileList))
            {
                body["SoFileList"] = request.SoFileList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalSwitch))
            {
                body["TotalSwitch"] = request.TotalSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAShield))
            {
                body["UseAShield"] = request.UseAShield;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartUserAppAsyncEnhanceInMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartUserAppAsyncEnhanceInMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// StartUserAppAsyncEnhanceInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// StartUserAppAsyncEnhanceInMsaResponse
        /// </returns>
        public StartUserAppAsyncEnhanceInMsaResponse StartUserAppAsyncEnhanceInMsa(StartUserAppAsyncEnhanceInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartUserAppAsyncEnhanceInMsaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartUserAppAsyncEnhanceInMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// StartUserAppAsyncEnhanceInMsaResponse
        /// </returns>
        public async Task<StartUserAppAsyncEnhanceInMsaResponse> StartUserAppAsyncEnhanceInMsaAsync(StartUserAppAsyncEnhanceInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartUserAppAsyncEnhanceInMsaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLinkResponse
        /// </returns>
        public UpdateLinkResponse UpdateLinkWithOptions(UpdateLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cors))
            {
                body["Cors"] = request.Cors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dynamicfield))
            {
                body["Dynamicfield"] = request.Dynamicfield;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUrl))
            {
                body["TargetUrl"] = request.TargetUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLink",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLinkResponse
        /// </returns>
        public async Task<UpdateLinkResponse> UpdateLinkWithOptionsAsync(UpdateLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cors))
            {
                body["Cors"] = request.Cors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dynamicfield))
            {
                body["Dynamicfield"] = request.Dynamicfield;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUrl))
            {
                body["TargetUrl"] = request.TargetUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLink",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLinkResponse
        /// </returns>
        public UpdateLinkResponse UpdateLink(UpdateLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新短链</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLinkResponse
        /// </returns>
        public async Task<UpdateLinkResponse> UpdateLinkAsync(UpdateLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLinkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateMcubeWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcubeWhitelistResponse
        /// </returns>
        public UpdateMcubeWhitelistResponse UpdateMcubeWhitelistWithOptions(UpdateMcubeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyIds))
            {
                body["KeyIds"] = request.KeyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcubeWhitelist",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcubeWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateMcubeWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcubeWhitelistResponse
        /// </returns>
        public async Task<UpdateMcubeWhitelistResponse> UpdateMcubeWhitelistWithOptionsAsync(UpdateMcubeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyIds))
            {
                body["KeyIds"] = request.KeyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssUrl))
            {
                body["OssUrl"] = request.OssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcubeWhitelist",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcubeWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateMcubeWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcubeWhitelistResponse
        /// </returns>
        public UpdateMcubeWhitelistResponse UpdateMcubeWhitelist(UpdateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMcubeWhitelistWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateMcubeWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcubeWhitelistResponse
        /// </returns>
        public async Task<UpdateMcubeWhitelistResponse> UpdateMcubeWhitelistAsync(UpdateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMcubeWhitelistWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateMdsCubeResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMdsCubeResourceResponse
        /// </returns>
        public UpdateMdsCubeResourceResponse UpdateMdsCubeResourceWithOptions(UpdateMdsCubeResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockDataUrl))
            {
                body["MockDataUrl"] = request.MockDataUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMdsCubeResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMdsCubeResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateMdsCubeResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMdsCubeResourceResponse
        /// </returns>
        public async Task<UpdateMdsCubeResourceResponse> UpdateMdsCubeResourceWithOptionsAsync(UpdateMdsCubeResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MockDataUrl))
            {
                body["MockDataUrl"] = request.MockDataUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateResourceId))
            {
                body["TemplateResourceId"] = request.TemplateResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMdsCubeResource",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMdsCubeResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateMdsCubeResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMdsCubeResourceResponse
        /// </returns>
        public UpdateMdsCubeResourceResponse UpdateMdsCubeResource(UpdateMdsCubeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMdsCubeResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateMdsCubeResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMdsCubeResourceResponse
        /// </returns>
        public async Task<UpdateMdsCubeResourceResponse> UpdateMdsCubeResourceAsync(UpdateMdsCubeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMdsCubeResourceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateMpaasAppInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMpaasAppInfoResponse
        /// </returns>
        public UpdateMpaasAppInfoResponse UpdateMpaasAppInfoWithOptions(UpdateMpaasAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconFileUrl))
            {
                body["IconFileUrl"] = request.IconFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMpaasAppInfo",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMpaasAppInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateMpaasAppInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMpaasAppInfoResponse
        /// </returns>
        public async Task<UpdateMpaasAppInfoResponse> UpdateMpaasAppInfoWithOptionsAsync(UpdateMpaasAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconFileUrl))
            {
                body["IconFileUrl"] = request.IconFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                body["SystemType"] = request.SystemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMpaasAppInfo",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMpaasAppInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateMpaasAppInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMpaasAppInfoResponse
        /// </returns>
        public UpdateMpaasAppInfoResponse UpdateMpaasAppInfo(UpdateMpaasAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMpaasAppInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateMpaasAppInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMpaasAppInfoResponse
        /// </returns>
        public async Task<UpdateMpaasAppInfoResponse> UpdateMpaasAppInfoAsync(UpdateMpaasAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMpaasAppInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传字节码到msa进行加固</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadBitcodeToMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadBitcodeToMsaResponse
        /// </returns>
        public UploadBitcodeToMsaResponse UploadBitcodeToMsaWithOptions(UploadBitcodeToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bitcode))
            {
                body["Bitcode"] = request.Bitcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeVersion))
            {
                body["CodeVersion"] = request.CodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.License))
            {
                body["License"] = request.License;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadBitcodeToMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadBitcodeToMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传字节码到msa进行加固</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadBitcodeToMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadBitcodeToMsaResponse
        /// </returns>
        public async Task<UploadBitcodeToMsaResponse> UploadBitcodeToMsaWithOptionsAsync(UploadBitcodeToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bitcode))
            {
                body["Bitcode"] = request.Bitcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeVersion))
            {
                body["CodeVersion"] = request.CodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.License))
            {
                body["License"] = request.License;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadBitcodeToMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadBitcodeToMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传字节码到msa进行加固</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadBitcodeToMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadBitcodeToMsaResponse
        /// </returns>
        public UploadBitcodeToMsaResponse UploadBitcodeToMsa(UploadBitcodeToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadBitcodeToMsaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传字节码到msa进行加固</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadBitcodeToMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadBitcodeToMsaResponse
        /// </returns>
        public async Task<UploadBitcodeToMsaResponse> UploadBitcodeToMsaAsync(UploadBitcodeToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadBitcodeToMsaWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UploadMcubeMiniPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeMiniPackageResponse
        /// </returns>
        public UploadMcubeMiniPackageResponse UploadMcubeMiniPackageWithOptions(UploadMcubeMiniPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                body["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMax))
            {
                body["ClientVersionMax"] = request.ClientVersionMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMin))
            {
                body["ClientVersionMin"] = request.ClientVersionMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableKeepAlive))
            {
                body["EnableKeepAlive"] = request.EnableKeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOptionMenu))
            {
                body["EnableOptionMenu"] = request.EnableOptionMenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTabBar))
            {
                body["EnableTabBar"] = request.EnableTabBar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Version))
            {
                body["H5Version"] = request.H5Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconFileUrl))
            {
                body["IconFileUrl"] = request.IconFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                body["IconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallType))
            {
                body["InstallType"] = request.InstallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainUrl))
            {
                body["MainUrl"] = request.MainUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFileUrl))
            {
                body["ResourceFileUrl"] = request.ResourceFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                body["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMcubeMiniPackage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMcubeMiniPackageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadMcubeMiniPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeMiniPackageResponse
        /// </returns>
        public async Task<UploadMcubeMiniPackageResponse> UploadMcubeMiniPackageWithOptionsAsync(UploadMcubeMiniPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                body["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMax))
            {
                body["ClientVersionMax"] = request.ClientVersionMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersionMin))
            {
                body["ClientVersionMin"] = request.ClientVersionMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableKeepAlive))
            {
                body["EnableKeepAlive"] = request.EnableKeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOptionMenu))
            {
                body["EnableOptionMenu"] = request.EnableOptionMenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTabBar))
            {
                body["EnableTabBar"] = request.EnableTabBar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Id))
            {
                body["H5Id"] = request.H5Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Name))
            {
                body["H5Name"] = request.H5Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Version))
            {
                body["H5Version"] = request.H5Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconFileUrl))
            {
                body["IconFileUrl"] = request.IconFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                body["IconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallType))
            {
                body["InstallType"] = request.InstallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainUrl))
            {
                body["MainUrl"] = request.MainUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFileUrl))
            {
                body["ResourceFileUrl"] = request.ResourceFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                body["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMcubeMiniPackage",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMcubeMiniPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadMcubeMiniPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeMiniPackageResponse
        /// </returns>
        public UploadMcubeMiniPackageResponse UploadMcubeMiniPackage(UploadMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMcubeMiniPackageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UploadMcubeMiniPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeMiniPackageResponse
        /// </returns>
        public async Task<UploadMcubeMiniPackageResponse> UploadMcubeMiniPackageAsync(UploadMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMcubeMiniPackageWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UploadMcubeRsaKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeRsaKeyResponse
        /// </returns>
        public UploadMcubeRsaKeyResponse UploadMcubeRsaKeyWithOptions(UploadMcubeRsaKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMcubeRsaKey",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMcubeRsaKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadMcubeRsaKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeRsaKeyResponse
        /// </returns>
        public async Task<UploadMcubeRsaKeyResponse> UploadMcubeRsaKeyWithOptionsAsync(UploadMcubeRsaKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnexFlag))
            {
                body["OnexFlag"] = request.OnexFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadMcubeRsaKey",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMcubeRsaKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadMcubeRsaKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeRsaKeyResponse
        /// </returns>
        public UploadMcubeRsaKeyResponse UploadMcubeRsaKey(UploadMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMcubeRsaKeyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UploadMcubeRsaKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadMcubeRsaKeyResponse
        /// </returns>
        public async Task<UploadMcubeRsaKeyResponse> UploadMcubeRsaKeyAsync(UploadMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMcubeRsaKeyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UploadUserAppToMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadUserAppToMsaResponse
        /// </returns>
        public UploadUserAppToMsaResponse UploadUserAppToMsaWithOptions(UploadUserAppToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadUserAppToMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadUserAppToMsaResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadUserAppToMsaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadUserAppToMsaResponse
        /// </returns>
        public async Task<UploadUserAppToMsaResponse> UploadUserAppToMsaWithOptionsAsync(UploadUserAppToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadUserAppToMsa",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadUserAppToMsaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadUserAppToMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadUserAppToMsaResponse
        /// </returns>
        public UploadUserAppToMsaResponse UploadUserAppToMsa(UploadUserAppToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadUserAppToMsaWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UploadUserAppToMsaRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadUserAppToMsaResponse
        /// </returns>
        public async Task<UploadUserAppToMsaResponse> UploadUserAppToMsaAsync(UploadUserAppToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadUserAppToMsaWithOptionsAsync(request, runtime);
        }

    }
}
