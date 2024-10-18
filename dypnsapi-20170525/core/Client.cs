// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dypnsapi20170525.Models;

namespace AlibabaCloud.SDK.Dypnsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dypnsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSmsVerifyCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSmsVerifyCodeResponse
        /// </returns>
        public CheckSmsVerifyCodeResponse CheckSmsVerifyCodeWithOptions(CheckSmsVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseAuthPolicy))
            {
                query["CaseAuthPolicy"] = request.CaseAuthPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSmsVerifyCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSmsVerifyCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSmsVerifyCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSmsVerifyCodeResponse
        /// </returns>
        public async Task<CheckSmsVerifyCodeResponse> CheckSmsVerifyCodeWithOptionsAsync(CheckSmsVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseAuthPolicy))
            {
                query["CaseAuthPolicy"] = request.CaseAuthPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSmsVerifyCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSmsVerifyCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSmsVerifyCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSmsVerifyCodeResponse
        /// </returns>
        public CheckSmsVerifyCodeResponse CheckSmsVerifyCode(CheckSmsVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSmsVerifyCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSmsVerifyCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSmsVerifyCodeResponse
        /// </returns>
        public async Task<CheckSmsVerifyCodeResponse> CheckSmsVerifyCodeAsync(CheckSmsVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSmsVerifyCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code for a converged communication authentication service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeConfigResponse
        /// </returns>
        public CreateSchemeConfigResponse CreateSchemeConfigWithOptions(CreateSchemeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPackageName))
            {
                query["AndroidPackageName"] = request.AndroidPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPackageSign))
            {
                query["AndroidPackageSign"] = request.AndroidPackageSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Origin))
            {
                query["H5Origin"] = request.H5Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Url))
            {
                query["H5Url"] = request.H5Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosBundleId))
            {
                query["IosBundleId"] = request.IosBundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSchemeConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSchemeConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code for a converged communication authentication service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeConfigResponse
        /// </returns>
        public async Task<CreateSchemeConfigResponse> CreateSchemeConfigWithOptionsAsync(CreateSchemeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPackageName))
            {
                query["AndroidPackageName"] = request.AndroidPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPackageSign))
            {
                query["AndroidPackageSign"] = request.AndroidPackageSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Origin))
            {
                query["H5Origin"] = request.H5Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.H5Url))
            {
                query["H5Url"] = request.H5Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosBundleId))
            {
                query["IosBundleId"] = request.IosBundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSchemeConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSchemeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code for a converged communication authentication service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeConfigResponse
        /// </returns>
        public CreateSchemeConfigResponse CreateSchemeConfig(CreateSchemeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSchemeConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code for a converged communication authentication service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeConfigResponse
        /// </returns>
        public async Task<CreateSchemeConfigResponse> CreateSchemeConfigAsync(CreateSchemeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSchemeConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySchemeResponse
        /// </returns>
        public CreateVerifySchemeResponse CreateVerifySchemeWithOptions(CreateVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmApiCode))
            {
                query["CmApiCode"] = request.CmApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CtApiCode))
            {
                query["CtApiCode"] = request.CtApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuApiCode))
            {
                query["CuApiCode"] = request.CuApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HmAppIdentifier))
            {
                query["HmAppIdentifier"] = request.HmAppIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HmPackageName))
            {
                query["HmPackageName"] = request.HmPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HmSignName))
            {
                query["HmSignName"] = request.HmSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                query["IpWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackName))
            {
                query["PackName"] = request.PackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackSign))
            {
                query["PackSign"] = request.PackSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                query["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVerifySchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySchemeResponse
        /// </returns>
        public async Task<CreateVerifySchemeResponse> CreateVerifySchemeWithOptionsAsync(CreateVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmApiCode))
            {
                query["CmApiCode"] = request.CmApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CtApiCode))
            {
                query["CtApiCode"] = request.CtApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuApiCode))
            {
                query["CuApiCode"] = request.CuApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HmAppIdentifier))
            {
                query["HmAppIdentifier"] = request.HmAppIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HmPackageName))
            {
                query["HmPackageName"] = request.HmPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HmSignName))
            {
                query["HmSignName"] = request.HmSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhiteList))
            {
                query["IpWhiteList"] = request.IpWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackName))
            {
                query["PackName"] = request.PackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackSign))
            {
                query["PackSign"] = request.PackSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                query["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVerifySchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySchemeResponse
        /// </returns>
        public CreateVerifySchemeResponse CreateVerifyScheme(CreateVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySchemeResponse
        /// </returns>
        public async Task<CreateVerifySchemeResponse> CreateVerifySchemeAsync(CreateVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifySchemeResponse
        /// </returns>
        public DeleteVerifySchemeResponse DeleteVerifySchemeWithOptions(DeleteVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeCode))
            {
                query["SchemeCode"] = request.SchemeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVerifySchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifySchemeResponse
        /// </returns>
        public async Task<DeleteVerifySchemeResponse> DeleteVerifySchemeWithOptionsAsync(DeleteVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeCode))
            {
                query["SchemeCode"] = request.SchemeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVerifySchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifySchemeResponse
        /// </returns>
        public DeleteVerifySchemeResponse DeleteVerifyScheme(DeleteVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVerifySchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifySchemeResponse
        /// </returns>
        public async Task<DeleteVerifySchemeResponse> DeleteVerifySchemeAsync(DeleteVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVerifySchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySchemeResponse
        /// </returns>
        public DescribeVerifySchemeResponse DescribeVerifySchemeWithOptions(DescribeVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeCode))
            {
                query["SchemeCode"] = request.SchemeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifySchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySchemeResponse
        /// </returns>
        public async Task<DescribeVerifySchemeResponse> DescribeVerifySchemeWithOptionsAsync(DescribeVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeCode))
            {
                query["SchemeCode"] = request.SchemeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifySchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySchemeResponse
        /// </returns>
        public DescribeVerifySchemeResponse DescribeVerifyScheme(DescribeVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySchemeResponse
        /// </returns>
        public async Task<DescribeVerifySchemeResponse> DescribeVerifySchemeAsync(DescribeVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token used for the authentication of the phone number verification for HTML5 pages. You can obtain AccessToken and JwtToken after a successful call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthTokenResponse
        /// </returns>
        public GetAuthTokenResponse GetAuthTokenWithOptions(GetAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token used for the authentication of the phone number verification for HTML5 pages. You can obtain AccessToken and JwtToken after a successful call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthTokenResponse
        /// </returns>
        public async Task<GetAuthTokenResponse> GetAuthTokenWithOptionsAsync(GetAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token used for the authentication of the phone number verification for HTML5 pages. You can obtain AccessToken and JwtToken after a successful call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthTokenResponse
        /// </returns>
        public GetAuthTokenResponse GetAuthToken(GetAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token used for the authentication of the phone number verification for HTML5 pages. You can obtain AccessToken and JwtToken after a successful call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthTokenResponse
        /// </returns>
        public async Task<GetAuthTokenResponse> GetAuthTokenAsync(GetAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the URL for the Alipay account authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account and obtain an Alibaba Cloud AccessKey pair. For more information, see <a href="https://help.aliyun.com/document_detail/196922.html">Process of communication authorization</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationUrlResponse
        /// </returns>
        public GetAuthorizationUrlResponse GetAuthorizationUrlWithOptions(GetAuthorizationUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNo))
            {
                query["PhoneNo"] = request.PhoneNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                query["SchemeId"] = request.SchemeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the URL for the Alipay account authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account and obtain an Alibaba Cloud AccessKey pair. For more information, see <a href="https://help.aliyun.com/document_detail/196922.html">Process of communication authorization</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationUrlResponse
        /// </returns>
        public async Task<GetAuthorizationUrlResponse> GetAuthorizationUrlWithOptionsAsync(GetAuthorizationUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNo))
            {
                query["PhoneNo"] = request.PhoneNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                query["SchemeId"] = request.SchemeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the URL for the Alipay account authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account and obtain an Alibaba Cloud AccessKey pair. For more information, see <a href="https://help.aliyun.com/document_detail/196922.html">Process of communication authorization</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationUrlResponse
        /// </returns>
        public GetAuthorizationUrlResponse GetAuthorizationUrl(GetAuthorizationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthorizationUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the URL for the Alipay account authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account and obtain an Alibaba Cloud AccessKey pair. For more information, see <a href="https://help.aliyun.com/document_detail/196922.html">Process of communication authorization</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationUrlResponse
        /// </returns>
        public async Task<GetAuthorizationUrlResponse> GetAuthorizationUrlAsync(GetAuthorizationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthorizationUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the token that is obtained from the client SDKs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFusionAuthTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFusionAuthTokenResponse
        /// </returns>
        public GetFusionAuthTokenResponse GetFusionAuthTokenWithOptions(GetFusionAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageName))
            {
                query["PackageName"] = request.PackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageSign))
            {
                query["PackageSign"] = request.PackageSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeCode))
            {
                query["SchemeCode"] = request.SchemeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFusionAuthToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFusionAuthTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the token that is obtained from the client SDKs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFusionAuthTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFusionAuthTokenResponse
        /// </returns>
        public async Task<GetFusionAuthTokenResponse> GetFusionAuthTokenWithOptionsAsync(GetFusionAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageName))
            {
                query["PackageName"] = request.PackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageSign))
            {
                query["PackageSign"] = request.PackageSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeCode))
            {
                query["SchemeCode"] = request.SchemeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFusionAuthToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFusionAuthTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the token that is obtained from the client SDKs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFusionAuthTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFusionAuthTokenResponse
        /// </returns>
        public GetFusionAuthTokenResponse GetFusionAuthToken(GetFusionAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFusionAuthTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the token that is obtained from the client SDKs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFusionAuthTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFusionAuthTokenResponse
        /// </returns>
        public async Task<GetFusionAuthTokenResponse> GetFusionAuthTokenAsync(GetFusionAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFusionAuthTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration. You can call this operation only after you confirm the authorization on the authorization page provided by the SDK for one-click logon. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMobileResponse
        /// </returns>
        public GetMobileResponse GetMobileWithOptions(GetMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMobile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMobileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration. You can call this operation only after you confirm the authorization on the authorization page provided by the SDK for one-click logon. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMobileResponse
        /// </returns>
        public async Task<GetMobileResponse> GetMobileWithOptionsAsync(GetMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMobile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMobileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration. You can call this operation only after you confirm the authorization on the authorization page provided by the SDK for one-click logon. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMobileResponse
        /// </returns>
        public GetMobileResponse GetMobile(GetMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMobileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration. You can call this operation only after you confirm the authorization on the authorization page provided by the SDK for one-click logon. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMobileResponse
        /// </returns>
        public async Task<GetMobileResponse> GetMobileAsync(GetMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMobileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon. This operation is exclusive to HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration in HTML5 pages. You can call this operation only after you confirm the authorization on the authorization page provided by the JavaScript SDK. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPhoneWithTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhoneWithTokenResponse
        /// </returns>
        public GetPhoneWithTokenResponse GetPhoneWithTokenWithOptions(GetPhoneWithTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpToken))
            {
                query["SpToken"] = request.SpToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhoneWithToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneWithTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon. This operation is exclusive to HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration in HTML5 pages. You can call this operation only after you confirm the authorization on the authorization page provided by the JavaScript SDK. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPhoneWithTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhoneWithTokenResponse
        /// </returns>
        public async Task<GetPhoneWithTokenResponse> GetPhoneWithTokenWithOptionsAsync(GetPhoneWithTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpToken))
            {
                query["SpToken"] = request.SpToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhoneWithToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneWithTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon. This operation is exclusive to HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration in HTML5 pages. You can call this operation only after you confirm the authorization on the authorization page provided by the JavaScript SDK. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPhoneWithTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhoneWithTokenResponse
        /// </returns>
        public GetPhoneWithTokenResponse GetPhoneWithToken(GetPhoneWithTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhoneWithTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a phone number for one-click logon. This operation is exclusive to HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable only to one-click logon or registration in HTML5 pages. You can call this operation only after you confirm the authorization on the authorization page provided by the JavaScript SDK. You are prohibited from simulating or bypassing the authorization process. Alibaba Cloud reserves the right to terminate our services and take legal actions against such violations.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPhoneWithTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhoneWithTokenResponse
        /// </returns>
        public async Task<GetPhoneWithTokenResponse> GetPhoneWithTokenAsync(GetPhoneWithTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhoneWithTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token for an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsAuthTokensRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsAuthTokensResponse
        /// </returns>
        public GetSmsAuthTokensResponse GetSmsAuthTokensWithOptions(GetSmsAuthTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expire))
            {
                query["Expire"] = request.Expire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageName))
            {
                query["PackageName"] = request.PackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCodeExpire))
            {
                query["SmsCodeExpire"] = request.SmsCodeExpire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                query["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsAuthTokens",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsAuthTokensResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token for an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsAuthTokensRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmsAuthTokensResponse
        /// </returns>
        public async Task<GetSmsAuthTokensResponse> GetSmsAuthTokensWithOptionsAsync(GetSmsAuthTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expire))
            {
                query["Expire"] = request.Expire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageName))
            {
                query["PackageName"] = request.PackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCodeExpire))
            {
                query["SmsCodeExpire"] = request.SmsCodeExpire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateCode))
            {
                query["SmsTemplateCode"] = request.SmsTemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmsAuthTokens",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmsAuthTokensResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token for an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsAuthTokensRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsAuthTokensResponse
        /// </returns>
        public GetSmsAuthTokensResponse GetSmsAuthTokens(GetSmsAuthTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsAuthTokensWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the authorization token for an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSmsAuthTokensRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmsAuthTokensResponse
        /// </returns>
        public async Task<GetSmsAuthTokensResponse> GetSmsAuthTokensAsync(GetSmsAuthTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsAuthTokensWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建方案号（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyCreateVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JyCreateVerifySchemeResponse
        /// </returns>
        [Obsolete("OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.\n")]
        // Deprecated
        public JyCreateVerifySchemeResponse JyCreateVerifySchemeWithOptions(JyCreateVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmApiCode))
            {
                query["CmApiCode"] = request.CmApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CtApiCode))
            {
                query["CtApiCode"] = request.CtApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuApiCode))
            {
                query["CuApiCode"] = request.CuApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackName))
            {
                query["PackName"] = request.PackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackSign))
            {
                query["PackSign"] = request.PackSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JyCreateVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JyCreateVerifySchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建方案号（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyCreateVerifySchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JyCreateVerifySchemeResponse
        /// </returns>
        [Obsolete("OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.\n")]
        // Deprecated
        public async Task<JyCreateVerifySchemeResponse> JyCreateVerifySchemeWithOptionsAsync(JyCreateVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BundleId))
            {
                query["BundleId"] = request.BundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmApiCode))
            {
                query["CmApiCode"] = request.CmApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CtApiCode))
            {
                query["CtApiCode"] = request.CtApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuApiCode))
            {
                query["CuApiCode"] = request.CuApiCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackName))
            {
                query["PackName"] = request.PackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackSign))
            {
                query["PackSign"] = request.PackSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JyCreateVerifyScheme",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JyCreateVerifySchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建方案号（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyCreateVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// JyCreateVerifySchemeResponse
        /// </returns>
        [Obsolete("OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.\n")]
        // Deprecated
        public JyCreateVerifySchemeResponse JyCreateVerifyScheme(JyCreateVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JyCreateVerifySchemeWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建方案号（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyCreateVerifySchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// JyCreateVerifySchemeResponse
        /// </returns>
        [Obsolete("OpenAPI JyCreateVerifyScheme is deprecated, please use Dypnsapi::2017-05-25::CreateVerifyScheme instead.\n")]
        // Deprecated
        public async Task<JyCreateVerifySchemeResponse> JyCreateVerifySchemeAsync(JyCreateVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JyCreateVerifySchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据方案号查询运营商APP信（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyQueryAppInfoBySceneCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JyQueryAppInfoBySceneCodeResponse
        /// </returns>
        [Obsolete("OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.\n")]
        // Deprecated
        public JyQueryAppInfoBySceneCodeResponse JyQueryAppInfoBySceneCodeWithOptions(JyQueryAppInfoBySceneCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JyQueryAppInfoBySceneCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JyQueryAppInfoBySceneCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据方案号查询运营商APP信（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyQueryAppInfoBySceneCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JyQueryAppInfoBySceneCodeResponse
        /// </returns>
        [Obsolete("OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.\n")]
        // Deprecated
        public async Task<JyQueryAppInfoBySceneCodeResponse> JyQueryAppInfoBySceneCodeWithOptionsAsync(JyQueryAppInfoBySceneCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JyQueryAppInfoBySceneCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JyQueryAppInfoBySceneCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据方案号查询运营商APP信（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyQueryAppInfoBySceneCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// JyQueryAppInfoBySceneCodeResponse
        /// </returns>
        [Obsolete("OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.\n")]
        // Deprecated
        public JyQueryAppInfoBySceneCodeResponse JyQueryAppInfoBySceneCode(JyQueryAppInfoBySceneCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JyQueryAppInfoBySceneCodeWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据方案号查询运营商APP信（为极意临时定制）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// JyQueryAppInfoBySceneCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// JyQueryAppInfoBySceneCodeResponse
        /// </returns>
        [Obsolete("OpenAPI JyQueryAppInfoBySceneCode is deprecated, please use Dypnsapi::2017-05-25::QueryAppInfoBySceneCode instead.\n")]
        // Deprecated
        public async Task<JyQueryAppInfoBySceneCodeResponse> JyQueryAppInfoBySceneCodeAsync(JyQueryAppInfoBySceneCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JyQueryAppInfoBySceneCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fees generated by a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyBillingPublicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyBillingPublicResponse
        /// </returns>
        public QueryGateVerifyBillingPublicResponse QueryGateVerifyBillingPublicWithOptions(QueryGateVerifyBillingPublicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationType))
            {
                query["AuthenticationType"] = request.AuthenticationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGateVerifyBillingPublic",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGateVerifyBillingPublicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fees generated by a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyBillingPublicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyBillingPublicResponse
        /// </returns>
        public async Task<QueryGateVerifyBillingPublicResponse> QueryGateVerifyBillingPublicWithOptionsAsync(QueryGateVerifyBillingPublicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationType))
            {
                query["AuthenticationType"] = request.AuthenticationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGateVerifyBillingPublic",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGateVerifyBillingPublicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fees generated by a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyBillingPublicRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyBillingPublicResponse
        /// </returns>
        public QueryGateVerifyBillingPublicResponse QueryGateVerifyBillingPublic(QueryGateVerifyBillingPublicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGateVerifyBillingPublicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fees generated by a verification service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyBillingPublicRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyBillingPublicResponse
        /// </returns>
        public async Task<QueryGateVerifyBillingPublicResponse> QueryGateVerifyBillingPublicAsync(QueryGateVerifyBillingPublicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGateVerifyBillingPublicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the calls of Phone Number Verification Service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyStatisticPublicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyStatisticPublicResponse
        /// </returns>
        public QueryGateVerifyStatisticPublicResponse QueryGateVerifyStatisticPublicWithOptions(QueryGateVerifyStatisticPublicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationType))
            {
                query["AuthenticationType"] = request.AuthenticationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
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
                Action = "QueryGateVerifyStatisticPublic",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGateVerifyStatisticPublicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the calls of Phone Number Verification Service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyStatisticPublicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyStatisticPublicResponse
        /// </returns>
        public async Task<QueryGateVerifyStatisticPublicResponse> QueryGateVerifyStatisticPublicWithOptionsAsync(QueryGateVerifyStatisticPublicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationType))
            {
                query["AuthenticationType"] = request.AuthenticationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
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
                Action = "QueryGateVerifyStatisticPublic",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGateVerifyStatisticPublicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the calls of Phone Number Verification Service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyStatisticPublicRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyStatisticPublicResponse
        /// </returns>
        public QueryGateVerifyStatisticPublicResponse QueryGateVerifyStatisticPublic(QueryGateVerifyStatisticPublicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGateVerifyStatisticPublicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the calls of Phone Number Verification Service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryGateVerifyStatisticPublicRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGateVerifyStatisticPublicResponse
        /// </returns>
        public async Task<QueryGateVerifyStatisticPublicResponse> QueryGateVerifyStatisticPublicAsync(QueryGateVerifyStatisticPublicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGateVerifyStatisticPublicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySendDetails is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery status of the SMS verification code. You can query only the delivery status of the SMS verification code that is sent by calling corresponding API operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySendDetails is deprecated\n")]
        // Deprecated
        public QuerySendDetailsResponse QuerySendDetailsWithOptions(QuerySendDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                query["SendDate"] = request.SendDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySendDetails",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySendDetails is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery status of the SMS verification code. You can query only the delivery status of the SMS verification code that is sent by calling corresponding API operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySendDetails is deprecated\n")]
        // Deprecated
        public async Task<QuerySendDetailsResponse> QuerySendDetailsWithOptionsAsync(QuerySendDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                query["SendDate"] = request.SendDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySendDetails",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySendDetails is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery status of the SMS verification code. You can query only the delivery status of the SMS verification code that is sent by calling corresponding API operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySendDetails is deprecated\n")]
        // Deprecated
        public QuerySendDetailsResponse QuerySendDetails(QuerySendDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySendDetailsWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI QuerySendDetails is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery status of the SMS verification code. You can query only the delivery status of the SMS verification code that is sent by calling corresponding API operations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySendDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySendDetailsResponse
        /// </returns>
        [Obsolete("OpenAPI QuerySendDetails is deprecated\n")]
        // Deprecated
        public async Task<QuerySendDetailsResponse> QuerySendDetailsAsync(QuerySendDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySendDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSmsVerifyCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSmsVerifyCodeResponse
        /// </returns>
        public SendSmsVerifyCodeResponse SendSmsVerifyCodeWithOptions(SendSmsVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeLength))
            {
                query["CodeLength"] = request.CodeLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                query["CodeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicatePolicy))
            {
                query["DuplicatePolicy"] = request.DuplicatePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnVerifyCode))
            {
                query["ReturnVerifyCode"] = request.ReturnVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTime))
            {
                query["ValidTime"] = request.ValidTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSmsVerifyCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSmsVerifyCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSmsVerifyCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSmsVerifyCodeResponse
        /// </returns>
        public async Task<SendSmsVerifyCodeResponse> SendSmsVerifyCodeWithOptionsAsync(SendSmsVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeLength))
            {
                query["CodeLength"] = request.CodeLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                query["CodeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicatePolicy))
            {
                query["DuplicatePolicy"] = request.DuplicatePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnVerifyCode))
            {
                query["ReturnVerifyCode"] = request.ReturnVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeName))
            {
                query["SchemeName"] = request.SchemeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                query["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidTime))
            {
                query["ValidTime"] = request.ValidTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSmsVerifyCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSmsVerifyCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSmsVerifyCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSmsVerifyCodeResponse
        /// </returns>
        public SendSmsVerifyCodeResponse SendSmsVerifyCode(SendSmsVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendSmsVerifyCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends SMS verification codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSmsVerifyCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSmsVerifyCodeResponse
        /// </returns>
        public async Task<SendSmsVerifyCodeResponse> SendSmsVerifyCodeAsync(SendSmsVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendSmsVerifyCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number that you use.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable to only the verification of thephone number that you use. To obtain a phone number for one-click logon, call <a href="https://help.aliyun.com/document_detail/189865.html">GetMobile</a>.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyMobileResponse
        /// </returns>
        public VerifyMobileResponse VerifyMobileWithOptions(VerifyMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessCode))
            {
                query["AccessCode"] = request.AccessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMobile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMobileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number that you use.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable to only the verification of thephone number that you use. To obtain a phone number for one-click logon, call <a href="https://help.aliyun.com/document_detail/189865.html">GetMobile</a>.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMobileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyMobileResponse
        /// </returns>
        public async Task<VerifyMobileResponse> VerifyMobileWithOptionsAsync(VerifyMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessCode))
            {
                query["AccessCode"] = request.AccessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMobile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMobileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number that you use.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable to only the verification of thephone number that you use. To obtain a phone number for one-click logon, call <a href="https://help.aliyun.com/document_detail/189865.html">GetMobile</a>.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyMobileResponse
        /// </returns>
        public VerifyMobileResponse VerifyMobile(VerifyMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMobileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number that you use.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/84541.html">Getting Started</a>.</para>
        /// <remarks>
        /// <para> This operation is applicable to only the verification of thephone number that you use. To obtain a phone number for one-click logon, call <a href="https://help.aliyun.com/document_detail/189865.html">GetMobile</a>.</para>
        /// </remarks>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 5,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyMobileResponse
        /// </returns>
        public async Task<VerifyMobileResponse> VerifyMobileAsync(VerifyMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMobileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number used in HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyPhoneWithTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyPhoneWithTokenResponse
        /// </returns>
        public VerifyPhoneWithTokenResponse VerifyPhoneWithTokenWithOptions(VerifyPhoneWithTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpToken))
            {
                query["SpToken"] = request.SpToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyPhoneWithToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyPhoneWithTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number used in HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyPhoneWithTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyPhoneWithTokenResponse
        /// </returns>
        public async Task<VerifyPhoneWithTokenResponse> VerifyPhoneWithTokenWithOptionsAsync(VerifyPhoneWithTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpToken))
            {
                query["SpToken"] = request.SpToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyPhoneWithToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyPhoneWithTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number used in HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyPhoneWithTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyPhoneWithTokenResponse
        /// </returns>
        public VerifyPhoneWithTokenResponse VerifyPhoneWithToken(VerifyPhoneWithTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyPhoneWithTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the phone number used in HTML5 pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/169786.html">Use the phone number verification feature for HTML5 pages</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyPhoneWithTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyPhoneWithTokenResponse
        /// </returns>
        public async Task<VerifyPhoneWithTokenResponse> VerifyPhoneWithTokenAsync(VerifyPhoneWithTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyPhoneWithTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifySmsCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifySmsCodeResponse
        /// </returns>
        public VerifySmsCodeResponse VerifySmsCodeWithOptions(VerifySmsCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCode))
            {
                query["SmsCode"] = request.SmsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsToken))
            {
                query["SmsToken"] = request.SmsToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySmsCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySmsCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifySmsCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifySmsCodeResponse
        /// </returns>
        public async Task<VerifySmsCodeResponse> VerifySmsCodeWithOptionsAsync(VerifySmsCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCode))
            {
                query["SmsCode"] = request.SmsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsToken))
            {
                query["SmsToken"] = request.SmsToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySmsCode",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySmsCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifySmsCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifySmsCodeResponse
        /// </returns>
        public VerifySmsCodeResponse VerifySmsCode(VerifySmsCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifySmsCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies SMS verification codes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Preparations</h3>
        /// <para>You must register an Alibaba Cloud account, obtain an Alibaba Cloud AccessKey pair, and create a verification service. For more information, see <a href="https://help.aliyun.com/document_detail/313209.html">Use the SMS verification feature</a>.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 500 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifySmsCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifySmsCodeResponse
        /// </returns>
        public async Task<VerifySmsCodeResponse> VerifySmsCodeAsync(VerifySmsCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifySmsCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the verification token that is obtained by using the authentication token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyWithFusionAuthTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyWithFusionAuthTokenResponse
        /// </returns>
        public VerifyWithFusionAuthTokenResponse VerifyWithFusionAuthTokenWithOptions(VerifyWithFusionAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyToken))
            {
                query["VerifyToken"] = request.VerifyToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyWithFusionAuthToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyWithFusionAuthTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the verification token that is obtained by using the authentication token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyWithFusionAuthTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyWithFusionAuthTokenResponse
        /// </returns>
        public async Task<VerifyWithFusionAuthTokenResponse> VerifyWithFusionAuthTokenWithOptionsAsync(VerifyWithFusionAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyToken))
            {
                query["VerifyToken"] = request.VerifyToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyWithFusionAuthToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyWithFusionAuthTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the verification token that is obtained by using the authentication token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyWithFusionAuthTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyWithFusionAuthTokenResponse
        /// </returns>
        public VerifyWithFusionAuthTokenResponse VerifyWithFusionAuthToken(VerifyWithFusionAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyWithFusionAuthTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the verification results by using the verification token that is obtained by using the authentication token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyWithFusionAuthTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyWithFusionAuthTokenResponse
        /// </returns>
        public async Task<VerifyWithFusionAuthTokenResponse> VerifyWithFusionAuthTokenAsync(VerifyWithFusionAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyWithFusionAuthTokenWithOptionsAsync(request, runtime);
        }

    }
}
