// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Linkcard20210520.Models;

namespace AlibabaCloud.SDK.Linkcard20210520
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("linkcard", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetCardDetailResponse GetCardDetailWithOptions(GetCardDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyCard))
            {
                query["DestroyCard"] = request.DestroyCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowPsim))
            {
                query["ShowPsim"] = request.ShowPsim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardDetail",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCardDetailResponse> GetCardDetailWithOptionsAsync(GetCardDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyCard))
            {
                query["DestroyCard"] = request.DestroyCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowPsim))
            {
                query["ShowPsim"] = request.ShowPsim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardDetail",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCardDetailResponse GetCardDetail(GetCardDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCardDetailWithOptions(request, runtime);
        }

        public async Task<GetCardDetailResponse> GetCardDetailAsync(GetCardDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCardDetailWithOptionsAsync(request, runtime);
        }

        public GetCardFlowInfoResponse GetCardFlowInfoWithOptions(GetCardFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateList))
            {
                query["DateList"] = request.DateList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardFlowInfo",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardFlowInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCardFlowInfoResponse> GetCardFlowInfoWithOptionsAsync(GetCardFlowInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateList))
            {
                query["DateList"] = request.DateList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardFlowInfo",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardFlowInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCardFlowInfoResponse GetCardFlowInfo(GetCardFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCardFlowInfoWithOptions(request, runtime);
        }

        public async Task<GetCardFlowInfoResponse> GetCardFlowInfoAsync(GetCardFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCardFlowInfoWithOptionsAsync(request, runtime);
        }

        public GetCredentialPoolStatisticsResponse GetCredentialPoolStatisticsWithOptions(GetCredentialPoolStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNO))
            {
                query["CredentialNO"] = request.CredentialNO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["Date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredentialPoolStatistics",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialPoolStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCredentialPoolStatisticsResponse> GetCredentialPoolStatisticsWithOptionsAsync(GetCredentialPoolStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNO))
            {
                query["CredentialNO"] = request.CredentialNO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["Date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredentialPoolStatistics",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialPoolStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCredentialPoolStatisticsResponse GetCredentialPoolStatistics(GetCredentialPoolStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCredentialPoolStatisticsWithOptions(request, runtime);
        }

        public async Task<GetCredentialPoolStatisticsResponse> GetCredentialPoolStatisticsAsync(GetCredentialPoolStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCredentialPoolStatisticsWithOptionsAsync(request, runtime);
        }

        public RebindResumeSingleCardResponse RebindResumeSingleCardWithOptions(RebindResumeSingleCardRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RebindResumeSingleCardShrinkRequest request = new RebindResumeSingleCardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptMsisdns))
            {
                request.OptMsisdnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptMsisdns, "OptMsisdns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptMsisdnsShrink))
            {
                query["OptMsisdns"] = request.OptMsisdnsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebindResumeSingleCard",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebindResumeSingleCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RebindResumeSingleCardResponse> RebindResumeSingleCardWithOptionsAsync(RebindResumeSingleCardRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RebindResumeSingleCardShrinkRequest request = new RebindResumeSingleCardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptMsisdns))
            {
                request.OptMsisdnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptMsisdns, "OptMsisdns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptMsisdnsShrink))
            {
                query["OptMsisdns"] = request.OptMsisdnsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebindResumeSingleCard",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebindResumeSingleCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RebindResumeSingleCardResponse RebindResumeSingleCard(RebindResumeSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebindResumeSingleCardWithOptions(request, runtime);
        }

        public async Task<RebindResumeSingleCardResponse> RebindResumeSingleCardAsync(RebindResumeSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebindResumeSingleCardWithOptionsAsync(request, runtime);
        }

        public ResumeSingleCardResponse ResumeSingleCardWithOptions(ResumeSingleCardRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResumeSingleCardShrinkRequest request = new ResumeSingleCardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptMsisdns))
            {
                request.OptMsisdnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptMsisdns, "OptMsisdns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptMsisdnsShrink))
            {
                query["OptMsisdns"] = request.OptMsisdnsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeSingleCard",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeSingleCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeSingleCardResponse> ResumeSingleCardWithOptionsAsync(ResumeSingleCardRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResumeSingleCardShrinkRequest request = new ResumeSingleCardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptMsisdns))
            {
                request.OptMsisdnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptMsisdns, "OptMsisdns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptMsisdnsShrink))
            {
                query["OptMsisdns"] = request.OptMsisdnsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeSingleCard",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeSingleCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeSingleCardResponse ResumeSingleCard(ResumeSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeSingleCardWithOptions(request, runtime);
        }

        public async Task<ResumeSingleCardResponse> ResumeSingleCardAsync(ResumeSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeSingleCardWithOptionsAsync(request, runtime);
        }

        public StopSingleCardResponse StopSingleCardWithOptions(StopSingleCardRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopSingleCardShrinkRequest request = new StopSingleCardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptMsisdns))
            {
                request.OptMsisdnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptMsisdns, "OptMsisdns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptMsisdnsShrink))
            {
                query["OptMsisdns"] = request.OptMsisdnsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSingleCard",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSingleCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopSingleCardResponse> StopSingleCardWithOptionsAsync(StopSingleCardRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopSingleCardShrinkRequest request = new StopSingleCardShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OptMsisdns))
            {
                request.OptMsisdnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OptMsisdns, "OptMsisdns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptMsisdnsShrink))
            {
                query["OptMsisdns"] = request.OptMsisdnsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSingleCard",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSingleCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopSingleCardResponse StopSingleCard(StopSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopSingleCardWithOptions(request, runtime);
        }

        public async Task<StopSingleCardResponse> StopSingleCardAsync(StopSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopSingleCardWithOptionsAsync(request, runtime);
        }

    }
}
