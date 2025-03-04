// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MarketplaceIntl20221230.Models;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("marketplaceintl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>isv推送实例消息给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NoticeInstanceUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NoticeInstanceUserResponse
        /// </returns>
        public NoticeInstanceUserResponse NoticeInstanceUserWithOptions(NoticeInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeParam))
            {
                body["NoticeParam"] = request.NoticeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NoticeInstanceUser",
                Version = "2022-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<NoticeInstanceUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<NoticeInstanceUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>isv推送实例消息给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NoticeInstanceUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NoticeInstanceUserResponse
        /// </returns>
        public async Task<NoticeInstanceUserResponse> NoticeInstanceUserWithOptionsAsync(NoticeInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeParam))
            {
                body["NoticeParam"] = request.NoticeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NoticeInstanceUser",
                Version = "2022-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<NoticeInstanceUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<NoticeInstanceUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>isv推送实例消息给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NoticeInstanceUserRequest
        /// </param>
        /// 
        /// <returns>
        /// NoticeInstanceUserResponse
        /// </returns>
        public NoticeInstanceUserResponse NoticeInstanceUser(NoticeInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NoticeInstanceUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>isv推送实例消息给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NoticeInstanceUserRequest
        /// </param>
        /// 
        /// <returns>
        /// NoticeInstanceUserResponse
        /// </returns>
        public async Task<NoticeInstanceUserResponse> NoticeInstanceUserAsync(NoticeInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NoticeInstanceUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际云市场推送计量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public PushMeteringDataResponse PushMeteringDataWithOptions(PushMeteringDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                body["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeteringData))
            {
                body["MeteringData"] = request.MeteringData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMeteringData",
                Version = "2022-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushMeteringDataResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushMeteringDataResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际云市场推送计量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public async Task<PushMeteringDataResponse> PushMeteringDataWithOptionsAsync(PushMeteringDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                body["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeteringData))
            {
                body["MeteringData"] = request.MeteringData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMeteringData",
                Version = "2022-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PushMeteringDataResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PushMeteringDataResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际云市场推送计量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public PushMeteringDataResponse PushMeteringData(PushMeteringDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMeteringDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>国际云市场推送计量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public async Task<PushMeteringDataResponse> PushMeteringDataAsync(PushMeteringDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMeteringDataWithOptionsAsync(request, runtime);
        }

    }
}
