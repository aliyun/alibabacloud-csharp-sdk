// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MPaaS20200710.Models;

namespace AlibabaCloud.SDK.MPaaS20200710
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelMpsSchedulerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelMpsSchedulerResponse
        /// </returns>
        public CancelMpsSchedulerResponse CancelMpsSchedulerWithOptions(CancelMpsSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelMpsScheduler",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelMpsSchedulerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelMpsSchedulerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelMpsSchedulerResponse
        /// </returns>
        public async Task<CancelMpsSchedulerResponse> CancelMpsSchedulerWithOptionsAsync(CancelMpsSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelMpsScheduler",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelMpsSchedulerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelMpsSchedulerRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelMpsSchedulerResponse
        /// </returns>
        public CancelMpsSchedulerResponse CancelMpsScheduler(CancelMpsSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelMpsSchedulerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelMpsSchedulerRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelMpsSchedulerResponse
        /// </returns>
        public async Task<CancelMpsSchedulerResponse> CancelMpsSchedulerAsync(CancelMpsSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelMpsSchedulerWithOptionsAsync(request, runtime);
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务列表</para>
        /// </summary>
        /// 
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
                Version = "2020-07-10",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务列表</para>
        /// </summary>
        /// 
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
                Version = "2020-07-10",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务列表</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询定时任务列表</para>
        /// </summary>
        /// 
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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
                Version = "2020-07-10",
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

    }
}
