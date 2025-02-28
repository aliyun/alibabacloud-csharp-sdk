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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyResponse
        /// </returns>
        public EntElementVerifyResponse EntElementVerifyWithOptions(EntElementVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "EntElementVerify",
                Version = "2022-11-25",
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
                return TeaModel.ToObject<EntElementVerifyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntElementVerifyResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyResponse
        /// </returns>
        public async Task<EntElementVerifyResponse> EntElementVerifyWithOptionsAsync(EntElementVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "EntElementVerify",
                Version = "2022-11-25",
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
                return TeaModel.ToObject<EntElementVerifyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntElementVerifyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyResponse
        /// </returns>
        public EntElementVerifyResponse EntElementVerify(EntElementVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EntElementVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素核验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyResponse
        /// </returns>
        public async Task<EntElementVerifyResponse> EntElementVerifyAsync(EntElementVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EntElementVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素验证V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyV2Response
        /// </returns>
        public EntElementVerifyV2Response EntElementVerifyV2WithOptions(EntElementVerifyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "EntElementVerifyV2",
                Version = "2022-11-25",
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
                return TeaModel.ToObject<EntElementVerifyV2Response>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntElementVerifyV2Response>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素验证V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyV2Response
        /// </returns>
        public async Task<EntElementVerifyV2Response> EntElementVerifyV2WithOptionsAsync(EntElementVerifyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "EntElementVerifyV2",
                Version = "2022-11-25",
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
                return TeaModel.ToObject<EntElementVerifyV2Response>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntElementVerifyV2Response>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素验证V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyV2Response
        /// </returns>
        public EntElementVerifyV2Response EntElementVerifyV2(EntElementVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EntElementVerifyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业要素验证V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntElementVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// EntElementVerifyV2Response
        /// </returns>
        public async Task<EntElementVerifyV2Response> EntElementVerifyV2Async(EntElementVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EntElementVerifyV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业经营异常查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntRiskQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntRiskQueryResponse
        /// </returns>
        public EntRiskQueryResponse EntRiskQueryWithOptions(EntRiskQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamValue))
            {
                query["ParamValue"] = request.ParamValue;
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
                Action = "EntRiskQuery",
                Version = "2022-11-25",
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
                return TeaModel.ToObject<EntRiskQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntRiskQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业经营异常查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntRiskQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntRiskQueryResponse
        /// </returns>
        public async Task<EntRiskQueryResponse> EntRiskQueryWithOptionsAsync(EntRiskQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamValue))
            {
                query["ParamValue"] = request.ParamValue;
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
                Action = "EntRiskQuery",
                Version = "2022-11-25",
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
                return TeaModel.ToObject<EntRiskQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntRiskQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业经营异常查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntRiskQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// EntRiskQueryResponse
        /// </returns>
        public EntRiskQueryResponse EntRiskQuery(EntRiskQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EntRiskQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业经营异常查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntRiskQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// EntRiskQueryResponse
        /// </returns>
        public async Task<EntRiskQueryResponse> EntRiskQueryAsync(EntRiskQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EntRiskQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业认证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntVerifyResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EntVerifyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntVerifyResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业认证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EntVerifyResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EntVerifyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EntVerifyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业认证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EntVerifyResponse
        /// </returns>
        public EntVerifyResponse EntVerify(EntVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EntVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业认证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EntVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EntVerifyResponse
        /// </returns>
        public async Task<EntVerifyResponse> EntVerifyAsync(EntVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EntVerifyWithOptionsAsync(request, runtime);
        }

    }
}
