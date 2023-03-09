// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Agency20180703.Models;

namespace AlibabaCloud.SDK.Agency20180703
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "agency.aliyuncs.com"},
                {"ap-northeast-2-pop", "agency.aliyuncs.com"},
                {"ap-south-1", "agency.aliyuncs.com"},
                {"ap-southeast-2", "agency.aliyuncs.com"},
                {"ap-southeast-3", "agency.aliyuncs.com"},
                {"ap-southeast-5", "agency.aliyuncs.com"},
                {"cn-beijing", "agency.aliyuncs.com"},
                {"cn-beijing-finance-1", "agency.aliyuncs.com"},
                {"cn-beijing-finance-pop", "agency.aliyuncs.com"},
                {"cn-beijing-gov-1", "agency.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "agency.aliyuncs.com"},
                {"cn-chengdu", "agency.aliyuncs.com"},
                {"cn-edge-1", "agency.aliyuncs.com"},
                {"cn-fujian", "agency.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "agency.aliyuncs.com"},
                {"cn-hangzhou", "agency.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "agency.aliyuncs.com"},
                {"cn-hangzhou-finance", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "agency.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "agency.aliyuncs.com"},
                {"cn-hangzhou-test-306", "agency.aliyuncs.com"},
                {"cn-hongkong", "agency.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "agency.aliyuncs.com"},
                {"cn-huhehaote", "agency.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "agency.aliyuncs.com"},
                {"cn-north-2-gov-1", "agency.aliyuncs.com"},
                {"cn-qingdao", "agency.aliyuncs.com"},
                {"cn-qingdao-nebula", "agency.aliyuncs.com"},
                {"cn-shanghai", "agency.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "agency.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "agency.aliyuncs.com"},
                {"cn-shanghai-finance-1", "agency.aliyuncs.com"},
                {"cn-shanghai-inner", "agency.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "agency.aliyuncs.com"},
                {"cn-shenzhen", "agency.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "agency.aliyuncs.com"},
                {"cn-shenzhen-inner", "agency.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "agency.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "agency.aliyuncs.com"},
                {"cn-wuhan", "agency.aliyuncs.com"},
                {"cn-wulanchabu", "agency.aliyuncs.com"},
                {"cn-yushanfang", "agency.aliyuncs.com"},
                {"cn-zhangbei", "agency.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "agency.aliyuncs.com"},
                {"cn-zhangjiakou", "agency.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "agency.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "agency.aliyuncs.com"},
                {"eu-central-1", "agency.aliyuncs.com"},
                {"eu-west-1", "agency.aliyuncs.com"},
                {"eu-west-1-oxs", "agency.aliyuncs.com"},
                {"me-east-1", "agency.aliyuncs.com"},
                {"rus-west-1-pop", "agency.aliyuncs.com"},
                {"us-east-1", "agency.aliyuncs.com"},
                {"us-west-1", "agency.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("agency", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ClearOutstandingBalanceResponse ClearOutstandingBalanceWithOptions(ClearOutstandingBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebtQuota))
            {
                query["DebtQuota"] = request.DebtQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserPk))
            {
                query["EndUserPk"] = request.EndUserPk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearOutstandingBalance",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearOutstandingBalanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ClearOutstandingBalanceResponse> ClearOutstandingBalanceWithOptionsAsync(ClearOutstandingBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebtQuota))
            {
                query["DebtQuota"] = request.DebtQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserPk))
            {
                query["EndUserPk"] = request.EndUserPk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearOutstandingBalance",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearOutstandingBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ClearOutstandingBalanceResponse ClearOutstandingBalance(ClearOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearOutstandingBalanceWithOptions(request, runtime);
        }

        public async Task<ClearOutstandingBalanceResponse> ClearOutstandingBalanceAsync(ClearOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearOutstandingBalanceWithOptionsAsync(request, runtime);
        }

        public CreateNormalAccountResponse CreateNormalAccountWithOptions(CreateNormalAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateNormalAccountInfoList))
            {
                query["CreateNormalAccountInfoList"] = request.CreateNormalAccountInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNormalAccount",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNormalAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateNormalAccountResponse> CreateNormalAccountWithOptionsAsync(CreateNormalAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateNormalAccountInfoList))
            {
                query["CreateNormalAccountInfoList"] = request.CreateNormalAccountInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNormalAccount",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNormalAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateNormalAccountResponse CreateNormalAccount(CreateNormalAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNormalAccountWithOptions(request, runtime);
        }

        public async Task<CreateNormalAccountResponse> CreateNormalAccountAsync(CreateNormalAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNormalAccountWithOptionsAsync(request, runtime);
        }

        public DeductOutstandingBalanceResponse DeductOutstandingBalanceWithOptions(DeductOutstandingBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductAmount))
            {
                query["DeductAmount"] = request.DeductAmount;
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
                Action = "DeductOutstandingBalance",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductOutstandingBalanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeductOutstandingBalanceResponse> DeductOutstandingBalanceWithOptionsAsync(DeductOutstandingBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductAmount))
            {
                query["DeductAmount"] = request.DeductAmount;
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
                Action = "DeductOutstandingBalance",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductOutstandingBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeductOutstandingBalanceResponse DeductOutstandingBalance(DeductOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeductOutstandingBalanceWithOptions(request, runtime);
        }

        public async Task<DeductOutstandingBalanceResponse> DeductOutstandingBalanceAsync(DeductOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeductOutstandingBalanceWithOptionsAsync(request, runtime);
        }

        public GetAccountInfoResponse GetAccountInfoWithOptions(GetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
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
                Action = "GetAccountInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAccountInfoResponse> GetAccountInfoWithOptionsAsync(GetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
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
                Action = "GetAccountInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAccountInfoResponse GetAccountInfo(GetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountInfoWithOptions(request, runtime);
        }

        public async Task<GetAccountInfoResponse> GetAccountInfoAsync(GetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountInfoWithOptionsAsync(request, runtime);
        }

        public GetAssociationStatusResponse GetAssociationStatusWithOptions(GetAssociationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetAssociationStatusList))
            {
                query["GetAssociationStatusList"] = request.GetAssociationStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAssociationStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAssociationStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAssociationStatusResponse> GetAssociationStatusWithOptionsAsync(GetAssociationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetAssociationStatusList))
            {
                query["GetAssociationStatusList"] = request.GetAssociationStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAssociationStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAssociationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAssociationStatusResponse GetAssociationStatus(GetAssociationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAssociationStatusWithOptions(request, runtime);
        }

        public async Task<GetAssociationStatusResponse> GetAssociationStatusAsync(GetAssociationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAssociationStatusWithOptionsAsync(request, runtime);
        }

        public GetBillDetailResponse GetBillDetailWithOptions(GetBillDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBillDetail",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBillDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBillDetailResponse> GetBillDetailWithOptionsAsync(GetBillDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                query["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hid))
            {
                query["Hid"] = request.Hid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBillDetail",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBillDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBillDetailResponse GetBillDetail(GetBillDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBillDetailWithOptions(request, runtime);
        }

        public async Task<GetBillDetailResponse> GetBillDetailAsync(GetBillDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBillDetailWithOptionsAsync(request, runtime);
        }

        public GetBillListResponse GetBillListWithOptions(GetBillListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                query["InstId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsStronger))
            {
                query["IsStronger"] = request.IsStronger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayStatus))
            {
                query["PayStatus"] = request.PayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
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
                Action = "GetBillList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBillListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBillListResponse> GetBillListWithOptionsAsync(GetBillListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                query["InstId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsStronger))
            {
                query["IsStronger"] = request.IsStronger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayStatus))
            {
                query["PayStatus"] = request.PayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
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
                Action = "GetBillList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBillListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBillListResponse GetBillList(GetBillListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBillListWithOptions(request, runtime);
        }

        public async Task<GetBillListResponse> GetBillListAsync(GetBillListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBillListWithOptionsAsync(request, runtime);
        }

        public GetCreditInfoResponse GetCreditInfoWithOptions(GetCreditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetCreditInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreditInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCreditInfoResponse> GetCreditInfoWithOptionsAsync(GetCreditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetCreditInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreditInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCreditInfoResponse GetCreditInfo(GetCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreditInfoWithOptions(request, runtime);
        }

        public async Task<GetCreditInfoResponse> GetCreditInfoAsync(GetCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreditInfoWithOptionsAsync(request, runtime);
        }

        public GetCustomerListResponse GetCustomerListWithOptions(GetCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerGcLevel))
            {
                query["CustomerGcLevel"] = request.CustomerGcLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerStatus))
            {
                query["CustomerStatus"] = request.CustomerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCustomerListResponse> GetCustomerListWithOptionsAsync(GetCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerGcLevel))
            {
                query["CustomerGcLevel"] = request.CustomerGcLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerStatus))
            {
                query["CustomerStatus"] = request.CustomerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCustomerListResponse GetCustomerList(GetCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerListWithOptions(request, runtime);
        }

        public async Task<GetCustomerListResponse> GetCustomerListAsync(GetCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerListWithOptionsAsync(request, runtime);
        }

        public GetDailyBillResponse GetDailyBillWithOptions(GetDailyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
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
                Action = "GetDailyBill",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDailyBillResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDailyBillResponse> GetDailyBillWithOptionsAsync(GetDailyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
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
                Action = "GetDailyBill",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDailyBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDailyBillResponse GetDailyBill(GetDailyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDailyBillWithOptions(request, runtime);
        }

        public async Task<GetDailyBillResponse> GetDailyBillAsync(GetDailyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDailyBillWithOptionsAsync(request, runtime);
        }

        public GetDailyBillListResponse GetDailyBillListWithOptions(GetDailyBillListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillTime))
            {
                query["BillTime"] = request.BillTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
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
                Action = "GetDailyBillList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDailyBillListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDailyBillListResponse> GetDailyBillListWithOptionsAsync(GetDailyBillListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillTime))
            {
                query["BillTime"] = request.BillTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
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
                Action = "GetDailyBillList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDailyBillListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDailyBillListResponse GetDailyBillList(GetDailyBillListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDailyBillListWithOptions(request, runtime);
        }

        public async Task<GetDailyBillListResponse> GetDailyBillListAsync(GetDailyBillListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDailyBillListWithOptionsAsync(request, runtime);
        }

        public GetInstanceListResponse GetInstanceListWithOptions(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                query["Ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIpAddresse))
            {
                query["PublicIpAddresse"] = request.PublicIpAddresse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                query["Sk"] = request.Sk;
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
                Action = "GetInstanceList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceListResponse> GetInstanceListWithOptionsAsync(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                query["Ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIpAddresse))
            {
                query["PublicIpAddresse"] = request.PublicIpAddresse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                query["Sk"] = request.Sk;
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
                Action = "GetInstanceList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceListResponse GetInstanceList(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceListWithOptions(request, runtime);
        }

        public async Task<GetInstanceListResponse> GetInstanceListAsync(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceListWithOptionsAsync(request, runtime);
        }

        public GetInviteStatusResponse GetInviteStatusWithOptions(GetInviteStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteStatusList))
            {
                query["InviteStatusList"] = request.InviteStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInviteStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInviteStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInviteStatusResponse> GetInviteStatusWithOptionsAsync(GetInviteStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteStatusList))
            {
                query["InviteStatusList"] = request.InviteStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInviteStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInviteStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInviteStatusResponse GetInviteStatus(GetInviteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInviteStatusWithOptions(request, runtime);
        }

        public async Task<GetInviteStatusResponse> GetInviteStatusAsync(GetInviteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInviteStatusWithOptionsAsync(request, runtime);
        }

        public GetMonthBillListResponse GetMonthBillListWithOptions(GetMonthBillListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthBillTime))
            {
                query["MonthBillTime"] = request.MonthBillTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthBillType))
            {
                query["MonthBillType"] = request.MonthBillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthUserType))
            {
                query["MonthUserType"] = request.MonthUserType;
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
                Action = "GetMonthBillList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthBillListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMonthBillListResponse> GetMonthBillListWithOptionsAsync(GetMonthBillListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthBillTime))
            {
                query["MonthBillTime"] = request.MonthBillTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthBillType))
            {
                query["MonthBillType"] = request.MonthBillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthUserType))
            {
                query["MonthUserType"] = request.MonthUserType;
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
                Action = "GetMonthBillList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthBillListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMonthBillListResponse GetMonthBillList(GetMonthBillListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonthBillListWithOptions(request, runtime);
        }

        public async Task<GetMonthBillListResponse> GetMonthBillListAsync(GetMonthBillListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonthBillListWithOptionsAsync(request, runtime);
        }

        public GetMonthlyBillResponse GetMonthlyBillWithOptions(GetMonthlyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthlyBill",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthlyBillResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMonthlyBillResponse> GetMonthlyBillWithOptionsAsync(GetMonthlyBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwner))
            {
                query["BillOwner"] = request.BillOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillType))
            {
                query["BillType"] = request.BillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthlyBill",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthlyBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMonthlyBillResponse GetMonthlyBill(GetMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonthlyBillWithOptions(request, runtime);
        }

        public async Task<GetMonthlyBillResponse> GetMonthlyBillAsync(GetMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonthlyBillWithOptionsAsync(request, runtime);
        }

        public GetOrderDetailResponse GetOrderDetailWithOptions(GetOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["OrderNo"] = request.OrderNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderDetail",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrderDetailResponse> GetOrderDetailWithOptionsAsync(GetOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["OrderNo"] = request.OrderNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderDetail",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrderDetailResponse GetOrderDetail(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrderDetailWithOptions(request, runtime);
        }

        public async Task<GetOrderDetailResponse> GetOrderDetailAsync(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrderDetailWithOptionsAsync(request, runtime);
        }

        public GetOrderListResponse GetOrderListWithOptions(GetOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsStronger))
            {
                query["IsStronger"] = request.IsStronger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                query["TimeType"] = request.TimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrderListResponse> GetOrderListWithOptionsAsync(GetOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsStronger))
            {
                query["IsStronger"] = request.IsStronger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                query["TimeType"] = request.TimeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrderListResponse GetOrderList(GetOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrderListWithOptions(request, runtime);
        }

        public async Task<GetOrderListResponse> GetOrderListAsync(GetOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrderListWithOptionsAsync(request, runtime);
        }

        public GetShareAccountListResponse GetShareAccountListWithOptions(GetShareAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareAccountList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareAccountListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetShareAccountListResponse> GetShareAccountListWithOptionsAsync(GetShareAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareAccountList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareAccountListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetShareAccountListResponse GetShareAccountList(GetShareAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetShareAccountListWithOptions(request, runtime);
        }

        public async Task<GetShareAccountListResponse> GetShareAccountListAsync(GetShareAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetShareAccountListWithOptionsAsync(request, runtime);
        }

        public GetShareCustomerListResponse GetShareCustomerListWithOptions(GetShareCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerType))
            {
                query["CustomerType"] = request.CustomerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExitOnGoingProject))
            {
                query["ExitOnGoingProject"] = request.ExitOnGoingProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareCustomerList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareCustomerListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetShareCustomerListResponse> GetShareCustomerListWithOptionsAsync(GetShareCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerName))
            {
                query["CustomerName"] = request.CustomerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerType))
            {
                query["CustomerType"] = request.CustomerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExitOnGoingProject))
            {
                query["ExitOnGoingProject"] = request.ExitOnGoingProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUid))
            {
                query["RamUid"] = request.RamUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShareCustomerList",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareCustomerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetShareCustomerListResponse GetShareCustomerList(GetShareCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetShareCustomerListWithOptions(request, runtime);
        }

        public async Task<GetShareCustomerListResponse> GetShareCustomerListAsync(GetShareCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetShareCustomerListWithOptionsAsync(request, runtime);
        }

        public GetSubAccountInfoResponse GetSubAccountInfoWithOptions(GetSubAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
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
                Action = "GetSubAccountInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSubAccountInfoResponse> GetSubAccountInfoWithOptionsAsync(GetSubAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
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
                Action = "GetSubAccountInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSubAccountInfoResponse GetSubAccountInfo(GetSubAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubAccountInfoWithOptions(request, runtime);
        }

        public async Task<GetSubAccountInfoResponse> GetSubAccountInfoAsync(GetSubAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubAccountInfoWithOptionsAsync(request, runtime);
        }

        public GetUnassociatedCustomerResponse GetUnassociatedCustomerWithOptions(GetUnassociatedCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnassociatedCustomer",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnassociatedCustomerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUnassociatedCustomerResponse> GetUnassociatedCustomerWithOptionsAsync(GetUnassociatedCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUnassociatedCustomer",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUnassociatedCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUnassociatedCustomerResponse GetUnassociatedCustomer(GetUnassociatedCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUnassociatedCustomerWithOptions(request, runtime);
        }

        public async Task<GetUnassociatedCustomerResponse> GetUnassociatedCustomerAsync(GetUnassociatedCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUnassociatedCustomerWithOptionsAsync(request, runtime);
        }

        public InviteSubAccountResponse InviteSubAccountWithOptions(InviteSubAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountInfoList))
            {
                query["AccountInfoList"] = request.AccountInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteSubAccount",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteSubAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InviteSubAccountResponse> InviteSubAccountWithOptionsAsync(InviteSubAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountInfoList))
            {
                query["AccountInfoList"] = request.AccountInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InviteSubAccount",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InviteSubAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InviteSubAccountResponse InviteSubAccount(InviteSubAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InviteSubAccountWithOptions(request, runtime);
        }

        public async Task<InviteSubAccountResponse> InviteSubAccountAsync(InviteSubAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InviteSubAccountWithOptionsAsync(request, runtime);
        }

        public ReportCustomerResponse ReportCustomerWithOptions(ReportCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportCustomerInfoList))
            {
                query["ReportCustomerInfoList"] = request.ReportCustomerInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportCustomer",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportCustomerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReportCustomerResponse> ReportCustomerWithOptionsAsync(ReportCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportCustomerInfoList))
            {
                query["ReportCustomerInfoList"] = request.ReportCustomerInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportCustomer",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReportCustomerResponse ReportCustomer(ReportCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportCustomerWithOptions(request, runtime);
        }

        public async Task<ReportCustomerResponse> ReportCustomerAsync(ReportCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportCustomerWithOptionsAsync(request, runtime);
        }

        public ResendEmailResponse ResendEmailWithOptions(ResendEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteId))
            {
                query["InviteId"] = request.InviteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendEmail",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendEmailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResendEmailResponse> ResendEmailWithOptionsAsync(ResendEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviteId))
            {
                query["InviteId"] = request.InviteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendEmail",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResendEmailResponse ResendEmail(ResendEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendEmailWithOptions(request, runtime);
        }

        public async Task<ResendEmailResponse> ResendEmailAsync(ResendEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendEmailWithOptionsAsync(request, runtime);
        }

        public SetAccountInfoResponse SetAccountInfoWithOptions(SetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNickname))
            {
                query["AccountNickname"] = request.AccountNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "SetAccountInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetAccountInfoResponse> SetAccountInfoWithOptionsAsync(SetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNickname))
            {
                query["AccountNickname"] = request.AccountNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "SetAccountInfo",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetAccountInfoResponse SetAccountInfo(SetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccountInfoWithOptions(request, runtime);
        }

        public async Task<SetAccountInfoResponse> SetAccountInfoAsync(SetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccountInfoWithOptionsAsync(request, runtime);
        }

        public SetCreditLimitResponse SetCreditLimitWithOptions(SetCreditLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserPk))
            {
                query["EndUserPk"] = request.EndUserPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCreditLimit",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLimitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetCreditLimitResponse> SetCreditLimitWithOptionsAsync(SetCreditLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPk))
            {
                query["AliyunPk"] = request.AliyunPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserPk))
            {
                query["EndUserPk"] = request.EndUserPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCreditLimit",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetCreditLimitResponse SetCreditLimit(SetCreditLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCreditLimitWithOptions(request, runtime);
        }

        public async Task<SetCreditLimitResponse> SetCreditLimitAsync(SetCreditLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCreditLimitWithOptionsAsync(request, runtime);
        }

        public SetCreditLimitStatusResponse SetCreditLimitStatusWithOptions(SetCreditLimitStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditStatus))
            {
                query["CreditStatus"] = request.CreditStatus;
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
                Action = "SetCreditLimitStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLimitStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetCreditLimitStatusResponse> SetCreditLimitStatusWithOptionsAsync(SetCreditLimitStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditStatus))
            {
                query["CreditStatus"] = request.CreditStatus;
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
                Action = "SetCreditLimitStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLimitStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetCreditLimitStatusResponse SetCreditLimitStatus(SetCreditLimitStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCreditLimitStatusWithOptions(request, runtime);
        }

        public async Task<SetCreditLimitStatusResponse> SetCreditLimitStatusAsync(SetCreditLimitStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCreditLimitStatusWithOptionsAsync(request, runtime);
        }

        public SetCreditLineResponse SetCreditLineWithOptions(SetCreditLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditLine))
            {
                query["CreditLine"] = request.CreditLine;
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
                Action = "SetCreditLine",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetCreditLineResponse> SetCreditLineWithOptionsAsync(SetCreditLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditLine))
            {
                query["CreditLine"] = request.CreditLine;
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
                Action = "SetCreditLine",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetCreditLineResponse SetCreditLine(SetCreditLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCreditLineWithOptions(request, runtime);
        }

        public async Task<SetCreditLineResponse> SetCreditLineAsync(SetCreditLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCreditLineWithOptionsAsync(request, runtime);
        }

        public SetCreditStatusResponse SetCreditStatusWithOptions(SetCreditStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditStatus))
            {
                query["CreditStatus"] = request.CreditStatus;
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
                Action = "SetCreditStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetCreditStatusResponse> SetCreditStatusWithOptionsAsync(SetCreditStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditStatus))
            {
                query["CreditStatus"] = request.CreditStatus;
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
                Action = "SetCreditStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCreditStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetCreditStatusResponse SetCreditStatus(SetCreditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCreditStatusWithOptions(request, runtime);
        }

        public async Task<SetCreditStatusResponse> SetCreditStatusAsync(SetCreditStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCreditStatusWithOptionsAsync(request, runtime);
        }

        public SetWarningThresholdResponse SetWarningThresholdWithOptions(SetWarningThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarningValue))
            {
                query["WarningValue"] = request.WarningValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWarningThreshold",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWarningThresholdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetWarningThresholdResponse> SetWarningThresholdWithOptionsAsync(SetWarningThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarningValue))
            {
                query["WarningValue"] = request.WarningValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWarningThreshold",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWarningThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetWarningThresholdResponse SetWarningThreshold(SetWarningThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWarningThresholdWithOptions(request, runtime);
        }

        public async Task<SetWarningThresholdResponse> SetWarningThresholdAsync(SetWarningThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWarningThresholdWithOptionsAsync(request, runtime);
        }

        public SetZeroCreditShutdownPolicyResponse SetZeroCreditShutdownPolicyWithOptions(SetZeroCreditShutdownPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownPolicy))
            {
                query["ShutdownPolicy"] = request.ShutdownPolicy;
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
                Action = "SetZeroCreditShutdownPolicy",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetZeroCreditShutdownPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetZeroCreditShutdownPolicyResponse> SetZeroCreditShutdownPolicyWithOptionsAsync(SetZeroCreditShutdownPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownPolicy))
            {
                query["ShutdownPolicy"] = request.ShutdownPolicy;
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
                Action = "SetZeroCreditShutdownPolicy",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetZeroCreditShutdownPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetZeroCreditShutdownPolicyResponse SetZeroCreditShutdownPolicy(SetZeroCreditShutdownPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetZeroCreditShutdownPolicyWithOptions(request, runtime);
        }

        public async Task<SetZeroCreditShutdownPolicyResponse> SetZeroCreditShutdownPolicyAsync(SetZeroCreditShutdownPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetZeroCreditShutdownPolicyWithOptionsAsync(request, runtime);
        }

        public SetZeroCreditShutdownStatusResponse SetZeroCreditShutdownStatusWithOptions(SetZeroCreditShutdownStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownPolicy))
            {
                query["ShutdownPolicy"] = request.ShutdownPolicy;
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
                Action = "SetZeroCreditShutdownStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetZeroCreditShutdownStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetZeroCreditShutdownStatusResponse> SetZeroCreditShutdownStatusWithOptionsAsync(SetZeroCreditShutdownStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShutdownPolicy))
            {
                query["ShutdownPolicy"] = request.ShutdownPolicy;
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
                Action = "SetZeroCreditShutdownStatus",
                Version = "2018-07-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetZeroCreditShutdownStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetZeroCreditShutdownStatusResponse SetZeroCreditShutdownStatus(SetZeroCreditShutdownStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetZeroCreditShutdownStatusWithOptions(request, runtime);
        }

        public async Task<SetZeroCreditShutdownStatusResponse> SetZeroCreditShutdownStatusAsync(SetZeroCreditShutdownStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetZeroCreditShutdownStatusWithOptionsAsync(request, runtime);
        }

    }
}
