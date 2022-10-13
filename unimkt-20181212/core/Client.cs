// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.UniMkt20181212.Models;

namespace AlibabaCloud.SDK.UniMkt20181212
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "cloudcode.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "cloudcode.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("unimkt", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ChangeMediaStatusResponse ChangeMediaStatusWithOptions(ChangeMediaStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                body["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                body["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMediaStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMediaStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeMediaStatusResponse> ChangeMediaStatusWithOptionsAsync(ChangeMediaStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                body["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                body["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMediaStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMediaStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeMediaStatusResponse ChangeMediaStatus(ChangeMediaStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMediaStatusWithOptions(request, runtime);
        }

        public async Task<ChangeMediaStatusResponse> ChangeMediaStatusAsync(ChangeMediaStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMediaStatusWithOptionsAsync(request, runtime);
        }

        public ChangeSlotStatusResponse ChangeSlotStatusWithOptions(ChangeSlotStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotCorporateStatus))
            {
                body["AdSlotCorporateStatus"] = request.AdSlotCorporateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                body["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotStatus))
            {
                body["AdSlotStatus"] = request.AdSlotStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeSlotStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeSlotStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeSlotStatusResponse> ChangeSlotStatusWithOptionsAsync(ChangeSlotStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotCorporateStatus))
            {
                body["AdSlotCorporateStatus"] = request.AdSlotCorporateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                body["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotStatus))
            {
                body["AdSlotStatus"] = request.AdSlotStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeSlotStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeSlotStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeSlotStatusResponse ChangeSlotStatus(ChangeSlotStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeSlotStatusWithOptions(request, runtime);
        }

        public async Task<ChangeSlotStatusResponse> ChangeSlotStatusAsync(ChangeSlotStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeSlotStatusWithOptionsAsync(request, runtime);
        }

        public ChangeTenantStatusResponse ChangeTenantStatusWithOptions(ChangeTenantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeTenantStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeTenantStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeTenantStatusResponse> ChangeTenantStatusWithOptionsAsync(ChangeTenantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeTenantStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeTenantStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeTenantStatusResponse ChangeTenantStatus(ChangeTenantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeTenantStatusWithOptions(request, runtime);
        }

        public async Task<ChangeTenantStatusResponse> ChangeTenantStatusAsync(ChangeTenantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeTenantStatusWithOptionsAsync(request, runtime);
        }

        public ChangeTenantUserStatusResponse ChangeTenantUserStatusWithOptions(ChangeTenantUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeTenantUserStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeTenantUserStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeTenantUserStatusResponse> ChangeTenantUserStatusWithOptionsAsync(ChangeTenantUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["MessageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeTenantUserStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeTenantUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeTenantUserStatusResponse ChangeTenantUserStatus(ChangeTenantUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeTenantUserStatusWithOptions(request, runtime);
        }

        public async Task<ChangeTenantUserStatusResponse> ChangeTenantUserStatusAsync(ChangeTenantUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeTenantUserStatusWithOptionsAsync(request, runtime);
        }

        public ChargeLaunchResponse ChargeLaunchWithOptions(ChargeLaunchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                query["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                query["OuterCode"] = request.OuterCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChargeLaunch",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChargeLaunchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChargeLaunchResponse> ChargeLaunchWithOptionsAsync(ChargeLaunchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                query["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                query["OuterCode"] = request.OuterCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChargeLaunch",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChargeLaunchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChargeLaunchResponse ChargeLaunch(ChargeLaunchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChargeLaunchWithOptions(request, runtime);
        }

        public async Task<ChargeLaunchResponse> ChargeLaunchAsync(ChargeLaunchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChargeLaunchWithOptionsAsync(request, runtime);
        }

        public CheckDeviceResponse CheckDeviceWithOptions(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevice",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDeviceResponse> CheckDeviceWithOptionsAsync(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevice",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDeviceResponse CheckDevice(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDeviceWithOptions(request, runtime);
        }

        public async Task<CheckDeviceResponse> CheckDeviceAsync(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDeviceWithOptionsAsync(request, runtime);
        }

        public CheckReceivingDetailResponse CheckReceivingDetailWithOptions(CheckReceivingDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["DeviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                body["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckReceivingDetail",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckReceivingDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckReceivingDetailResponse> CheckReceivingDetailWithOptionsAsync(CheckReceivingDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["DeviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                body["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckReceivingDetail",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckReceivingDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckReceivingDetailResponse CheckReceivingDetail(CheckReceivingDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckReceivingDetailWithOptions(request, runtime);
        }

        public async Task<CheckReceivingDetailResponse> CheckReceivingDetailAsync(CheckReceivingDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckReceivingDetailWithOptionsAsync(request, runtime);
        }

        public CheckTenantBizResponse CheckTenantBizWithOptions(CheckTenantBizRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTenantBiz",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTenantBizResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckTenantBizResponse> CheckTenantBizWithOptionsAsync(CheckTenantBizRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTenantBiz",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTenantBizResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckTenantBizResponse CheckTenantBiz(CheckTenantBizRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTenantBizWithOptions(request, runtime);
        }

        public async Task<CheckTenantBizResponse> CheckTenantBizAsync(CheckTenantBizRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTenantBizWithOptionsAsync(request, runtime);
        }

        public CheckUserFinishAdResponse CheckUserFinishAdWithOptions(CheckUserFinishAdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adid))
            {
                query["Adid"] = request.Adid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clicklink))
            {
                query["Clicklink"] = request.Clicklink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mediaid))
            {
                query["Mediaid"] = request.Mediaid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tagid))
            {
                query["Tagid"] = request.Tagid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUserFinishAd",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserFinishAdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckUserFinishAdResponse> CheckUserFinishAdWithOptionsAsync(CheckUserFinishAdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adid))
            {
                query["Adid"] = request.Adid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clicklink))
            {
                query["Clicklink"] = request.Clicklink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mediaid))
            {
                query["Mediaid"] = request.Mediaid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tagid))
            {
                query["Tagid"] = request.Tagid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUserFinishAd",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserFinishAdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckUserFinishAdResponse CheckUserFinishAd(CheckUserFinishAdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUserFinishAdWithOptions(request, runtime);
        }

        public async Task<CheckUserFinishAdResponse> CheckUserFinishAdAsync(CheckUserFinishAdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUserFinishAdWithOptionsAsync(request, runtime);
        }

        public CountUserResponse CountUserWithOptions(CountUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CountUserShrinkRequest request = new CountUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CountUserResponse> CountUserWithOptionsAsync(CountUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CountUserShrinkRequest request = new CountUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CountUserResponse CountUser(CountUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountUserWithOptions(request, runtime);
        }

        public async Task<CountUserResponse> CountUserAsync(CountUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountUserWithOptionsAsync(request, runtime);
        }

        public CreateCalculationResponse CreateCalculationWithOptions(CreateCalculationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCodeUserId))
            {
                query["CloudCodeUserId"] = request.CloudCodeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryString))
            {
                query["QueryString"] = request.QueryString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCalculation",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCalculationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCalculationResponse> CreateCalculationWithOptionsAsync(CreateCalculationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCodeUserId))
            {
                query["CloudCodeUserId"] = request.CloudCodeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryString))
            {
                query["QueryString"] = request.QueryString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCalculation",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCalculationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCalculationResponse CreateCalculation(CreateCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCalculationWithOptions(request, runtime);
        }

        public async Task<CreateCalculationResponse> CreateCalculationAsync(CreateCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCalculationWithOptionsAsync(request, runtime);
        }

        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowShrinkRequest request = new CreateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Flow))
            {
                request.FlowShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Flow, "Flow", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowShrink))
            {
                body["Flow"] = request.FlowShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowShrinkRequest request = new CreateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Flow))
            {
                request.FlowShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Flow, "Flow", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowShrink))
            {
                body["Flow"] = request.FlowShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowWithOptions(request, runtime);
        }

        public async Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowWithOptionsAsync(request, runtime);
        }

        public CreateMediaResponse CreateMediaWithOptions(CreateMediaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMediaShrinkRequest request = new CreateMediaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Media))
            {
                request.MediaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Media, "Media", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaShrink))
            {
                body["Media"] = request.MediaShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMediaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMediaResponse> CreateMediaWithOptionsAsync(CreateMediaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMediaShrinkRequest request = new CreateMediaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Media))
            {
                request.MediaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Media, "Media", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaShrink))
            {
                body["Media"] = request.MediaShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMediaResponse CreateMedia(CreateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMediaWithOptions(request, runtime);
        }

        public async Task<CreateMediaResponse> CreateMediaAsync(CreateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMediaWithOptionsAsync(request, runtime);
        }

        public CreateProxyBrandUserResponse CreateProxyBrandUserWithOptions(CreateProxyBrandUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Company))
            {
                query["Company"] = request.Company;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["Industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProxyBrandUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProxyBrandUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProxyBrandUserResponse> CreateProxyBrandUserWithOptionsAsync(CreateProxyBrandUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Company))
            {
                query["Company"] = request.Company;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["Industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProxyBrandUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProxyBrandUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateProxyBrandUserResponse CreateProxyBrandUser(CreateProxyBrandUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProxyBrandUserWithOptions(request, runtime);
        }

        public async Task<CreateProxyBrandUserResponse> CreateProxyBrandUserAsync(CreateProxyBrandUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProxyBrandUserWithOptionsAsync(request, runtime);
        }

        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRuleShrinkRequest request = new CreateRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdRule))
            {
                request.AdRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdRule, "AdRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdRuleShrink))
            {
                body["AdRule"] = request.AdRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRuleShrinkRequest request = new CreateRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdRule))
            {
                request.AdRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdRule, "AdRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdRuleShrink))
            {
                body["AdRule"] = request.AdRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        public CreateSlotResponse CreateSlotWithOptions(CreateSlotRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSlotShrinkRequest request = new CreateSlotShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlot))
            {
                request.AdSlotShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlot, "AdSlot", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotShrink))
            {
                body["AdSlot"] = request.AdSlotShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSlotResponse> CreateSlotWithOptionsAsync(CreateSlotRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSlotShrinkRequest request = new CreateSlotShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlot))
            {
                request.AdSlotShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlot, "AdSlot", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotShrink))
            {
                body["AdSlot"] = request.AdSlotShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSlotResponse CreateSlot(CreateSlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSlotWithOptions(request, runtime);
        }

        public async Task<CreateSlotResponse> CreateSlotAsync(CreateSlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSlotWithOptionsAsync(request, runtime);
        }

        public CreateTenantResponse CreateTenantWithOptions(CreateTenantRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantShrinkRequest request = new CreateTenantShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tenant))
            {
                request.TenantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tenant, "Tenant", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantShrink))
            {
                body["Tenant"] = request.TenantShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenant",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTenantResponse> CreateTenantWithOptionsAsync(CreateTenantRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantShrinkRequest request = new CreateTenantShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tenant))
            {
                request.TenantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tenant, "Tenant", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantShrink))
            {
                body["Tenant"] = request.TenantShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenant",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTenantResponse CreateTenant(CreateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantWithOptions(request, runtime);
        }

        public async Task<CreateTenantResponse> CreateTenantAsync(CreateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantWithOptionsAsync(request, runtime);
        }

        public CreateTenantUserResponse CreateTenantUserWithOptions(CreateTenantUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantUserShrinkRequest request = new CreateTenantUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantUser))
            {
                request.TenantUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantUser, "TenantUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantUserShrink))
            {
                body["TenantUser"] = request.TenantUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTenantUserResponse> CreateTenantUserWithOptionsAsync(CreateTenantUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantUserShrinkRequest request = new CreateTenantUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantUser))
            {
                request.TenantUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantUser, "TenantUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantUserShrink))
            {
                body["TenantUser"] = request.TenantUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTenantUserResponse CreateTenantUser(CreateTenantUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantUserWithOptions(request, runtime);
        }

        public async Task<CreateTenantUserResponse> CreateTenantUserAsync(CreateTenantUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantUserWithOptionsAsync(request, runtime);
        }

        public CreateUnionTaskResponse CreateUnionTaskWithOptions(CreateUnionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUnionTaskShrinkRequest request = new CreateUnionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaIdBlackList))
            {
                request.MediaIdBlackListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaIdBlackList, "MediaIdBlackList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaIdWhiteList))
            {
                request.MediaIdWhiteListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaIdWhiteList, "MediaIdWhiteList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorId))
            {
                query["AnchorId"] = request.AnchorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentUrl))
            {
                query["ContentUrl"] = request.ContentUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomCreativeType))
            {
                query["CustomCreativeType"] = request.CustomCreativeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryLabelBagId))
            {
                query["IndustryLabelBagId"] = request.IndustryLabelBagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIdBlackListShrink))
            {
                query["MediaIdBlackList"] = request.MediaIdBlackListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIdWhiteListShrink))
            {
                query["MediaIdWhiteList"] = request.MediaIdWhiteListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIndustry))
            {
                query["MediaIndustry"] = request.MediaIndustry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaDay))
            {
                query["QuotaDay"] = request.QuotaDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizType))
            {
                query["TaskBizType"] = request.TaskBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRuleType))
            {
                query["TaskRuleType"] = request.TaskRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUnionTask",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUnionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUnionTaskResponse> CreateUnionTaskWithOptionsAsync(CreateUnionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUnionTaskShrinkRequest request = new CreateUnionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaIdBlackList))
            {
                request.MediaIdBlackListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaIdBlackList, "MediaIdBlackList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaIdWhiteList))
            {
                request.MediaIdWhiteListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaIdWhiteList, "MediaIdWhiteList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorId))
            {
                query["AnchorId"] = request.AnchorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentUrl))
            {
                query["ContentUrl"] = request.ContentUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomCreativeType))
            {
                query["CustomCreativeType"] = request.CustomCreativeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryLabelBagId))
            {
                query["IndustryLabelBagId"] = request.IndustryLabelBagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIdBlackListShrink))
            {
                query["MediaIdBlackList"] = request.MediaIdBlackListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIdWhiteListShrink))
            {
                query["MediaIdWhiteList"] = request.MediaIdWhiteListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIndustry))
            {
                query["MediaIndustry"] = request.MediaIndustry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaDay))
            {
                query["QuotaDay"] = request.QuotaDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizType))
            {
                query["TaskBizType"] = request.TaskBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRuleType))
            {
                query["TaskRuleType"] = request.TaskRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUnionTask",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUnionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateUnionTaskResponse CreateUnionTask(CreateUnionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUnionTaskWithOptions(request, runtime);
        }

        public async Task<CreateUnionTaskResponse> CreateUnionTaskAsync(CreateUnionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUnionTaskWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserShrinkRequest request = new CreateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserShrinkRequest request = new CreateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        public CreatesSlotTemplateResponse CreatesSlotTemplateWithOptions(CreatesSlotTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatesSlotTemplateShrinkRequest request = new CreatesSlotTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlotTemplate))
            {
                request.AdSlotTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlotTemplate, "AdSlotTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotTemplateShrink))
            {
                body["AdSlotTemplate"] = request.AdSlotTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatesSlotTemplate",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatesSlotTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatesSlotTemplateResponse> CreatesSlotTemplateWithOptionsAsync(CreatesSlotTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatesSlotTemplateShrinkRequest request = new CreatesSlotTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlotTemplate))
            {
                request.AdSlotTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlotTemplate, "AdSlotTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotTemplateShrink))
            {
                body["AdSlotTemplate"] = request.AdSlotTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatesSlotTemplate",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatesSlotTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatesSlotTemplateResponse CreatesSlotTemplate(CreatesSlotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatesSlotTemplateWithOptions(request, runtime);
        }

        public async Task<CreatesSlotTemplateResponse> CreatesSlotTemplateAsync(CreatesSlotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatesSlotTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteRuleShrinkRequest request = new DeleteRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdRule))
            {
                request.AdRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdRule, "AdRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                query["MessageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdRuleShrink))
            {
                body["AdRule"] = request.AdRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteRuleShrinkRequest request = new DeleteRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdRule))
            {
                request.AdRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdRule, "AdRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                query["MessageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdRuleShrink))
            {
                body["AdRule"] = request.AdRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        public DeviceApiAddDeviceResponse DeviceApiAddDeviceWithOptions(DeviceApiAddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceModelNumber))
            {
                body["DeviceModelNumber"] = request.DeviceModelNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.District))
            {
                body["District"] = request.District;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraMap))
            {
                body["ExtraMap"] = request.ExtraMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                body["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["Floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationName))
            {
                body["LocationName"] = request.LocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                body["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                body["SecondScene"] = request.SecondScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceApiAddDevice",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceApiAddDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeviceApiAddDeviceResponse> DeviceApiAddDeviceWithOptionsAsync(DeviceApiAddDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceModelNumber))
            {
                body["DeviceModelNumber"] = request.DeviceModelNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.District))
            {
                body["District"] = request.District;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraMap))
            {
                body["ExtraMap"] = request.ExtraMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                body["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["Floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationName))
            {
                body["LocationName"] = request.LocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                body["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                body["SecondScene"] = request.SecondScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceApiAddDevice",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceApiAddDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeviceApiAddDeviceResponse DeviceApiAddDevice(DeviceApiAddDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeviceApiAddDeviceWithOptions(request, runtime);
        }

        public async Task<DeviceApiAddDeviceResponse> DeviceApiAddDeviceAsync(DeviceApiAddDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeviceApiAddDeviceWithOptionsAsync(request, runtime);
        }

        public EndUnionTaskResponse EndUnionTaskWithOptions(EndUnionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndUnionTask",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndUnionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EndUnionTaskResponse> EndUnionTaskWithOptionsAsync(EndUnionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndUnionTask",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndUnionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EndUnionTaskResponse EndUnionTask(EndUnionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EndUnionTaskWithOptions(request, runtime);
        }

        public async Task<EndUnionTaskResponse> EndUnionTaskAsync(EndUnionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EndUnionTaskWithOptionsAsync(request, runtime);
        }

        public GetBizTypeConfigResponse GetBizTypeConfigWithOptions(GetBizTypeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizTypeConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizTypeConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBizTypeConfigResponse> GetBizTypeConfigWithOptionsAsync(GetBizTypeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizTypeConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizTypeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBizTypeConfigResponse GetBizTypeConfig(GetBizTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBizTypeConfigWithOptions(request, runtime);
        }

        public async Task<GetBizTypeConfigResponse> GetBizTypeConfigAsync(GetBizTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBizTypeConfigWithOptionsAsync(request, runtime);
        }

        public GetBizTypeConfigListResponse GetBizTypeConfigListWithOptions(GetBizTypeConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizTypeConfigList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizTypeConfigListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBizTypeConfigListResponse> GetBizTypeConfigListWithOptionsAsync(GetBizTypeConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizTypeConfigList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizTypeConfigListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBizTypeConfigListResponse GetBizTypeConfigList(GetBizTypeConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBizTypeConfigListWithOptions(request, runtime);
        }

        public async Task<GetBizTypeConfigListResponse> GetBizTypeConfigListAsync(GetBizTypeConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBizTypeConfigListWithOptionsAsync(request, runtime);
        }

        public GetDeliveryTypeConfigResponse GetDeliveryTypeConfigWithOptions(GetDeliveryTypeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryTypeConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryTypeConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDeliveryTypeConfigResponse> GetDeliveryTypeConfigWithOptionsAsync(GetDeliveryTypeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryType))
            {
                body["DeliveryType"] = request.DeliveryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryTypeConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryTypeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDeliveryTypeConfigResponse GetDeliveryTypeConfig(GetDeliveryTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeliveryTypeConfigWithOptions(request, runtime);
        }

        public async Task<GetDeliveryTypeConfigResponse> GetDeliveryTypeConfigAsync(GetDeliveryTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeliveryTypeConfigWithOptionsAsync(request, runtime);
        }

        public GetDeliveryTypeConfigListResponse GetDeliveryTypeConfigListWithOptions(GetDeliveryTypeConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryTypeConfigList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryTypeConfigListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDeliveryTypeConfigListResponse> GetDeliveryTypeConfigListWithOptionsAsync(GetDeliveryTypeConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryTypeConfigList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryTypeConfigListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDeliveryTypeConfigListResponse GetDeliveryTypeConfigList(GetDeliveryTypeConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeliveryTypeConfigListWithOptions(request, runtime);
        }

        public async Task<GetDeliveryTypeConfigListResponse> GetDeliveryTypeConfigListAsync(GetDeliveryTypeConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeliveryTypeConfigListWithOptionsAsync(request, runtime);
        }

        public GetMainPartListResponse GetMainPartListWithOptions(GetMainPartListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainName))
            {
                query["MainName"] = request.MainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainType))
            {
                query["MainType"] = request.MainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentMainId))
            {
                query["ParentMainId"] = request.ParentMainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMainPartList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMainPartListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMainPartListResponse> GetMainPartListWithOptionsAsync(GetMainPartListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainName))
            {
                query["MainName"] = request.MainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainType))
            {
                query["MainType"] = request.MainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentMainId))
            {
                query["ParentMainId"] = request.ParentMainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMainPartList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMainPartListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMainPartListResponse GetMainPartList(GetMainPartListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMainPartListWithOptions(request, runtime);
        }

        public async Task<GetMainPartListResponse> GetMainPartListAsync(GetMainPartListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMainPartListWithOptionsAsync(request, runtime);
        }

        public GetProductConfigResponse GetProductConfigWithOptions(GetProductConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProductConfigResponse> GetProductConfigWithOptionsAsync(GetProductConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProductConfigResponse GetProductConfig(GetProductConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductConfigWithOptions(request, runtime);
        }

        public async Task<GetProductConfigResponse> GetProductConfigAsync(GetProductConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductConfigWithOptionsAsync(request, runtime);
        }

        public GetPublishPriceTaskResponse GetPublishPriceTaskWithOptions(GetPublishPriceTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublishPriceTask",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublishPriceTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPublishPriceTaskResponse> GetPublishPriceTaskWithOptionsAsync(GetPublishPriceTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublishPriceTask",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublishPriceTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPublishPriceTaskResponse GetPublishPriceTask(GetPublishPriceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublishPriceTaskWithOptions(request, runtime);
        }

        public async Task<GetPublishPriceTaskResponse> GetPublishPriceTaskAsync(GetPublishPriceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublishPriceTaskWithOptionsAsync(request, runtime);
        }

        public GetUnionTaskStatusResponse GetUnionTaskStatusWithOptions(GetUnionTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnionTaskStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnionTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUnionTaskStatusResponse> GetUnionTaskStatusWithOptionsAsync(GetUnionTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnionTaskStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnionTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUnionTaskStatusResponse GetUnionTaskStatus(GetUnionTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUnionTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetUnionTaskStatusResponse> GetUnionTaskStatusAsync(GetUnionTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUnionTaskStatusWithOptionsAsync(request, runtime);
        }

        public InnerCallServiceResponse InnerCallServiceWithOptions(InnerCallServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InnerCallService",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InnerCallServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InnerCallServiceResponse> InnerCallServiceWithOptionsAsync(InnerCallServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InnerCallService",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InnerCallServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InnerCallServiceResponse InnerCallService(InnerCallServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InnerCallServiceWithOptions(request, runtime);
        }

        public async Task<InnerCallServiceResponse> InnerCallServiceAsync(InnerCallServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InnerCallServiceWithOptionsAsync(request, runtime);
        }

        public KeepAliveResponse KeepAliveWithOptions(KeepAliveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CellId))
            {
                body["CellId"] = request.CellId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tac))
            {
                body["Tac"] = request.Tac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KeepAlive",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KeepAliveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<KeepAliveResponse> KeepAliveWithOptionsAsync(KeepAliveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CellId))
            {
                body["CellId"] = request.CellId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tac))
            {
                body["Tac"] = request.Tac;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KeepAlive",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KeepAliveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public KeepAliveResponse KeepAlive(KeepAliveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KeepAliveWithOptions(request, runtime);
        }

        public async Task<KeepAliveResponse> KeepAliveAsync(KeepAliveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KeepAliveWithOptionsAsync(request, runtime);
        }

        public ListFlowResponse ListFlowWithOptions(ListFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFlowShrinkRequest request = new ListFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListFlow))
            {
                request.ListFlowShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListFlow, "ListFlow", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListFlowShrink))
            {
                body["ListFlow"] = request.ListFlowShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowResponse> ListFlowWithOptionsAsync(ListFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFlowShrinkRequest request = new ListFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListFlow))
            {
                request.ListFlowShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListFlow, "ListFlow", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListFlowShrink))
            {
                body["ListFlow"] = request.ListFlowShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowResponse ListFlow(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowWithOptions(request, runtime);
        }

        public async Task<ListFlowResponse> ListFlowAsync(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowWithOptionsAsync(request, runtime);
        }

        public ListMediaResponse ListMediaWithOptions(ListMediaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMediaShrinkRequest request = new ListMediaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                query["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                query["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                query["SecondScene"] = request.SecondScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMediaResponse> ListMediaWithOptionsAsync(ListMediaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMediaShrinkRequest request = new ListMediaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                query["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                query["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                query["SecondScene"] = request.SecondScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMediaResponse ListMedia(ListMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaWithOptions(request, runtime);
        }

        public async Task<ListMediaResponse> ListMediaAsync(ListMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaWithOptionsAsync(request, runtime);
        }

        public ListMediaNameResponse ListMediaNameWithOptions(ListMediaNameRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMediaNameShrinkRequest request = new ListMediaNameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                query["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                query["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                query["SecondScene"] = request.SecondScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaName",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMediaNameResponse> ListMediaNameWithOptionsAsync(ListMediaNameRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMediaNameShrinkRequest request = new ListMediaNameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessStatus))
            {
                query["AccessStatus"] = request.AccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                query["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                query["SecondScene"] = request.SecondScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaName",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMediaNameResponse ListMediaName(ListMediaNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaNameWithOptions(request, runtime);
        }

        public async Task<ListMediaNameResponse> ListMediaNameAsync(ListMediaNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaNameWithOptionsAsync(request, runtime);
        }

        public ListRuleResponse ListRuleWithOptions(ListRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaName))
            {
                query["MediaName"] = request.MediaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRuleResponse> ListRuleWithOptionsAsync(ListRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaName))
            {
                query["MediaName"] = request.MediaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRuleResponse ListRule(ListRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRuleWithOptions(request, runtime);
        }

        public async Task<ListRuleResponse> ListRuleAsync(ListRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRuleWithOptionsAsync(request, runtime);
        }

        public ListRuleAreaResponse ListRuleAreaWithOptions(ListRuleAreaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuleArea",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleAreaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRuleAreaResponse> ListRuleAreaWithOptionsAsync(ListRuleAreaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaStatus))
            {
                query["MediaStatus"] = request.MediaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuleArea",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleAreaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRuleAreaResponse ListRuleArea(ListRuleAreaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRuleAreaWithOptions(request, runtime);
        }

        public async Task<ListRuleAreaResponse> ListRuleAreaAsync(ListRuleAreaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRuleAreaWithOptionsAsync(request, runtime);
        }

        public ListSlotResponse ListSlotWithOptions(ListSlotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotCorporateStatus))
            {
                query["AdSlotCorporateStatus"] = request.AdSlotCorporateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotStatus))
            {
                query["AdSlotStatus"] = request.AdSlotStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaName))
            {
                query["MediaName"] = request.MediaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSlotResponse> ListSlotWithOptionsAsync(ListSlotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotCorporateStatus))
            {
                query["AdSlotCorporateStatus"] = request.AdSlotCorporateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotStatus))
            {
                query["AdSlotStatus"] = request.AdSlotStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaName))
            {
                query["MediaName"] = request.MediaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSlotResponse ListSlot(ListSlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSlotWithOptions(request, runtime);
        }

        public async Task<ListSlotResponse> ListSlotAsync(ListSlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSlotWithOptionsAsync(request, runtime);
        }

        public ListTasksResponse ListTasksWithOptions(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                body["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrencyType))
            {
                body["CurrencyType"] = request.CurrencyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketingType))
            {
                body["MarketingType"] = request.MarketingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserNick))
            {
                body["ProxyUserNick"] = request.ProxyUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                body["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrencyType))
            {
                body["CurrencyType"] = request.CurrencyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketingType))
            {
                body["MarketingType"] = request.MarketingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserNick))
            {
                body["ProxyUserNick"] = request.ProxyUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTasksWithOptions(request, runtime);
        }

        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTasksWithOptionsAsync(request, runtime);
        }

        public ListTenantResponse ListTenantWithOptions(ListTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                query["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenant",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTenantResponse> ListTenantWithOptionsAsync(ListTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                query["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenant",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTenantResponse ListTenant(ListTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTenantWithOptions(request, runtime);
        }

        public async Task<ListTenantResponse> ListTenantAsync(ListTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTenantWithOptionsAsync(request, runtime);
        }

        public ListTenantNameResponse ListTenantNameWithOptions(ListTenantNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                query["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantName",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTenantNameResponse> ListTenantNameWithOptionsAsync(ListTenantNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCreateTime))
            {
                query["StartCreateTime"] = request.StartCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                query["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantName",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTenantNameResponse ListTenantName(ListTenantNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTenantNameWithOptions(request, runtime);
        }

        public async Task<ListTenantNameResponse> ListTenantNameAsync(ListTenantNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTenantNameWithOptionsAsync(request, runtime);
        }

        public ListUnionMediaIndustryResponse ListUnionMediaIndustryWithOptions(ListUnionMediaIndustryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUnionMediaIndustry",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUnionMediaIndustryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUnionMediaIndustryResponse> ListUnionMediaIndustryWithOptionsAsync(ListUnionMediaIndustryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUnionMediaIndustry",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUnionMediaIndustryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUnionMediaIndustryResponse ListUnionMediaIndustry(ListUnionMediaIndustryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUnionMediaIndustryWithOptions(request, runtime);
        }

        public async Task<ListUnionMediaIndustryResponse> ListUnionMediaIndustryAsync(ListUnionMediaIndustryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUnionMediaIndustryWithOptionsAsync(request, runtime);
        }

        public ListUserResponse ListUserWithOptions(ListUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserShrinkRequest request = new ListUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserResponse> ListUserWithOptionsAsync(ListUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserShrinkRequest request = new ListUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserResponse ListUser(ListUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserWithOptions(request, runtime);
        }

        public async Task<ListUserResponse> ListUserAsync(ListUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserWithOptionsAsync(request, runtime);
        }

        public ModifyMediaResponse ModifyMediaWithOptions(ModifyMediaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyMediaShrinkRequest request = new ModifyMediaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Media))
            {
                request.MediaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Media, "Media", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaShrink))
            {
                body["Media"] = request.MediaShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMediaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMediaResponse> ModifyMediaWithOptionsAsync(ModifyMediaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyMediaShrinkRequest request = new ModifyMediaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Media))
            {
                request.MediaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Media, "Media", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaShrink))
            {
                body["Media"] = request.MediaShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMediaResponse ModifyMedia(ModifyMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMediaWithOptions(request, runtime);
        }

        public async Task<ModifyMediaResponse> ModifyMediaAsync(ModifyMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMediaWithOptionsAsync(request, runtime);
        }

        public ModifyRuleResponse ModifyRuleWithOptions(ModifyRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyRuleShrinkRequest request = new ModifyRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdRule))
            {
                request.AdRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdRule, "AdRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdRuleShrink))
            {
                body["AdRule"] = request.AdRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyRuleResponse> ModifyRuleWithOptionsAsync(ModifyRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyRuleShrinkRequest request = new ModifyRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdRule))
            {
                request.AdRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdRule, "AdRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdRuleShrink))
            {
                body["AdRule"] = request.AdRuleShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyRuleResponse ModifyRule(ModifyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRuleWithOptions(request, runtime);
        }

        public async Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRuleWithOptionsAsync(request, runtime);
        }

        public ModifySlotResponse ModifySlotWithOptions(ModifySlotRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySlotShrinkRequest request = new ModifySlotShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlot))
            {
                request.AdSlotShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlot, "AdSlot", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotShrink))
            {
                body["AdSlot"] = request.AdSlotShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySlotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySlotResponse> ModifySlotWithOptionsAsync(ModifySlotRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySlotShrinkRequest request = new ModifySlotShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlot))
            {
                request.AdSlotShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlot, "AdSlot", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotShrink))
            {
                body["AdSlot"] = request.AdSlotShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySlotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySlotResponse ModifySlot(ModifySlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySlotWithOptions(request, runtime);
        }

        public async Task<ModifySlotResponse> ModifySlotAsync(ModifySlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySlotWithOptionsAsync(request, runtime);
        }

        public ModifySlotTemplateResponse ModifySlotTemplateWithOptions(ModifySlotTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySlotTemplateShrinkRequest request = new ModifySlotTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlotTemplate))
            {
                request.AdSlotTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlotTemplate, "AdSlotTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotTemplateShrink))
            {
                body["AdSlotTemplate"] = request.AdSlotTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySlotTemplate",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySlotTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySlotTemplateResponse> ModifySlotTemplateWithOptionsAsync(ModifySlotTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySlotTemplateShrinkRequest request = new ModifySlotTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdSlotTemplate))
            {
                request.AdSlotTemplateShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdSlotTemplate, "AdSlotTemplate", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotTemplateShrink))
            {
                body["AdSlotTemplate"] = request.AdSlotTemplateShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySlotTemplate",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySlotTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySlotTemplateResponse ModifySlotTemplate(ModifySlotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySlotTemplateWithOptions(request, runtime);
        }

        public async Task<ModifySlotTemplateResponse> ModifySlotTemplateAsync(ModifySlotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySlotTemplateWithOptionsAsync(request, runtime);
        }

        public ModifyTenantInfoResponse ModifyTenantInfoWithOptions(ModifyTenantInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyTenantInfoShrinkRequest request = new ModifyTenantInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tenant))
            {
                request.TenantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tenant, "Tenant", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantShrink))
            {
                body["Tenant"] = request.TenantShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyTenantInfoResponse> ModifyTenantInfoWithOptionsAsync(ModifyTenantInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyTenantInfoShrinkRequest request = new ModifyTenantInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tenant))
            {
                request.TenantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tenant, "Tenant", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantShrink))
            {
                body["Tenant"] = request.TenantShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyTenantInfoResponse ModifyTenantInfo(ModifyTenantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantInfoWithOptions(request, runtime);
        }

        public async Task<ModifyTenantInfoResponse> ModifyTenantInfoAsync(ModifyTenantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantInfoWithOptionsAsync(request, runtime);
        }

        public PushDeviceStatusResponse PushDeviceStatusWithOptions(PushDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDeviceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushDeviceStatusResponse> PushDeviceStatusWithOptionsAsync(PushDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceStatus",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDeviceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushDeviceStatusResponse PushDeviceStatus(PushDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushDeviceStatusWithOptions(request, runtime);
        }

        public async Task<PushDeviceStatusResponse> PushDeviceStatusAsync(PushDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushDeviceStatusWithOptionsAsync(request, runtime);
        }

        public PushExtraTradeDetailResponse PushExtraTradeDetailWithOptions(PushExtraTradeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityId))
            {
                body["CommodityId"] = request.CommodityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityName))
            {
                body["CommodityName"] = request.CommodityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalePrice))
            {
                body["SalePrice"] = request.SalePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradePrice))
            {
                body["TradePrice"] = request.TradePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeStatus))
            {
                body["TradeStatus"] = request.TradeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTime))
            {
                body["TradeTime"] = request.TradeTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushExtraTradeDetail",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushExtraTradeDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushExtraTradeDetailResponse> PushExtraTradeDetailWithOptionsAsync(PushExtraTradeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityId))
            {
                body["CommodityId"] = request.CommodityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityName))
            {
                body["CommodityName"] = request.CommodityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalePrice))
            {
                body["SalePrice"] = request.SalePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradePrice))
            {
                body["TradePrice"] = request.TradePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeStatus))
            {
                body["TradeStatus"] = request.TradeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTime))
            {
                body["TradeTime"] = request.TradeTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushExtraTradeDetail",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushExtraTradeDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushExtraTradeDetailResponse PushExtraTradeDetail(PushExtraTradeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushExtraTradeDetailWithOptions(request, runtime);
        }

        public async Task<PushExtraTradeDetailResponse> PushExtraTradeDetailAsync(PushExtraTradeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushExtraTradeDetailWithOptionsAsync(request, runtime);
        }

        public PushFaultEventResponse PushFaultEventWithOptions(PushFaultEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultComment))
            {
                body["FaultComment"] = request.FaultComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                body["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushFaultEvent",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushFaultEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushFaultEventResponse> PushFaultEventWithOptionsAsync(PushFaultEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultComment))
            {
                body["FaultComment"] = request.FaultComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                body["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                body["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushFaultEvent",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushFaultEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushFaultEventResponse PushFaultEvent(PushFaultEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushFaultEventWithOptions(request, runtime);
        }

        public async Task<PushFaultEventResponse> PushFaultEventAsync(PushFaultEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushFaultEventWithOptionsAsync(request, runtime);
        }

        public PushTradeDetailResponse PushTradeDetailWithOptions(PushTradeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOrderId))
            {
                body["AlipayOrderId"] = request.AlipayOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityId))
            {
                body["CommodityId"] = request.CommodityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityName))
            {
                body["CommodityName"] = request.CommodityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterTradeId))
            {
                body["OuterTradeId"] = request.OuterTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalePrice))
            {
                body["SalePrice"] = request.SalePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeOrderId))
            {
                body["TradeOrderId"] = request.TradeOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradePrice))
            {
                body["TradePrice"] = request.TradePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeStatus))
            {
                body["TradeStatus"] = request.TradeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTime))
            {
                body["TradeTime"] = request.TradeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationStatus))
            {
                body["VerificationStatus"] = request.VerificationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushTradeDetail",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushTradeDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushTradeDetailResponse> PushTradeDetailWithOptionsAsync(PushTradeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOrderId))
            {
                body["AlipayOrderId"] = request.AlipayOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityId))
            {
                body["CommodityId"] = request.CommodityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityName))
            {
                body["CommodityName"] = request.CommodityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                body["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterTradeId))
            {
                body["OuterTradeId"] = request.OuterTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalePrice))
            {
                body["SalePrice"] = request.SalePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeOrderId))
            {
                body["TradeOrderId"] = request.TradeOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradePrice))
            {
                body["TradePrice"] = request.TradePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeStatus))
            {
                body["TradeStatus"] = request.TradeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTime))
            {
                body["TradeTime"] = request.TradeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationStatus))
            {
                body["VerificationStatus"] = request.VerificationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushTradeDetail",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushTradeDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushTradeDetailResponse PushTradeDetail(PushTradeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushTradeDetailWithOptions(request, runtime);
        }

        public async Task<PushTradeDetailResponse> PushTradeDetailAsync(PushTradeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushTradeDetailWithOptionsAsync(request, runtime);
        }

        public QueryAppPromotionResponse QueryAppPromotionWithOptions(QueryAppPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                query["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAppPromotion",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppPromotionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAppPromotionResponse> QueryAppPromotionWithOptionsAsync(QueryAppPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                query["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAppPromotion",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppPromotionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryAppPromotionResponse QueryAppPromotion(QueryAppPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAppPromotionWithOptions(request, runtime);
        }

        public async Task<QueryAppPromotionResponse> QueryAppPromotionAsync(QueryAppPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAppPromotionWithOptionsAsync(request, runtime);
        }

        public QueryAppTasksResponse QueryAppTasksWithOptions(QueryAppTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAppTasks",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAppTasksResponse> QueryAppTasksWithOptionsAsync(QueryAppTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAppTasks",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAppTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryAppTasksResponse QueryAppTasks(QueryAppTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAppTasksWithOptions(request, runtime);
        }

        public async Task<QueryAppTasksResponse> QueryAppTasksAsync(QueryAppTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAppTasksWithOptionsAsync(request, runtime);
        }

        public QueryAvailableBalanceResponse QueryAvailableBalanceWithOptions(QueryAvailableBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableBalance",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableBalanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAvailableBalanceResponse> QueryAvailableBalanceWithOptionsAsync(QueryAvailableBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableBalance",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryAvailableBalanceResponse QueryAvailableBalance(QueryAvailableBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAvailableBalanceWithOptions(request, runtime);
        }

        public async Task<QueryAvailableBalanceResponse> QueryAvailableBalanceAsync(QueryAvailableBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAvailableBalanceWithOptionsAsync(request, runtime);
        }

        public QueryChannelHistoryDataResponse QueryChannelHistoryDataWithOptions(QueryChannelHistoryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChannelHistoryData",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChannelHistoryDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryChannelHistoryDataResponse> QueryChannelHistoryDataWithOptionsAsync(QueryChannelHistoryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChannelHistoryData",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChannelHistoryDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryChannelHistoryDataResponse QueryChannelHistoryData(QueryChannelHistoryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChannelHistoryDataWithOptions(request, runtime);
        }

        public async Task<QueryChannelHistoryDataResponse> QueryChannelHistoryDataAsync(QueryChannelHistoryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChannelHistoryDataWithOptionsAsync(request, runtime);
        }

        public QueryContentInfoResponse QueryContentInfoWithOptions(QueryContentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContentInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContentInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryContentInfoResponse> QueryContentInfoWithOptionsAsync(QueryContentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContentInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContentInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryContentInfoResponse QueryContentInfo(QueryContentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryContentInfoWithOptions(request, runtime);
        }

        public async Task<QueryContentInfoResponse> QueryContentInfoAsync(QueryContentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryContentInfoWithOptionsAsync(request, runtime);
        }

        public QueryContentListResponse QueryContentListWithOptions(QueryContentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizType))
            {
                query["TaskBizType"] = request.TaskBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContentList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContentListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryContentListResponse> QueryContentListWithOptionsAsync(QueryContentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizType))
            {
                query["TaskBizType"] = request.TaskBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContentList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryContentListResponse QueryContentList(QueryContentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryContentListWithOptions(request, runtime);
        }

        public async Task<QueryContentListResponse> QueryContentListAsync(QueryContentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryContentListWithOptionsAsync(request, runtime);
        }

        public QueryFlowResponse QueryFlowWithOptions(QueryFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFlowResponse> QueryFlowWithOptionsAsync(QueryFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFlowResponse QueryFlow(QueryFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFlowWithOptions(request, runtime);
        }

        public async Task<QueryFlowResponse> QueryFlowAsync(QueryFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFlowWithOptionsAsync(request, runtime);
        }

        public QueryIncomeDataResponse QueryIncomeDataWithOptions(QueryIncomeDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryIncomeDataShrinkRequest request = new QueryIncomeDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIncomeData",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIncomeDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryIncomeDataResponse> QueryIncomeDataWithOptionsAsync(QueryIncomeDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryIncomeDataShrinkRequest request = new QueryIncomeDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIncomeData",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIncomeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryIncomeDataResponse QueryIncomeData(QueryIncomeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIncomeDataWithOptions(request, runtime);
        }

        public async Task<QueryIncomeDataResponse> QueryIncomeDataAsync(QueryIncomeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIncomeDataWithOptionsAsync(request, runtime);
        }

        public QueryIncomeTrendResponse QueryIncomeTrendWithOptions(QueryIncomeTrendRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryIncomeTrendShrinkRequest request = new QueryIncomeTrendShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slot))
            {
                query["Slot"] = request.Slot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlotDimension))
            {
                query["SlotDimension"] = request.SlotDimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIncomeTrend",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIncomeTrendResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryIncomeTrendResponse> QueryIncomeTrendWithOptionsAsync(QueryIncomeTrendRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryIncomeTrendShrinkRequest request = new QueryIncomeTrendShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaName))
            {
                request.MediaNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaName, "MediaName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotName))
            {
                query["AdSlotName"] = request.AdSlotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotType))
            {
                query["AdSlotType"] = request.AdSlotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNameShrink))
            {
                query["MediaName"] = request.MediaNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slot))
            {
                query["Slot"] = request.Slot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlotDimension))
            {
                query["SlotDimension"] = request.SlotDimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIncomeTrend",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIncomeTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryIncomeTrendResponse QueryIncomeTrend(QueryIncomeTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIncomeTrendWithOptions(request, runtime);
        }

        public async Task<QueryIncomeTrendResponse> QueryIncomeTrendAsync(QueryIncomeTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIncomeTrendWithOptionsAsync(request, runtime);
        }

        public QueryIndustryLabelBagResponse QueryIndustryLabelBagWithOptions(QueryIndustryLabelBagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryLabelBag",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIndustryLabelBagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryIndustryLabelBagResponse> QueryIndustryLabelBagWithOptionsAsync(QueryIndustryLabelBagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIndustryLabelBag",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIndustryLabelBagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryIndustryLabelBagResponse QueryIndustryLabelBag(QueryIndustryLabelBagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIndustryLabelBagWithOptions(request, runtime);
        }

        public async Task<QueryIndustryLabelBagResponse> QueryIndustryLabelBagAsync(QueryIndustryLabelBagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIndustryLabelBagWithOptionsAsync(request, runtime);
        }

        public QueryMediaResponse QueryMediaWithOptions(QueryMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMediaResponse> QueryMediaWithOptionsAsync(QueryMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMedia",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMediaResponse QueryMedia(QueryMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaWithOptions(request, runtime);
        }

        public async Task<QueryMediaResponse> QueryMediaAsync(QueryMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaWithOptionsAsync(request, runtime);
        }

        public QueryPromotionResponse QueryPromotionWithOptions(QueryPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                body["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyChannelId))
            {
                body["ProxyChannelId"] = request.ProxyChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPromotion",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPromotionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPromotionResponse> QueryPromotionWithOptionsAsync(QueryPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                body["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyChannelId))
            {
                body["ProxyChannelId"] = request.ProxyChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPromotion",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPromotionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPromotionResponse QueryPromotion(QueryPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPromotionWithOptions(request, runtime);
        }

        public async Task<QueryPromotionResponse> QueryPromotionAsync(QueryPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPromotionWithOptionsAsync(request, runtime);
        }

        public QueryRuleResponse QueryRuleWithOptions(QueryRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRuleResponse> QueryRuleWithOptionsAsync(QueryRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRule",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRuleResponse QueryRule(QueryRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRuleWithOptions(request, runtime);
        }

        public async Task<QueryRuleResponse> QueryRuleAsync(QueryRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRuleWithOptionsAsync(request, runtime);
        }

        public QuerySlotResponse QuerySlotWithOptions(QuerySlotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySlotResponse> QuerySlotWithOptionsAsync(QuerySlotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotId))
            {
                query["AdSlotId"] = request.AdSlotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlot",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySlotResponse QuerySlot(QuerySlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySlotWithOptions(request, runtime);
        }

        public async Task<QuerySlotResponse> QuerySlotAsync(QuerySlotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySlotWithOptionsAsync(request, runtime);
        }

        public QuerySlotTemplateResponse QuerySlotTemplateWithOptions(QuerySlotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotTemplateId))
            {
                query["AdSlotTemplateId"] = request.AdSlotTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlotTemplate",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlotTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySlotTemplateResponse> QuerySlotTemplateWithOptionsAsync(QuerySlotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdSlotTemplateId))
            {
                query["AdSlotTemplateId"] = request.AdSlotTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlotTemplate",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlotTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySlotTemplateResponse QuerySlotTemplate(QuerySlotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySlotTemplateWithOptions(request, runtime);
        }

        public async Task<QuerySlotTemplateResponse> QuerySlotTemplateAsync(QuerySlotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySlotTemplateWithOptionsAsync(request, runtime);
        }

        public QueryTaskBizTypeResponse QueryTaskBizTypeWithOptions(QueryTaskBizTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskBizType",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskBizTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskBizTypeResponse> QueryTaskBizTypeWithOptionsAsync(QueryTaskBizTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskBizType",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskBizTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskBizTypeResponse QueryTaskBizType(QueryTaskBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskBizTypeWithOptions(request, runtime);
        }

        public async Task<QueryTaskBizTypeResponse> QueryTaskBizTypeAsync(QueryTaskBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskBizTypeWithOptionsAsync(request, runtime);
        }

        public QueryTaskRuleLimitResponse QueryTaskRuleLimitWithOptions(QueryTaskRuleLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskRuleLimit",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskRuleLimitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskRuleLimitResponse> QueryTaskRuleLimitWithOptionsAsync(QueryTaskRuleLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskRuleLimit",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskRuleLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskRuleLimitResponse QueryTaskRuleLimit(QueryTaskRuleLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskRuleLimitWithOptions(request, runtime);
        }

        public async Task<QueryTaskRuleLimitResponse> QueryTaskRuleLimitAsync(QueryTaskRuleLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskRuleLimitWithOptionsAsync(request, runtime);
        }

        public QueryTaskRulesResponse QueryTaskRulesWithOptions(QueryTaskRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRuleType))
            {
                query["TaskRuleType"] = request.TaskRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskRules",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskRulesResponse> QueryTaskRulesWithOptionsAsync(QueryTaskRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRuleType))
            {
                query["TaskRuleType"] = request.TaskRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskRules",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskRulesResponse QueryTaskRules(QueryTaskRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskRulesWithOptions(request, runtime);
        }

        public async Task<QueryTaskRulesResponse> QueryTaskRulesAsync(QueryTaskRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskRulesWithOptionsAsync(request, runtime);
        }

        public QueryTenantBizConfigResponse QueryTenantBizConfigWithOptions(QueryTenantBizConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantBizConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantBizConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTenantBizConfigResponse> QueryTenantBizConfigWithOptionsAsync(QueryTenantBizConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantBizConfig",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantBizConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTenantBizConfigResponse QueryTenantBizConfig(QueryTenantBizConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTenantBizConfigWithOptions(request, runtime);
        }

        public async Task<QueryTenantBizConfigResponse> QueryTenantBizConfigAsync(QueryTenantBizConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTenantBizConfigWithOptionsAsync(request, runtime);
        }

        public QueryTenantInfoResponse QueryTenantInfoWithOptions(QueryTenantInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTenantInfoResponse> QueryTenantInfoWithOptionsAsync(QueryTenantInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTenantInfoResponse QueryTenantInfo(QueryTenantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTenantInfoWithOptions(request, runtime);
        }

        public async Task<QueryTenantInfoResponse> QueryTenantInfoAsync(QueryTenantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTenantInfoWithOptionsAsync(request, runtime);
        }

        public QueryTenantUserResponse QueryTenantUserWithOptions(QueryTenantUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTenantUserResponse> QueryTenantUserWithOptionsAsync(QueryTenantUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTenantUserResponse QueryTenantUser(QueryTenantUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTenantUserWithOptions(request, runtime);
        }

        public async Task<QueryTenantUserResponse> QueryTenantUserAsync(QueryTenantUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTenantUserWithOptionsAsync(request, runtime);
        }

        public QueryTenantUserByUserIdResponse QueryTenantUserByUserIdWithOptions(QueryTenantUserByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantUserByUserId",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantUserByUserIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTenantUserByUserIdResponse> QueryTenantUserByUserIdWithOptionsAsync(QueryTenantUserByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTenantUserByUserId",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTenantUserByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTenantUserByUserIdResponse QueryTenantUserByUserId(QueryTenantUserByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTenantUserByUserIdWithOptions(request, runtime);
        }

        public async Task<QueryTenantUserByUserIdResponse> QueryTenantUserByUserIdAsync(QueryTenantUserByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTenantUserByUserIdWithOptionsAsync(request, runtime);
        }

        public QueryUnionChannelResponse QueryUnionChannelWithOptions(QueryUnionChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionChannel",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionChannelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnionChannelResponse> QueryUnionChannelWithOptionsAsync(QueryUnionChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionChannel",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUnionChannelResponse QueryUnionChannel(QueryUnionChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnionChannelWithOptions(request, runtime);
        }

        public async Task<QueryUnionChannelResponse> QueryUnionChannelAsync(QueryUnionChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnionChannelWithOptionsAsync(request, runtime);
        }

        public QueryUnionContentInfoResponse QueryUnionContentInfoWithOptions(QueryUnionContentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionContentInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionContentInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnionContentInfoResponse> QueryUnionContentInfoWithOptionsAsync(QueryUnionContentInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionContentInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionContentInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUnionContentInfoResponse QueryUnionContentInfo(QueryUnionContentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnionContentInfoWithOptions(request, runtime);
        }

        public async Task<QueryUnionContentInfoResponse> QueryUnionContentInfoAsync(QueryUnionContentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnionContentInfoWithOptionsAsync(request, runtime);
        }

        public QueryUnionPromotionResponse QueryUnionPromotionWithOptions(QueryUnionPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyChannelId))
            {
                query["ProxyChannelId"] = request.ProxyChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionBizType))
            {
                query["UnionBizType"] = request.UnionBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionPromotion",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionPromotionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnionPromotionResponse> QueryUnionPromotionWithOptionsAsync(QueryUnionPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyChannelId))
            {
                query["ProxyChannelId"] = request.ProxyChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sign))
            {
                query["Sign"] = request.Sign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionBizType))
            {
                query["UnionBizType"] = request.UnionBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNick))
            {
                query["UserNick"] = request.UserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionPromotion",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionPromotionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUnionPromotionResponse QueryUnionPromotion(QueryUnionPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnionPromotionWithOptions(request, runtime);
        }

        public async Task<QueryUnionPromotionResponse> QueryUnionPromotionAsync(QueryUnionPromotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnionPromotionWithOptionsAsync(request, runtime);
        }

        public QueryUnionSumChannelDataResponse QueryUnionSumChannelDataWithOptions(QueryUnionSumChannelDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionSumChannelData",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionSumChannelDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnionSumChannelDataResponse> QueryUnionSumChannelDataWithOptionsAsync(QueryUnionSumChannelDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionSumChannelData",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionSumChannelDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUnionSumChannelDataResponse QueryUnionSumChannelData(QueryUnionSumChannelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnionSumChannelDataWithOptions(request, runtime);
        }

        public async Task<QueryUnionSumChannelDataResponse> QueryUnionSumChannelDataAsync(QueryUnionSumChannelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnionSumChannelDataWithOptionsAsync(request, runtime);
        }

        public QueryUnionTaskInfoResponse QueryUnionTaskInfoWithOptions(QueryUnionTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionTaskInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnionTaskInfoResponse> QueryUnionTaskInfoWithOptionsAsync(QueryUnionTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionTaskInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUnionTaskInfoResponse QueryUnionTaskInfo(QueryUnionTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnionTaskInfoWithOptions(request, runtime);
        }

        public async Task<QueryUnionTaskInfoResponse> QueryUnionTaskInfoAsync(QueryUnionTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnionTaskInfoWithOptionsAsync(request, runtime);
        }

        public QueryUnionTaskListResponse QueryUnionTaskListWithOptions(QueryUnionTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionTaskList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionTaskListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnionTaskListResponse> QueryUnionTaskListWithOptionsAsync(QueryUnionTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserNick))
            {
                query["BrandUserNick"] = request.BrandUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnionTaskList",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnionTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUnionTaskListResponse QueryUnionTaskList(QueryUnionTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUnionTaskListWithOptions(request, runtime);
        }

        public async Task<QueryUnionTaskListResponse> QueryUnionTaskListAsync(QueryUnionTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUnionTaskListWithOptionsAsync(request, runtime);
        }

        public QueryUserResponse QueryUserWithOptions(QueryUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUserShrinkRequest request = new QueryUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUserResponse> QueryUserWithOptionsAsync(QueryUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUserShrinkRequest request = new QueryUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUserResponse QueryUser(QueryUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserWithOptions(request, runtime);
        }

        public async Task<QueryUserResponse> QueryUserAsync(QueryUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserWithOptionsAsync(request, runtime);
        }

        public ReduceAmountResponse ReduceAmountWithOptions(ReduceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceAmount",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceAmountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReduceAmountResponse> ReduceAmountWithOptionsAsync(ReduceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceAmount",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceAmountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReduceAmountResponse ReduceAmount(ReduceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReduceAmountWithOptions(request, runtime);
        }

        public async Task<ReduceAmountResponse> ReduceAmountAsync(ReduceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReduceAmountWithOptionsAsync(request, runtime);
        }

        public RegistDeviceResponse RegistDeviceWithOptions(RegistDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailAddr))
            {
                body["DetailAddr"] = request.DetailAddr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceModelNumber))
            {
                body["DeviceModelNumber"] = request.DeviceModelNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.District))
            {
                body["District"] = request.District;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                body["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["Floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationName))
            {
                body["LocationName"] = request.LocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                body["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                body["SecondScene"] = request.SecondScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegistDevice",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegistDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegistDeviceResponse> RegistDeviceWithOptionsAsync(RegistDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailAddr))
            {
                body["DetailAddr"] = request.DetailAddr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceModelNumber))
            {
                body["DeviceModelNumber"] = request.DeviceModelNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.District))
            {
                body["District"] = request.District;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScene))
            {
                body["FirstScene"] = request.FirstScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Floor))
            {
                body["Floor"] = request.Floor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationName))
            {
                body["LocationName"] = request.LocationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                body["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondScene))
            {
                body["SecondScene"] = request.SecondScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegistDevice",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegistDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegistDeviceResponse RegistDevice(RegistDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegistDeviceWithOptions(request, runtime);
        }

        public async Task<RegistDeviceResponse> RegistDeviceAsync(RegistDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegistDeviceWithOptionsAsync(request, runtime);
        }

        public SaveCpmTradeResponse SaveCpmTradeWithOptions(SaveCpmTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvertType))
            {
                query["AdvertType"] = request.AdvertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                query["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPrice))
            {
                query["ApplyPrice"] = request.ApplyPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostDetail))
            {
                query["CostDetail"] = request.CostDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["DeviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendString))
            {
                query["ExtendString"] = request.ExtendString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldId))
            {
                query["HoldId"] = request.HoldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                query["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealCostAmount))
            {
                query["RealCostAmount"] = request.RealCostAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sex))
            {
                query["Sex"] = request.Sex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTag))
            {
                query["TaskTag"] = request.TaskTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTime))
            {
                query["TradeTime"] = request.TradeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveCpmTrade",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCpmTradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveCpmTradeResponse> SaveCpmTradeWithOptionsAsync(SaveCpmTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvertType))
            {
                query["AdvertType"] = request.AdvertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                query["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPrice))
            {
                query["ApplyPrice"] = request.ApplyPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostDetail))
            {
                query["CostDetail"] = request.CostDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["DeviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendString))
            {
                query["ExtendString"] = request.ExtendString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldId))
            {
                query["HoldId"] = request.HoldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                query["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealCostAmount))
            {
                query["RealCostAmount"] = request.RealCostAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sex))
            {
                query["Sex"] = request.Sex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTag))
            {
                query["TaskTag"] = request.TaskTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTime))
            {
                query["TradeTime"] = request.TradeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveCpmTrade",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCpmTradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveCpmTradeResponse SaveCpmTrade(SaveCpmTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveCpmTradeWithOptions(request, runtime);
        }

        public async Task<SaveCpmTradeResponse> SaveCpmTradeAsync(SaveCpmTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveCpmTradeWithOptionsAsync(request, runtime);
        }

        public ScanCodeNotificationResponse ScanCodeNotificationWithOptions(ScanCodeNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                query["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPrice))
            {
                query["ApplyPrice"] = request.ApplyPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizResult))
            {
                query["BizResult"] = request.BizResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandNick))
            {
                query["BrandNick"] = request.BrandNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeTag))
            {
                query["ChargeTag"] = request.ChargeTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cid))
            {
                query["Cid"] = request.Cid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityId))
            {
                query["CommodityId"] = request.CommodityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostDetail))
            {
                query["CostDetail"] = request.CostDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["DeviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HolderId))
            {
                query["HolderId"] = request.HolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                query["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStr))
            {
                query["QueryStr"] = request.QueryStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealCostAmount))
            {
                query["RealCostAmount"] = request.RealCostAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalePrice))
            {
                query["SalePrice"] = request.SalePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sex))
            {
                query["Sex"] = request.Sex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTimeStr))
            {
                query["TradeTimeStr"] = request.TradeTimeStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScanCodeNotification",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanCodeNotificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScanCodeNotificationResponse> ScanCodeNotificationWithOptionsAsync(ScanCodeNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                query["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayOpenId))
            {
                query["AlipayOpenId"] = request.AlipayOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPrice))
            {
                query["ApplyPrice"] = request.ApplyPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizResult))
            {
                query["BizResult"] = request.BizResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandNick))
            {
                query["BrandNick"] = request.BrandNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeTag))
            {
                query["ChargeTag"] = request.ChargeTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cid))
            {
                query["Cid"] = request.Cid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityId))
            {
                query["CommodityId"] = request.CommodityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostDetail))
            {
                query["CostDetail"] = request.CostDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["DeviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HolderId))
            {
                query["HolderId"] = request.HolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterCode))
            {
                query["OuterCode"] = request.OuterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phase))
            {
                query["Phase"] = request.Phase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStr))
            {
                query["QueryStr"] = request.QueryStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealCostAmount))
            {
                query["RealCostAmount"] = request.RealCostAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SalePrice))
            {
                query["SalePrice"] = request.SalePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sex))
            {
                query["Sex"] = request.Sex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTimeStr))
            {
                query["TradeTimeStr"] = request.TradeTimeStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScanCodeNotification",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanCodeNotificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScanCodeNotificationResponse ScanCodeNotification(ScanCodeNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScanCodeNotificationWithOptions(request, runtime);
        }

        public async Task<ScanCodeNotificationResponse> ScanCodeNotificationAsync(ScanCodeNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScanCodeNotificationWithOptionsAsync(request, runtime);
        }

        public SearchAdvertisingResponse SearchAdvertisingWithOptions(SearchAdvertisingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchAdvertisingShrinkRequest request = new SearchAdvertisingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.App.ToMap()))
            {
                request.AppShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.App.ToMap(), "App", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Device.ToMap()))
            {
                request.DeviceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Device.ToMap(), "Device", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ext))
            {
                request.ExtShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ext, "Ext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Imp))
            {
                request.ImpShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Imp, "Imp", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User.ToMap()))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User.ToMap(), "User", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppShrink))
            {
                query["App"] = request.AppShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceShrink))
            {
                query["Device"] = request.DeviceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtShrink))
            {
                query["Ext"] = request.ExtShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImpShrink))
            {
                query["Imp"] = request.ImpShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                query["Test"] = request.Test;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserShrink))
            {
                query["User"] = request.UserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchAdvertising",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAdvertisingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchAdvertisingResponse> SearchAdvertisingWithOptionsAsync(SearchAdvertisingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchAdvertisingShrinkRequest request = new SearchAdvertisingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.App.ToMap()))
            {
                request.AppShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.App.ToMap(), "App", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Device.ToMap()))
            {
                request.DeviceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Device.ToMap(), "Device", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ext))
            {
                request.ExtShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ext, "Ext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Imp))
            {
                request.ImpShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Imp, "Imp", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User.ToMap()))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User.ToMap(), "User", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppShrink))
            {
                query["App"] = request.AppShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceShrink))
            {
                query["Device"] = request.DeviceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtShrink))
            {
                query["Ext"] = request.ExtShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImpShrink))
            {
                query["Imp"] = request.ImpShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                query["Test"] = request.Test;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserShrink))
            {
                query["User"] = request.UserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchAdvertising",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAdvertisingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchAdvertisingResponse SearchAdvertising(SearchAdvertisingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchAdvertisingWithOptions(request, runtime);
        }

        public async Task<SearchAdvertisingResponse> SearchAdvertisingAsync(SearchAdvertisingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchAdvertisingWithOptionsAsync(request, runtime);
        }

        public SendTaokeInfoResponse SendTaokeInfoWithOptions(SendTaokeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                body["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandId))
            {
                body["BrandId"] = request.BrandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentId))
            {
                body["ComponentId"] = request.ComponentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.District))
            {
                body["District"] = request.District;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentType))
            {
                body["EnvironmentType"] = request.EnvironmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                body["Imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayPrice))
            {
                body["PayPrice"] = request.PayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plat))
            {
                body["Plat"] = request.Plat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTitle))
            {
                body["ProductTitle"] = request.ProductTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellPrice))
            {
                body["SellPrice"] = request.SellPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                body["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTaokeInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTaokeInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendTaokeInfoResponse> SendTaokeInfoWithOptionsAsync(SendTaokeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                body["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandId))
            {
                body["BrandId"] = request.BrandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentId))
            {
                body["ComponentId"] = request.ComponentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.District))
            {
                body["District"] = request.District;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentType))
            {
                body["EnvironmentType"] = request.EnvironmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                body["Imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayPrice))
            {
                body["PayPrice"] = request.PayPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plat))
            {
                body["Plat"] = request.Plat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTitle))
            {
                body["ProductTitle"] = request.ProductTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellPrice))
            {
                body["SellPrice"] = request.SellPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                body["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTaokeInfo",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTaokeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendTaokeInfoResponse SendTaokeInfo(SendTaokeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendTaokeInfoWithOptions(request, runtime);
        }

        public async Task<SendTaokeInfoResponse> SendTaokeInfoAsync(SendTaokeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendTaokeInfoWithOptionsAsync(request, runtime);
        }

        public SyncUnionOrderResponse SyncUnionOrderWithOptions(SyncUnionOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                query["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPrice))
            {
                query["ApplyPrice"] = request.ApplyPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSerialNumber))
            {
                query["BizSerialNumber"] = request.BizSerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandName))
            {
                query["BrandName"] = request.BrandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                query["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HolderId))
            {
                query["HolderId"] = request.HolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryLabelBagId))
            {
                query["IndustryLabelBagId"] = request.IndustryLabelBagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyChannelId))
            {
                query["ProxyChannelId"] = request.ProxyChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealCostAmount))
            {
                query["RealCostAmount"] = request.RealCostAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sex))
            {
                query["Sex"] = request.Sex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizType))
            {
                query["TaskBizType"] = request.TaskBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRuleType))
            {
                query["TaskRuleType"] = request.TaskRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTimeString))
            {
                query["TradeTimeString"] = request.TradeTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncUnionOrder",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncUnionOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncUnionOrderResponse> SyncUnionOrderWithOptionsAsync(SyncUnionOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Age))
            {
                query["Age"] = request.Age;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPrice))
            {
                query["ApplyPrice"] = request.ApplyPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSerialNumber))
            {
                query["BizSerialNumber"] = request.BizSerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandName))
            {
                query["BrandName"] = request.BrandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrandUserId))
            {
                query["BrandUserId"] = request.BrandUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                query["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HolderId))
            {
                query["HolderId"] = request.HolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryLabelBagId))
            {
                query["IndustryLabelBagId"] = request.IndustryLabelBagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyChannelId))
            {
                query["ProxyChannelId"] = request.ProxyChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUserId))
            {
                query["ProxyUserId"] = request.ProxyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealCostAmount))
            {
                query["RealCostAmount"] = request.RealCostAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sex))
            {
                query["Sex"] = request.Sex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizType))
            {
                query["TaskBizType"] = request.TaskBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRuleType))
            {
                query["TaskRuleType"] = request.TaskRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTimeString))
            {
                query["TradeTimeString"] = request.TradeTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V))
            {
                query["V"] = request.V;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncUnionOrder",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncUnionOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SyncUnionOrderResponse SyncUnionOrder(SyncUnionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncUnionOrderWithOptions(request, runtime);
        }

        public async Task<SyncUnionOrderResponse> SyncUnionOrderAsync(SyncUnionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncUnionOrderWithOptionsAsync(request, runtime);
        }

        public UpdateFlowResponse UpdateFlowWithOptions(UpdateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlowShrinkRequest request = new UpdateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Flow))
            {
                request.FlowShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Flow, "Flow", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowShrink))
            {
                body["Flow"] = request.FlowShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFlowResponse> UpdateFlowWithOptionsAsync(UpdateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFlowShrinkRequest request = new UpdateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Flow))
            {
                request.FlowShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Flow, "Flow", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowShrink))
            {
                body["Flow"] = request.FlowShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlowWithOptions(request, runtime);
        }

        public async Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlowWithOptionsAsync(request, runtime);
        }

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserShrinkRequest request = new UpdateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserShrinkRequest request = new UpdateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SspUser))
            {
                request.SspUserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SspUser, "SspUser", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Business))
            {
                query["Business"] = request.Business;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSiteUserId))
            {
                query["OriginSiteUserId"] = request.OriginSiteUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSite))
            {
                query["UserSite"] = request.UserSite;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SspUserShrink))
            {
                body["SspUser"] = request.SspUserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2018-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

    }
}
