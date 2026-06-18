// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ModelStudio20260210.Models;

namespace AlibabaCloud.SDK.ModelStudio20260210
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"eu-central-1", "modelstudio.eu-central-1.aliyuncs.com"},
                {"cn-hongkong", "modelstudio.cn-hongkong.aliyuncs.com"},
                {"cn-beijing", "modelstudio.cn-beijing.aliyuncs.com"},
                {"ap-southeast-1", "modelstudio.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("modelstudio", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates an account and directly adds it as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrganizationMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrganizationMemberResponse
        /// </returns>
        public AddOrganizationMemberResponse AddOrganizationMemberWithOptions(AddOrganizationMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgRoleCode))
            {
                query["OrgRoleCode"] = request.OrgRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOrganizationMember",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/member-additions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrganizationMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an account and directly adds it as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrganizationMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrganizationMemberResponse
        /// </returns>
        public async Task<AddOrganizationMemberResponse> AddOrganizationMemberWithOptionsAsync(AddOrganizationMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgRoleCode))
            {
                query["OrgRoleCode"] = request.OrgRoleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOrganizationMember",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/member-additions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrganizationMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an account and directly adds it as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrganizationMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrganizationMemberResponse
        /// </returns>
        public AddOrganizationMemberResponse AddOrganizationMember(AddOrganizationMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddOrganizationMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an account and directly adds it as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrganizationMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrganizationMemberResponse
        /// </returns>
        public async Task<AddOrganizationMemberResponse> AddOrganizationMemberAsync(AddOrganizationMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddOrganizationMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns seats in bulk to the member level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAssignSeatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAssignSeatsResponse
        /// </returns>
        public BatchAssignSeatsResponse BatchAssignSeatsWithOptions(BatchAssignSeatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsStr))
            {
                query["AccountIdsStr"] = request.AccountIdsStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatType))
            {
                query["SeatType"] = request.SeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAssignSeats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/seat-assignments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAssignSeatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns seats in bulk to the member level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAssignSeatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAssignSeatsResponse
        /// </returns>
        public async Task<BatchAssignSeatsResponse> BatchAssignSeatsWithOptionsAsync(BatchAssignSeatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsStr))
            {
                query["AccountIdsStr"] = request.AccountIdsStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatType))
            {
                query["SeatType"] = request.SeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAssignSeats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/seat-assignments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAssignSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns seats in bulk to the member level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAssignSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAssignSeatsResponse
        /// </returns>
        public BatchAssignSeatsResponse BatchAssignSeats(BatchAssignSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchAssignSeatsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns seats in bulk to the member level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAssignSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAssignSeatsResponse
        /// </returns>
        public async Task<BatchAssignSeatsResponse> BatchAssignSeatsAsync(BatchAssignSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchAssignSeatsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Before using large models or applications in Alibaba Cloud Model Studio, create an API key as an authentication credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public CreateApiKeyResponse CreateApiKeyWithOptions(CreateApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auth))
            {
                body["auth"] = request.Auth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Before using large models or applications in Alibaba Cloud Model Studio, create an API key as an authentication credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public async Task<CreateApiKeyResponse> CreateApiKeyWithOptionsAsync(CreateApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auth))
            {
                body["auth"] = request.Auth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Before using large models or applications in Alibaba Cloud Model Studio, create an API key as an authentication credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApiKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Before using large models or applications in Alibaba Cloud Model Studio, create an API key as an authentication credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public async Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApiKeyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UAC API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenPlanKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanKeyResponse
        /// </returns>
        public CreateTokenPlanKeyResponse CreateTokenPlanKeyWithOptions(CreateTokenPlanKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTokenPlanKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/api-keys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenPlanKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UAC API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenPlanKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanKeyResponse
        /// </returns>
        public async Task<CreateTokenPlanKeyResponse> CreateTokenPlanKeyWithOptionsAsync(CreateTokenPlanKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTokenPlanKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/api-keys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenPlanKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UAC API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenPlanKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanKeyResponse
        /// </returns>
        public CreateTokenPlanKeyResponse CreateTokenPlanKey(CreateTokenPlanKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTokenPlanKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a UAC API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenPlanKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanKeyResponse
        /// </returns>
        public async Task<CreateTokenPlanKeyResponse> CreateTokenPlanKeyAsync(CreateTokenPlanKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTokenPlanKeyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a business workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSite))
            {
                query["serviceSite"] = request.ServiceSite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a business workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSite))
            {
                query["serviceSite"] = request.ServiceSite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a business workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a business workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public DeleteApiKeyResponse DeleteApiKeyWithOptions(string apiKeyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public async Task<DeleteApiKeyResponse> DeleteApiKeyWithOptionsAsync(string apiKeyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public DeleteApiKeyResponse DeleteApiKey(string apiKeyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApiKeyWithOptions(apiKeyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public async Task<DeleteApiKeyResponse> DeleteApiKeyAsync(string apiKeyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApiKeyWithOptionsAsync(apiKeyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A workspace can be deleted only if the following conditional requirements are met:</para>
        /// <ol>
        /// <item><description>The workspace is not the default workspace.</description></item>
        /// <item><description>The workspace is not used to purchase other products, such as AMB.</description></item>
        /// <item><description>In permission management, the workspace is not granted to Resource Access Management (RAM) users or RAM roles.</description></item>
        /// <item><description>The workspace does not contain any resources, such as API keys, model deployments, or knowledge bases.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string workspaceId, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A workspace can be deleted only if the following conditional requirements are met:</para>
        /// <ol>
        /// <item><description>The workspace is not the default workspace.</description></item>
        /// <item><description>The workspace is not used to purchase other products, such as AMB.</description></item>
        /// <item><description>In permission management, the workspace is not granted to Resource Access Management (RAM) users or RAM roles.</description></item>
        /// <item><description>The workspace does not contain any resources, such as API keys, model deployments, or knowledge bases.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string workspaceId, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A workspace can be deleted only if the following conditional requirements are met:</para>
        /// <ol>
        /// <item><description>The workspace is not the default workspace.</description></item>
        /// <item><description>The workspace is not used to purchase other products, such as AMB.</description></item>
        /// <item><description>In permission management, the workspace is not granted to Resource Access Management (RAM) users or RAM roles.</description></item>
        /// <item><description>The workspace does not contain any resources, such as API keys, model deployments, or knowledge bases.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string workspaceId, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A workspace can be deleted only if the following conditional requirements are met:</para>
        /// <ol>
        /// <item><description>The workspace is not the default workspace.</description></item>
        /// <item><description>The workspace is not used to purchase other products, such as AMB.</description></item>
        /// <item><description>In permission management, the workspace is not granted to Resource Access Management (RAM) users or RAM roles.</description></item>
        /// <item><description>The workspace does not contain any resources, such as API keys, model deployments, or knowledge bases.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string workspaceId, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key cannot be disabled if it is already disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableApiKeyResponse
        /// </returns>
        public DisableApiKeyResponse DisableApiKeyWithOptions(string apiKeyId, DisableApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId) + "/disable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key cannot be disabled if it is already disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableApiKeyResponse
        /// </returns>
        public async Task<DisableApiKeyResponse> DisableApiKeyWithOptionsAsync(string apiKeyId, DisableApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId) + "/disable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key cannot be disabled if it is already disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableApiKeyResponse
        /// </returns>
        public DisableApiKeyResponse DisableApiKey(string apiKeyId, DisableApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableApiKeyWithOptions(apiKeyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key cannot be disabled if it is already disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableApiKeyResponse
        /// </returns>
        public async Task<DisableApiKeyResponse> DisableApiKeyAsync(string apiKeyId, DisableApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableApiKeyWithOptionsAsync(apiKeyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key that is already enabled cannot be enabled again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableApiKeyResponse
        /// </returns>
        public EnableApiKeyResponse EnableApiKeyWithOptions(string apiKeyId, EnableApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId) + "/enable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key that is already enabled cannot be enabled again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableApiKeyResponse
        /// </returns>
        public async Task<EnableApiKeyResponse> EnableApiKeyWithOptionsAsync(string apiKeyId, EnableApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId) + "/enable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key that is already enabled cannot be enabled again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableApiKeyResponse
        /// </returns>
        public EnableApiKeyResponse EnableApiKey(string apiKeyId, EnableApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableApiKeyWithOptions(apiKeyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>An API key that is already enabled cannot be enabled again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableApiKeyResponse
        /// </returns>
        public async Task<EnableApiKeyResponse> EnableApiKeyAsync(string apiKeyId, EnableApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableApiKeyWithOptionsAsync(apiKeyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiKeyResponse
        /// </returns>
        public GetApiKeyResponse GetApiKeyWithOptions(string apiKeyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiKeyResponse
        /// </returns>
        public async Task<GetApiKeyResponse> GetApiKeyWithOptionsAsync(string apiKeyId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified authentication credential API key.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetApiKeyResponse
        /// </returns>
        public GetApiKeyResponse GetApiKey(string apiKeyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetApiKeyWithOptions(apiKeyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified authentication credential API key.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetApiKeyResponse
        /// </returns>
        public async Task<GetApiKeyResponse> GetApiKeyAsync(string apiKeyId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetApiKeyWithOptionsAsync(apiKeyId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries seat details by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionSeatDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionSeatDetailsResponse
        /// </returns>
        public GetSubscriptionSeatDetailsResponse GetSubscriptionSeatDetailsWithOptions(GetSubscriptionSeatDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryAssigned))
            {
                query["QueryAssigned"] = request.QueryAssigned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatId))
            {
                query["SeatId"] = request.SeatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatType))
            {
                query["SeatType"] = request.SeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListStr))
            {
                query["StatusListStr"] = request.StatusListStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionSeatDetails",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/seat-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionSeatDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries seat details by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionSeatDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionSeatDetailsResponse
        /// </returns>
        public async Task<GetSubscriptionSeatDetailsResponse> GetSubscriptionSeatDetailsWithOptionsAsync(GetSubscriptionSeatDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUacAccountId))
            {
                query["CallerUacAccountId"] = request.CallerUacAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryAssigned))
            {
                query["QueryAssigned"] = request.QueryAssigned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatId))
            {
                query["SeatId"] = request.SeatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatType))
            {
                query["SeatType"] = request.SeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListStr))
            {
                query["StatusListStr"] = request.StatusListStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionSeatDetails",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/seat-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionSeatDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries seat details by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionSeatDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionSeatDetailsResponse
        /// </returns>
        public GetSubscriptionSeatDetailsResponse GetSubscriptionSeatDetails(GetSubscriptionSeatDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubscriptionSeatDetailsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries seat details by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionSeatDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionSeatDetailsResponse
        /// </returns>
        public async Task<GetSubscriptionSeatDetailsResponse> GetSubscriptionSeatDetailsAsync(GetSubscriptionSeatDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubscriptionSeatDetailsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of authentication credential API Key information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public ListApiKeysResponse ListApiKeysWithOptions(ListApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiKeys",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of authentication credential API Key information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public async Task<ListApiKeysResponse> ListApiKeysWithOptionsAsync(ListApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiKeys",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of authentication credential API Key information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public ListApiKeysResponse ListApiKeys(ListApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApiKeysWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of authentication credential API Key information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public async Task<ListApiKeysResponse> ListApiKeysAsync(ListApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApiKeysWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of business workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of business workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of business workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of business workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API key value changes. The API key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public ResetApiKeyResponse ResetApiKeyWithOptions(string apiKeyId, ResetApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId) + "/reset",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API key value changes. The API key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public async Task<ResetApiKeyResponse> ResetApiKeyWithOptionsAsync(string apiKeyId, ResetApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId) + "/reset",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API key value changes. The API key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public ResetApiKeyResponse ResetApiKey(string apiKeyId, ResetApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResetApiKeyWithOptions(apiKeyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API key value changes. The API key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public async Task<ResetApiKeyResponse> ResetApiKeyAsync(string apiKeyId, ResetApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResetApiKeyWithOptionsAsync(apiKeyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the information of an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyResponse
        /// </returns>
        public UpdateApiKeyResponse UpdateApiKeyWithOptions(string apiKeyId, UpdateApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auth))
            {
                body["auth"] = request.Auth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the information of an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyResponse
        /// </returns>
        public async Task<UpdateApiKeyResponse> UpdateApiKeyWithOptionsAsync(string apiKeyId, UpdateApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auth))
            {
                body["auth"] = request.Auth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/modelstudio/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(apiKeyId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the information of an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyResponse
        /// </returns>
        public UpdateApiKeyResponse UpdateApiKey(string apiKeyId, UpdateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApiKeyWithOptions(apiKeyId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits the information of an authentication credential API key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyResponse
        /// </returns>
        public async Task<UpdateApiKeyResponse> UpdateApiKeyAsync(string apiKeyId, UpdateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApiKeyWithOptionsAsync(apiKeyId, request, headers, runtime);
        }

    }
}
