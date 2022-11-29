// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth20221125.Models;

namespace AlibabaCloud.SDK.Cloudauth20221125
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public EntVerifyResponse EntVerifyWithOptions(EntVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                query["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntName))
            {
                query["EntName"] = request.EntName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoVerifyType))
            {
                query["InfoVerifyType"] = request.InfoVerifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertNo))
            {
                query["LegalPersonCertNo"] = request.LegalPersonCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonMobile))
            {
                query["LegalPersonMobile"] = request.LegalPersonMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNo))
            {
                query["LicenseNo"] = request.LicenseNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskModelVersion))
            {
                query["RiskModelVersion"] = request.RiskModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskVerifyType))
            {
                query["RiskVerifyType"] = request.RiskVerifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAuthorization))
            {
                query["UserAuthorization"] = request.UserAuthorization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntVerify",
                Version = "2022-11-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntVerifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EntVerifyResponse> EntVerifyWithOptionsAsync(EntVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                query["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntName))
            {
                query["EntName"] = request.EntName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoVerifyType))
            {
                query["InfoVerifyType"] = request.InfoVerifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertNo))
            {
                query["LegalPersonCertNo"] = request.LegalPersonCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonMobile))
            {
                query["LegalPersonMobile"] = request.LegalPersonMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonName))
            {
                query["LegalPersonName"] = request.LegalPersonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNo))
            {
                query["LicenseNo"] = request.LicenseNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskModelVersion))
            {
                query["RiskModelVersion"] = request.RiskModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskVerifyType))
            {
                query["RiskVerifyType"] = request.RiskVerifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAuthorization))
            {
                query["UserAuthorization"] = request.UserAuthorization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EntVerify",
                Version = "2022-11-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EntVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EntVerifyResponse EntVerify(EntVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EntVerifyWithOptions(request, runtime);
        }

        public async Task<EntVerifyResponse> EntVerifyAsync(EntVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EntVerifyWithOptionsAsync(request, runtime);
        }

    }
}
