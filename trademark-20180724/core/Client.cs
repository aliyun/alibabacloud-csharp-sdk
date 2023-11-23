// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Trademark20180724.Models;

namespace AlibabaCloud.SDK.Trademark20180724
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("trademark", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AcceptPartnerNotificationResponse AcceptPartnerNotificationWithOptions(AcceptPartnerNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Material))
            {
                query["Material"] = request.Material;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptPartnerNotification",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptPartnerNotificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AcceptPartnerNotificationResponse> AcceptPartnerNotificationWithOptionsAsync(AcceptPartnerNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Material))
            {
                query["Material"] = request.Material;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptPartnerNotification",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptPartnerNotificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AcceptPartnerNotificationResponse AcceptPartnerNotification(AcceptPartnerNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptPartnerNotificationWithOptions(request, runtime);
        }

        public async Task<AcceptPartnerNotificationResponse> AcceptPartnerNotificationAsync(AcceptPartnerNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptPartnerNotificationWithOptionsAsync(request, runtime);
        }

        public ApplyNotaryPostResponse ApplyNotaryPostWithOptions(ApplyNotaryPostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryOrderId))
            {
                query["NotaryOrderId"] = request.NotaryOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAddress))
            {
                query["ReceiverAddress"] = request.ReceiverAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                query["ReceiverName"] = request.ReceiverName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverPhone))
            {
                query["ReceiverPhone"] = request.ReceiverPhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyNotaryPost",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyNotaryPostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyNotaryPostResponse> ApplyNotaryPostWithOptionsAsync(ApplyNotaryPostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryOrderId))
            {
                query["NotaryOrderId"] = request.NotaryOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAddress))
            {
                query["ReceiverAddress"] = request.ReceiverAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                query["ReceiverName"] = request.ReceiverName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverPhone))
            {
                query["ReceiverPhone"] = request.ReceiverPhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyNotaryPost",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyNotaryPostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyNotaryPostResponse ApplyNotaryPost(ApplyNotaryPostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyNotaryPostWithOptions(request, runtime);
        }

        public async Task<ApplyNotaryPostResponse> ApplyNotaryPostAsync(ApplyNotaryPostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyNotaryPostWithOptionsAsync(request, runtime);
        }

        public AskAdjudicationFileResponse AskAdjudicationFileWithOptions(AskAdjudicationFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskAdjudicationFile",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskAdjudicationFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AskAdjudicationFileResponse> AskAdjudicationFileWithOptionsAsync(AskAdjudicationFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskAdjudicationFile",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskAdjudicationFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AskAdjudicationFileResponse AskAdjudicationFile(AskAdjudicationFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AskAdjudicationFileWithOptions(request, runtime);
        }

        public async Task<AskAdjudicationFileResponse> AskAdjudicationFileAsync(AskAdjudicationFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AskAdjudicationFileWithOptionsAsync(request, runtime);
        }

        public BindMaterialResponse BindMaterialWithOptions(BindMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindMaterialResponse> BindMaterialWithOptionsAsync(BindMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindMaterialResponse BindMaterial(BindMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindMaterialWithOptions(request, runtime);
        }

        public async Task<BindMaterialResponse> BindMaterialAsync(BindMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindMaterialWithOptionsAsync(request, runtime);
        }

        public CancelTradeOrderResponse CancelTradeOrderWithOptions(CancelTradeOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTradeOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTradeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelTradeOrderResponse> CancelTradeOrderWithOptionsAsync(CancelTradeOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTradeOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTradeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelTradeOrderResponse CancelTradeOrder(CancelTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelTradeOrderWithOptions(request, runtime);
        }

        public async Task<CancelTradeOrderResponse> CancelTradeOrderAsync(CancelTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelTradeOrderWithOptionsAsync(request, runtime);
        }

        public CheckFlsmFillResponse CheckFlsmFillWithOptions(CheckFlsmFillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WtrName))
            {
                query["WtrName"] = request.WtrName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFlsmFill",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFlsmFillResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckFlsmFillResponse> CheckFlsmFillWithOptionsAsync(CheckFlsmFillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WtrName))
            {
                query["WtrName"] = request.WtrName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFlsmFill",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFlsmFillResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckFlsmFillResponse CheckFlsmFill(CheckFlsmFillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFlsmFillWithOptions(request, runtime);
        }

        public async Task<CheckFlsmFillResponse> CheckFlsmFillAsync(CheckFlsmFillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFlsmFillWithOptionsAsync(request, runtime);
        }

        public CheckIfCollectedResponse CheckIfCollectedWithOptions(CheckIfCollectedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdList))
            {
                query["ItemIdList"] = request.ItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckIfCollected",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckIfCollectedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckIfCollectedResponse> CheckIfCollectedWithOptionsAsync(CheckIfCollectedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdList))
            {
                query["ItemIdList"] = request.ItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckIfCollected",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckIfCollectedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckIfCollectedResponse CheckIfCollected(CheckIfCollectedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckIfCollectedWithOptions(request, runtime);
        }

        public async Task<CheckIfCollectedResponse> CheckIfCollectedAsync(CheckIfCollectedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckIfCollectedWithOptionsAsync(request, runtime);
        }

        public CheckLoaFillResponse CheckLoaFillWithOptions(CheckLoaFillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WtrName))
            {
                query["WtrName"] = request.WtrName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckLoaFill",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckLoaFillResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckLoaFillResponse> CheckLoaFillWithOptionsAsync(CheckLoaFillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WtrName))
            {
                query["WtrName"] = request.WtrName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckLoaFill",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckLoaFillResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckLoaFillResponse CheckLoaFill(CheckLoaFillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckLoaFillWithOptions(request, runtime);
        }

        public async Task<CheckLoaFillResponse> CheckLoaFillAsync(CheckLoaFillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckLoaFillWithOptionsAsync(request, runtime);
        }

        public CheckTrademarkIconResponse CheckTrademarkIconWithOptions(CheckTrademarkIconRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIconOssKey))
            {
                query["TrademarkIconOssKey"] = request.TrademarkIconOssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTrademarkIcon",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTrademarkIconResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckTrademarkIconResponse> CheckTrademarkIconWithOptionsAsync(CheckTrademarkIconRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                query["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkIconOssKey))
            {
                query["TrademarkIconOssKey"] = request.TrademarkIconOssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTrademarkIcon",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTrademarkIconResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckTrademarkIconResponse CheckTrademarkIcon(CheckTrademarkIconRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTrademarkIconWithOptions(request, runtime);
        }

        public async Task<CheckTrademarkIconResponse> CheckTrademarkIconAsync(CheckTrademarkIconRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTrademarkIconWithOptionsAsync(request, runtime);
        }

        public CheckTrademarkOrderResponse CheckTrademarkOrderWithOptions(CheckTrademarkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBlackIcon))
            {
                query["IsBlackIcon"] = request.IsBlackIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoGoodsId))
            {
                query["LogoGoodsId"] = request.LogoGoodsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderData))
            {
                query["OrderData"] = request.OrderData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerCode))
            {
                query["PartnerCode"] = request.PartnerCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealUserName))
            {
                query["RealUserName"] = request.RealUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterName))
            {
                query["RegisterName"] = request.RegisterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewInfoId))
            {
                query["RenewInfoId"] = request.RenewInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootCode))
            {
                query["RootCode"] = request.RootCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                query["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNameType))
            {
                query["TmNameType"] = request.TmNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTrademarkOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTrademarkOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckTrademarkOrderResponse> CheckTrademarkOrderWithOptionsAsync(CheckTrademarkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBlackIcon))
            {
                query["IsBlackIcon"] = request.IsBlackIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoGoodsId))
            {
                query["LogoGoodsId"] = request.LogoGoodsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderData))
            {
                query["OrderData"] = request.OrderData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerCode))
            {
                query["PartnerCode"] = request.PartnerCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealUserName))
            {
                query["RealUserName"] = request.RealUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterName))
            {
                query["RegisterName"] = request.RegisterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewInfoId))
            {
                query["RenewInfoId"] = request.RenewInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootCode))
            {
                query["RootCode"] = request.RootCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                query["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNameType))
            {
                query["TmNameType"] = request.TmNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTrademarkOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTrademarkOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckTrademarkOrderResponse CheckTrademarkOrder(CheckTrademarkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTrademarkOrderWithOptions(request, runtime);
        }

        public async Task<CheckTrademarkOrderResponse> CheckTrademarkOrderAsync(CheckTrademarkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTrademarkOrderWithOptionsAsync(request, runtime);
        }

        public CombineLoaResponse CombineLoaWithOptions(CombineLoaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPostcode))
            {
                query["ContactPostcode"] = request.ContactPostcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nationality))
            {
                query["Nationality"] = request.Nationality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceType))
            {
                query["TmProduceType"] = request.TmProduceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CombineLoa",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CombineLoaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CombineLoaResponse> CombineLoaWithOptionsAsync(CombineLoaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantType))
            {
                query["ApplicantType"] = request.ApplicantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPostcode))
            {
                query["ContactPostcode"] = request.ContactPostcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nationality))
            {
                query["Nationality"] = request.Nationality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceType))
            {
                query["TmProduceType"] = request.TmProduceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CombineLoa",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CombineLoaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CombineLoaResponse CombineLoa(CombineLoaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CombineLoaWithOptions(request, runtime);
        }

        public async Task<CombineLoaResponse> CombineLoaAsync(CombineLoaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CombineLoaWithOptionsAsync(request, runtime);
        }

        public CombineWTSResponse CombineWTSWithOptions(CombineWTSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                query["Contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddressPost))
            {
                query["ContactAddressPost"] = request.ContactAddressPost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMobile))
            {
                query["ContactMobile"] = request.ContactMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nationality))
            {
                query["Nationality"] = request.Nationality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNum))
            {
                query["TmNum"] = request.TmNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceType))
            {
                query["TmProduceType"] = request.TmProduceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WtsType))
            {
                query["WtsType"] = request.WtsType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CombineWTS",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CombineWTSResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CombineWTSResponse> CombineWTSWithOptionsAsync(CombineWTSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                query["Contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddressPost))
            {
                query["ContactAddressPost"] = request.ContactAddressPost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMobile))
            {
                query["ContactMobile"] = request.ContactMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nationality))
            {
                query["Nationality"] = request.Nationality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNum))
            {
                query["TmNum"] = request.TmNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceType))
            {
                query["TmProduceType"] = request.TmProduceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkName))
            {
                query["TrademarkName"] = request.TrademarkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WtsType))
            {
                query["WtsType"] = request.WtsType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CombineWTS",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CombineWTSResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CombineWTSResponse CombineWTS(CombineWTSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CombineWTSWithOptions(request, runtime);
        }

        public async Task<CombineWTSResponse> CombineWTSAsync(CombineWTSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CombineWTSWithOptionsAsync(request, runtime);
        }

        public ComplementIntentionUserIdResponse ComplementIntentionUserIdWithOptions(ComplementIntentionUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                query["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplementUserId))
            {
                body["ComplementUserId"] = request.ComplementUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ComplementIntentionUserId",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ComplementIntentionUserIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ComplementIntentionUserIdResponse> ComplementIntentionUserIdWithOptionsAsync(ComplementIntentionUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                query["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComplementUserId))
            {
                body["ComplementUserId"] = request.ComplementUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ComplementIntentionUserId",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ComplementIntentionUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ComplementIntentionUserIdResponse ComplementIntentionUserId(ComplementIntentionUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ComplementIntentionUserIdWithOptions(request, runtime);
        }

        public async Task<ComplementIntentionUserIdResponse> ComplementIntentionUserIdAsync(ComplementIntentionUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ComplementIntentionUserIdWithOptionsAsync(request, runtime);
        }

        public ConfirmAdditionalMaterialResponse ConfirmAdditionalMaterialWithOptions(ConfirmAdditionalMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmAdditionalMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmAdditionalMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmAdditionalMaterialResponse> ConfirmAdditionalMaterialWithOptionsAsync(ConfirmAdditionalMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmAdditionalMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmAdditionalMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmAdditionalMaterialResponse ConfirmAdditionalMaterial(ConfirmAdditionalMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmAdditionalMaterialWithOptions(request, runtime);
        }

        public async Task<ConfirmAdditionalMaterialResponse> ConfirmAdditionalMaterialAsync(ConfirmAdditionalMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmAdditionalMaterialWithOptionsAsync(request, runtime);
        }

        public ConfirmApplicantResponse ConfirmApplicantWithOptions(ConfirmApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmApplicantResponse> ConfirmApplicantWithOptionsAsync(ConfirmApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmApplicantResponse ConfirmApplicant(ConfirmApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmApplicantWithOptions(request, runtime);
        }

        public async Task<ConfirmApplicantResponse> ConfirmApplicantAsync(ConfirmApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmApplicantWithOptionsAsync(request, runtime);
        }

        public ConfirmDissentOriginalResponse ConfirmDissentOriginalWithOptions(ConfirmDissentOriginalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDissentOriginal",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDissentOriginalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmDissentOriginalResponse> ConfirmDissentOriginalWithOptionsAsync(ConfirmDissentOriginalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDissentOriginal",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDissentOriginalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmDissentOriginalResponse ConfirmDissentOriginal(ConfirmDissentOriginalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmDissentOriginalWithOptions(request, runtime);
        }

        public async Task<ConfirmDissentOriginalResponse> ConfirmDissentOriginalAsync(ConfirmDissentOriginalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmDissentOriginalWithOptionsAsync(request, runtime);
        }

        public ConvertImageToGrayResponse ConvertImageToGrayWithOptions(ConvertImageToGrayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertImageToGray",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertImageToGrayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConvertImageToGrayResponse> ConvertImageToGrayWithOptionsAsync(ConvertImageToGrayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertImageToGray",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertImageToGrayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConvertImageToGrayResponse ConvertImageToGray(ConvertImageToGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertImageToGrayWithOptions(request, runtime);
        }

        public async Task<ConvertImageToGrayResponse> ConvertImageToGrayAsync(ConvertImageToGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertImageToGrayWithOptionsAsync(request, runtime);
        }

        public CopyApplicantResponse CopyApplicantWithOptions(CopyApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CopyApplicantResponse> CopyApplicantWithOptionsAsync(CopyApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CopyApplicantResponse CopyApplicant(CopyApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyApplicantWithOptions(request, runtime);
        }

        public async Task<CopyApplicantResponse> CopyApplicantAsync(CopyApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyApplicantWithOptionsAsync(request, runtime);
        }

        public CreateIntentionOrderResponse CreateIntentionOrderWithOptions(CreateIntentionOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntentionOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntentionOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIntentionOrderResponse> CreateIntentionOrderWithOptionsAsync(CreateIntentionOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntentionOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntentionOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIntentionOrderResponse CreateIntentionOrder(CreateIntentionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIntentionOrderWithOptions(request, runtime);
        }

        public async Task<CreateIntentionOrderResponse> CreateIntentionOrderAsync(CreateIntentionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIntentionOrderWithOptionsAsync(request, runtime);
        }

        public CreateIntentionOrderGeneratingPayResponse CreateIntentionOrderGeneratingPayWithOptions(CreateIntentionOrderGeneratingPayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentCallback))
            {
                query["PaymentCallback"] = request.PaymentCallback;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntentionOrderGeneratingPay",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntentionOrderGeneratingPayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIntentionOrderGeneratingPayResponse> CreateIntentionOrderGeneratingPayWithOptionsAsync(CreateIntentionOrderGeneratingPayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentCallback))
            {
                query["PaymentCallback"] = request.PaymentCallback;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntentionOrderGeneratingPay",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntentionOrderGeneratingPayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIntentionOrderGeneratingPayResponse CreateIntentionOrderGeneratingPay(CreateIntentionOrderGeneratingPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIntentionOrderGeneratingPayWithOptions(request, runtime);
        }

        public async Task<CreateIntentionOrderGeneratingPayResponse> CreateIntentionOrderGeneratingPayAsync(CreateIntentionOrderGeneratingPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIntentionOrderGeneratingPayWithOptionsAsync(request, runtime);
        }

        public CreateTrademarkOrderResponse CreateTrademarkOrderWithOptions(CreateTrademarkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BigDipperSource))
            {
                query["BigDipperSource"] = request.BigDipperSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBlackIcon))
            {
                query["IsBlackIcon"] = request.IsBlackIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderData))
            {
                query["OrderData"] = request.OrderData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerCode))
            {
                query["PartnerCode"] = request.PartnerCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealUserName))
            {
                query["RealUserName"] = request.RealUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterName))
            {
                query["RegisterName"] = request.RegisterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewInfoId))
            {
                query["RenewInfoId"] = request.RenewInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootCode))
            {
                query["RootCode"] = request.RootCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                query["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNameType))
            {
                query["TmNameType"] = request.TmNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ua))
            {
                query["Ua"] = request.Ua;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrademarkOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrademarkOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTrademarkOrderResponse> CreateTrademarkOrderWithOptionsAsync(CreateTrademarkOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementId))
            {
                query["AgreementId"] = request.AgreementId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BigDipperSource))
            {
                query["BigDipperSource"] = request.BigDipperSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBlackIcon))
            {
                query["IsBlackIcon"] = request.IsBlackIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeKey))
            {
                query["LegalNoticeKey"] = request.LegalNoticeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderData))
            {
                query["OrderData"] = request.OrderData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerCode))
            {
                query["PartnerCode"] = request.PartnerCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealUserName))
            {
                query["RealUserName"] = request.RealUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterName))
            {
                query["RegisterName"] = request.RegisterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewInfoId))
            {
                query["RenewInfoId"] = request.RenewInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootCode))
            {
                query["RootCode"] = request.RootCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                query["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNameType))
            {
                query["TmNameType"] = request.TmNameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ua))
            {
                query["Ua"] = request.Ua;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrademarkOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrademarkOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTrademarkOrderResponse CreateTrademarkOrder(CreateTrademarkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrademarkOrderWithOptions(request, runtime);
        }

        public async Task<CreateTrademarkOrderResponse> CreateTrademarkOrderAsync(CreateTrademarkOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrademarkOrderWithOptionsAsync(request, runtime);
        }

        public DeleteMaterialResponse DeleteMaterialWithOptions(DeleteMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMaterialResponse> DeleteMaterialWithOptionsAsync(DeleteMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMaterialResponse DeleteMaterial(DeleteMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMaterialWithOptions(request, runtime);
        }

        public async Task<DeleteMaterialResponse> DeleteMaterialAsync(DeleteMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMaterialWithOptionsAsync(request, runtime);
        }

        public DeleteTmMonitorRuleResponse DeleteTmMonitorRuleWithOptions(DeleteTmMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTmMonitorRule",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTmMonitorRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTmMonitorRuleResponse> DeleteTmMonitorRuleWithOptionsAsync(DeleteTmMonitorRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTmMonitorRule",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTmMonitorRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTmMonitorRuleResponse DeleteTmMonitorRule(DeleteTmMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTmMonitorRuleWithOptions(request, runtime);
        }

        public async Task<DeleteTmMonitorRuleResponse> DeleteTmMonitorRuleAsync(DeleteTmMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTmMonitorRuleWithOptionsAsync(request, runtime);
        }

        public DeleteTrademarkApplicationResponse DeleteTrademarkApplicationWithOptions(DeleteTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrademarkApplication",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrademarkApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTrademarkApplicationResponse> DeleteTrademarkApplicationWithOptionsAsync(DeleteTrademarkApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrademarkApplication",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrademarkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTrademarkApplicationResponse DeleteTrademarkApplication(DeleteTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrademarkApplicationWithOptions(request, runtime);
        }

        public async Task<DeleteTrademarkApplicationResponse> DeleteTrademarkApplicationAsync(DeleteTrademarkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrademarkApplicationWithOptionsAsync(request, runtime);
        }

        public DenySupplementResponse DenySupplementWithOptions(DenySupplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DenySupplement",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DenySupplementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DenySupplementResponse> DenySupplementWithOptionsAsync(DenySupplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DenySupplement",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DenySupplementResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DenySupplementResponse DenySupplement(DenySupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DenySupplementWithOptions(request, runtime);
        }

        public async Task<DenySupplementResponse> DenySupplementAsync(DenySupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DenySupplementWithOptionsAsync(request, runtime);
        }

        public DescirbeCombineTrademarkResponse DescirbeCombineTrademarkWithOptions(DescirbeCombineTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccurateMatch))
            {
                query["AccurateMatch"] = request.AccurateMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                query["Products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationNumber))
            {
                query["RegistrationNumber"] = request.RegistrationNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarGroups))
            {
                query["SimilarGroups"] = request.SimilarGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeCombineTrademark",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeCombineTrademarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescirbeCombineTrademarkResponse> DescirbeCombineTrademarkWithOptionsAsync(DescirbeCombineTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccurateMatch))
            {
                query["AccurateMatch"] = request.AccurateMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                query["Products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationNumber))
            {
                query["RegistrationNumber"] = request.RegistrationNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarGroups))
            {
                query["SimilarGroups"] = request.SimilarGroups;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeCombineTrademark",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeCombineTrademarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescirbeCombineTrademarkResponse DescirbeCombineTrademark(DescirbeCombineTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescirbeCombineTrademarkWithOptions(request, runtime);
        }

        public async Task<DescirbeCombineTrademarkResponse> DescirbeCombineTrademarkAsync(DescirbeCombineTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescirbeCombineTrademarkWithOptionsAsync(request, runtime);
        }

        public FillLogisticsResponse FillLogisticsWithOptions(FillLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logistics))
            {
                query["Logistics"] = request.Logistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FillLogistics",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FillLogisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FillLogisticsResponse> FillLogisticsWithOptionsAsync(FillLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logistics))
            {
                query["Logistics"] = request.Logistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FillLogistics",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FillLogisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FillLogisticsResponse FillLogistics(FillLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FillLogisticsWithOptions(request, runtime);
        }

        public async Task<FillLogisticsResponse> FillLogisticsAsync(FillLogisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FillLogisticsWithOptionsAsync(request, runtime);
        }

        public FilterUnavailableCodesResponse FilterUnavailableCodesWithOptions(FilterUnavailableCodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FilterUnavailableCodesShrinkRequest request = new FilterUnavailableCodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Codes))
            {
                request.CodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Codes, "Codes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodesShrink))
            {
                query["Codes"] = request.CodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FilterUnavailableCodes",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FilterUnavailableCodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FilterUnavailableCodesResponse> FilterUnavailableCodesWithOptionsAsync(FilterUnavailableCodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FilterUnavailableCodesShrinkRequest request = new FilterUnavailableCodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Codes))
            {
                request.CodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Codes, "Codes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodesShrink))
            {
                query["Codes"] = request.CodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FilterUnavailableCodes",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FilterUnavailableCodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FilterUnavailableCodesResponse FilterUnavailableCodes(FilterUnavailableCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FilterUnavailableCodesWithOptions(request, runtime);
        }

        public async Task<FilterUnavailableCodesResponse> FilterUnavailableCodesAsync(FilterUnavailableCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FilterUnavailableCodesWithOptionsAsync(request, runtime);
        }

        public ForceUploadTrademarkOnsaleResponse ForceUploadTrademarkOnsaleWithOptions(ForceUploadTrademarkOnsaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForceUploadTrademarkOnsale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceUploadTrademarkOnsaleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ForceUploadTrademarkOnsaleResponse> ForceUploadTrademarkOnsaleWithOptionsAsync(ForceUploadTrademarkOnsaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForceUploadTrademarkOnsale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceUploadTrademarkOnsaleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ForceUploadTrademarkOnsaleResponse ForceUploadTrademarkOnsale(ForceUploadTrademarkOnsaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForceUploadTrademarkOnsaleWithOptions(request, runtime);
        }

        public async Task<ForceUploadTrademarkOnsaleResponse> ForceUploadTrademarkOnsaleAsync(ForceUploadTrademarkOnsaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForceUploadTrademarkOnsaleWithOptionsAsync(request, runtime);
        }

        public GenerateQrCodeResponse GenerateQrCodeWithOptions(GenerateQrCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldKey))
            {
                query["FieldKey"] = request.FieldKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateQrCode",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateQrCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateQrCodeResponse> GenerateQrCodeWithOptionsAsync(GenerateQrCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldKey))
            {
                query["FieldKey"] = request.FieldKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateQrCode",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateQrCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateQrCodeResponse GenerateQrCode(GenerateQrCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateQrCodeWithOptions(request, runtime);
        }

        public async Task<GenerateQrCodeResponse> GenerateQrCodeAsync(GenerateQrCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateQrCodeWithOptionsAsync(request, runtime);
        }

        public GenerateUploadFilePolicyResponse GenerateUploadFilePolicyWithOptions(GenerateUploadFilePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadFilePolicy",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateUploadFilePolicyResponse> GenerateUploadFilePolicyWithOptionsAsync(GenerateUploadFilePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadFilePolicy",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateUploadFilePolicyResponse GenerateUploadFilePolicy(GenerateUploadFilePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadFilePolicyWithOptions(request, runtime);
        }

        public async Task<GenerateUploadFilePolicyResponse> GenerateUploadFilePolicyAsync(GenerateUploadFilePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadFilePolicyWithOptionsAsync(request, runtime);
        }

        public GetAuthorizationLetterVersionResponse GetAuthorizationLetterVersionWithOptions(GetAuthorizationLetterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationLetterVersion",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationLetterVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAuthorizationLetterVersionResponse> GetAuthorizationLetterVersionWithOptionsAsync(GetAuthorizationLetterVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationLetterVersion",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationLetterVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAuthorizationLetterVersionResponse GetAuthorizationLetterVersion(GetAuthorizationLetterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthorizationLetterVersionWithOptions(request, runtime);
        }

        public async Task<GetAuthorizationLetterVersionResponse> GetAuthorizationLetterVersionAsync(GetAuthorizationLetterVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthorizationLetterVersionWithOptionsAsync(request, runtime);
        }

        public GetDefaultPrincipalResponse GetDefaultPrincipalWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultPrincipal",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultPrincipalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDefaultPrincipalResponse> GetDefaultPrincipalWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultPrincipal",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultPrincipalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDefaultPrincipalResponse GetDefaultPrincipal()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultPrincipalWithOptions(runtime);
        }

        public async Task<GetDefaultPrincipalResponse> GetDefaultPrincipalAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultPrincipalWithOptionsAsync(runtime);
        }

        public GetDefaultPrincipalNameResponse GetDefaultPrincipalNameWithOptions(GetDefaultPrincipalNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultPrincipalName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultPrincipalNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDefaultPrincipalNameResponse> GetDefaultPrincipalNameWithOptionsAsync(GetDefaultPrincipalNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultPrincipalName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultPrincipalNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDefaultPrincipalNameResponse GetDefaultPrincipalName(GetDefaultPrincipalNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultPrincipalNameWithOptions(request, runtime);
        }

        public async Task<GetDefaultPrincipalNameResponse> GetDefaultPrincipalNameAsync(GetDefaultPrincipalNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultPrincipalNameWithOptionsAsync(request, runtime);
        }

        public GetNotaryOrderResponse GetNotaryOrderWithOptions(GetNotaryOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryOrderId))
            {
                query["NotaryOrderId"] = request.NotaryOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotaryOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotaryOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNotaryOrderResponse> GetNotaryOrderWithOptionsAsync(GetNotaryOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryOrderId))
            {
                query["NotaryOrderId"] = request.NotaryOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotaryOrder",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotaryOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNotaryOrderResponse GetNotaryOrder(GetNotaryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNotaryOrderWithOptions(request, runtime);
        }

        public async Task<GetNotaryOrderResponse> GetNotaryOrderAsync(GetNotaryOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNotaryOrderWithOptionsAsync(request, runtime);
        }

        public GetSupportPrincipalNameResponse GetSupportPrincipalNameWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSupportPrincipalName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupportPrincipalNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSupportPrincipalNameResponse> GetSupportPrincipalNameWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSupportPrincipalName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupportPrincipalNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSupportPrincipalNameResponse GetSupportPrincipalName()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSupportPrincipalNameWithOptions(runtime);
        }

        public async Task<GetSupportPrincipalNameResponse> GetSupportPrincipalNameAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSupportPrincipalNameWithOptionsAsync(runtime);
        }

        public InsertMaterialResponse InsertMaterialWithOptions(InsertMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertMaterialResponse> InsertMaterialWithOptionsAsync(InsertMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertMaterialResponse InsertMaterial(InsertMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertMaterialWithOptions(request, runtime);
        }

        public async Task<InsertMaterialResponse> InsertMaterialAsync(InsertMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertMaterialWithOptionsAsync(request, runtime);
        }

        public InsertRenewInfoResponse InsertRenewInfoWithOptions(InsertRenewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngAddress))
            {
                query["EngAddress"] = request.EngAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngName))
            {
                query["EngName"] = request.EngName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterTime))
            {
                query["RegisterTime"] = request.RegisterTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRenewInfo",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRenewInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertRenewInfoResponse> InsertRenewInfoWithOptionsAsync(InsertRenewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngAddress))
            {
                query["EngAddress"] = request.EngAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngName))
            {
                query["EngName"] = request.EngName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterTime))
            {
                query["RegisterTime"] = request.RegisterTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRenewInfo",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRenewInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertRenewInfoResponse InsertRenewInfo(InsertRenewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertRenewInfoWithOptions(request, runtime);
        }

        public async Task<InsertRenewInfoResponse> InsertRenewInfoAsync(InsertRenewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertRenewInfoWithOptionsAsync(request, runtime);
        }

        public InsertTmMonitorRuleResponse InsertTmMonitorRuleWithOptions(InsertTmMonitorRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertTmMonitorRuleShrinkRequest request = new InsertTmMonitorRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Classification))
            {
                request.ClassificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Classification, "Classification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyStatus))
            {
                request.NotifyStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyStatus, "NotifyStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationShrink))
            {
                query["Classification"] = request.ClassificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndApplyDate))
            {
                query["EndApplyDate"] = request.EndApplyDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStatusShrink))
            {
                query["NotifyStatus"] = request.NotifyStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleKeyword))
            {
                query["RuleKeyword"] = request.RuleKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleSource))
            {
                query["RuleSource"] = request.RuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartApplyDate))
            {
                query["StartApplyDate"] = request.StartApplyDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertTmMonitorRule",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertTmMonitorRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertTmMonitorRuleResponse> InsertTmMonitorRuleWithOptionsAsync(InsertTmMonitorRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertTmMonitorRuleShrinkRequest request = new InsertTmMonitorRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Classification))
            {
                request.ClassificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Classification, "Classification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotifyStatus))
            {
                request.NotifyStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotifyStatus, "NotifyStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationShrink))
            {
                query["Classification"] = request.ClassificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndApplyDate))
            {
                query["EndApplyDate"] = request.EndApplyDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStatusShrink))
            {
                query["NotifyStatus"] = request.NotifyStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleKeyword))
            {
                query["RuleKeyword"] = request.RuleKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleSource))
            {
                query["RuleSource"] = request.RuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartApplyDate))
            {
                query["StartApplyDate"] = request.StartApplyDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertTmMonitorRule",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertTmMonitorRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertTmMonitorRuleResponse InsertTmMonitorRule(InsertTmMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertTmMonitorRuleWithOptions(request, runtime);
        }

        public async Task<InsertTmMonitorRuleResponse> InsertTmMonitorRuleAsync(InsertTmMonitorRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertTmMonitorRuleWithOptionsAsync(request, runtime);
        }

        public ListNotaryInfosResponse ListNotaryInfosWithOptions(ListNotaryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizOrderNo))
            {
                query["BizOrderNo"] = request.BizOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryType))
            {
                query["NotaryType"] = request.NotaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNotaryInfos",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNotaryInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListNotaryInfosResponse> ListNotaryInfosWithOptionsAsync(ListNotaryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizOrderNo))
            {
                query["BizOrderNo"] = request.BizOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryType))
            {
                query["NotaryType"] = request.NotaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNotaryInfos",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNotaryInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListNotaryInfosResponse ListNotaryInfos(ListNotaryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNotaryInfosWithOptions(request, runtime);
        }

        public async Task<ListNotaryInfosResponse> ListNotaryInfosAsync(ListNotaryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNotaryInfosWithOptionsAsync(request, runtime);
        }

        public ListNotaryOrdersResponse ListNotaryOrdersWithOptions(ListNotaryOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunOrderId))
            {
                query["AliyunOrderId"] = request.AliyunOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOrderDate))
            {
                query["EndOrderDate"] = request.EndOrderDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryStatus))
            {
                query["NotaryStatus"] = request.NotaryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryType))
            {
                query["NotaryType"] = request.NotaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByType))
            {
                query["SortByType"] = request.SortByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKeyType))
            {
                query["SortKeyType"] = request.SortKeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOrderDate))
            {
                query["StartOrderDate"] = request.StartOrderDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNotaryOrders",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNotaryOrdersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListNotaryOrdersResponse> ListNotaryOrdersWithOptionsAsync(ListNotaryOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunOrderId))
            {
                query["AliyunOrderId"] = request.AliyunOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOrderDate))
            {
                query["EndOrderDate"] = request.EndOrderDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryStatus))
            {
                query["NotaryStatus"] = request.NotaryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryType))
            {
                query["NotaryType"] = request.NotaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByType))
            {
                query["SortByType"] = request.SortByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKeyType))
            {
                query["SortKeyType"] = request.SortKeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOrderDate))
            {
                query["StartOrderDate"] = request.StartOrderDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNotaryOrders",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNotaryOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListNotaryOrdersResponse ListNotaryOrders(ListNotaryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNotaryOrdersWithOptions(request, runtime);
        }

        public async Task<ListNotaryOrdersResponse> ListNotaryOrdersAsync(ListNotaryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNotaryOrdersWithOptionsAsync(request, runtime);
        }

        public ListTrademarkSbjKeyResponse ListTrademarkSbjKeyWithOptions(ListTrademarkSbjKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkSbjKey",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkSbjKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTrademarkSbjKeyResponse> ListTrademarkSbjKeyWithOptionsAsync(ListTrademarkSbjKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrademarkSbjKey",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrademarkSbjKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTrademarkSbjKeyResponse ListTrademarkSbjKey(ListTrademarkSbjKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrademarkSbjKeyWithOptions(request, runtime);
        }

        public async Task<ListTrademarkSbjKeyResponse> ListTrademarkSbjKeyAsync(ListTrademarkSbjKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrademarkSbjKeyWithOptionsAsync(request, runtime);
        }

        public ModifySubmitTransferMaterailResponse ModifySubmitTransferMaterailWithOptions(ModifySubmitTransferMaterailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySubmitTransferMaterailShrinkRequest request = new ModifySubmitTransferMaterailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Other))
            {
                request.OtherShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Other, "Other", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssigneeProxy))
            {
                query["AssigneeProxy"] = request.AssigneeProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerBusinessLicenseTranslation))
            {
                query["BuyerBusinessLicenseTranslation"] = request.BuyerBusinessLicenseTranslation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerBusinessLicenseTranslation))
            {
                query["SellerBusinessLicenseTranslation"] = request.SellerBusinessLicenseTranslation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeMaterialFullUpdate))
            {
                query["TradeMaterialFullUpdate"] = request.TradeMaterialFullUpdate;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                body["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerBusinessLicense))
            {
                body["BuyerBusinessLicense"] = request.BuyerBusinessLicense;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerIdCard))
            {
                body["BuyerIdCard"] = request.BuyerIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNo))
            {
                body["CardNo"] = request.CardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["CardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Complete))
            {
                body["Complete"] = request.Complete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                body["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMobile))
            {
                body["ContactMobile"] = request.ContactMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notarization))
            {
                body["Notarization"] = request.Notarization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherShrink))
            {
                body["Other"] = request.OtherShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationCert))
            {
                body["RegistrationCert"] = request.RegistrationCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerApply))
            {
                body["SellerApply"] = request.SellerApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerBusinessLicense))
            {
                body["SellerBusinessLicense"] = request.SellerBusinessLicense;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerIdCard))
            {
                body["SellerIdCard"] = request.SellerIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerProxy))
            {
                body["SellerProxy"] = request.SellerProxy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySubmitTransferMaterail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubmitTransferMaterailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySubmitTransferMaterailResponse> ModifySubmitTransferMaterailWithOptionsAsync(ModifySubmitTransferMaterailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySubmitTransferMaterailShrinkRequest request = new ModifySubmitTransferMaterailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Other))
            {
                request.OtherShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Other, "Other", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssigneeProxy))
            {
                query["AssigneeProxy"] = request.AssigneeProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerBusinessLicenseTranslation))
            {
                query["BuyerBusinessLicenseTranslation"] = request.BuyerBusinessLicenseTranslation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerBusinessLicenseTranslation))
            {
                query["SellerBusinessLicenseTranslation"] = request.SellerBusinessLicenseTranslation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeMaterialFullUpdate))
            {
                query["TradeMaterialFullUpdate"] = request.TradeMaterialFullUpdate;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                body["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerBusinessLicense))
            {
                body["BuyerBusinessLicense"] = request.BuyerBusinessLicense;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerIdCard))
            {
                body["BuyerIdCard"] = request.BuyerIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNo))
            {
                body["CardNo"] = request.CardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["CardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Complete))
            {
                body["Complete"] = request.Complete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                body["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMobile))
            {
                body["ContactMobile"] = request.ContactMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notarization))
            {
                body["Notarization"] = request.Notarization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherShrink))
            {
                body["Other"] = request.OtherShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationCert))
            {
                body["RegistrationCert"] = request.RegistrationCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerApply))
            {
                body["SellerApply"] = request.SellerApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerBusinessLicense))
            {
                body["SellerBusinessLicense"] = request.SellerBusinessLicense;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerIdCard))
            {
                body["SellerIdCard"] = request.SellerIdCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerProxy))
            {
                body["SellerProxy"] = request.SellerProxy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySubmitTransferMaterail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubmitTransferMaterailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySubmitTransferMaterailResponse ModifySubmitTransferMaterail(ModifySubmitTransferMaterailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySubmitTransferMaterailWithOptions(request, runtime);
        }

        public async Task<ModifySubmitTransferMaterailResponse> ModifySubmitTransferMaterailAsync(ModifySubmitTransferMaterailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySubmitTransferMaterailWithOptionsAsync(request, runtime);
        }

        public OperateProduceResponse OperateProduceWithOptions(OperateProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtMap))
            {
                query["ExtMap"] = request.ExtMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateProduceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OperateProduceResponse> OperateProduceWithOptionsAsync(OperateProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtMap))
            {
                query["ExtMap"] = request.ExtMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateProduceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OperateProduceResponse OperateProduce(OperateProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateProduceWithOptions(request, runtime);
        }

        public async Task<OperateProduceResponse> OperateProduceAsync(OperateProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateProduceWithOptionsAsync(request, runtime);
        }

        public PartnerUpdateTrademarkNameResponse PartnerUpdateTrademarkNameWithOptions(PartnerUpdateTrademarkNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                query["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                body["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                body["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                body["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                body["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                body["TmName"] = request.TmName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PartnerUpdateTrademarkName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PartnerUpdateTrademarkNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PartnerUpdateTrademarkNameResponse> PartnerUpdateTrademarkNameWithOptionsAsync(PartnerUpdateTrademarkNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                query["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                query["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSceneType))
            {
                body["EventSceneType"] = request.EventSceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                body["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                body["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                body["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                body["TmName"] = request.TmName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PartnerUpdateTrademarkName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PartnerUpdateTrademarkNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PartnerUpdateTrademarkNameResponse PartnerUpdateTrademarkName(PartnerUpdateTrademarkNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PartnerUpdateTrademarkNameWithOptions(request, runtime);
        }

        public async Task<PartnerUpdateTrademarkNameResponse> PartnerUpdateTrademarkNameAsync(PartnerUpdateTrademarkNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PartnerUpdateTrademarkNameWithOptionsAsync(request, runtime);
        }

        public QueryCommunicationLogsResponse QueryCommunicationLogsWithOptions(QueryCommunicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCommunicationLogs",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCommunicationLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryCommunicationLogsResponse> QueryCommunicationLogsWithOptionsAsync(QueryCommunicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCommunicationLogs",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCommunicationLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryCommunicationLogsResponse QueryCommunicationLogs(QueryCommunicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCommunicationLogsWithOptions(request, runtime);
        }

        public async Task<QueryCommunicationLogsResponse> QueryCommunicationLogsAsync(QueryCommunicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCommunicationLogsWithOptionsAsync(request, runtime);
        }

        public QueryCredentialsInfoResponse QueryCredentialsInfoWithOptions(QueryCredentialsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                body["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCredentialsInfo",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCredentialsInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryCredentialsInfoResponse> QueryCredentialsInfoWithOptionsAsync(QueryCredentialsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                body["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCredentialsInfo",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCredentialsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryCredentialsInfoResponse QueryCredentialsInfo(QueryCredentialsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCredentialsInfoWithOptions(request, runtime);
        }

        public async Task<QueryCredentialsInfoResponse> QueryCredentialsInfoAsync(QueryCredentialsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCredentialsInfoWithOptionsAsync(request, runtime);
        }

        public QueryExtensionAttributeResponse QueryExtensionAttributeWithOptions(QueryExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeKey))
            {
                query["AttributeKey"] = request.AttributeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExtensionAttribute",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExtensionAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryExtensionAttributeResponse> QueryExtensionAttributeWithOptionsAsync(QueryExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeKey))
            {
                query["AttributeKey"] = request.AttributeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExtensionAttribute",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExtensionAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryExtensionAttributeResponse QueryExtensionAttribute(QueryExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExtensionAttributeWithOptions(request, runtime);
        }

        public async Task<QueryExtensionAttributeResponse> QueryExtensionAttributeAsync(QueryExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExtensionAttributeWithOptionsAsync(request, runtime);
        }

        public QueryIntentionDetailResponse QueryIntentionDetailWithOptions(QueryIntentionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryIntentionDetailResponse> QueryIntentionDetailWithOptionsAsync(QueryIntentionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryIntentionDetailResponse QueryIntentionDetail(QueryIntentionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIntentionDetailWithOptions(request, runtime);
        }

        public async Task<QueryIntentionDetailResponse> QueryIntentionDetailAsync(QueryIntentionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIntentionDetailWithOptionsAsync(request, runtime);
        }

        public QueryIntentionListResponse QueryIntentionListWithOptions(QueryIntentionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryIntentionListResponse> QueryIntentionListWithOptionsAsync(QueryIntentionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryIntentionListResponse QueryIntentionList(QueryIntentionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIntentionListWithOptions(request, runtime);
        }

        public async Task<QueryIntentionListResponse> QueryIntentionListAsync(QueryIntentionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIntentionListWithOptionsAsync(request, runtime);
        }

        public QueryIntentionOwnerResponse QueryIntentionOwnerWithOptions(QueryIntentionOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionOwner",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionOwnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryIntentionOwnerResponse> QueryIntentionOwnerWithOptionsAsync(QueryIntentionOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionOwner",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionOwnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryIntentionOwnerResponse QueryIntentionOwner(QueryIntentionOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIntentionOwnerWithOptions(request, runtime);
        }

        public async Task<QueryIntentionOwnerResponse> QueryIntentionOwnerAsync(QueryIntentionOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIntentionOwnerWithOptionsAsync(request, runtime);
        }

        public QueryIntentionPriceResponse QueryIntentionPriceWithOptions(QueryIntentionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionPrice",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryIntentionPriceResponse> QueryIntentionPriceWithOptionsAsync(QueryIntentionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntentionPrice",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntentionPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryIntentionPriceResponse QueryIntentionPrice(QueryIntentionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIntentionPriceWithOptions(request, runtime);
        }

        public async Task<QueryIntentionPriceResponse> QueryIntentionPriceAsync(QueryIntentionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIntentionPriceWithOptionsAsync(request, runtime);
        }

        public QueryMaterialResponse QueryMaterialWithOptions(QueryMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryUnconfirmedInfo))
            {
                query["QueryUnconfirmedInfo"] = request.QueryUnconfirmedInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMaterialResponse> QueryMaterialWithOptionsAsync(QueryMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryUnconfirmedInfo))
            {
                query["QueryUnconfirmedInfo"] = request.QueryUnconfirmedInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMaterialResponse QueryMaterial(QueryMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMaterialWithOptions(request, runtime);
        }

        public async Task<QueryMaterialResponse> QueryMaterialAsync(QueryMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMaterialWithOptionsAsync(request, runtime);
        }

        public QueryMaterialListResponse QueryMaterialListWithOptions(QueryMaterialListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialVersion))
            {
                query["MaterialVersion"] = request.MaterialVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemVersion))
            {
                query["SystemVersion"] = request.SystemVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMaterialList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMaterialListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMaterialListResponse> QueryMaterialListWithOptionsAsync(QueryMaterialListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialId))
            {
                query["MaterialId"] = request.MaterialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialVersion))
            {
                query["MaterialVersion"] = request.MaterialVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemVersion))
            {
                query["SystemVersion"] = request.SystemVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMaterialList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMaterialListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMaterialListResponse QueryMaterialList(QueryMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMaterialListWithOptions(request, runtime);
        }

        public async Task<QueryMaterialListResponse> QueryMaterialListAsync(QueryMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMaterialListWithOptionsAsync(request, runtime);
        }

        public QueryMonitorKeywordsResponse QueryMonitorKeywordsWithOptions(QueryMonitorKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMonitorKeywords",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMonitorKeywordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMonitorKeywordsResponse> QueryMonitorKeywordsWithOptionsAsync(QueryMonitorKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMonitorKeywords",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMonitorKeywordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMonitorKeywordsResponse QueryMonitorKeywords(QueryMonitorKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMonitorKeywordsWithOptions(request, runtime);
        }

        public async Task<QueryMonitorKeywordsResponse> QueryMonitorKeywordsAsync(QueryMonitorKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMonitorKeywordsWithOptionsAsync(request, runtime);
        }

        public QueryOfficialFileCustomListResponse QueryOfficialFileCustomListWithOptions(QueryOfficialFileCustomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryOfficialFileCustomList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialFileCustomListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOfficialFileCustomListResponse> QueryOfficialFileCustomListWithOptionsAsync(QueryOfficialFileCustomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryOfficialFileCustomList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOfficialFileCustomListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOfficialFileCustomListResponse QueryOfficialFileCustomList(QueryOfficialFileCustomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOfficialFileCustomListWithOptions(request, runtime);
        }

        public async Task<QueryOfficialFileCustomListResponse> QueryOfficialFileCustomListAsync(QueryOfficialFileCustomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOfficialFileCustomListWithOptionsAsync(request, runtime);
        }

        public QueryOrderLogisticsListResponse QueryOrderLogisticsListWithOptions(QueryOrderLogisticsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceOrderId))
            {
                body["ProduceOrderId"] = request.ProduceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                body["RegisterNumber"] = request.RegisterNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderLogisticsList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderLogisticsListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderLogisticsListResponse> QueryOrderLogisticsListWithOptionsAsync(QueryOrderLogisticsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceOrderId))
            {
                body["ProduceOrderId"] = request.ProduceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                body["RegisterNumber"] = request.RegisterNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderLogisticsList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderLogisticsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrderLogisticsListResponse QueryOrderLogisticsList(QueryOrderLogisticsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderLogisticsListWithOptions(request, runtime);
        }

        public async Task<QueryOrderLogisticsListResponse> QueryOrderLogisticsListAsync(QueryOrderLogisticsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderLogisticsListWithOptionsAsync(request, runtime);
        }

        public QueryOssResourcesResponse QueryOssResourcesWithOptions(QueryOssResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOssResources",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOssResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOssResourcesResponse> QueryOssResourcesWithOptionsAsync(QueryOssResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOssResources",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOssResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOssResourcesResponse QueryOssResources(QueryOssResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOssResourcesWithOptions(request, runtime);
        }

        public async Task<QueryOssResourcesResponse> QueryOssResourcesAsync(QueryOssResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOssResourcesWithOptionsAsync(request, runtime);
        }

        public QueryProduceDetailResponse QueryProduceDetailWithOptions(QueryProduceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNo))
            {
                query["ApplyNo"] = request.ApplyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProduceDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProduceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryProduceDetailResponse> QueryProduceDetailWithOptionsAsync(QueryProduceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNo))
            {
                query["ApplyNo"] = request.ApplyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProduceDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProduceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryProduceDetailResponse QueryProduceDetail(QueryProduceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProduceDetailWithOptions(request, runtime);
        }

        public async Task<QueryProduceDetailResponse> QueryProduceDetailAsync(QueryProduceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProduceDetailWithOptionsAsync(request, runtime);
        }

        public QueryProduceListResponse QueryProduceListWithOptions(QueryProduceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeLeft))
            {
                query["CreateTimeLeft"] = request.CreateTimeLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRight))
            {
                query["CreateTimeRight"] = request.CreateTimeRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProduceList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProduceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryProduceListResponse> QueryProduceListWithOptionsAsync(QueryProduceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeLeft))
            {
                query["CreateTimeLeft"] = request.CreateTimeLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRight))
            {
                query["CreateTimeRight"] = request.CreateTimeRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProduceList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProduceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryProduceListResponse QueryProduceList(QueryProduceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProduceListWithOptions(request, runtime);
        }

        public async Task<QueryProduceListResponse> QueryProduceListAsync(QueryProduceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProduceListWithOptionsAsync(request, runtime);
        }

        public QueryQrCodeUploadStatusResponse QueryQrCodeUploadStatusWithOptions(QueryQrCodeUploadStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldKey))
            {
                query["FieldKey"] = request.FieldKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryQrCodeUploadStatus",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryQrCodeUploadStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryQrCodeUploadStatusResponse> QueryQrCodeUploadStatusWithOptionsAsync(QueryQrCodeUploadStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldKey))
            {
                query["FieldKey"] = request.FieldKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryQrCodeUploadStatus",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryQrCodeUploadStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryQrCodeUploadStatusResponse QueryQrCodeUploadStatus(QueryQrCodeUploadStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryQrCodeUploadStatusWithOptions(request, runtime);
        }

        public async Task<QueryQrCodeUploadStatusResponse> QueryQrCodeUploadStatusAsync(QueryQrCodeUploadStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryQrCodeUploadStatusWithOptionsAsync(request, runtime);
        }

        public QuerySbjRuleResponse QuerySbjRuleWithOptions(QuerySbjRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySbjRule",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySbjRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySbjRuleResponse> QuerySbjRuleWithOptionsAsync(QuerySbjRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySbjRule",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySbjRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySbjRuleResponse QuerySbjRule(QuerySbjRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySbjRuleWithOptions(request, runtime);
        }

        public async Task<QuerySbjRuleResponse> QuerySbjRuleAsync(QuerySbjRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySbjRuleWithOptionsAsync(request, runtime);
        }

        public QuerySupplementDetailResponse QuerySupplementDetailWithOptions(QuerySupplementDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySupplementDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupplementDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySupplementDetailResponse> QuerySupplementDetailWithOptionsAsync(QuerySupplementDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySupplementDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupplementDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySupplementDetailResponse QuerySupplementDetail(QuerySupplementDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySupplementDetailWithOptions(request, runtime);
        }

        public async Task<QuerySupplementDetailResponse> QuerySupplementDetailAsync(QuerySupplementDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySupplementDetailWithOptionsAsync(request, runtime);
        }

        public QueryTaskListResponse QueryTaskListWithOptions(QueryTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryTaskList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskListResponse> QueryTaskListWithOptionsAsync(QueryTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryTaskList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskListResponse QueryTaskList(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskListWithOptions(request, runtime);
        }

        public async Task<QueryTaskListResponse> QueryTaskListAsync(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskListWithOptionsAsync(request, runtime);
        }

        public QueryTmCollectionPageListResponse QueryTmCollectionPageListWithOptions(QueryTmCollectionPageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryTmCollectionPageList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTmCollectionPageListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTmCollectionPageListResponse> QueryTmCollectionPageListWithOptionsAsync(QueryTmCollectionPageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "QueryTmCollectionPageList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTmCollectionPageListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTmCollectionPageListResponse QueryTmCollectionPageList(QueryTmCollectionPageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTmCollectionPageListWithOptions(request, runtime);
        }

        public async Task<QueryTmCollectionPageListResponse> QueryTmCollectionPageListAsync(QueryTmCollectionPageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTmCollectionPageListWithOptionsAsync(request, runtime);
        }

        public QueryTmSbjProduceResponse QueryTmSbjProduceWithOptions(QueryTmSbjProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityBizTypeStr))
            {
                query["HighPriorityBizTypeStr"] = request.HighPriorityBizTypeStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityMaterialNameStr))
            {
                query["HighPriorityMaterialNameStr"] = request.HighPriorityMaterialNameStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityOrderIdStr))
            {
                query["HighPriorityOrderIdStr"] = request.HighPriorityOrderIdStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityUserIdStr))
            {
                query["HighPriorityUserIdStr"] = request.HighPriorityUserIdStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProducerType))
            {
                query["ProducerType"] = request.ProducerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryOrderPageSize))
            {
                query["QueryOrderPageSize"] = request.QueryOrderPageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTmSbjProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTmSbjProduceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTmSbjProduceResponse> QueryTmSbjProduceWithOptionsAsync(QueryTmSbjProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityBizTypeStr))
            {
                query["HighPriorityBizTypeStr"] = request.HighPriorityBizTypeStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityMaterialNameStr))
            {
                query["HighPriorityMaterialNameStr"] = request.HighPriorityMaterialNameStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityOrderIdStr))
            {
                query["HighPriorityOrderIdStr"] = request.HighPriorityOrderIdStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighPriorityUserIdStr))
            {
                query["HighPriorityUserIdStr"] = request.HighPriorityUserIdStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProducerType))
            {
                query["ProducerType"] = request.ProducerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryOrderPageSize))
            {
                query["QueryOrderPageSize"] = request.QueryOrderPageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTmSbjProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTmSbjProduceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTmSbjProduceResponse QueryTmSbjProduce(QueryTmSbjProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTmSbjProduceWithOptions(request, runtime);
        }

        public async Task<QueryTmSbjProduceResponse> QueryTmSbjProduceAsync(QueryTmSbjProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTmSbjProduceWithOptionsAsync(request, runtime);
        }

        public QueryTmSbjProduceDetailResponse QueryTmSbjProduceDetailWithOptions(QueryTmSbjProduceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTmSbjProduceDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTmSbjProduceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTmSbjProduceDetailResponse> QueryTmSbjProduceDetailWithOptionsAsync(QueryTmSbjProduceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTmSbjProduceDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTmSbjProduceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTmSbjProduceDetailResponse QueryTmSbjProduceDetail(QueryTmSbjProduceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTmSbjProduceDetailWithOptions(request, runtime);
        }

        public async Task<QueryTmSbjProduceDetailResponse> QueryTmSbjProduceDetailAsync(QueryTmSbjProduceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTmSbjProduceDetailWithOptionsAsync(request, runtime);
        }

        public QueryTradeIntentionUserListResponse QueryTradeIntentionUserListWithOptions(QueryTradeIntentionUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Begin))
            {
                query["Begin"] = request.Begin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeIntentionUserList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeIntentionUserListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTradeIntentionUserListResponse> QueryTradeIntentionUserListWithOptionsAsync(QueryTradeIntentionUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Begin))
            {
                query["Begin"] = request.Begin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeIntentionUserList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeIntentionUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTradeIntentionUserListResponse QueryTradeIntentionUserList(QueryTradeIntentionUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTradeIntentionUserListWithOptions(request, runtime);
        }

        public async Task<QueryTradeIntentionUserListResponse> QueryTradeIntentionUserListAsync(QueryTradeIntentionUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTradeIntentionUserListWithOptionsAsync(request, runtime);
        }

        public QueryTradeMarkApplicationDetailResponse QueryTradeMarkApplicationDetailWithOptions(QueryTradeMarkApplicationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplicationDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTradeMarkApplicationDetailResponse> QueryTradeMarkApplicationDetailWithOptionsAsync(QueryTradeMarkApplicationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplicationDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTradeMarkApplicationDetailResponse QueryTradeMarkApplicationDetail(QueryTradeMarkApplicationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTradeMarkApplicationDetailWithOptions(request, runtime);
        }

        public async Task<QueryTradeMarkApplicationDetailResponse> QueryTradeMarkApplicationDetailAsync(QueryTradeMarkApplicationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTradeMarkApplicationDetailWithOptionsAsync(request, runtime);
        }

        public QueryTradeMarkApplicationLogsResponse QueryTradeMarkApplicationLogsWithOptions(QueryTradeMarkApplicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplicationLogs",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTradeMarkApplicationLogsResponse> QueryTradeMarkApplicationLogsWithOptionsAsync(QueryTradeMarkApplicationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplicationLogs",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTradeMarkApplicationLogsResponse QueryTradeMarkApplicationLogs(QueryTradeMarkApplicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTradeMarkApplicationLogsWithOptions(request, runtime);
        }

        public async Task<QueryTradeMarkApplicationLogsResponse> QueryTradeMarkApplicationLogsAsync(QueryTradeMarkApplicationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTradeMarkApplicationLogsWithOptionsAsync(request, runtime);
        }

        public QueryTradeMarkApplicationsResponse QueryTradeMarkApplicationsWithOptions(QueryTradeMarkApplicationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTradeMarkApplicationsShrinkRequest request = new QueryTradeMarkApplicationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "StatusList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                query["Hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                query["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["StatusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementStatus))
            {
                query["SupplementStatus"] = request.SupplementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplications",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTradeMarkApplicationsResponse> QueryTradeMarkApplicationsWithOptionsAsync(QueryTradeMarkApplicationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTradeMarkApplicationsShrinkRequest request = new QueryTradeMarkApplicationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "StatusList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidden))
            {
                query["Hidden"] = request.Hidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                query["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialName))
            {
                query["MaterialName"] = request.MaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["StatusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementStatus))
            {
                query["SupplementStatus"] = request.SupplementStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplications",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTradeMarkApplicationsResponse QueryTradeMarkApplications(QueryTradeMarkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTradeMarkApplicationsWithOptions(request, runtime);
        }

        public async Task<QueryTradeMarkApplicationsResponse> QueryTradeMarkApplicationsAsync(QueryTradeMarkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTradeMarkApplicationsWithOptionsAsync(request, runtime);
        }

        public QueryTradeMarkApplicationsByIntentionResponse QueryTradeMarkApplicationsByIntentionWithOptions(QueryTradeMarkApplicationsByIntentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceStatus))
            {
                query["TmProduceStatus"] = request.TmProduceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplicationsByIntention",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationsByIntentionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTradeMarkApplicationsByIntentionResponse> QueryTradeMarkApplicationsByIntentionWithOptionsAsync(QueryTradeMarkApplicationsByIntentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmProduceStatus))
            {
                query["TmProduceStatus"] = request.TmProduceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeMarkApplicationsByIntention",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeMarkApplicationsByIntentionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTradeMarkApplicationsByIntentionResponse QueryTradeMarkApplicationsByIntention(QueryTradeMarkApplicationsByIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTradeMarkApplicationsByIntentionWithOptions(request, runtime);
        }

        public async Task<QueryTradeMarkApplicationsByIntentionResponse> QueryTradeMarkApplicationsByIntentionAsync(QueryTradeMarkApplicationsByIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTradeMarkApplicationsByIntentionWithOptionsAsync(request, runtime);
        }

        public QueryTradeProduceDetailResponse QueryTradeProduceDetailWithOptions(QueryTradeProduceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeProduceDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeProduceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTradeProduceDetailResponse> QueryTradeProduceDetailWithOptionsAsync(QueryTradeProduceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeProduceDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeProduceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTradeProduceDetailResponse QueryTradeProduceDetail(QueryTradeProduceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTradeProduceDetailWithOptions(request, runtime);
        }

        public async Task<QueryTradeProduceDetailResponse> QueryTradeProduceDetailAsync(QueryTradeProduceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTradeProduceDetailWithOptionsAsync(request, runtime);
        }

        public QueryTradeProduceListResponse QueryTradeProduceListWithOptions(QueryTradeProduceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerStatus))
            {
                query["BuyerStatus"] = request.BuyerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOrderId))
            {
                query["PreOrderId"] = request.PreOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeProduceList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeProduceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTradeProduceListResponse> QueryTradeProduceListWithOptionsAsync(QueryTradeProduceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerStatus))
            {
                query["BuyerStatus"] = request.BuyerStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOrderId))
            {
                query["PreOrderId"] = request.PreOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTradeProduceList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeProduceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTradeProduceListResponse QueryTradeProduceList(QueryTradeProduceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTradeProduceListWithOptions(request, runtime);
        }

        public async Task<QueryTradeProduceListResponse> QueryTradeProduceListAsync(QueryTradeProduceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTradeProduceListWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkDetailByApplyNumberResponse QueryTrademarkDetailByApplyNumberWithOptions(QueryTrademarkDetailByApplyNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNumber))
            {
                query["ApplyNumber"] = request.ApplyNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkDetailByApplyNumber",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkDetailByApplyNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkDetailByApplyNumberResponse> QueryTrademarkDetailByApplyNumberWithOptionsAsync(QueryTrademarkDetailByApplyNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNumber))
            {
                query["ApplyNumber"] = request.ApplyNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkDetailByApplyNumber",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkDetailByApplyNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkDetailByApplyNumberResponse QueryTrademarkDetailByApplyNumber(QueryTrademarkDetailByApplyNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkDetailByApplyNumberWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkDetailByApplyNumberResponse> QueryTrademarkDetailByApplyNumberAsync(QueryTrademarkDetailByApplyNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkDetailByApplyNumberWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkDetailByApplyNumberEspResponse QueryTrademarkDetailByApplyNumberEspWithOptions(QueryTrademarkDetailByApplyNumberEspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNumber))
            {
                query["ApplyNumber"] = request.ApplyNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkDetailByApplyNumberEsp",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkDetailByApplyNumberEspResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkDetailByApplyNumberEspResponse> QueryTrademarkDetailByApplyNumberEspWithOptionsAsync(QueryTrademarkDetailByApplyNumberEspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNumber))
            {
                query["ApplyNumber"] = request.ApplyNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkDetailByApplyNumberEsp",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkDetailByApplyNumberEspResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkDetailByApplyNumberEspResponse QueryTrademarkDetailByApplyNumberEsp(QueryTrademarkDetailByApplyNumberEspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkDetailByApplyNumberEspWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkDetailByApplyNumberEspResponse> QueryTrademarkDetailByApplyNumberEspAsync(QueryTrademarkDetailByApplyNumberEspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkDetailByApplyNumberEspWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkModelDetailResponse QueryTrademarkModelDetailWithOptions(QueryTrademarkModelDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewSupplementMaterial))
            {
                query["ReviewSupplementMaterial"] = request.ReviewSupplementMaterial;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkModelDetailResponse> QueryTrademarkModelDetailWithOptionsAsync(QueryTrademarkModelDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewSupplementMaterial))
            {
                query["ReviewSupplementMaterial"] = request.ReviewSupplementMaterial;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkModelDetailResponse QueryTrademarkModelDetail(QueryTrademarkModelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkModelDetailWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkModelDetailResponse> QueryTrademarkModelDetailAsync(QueryTrademarkModelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkModelDetailWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkModelEspDetailResponse QueryTrademarkModelEspDetailWithOptions(QueryTrademarkModelEspDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelEspDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelEspDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkModelEspDetailResponse> QueryTrademarkModelEspDetailWithOptionsAsync(QueryTrademarkModelEspDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelEspDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelEspDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkModelEspDetailResponse QueryTrademarkModelEspDetail(QueryTrademarkModelEspDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkModelEspDetailWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkModelEspDetailResponse> QueryTrademarkModelEspDetailAsync(QueryTrademarkModelEspDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkModelEspDetailWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkModelEspListResponse QueryTrademarkModelEspListWithOptions(QueryTrademarkModelEspListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTrademarkModelEspListShrinkRequest request = new QueryTrademarkModelEspListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExistStatus))
            {
                request.ExistStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExistStatus, "ExistStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalSubmitStatus))
            {
                query["AdditionalSubmitStatus"] = request.AdditionalSubmitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalSubmitTime))
            {
                query["AdditionalSubmitTime"] = request.AdditionalSubmitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistStatusShrink))
            {
                query["ExistStatus"] = request.ExistStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIdsStr))
            {
                query["OrderIdsStr"] = request.OrderIdsStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInstanceId))
            {
                query["OrderInstanceId"] = request.OrderInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitStatus))
            {
                query["SubmitStatus"] = request.SubmitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                query["SubmitTime"] = request.SubmitTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelEspList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelEspListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkModelEspListResponse> QueryTrademarkModelEspListWithOptionsAsync(QueryTrademarkModelEspListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTrademarkModelEspListShrinkRequest request = new QueryTrademarkModelEspListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExistStatus))
            {
                request.ExistStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExistStatus, "ExistStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalSubmitStatus))
            {
                query["AdditionalSubmitStatus"] = request.AdditionalSubmitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalSubmitTime))
            {
                query["AdditionalSubmitTime"] = request.AdditionalSubmitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistStatusShrink))
            {
                query["ExistStatus"] = request.ExistStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIdsStr))
            {
                query["OrderIdsStr"] = request.OrderIdsStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInstanceId))
            {
                query["OrderInstanceId"] = request.OrderInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitStatus))
            {
                query["SubmitStatus"] = request.SubmitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                query["SubmitTime"] = request.SubmitTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelEspList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelEspListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkModelEspListResponse QueryTrademarkModelEspList(QueryTrademarkModelEspListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkModelEspListWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkModelEspListResponse> QueryTrademarkModelEspListAsync(QueryTrademarkModelEspListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkModelEspListWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkModelListResponse QueryTrademarkModelListWithOptions(QueryTrademarkModelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIdsStr))
            {
                query["OrderIdsStr"] = request.OrderIdsStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceTypesStr))
            {
                query["ProduceTypesStr"] = request.ProduceTypesStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitStart))
            {
                query["SubmitStart"] = request.SubmitStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitStatus))
            {
                query["SubmitStatus"] = request.SubmitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                query["SubmitTime"] = request.SubmitTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkModelListResponse> QueryTrademarkModelListWithOptionsAsync(QueryTrademarkModelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIdsStr))
            {
                query["OrderIdsStr"] = request.OrderIdsStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceTypesStr))
            {
                query["ProduceTypesStr"] = request.ProduceTypesStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitStart))
            {
                query["SubmitStart"] = request.SubmitStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitStatus))
            {
                query["SubmitStatus"] = request.SubmitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                query["SubmitTime"] = request.SubmitTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkModelList",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkModelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkModelListResponse QueryTrademarkModelList(QueryTrademarkModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkModelListWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkModelListResponse> QueryTrademarkModelListAsync(QueryTrademarkModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkModelListWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkMonitorResultsResponse QueryTrademarkMonitorResultsWithOptions(QueryTrademarkMonitorResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyYear))
            {
                query["ApplyYear"] = request.ApplyYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedureStatus))
            {
                query["ProcedureStatus"] = request.ProcedureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationNumber))
            {
                query["RegistrationNumber"] = request.RegistrationNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkMonitorResults",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkMonitorResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkMonitorResultsResponse> QueryTrademarkMonitorResultsWithOptionsAsync(QueryTrademarkMonitorResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyYear))
            {
                query["ApplyYear"] = request.ApplyYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedureStatus))
            {
                query["ProcedureStatus"] = request.ProcedureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationNumber))
            {
                query["RegistrationNumber"] = request.RegistrationNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkMonitorResults",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkMonitorResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkMonitorResultsResponse QueryTrademarkMonitorResults(QueryTrademarkMonitorResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkMonitorResultsWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkMonitorResultsResponse> QueryTrademarkMonitorResultsAsync(QueryTrademarkMonitorResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkMonitorResultsWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkMonitorRulesResponse QueryTrademarkMonitorRulesWithOptions(QueryTrademarkMonitorRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUpdate))
            {
                query["NotifyUpdate"] = request.NotifyUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkMonitorRules",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkMonitorRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkMonitorRulesResponse> QueryTrademarkMonitorRulesWithOptionsAsync(QueryTrademarkMonitorRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUpdate))
            {
                query["NotifyUpdate"] = request.NotifyUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkMonitorRules",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkMonitorRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkMonitorRulesResponse QueryTrademarkMonitorRules(QueryTrademarkMonitorRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkMonitorRulesWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkMonitorRulesResponse> QueryTrademarkMonitorRulesAsync(QueryTrademarkMonitorRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkMonitorRulesWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkOnSaleResponse QueryTrademarkOnSaleWithOptions(QueryTrademarkOnSaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterCode))
            {
                query["RegisterCode"] = request.RegisterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkOnSale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkOnSaleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkOnSaleResponse> QueryTrademarkOnSaleWithOptionsAsync(QueryTrademarkOnSaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterCode))
            {
                query["RegisterCode"] = request.RegisterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkOnSale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkOnSaleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkOnSaleResponse QueryTrademarkOnSale(QueryTrademarkOnSaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkOnSaleWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkOnSaleResponse> QueryTrademarkOnSaleAsync(QueryTrademarkOnSaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkOnSaleWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkPriceResponse QueryTrademarkPriceWithOptions(QueryTrademarkPriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTrademarkPriceShrinkRequest request = new QueryTrademarkPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderData))
            {
                request.OrderDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderData, "OrderData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDataShrink))
            {
                query["OrderData"] = request.OrderDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkPrice",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkPriceResponse> QueryTrademarkPriceWithOptionsAsync(QueryTrademarkPriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTrademarkPriceShrinkRequest request = new QueryTrademarkPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderData))
            {
                request.OrderDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderData, "OrderData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDataShrink))
            {
                query["OrderData"] = request.OrderDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkPrice",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkPriceResponse QueryTrademarkPrice(QueryTrademarkPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkPriceWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkPriceResponse> QueryTrademarkPriceAsync(QueryTrademarkPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkPriceWithOptionsAsync(request, runtime);
        }

        public QueryTrademarkUploadAuditResultResponse QueryTrademarkUploadAuditResultWithOptions(QueryTrademarkUploadAuditResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterCode))
            {
                query["RegisterCode"] = request.RegisterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkUploadAuditResult",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkUploadAuditResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTrademarkUploadAuditResultResponse> QueryTrademarkUploadAuditResultWithOptionsAsync(QueryTrademarkUploadAuditResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterCode))
            {
                query["RegisterCode"] = request.RegisterCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTrademarkUploadAuditResult",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTrademarkUploadAuditResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTrademarkUploadAuditResultResponse QueryTrademarkUploadAuditResult(QueryTrademarkUploadAuditResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrademarkUploadAuditResultWithOptions(request, runtime);
        }

        public async Task<QueryTrademarkUploadAuditResultResponse> QueryTrademarkUploadAuditResultAsync(QueryTrademarkUploadAuditResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrademarkUploadAuditResultWithOptionsAsync(request, runtime);
        }

        public RecordBankBalanceResponse RecordBankBalanceWithOptions(RecordBankBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionDate))
            {
                query["ActionDate"] = request.ActionDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Balance))
            {
                query["Balance"] = request.Balance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordBankBalance",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordBankBalanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecordBankBalanceResponse> RecordBankBalanceWithOptionsAsync(RecordBankBalanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionDate))
            {
                query["ActionDate"] = request.ActionDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Balance))
            {
                query["Balance"] = request.Balance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordBankBalance",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordBankBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecordBankBalanceResponse RecordBankBalance(RecordBankBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordBankBalanceWithOptions(request, runtime);
        }

        public async Task<RecordBankBalanceResponse> RecordBankBalanceAsync(RecordBankBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordBankBalanceWithOptionsAsync(request, runtime);
        }

        public RefundProduceResponse RefundProduceWithOptions(RefundProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundType))
            {
                query["RefundType"] = request.RefundType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundProduceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefundProduceResponse> RefundProduceWithOptionsAsync(RefundProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundType))
            {
                query["RefundType"] = request.RefundType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundProduceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefundProduceResponse RefundProduce(RefundProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundProduceWithOptions(request, runtime);
        }

        public async Task<RefundProduceResponse> RefundProduceAsync(RefundProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundProduceWithOptionsAsync(request, runtime);
        }

        public RefuseAdditionalMaterialResponse RefuseAdditionalMaterialWithOptions(RefuseAdditionalMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseAdditionalMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseAdditionalMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefuseAdditionalMaterialResponse> RefuseAdditionalMaterialWithOptionsAsync(RefuseAdditionalMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseAdditionalMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseAdditionalMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefuseAdditionalMaterialResponse RefuseAdditionalMaterial(RefuseAdditionalMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefuseAdditionalMaterialWithOptions(request, runtime);
        }

        public async Task<RefuseAdditionalMaterialResponse> RefuseAdditionalMaterialAsync(RefuseAdditionalMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefuseAdditionalMaterialWithOptionsAsync(request, runtime);
        }

        public RefuseApplicantResponse RefuseApplicantWithOptions(RefuseApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefuseApplicantResponse> RefuseApplicantWithOptionsAsync(RefuseApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefuseApplicantResponse RefuseApplicant(RefuseApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefuseApplicantWithOptions(request, runtime);
        }

        public async Task<RefuseApplicantResponse> RefuseApplicantAsync(RefuseApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefuseApplicantWithOptionsAsync(request, runtime);
        }

        public RejectApplicantResponse RejectApplicantWithOptions(RejectApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectApplicantResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RejectApplicantResponse> RejectApplicantWithOptionsAsync(RejectApplicantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectApplicant",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectApplicantResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RejectApplicantResponse RejectApplicant(RejectApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectApplicantWithOptions(request, runtime);
        }

        public async Task<RejectApplicantResponse> RejectApplicantAsync(RejectApplicantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectApplicantWithOptionsAsync(request, runtime);
        }

        public SaveClassificationConditionsResponse SaveClassificationConditionsWithOptions(SaveClassificationConditionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveClassificationConditions",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveClassificationConditionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveClassificationConditionsResponse> SaveClassificationConditionsWithOptionsAsync(SaveClassificationConditionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                query["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveClassificationConditions",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveClassificationConditionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveClassificationConditionsResponse SaveClassificationConditions(SaveClassificationConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveClassificationConditionsWithOptions(request, runtime);
        }

        public async Task<SaveClassificationConditionsResponse> SaveClassificationConditionsAsync(SaveClassificationConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveClassificationConditionsWithOptionsAsync(request, runtime);
        }

        public SaveExtensionAttributeResponse SaveExtensionAttributeWithOptions(SaveExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeKey))
            {
                query["AttributeKey"] = request.AttributeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeValue))
            {
                query["AttributeValue"] = request.AttributeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveExtensionAttribute",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveExtensionAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveExtensionAttributeResponse> SaveExtensionAttributeWithOptionsAsync(SaveExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeKey))
            {
                query["AttributeKey"] = request.AttributeKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeValue))
            {
                query["AttributeValue"] = request.AttributeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveExtensionAttribute",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveExtensionAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveExtensionAttributeResponse SaveExtensionAttribute(SaveExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveExtensionAttributeWithOptions(request, runtime);
        }

        public async Task<SaveExtensionAttributeResponse> SaveExtensionAttributeAsync(SaveExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveExtensionAttributeWithOptionsAsync(request, runtime);
        }

        public SaveTaskResponse SaveTaskWithOptions(SaveTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                query["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTask",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTaskResponse> SaveTaskWithOptionsAsync(SaveTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                query["Request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTask",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTaskResponse SaveTask(SaveTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskWithOptions(request, runtime);
        }

        public async Task<SaveTaskResponse> SaveTaskAsync(SaveTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskWithOptionsAsync(request, runtime);
        }

        public SaveTaskForOfficialFileCustomResponse SaveTaskForOfficialFileCustomWithOptions(SaveTaskForOfficialFileCustomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndAcceptTime))
            {
                query["EndAcceptTime"] = request.EndAcceptTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartAcceptTime))
            {
                query["StartAcceptTime"] = request.StartAcceptTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForOfficialFileCustom",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForOfficialFileCustomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTaskForOfficialFileCustomResponse> SaveTaskForOfficialFileCustomWithOptionsAsync(SaveTaskForOfficialFileCustomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndAcceptTime))
            {
                query["EndAcceptTime"] = request.EndAcceptTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartAcceptTime))
            {
                query["StartAcceptTime"] = request.StartAcceptTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForOfficialFileCustom",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForOfficialFileCustomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTaskForOfficialFileCustomResponse SaveTaskForOfficialFileCustom(SaveTaskForOfficialFileCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForOfficialFileCustomWithOptions(request, runtime);
        }

        public async Task<SaveTaskForOfficialFileCustomResponse> SaveTaskForOfficialFileCustomAsync(SaveTaskForOfficialFileCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForOfficialFileCustomWithOptionsAsync(request, runtime);
        }

        public SaveTradeMarkReviewMaterialDetailResponse SaveTradeMarkReviewMaterialDetailWithOptions(SaveTradeMarkReviewMaterialDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveTradeMarkReviewMaterialDetailShrinkRequest request = new SaveTradeMarkReviewMaterialDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalOssKeyList))
            {
                request.AdditionalOssKeyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalOssKeyList, "AdditionalOssKeyList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalOssKeyListShrink))
            {
                body["AdditionalOssKeyList"] = request.AdditionalOssKeyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationOssKey))
            {
                body["ApplicationOssKey"] = request.ApplicationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                body["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                body["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeName))
            {
                body["ChangeName"] = request.ChangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                body["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                body["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                body["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                body["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngAddress))
            {
                body["EngAddress"] = request.EngAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngName))
            {
                body["EngName"] = request.EngName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                body["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                body["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                body["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                body["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewMaterialAdditionalJson))
            {
                body["ReviewMaterialAdditionalJson"] = request.ReviewMaterialAdditionalJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separate))
            {
                body["Separate"] = request.Separate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitOnline))
            {
                body["SubmitOnline"] = request.SubmitOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitType))
            {
                body["SubmitType"] = request.SubmitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementFlag))
            {
                body["SupplementFlag"] = request.SupplementFlag;
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
                Action = "SaveTradeMarkReviewMaterialDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTradeMarkReviewMaterialDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTradeMarkReviewMaterialDetailResponse> SaveTradeMarkReviewMaterialDetailWithOptionsAsync(SaveTradeMarkReviewMaterialDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveTradeMarkReviewMaterialDetailShrinkRequest request = new SaveTradeMarkReviewMaterialDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalOssKeyList))
            {
                request.AdditionalOssKeyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalOssKeyList, "AdditionalOssKeyList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalOssKeyListShrink))
            {
                body["AdditionalOssKeyList"] = request.AdditionalOssKeyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationOssKey))
            {
                body["ApplicationOssKey"] = request.ApplicationOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                body["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                body["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeName))
            {
                body["ChangeName"] = request.ChangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                body["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                body["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                body["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                body["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngAddress))
            {
                body["EngAddress"] = request.EngAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngName))
            {
                body["EngName"] = request.EngName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                body["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                body["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                body["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                body["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewMaterialAdditionalJson))
            {
                body["ReviewMaterialAdditionalJson"] = request.ReviewMaterialAdditionalJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separate))
            {
                body["Separate"] = request.Separate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitOnline))
            {
                body["SubmitOnline"] = request.SubmitOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitType))
            {
                body["SubmitType"] = request.SubmitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementFlag))
            {
                body["SupplementFlag"] = request.SupplementFlag;
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
                Action = "SaveTradeMarkReviewMaterialDetail",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTradeMarkReviewMaterialDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTradeMarkReviewMaterialDetailResponse SaveTradeMarkReviewMaterialDetail(SaveTradeMarkReviewMaterialDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTradeMarkReviewMaterialDetailWithOptions(request, runtime);
        }

        public async Task<SaveTradeMarkReviewMaterialDetailResponse> SaveTradeMarkReviewMaterialDetailAsync(SaveTradeMarkReviewMaterialDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTradeMarkReviewMaterialDetailWithOptionsAsync(request, runtime);
        }

        public SbjOperateResponse SbjOperateWithOptions(SbjOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNo))
            {
                query["ApplyNo"] = request.ApplyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDate))
            {
                query["FileDate"] = request.FileDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssKey))
            {
                query["FileOssKey"] = request.FileOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptOssKey))
            {
                query["ReceiptOssKey"] = request.ReceiptOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmittedSuccess))
            {
                query["SubmittedSuccess"] = request.SubmittedSuccess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbjOperate",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbjOperateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SbjOperateResponse> SbjOperateWithOptionsAsync(SbjOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNo))
            {
                query["ApplyNo"] = request.ApplyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDate))
            {
                query["FileDate"] = request.FileDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssKey))
            {
                query["FileOssKey"] = request.FileOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptOssKey))
            {
                query["ReceiptOssKey"] = request.ReceiptOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmittedSuccess))
            {
                query["SubmittedSuccess"] = request.SubmittedSuccess;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbjOperate",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbjOperateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SbjOperateResponse SbjOperate(SbjOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SbjOperateWithOptions(request, runtime);
        }

        public async Task<SbjOperateResponse> SbjOperateAsync(SbjOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SbjOperateWithOptionsAsync(request, runtime);
        }

        public SbjOperateNewResponse SbjOperateNewWithOptions(SbjOperateNewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddSubmitCount))
            {
                query["AddSubmitCount"] = request.AddSubmitCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowResubmit))
            {
                query["AllowResubmit"] = request.AllowResubmit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNo))
            {
                query["ApplyNo"] = request.ApplyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStatus))
            {
                query["ChangeStatus"] = request.ChangeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsgScreenshot))
            {
                query["ErrorMsgScreenshot"] = request.ErrorMsgScreenshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDate))
            {
                query["FileDate"] = request.FileDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssKey))
            {
                query["FileOssKey"] = request.FileOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptOssKey))
            {
                query["ReceiptOssKey"] = request.ReceiptOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmittedSuccess))
            {
                query["SubmittedSuccess"] = request.SubmittedSuccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessType))
            {
                query["SuccessType"] = request.SuccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbjOperateNew",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbjOperateNewResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SbjOperateNewResponse> SbjOperateNewWithOptionsAsync(SbjOperateNewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddSubmitCount))
            {
                query["AddSubmitCount"] = request.AddSubmitCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowResubmit))
            {
                query["AllowResubmit"] = request.AllowResubmit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyNo))
            {
                query["ApplyNo"] = request.ApplyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStatus))
            {
                query["ChangeStatus"] = request.ChangeStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsgScreenshot))
            {
                query["ErrorMsgScreenshot"] = request.ErrorMsgScreenshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDate))
            {
                query["FileDate"] = request.FileDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssKey))
            {
                query["FileOssKey"] = request.FileOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["OrderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptOssKey))
            {
                query["ReceiptOssKey"] = request.ReceiptOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmittedSuccess))
            {
                query["SubmittedSuccess"] = request.SubmittedSuccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessType))
            {
                query["SuccessType"] = request.SuccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbjOperateNew",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbjOperateNewResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SbjOperateNewResponse SbjOperateNew(SbjOperateNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SbjOperateNewWithOptions(request, runtime);
        }

        public async Task<SbjOperateNewResponse> SbjOperateNewAsync(SbjOperateNewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SbjOperateNewWithOptionsAsync(request, runtime);
        }

        public SbrainServiceExecuteResponse SbrainServiceExecuteWithOptions(SbrainServiceExecuteRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SbrainServiceExecuteShrinkRequest request = new SbrainServiceExecuteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteParams))
            {
                request.ExecuteParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteParams, "ExecuteParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteParamsShrink))
            {
                query["ExecuteParams"] = request.ExecuteParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceNo))
            {
                query["ReferenceNo"] = request.ReferenceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceType))
            {
                query["ReferenceType"] = request.ReferenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                query["SchemeId"] = request.SchemeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePlace))
            {
                query["ServicePlace"] = request.ServicePlace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbrainServiceExecute",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbrainServiceExecuteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SbrainServiceExecuteResponse> SbrainServiceExecuteWithOptionsAsync(SbrainServiceExecuteRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SbrainServiceExecuteShrinkRequest request = new SbrainServiceExecuteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteParams))
            {
                request.ExecuteParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteParams, "ExecuteParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteParamsShrink))
            {
                query["ExecuteParams"] = request.ExecuteParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceNo))
            {
                query["ReferenceNo"] = request.ReferenceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceType))
            {
                query["ReferenceType"] = request.ReferenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                query["SchemeId"] = request.SchemeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePlace))
            {
                query["ServicePlace"] = request.ServicePlace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbrainServiceExecute",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbrainServiceExecuteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SbrainServiceExecuteResponse SbrainServiceExecute(SbrainServiceExecuteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SbrainServiceExecuteWithOptions(request, runtime);
        }

        public async Task<SbrainServiceExecuteResponse> SbrainServiceExecuteAsync(SbrainServiceExecuteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SbrainServiceExecuteWithOptionsAsync(request, runtime);
        }

        public SbrainServiceHasRunningTaskBatchQueryResponse SbrainServiceHasRunningTaskBatchQueryWithOptions(SbrainServiceHasRunningTaskBatchQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SbrainServiceHasRunningTaskBatchQueryShrinkRequest request = new SbrainServiceHasRunningTaskBatchQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceNos))
            {
                request.ReferenceNosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceNos, "ReferenceNos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceNosShrink))
            {
                query["ReferenceNos"] = request.ReferenceNosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceType))
            {
                query["ReferenceType"] = request.ReferenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
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
                Action = "SbrainServiceHasRunningTaskBatchQuery",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbrainServiceHasRunningTaskBatchQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SbrainServiceHasRunningTaskBatchQueryResponse> SbrainServiceHasRunningTaskBatchQueryWithOptionsAsync(SbrainServiceHasRunningTaskBatchQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SbrainServiceHasRunningTaskBatchQueryShrinkRequest request = new SbrainServiceHasRunningTaskBatchQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceNos))
            {
                request.ReferenceNosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceNos, "ReferenceNos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceNosShrink))
            {
                query["ReferenceNos"] = request.ReferenceNosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceType))
            {
                query["ReferenceType"] = request.ReferenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
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
                Action = "SbrainServiceHasRunningTaskBatchQuery",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbrainServiceHasRunningTaskBatchQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SbrainServiceHasRunningTaskBatchQueryResponse SbrainServiceHasRunningTaskBatchQuery(SbrainServiceHasRunningTaskBatchQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SbrainServiceHasRunningTaskBatchQueryWithOptions(request, runtime);
        }

        public async Task<SbrainServiceHasRunningTaskBatchQueryResponse> SbrainServiceHasRunningTaskBatchQueryAsync(SbrainServiceHasRunningTaskBatchQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SbrainServiceHasRunningTaskBatchQueryWithOptionsAsync(request, runtime);
        }

        public SbrainServiceSchemeMatchResponse SbrainServiceSchemeMatchWithOptions(SbrainServiceSchemeMatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SbrainServiceSchemeMatchShrinkRequest request = new SbrainServiceSchemeMatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MatchParams))
            {
                request.MatchParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MatchParams, "MatchParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchParamsShrink))
            {
                query["MatchParams"] = request.MatchParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceNo))
            {
                query["ReferenceNo"] = request.ReferenceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceType))
            {
                query["ReferenceType"] = request.ReferenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbrainServiceSchemeMatch",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbrainServiceSchemeMatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SbrainServiceSchemeMatchResponse> SbrainServiceSchemeMatchWithOptionsAsync(SbrainServiceSchemeMatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SbrainServiceSchemeMatchShrinkRequest request = new SbrainServiceSchemeMatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MatchParams))
            {
                request.MatchParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MatchParams, "MatchParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchParamsShrink))
            {
                query["MatchParams"] = request.MatchParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceNo))
            {
                query["ReferenceNo"] = request.ReferenceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceType))
            {
                query["ReferenceType"] = request.ReferenceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SbrainServiceSchemeMatch",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SbrainServiceSchemeMatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SbrainServiceSchemeMatchResponse SbrainServiceSchemeMatch(SbrainServiceSchemeMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SbrainServiceSchemeMatchWithOptions(request, runtime);
        }

        public async Task<SbrainServiceSchemeMatchResponse> SbrainServiceSchemeMatchAsync(SbrainServiceSchemeMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SbrainServiceSchemeMatchWithOptionsAsync(request, runtime);
        }

        public SearchTmOnsalesResponse SearchTmOnsalesWithOptions(SearchTmOnsalesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPriceLeft))
            {
                query["OrderPriceLeft"] = request.OrderPriceLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPriceRight))
            {
                query["OrderPriceRight"] = request.OrderPriceRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryAll))
            {
                query["QueryAll"] = request.QueryAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegLeft))
            {
                query["RegLeft"] = request.RegLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegRight))
            {
                query["RegRight"] = request.RegRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["SortName"] = request.SortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopSearch))
            {
                query["TopSearch"] = request.TopSearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchTmOnsales",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTmOnsalesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchTmOnsalesResponse> SearchTmOnsalesWithOptionsAsync(SearchTmOnsalesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classification))
            {
                query["Classification"] = request.Classification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPriceLeft))
            {
                query["OrderPriceLeft"] = request.OrderPriceLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPriceRight))
            {
                query["OrderPriceRight"] = request.OrderPriceRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryAll))
            {
                query["QueryAll"] = request.QueryAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegLeft))
            {
                query["RegLeft"] = request.RegLeft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegRight))
            {
                query["RegRight"] = request.RegRight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNumber))
            {
                query["RegisterNumber"] = request.RegisterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["SortName"] = request.SortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopSearch))
            {
                query["TopSearch"] = request.TopSearch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchTmOnsales",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTmOnsalesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchTmOnsalesResponse SearchTmOnsales(SearchTmOnsalesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTmOnsalesWithOptions(request, runtime);
        }

        public async Task<SearchTmOnsalesResponse> SearchTmOnsalesAsync(SearchTmOnsalesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTmOnsalesWithOptionsAsync(request, runtime);
        }

        public StartNotaryResponse StartNotaryWithOptions(StartNotaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryOrderId))
            {
                query["NotaryOrderId"] = request.NotaryOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartNotary",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartNotaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartNotaryResponse> StartNotaryWithOptionsAsync(StartNotaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryOrderId))
            {
                query["NotaryOrderId"] = request.NotaryOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartNotary",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartNotaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartNotaryResponse StartNotary(StartNotaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartNotaryWithOptions(request, runtime);
        }

        public async Task<StartNotaryResponse> StartNotaryAsync(StartNotaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartNotaryWithOptionsAsync(request, runtime);
        }

        public StoreMaterialTemporarilyResponse StoreMaterialTemporarilyWithOptions(StoreMaterialTemporarilyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StoreMaterialTemporarily",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StoreMaterialTemporarilyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StoreMaterialTemporarilyResponse> StoreMaterialTemporarilyWithOptionsAsync(StoreMaterialTemporarilyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalName))
            {
                query["PrincipalName"] = request.PrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StoreMaterialTemporarily",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StoreMaterialTemporarilyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StoreMaterialTemporarilyResponse StoreMaterialTemporarily(StoreMaterialTemporarilyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StoreMaterialTemporarilyWithOptions(request, runtime);
        }

        public async Task<StoreMaterialTemporarilyResponse> StoreMaterialTemporarilyAsync(StoreMaterialTemporarilyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StoreMaterialTemporarilyWithOptionsAsync(request, runtime);
        }

        public SubmitSupplementResponse SubmitSupplementWithOptions(SubmitSupplementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSupplementShrinkRequest request = new SubmitSupplementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UploadOssKeyList))
            {
                request.UploadOssKeyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UploadOssKeyList, "UploadOssKeyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadOssKeyListShrink))
            {
                query["UploadOssKeyList"] = request.UploadOssKeyListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSupplement",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSupplementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitSupplementResponse> SubmitSupplementWithOptionsAsync(SubmitSupplementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSupplementShrinkRequest request = new SubmitSupplementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UploadOssKeyList))
            {
                request.UploadOssKeyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UploadOssKeyList, "UploadOssKeyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadOssKeyListShrink))
            {
                query["UploadOssKeyList"] = request.UploadOssKeyListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSupplement",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSupplementResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitSupplementResponse SubmitSupplement(SubmitSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSupplementWithOptions(request, runtime);
        }

        public async Task<SubmitSupplementResponse> SubmitSupplementAsync(SubmitSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSupplementWithOptionsAsync(request, runtime);
        }

        public SubmitTrademarkApplicationComplaintResponse SubmitTrademarkApplicationComplaintWithOptions(SubmitTrademarkApplicationComplaintRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTrademarkApplicationComplaintShrinkRequest request = new SubmitTrademarkApplicationComplaintShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTrademarkApplicationComplaint",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTrademarkApplicationComplaintResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitTrademarkApplicationComplaintResponse> SubmitTrademarkApplicationComplaintWithOptionsAsync(SubmitTrademarkApplicationComplaintRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTrademarkApplicationComplaintShrinkRequest request = new SubmitTrademarkApplicationComplaintShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTrademarkApplicationComplaint",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTrademarkApplicationComplaintResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitTrademarkApplicationComplaintResponse SubmitTrademarkApplicationComplaint(SubmitTrademarkApplicationComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTrademarkApplicationComplaintWithOptions(request, runtime);
        }

        public async Task<SubmitTrademarkApplicationComplaintResponse> SubmitTrademarkApplicationComplaintAsync(SubmitTrademarkApplicationComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTrademarkApplicationComplaintWithOptionsAsync(request, runtime);
        }

        public SyncTrademarkResponse SyncTrademarkWithOptions(SyncTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncTrademark",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTrademarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncTrademarkResponse> SyncTrademarkWithOptionsAsync(SyncTrademarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncTrademark",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTrademarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SyncTrademarkResponse SyncTrademark(SyncTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncTrademarkWithOptions(request, runtime);
        }

        public async Task<SyncTrademarkResponse> SyncTrademarkAsync(SyncTrademarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncTrademarkWithOptionsAsync(request, runtime);
        }

        public UpdateApplicantContacterResponse UpdateApplicantContacterWithOptions(UpdateApplicantContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipCode))
            {
                query["ContactZipCode"] = request.ContactZipCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicantContacter",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicantContacterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateApplicantContacterResponse> UpdateApplicantContacterWithOptionsAsync(UpdateApplicantContacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicantId))
            {
                query["ApplicantId"] = request.ApplicantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipCode))
            {
                query["ContactZipCode"] = request.ContactZipCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicantContacter",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicantContacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateApplicantContacterResponse UpdateApplicantContacter(UpdateApplicantContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicantContacterWithOptions(request, runtime);
        }

        public async Task<UpdateApplicantContacterResponse> UpdateApplicantContacterAsync(UpdateApplicantContacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicantContacterWithOptionsAsync(request, runtime);
        }

        public UpdateMaterialResponse UpdateMaterialWithOptions(UpdateMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaId))
            {
                query["LoaId"] = request.LoaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMaterialResponse> UpdateMaterialWithOptionsAsync(UpdateMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLicenceOssKey))
            {
                query["BusinessLicenceOssKey"] = request.BusinessLicenceOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardNumber))
            {
                query["CardNumber"] = request.CardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactAddress))
            {
                query["ContactAddress"] = request.ContactAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCity))
            {
                query["ContactCity"] = request.ContactCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactCounty))
            {
                query["ContactCounty"] = request.ContactCounty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactDistrict))
            {
                query["ContactDistrict"] = request.ContactDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNumber))
            {
                query["ContactNumber"] = request.ContactNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactProvince))
            {
                query["ContactProvince"] = request.ContactProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactZipcode))
            {
                query["ContactZipcode"] = request.ContactZipcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EAddress))
            {
                query["EAddress"] = request.EAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardName))
            {
                query["IdCardName"] = request.IdCardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardOssKey))
            {
                query["IdCardOssKey"] = request.IdCardOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalNoticeOssKey))
            {
                query["LegalNoticeOssKey"] = request.LegalNoticeOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaId))
            {
                query["LoaId"] = request.LoaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                query["LoaOssKey"] = request.LoaOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassportOssKey))
            {
                query["PassportOssKey"] = request.PassportOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalType))
            {
                query["PersonalType"] = request.PersonalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Town))
            {
                query["Town"] = request.Town;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMaterial",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMaterialResponse UpdateMaterial(UpdateMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMaterialWithOptions(request, runtime);
        }

        public async Task<UpdateMaterialResponse> UpdateMaterialAsync(UpdateMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMaterialWithOptionsAsync(request, runtime);
        }

        public UpdateProduceResponse UpdateProduceWithOptions(UpdateProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtMap))
            {
                query["ExtMap"] = request.ExtMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProduceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProduceResponse> UpdateProduceWithOptionsAsync(UpdateProduceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtMap))
            {
                query["ExtMap"] = request.ExtMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduce",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProduceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProduceResponse UpdateProduce(UpdateProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProduceWithOptions(request, runtime);
        }

        public async Task<UpdateProduceResponse> UpdateProduceAsync(UpdateProduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProduceWithOptionsAsync(request, runtime);
        }

        public UpdateProduceLoaIdResponse UpdateProduceLoaIdWithOptions(UpdateProduceLoaIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                body["LoaOssKey"] = request.LoaOssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduceLoaId",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProduceLoaIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProduceLoaIdResponse> UpdateProduceLoaIdWithOptionsAsync(UpdateProduceLoaIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoaOssKey))
            {
                body["LoaOssKey"] = request.LoaOssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduceLoaId",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProduceLoaIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProduceLoaIdResponse UpdateProduceLoaId(UpdateProduceLoaIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProduceLoaIdWithOptions(request, runtime);
        }

        public async Task<UpdateProduceLoaIdResponse> UpdateProduceLoaIdAsync(UpdateProduceLoaIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProduceLoaIdWithOptionsAsync(request, runtime);
        }

        public UpdateSendMaterialNumResponse UpdateSendMaterialNumWithOptions(UpdateSendMaterialNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSendMaterialNum",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSendMaterialNumResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSendMaterialNumResponse> UpdateSendMaterialNumWithOptionsAsync(UpdateSendMaterialNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSendMaterialNum",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSendMaterialNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSendMaterialNumResponse UpdateSendMaterialNum(UpdateSendMaterialNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSendMaterialNumWithOptions(request, runtime);
        }

        public async Task<UpdateSendMaterialNumResponse> UpdateSendMaterialNumAsync(UpdateSendMaterialNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSendMaterialNumWithOptionsAsync(request, runtime);
        }

        public UpdateTrademarkNameResponse UpdateTrademarkNameWithOptions(UpdateTrademarkNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                body["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                body["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                body["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrademarkName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrademarkNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTrademarkNameResponse> UpdateTrademarkNameWithOptionsAsync(UpdateTrademarkNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmComment))
            {
                body["TmComment"] = request.TmComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                body["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                body["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrademarkName",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrademarkNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTrademarkNameResponse UpdateTrademarkName(UpdateTrademarkNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrademarkNameWithOptions(request, runtime);
        }

        public async Task<UpdateTrademarkNameResponse> UpdateTrademarkNameAsync(UpdateTrademarkNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrademarkNameWithOptionsAsync(request, runtime);
        }

        public UpdateTrademarkOnsaleResponse UpdateTrademarkOnsaleWithOptions(UpdateTrademarkOnsaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTmDetailJson))
            {
                query["TradeTmDetailJson"] = request.TradeTmDetailJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrademarkOnsale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrademarkOnsaleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTrademarkOnsaleResponse> UpdateTrademarkOnsaleWithOptionsAsync(UpdateTrademarkOnsaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTmDetailJson))
            {
                query["TradeTmDetailJson"] = request.TradeTmDetailJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrademarkOnsale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrademarkOnsaleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTrademarkOnsaleResponse UpdateTrademarkOnsale(UpdateTrademarkOnsaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrademarkOnsaleWithOptions(request, runtime);
        }

        public async Task<UpdateTrademarkOnsaleResponse> UpdateTrademarkOnsaleAsync(UpdateTrademarkOnsaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrademarkOnsaleWithOptionsAsync(request, runtime);
        }

        public UploadNotaryDataResponse UploadNotaryDataWithOptions(UploadNotaryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizOrderNo))
            {
                query["BizOrderNo"] = request.BizOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryType))
            {
                query["NotaryType"] = request.NotaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadContext))
            {
                query["UploadContext"] = request.UploadContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadNotaryData",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadNotaryDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadNotaryDataResponse> UploadNotaryDataWithOptionsAsync(UploadNotaryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizOrderNo))
            {
                query["BizOrderNo"] = request.BizOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotaryType))
            {
                query["NotaryType"] = request.NotaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadContext))
            {
                query["UploadContext"] = request.UploadContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadNotaryData",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadNotaryDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadNotaryDataResponse UploadNotaryData(UploadNotaryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadNotaryDataWithOptions(request, runtime);
        }

        public async Task<UploadNotaryDataResponse> UploadNotaryDataAsync(UploadNotaryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadNotaryDataWithOptionsAsync(request, runtime);
        }

        public UploadTrademarkOnSaleResponse UploadTrademarkOnSaleWithOptions(UploadTrademarkOnSaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTmDetailJson))
            {
                query["TradeTmDetailJson"] = request.TradeTmDetailJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadTrademarkOnSale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadTrademarkOnSaleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadTrademarkOnSaleResponse> UploadTrademarkOnSaleWithOptionsAsync(UploadTrademarkOnSaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassificationCode))
            {
                query["ClassificationCode"] = request.ClassificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalPrice))
            {
                query["OriginalPrice"] = request.OriginalPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerEnName))
            {
                query["OwnerEnName"] = request.OwnerEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerName))
            {
                query["OwnerName"] = request.OwnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegAnnDate))
            {
                query["RegAnnDate"] = request.RegAnnDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryClassification))
            {
                query["SecondaryClassification"] = request.SecondaryClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdClassification))
            {
                query["ThirdClassification"] = request.ThirdClassification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmIcon))
            {
                query["TmIcon"] = request.TmIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmName))
            {
                query["TmName"] = request.TmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmNumber))
            {
                query["TmNumber"] = request.TmNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmType))
            {
                query["TmType"] = request.TmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTmDetailJson))
            {
                query["TradeTmDetailJson"] = request.TradeTmDetailJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadTrademarkOnSale",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadTrademarkOnSaleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadTrademarkOnSaleResponse UploadTrademarkOnSale(UploadTrademarkOnSaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadTrademarkOnSaleWithOptions(request, runtime);
        }

        public async Task<UploadTrademarkOnSaleResponse> UploadTrademarkOnSaleAsync(UploadTrademarkOnSaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadTrademarkOnSaleWithOptionsAsync(request, runtime);
        }

        public WriteCommunicationLogResponse WriteCommunicationLogWithOptions(WriteCommunicationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteCommunicationLog",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteCommunicationLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WriteCommunicationLogResponse> WriteCommunicationLogWithOptionsAsync(WriteCommunicationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteCommunicationLog",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteCommunicationLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WriteCommunicationLogResponse WriteCommunicationLog(WriteCommunicationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WriteCommunicationLogWithOptions(request, runtime);
        }

        public async Task<WriteCommunicationLogResponse> WriteCommunicationLogAsync(WriteCommunicationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WriteCommunicationLogWithOptionsAsync(request, runtime);
        }

        public WriteIntentionCommunicationLogResponse WriteIntentionCommunicationLogWithOptions(WriteIntentionCommunicationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reject))
            {
                query["Reject"] = request.Reject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteIntentionCommunicationLog",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteIntentionCommunicationLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WriteIntentionCommunicationLogResponse> WriteIntentionCommunicationLogWithOptionsAsync(WriteIntentionCommunicationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reject))
            {
                query["Reject"] = request.Reject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteIntentionCommunicationLog",
                Version = "2018-07-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteIntentionCommunicationLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WriteIntentionCommunicationLogResponse WriteIntentionCommunicationLog(WriteIntentionCommunicationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WriteIntentionCommunicationLogWithOptions(request, runtime);
        }

        public async Task<WriteIntentionCommunicationLogResponse> WriteIntentionCommunicationLogAsync(WriteIntentionCommunicationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WriteIntentionCommunicationLogWithOptionsAsync(request, runtime);
        }

    }
}
