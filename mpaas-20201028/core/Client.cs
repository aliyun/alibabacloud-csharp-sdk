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

        /**
         * @param request AddMdsMiniConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMdsMiniConfigResponse
         */
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

        /**
         * @param request AddMdsMiniConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMdsMiniConfigResponse
         */
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

        /**
         * @param request AddMdsMiniConfigRequest
         * @return AddMdsMiniConfigResponse
         */
        public AddMdsMiniConfigResponse AddMdsMiniConfig(AddMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMdsMiniConfigWithOptions(request, runtime);
        }

        /**
         * @param request AddMdsMiniConfigRequest
         * @return AddMdsMiniConfigResponse
         */
        public async Task<AddMdsMiniConfigResponse> AddMdsMiniConfigAsync(AddMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMdsMiniConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CancelPushSchedulerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelPushSchedulerResponse
         */
        public CancelPushSchedulerResponse CancelPushSchedulerWithOptions(CancelPushSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
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

        /**
         * @param request CancelPushSchedulerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelPushSchedulerResponse
         */
        public async Task<CancelPushSchedulerResponse> CancelPushSchedulerWithOptionsAsync(CancelPushSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
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

        /**
         * @param request CancelPushSchedulerRequest
         * @return CancelPushSchedulerResponse
         */
        public CancelPushSchedulerResponse CancelPushScheduler(CancelPushSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPushSchedulerWithOptions(request, runtime);
        }

        /**
         * @param request CancelPushSchedulerRequest
         * @return CancelPushSchedulerResponse
         */
        public async Task<CancelPushSchedulerResponse> CancelPushSchedulerAsync(CancelPushSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPushSchedulerWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ChangeMcubeMiniTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeMcubeMiniTaskStatusResponse
         */
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

        /**
         * @param request ChangeMcubeMiniTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeMcubeMiniTaskStatusResponse
         */
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

        /**
         * @param request ChangeMcubeMiniTaskStatusRequest
         * @return ChangeMcubeMiniTaskStatusResponse
         */
        public ChangeMcubeMiniTaskStatusResponse ChangeMcubeMiniTaskStatus(ChangeMcubeMiniTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMcubeMiniTaskStatusWithOptions(request, runtime);
        }

        /**
         * @param request ChangeMcubeMiniTaskStatusRequest
         * @return ChangeMcubeMiniTaskStatusResponse
         */
        public async Task<ChangeMcubeMiniTaskStatusResponse> ChangeMcubeMiniTaskStatusAsync(ChangeMcubeMiniTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMcubeMiniTaskStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ChangeMcubeNebulaTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeMcubeNebulaTaskStatusResponse
         */
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

        /**
         * @param request ChangeMcubeNebulaTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeMcubeNebulaTaskStatusResponse
         */
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

        /**
         * @param request ChangeMcubeNebulaTaskStatusRequest
         * @return ChangeMcubeNebulaTaskStatusResponse
         */
        public ChangeMcubeNebulaTaskStatusResponse ChangeMcubeNebulaTaskStatus(ChangeMcubeNebulaTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMcubeNebulaTaskStatusWithOptions(request, runtime);
        }

        /**
         * @param request ChangeMcubeNebulaTaskStatusRequest
         * @return ChangeMcubeNebulaTaskStatusResponse
         */
        public async Task<ChangeMcubeNebulaTaskStatusResponse> ChangeMcubeNebulaTaskStatusAsync(ChangeMcubeNebulaTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMcubeNebulaTaskStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ChangeMcubePublicTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeMcubePublicTaskStatusResponse
         */
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

        /**
         * @param request ChangeMcubePublicTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeMcubePublicTaskStatusResponse
         */
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

        /**
         * @param request ChangeMcubePublicTaskStatusRequest
         * @return ChangeMcubePublicTaskStatusResponse
         */
        public ChangeMcubePublicTaskStatusResponse ChangeMcubePublicTaskStatus(ChangeMcubePublicTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMcubePublicTaskStatusWithOptions(request, runtime);
        }

        /**
         * @param request ChangeMcubePublicTaskStatusRequest
         * @return ChangeMcubePublicTaskStatusResponse
         */
        public async Task<ChangeMcubePublicTaskStatusResponse> ChangeMcubePublicTaskStatusAsync(ChangeMcubePublicTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMcubePublicTaskStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CopyMcdpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyMcdpGroupResponse
         */
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

        /**
         * @param request CopyMcdpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyMcdpGroupResponse
         */
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

        /**
         * @param request CopyMcdpGroupRequest
         * @return CopyMcdpGroupResponse
         */
        public CopyMcdpGroupResponse CopyMcdpGroup(CopyMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyMcdpGroupWithOptions(request, runtime);
        }

        /**
         * @param request CopyMcdpGroupRequest
         * @return CopyMcdpGroupResponse
         */
        public async Task<CopyMcdpGroupResponse> CopyMcdpGroupAsync(CopyMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyMcdpGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建短链
         *
         * @param request CreateLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLinkResponse
         */
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

        /**
         * @summary 创建短链
         *
         * @param request CreateLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLinkResponse
         */
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

        /**
         * @summary 创建短链
         *
         * @param request CreateLinkRequest
         * @return CreateLinkResponse
         */
        public CreateLinkResponse CreateLink(CreateLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLinkWithOptions(request, runtime);
        }

        /**
         * @summary 创建短链
         *
         * @param request CreateLinkRequest
         * @return CreateLinkResponse
         */
        public async Task<CreateLinkResponse> CreateLinkAsync(CreateLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMasCrowdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMasCrowdResponse
         */
        public CreateMasCrowdResponse CreateMasCrowdWithOptions(CreateMasCrowdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMasCrowdCreateJsonStr))
            {
                body["MpaasMappcenterMcdpMasCrowdCreateJsonStr"] = request.MpaasMappcenterMcdpMasCrowdCreateJsonStr;
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
                Action = "CreateMasCrowd",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMasCrowdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateMasCrowdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMasCrowdResponse
         */
        public async Task<CreateMasCrowdResponse> CreateMasCrowdWithOptionsAsync(CreateMasCrowdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMasCrowdCreateJsonStr))
            {
                body["MpaasMappcenterMcdpMasCrowdCreateJsonStr"] = request.MpaasMappcenterMcdpMasCrowdCreateJsonStr;
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
                Action = "CreateMasCrowd",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMasCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateMasCrowdRequest
         * @return CreateMasCrowdResponse
         */
        public CreateMasCrowdResponse CreateMasCrowd(CreateMasCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMasCrowdWithOptions(request, runtime);
        }

        /**
         * @param request CreateMasCrowdRequest
         * @return CreateMasCrowdResponse
         */
        public async Task<CreateMasCrowdResponse> CreateMasCrowdAsync(CreateMasCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMasCrowdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMasFunnelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMasFunnelResponse
         */
        public CreateMasFunnelResponse CreateMasFunnelWithOptions(CreateMasFunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMasFunnelCreateJsonStr))
            {
                body["MpaasMappcenterMcdpMasFunnelCreateJsonStr"] = request.MpaasMappcenterMcdpMasFunnelCreateJsonStr;
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
                Action = "CreateMasFunnel",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMasFunnelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateMasFunnelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMasFunnelResponse
         */
        public async Task<CreateMasFunnelResponse> CreateMasFunnelWithOptionsAsync(CreateMasFunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMasFunnelCreateJsonStr))
            {
                body["MpaasMappcenterMcdpMasFunnelCreateJsonStr"] = request.MpaasMappcenterMcdpMasFunnelCreateJsonStr;
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
                Action = "CreateMasFunnel",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMasFunnelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateMasFunnelRequest
         * @return CreateMasFunnelResponse
         */
        public CreateMasFunnelResponse CreateMasFunnel(CreateMasFunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMasFunnelWithOptions(request, runtime);
        }

        /**
         * @param request CreateMasFunnelRequest
         * @return CreateMasFunnelResponse
         */
        public async Task<CreateMasFunnelResponse> CreateMasFunnelAsync(CreateMasFunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMasFunnelWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcdpEventRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpEventResponse
         */
        public CreateMcdpEventResponse CreateMcdpEventWithOptions(CreateMcdpEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventCreateJsonStr))
            {
                body["MpaasMappcenterMcdpEventCreateJsonStr"] = request.MpaasMappcenterMcdpEventCreateJsonStr;
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
                Action = "CreateMcdpEvent",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateMcdpEventRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpEventResponse
         */
        public async Task<CreateMcdpEventResponse> CreateMcdpEventWithOptionsAsync(CreateMcdpEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventCreateJsonStr))
            {
                body["MpaasMappcenterMcdpEventCreateJsonStr"] = request.MpaasMappcenterMcdpEventCreateJsonStr;
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
                Action = "CreateMcdpEvent",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateMcdpEventRequest
         * @return CreateMcdpEventResponse
         */
        public CreateMcdpEventResponse CreateMcdpEvent(CreateMcdpEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpEventWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcdpEventRequest
         * @return CreateMcdpEventResponse
         */
        public async Task<CreateMcdpEventResponse> CreateMcdpEventAsync(CreateMcdpEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpEventWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcdpEventAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpEventAttributeResponse
         */
        public CreateMcdpEventAttributeResponse CreateMcdpEventAttributeWithOptions(CreateMcdpEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventAttributeCreateJsonStr))
            {
                body["MpaasMappcenterMcdpEventAttributeCreateJsonStr"] = request.MpaasMappcenterMcdpEventAttributeCreateJsonStr;
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
                Action = "CreateMcdpEventAttribute",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpEventAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateMcdpEventAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpEventAttributeResponse
         */
        public async Task<CreateMcdpEventAttributeResponse> CreateMcdpEventAttributeWithOptionsAsync(CreateMcdpEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventAttributeCreateJsonStr))
            {
                body["MpaasMappcenterMcdpEventAttributeCreateJsonStr"] = request.MpaasMappcenterMcdpEventAttributeCreateJsonStr;
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
                Action = "CreateMcdpEventAttribute",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcdpEventAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateMcdpEventAttributeRequest
         * @return CreateMcdpEventAttributeResponse
         */
        public CreateMcdpEventAttributeResponse CreateMcdpEventAttribute(CreateMcdpEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpEventAttributeWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcdpEventAttributeRequest
         * @return CreateMcdpEventAttributeResponse
         */
        public async Task<CreateMcdpEventAttributeResponse> CreateMcdpEventAttributeAsync(CreateMcdpEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpEventAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcdpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpGroupResponse
         */
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

        /**
         * @param request CreateMcdpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpGroupResponse
         */
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

        /**
         * @param request CreateMcdpGroupRequest
         * @return CreateMcdpGroupResponse
         */
        public CreateMcdpGroupResponse CreateMcdpGroup(CreateMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpGroupWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcdpGroupRequest
         * @return CreateMcdpGroupResponse
         */
        public async Task<CreateMcdpGroupResponse> CreateMcdpGroupAsync(CreateMcdpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcdpMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpMaterialResponse
         */
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

        /**
         * @param request CreateMcdpMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpMaterialResponse
         */
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

        /**
         * @param request CreateMcdpMaterialRequest
         * @return CreateMcdpMaterialResponse
         */
        public CreateMcdpMaterialResponse CreateMcdpMaterial(CreateMcdpMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpMaterialWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcdpMaterialRequest
         * @return CreateMcdpMaterialResponse
         */
        public async Task<CreateMcdpMaterialResponse> CreateMcdpMaterialAsync(CreateMcdpMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpMaterialWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcdpZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpZoneResponse
         */
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

        /**
         * @param request CreateMcdpZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcdpZoneResponse
         */
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

        /**
         * @param request CreateMcdpZoneRequest
         * @return CreateMcdpZoneResponse
         */
        public CreateMcdpZoneResponse CreateMcdpZone(CreateMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcdpZoneWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcdpZoneRequest
         * @return CreateMcdpZoneResponse
         */
        public async Task<CreateMcdpZoneResponse> CreateMcdpZoneAsync(CreateMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcdpZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeMiniAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeMiniAppResponse
         */
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

        /**
         * @param request CreateMcubeMiniAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeMiniAppResponse
         */
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

        /**
         * @param request CreateMcubeMiniAppRequest
         * @return CreateMcubeMiniAppResponse
         */
        public CreateMcubeMiniAppResponse CreateMcubeMiniApp(CreateMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeMiniAppWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeMiniAppRequest
         * @return CreateMcubeMiniAppResponse
         */
        public async Task<CreateMcubeMiniAppResponse> CreateMcubeMiniAppAsync(CreateMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeMiniAppWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeMiniTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeMiniTaskResponse
         */
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

        /**
         * @param request CreateMcubeMiniTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeMiniTaskResponse
         */
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

        /**
         * @param request CreateMcubeMiniTaskRequest
         * @return CreateMcubeMiniTaskResponse
         */
        public CreateMcubeMiniTaskResponse CreateMcubeMiniTask(CreateMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeMiniTaskWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeMiniTaskRequest
         * @return CreateMcubeMiniTaskResponse
         */
        public async Task<CreateMcubeMiniTaskResponse> CreateMcubeMiniTaskAsync(CreateMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeMiniTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeNebulaAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeNebulaAppResponse
         */
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

        /**
         * @param request CreateMcubeNebulaAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeNebulaAppResponse
         */
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

        /**
         * @param request CreateMcubeNebulaAppRequest
         * @return CreateMcubeNebulaAppResponse
         */
        public CreateMcubeNebulaAppResponse CreateMcubeNebulaApp(CreateMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeNebulaAppWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeNebulaAppRequest
         * @return CreateMcubeNebulaAppResponse
         */
        public async Task<CreateMcubeNebulaAppResponse> CreateMcubeNebulaAppAsync(CreateMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeNebulaAppWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeNebulaResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeNebulaResourceResponse
         */
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

        /**
         * @param request CreateMcubeNebulaResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeNebulaResourceResponse
         */
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

        /**
         * @param request CreateMcubeNebulaResourceRequest
         * @return CreateMcubeNebulaResourceResponse
         */
        public CreateMcubeNebulaResourceResponse CreateMcubeNebulaResource(CreateMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeNebulaResourceWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeNebulaResourceRequest
         * @return CreateMcubeNebulaResourceResponse
         */
        public async Task<CreateMcubeNebulaResourceResponse> CreateMcubeNebulaResourceAsync(CreateMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeNebulaResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeNebulaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeNebulaTaskResponse
         */
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

        /**
         * @param request CreateMcubeNebulaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeNebulaTaskResponse
         */
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

        /**
         * @param request CreateMcubeNebulaTaskRequest
         * @return CreateMcubeNebulaTaskResponse
         */
        public CreateMcubeNebulaTaskResponse CreateMcubeNebulaTask(CreateMcubeNebulaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeNebulaTaskWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeNebulaTaskRequest
         * @return CreateMcubeNebulaTaskResponse
         */
        public async Task<CreateMcubeNebulaTaskResponse> CreateMcubeNebulaTaskAsync(CreateMcubeNebulaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeNebulaTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeUpgradePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeUpgradePackageResponse
         */
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

        /**
         * @param request CreateMcubeUpgradePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeUpgradePackageResponse
         */
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

        /**
         * @param request CreateMcubeUpgradePackageRequest
         * @return CreateMcubeUpgradePackageResponse
         */
        public CreateMcubeUpgradePackageResponse CreateMcubeUpgradePackage(CreateMcubeUpgradePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeUpgradePackageWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeUpgradePackageRequest
         * @return CreateMcubeUpgradePackageResponse
         */
        public async Task<CreateMcubeUpgradePackageResponse> CreateMcubeUpgradePackageAsync(CreateMcubeUpgradePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeUpgradePackageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeUpgradeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeUpgradeTaskResponse
         */
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

        /**
         * @param request CreateMcubeUpgradeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeUpgradeTaskResponse
         */
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

        /**
         * @param request CreateMcubeUpgradeTaskRequest
         * @return CreateMcubeUpgradeTaskResponse
         */
        public CreateMcubeUpgradeTaskResponse CreateMcubeUpgradeTask(CreateMcubeUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeUpgradeTaskWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeUpgradeTaskRequest
         * @return CreateMcubeUpgradeTaskResponse
         */
        public async Task<CreateMcubeUpgradeTaskResponse> CreateMcubeUpgradeTaskAsync(CreateMcubeUpgradeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeUpgradeTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeVhostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeVhostResponse
         */
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

        /**
         * @param request CreateMcubeVhostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeVhostResponse
         */
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

        /**
         * @param request CreateMcubeVhostRequest
         * @return CreateMcubeVhostResponse
         */
        public CreateMcubeVhostResponse CreateMcubeVhost(CreateMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeVhostWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeVhostRequest
         * @return CreateMcubeVhostResponse
         */
        public async Task<CreateMcubeVhostResponse> CreateMcubeVhostAsync(CreateMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeVhostWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeWhitelistResponse
         */
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

        /**
         * @param request CreateMcubeWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeWhitelistResponse
         */
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

        /**
         * @param request CreateMcubeWhitelistRequest
         * @return CreateMcubeWhitelistResponse
         */
        public CreateMcubeWhitelistResponse CreateMcubeWhitelist(CreateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeWhitelistWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeWhitelistRequest
         * @return CreateMcubeWhitelistResponse
         */
        public async Task<CreateMcubeWhitelistResponse> CreateMcubeWhitelistAsync(CreateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMcubeWhitelistForIdeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeWhitelistForIdeResponse
         */
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

        /**
         * @param request CreateMcubeWhitelistForIdeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMcubeWhitelistForIdeResponse
         */
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

        /**
         * @param request CreateMcubeWhitelistForIdeRequest
         * @return CreateMcubeWhitelistForIdeResponse
         */
        public CreateMcubeWhitelistForIdeResponse CreateMcubeWhitelistForIde(CreateMcubeWhitelistForIdeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMcubeWhitelistForIdeWithOptions(request, runtime);
        }

        /**
         * @param request CreateMcubeWhitelistForIdeRequest
         * @return CreateMcubeWhitelistForIdeResponse
         */
        public async Task<CreateMcubeWhitelistForIdeResponse> CreateMcubeWhitelistForIdeAsync(CreateMcubeWhitelistForIdeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMcubeWhitelistForIdeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMdsMiniprogramTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMdsMiniprogramTaskResponse
         */
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

        /**
         * @param request CreateMdsMiniprogramTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMdsMiniprogramTaskResponse
         */
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

        /**
         * @param request CreateMdsMiniprogramTaskRequest
         * @return CreateMdsMiniprogramTaskResponse
         */
        public CreateMdsMiniprogramTaskResponse CreateMdsMiniprogramTask(CreateMdsMiniprogramTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMdsMiniprogramTaskWithOptions(request, runtime);
        }

        /**
         * @param request CreateMdsMiniprogramTaskRequest
         * @return CreateMdsMiniprogramTaskResponse
         */
        public async Task<CreateMdsMiniprogramTaskResponse> CreateMdsMiniprogramTaskAsync(CreateMdsMiniprogramTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMdsMiniprogramTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMsaEnhanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMsaEnhanceResponse
         */
        public CreateMsaEnhanceResponse CreateMsaEnhanceWithOptions(CreateMsaEnhanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMsaEnhanceCreateJsonStr))
            {
                body["MpaasMappcenterMsaEnhanceCreateJsonStr"] = request.MpaasMappcenterMsaEnhanceCreateJsonStr;
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
                Action = "CreateMsaEnhance",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMsaEnhanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateMsaEnhanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMsaEnhanceResponse
         */
        public async Task<CreateMsaEnhanceResponse> CreateMsaEnhanceWithOptionsAsync(CreateMsaEnhanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMsaEnhanceCreateJsonStr))
            {
                body["MpaasMappcenterMsaEnhanceCreateJsonStr"] = request.MpaasMappcenterMsaEnhanceCreateJsonStr;
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
                Action = "CreateMsaEnhance",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMsaEnhanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateMsaEnhanceRequest
         * @return CreateMsaEnhanceResponse
         */
        public CreateMsaEnhanceResponse CreateMsaEnhance(CreateMsaEnhanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMsaEnhanceWithOptions(request, runtime);
        }

        /**
         * @param request CreateMsaEnhanceRequest
         * @return CreateMsaEnhanceResponse
         */
        public async Task<CreateMsaEnhanceResponse> CreateMsaEnhanceAsync(CreateMsaEnhanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMsaEnhanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateOpenGlobalDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOpenGlobalDataResponse
         */
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

        /**
         * @param request CreateOpenGlobalDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOpenGlobalDataResponse
         */
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

        /**
         * @param request CreateOpenGlobalDataRequest
         * @return CreateOpenGlobalDataResponse
         */
        public CreateOpenGlobalDataResponse CreateOpenGlobalData(CreateOpenGlobalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOpenGlobalDataWithOptions(request, runtime);
        }

        /**
         * @param request CreateOpenGlobalDataRequest
         * @return CreateOpenGlobalDataResponse
         */
        public async Task<CreateOpenGlobalDataResponse> CreateOpenGlobalDataAsync(CreateOpenGlobalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOpenGlobalDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateOpenSingleDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOpenSingleDataResponse
         */
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

        /**
         * @param request CreateOpenSingleDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOpenSingleDataResponse
         */
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

        /**
         * @param request CreateOpenSingleDataRequest
         * @return CreateOpenSingleDataResponse
         */
        public CreateOpenSingleDataResponse CreateOpenSingleData(CreateOpenSingleDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOpenSingleDataWithOptions(request, runtime);
        }

        /**
         * @param request CreateOpenSingleDataRequest
         * @return CreateOpenSingleDataResponse
         */
        public async Task<CreateOpenSingleDataResponse> CreateOpenSingleDataAsync(CreateOpenSingleDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOpenSingleDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteCubecardWhitelistContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCubecardWhitelistContentResponse
         */
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

        /**
         * @param request DeleteCubecardWhitelistContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCubecardWhitelistContentResponse
         */
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

        /**
         * @param request DeleteCubecardWhitelistContentRequest
         * @return DeleteCubecardWhitelistContentResponse
         */
        public DeleteCubecardWhitelistContentResponse DeleteCubecardWhitelistContent(DeleteCubecardWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCubecardWhitelistContentWithOptions(request, runtime);
        }

        /**
         * @param request DeleteCubecardWhitelistContentRequest
         * @return DeleteCubecardWhitelistContentResponse
         */
        public async Task<DeleteCubecardWhitelistContentResponse> DeleteCubecardWhitelistContentAsync(DeleteCubecardWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCubecardWhitelistContentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcdpAimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpAimResponse
         */
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

        /**
         * @param request DeleteMcdpAimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpAimResponse
         */
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

        /**
         * @param request DeleteMcdpAimRequest
         * @return DeleteMcdpAimResponse
         */
        public DeleteMcdpAimResponse DeleteMcdpAim(DeleteMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpAimWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcdpAimRequest
         * @return DeleteMcdpAimResponse
         */
        public async Task<DeleteMcdpAimResponse> DeleteMcdpAimAsync(DeleteMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpAimWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcdpCrowdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpCrowdResponse
         */
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

        /**
         * @param request DeleteMcdpCrowdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpCrowdResponse
         */
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

        /**
         * @param request DeleteMcdpCrowdRequest
         * @return DeleteMcdpCrowdResponse
         */
        public DeleteMcdpCrowdResponse DeleteMcdpCrowd(DeleteMcdpCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpCrowdWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcdpCrowdRequest
         * @return DeleteMcdpCrowdResponse
         */
        public async Task<DeleteMcdpCrowdResponse> DeleteMcdpCrowdAsync(DeleteMcdpCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpCrowdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcdpEventAttributeByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpEventAttributeByIdResponse
         */
        public DeleteMcdpEventAttributeByIdResponse DeleteMcdpEventAttributeByIdWithOptions(DeleteMcdpEventAttributeByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventAttributeDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpEventAttributeDeleteJsonStr"] = request.MpaasMappcenterMcdpEventAttributeDeleteJsonStr;
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
                Action = "DeleteMcdpEventAttributeById",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpEventAttributeByIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteMcdpEventAttributeByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpEventAttributeByIdResponse
         */
        public async Task<DeleteMcdpEventAttributeByIdResponse> DeleteMcdpEventAttributeByIdWithOptionsAsync(DeleteMcdpEventAttributeByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventAttributeDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpEventAttributeDeleteJsonStr"] = request.MpaasMappcenterMcdpEventAttributeDeleteJsonStr;
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
                Action = "DeleteMcdpEventAttributeById",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpEventAttributeByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteMcdpEventAttributeByIdRequest
         * @return DeleteMcdpEventAttributeByIdResponse
         */
        public DeleteMcdpEventAttributeByIdResponse DeleteMcdpEventAttributeById(DeleteMcdpEventAttributeByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpEventAttributeByIdWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcdpEventAttributeByIdRequest
         * @return DeleteMcdpEventAttributeByIdResponse
         */
        public async Task<DeleteMcdpEventAttributeByIdResponse> DeleteMcdpEventAttributeByIdAsync(DeleteMcdpEventAttributeByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpEventAttributeByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcdpEventByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpEventByIdResponse
         */
        public DeleteMcdpEventByIdResponse DeleteMcdpEventByIdWithOptions(DeleteMcdpEventByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpEventDeleteJsonStr"] = request.MpaasMappcenterMcdpEventDeleteJsonStr;
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
                Action = "DeleteMcdpEventById",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpEventByIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteMcdpEventByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpEventByIdResponse
         */
        public async Task<DeleteMcdpEventByIdResponse> DeleteMcdpEventByIdWithOptionsAsync(DeleteMcdpEventByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpEventDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpEventDeleteJsonStr"] = request.MpaasMappcenterMcdpEventDeleteJsonStr;
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
                Action = "DeleteMcdpEventById",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpEventByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteMcdpEventByIdRequest
         * @return DeleteMcdpEventByIdResponse
         */
        public DeleteMcdpEventByIdResponse DeleteMcdpEventById(DeleteMcdpEventByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpEventByIdWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcdpEventByIdRequest
         * @return DeleteMcdpEventByIdResponse
         */
        public async Task<DeleteMcdpEventByIdResponse> DeleteMcdpEventByIdAsync(DeleteMcdpEventByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpEventByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcdpMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpMaterialResponse
         */
        public DeleteMcdpMaterialResponse DeleteMcdpMaterialWithOptions(DeleteMcdpMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMaterialDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpMaterialDeleteJsonStr"] = request.MpaasMappcenterMcdpMaterialDeleteJsonStr;
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
                Action = "DeleteMcdpMaterial",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpMaterialResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteMcdpMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpMaterialResponse
         */
        public async Task<DeleteMcdpMaterialResponse> DeleteMcdpMaterialWithOptionsAsync(DeleteMcdpMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMappcenterMcdpMaterialDeleteJsonStr))
            {
                body["MpaasMappcenterMcdpMaterialDeleteJsonStr"] = request.MpaasMappcenterMcdpMaterialDeleteJsonStr;
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
                Action = "DeleteMcdpMaterial",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcdpMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteMcdpMaterialRequest
         * @return DeleteMcdpMaterialResponse
         */
        public DeleteMcdpMaterialResponse DeleteMcdpMaterial(DeleteMcdpMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpMaterialWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcdpMaterialRequest
         * @return DeleteMcdpMaterialResponse
         */
        public async Task<DeleteMcdpMaterialResponse> DeleteMcdpMaterialAsync(DeleteMcdpMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpMaterialWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcdpZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpZoneResponse
         */
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

        /**
         * @param request DeleteMcdpZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcdpZoneResponse
         */
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

        /**
         * @param request DeleteMcdpZoneRequest
         * @return DeleteMcdpZoneResponse
         */
        public DeleteMcdpZoneResponse DeleteMcdpZone(DeleteMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcdpZoneWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcdpZoneRequest
         * @return DeleteMcdpZoneResponse
         */
        public async Task<DeleteMcdpZoneResponse> DeleteMcdpZoneAsync(DeleteMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcdpZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcubeMiniAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeMiniAppResponse
         */
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

        /**
         * @param request DeleteMcubeMiniAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeMiniAppResponse
         */
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

        /**
         * @param request DeleteMcubeMiniAppRequest
         * @return DeleteMcubeMiniAppResponse
         */
        public DeleteMcubeMiniAppResponse DeleteMcubeMiniApp(DeleteMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeMiniAppWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcubeMiniAppRequest
         * @return DeleteMcubeMiniAppResponse
         */
        public async Task<DeleteMcubeMiniAppResponse> DeleteMcubeMiniAppAsync(DeleteMcubeMiniAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeMiniAppWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcubeNebulaAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeNebulaAppResponse
         */
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

        /**
         * @param request DeleteMcubeNebulaAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeNebulaAppResponse
         */
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

        /**
         * @param request DeleteMcubeNebulaAppRequest
         * @return DeleteMcubeNebulaAppResponse
         */
        public DeleteMcubeNebulaAppResponse DeleteMcubeNebulaApp(DeleteMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeNebulaAppWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcubeNebulaAppRequest
         * @return DeleteMcubeNebulaAppResponse
         */
        public async Task<DeleteMcubeNebulaAppResponse> DeleteMcubeNebulaAppAsync(DeleteMcubeNebulaAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeNebulaAppWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcubeUpgradeResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeUpgradeResourceResponse
         */
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

        /**
         * @param request DeleteMcubeUpgradeResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeUpgradeResourceResponse
         */
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

        /**
         * @param request DeleteMcubeUpgradeResourceRequest
         * @return DeleteMcubeUpgradeResourceResponse
         */
        public DeleteMcubeUpgradeResourceResponse DeleteMcubeUpgradeResource(DeleteMcubeUpgradeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeUpgradeResourceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcubeUpgradeResourceRequest
         * @return DeleteMcubeUpgradeResourceResponse
         */
        public async Task<DeleteMcubeUpgradeResourceResponse> DeleteMcubeUpgradeResourceAsync(DeleteMcubeUpgradeResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeUpgradeResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMcubeWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeWhitelistResponse
         */
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

        /**
         * @param request DeleteMcubeWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMcubeWhitelistResponse
         */
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

        /**
         * @param request DeleteMcubeWhitelistRequest
         * @return DeleteMcubeWhitelistResponse
         */
        public DeleteMcubeWhitelistResponse DeleteMcubeWhitelist(DeleteMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMcubeWhitelistWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMcubeWhitelistRequest
         * @return DeleteMcubeWhitelistResponse
         */
        public async Task<DeleteMcubeWhitelistResponse> DeleteMcubeWhitelistAsync(DeleteMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMcubeWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMdsWhitelistContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMdsWhitelistContentResponse
         */
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

        /**
         * @param request DeleteMdsWhitelistContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMdsWhitelistContentResponse
         */
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

        /**
         * @param request DeleteMdsWhitelistContentRequest
         * @return DeleteMdsWhitelistContentResponse
         */
        public DeleteMdsWhitelistContentResponse DeleteMdsWhitelistContent(DeleteMdsWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMdsWhitelistContentWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMdsWhitelistContentRequest
         * @return DeleteMdsWhitelistContentResponse
         */
        public async Task<DeleteMdsWhitelistContentResponse> DeleteMdsWhitelistContentAsync(DeleteMdsWhitelistContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMdsWhitelistContentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ExistMcubeRsaKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExistMcubeRsaKeyResponse
         */
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

        /**
         * @param request ExistMcubeRsaKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExistMcubeRsaKeyResponse
         */
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

        /**
         * @param request ExistMcubeRsaKeyRequest
         * @return ExistMcubeRsaKeyResponse
         */
        public ExistMcubeRsaKeyResponse ExistMcubeRsaKey(ExistMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExistMcubeRsaKeyWithOptions(request, runtime);
        }

        /**
         * @param request ExistMcubeRsaKeyRequest
         * @return ExistMcubeRsaKeyResponse
         */
        public async Task<ExistMcubeRsaKeyResponse> ExistMcubeRsaKeyAsync(ExistMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExistMcubeRsaKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ExportMappCenterAppConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportMappCenterAppConfigResponse
         */
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

        /**
         * @param request ExportMappCenterAppConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportMappCenterAppConfigResponse
         */
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

        /**
         * @param request ExportMappCenterAppConfigRequest
         * @return ExportMappCenterAppConfigResponse
         */
        public ExportMappCenterAppConfigResponse ExportMappCenterAppConfig(ExportMappCenterAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportMappCenterAppConfigWithOptions(request, runtime);
        }

        /**
         * @param request ExportMappCenterAppConfigRequest
         * @return ExportMappCenterAppConfigResponse
         */
        public async Task<ExportMappCenterAppConfigResponse> ExportMappCenterAppConfigAsync(ExportMappCenterAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportMappCenterAppConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetFileTokenForUploadToMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileTokenForUploadToMsaResponse
         */
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

        /**
         * @param request GetFileTokenForUploadToMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileTokenForUploadToMsaResponse
         */
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

        /**
         * @param request GetFileTokenForUploadToMsaRequest
         * @return GetFileTokenForUploadToMsaResponse
         */
        public GetFileTokenForUploadToMsaResponse GetFileTokenForUploadToMsa(GetFileTokenForUploadToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileTokenForUploadToMsaWithOptions(request, runtime);
        }

        /**
         * @param request GetFileTokenForUploadToMsaRequest
         * @return GetFileTokenForUploadToMsaResponse
         */
        public async Task<GetFileTokenForUploadToMsaResponse> GetFileTokenForUploadToMsaAsync(GetFileTokenForUploadToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileTokenForUploadToMsaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetLogUrlInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogUrlInMsaResponse
         */
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

        /**
         * @param request GetLogUrlInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogUrlInMsaResponse
         */
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

        /**
         * @param request GetLogUrlInMsaRequest
         * @return GetLogUrlInMsaResponse
         */
        public GetLogUrlInMsaResponse GetLogUrlInMsa(GetLogUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogUrlInMsaWithOptions(request, runtime);
        }

        /**
         * @param request GetLogUrlInMsaRequest
         * @return GetLogUrlInMsaResponse
         */
        public async Task<GetLogUrlInMsaResponse> GetLogUrlInMsaAsync(GetLogUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogUrlInMsaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMcubeFileTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeFileTokenResponse
         */
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

        /**
         * @param request GetMcubeFileTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeFileTokenResponse
         */
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

        /**
         * @param request GetMcubeFileTokenRequest
         * @return GetMcubeFileTokenResponse
         */
        public GetMcubeFileTokenResponse GetMcubeFileToken(GetMcubeFileTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeFileTokenWithOptions(request, runtime);
        }

        /**
         * @param request GetMcubeFileTokenRequest
         * @return GetMcubeFileTokenResponse
         */
        public async Task<GetMcubeFileTokenResponse> GetMcubeFileTokenAsync(GetMcubeFileTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeFileTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMcubeNebulaResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeNebulaResourceResponse
         */
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

        /**
         * @param request GetMcubeNebulaResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeNebulaResourceResponse
         */
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

        /**
         * @param request GetMcubeNebulaResourceRequest
         * @return GetMcubeNebulaResourceResponse
         */
        public GetMcubeNebulaResourceResponse GetMcubeNebulaResource(GetMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeNebulaResourceWithOptions(request, runtime);
        }

        /**
         * @param request GetMcubeNebulaResourceRequest
         * @return GetMcubeNebulaResourceResponse
         */
        public async Task<GetMcubeNebulaResourceResponse> GetMcubeNebulaResourceAsync(GetMcubeNebulaResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeNebulaResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMcubeNebulaTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeNebulaTaskDetailResponse
         */
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

        /**
         * @param request GetMcubeNebulaTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeNebulaTaskDetailResponse
         */
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

        /**
         * @param request GetMcubeNebulaTaskDetailRequest
         * @return GetMcubeNebulaTaskDetailResponse
         */
        public GetMcubeNebulaTaskDetailResponse GetMcubeNebulaTaskDetail(GetMcubeNebulaTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeNebulaTaskDetailWithOptions(request, runtime);
        }

        /**
         * @param request GetMcubeNebulaTaskDetailRequest
         * @return GetMcubeNebulaTaskDetailResponse
         */
        public async Task<GetMcubeNebulaTaskDetailResponse> GetMcubeNebulaTaskDetailAsync(GetMcubeNebulaTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeNebulaTaskDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMcubeUpgradePackageInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeUpgradePackageInfoResponse
         */
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

        /**
         * @param request GetMcubeUpgradePackageInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeUpgradePackageInfoResponse
         */
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

        /**
         * @param request GetMcubeUpgradePackageInfoRequest
         * @return GetMcubeUpgradePackageInfoResponse
         */
        public GetMcubeUpgradePackageInfoResponse GetMcubeUpgradePackageInfo(GetMcubeUpgradePackageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeUpgradePackageInfoWithOptions(request, runtime);
        }

        /**
         * @param request GetMcubeUpgradePackageInfoRequest
         * @return GetMcubeUpgradePackageInfoResponse
         */
        public async Task<GetMcubeUpgradePackageInfoResponse> GetMcubeUpgradePackageInfoAsync(GetMcubeUpgradePackageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeUpgradePackageInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMcubeUpgradeTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeUpgradeTaskInfoResponse
         */
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

        /**
         * @param request GetMcubeUpgradeTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMcubeUpgradeTaskInfoResponse
         */
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

        /**
         * @param request GetMcubeUpgradeTaskInfoRequest
         * @return GetMcubeUpgradeTaskInfoResponse
         */
        public GetMcubeUpgradeTaskInfoResponse GetMcubeUpgradeTaskInfo(GetMcubeUpgradeTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcubeUpgradeTaskInfoWithOptions(request, runtime);
        }

        /**
         * @param request GetMcubeUpgradeTaskInfoRequest
         * @return GetMcubeUpgradeTaskInfoResponse
         */
        public async Task<GetMcubeUpgradeTaskInfoResponse> GetMcubeUpgradeTaskInfoAsync(GetMcubeUpgradeTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcubeUpgradeTaskInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMdsMiniConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMdsMiniConfigResponse
         */
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

        /**
         * @param request GetMdsMiniConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMdsMiniConfigResponse
         */
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

        /**
         * @param request GetMdsMiniConfigRequest
         * @return GetMdsMiniConfigResponse
         */
        public GetMdsMiniConfigResponse GetMdsMiniConfig(GetMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMdsMiniConfigWithOptions(request, runtime);
        }

        /**
         * @param request GetMdsMiniConfigRequest
         * @return GetMdsMiniConfigResponse
         */
        public async Task<GetMdsMiniConfigResponse> GetMdsMiniConfigAsync(GetMdsMiniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMdsMiniConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetUserAppDonwloadUrlInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppDonwloadUrlInMsaResponse
         */
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

        /**
         * @param request GetUserAppDonwloadUrlInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppDonwloadUrlInMsaResponse
         */
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

        /**
         * @param request GetUserAppDonwloadUrlInMsaRequest
         * @return GetUserAppDonwloadUrlInMsaResponse
         */
        public GetUserAppDonwloadUrlInMsaResponse GetUserAppDonwloadUrlInMsa(GetUserAppDonwloadUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserAppDonwloadUrlInMsaWithOptions(request, runtime);
        }

        /**
         * @param request GetUserAppDonwloadUrlInMsaRequest
         * @return GetUserAppDonwloadUrlInMsaResponse
         */
        public async Task<GetUserAppDonwloadUrlInMsaResponse> GetUserAppDonwloadUrlInMsaAsync(GetUserAppDonwloadUrlInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserAppDonwloadUrlInMsaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetUserAppEnhanceProcessInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppEnhanceProcessInMsaResponse
         */
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

        /**
         * @param request GetUserAppEnhanceProcessInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppEnhanceProcessInMsaResponse
         */
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

        /**
         * @param request GetUserAppEnhanceProcessInMsaRequest
         * @return GetUserAppEnhanceProcessInMsaResponse
         */
        public GetUserAppEnhanceProcessInMsaResponse GetUserAppEnhanceProcessInMsa(GetUserAppEnhanceProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserAppEnhanceProcessInMsaWithOptions(request, runtime);
        }

        /**
         * @param request GetUserAppEnhanceProcessInMsaRequest
         * @return GetUserAppEnhanceProcessInMsaResponse
         */
        public async Task<GetUserAppEnhanceProcessInMsaResponse> GetUserAppEnhanceProcessInMsaAsync(GetUserAppEnhanceProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserAppEnhanceProcessInMsaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetUserAppUploadProcessInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppUploadProcessInMsaResponse
         */
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

        /**
         * @param request GetUserAppUploadProcessInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserAppUploadProcessInMsaResponse
         */
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

        /**
         * @param request GetUserAppUploadProcessInMsaRequest
         * @return GetUserAppUploadProcessInMsaResponse
         */
        public GetUserAppUploadProcessInMsaResponse GetUserAppUploadProcessInMsa(GetUserAppUploadProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserAppUploadProcessInMsaWithOptions(request, runtime);
        }

        /**
         * @param request GetUserAppUploadProcessInMsaRequest
         * @return GetUserAppUploadProcessInMsaResponse
         */
        public async Task<GetUserAppUploadProcessInMsaResponse> GetUserAppUploadProcessInMsaAsync(GetUserAppUploadProcessInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserAppUploadProcessInMsaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMappCenterAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMappCenterAppsResponse
         */
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

        /**
         * @param request ListMappCenterAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMappCenterAppsResponse
         */
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

        /**
         * @return ListMappCenterAppsResponse
         */
        public ListMappCenterAppsResponse ListMappCenterApps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMappCenterAppsWithOptions(runtime);
        }

        /**
         * @return ListMappCenterAppsResponse
         */
        public async Task<ListMappCenterAppsResponse> ListMappCenterAppsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMappCenterAppsWithOptionsAsync(runtime);
        }

        /**
         * @param request ListMappCenterWorkspacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMappCenterWorkspacesResponse
         */
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

        /**
         * @param request ListMappCenterWorkspacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMappCenterWorkspacesResponse
         */
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

        /**
         * @return ListMappCenterWorkspacesResponse
         */
        public ListMappCenterWorkspacesResponse ListMappCenterWorkspaces()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMappCenterWorkspacesWithOptions(runtime);
        }

        /**
         * @return ListMappCenterWorkspacesResponse
         */
        public async Task<ListMappCenterWorkspacesResponse> ListMappCenterWorkspacesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMappCenterWorkspacesWithOptionsAsync(runtime);
        }

        /**
         * @param request ListMcdpAimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcdpAimResponse
         */
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

        /**
         * @param request ListMcdpAimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcdpAimResponse
         */
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

        /**
         * @param request ListMcdpAimRequest
         * @return ListMcdpAimResponse
         */
        public ListMcdpAimResponse ListMcdpAim(ListMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcdpAimWithOptions(request, runtime);
        }

        /**
         * @param request ListMcdpAimRequest
         * @return ListMcdpAimResponse
         */
        public async Task<ListMcdpAimResponse> ListMcdpAimAsync(ListMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcdpAimWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeMiniAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeMiniAppsResponse
         */
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

        /**
         * @param request ListMcubeMiniAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeMiniAppsResponse
         */
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

        /**
         * @param request ListMcubeMiniAppsRequest
         * @return ListMcubeMiniAppsResponse
         */
        public ListMcubeMiniAppsResponse ListMcubeMiniApps(ListMcubeMiniAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeMiniAppsWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeMiniAppsRequest
         * @return ListMcubeMiniAppsResponse
         */
        public async Task<ListMcubeMiniAppsResponse> ListMcubeMiniAppsAsync(ListMcubeMiniAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeMiniAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeMiniPackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeMiniPackagesResponse
         */
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

        /**
         * @param request ListMcubeMiniPackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeMiniPackagesResponse
         */
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

        /**
         * @param request ListMcubeMiniPackagesRequest
         * @return ListMcubeMiniPackagesResponse
         */
        public ListMcubeMiniPackagesResponse ListMcubeMiniPackages(ListMcubeMiniPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeMiniPackagesWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeMiniPackagesRequest
         * @return ListMcubeMiniPackagesResponse
         */
        public async Task<ListMcubeMiniPackagesResponse> ListMcubeMiniPackagesAsync(ListMcubeMiniPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeMiniPackagesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeMiniTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeMiniTasksResponse
         */
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

        /**
         * @param request ListMcubeMiniTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeMiniTasksResponse
         */
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

        /**
         * @param request ListMcubeMiniTasksRequest
         * @return ListMcubeMiniTasksResponse
         */
        public ListMcubeMiniTasksResponse ListMcubeMiniTasks(ListMcubeMiniTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeMiniTasksWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeMiniTasksRequest
         * @return ListMcubeMiniTasksResponse
         */
        public async Task<ListMcubeMiniTasksResponse> ListMcubeMiniTasksAsync(ListMcubeMiniTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeMiniTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeNebulaAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeNebulaAppsResponse
         */
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

        /**
         * @param request ListMcubeNebulaAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeNebulaAppsResponse
         */
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

        /**
         * @param request ListMcubeNebulaAppsRequest
         * @return ListMcubeNebulaAppsResponse
         */
        public ListMcubeNebulaAppsResponse ListMcubeNebulaApps(ListMcubeNebulaAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeNebulaAppsWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeNebulaAppsRequest
         * @return ListMcubeNebulaAppsResponse
         */
        public async Task<ListMcubeNebulaAppsResponse> ListMcubeNebulaAppsAsync(ListMcubeNebulaAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeNebulaAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeNebulaResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeNebulaResourcesResponse
         */
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

        /**
         * @param request ListMcubeNebulaResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeNebulaResourcesResponse
         */
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

        /**
         * @param request ListMcubeNebulaResourcesRequest
         * @return ListMcubeNebulaResourcesResponse
         */
        public ListMcubeNebulaResourcesResponse ListMcubeNebulaResources(ListMcubeNebulaResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeNebulaResourcesWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeNebulaResourcesRequest
         * @return ListMcubeNebulaResourcesResponse
         */
        public async Task<ListMcubeNebulaResourcesResponse> ListMcubeNebulaResourcesAsync(ListMcubeNebulaResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeNebulaResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeNebulaTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeNebulaTasksResponse
         */
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

        /**
         * @param request ListMcubeNebulaTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeNebulaTasksResponse
         */
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

        /**
         * @param request ListMcubeNebulaTasksRequest
         * @return ListMcubeNebulaTasksResponse
         */
        public ListMcubeNebulaTasksResponse ListMcubeNebulaTasks(ListMcubeNebulaTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeNebulaTasksWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeNebulaTasksRequest
         * @return ListMcubeNebulaTasksResponse
         */
        public async Task<ListMcubeNebulaTasksResponse> ListMcubeNebulaTasksAsync(ListMcubeNebulaTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeNebulaTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeUpgradePackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeUpgradePackagesResponse
         */
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

        /**
         * @param request ListMcubeUpgradePackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeUpgradePackagesResponse
         */
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

        /**
         * @param request ListMcubeUpgradePackagesRequest
         * @return ListMcubeUpgradePackagesResponse
         */
        public ListMcubeUpgradePackagesResponse ListMcubeUpgradePackages(ListMcubeUpgradePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeUpgradePackagesWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeUpgradePackagesRequest
         * @return ListMcubeUpgradePackagesResponse
         */
        public async Task<ListMcubeUpgradePackagesResponse> ListMcubeUpgradePackagesAsync(ListMcubeUpgradePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeUpgradePackagesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeUpgradeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeUpgradeTasksResponse
         */
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

        /**
         * @param request ListMcubeUpgradeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeUpgradeTasksResponse
         */
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

        /**
         * @param request ListMcubeUpgradeTasksRequest
         * @return ListMcubeUpgradeTasksResponse
         */
        public ListMcubeUpgradeTasksResponse ListMcubeUpgradeTasks(ListMcubeUpgradeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeUpgradeTasksWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeUpgradeTasksRequest
         * @return ListMcubeUpgradeTasksResponse
         */
        public async Task<ListMcubeUpgradeTasksResponse> ListMcubeUpgradeTasksAsync(ListMcubeUpgradeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeUpgradeTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMcubeWhitelistsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeWhitelistsResponse
         */
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

        /**
         * @param request ListMcubeWhitelistsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMcubeWhitelistsResponse
         */
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

        /**
         * @param request ListMcubeWhitelistsRequest
         * @return ListMcubeWhitelistsResponse
         */
        public ListMcubeWhitelistsResponse ListMcubeWhitelists(ListMcubeWhitelistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMcubeWhitelistsWithOptions(request, runtime);
        }

        /**
         * @param request ListMcubeWhitelistsRequest
         * @return ListMcubeWhitelistsResponse
         */
        public async Task<ListMcubeWhitelistsResponse> ListMcubeWhitelistsAsync(ListMcubeWhitelistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMcubeWhitelistsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMgsApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMgsApiResponse
         */
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

        /**
         * @param request ListMgsApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMgsApiResponse
         */
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

        /**
         * @param request ListMgsApiRequest
         * @return ListMgsApiResponse
         */
        public ListMgsApiResponse ListMgsApi(ListMgsApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMgsApiWithOptions(request, runtime);
        }

        /**
         * @param request ListMgsApiRequest
         * @return ListMgsApiResponse
         */
        public async Task<ListMgsApiResponse> ListMgsApiAsync(ListMgsApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMgsApiWithOptionsAsync(request, runtime);
        }

        /**
         * @param request LogMsaQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LogMsaQueryResponse
         */
        public LogMsaQueryResponse LogMsaQueryWithOptions(LogMsaQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "LogMsaQuery",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogMsaQueryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request LogMsaQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LogMsaQueryResponse
         */
        public async Task<LogMsaQueryResponse> LogMsaQueryWithOptionsAsync(LogMsaQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "LogMsaQuery",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogMsaQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request LogMsaQueryRequest
         * @return LogMsaQueryResponse
         */
        public LogMsaQueryResponse LogMsaQuery(LogMsaQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LogMsaQueryWithOptions(request, runtime);
        }

        /**
         * @param request LogMsaQueryRequest
         * @return LogMsaQueryResponse
         */
        public async Task<LogMsaQueryResponse> LogMsaQueryAsync(LogMsaQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LogMsaQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary OCR通用接口
         *
         * @param request MTRSOCRServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MTRSOCRServiceResponse
         */
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

        /**
         * @summary OCR通用接口
         *
         * @param request MTRSOCRServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MTRSOCRServiceResponse
         */
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

        /**
         * @summary OCR通用接口
         *
         * @param request MTRSOCRServiceRequest
         * @return MTRSOCRServiceResponse
         */
        public MTRSOCRServiceResponse MTRSOCRService(MTRSOCRServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MTRSOCRServiceWithOptions(request, runtime);
        }

        /**
         * @summary OCR通用接口
         *
         * @param request MTRSOCRServiceRequest
         * @return MTRSOCRServiceResponse
         */
        public async Task<MTRSOCRServiceResponse> MTRSOCRServiceAsync(MTRSOCRServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MTRSOCRServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新增主扫码
         *
         * @param request OpenApiAddActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiAddActiveCodeResponse
         */
        public OpenApiAddActiveCodeResponse OpenApiAddActiveCodeWithOptions(OpenApiAddActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiAddActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiAddActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiAddActiveCodeReqJsonStr;
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
                Action = "OpenApiAddActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiAddActiveCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 新增主扫码
         *
         * @param request OpenApiAddActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiAddActiveCodeResponse
         */
        public async Task<OpenApiAddActiveCodeResponse> OpenApiAddActiveCodeWithOptionsAsync(OpenApiAddActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiAddActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiAddActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiAddActiveCodeReqJsonStr;
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
                Action = "OpenApiAddActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiAddActiveCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 新增主扫码
         *
         * @param request OpenApiAddActiveCodeRequest
         * @return OpenApiAddActiveCodeResponse
         */
        public OpenApiAddActiveCodeResponse OpenApiAddActiveCode(OpenApiAddActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiAddActiveCodeWithOptions(request, runtime);
        }

        /**
         * @summary 新增主扫码
         *
         * @param request OpenApiAddActiveCodeRequest
         * @return OpenApiAddActiveCodeResponse
         */
        public async Task<OpenApiAddActiveCodeResponse> OpenApiAddActiveCodeAsync(OpenApiAddActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiAddActiveCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新增场景
         *
         * @param request OpenApiAddActiveSceneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiAddActiveSceneResponse
         */
        public OpenApiAddActiveSceneResponse OpenApiAddActiveSceneWithOptions(OpenApiAddActiveSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiAddActiveSceneReqJsonStr))
            {
                body["MpaasMqcpOpenApiAddActiveSceneReqJsonStr"] = request.MpaasMqcpOpenApiAddActiveSceneReqJsonStr;
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
                Action = "OpenApiAddActiveScene",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiAddActiveSceneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 新增场景
         *
         * @param request OpenApiAddActiveSceneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiAddActiveSceneResponse
         */
        public async Task<OpenApiAddActiveSceneResponse> OpenApiAddActiveSceneWithOptionsAsync(OpenApiAddActiveSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiAddActiveSceneReqJsonStr))
            {
                body["MpaasMqcpOpenApiAddActiveSceneReqJsonStr"] = request.MpaasMqcpOpenApiAddActiveSceneReqJsonStr;
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
                Action = "OpenApiAddActiveScene",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiAddActiveSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 新增场景
         *
         * @param request OpenApiAddActiveSceneRequest
         * @return OpenApiAddActiveSceneResponse
         */
        public OpenApiAddActiveSceneResponse OpenApiAddActiveScene(OpenApiAddActiveSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiAddActiveSceneWithOptions(request, runtime);
        }

        /**
         * @summary 新增场景
         *
         * @param request OpenApiAddActiveSceneRequest
         * @return OpenApiAddActiveSceneResponse
         */
        public async Task<OpenApiAddActiveSceneResponse> OpenApiAddActiveSceneAsync(OpenApiAddActiveSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiAddActiveSceneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 用户注册
         *
         * @param request OpenApiCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiCallbackResponse
         */
        public OpenApiCallbackResponse OpenApiCallbackWithOptions(OpenApiCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiCallbackRequestJsonStr))
            {
                body["MpaasMqcpOpenApiCallbackRequestJsonStr"] = request.MpaasMqcpOpenApiCallbackRequestJsonStr;
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
                Action = "OpenApiCallback",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用户注册
         *
         * @param request OpenApiCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiCallbackResponse
         */
        public async Task<OpenApiCallbackResponse> OpenApiCallbackWithOptionsAsync(OpenApiCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiCallbackRequestJsonStr))
            {
                body["MpaasMqcpOpenApiCallbackRequestJsonStr"] = request.MpaasMqcpOpenApiCallbackRequestJsonStr;
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
                Action = "OpenApiCallback",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用户注册
         *
         * @param request OpenApiCallbackRequest
         * @return OpenApiCallbackResponse
         */
        public OpenApiCallbackResponse OpenApiCallback(OpenApiCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiCallbackWithOptions(request, runtime);
        }

        /**
         * @summary 用户注册
         *
         * @param request OpenApiCallbackRequest
         * @return OpenApiCallbackResponse
         */
        public async Task<OpenApiCallbackResponse> OpenApiCallbackAsync(OpenApiCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiCallbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解码
         *
         * @param request OpenApiDecodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiDecodeResponse
         */
        public OpenApiDecodeResponse OpenApiDecodeWithOptions(OpenApiDecodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiDecodeRequestJsonStr))
            {
                body["MpaasMqcpOpenApiDecodeRequestJsonStr"] = request.MpaasMqcpOpenApiDecodeRequestJsonStr;
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
                Action = "OpenApiDecode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiDecodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解码
         *
         * @param request OpenApiDecodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiDecodeResponse
         */
        public async Task<OpenApiDecodeResponse> OpenApiDecodeWithOptionsAsync(OpenApiDecodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiDecodeRequestJsonStr))
            {
                body["MpaasMqcpOpenApiDecodeRequestJsonStr"] = request.MpaasMqcpOpenApiDecodeRequestJsonStr;
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
                Action = "OpenApiDecode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiDecodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解码
         *
         * @param request OpenApiDecodeRequest
         * @return OpenApiDecodeResponse
         */
        public OpenApiDecodeResponse OpenApiDecode(OpenApiDecodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiDecodeWithOptions(request, runtime);
        }

        /**
         * @summary 解码
         *
         * @param request OpenApiDecodeRequest
         * @return OpenApiDecodeResponse
         */
        public async Task<OpenApiDecodeResponse> OpenApiDecodeAsync(OpenApiDecodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiDecodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除主扫码
         *
         * @param request OpenApiDeleteActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiDeleteActiveCodeResponse
         */
        public OpenApiDeleteActiveCodeResponse OpenApiDeleteActiveCodeWithOptions(OpenApiDeleteActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiDeleteActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiDeleteActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiDeleteActiveCodeReqJsonStr;
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
                Action = "OpenApiDeleteActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiDeleteActiveCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除主扫码
         *
         * @param request OpenApiDeleteActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiDeleteActiveCodeResponse
         */
        public async Task<OpenApiDeleteActiveCodeResponse> OpenApiDeleteActiveCodeWithOptionsAsync(OpenApiDeleteActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiDeleteActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiDeleteActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiDeleteActiveCodeReqJsonStr;
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
                Action = "OpenApiDeleteActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiDeleteActiveCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除主扫码
         *
         * @param request OpenApiDeleteActiveCodeRequest
         * @return OpenApiDeleteActiveCodeResponse
         */
        public OpenApiDeleteActiveCodeResponse OpenApiDeleteActiveCode(OpenApiDeleteActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiDeleteActiveCodeWithOptions(request, runtime);
        }

        /**
         * @summary 删除主扫码
         *
         * @param request OpenApiDeleteActiveCodeRequest
         * @return OpenApiDeleteActiveCodeResponse
         */
        public async Task<OpenApiDeleteActiveCodeResponse> OpenApiDeleteActiveCodeAsync(OpenApiDeleteActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiDeleteActiveCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 编码
         *
         * @param request OpenApiEncodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiEncodeResponse
         */
        public OpenApiEncodeResponse OpenApiEncodeWithOptions(OpenApiEncodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiEncodeRequestJsonStr))
            {
                body["MpaasMqcpOpenApiEncodeRequestJsonStr"] = request.MpaasMqcpOpenApiEncodeRequestJsonStr;
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
                Action = "OpenApiEncode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiEncodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编码
         *
         * @param request OpenApiEncodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiEncodeResponse
         */
        public async Task<OpenApiEncodeResponse> OpenApiEncodeWithOptionsAsync(OpenApiEncodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiEncodeRequestJsonStr))
            {
                body["MpaasMqcpOpenApiEncodeRequestJsonStr"] = request.MpaasMqcpOpenApiEncodeRequestJsonStr;
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
                Action = "OpenApiEncode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiEncodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编码
         *
         * @param request OpenApiEncodeRequest
         * @return OpenApiEncodeResponse
         */
        public OpenApiEncodeResponse OpenApiEncode(OpenApiEncodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiEncodeWithOptions(request, runtime);
        }

        /**
         * @summary 编码
         *
         * @param request OpenApiEncodeRequest
         * @return OpenApiEncodeResponse
         */
        public async Task<OpenApiEncodeResponse> OpenApiEncodeAsync(OpenApiEncodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiEncodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 主扫码查询
         *
         * @param request OpenApiQueryActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiQueryActiveCodeResponse
         */
        public OpenApiQueryActiveCodeResponse OpenApiQueryActiveCodeWithOptions(OpenApiQueryActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiQueryActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiQueryActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiQueryActiveCodeReqJsonStr;
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
                Action = "OpenApiQueryActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiQueryActiveCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 主扫码查询
         *
         * @param request OpenApiQueryActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiQueryActiveCodeResponse
         */
        public async Task<OpenApiQueryActiveCodeResponse> OpenApiQueryActiveCodeWithOptionsAsync(OpenApiQueryActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiQueryActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiQueryActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiQueryActiveCodeReqJsonStr;
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
                Action = "OpenApiQueryActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiQueryActiveCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 主扫码查询
         *
         * @param request OpenApiQueryActiveCodeRequest
         * @return OpenApiQueryActiveCodeResponse
         */
        public OpenApiQueryActiveCodeResponse OpenApiQueryActiveCode(OpenApiQueryActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiQueryActiveCodeWithOptions(request, runtime);
        }

        /**
         * @summary 主扫码查询
         *
         * @param request OpenApiQueryActiveCodeRequest
         * @return OpenApiQueryActiveCodeResponse
         */
        public async Task<OpenApiQueryActiveCodeResponse> OpenApiQueryActiveCodeAsync(OpenApiQueryActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiQueryActiveCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询场景
         *
         * @param request OpenApiQueryActiveSceneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiQueryActiveSceneResponse
         */
        public OpenApiQueryActiveSceneResponse OpenApiQueryActiveSceneWithOptions(OpenApiQueryActiveSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiQueryActiveSceneReqJsonStr))
            {
                body["MpaasMqcpOpenApiQueryActiveSceneReqJsonStr"] = request.MpaasMqcpOpenApiQueryActiveSceneReqJsonStr;
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
                Action = "OpenApiQueryActiveScene",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiQueryActiveSceneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询场景
         *
         * @param request OpenApiQueryActiveSceneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiQueryActiveSceneResponse
         */
        public async Task<OpenApiQueryActiveSceneResponse> OpenApiQueryActiveSceneWithOptionsAsync(OpenApiQueryActiveSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiQueryActiveSceneReqJsonStr))
            {
                body["MpaasMqcpOpenApiQueryActiveSceneReqJsonStr"] = request.MpaasMqcpOpenApiQueryActiveSceneReqJsonStr;
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
                Action = "OpenApiQueryActiveScene",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiQueryActiveSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询场景
         *
         * @param request OpenApiQueryActiveSceneRequest
         * @return OpenApiQueryActiveSceneResponse
         */
        public OpenApiQueryActiveSceneResponse OpenApiQueryActiveScene(OpenApiQueryActiveSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiQueryActiveSceneWithOptions(request, runtime);
        }

        /**
         * @summary 查询场景
         *
         * @param request OpenApiQueryActiveSceneRequest
         * @return OpenApiQueryActiveSceneResponse
         */
        public async Task<OpenApiQueryActiveSceneResponse> OpenApiQueryActiveSceneAsync(OpenApiQueryActiveSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiQueryActiveSceneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成唯一被扫码
         *
         * @param request OpenApiUniqueEncodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiUniqueEncodeResponse
         */
        public OpenApiUniqueEncodeResponse OpenApiUniqueEncodeWithOptions(OpenApiUniqueEncodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiUniqueEncodeRequestJsonStr))
            {
                body["MpaasMqcpOpenApiUniqueEncodeRequestJsonStr"] = request.MpaasMqcpOpenApiUniqueEncodeRequestJsonStr;
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
                Action = "OpenApiUniqueEncode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiUniqueEncodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 生成唯一被扫码
         *
         * @param request OpenApiUniqueEncodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiUniqueEncodeResponse
         */
        public async Task<OpenApiUniqueEncodeResponse> OpenApiUniqueEncodeWithOptionsAsync(OpenApiUniqueEncodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiUniqueEncodeRequestJsonStr))
            {
                body["MpaasMqcpOpenApiUniqueEncodeRequestJsonStr"] = request.MpaasMqcpOpenApiUniqueEncodeRequestJsonStr;
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
                Action = "OpenApiUniqueEncode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiUniqueEncodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 生成唯一被扫码
         *
         * @param request OpenApiUniqueEncodeRequest
         * @return OpenApiUniqueEncodeResponse
         */
        public OpenApiUniqueEncodeResponse OpenApiUniqueEncode(OpenApiUniqueEncodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiUniqueEncodeWithOptions(request, runtime);
        }

        /**
         * @summary 生成唯一被扫码
         *
         * @param request OpenApiUniqueEncodeRequest
         * @return OpenApiUniqueEncodeResponse
         */
        public async Task<OpenApiUniqueEncodeResponse> OpenApiUniqueEncodeAsync(OpenApiUniqueEncodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiUniqueEncodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新主扫码
         *
         * @param request OpenApiUpdateActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiUpdateActiveCodeResponse
         */
        public OpenApiUpdateActiveCodeResponse OpenApiUpdateActiveCodeWithOptions(OpenApiUpdateActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiUpdateActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiUpdateActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiUpdateActiveCodeReqJsonStr;
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
                Action = "OpenApiUpdateActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiUpdateActiveCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新主扫码
         *
         * @param request OpenApiUpdateActiveCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiUpdateActiveCodeResponse
         */
        public async Task<OpenApiUpdateActiveCodeResponse> OpenApiUpdateActiveCodeWithOptionsAsync(OpenApiUpdateActiveCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiUpdateActiveCodeReqJsonStr))
            {
                body["MpaasMqcpOpenApiUpdateActiveCodeReqJsonStr"] = request.MpaasMqcpOpenApiUpdateActiveCodeReqJsonStr;
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
                Action = "OpenApiUpdateActiveCode",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiUpdateActiveCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新主扫码
         *
         * @param request OpenApiUpdateActiveCodeRequest
         * @return OpenApiUpdateActiveCodeResponse
         */
        public OpenApiUpdateActiveCodeResponse OpenApiUpdateActiveCode(OpenApiUpdateActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiUpdateActiveCodeWithOptions(request, runtime);
        }

        /**
         * @summary 更新主扫码
         *
         * @param request OpenApiUpdateActiveCodeRequest
         * @return OpenApiUpdateActiveCodeResponse
         */
        public async Task<OpenApiUpdateActiveCodeResponse> OpenApiUpdateActiveCodeAsync(OpenApiUpdateActiveCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiUpdateActiveCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新场景
         *
         * @param request OpenApiUpdateActiveSceneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiUpdateActiveSceneResponse
         */
        public OpenApiUpdateActiveSceneResponse OpenApiUpdateActiveSceneWithOptions(OpenApiUpdateActiveSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiUpdateActiveSceneReqJsonStr))
            {
                body["MpaasMqcpOpenApiUpdateActiveSceneReqJsonStr"] = request.MpaasMqcpOpenApiUpdateActiveSceneReqJsonStr;
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
                Action = "OpenApiUpdateActiveScene",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiUpdateActiveSceneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新场景
         *
         * @param request OpenApiUpdateActiveSceneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenApiUpdateActiveSceneResponse
         */
        public async Task<OpenApiUpdateActiveSceneResponse> OpenApiUpdateActiveSceneWithOptionsAsync(OpenApiUpdateActiveSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MpaasMqcpOpenApiUpdateActiveSceneReqJsonStr))
            {
                body["MpaasMqcpOpenApiUpdateActiveSceneReqJsonStr"] = request.MpaasMqcpOpenApiUpdateActiveSceneReqJsonStr;
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
                Action = "OpenApiUpdateActiveScene",
                Version = "2020-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiUpdateActiveSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新场景
         *
         * @param request OpenApiUpdateActiveSceneRequest
         * @return OpenApiUpdateActiveSceneResponse
         */
        public OpenApiUpdateActiveSceneResponse OpenApiUpdateActiveScene(OpenApiUpdateActiveSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiUpdateActiveSceneWithOptions(request, runtime);
        }

        /**
         * @summary 更新场景
         *
         * @param request OpenApiUpdateActiveSceneRequest
         * @return OpenApiUpdateActiveSceneResponse
         */
        public async Task<OpenApiUpdateActiveSceneResponse> OpenApiUpdateActiveSceneAsync(OpenApiUpdateActiveSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiUpdateActiveSceneWithOptionsAsync(request, runtime);
        }

        /**
         * @param request PushBindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushBindResponse
         */
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

        /**
         * @param request PushBindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushBindResponse
         */
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

        /**
         * @param request PushBindRequest
         * @return PushBindResponse
         */
        public PushBindResponse PushBind(PushBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushBindWithOptions(request, runtime);
        }

        /**
         * @param request PushBindRequest
         * @return PushBindResponse
         */
        public async Task<PushBindResponse> PushBindAsync(PushBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushBindWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq PushBroadcastRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushBroadcastResponse
         */
        public PushBroadcastResponse PushBroadcastWithOptions(PushBroadcastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushBroadcastShrinkRequest request = new PushBroadcastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindPeriod))
            {
                body["BindPeriod"] = request.BindPeriod;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindPeriod))
            {
                body["UnBindPeriod"] = request.UnBindPeriod;
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

        /**
         * @param tmpReq PushBroadcastRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushBroadcastResponse
         */
        public async Task<PushBroadcastResponse> PushBroadcastWithOptionsAsync(PushBroadcastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushBroadcastShrinkRequest request = new PushBroadcastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindPeriod))
            {
                body["BindPeriod"] = request.BindPeriod;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnBindPeriod))
            {
                body["UnBindPeriod"] = request.UnBindPeriod;
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

        /**
         * @param request PushBroadcastRequest
         * @return PushBroadcastResponse
         */
        public PushBroadcastResponse PushBroadcast(PushBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushBroadcastWithOptions(request, runtime);
        }

        /**
         * @param request PushBroadcastRequest
         * @return PushBroadcastResponse
         */
        public async Task<PushBroadcastResponse> PushBroadcastAsync(PushBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushBroadcastWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq PushMultipleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushMultipleResponse
         */
        public PushMultipleResponse PushMultipleWithOptions(PushMultipleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushMultipleShrinkRequest request = new PushMultipleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
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

        /**
         * @param tmpReq PushMultipleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushMultipleResponse
         */
        public async Task<PushMultipleResponse> PushMultipleWithOptionsAsync(PushMultipleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushMultipleShrinkRequest request = new PushMultipleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
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

        /**
         * @param request PushMultipleRequest
         * @return PushMultipleResponse
         */
        public PushMultipleResponse PushMultiple(PushMultipleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMultipleWithOptions(request, runtime);
        }

        /**
         * @param request PushMultipleRequest
         * @return PushMultipleResponse
         */
        public async Task<PushMultipleResponse> PushMultipleAsync(PushMultipleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMultipleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request PushReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushReportResponse
         */
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

        /**
         * @param request PushReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushReportResponse
         */
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

        /**
         * @param request PushReportRequest
         * @return PushReportResponse
         */
        public PushReportResponse PushReport(PushReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushReportWithOptions(request, runtime);
        }

        /**
         * @param request PushReportRequest
         * @return PushReportResponse
         */
        public async Task<PushReportResponse> PushReportAsync(PushReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushReportWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq PushSimpleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushSimpleResponse
         */
        public PushSimpleResponse PushSimpleWithOptions(PushSimpleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushSimpleShrinkRequest request = new PushSimpleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
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

        /**
         * @param tmpReq PushSimpleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushSimpleResponse
         */
        public async Task<PushSimpleResponse> PushSimpleWithOptionsAsync(PushSimpleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushSimpleShrinkRequest request = new PushSimpleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
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

        /**
         * @param request PushSimpleRequest
         * @return PushSimpleResponse
         */
        public PushSimpleResponse PushSimple(PushSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushSimpleWithOptions(request, runtime);
        }

        /**
         * @param request PushSimpleRequest
         * @return PushSimpleResponse
         */
        public async Task<PushSimpleResponse> PushSimpleAsync(PushSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushSimpleWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq PushTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushTemplateResponse
         */
        public PushTemplateResponse PushTemplateWithOptions(PushTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushTemplateShrinkRequest request = new PushTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
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

        /**
         * @param tmpReq PushTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushTemplateResponse
         */
        public async Task<PushTemplateResponse> PushTemplateWithOptionsAsync(PushTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushTemplateShrinkRequest request = new PushTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdChannelCategoryShrink))
            {
                body["ThirdChannelCategory"] = request.ThirdChannelCategoryShrink;
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

        /**
         * @param request PushTemplateRequest
         * @return PushTemplateResponse
         */
        public PushTemplateResponse PushTemplate(PushTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushTemplateWithOptions(request, runtime);
        }

        /**
         * @param request PushTemplateRequest
         * @return PushTemplateResponse
         */
        public async Task<PushTemplateResponse> PushTemplateAsync(PushTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request PushUnBindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushUnBindResponse
         */
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

        /**
         * @param request PushUnBindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushUnBindResponse
         */
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

        /**
         * @param request PushUnBindRequest
         * @return PushUnBindResponse
         */
        public PushUnBindResponse PushUnBind(PushUnBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushUnBindWithOptions(request, runtime);
        }

        /**
         * @param request PushUnBindRequest
         * @return PushUnBindResponse
         */
        public async Task<PushUnBindResponse> PushUnBindAsync(PushUnBindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushUnBindWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询Device+服务的
         *
         * @param request QueryInfoFromMdpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInfoFromMdpResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskScene))
            {
                body["RiskScene"] = request.RiskScene;
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

        /**
         * @summary 查询Device+服务的
         *
         * @param request QueryInfoFromMdpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInfoFromMdpResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskScene))
            {
                body["RiskScene"] = request.RiskScene;
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

        /**
         * @summary 查询Device+服务的
         *
         * @param request QueryInfoFromMdpRequest
         * @return QueryInfoFromMdpResponse
         */
        public QueryInfoFromMdpResponse QueryInfoFromMdp(QueryInfoFromMdpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInfoFromMdpWithOptions(request, runtime);
        }

        /**
         * @summary 查询Device+服务的
         *
         * @param request QueryInfoFromMdpRequest
         * @return QueryInfoFromMdpResponse
         */
        public async Task<QueryInfoFromMdpResponse> QueryInfoFromMdpAsync(QueryInfoFromMdpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInfoFromMdpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询短链
         *
         * @param request QueryLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryLinkResponse
         */
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

        /**
         * @summary 查询短链
         *
         * @param request QueryLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryLinkResponse
         */
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

        /**
         * @summary 查询短链
         *
         * @param request QueryLinkRequest
         * @return QueryLinkResponse
         */
        public QueryLinkResponse QueryLink(QueryLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLinkWithOptions(request, runtime);
        }

        /**
         * @summary 查询短链
         *
         * @param request QueryLinkRequest
         * @return QueryLinkResponse
         */
        public async Task<QueryLinkResponse> QueryLinkAsync(QueryLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMappCenterAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMappCenterAppResponse
         */
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

        /**
         * @param request QueryMappCenterAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMappCenterAppResponse
         */
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

        /**
         * @param request QueryMappCenterAppRequest
         * @return QueryMappCenterAppResponse
         */
        public QueryMappCenterAppResponse QueryMappCenterApp(QueryMappCenterAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMappCenterAppWithOptions(request, runtime);
        }

        /**
         * @param request QueryMappCenterAppRequest
         * @return QueryMappCenterAppResponse
         */
        public async Task<QueryMappCenterAppResponse> QueryMappCenterAppAsync(QueryMappCenterAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMappCenterAppWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMcdpAimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcdpAimResponse
         */
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

        /**
         * @param request QueryMcdpAimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcdpAimResponse
         */
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

        /**
         * @param request QueryMcdpAimRequest
         * @return QueryMcdpAimResponse
         */
        public QueryMcdpAimResponse QueryMcdpAim(QueryMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcdpAimWithOptions(request, runtime);
        }

        /**
         * @param request QueryMcdpAimRequest
         * @return QueryMcdpAimResponse
         */
        public async Task<QueryMcdpAimResponse> QueryMcdpAimAsync(QueryMcdpAimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcdpAimWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMcdpZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcdpZoneResponse
         */
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

        /**
         * @param request QueryMcdpZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcdpZoneResponse
         */
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

        /**
         * @param request QueryMcdpZoneRequest
         * @return QueryMcdpZoneResponse
         */
        public QueryMcdpZoneResponse QueryMcdpZone(QueryMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcdpZoneWithOptions(request, runtime);
        }

        /**
         * @param request QueryMcdpZoneRequest
         * @return QueryMcdpZoneResponse
         */
        public async Task<QueryMcdpZoneResponse> QueryMcdpZoneAsync(QueryMcdpZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcdpZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMcubeMiniPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcubeMiniPackageResponse
         */
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

        /**
         * @param request QueryMcubeMiniPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcubeMiniPackageResponse
         */
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

        /**
         * @param request QueryMcubeMiniPackageRequest
         * @return QueryMcubeMiniPackageResponse
         */
        public QueryMcubeMiniPackageResponse QueryMcubeMiniPackage(QueryMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcubeMiniPackageWithOptions(request, runtime);
        }

        /**
         * @param request QueryMcubeMiniPackageRequest
         * @return QueryMcubeMiniPackageResponse
         */
        public async Task<QueryMcubeMiniPackageResponse> QueryMcubeMiniPackageAsync(QueryMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcubeMiniPackageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMcubeMiniTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcubeMiniTaskResponse
         */
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

        /**
         * @param request QueryMcubeMiniTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcubeMiniTaskResponse
         */
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

        /**
         * @param request QueryMcubeMiniTaskRequest
         * @return QueryMcubeMiniTaskResponse
         */
        public QueryMcubeMiniTaskResponse QueryMcubeMiniTask(QueryMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcubeMiniTaskWithOptions(request, runtime);
        }

        /**
         * @param request QueryMcubeMiniTaskRequest
         * @return QueryMcubeMiniTaskResponse
         */
        public async Task<QueryMcubeMiniTaskResponse> QueryMcubeMiniTaskAsync(QueryMcubeMiniTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcubeMiniTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMcubeVhostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcubeVhostResponse
         */
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

        /**
         * @param request QueryMcubeVhostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMcubeVhostResponse
         */
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

        /**
         * @param request QueryMcubeVhostRequest
         * @return QueryMcubeVhostResponse
         */
        public QueryMcubeVhostResponse QueryMcubeVhost(QueryMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMcubeVhostWithOptions(request, runtime);
        }

        /**
         * @param request QueryMcubeVhostRequest
         * @return QueryMcubeVhostResponse
         */
        public async Task<QueryMcubeVhostResponse> QueryMcubeVhostAsync(QueryMcubeVhostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMcubeVhostWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMdsUpgradeTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMdsUpgradeTaskDetailResponse
         */
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

        /**
         * @param request QueryMdsUpgradeTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMdsUpgradeTaskDetailResponse
         */
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

        /**
         * @param request QueryMdsUpgradeTaskDetailRequest
         * @return QueryMdsUpgradeTaskDetailResponse
         */
        public QueryMdsUpgradeTaskDetailResponse QueryMdsUpgradeTaskDetail(QueryMdsUpgradeTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMdsUpgradeTaskDetailWithOptions(request, runtime);
        }

        /**
         * @param request QueryMdsUpgradeTaskDetailRequest
         * @return QueryMdsUpgradeTaskDetailResponse
         */
        public async Task<QueryMdsUpgradeTaskDetailResponse> QueryMdsUpgradeTaskDetailAsync(QueryMdsUpgradeTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMdsUpgradeTaskDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMgsApipageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMgsApipageResponse
         */
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

        /**
         * @param request QueryMgsApipageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMgsApipageResponse
         */
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

        /**
         * @param request QueryMgsApipageRequest
         * @return QueryMgsApipageResponse
         */
        public QueryMgsApipageResponse QueryMgsApipage(QueryMgsApipageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMgsApipageWithOptions(request, runtime);
        }

        /**
         * @param request QueryMgsApipageRequest
         * @return QueryMgsApipageResponse
         */
        public async Task<QueryMgsApipageResponse> QueryMgsApipageAsync(QueryMgsApipageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMgsApipageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMgsApirestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMgsApirestResponse
         */
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

        /**
         * @param request QueryMgsApirestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMgsApirestResponse
         */
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

        /**
         * @param request QueryMgsApirestRequest
         * @return QueryMgsApirestResponse
         */
        public QueryMgsApirestResponse QueryMgsApirest(QueryMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMgsApirestWithOptions(request, runtime);
        }

        /**
         * @param request QueryMgsApirestRequest
         * @return QueryMgsApirestResponse
         */
        public async Task<QueryMgsApirestResponse> QueryMgsApirestAsync(QueryMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMgsApirestWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMgsTestreqbodyautogenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMgsTestreqbodyautogenResponse
         */
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

        /**
         * @param request QueryMgsTestreqbodyautogenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMgsTestreqbodyautogenResponse
         */
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

        /**
         * @param request QueryMgsTestreqbodyautogenRequest
         * @return QueryMgsTestreqbodyautogenResponse
         */
        public QueryMgsTestreqbodyautogenResponse QueryMgsTestreqbodyautogen(QueryMgsTestreqbodyautogenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMgsTestreqbodyautogenWithOptions(request, runtime);
        }

        /**
         * @param request QueryMgsTestreqbodyautogenRequest
         * @return QueryMgsTestreqbodyautogenResponse
         */
        public async Task<QueryMgsTestreqbodyautogenResponse> QueryMgsTestreqbodyautogenAsync(QueryMgsTestreqbodyautogenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMgsTestreqbodyautogenWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMpsSchedulerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMpsSchedulerListResponse
         */
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

        /**
         * @param request QueryMpsSchedulerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMpsSchedulerListResponse
         */
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

        /**
         * @param request QueryMpsSchedulerListRequest
         * @return QueryMpsSchedulerListResponse
         */
        public QueryMpsSchedulerListResponse QueryMpsSchedulerList(QueryMpsSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMpsSchedulerListWithOptions(request, runtime);
        }

        /**
         * @param request QueryMpsSchedulerListRequest
         * @return QueryMpsSchedulerListResponse
         */
        public async Task<QueryMpsSchedulerListResponse> QueryMpsSchedulerListAsync(QueryMpsSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMpsSchedulerListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryPushAnalysisCoreIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushAnalysisCoreIndexResponse
         */
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

        /**
         * @param request QueryPushAnalysisCoreIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushAnalysisCoreIndexResponse
         */
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

        /**
         * @param request QueryPushAnalysisCoreIndexRequest
         * @return QueryPushAnalysisCoreIndexResponse
         */
        public QueryPushAnalysisCoreIndexResponse QueryPushAnalysisCoreIndex(QueryPushAnalysisCoreIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushAnalysisCoreIndexWithOptions(request, runtime);
        }

        /**
         * @param request QueryPushAnalysisCoreIndexRequest
         * @return QueryPushAnalysisCoreIndexResponse
         */
        public async Task<QueryPushAnalysisCoreIndexResponse> QueryPushAnalysisCoreIndexAsync(QueryPushAnalysisCoreIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushAnalysisCoreIndexWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryPushAnalysisTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushAnalysisTaskDetailResponse
         */
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

        /**
         * @param request QueryPushAnalysisTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushAnalysisTaskDetailResponse
         */
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

        /**
         * @param request QueryPushAnalysisTaskDetailRequest
         * @return QueryPushAnalysisTaskDetailResponse
         */
        public QueryPushAnalysisTaskDetailResponse QueryPushAnalysisTaskDetail(QueryPushAnalysisTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushAnalysisTaskDetailWithOptions(request, runtime);
        }

        /**
         * @param request QueryPushAnalysisTaskDetailRequest
         * @return QueryPushAnalysisTaskDetailResponse
         */
        public async Task<QueryPushAnalysisTaskDetailResponse> QueryPushAnalysisTaskDetailAsync(QueryPushAnalysisTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushAnalysisTaskDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryPushAnalysisTaskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushAnalysisTaskListResponse
         */
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

        /**
         * @param request QueryPushAnalysisTaskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushAnalysisTaskListResponse
         */
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

        /**
         * @param request QueryPushAnalysisTaskListRequest
         * @return QueryPushAnalysisTaskListResponse
         */
        public QueryPushAnalysisTaskListResponse QueryPushAnalysisTaskList(QueryPushAnalysisTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushAnalysisTaskListWithOptions(request, runtime);
        }

        /**
         * @param request QueryPushAnalysisTaskListRequest
         * @return QueryPushAnalysisTaskListResponse
         */
        public async Task<QueryPushAnalysisTaskListResponse> QueryPushAnalysisTaskListAsync(QueryPushAnalysisTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushAnalysisTaskListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryPushSchedulerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushSchedulerListResponse
         */
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

        /**
         * @param request QueryPushSchedulerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPushSchedulerListResponse
         */
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

        /**
         * @param request QueryPushSchedulerListRequest
         * @return QueryPushSchedulerListResponse
         */
        public QueryPushSchedulerListResponse QueryPushSchedulerList(QueryPushSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushSchedulerListWithOptions(request, runtime);
        }

        /**
         * @param request QueryPushSchedulerListRequest
         * @return QueryPushSchedulerListResponse
         */
        public async Task<QueryPushSchedulerListResponse> QueryPushSchedulerListAsync(QueryPushSchedulerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushSchedulerListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RevokePushMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokePushMessageResponse
         */
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

        /**
         * @param request RevokePushMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokePushMessageResponse
         */
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

        /**
         * @param request RevokePushMessageRequest
         * @return RevokePushMessageResponse
         */
        public RevokePushMessageResponse RevokePushMessage(RevokePushMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokePushMessageWithOptions(request, runtime);
        }

        /**
         * @param request RevokePushMessageRequest
         * @return RevokePushMessageResponse
         */
        public async Task<RevokePushMessageResponse> RevokePushMessageAsync(RevokePushMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokePushMessageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RevokePushTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokePushTaskResponse
         */
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

        /**
         * @param request RevokePushTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokePushTaskResponse
         */
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

        /**
         * @param request RevokePushTaskRequest
         * @return RevokePushTaskResponse
         */
        public RevokePushTaskResponse RevokePushTask(RevokePushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokePushTaskWithOptions(request, runtime);
        }

        /**
         * @param request RevokePushTaskRequest
         * @return RevokePushTaskResponse
         */
        public async Task<RevokePushTaskResponse> RevokePushTaskAsync(RevokePushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokePushTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RunMsaDiffRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunMsaDiffResponse
         */
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

        /**
         * @param request RunMsaDiffRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunMsaDiffResponse
         */
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

        /**
         * @param request RunMsaDiffRequest
         * @return RunMsaDiffResponse
         */
        public RunMsaDiffResponse RunMsaDiff(RunMsaDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunMsaDiffWithOptions(request, runtime);
        }

        /**
         * @param request RunMsaDiffRequest
         * @return RunMsaDiffResponse
         */
        public async Task<RunMsaDiffResponse> RunMsaDiffAsync(RunMsaDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunMsaDiffWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveMgsApirestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveMgsApirestResponse
         */
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

        /**
         * @param request SaveMgsApirestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveMgsApirestResponse
         */
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

        /**
         * @param request SaveMgsApirestRequest
         * @return SaveMgsApirestResponse
         */
        public SaveMgsApirestResponse SaveMgsApirest(SaveMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveMgsApirestWithOptions(request, runtime);
        }

        /**
         * @param request SaveMgsApirestRequest
         * @return SaveMgsApirestResponse
         */
        public async Task<SaveMgsApirestResponse> SaveMgsApirestAsync(SaveMgsApirestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveMgsApirestWithOptionsAsync(request, runtime);
        }

        /**
         * @param request StartUserAppAsyncEnhanceInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartUserAppAsyncEnhanceInMsaResponse
         */
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

        /**
         * @param request StartUserAppAsyncEnhanceInMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartUserAppAsyncEnhanceInMsaResponse
         */
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

        /**
         * @param request StartUserAppAsyncEnhanceInMsaRequest
         * @return StartUserAppAsyncEnhanceInMsaResponse
         */
        public StartUserAppAsyncEnhanceInMsaResponse StartUserAppAsyncEnhanceInMsa(StartUserAppAsyncEnhanceInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartUserAppAsyncEnhanceInMsaWithOptions(request, runtime);
        }

        /**
         * @param request StartUserAppAsyncEnhanceInMsaRequest
         * @return StartUserAppAsyncEnhanceInMsaResponse
         */
        public async Task<StartUserAppAsyncEnhanceInMsaResponse> StartUserAppAsyncEnhanceInMsaAsync(StartUserAppAsyncEnhanceInMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartUserAppAsyncEnhanceInMsaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateMcubeWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMcubeWhitelistResponse
         */
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

        /**
         * @param request UpdateMcubeWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMcubeWhitelistResponse
         */
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

        /**
         * @param request UpdateMcubeWhitelistRequest
         * @return UpdateMcubeWhitelistResponse
         */
        public UpdateMcubeWhitelistResponse UpdateMcubeWhitelist(UpdateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMcubeWhitelistWithOptions(request, runtime);
        }

        /**
         * @param request UpdateMcubeWhitelistRequest
         * @return UpdateMcubeWhitelistResponse
         */
        public async Task<UpdateMcubeWhitelistResponse> UpdateMcubeWhitelistAsync(UpdateMcubeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMcubeWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateMpaasAppInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMpaasAppInfoResponse
         */
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

        /**
         * @param request UpdateMpaasAppInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMpaasAppInfoResponse
         */
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

        /**
         * @param request UpdateMpaasAppInfoRequest
         * @return UpdateMpaasAppInfoResponse
         */
        public UpdateMpaasAppInfoResponse UpdateMpaasAppInfo(UpdateMpaasAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMpaasAppInfoWithOptions(request, runtime);
        }

        /**
         * @param request UpdateMpaasAppInfoRequest
         * @return UpdateMpaasAppInfoResponse
         */
        public async Task<UpdateMpaasAppInfoResponse> UpdateMpaasAppInfoAsync(UpdateMpaasAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMpaasAppInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 上传字节码到msa进行加固
         *
         * @param request UploadBitcodeToMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadBitcodeToMsaResponse
         */
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

        /**
         * @summary 上传字节码到msa进行加固
         *
         * @param request UploadBitcodeToMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadBitcodeToMsaResponse
         */
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

        /**
         * @summary 上传字节码到msa进行加固
         *
         * @param request UploadBitcodeToMsaRequest
         * @return UploadBitcodeToMsaResponse
         */
        public UploadBitcodeToMsaResponse UploadBitcodeToMsa(UploadBitcodeToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadBitcodeToMsaWithOptions(request, runtime);
        }

        /**
         * @summary 上传字节码到msa进行加固
         *
         * @param request UploadBitcodeToMsaRequest
         * @return UploadBitcodeToMsaResponse
         */
        public async Task<UploadBitcodeToMsaResponse> UploadBitcodeToMsaAsync(UploadBitcodeToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadBitcodeToMsaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UploadMcubeMiniPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadMcubeMiniPackageResponse
         */
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

        /**
         * @param request UploadMcubeMiniPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadMcubeMiniPackageResponse
         */
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

        /**
         * @param request UploadMcubeMiniPackageRequest
         * @return UploadMcubeMiniPackageResponse
         */
        public UploadMcubeMiniPackageResponse UploadMcubeMiniPackage(UploadMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMcubeMiniPackageWithOptions(request, runtime);
        }

        /**
         * @param request UploadMcubeMiniPackageRequest
         * @return UploadMcubeMiniPackageResponse
         */
        public async Task<UploadMcubeMiniPackageResponse> UploadMcubeMiniPackageAsync(UploadMcubeMiniPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMcubeMiniPackageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UploadMcubeRsaKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadMcubeRsaKeyResponse
         */
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

        /**
         * @param request UploadMcubeRsaKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadMcubeRsaKeyResponse
         */
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

        /**
         * @param request UploadMcubeRsaKeyRequest
         * @return UploadMcubeRsaKeyResponse
         */
        public UploadMcubeRsaKeyResponse UploadMcubeRsaKey(UploadMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMcubeRsaKeyWithOptions(request, runtime);
        }

        /**
         * @param request UploadMcubeRsaKeyRequest
         * @return UploadMcubeRsaKeyResponse
         */
        public async Task<UploadMcubeRsaKeyResponse> UploadMcubeRsaKeyAsync(UploadMcubeRsaKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMcubeRsaKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UploadUserAppToMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadUserAppToMsaResponse
         */
        public UploadUserAppToMsaResponse UploadUserAppToMsaWithOptions(UploadUserAppToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @param request UploadUserAppToMsaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadUserAppToMsaResponse
         */
        public async Task<UploadUserAppToMsaResponse> UploadUserAppToMsaWithOptionsAsync(UploadUserAppToMsaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @param request UploadUserAppToMsaRequest
         * @return UploadUserAppToMsaResponse
         */
        public UploadUserAppToMsaResponse UploadUserAppToMsa(UploadUserAppToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadUserAppToMsaWithOptions(request, runtime);
        }

        /**
         * @param request UploadUserAppToMsaRequest
         * @return UploadUserAppToMsaResponse
         */
        public async Task<UploadUserAppToMsaResponse> UploadUserAppToMsaAsync(UploadUserAppToMsaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadUserAppToMsaWithOptionsAsync(request, runtime);
        }

    }
}
