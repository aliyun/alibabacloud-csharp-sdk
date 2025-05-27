// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AccountCenter20241209.Models;

namespace AlibabaCloud.SDK.AccountCenter20241209
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("accountcenter", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public EnterpriseOrgQueryLoadTreeResponse EnterpriseOrgQueryLoadTreeWithOptions(EnterpriseOrgQueryLoadTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadOrgOnly))
            {
                query["LoadOrgOnly"] = request.LoadOrgOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseOrgQueryLoadTree",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseOrgQueryLoadTreeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public async Task<EnterpriseOrgQueryLoadTreeResponse> EnterpriseOrgQueryLoadTreeWithOptionsAsync(EnterpriseOrgQueryLoadTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadOrgOnly))
            {
                query["LoadOrgOnly"] = request.LoadOrgOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseOrgQueryLoadTree",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseOrgQueryLoadTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public EnterpriseOrgQueryLoadTreeResponse EnterpriseOrgQueryLoadTree(EnterpriseOrgQueryLoadTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseOrgQueryLoadTreeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织目录树查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseOrgQueryLoadTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseOrgQueryLoadTreeResponse
        /// </returns>
        public async Task<EnterpriseOrgQueryLoadTreeResponse> EnterpriseOrgQueryLoadTreeAsync(EnterpriseOrgQueryLoadTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseOrgQueryLoadTreeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public EnterpriseRegisterAccountResponse EnterpriseRegisterAccountWithOptions(EnterpriseRegisterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPassword))
            {
                query["EncryptPassword"] = request.EncryptPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                query["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteNick))
            {
                query["SiteNick"] = request.SiteNick;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRegisterAccount",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRegisterAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public async Task<EnterpriseRegisterAccountResponse> EnterpriseRegisterAccountWithOptionsAsync(EnterpriseRegisterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPassword))
            {
                query["EncryptPassword"] = request.EncryptPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptTicket))
            {
                query["EncryptTicket"] = request.EncryptTicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowCompleteInfo))
            {
                query["ShowCompleteInfo"] = request.ShowCompleteInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteNick))
            {
                query["SiteNick"] = request.SiteNick;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedEcId))
            {
                body["OrientedEcId"] = request.OrientedEcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedLeId))
            {
                body["OrientedLeId"] = request.OrientedLeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrientedNbId))
            {
                body["OrientedNbId"] = request.OrientedNbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnterpriseRegisterAccount",
                Version = "2024-12-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnterpriseRegisterAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public EnterpriseRegisterAccountResponse EnterpriseRegisterAccount(EnterpriseRegisterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnterpriseRegisterAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建成员账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnterpriseRegisterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// EnterpriseRegisterAccountResponse
        /// </returns>
        public async Task<EnterpriseRegisterAccountResponse> EnterpriseRegisterAccountAsync(EnterpriseRegisterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnterpriseRegisterAccountWithOptionsAsync(request, runtime);
        }

    }
}
