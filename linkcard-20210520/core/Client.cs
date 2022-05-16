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

        public CardStatisticsResponse CardStatisticsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CardStatistics",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CardStatisticsResponse> CardStatisticsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CardStatistics",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CardStatisticsResponse CardStatistics()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CardStatisticsWithOptions(runtime);
        }

        public async Task<CardStatisticsResponse> CardStatisticsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CardStatisticsWithOptionsAsync(runtime);
        }

        public ForceActivationResponse ForceActivationWithOptions(ForceActivationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                query["DateType"] = request.DateType;
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
                Action = "ForceActivation",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceActivationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ForceActivationResponse> ForceActivationWithOptionsAsync(ForceActivationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                query["DateType"] = request.DateType;
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
                Action = "ForceActivation",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceActivationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ForceActivationResponse ForceActivation(ForceActivationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForceActivationWithOptions(request, runtime);
        }

        public async Task<ForceActivationResponse> ForceActivationAsync(ForceActivationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForceActivationWithOptionsAsync(request, runtime);
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

        public ListCardInfoResponse ListCardInfoWithOptions(ListCardInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveTimeEnd))
            {
                query["ActiveTimeEnd"] = request.ActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveTimeStart))
            {
                query["ActiveTimeStart"] = request.ActiveTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliFee))
            {
                query["AliFee"] = request.AliFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunOrderId))
            {
                query["AliyunOrderId"] = request.AliyunOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApnName))
            {
                query["ApnName"] = request.ApnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyType))
            {
                query["CertifyType"] = request.CertifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNo))
            {
                query["CredentialNo"] = request.CredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataLevel))
            {
                query["DataLevel"] = request.DataLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectionalGroupId))
            {
                query["DirectionalGroupId"] = request.DirectionalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeEnd))
            {
                query["ExpireTimeEnd"] = request.ExpireTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeStart))
            {
                query["ExpireTimeStart"] = request.ExpireTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imsi))
            {
                query["Imsi"] = request.Imsi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRecharge))
            {
                query["IsAutoRecharge"] = request.IsAutoRecharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msisdn))
            {
                query["Msisdn"] = request.Msisdn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyId))
            {
                query["NotifyId"] = request.NotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsStatus))
            {
                query["OsStatus"] = request.OsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolId))
            {
                query["PoolId"] = request.PoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimType))
            {
                query["SimType"] = request.SimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                query["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardInfo",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCardInfoResponse> ListCardInfoWithOptionsAsync(ListCardInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveTimeEnd))
            {
                query["ActiveTimeEnd"] = request.ActiveTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveTimeStart))
            {
                query["ActiveTimeStart"] = request.ActiveTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliFee))
            {
                query["AliFee"] = request.AliFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunOrderId))
            {
                query["AliyunOrderId"] = request.AliyunOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApnName))
            {
                query["ApnName"] = request.ApnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyType))
            {
                query["CertifyType"] = request.CertifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNo))
            {
                query["CredentialNo"] = request.CredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataLevel))
            {
                query["DataLevel"] = request.DataLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectionalGroupId))
            {
                query["DirectionalGroupId"] = request.DirectionalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeEnd))
            {
                query["ExpireTimeEnd"] = request.ExpireTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeStart))
            {
                query["ExpireTimeStart"] = request.ExpireTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imsi))
            {
                query["Imsi"] = request.Imsi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRecharge))
            {
                query["IsAutoRecharge"] = request.IsAutoRecharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msisdn))
            {
                query["Msisdn"] = request.Msisdn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyId))
            {
                query["NotifyId"] = request.NotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsStatus))
            {
                query["OsStatus"] = request.OsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolId))
            {
                query["PoolId"] = request.PoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimType))
            {
                query["SimType"] = request.SimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                query["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardInfo",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCardInfoResponse ListCardInfo(ListCardInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCardInfoWithOptions(request, runtime);
        }

        public async Task<ListCardInfoResponse> ListCardInfoAsync(ListCardInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCardInfoWithOptionsAsync(request, runtime);
        }

        public ListOrderResponse ListOrderWithOptions(ListOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrder",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOrderResponse> ListOrderWithOptionsAsync(ListOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrder",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOrderResponse ListOrder(ListOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrderWithOptions(request, runtime);
        }

        public async Task<ListOrderResponse> ListOrderAsync(ListOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrderWithOptionsAsync(request, runtime);
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

        public RenewResponse RenewWithOptions(RenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyNum))
            {
                query["BuyNum"] = request.BuyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfferCode))
            {
                query["OfferCode"] = request.OfferCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RechargeType))
            {
                query["RechargeType"] = request.RechargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiProduct))
            {
                body["ApiProduct"] = request.ApiProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiRevision))
            {
                body["ApiRevision"] = request.ApiRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Renew",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenewResponse> RenewWithOptionsAsync(RenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyNum))
            {
                query["BuyNum"] = request.BuyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfferCode))
            {
                query["OfferCode"] = request.OfferCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RechargeType))
            {
                query["RechargeType"] = request.RechargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiProduct))
            {
                body["ApiProduct"] = request.ApiProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiRevision))
            {
                body["ApiRevision"] = request.ApiRevision;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Renew",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenewResponse Renew(RenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewWithOptions(request, runtime);
        }

        public async Task<RenewResponse> RenewAsync(RenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewWithOptionsAsync(request, runtime);
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

        public SetCardStopRuleResponse SetCardStopRuleWithOptions(SetCardStopRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRestore))
            {
                query["AutoRestore"] = request.AutoRestore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLimit))
            {
                query["FlowLimit"] = request.FlowLimit;
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
                Action = "SetCardStopRule",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCardStopRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetCardStopRuleResponse> SetCardStopRuleWithOptionsAsync(SetCardStopRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRestore))
            {
                query["AutoRestore"] = request.AutoRestore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLimit))
            {
                query["FlowLimit"] = request.FlowLimit;
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
                Action = "SetCardStopRule",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCardStopRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetCardStopRuleResponse SetCardStopRule(SetCardStopRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCardStopRuleWithOptions(request, runtime);
        }

        public async Task<SetCardStopRuleResponse> SetCardStopRuleAsync(SetCardStopRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCardStopRuleWithOptionsAsync(request, runtime);
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

        public UpdateAutoRechargeSwitchResponse UpdateAutoRechargeSwitchWithOptions(UpdateAutoRechargeSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Open))
            {
                query["Open"] = request.Open;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoRechargeSwitch",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoRechargeSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAutoRechargeSwitchResponse> UpdateAutoRechargeSwitchWithOptionsAsync(UpdateAutoRechargeSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Open))
            {
                query["Open"] = request.Open;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoRechargeSwitch",
                Version = "2021-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoRechargeSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAutoRechargeSwitchResponse UpdateAutoRechargeSwitch(UpdateAutoRechargeSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoRechargeSwitchWithOptions(request, runtime);
        }

        public async Task<UpdateAutoRechargeSwitchResponse> UpdateAutoRechargeSwitchAsync(UpdateAutoRechargeSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoRechargeSwitchWithOptionsAsync(request, runtime);
        }

    }
}
