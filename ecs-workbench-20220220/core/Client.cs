// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ecs_workbench20220220.Models;

namespace AlibabaCloud.SDK.Ecs_workbench20220220
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecs-workbench", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 获取实例录屏配置
         *
         * @param request GetInstanceRecordConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceRecordConfigResponse
         */
        public GetInstanceRecordConfigResponse GetInstanceRecordConfigWithOptions(GetInstanceRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceRecordConfig",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceRecordConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例录屏配置
         *
         * @param request GetInstanceRecordConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceRecordConfigResponse
         */
        public async Task<GetInstanceRecordConfigResponse> GetInstanceRecordConfigWithOptionsAsync(GetInstanceRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceRecordConfig",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceRecordConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例录屏配置
         *
         * @param request GetInstanceRecordConfigRequest
         * @return GetInstanceRecordConfigResponse
         */
        public GetInstanceRecordConfigResponse GetInstanceRecordConfig(GetInstanceRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceRecordConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取实例录屏配置
         *
         * @param request GetInstanceRecordConfigRequest
         * @return GetInstanceRecordConfigResponse
         */
        public async Task<GetInstanceRecordConfigResponse> GetInstanceRecordConfigAsync(GetInstanceRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceRecordConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取实例录屏记录列表
         *
         * @param request ListInstanceRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceRecordsResponse
         */
        public ListInstanceRecordsResponse ListInstanceRecordsWithOptions(ListInstanceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceRecords",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例录屏记录列表
         *
         * @param request ListInstanceRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceRecordsResponse
         */
        public async Task<ListInstanceRecordsResponse> ListInstanceRecordsWithOptionsAsync(ListInstanceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceRecords",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例录屏记录列表
         *
         * @param request ListInstanceRecordsRequest
         * @return ListInstanceRecordsResponse
         */
        public ListInstanceRecordsResponse ListInstanceRecords(ListInstanceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 获取实例录屏记录列表
         *
         * @param request ListInstanceRecordsRequest
         * @return ListInstanceRecordsResponse
         */
        public async Task<ListInstanceRecordsResponse> ListInstanceRecordsAsync(ListInstanceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 登录实例
         *
         * @param request LoginInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LoginInstanceResponse
         */
        public LoginInstanceResponse LoginInstanceWithOptions(LoginInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLoginInfo))
            {
                query["InstanceLoginInfo"] = request.InstanceLoginInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerInfo))
            {
                query["PartnerInfo"] = request.PartnerInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccount))
            {
                query["UserAccount"] = request.UserAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginInstance",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 登录实例
         *
         * @param request LoginInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LoginInstanceResponse
         */
        public async Task<LoginInstanceResponse> LoginInstanceWithOptionsAsync(LoginInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLoginInfo))
            {
                query["InstanceLoginInfo"] = request.InstanceLoginInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerInfo))
            {
                query["PartnerInfo"] = request.PartnerInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccount))
            {
                query["UserAccount"] = request.UserAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginInstance",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoginInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 登录实例
         *
         * @param request LoginInstanceRequest
         * @return LoginInstanceResponse
         */
        public LoginInstanceResponse LoginInstance(LoginInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoginInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 登录实例
         *
         * @param request LoginInstanceRequest
         * @return LoginInstanceResponse
         */
        public async Task<LoginInstanceResponse> LoginInstanceAsync(LoginInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoginInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置实例录屏配置
         *
         * @param request SetInstanceRecordConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetInstanceRecordConfigResponse
         */
        public SetInstanceRecordConfigResponse SetInstanceRecordConfigWithOptions(SetInstanceRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationDays))
            {
                body["ExpirationDays"] = request.ExpirationDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordStorageTarget))
            {
                body["RecordStorageTarget"] = request.RecordStorageTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetInstanceRecordConfig",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInstanceRecordConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置实例录屏配置
         *
         * @param request SetInstanceRecordConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetInstanceRecordConfigResponse
         */
        public async Task<SetInstanceRecordConfigResponse> SetInstanceRecordConfigWithOptionsAsync(SetInstanceRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationDays))
            {
                body["ExpirationDays"] = request.ExpirationDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordStorageTarget))
            {
                body["RecordStorageTarget"] = request.RecordStorageTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetInstanceRecordConfig",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetInstanceRecordConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置实例录屏配置
         *
         * @param request SetInstanceRecordConfigRequest
         * @return SetInstanceRecordConfigResponse
         */
        public SetInstanceRecordConfigResponse SetInstanceRecordConfig(SetInstanceRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceRecordConfigWithOptions(request, runtime);
        }

        /**
         * @summary 设置实例录屏配置
         *
         * @param request SetInstanceRecordConfigRequest
         * @return SetInstanceRecordConfigResponse
         */
        public async Task<SetInstanceRecordConfigResponse> SetInstanceRecordConfigAsync(SetInstanceRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceRecordConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看实例录屏内容
         *
         * @param request ViewInstanceRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ViewInstanceRecordsResponse
         */
        public ViewInstanceRecordsResponse ViewInstanceRecordsWithOptions(ViewInstanceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalSessionToken))
            {
                body["TerminalSessionToken"] = request.TerminalSessionToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ViewInstanceRecords",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ViewInstanceRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看实例录屏内容
         *
         * @param request ViewInstanceRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ViewInstanceRecordsResponse
         */
        public async Task<ViewInstanceRecordsResponse> ViewInstanceRecordsWithOptionsAsync(ViewInstanceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalSessionToken))
            {
                body["TerminalSessionToken"] = request.TerminalSessionToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ViewInstanceRecords",
                Version = "2022-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ViewInstanceRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看实例录屏内容
         *
         * @param request ViewInstanceRecordsRequest
         * @return ViewInstanceRecordsResponse
         */
        public ViewInstanceRecordsResponse ViewInstanceRecords(ViewInstanceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ViewInstanceRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 查看实例录屏内容
         *
         * @param request ViewInstanceRecordsRequest
         * @return ViewInstanceRecordsResponse
         */
        public async Task<ViewInstanceRecordsResponse> ViewInstanceRecordsAsync(ViewInstanceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ViewInstanceRecordsWithOptionsAsync(request, runtime);
        }

    }
}
