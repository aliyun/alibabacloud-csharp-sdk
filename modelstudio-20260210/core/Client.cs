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
        /// <para>Assigns seats in batches to the member level.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatType))
            {
                query["SeatType"] = request.SeatType;
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
        /// <para>Assigns seats in batches to the member level.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatType))
            {
                query["SeatType"] = request.SeatType;
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
        /// <para>Assigns seats in batches to the member level.</para>
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
        /// <para>Assigns seats in batches to the member level.</para>
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
        /// <para>Revokes member-level seats in batches.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchRevokeSeatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokeSeatsResponse
        /// </returns>
        public BatchRevokeSeatsResponse BatchRevokeSeatsWithOptions(BatchRevokeSeatsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchRevokeSeatsShrinkRequest request = new BatchRevokeSeatsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Items))
            {
                request.ItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Items, "Items", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemsShrink))
            {
                query["Items"] = request.ItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRevokeSeats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/seat-revocations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRevokeSeatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes member-level seats in batches.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchRevokeSeatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokeSeatsResponse
        /// </returns>
        public async Task<BatchRevokeSeatsResponse> BatchRevokeSeatsWithOptionsAsync(BatchRevokeSeatsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchRevokeSeatsShrinkRequest request = new BatchRevokeSeatsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Items))
            {
                request.ItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Items, "Items", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemsShrink))
            {
                query["Items"] = request.ItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRevokeSeats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/seat-revocations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRevokeSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes member-level seats in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRevokeSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokeSeatsResponse
        /// </returns>
        public BatchRevokeSeatsResponse BatchRevokeSeats(BatchRevokeSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchRevokeSeatsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes member-level seats in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRevokeSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokeSeatsResponse
        /// </returns>
        public async Task<BatchRevokeSeatsResponse> BatchRevokeSeatsAsync(BatchRevokeSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchRevokeSeatsWithOptionsAsync(request, headers, runtime);
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
        /// <para>Creates a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A user can have only one valid invitation link at a time.
        /// If the user already has a valid invitation link, this operation returns the existing link.
        /// To create a new link, call the RevokeTokenPlanInviteLink operation to invalidate the current link first.
        /// This operation returns only the generated token. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the China site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTokenPlanInviteLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanInviteLinkResponse
        /// </returns>
        public CreateTokenPlanInviteLinkResponse CreateTokenPlanInviteLinkWithOptions(CreateTokenPlanInviteLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireType))
            {
                query["ExpireType"] = request.ExpireType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSource))
            {
                query["SsoSource"] = request.SsoSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTokenPlanInviteLink",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/link/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenPlanInviteLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A user can have only one valid invitation link at a time.
        /// If the user already has a valid invitation link, this operation returns the existing link.
        /// To create a new link, call the RevokeTokenPlanInviteLink operation to invalidate the current link first.
        /// This operation returns only the generated token. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the China site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTokenPlanInviteLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanInviteLinkResponse
        /// </returns>
        public async Task<CreateTokenPlanInviteLinkResponse> CreateTokenPlanInviteLinkWithOptionsAsync(CreateTokenPlanInviteLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireType))
            {
                query["ExpireType"] = request.ExpireType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSource))
            {
                query["SsoSource"] = request.SsoSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTokenPlanInviteLink",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/link/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenPlanInviteLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A user can have only one valid invitation link at a time.
        /// If the user already has a valid invitation link, this operation returns the existing link.
        /// To create a new link, call the RevokeTokenPlanInviteLink operation to invalidate the current link first.
        /// This operation returns only the generated token. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the China site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTokenPlanInviteLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanInviteLinkResponse
        /// </returns>
        public CreateTokenPlanInviteLinkResponse CreateTokenPlanInviteLink(CreateTokenPlanInviteLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTokenPlanInviteLinkWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A user can have only one valid invitation link at a time.
        /// If the user already has a valid invitation link, this operation returns the existing link.
        /// To create a new link, call the RevokeTokenPlanInviteLink operation to invalidate the current link first.
        /// This operation returns only the generated token. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the China site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTokenPlanInviteLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenPlanInviteLinkResponse
        /// </returns>
        public async Task<CreateTokenPlanInviteLinkResponse> CreateTokenPlanInviteLinkAsync(CreateTokenPlanInviteLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTokenPlanInviteLinkWithOptionsAsync(request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
        /// <para>Retrieves information about a specified organization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves information about a specified organization by OrgId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOrganizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationResponse
        /// </returns>
        public GetOrganizationResponse GetOrganizationWithOptions(GetOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganization",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a specified organization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves information about a specified organization by OrgId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOrganizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationResponse
        /// </returns>
        public async Task<GetOrganizationResponse> GetOrganizationWithOptionsAsync(GetOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganization",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a specified organization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves information about a specified organization by OrgId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOrganizationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationResponse
        /// </returns>
        public GetOrganizationResponse GetOrganization(GetOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrganizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a specified organization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves information about a specified organization by OrgId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOrganizationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationResponse
        /// </returns>
        public async Task<GetOrganizationResponse> GetOrganizationAsync(GetOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrganizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries organization member statistics information, including the total number of members, the number of administrators, the number of regular members, the number of members with allocated seats, and the number of members without allocated seats.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationMemberSeatStatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationMemberSeatStatsResponse
        /// </returns>
        public GetOrganizationMemberSeatStatsResponse GetOrganizationMemberSeatStatsWithOptions(GetOrganizationMemberSeatStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationMemberSeatStats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/member-seat-stats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationMemberSeatStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries organization member statistics information, including the total number of members, the number of administrators, the number of regular members, the number of members with allocated seats, and the number of members without allocated seats.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationMemberSeatStatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationMemberSeatStatsResponse
        /// </returns>
        public async Task<GetOrganizationMemberSeatStatsResponse> GetOrganizationMemberSeatStatsWithOptionsAsync(GetOrganizationMemberSeatStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationMemberSeatStats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/member-seat-stats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationMemberSeatStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries organization member statistics information, including the total number of members, the number of administrators, the number of regular members, the number of members with allocated seats, and the number of members without allocated seats.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationMemberSeatStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationMemberSeatStatsResponse
        /// </returns>
        public GetOrganizationMemberSeatStatsResponse GetOrganizationMemberSeatStats(GetOrganizationMemberSeatStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrganizationMemberSeatStatsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries organization member statistics information, including the total number of members, the number of administrators, the number of regular members, the number of members with allocated seats, and the number of members without allocated seats.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationMemberSeatStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationMemberSeatStatsResponse
        /// </returns>
        public async Task<GetOrganizationMemberSeatStatsResponse> GetOrganizationMemberSeatStatsAsync(GetOrganizationMemberSeatStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrganizationMemberSeatStatsWithOptionsAsync(request, headers, runtime);
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
        /// <para>Queries the number of members and seats for member management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionStatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionStatsResponse
        /// </returns>
        public GetSubscriptionStatsResponse GetSubscriptionStatsWithOptions(GetSubscriptionStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionStats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/stats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of members and seats for member management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionStatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionStatsResponse
        /// </returns>
        public async Task<GetSubscriptionStatsResponse> GetSubscriptionStatsWithOptionsAsync(GetSubscriptionStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionStats",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/stats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of members and seats for member management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionStatsResponse
        /// </returns>
        public GetSubscriptionStatsResponse GetSubscriptionStats(GetSubscriptionStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubscriptionStatsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of members and seats for member management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubscriptionStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionStatsResponse
        /// </returns>
        public async Task<GetSubscriptionStatsResponse> GetSubscriptionStatsAsync(GetSubscriptionStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubscriptionStatsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan account details and organization information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the TokenPlan management platform account information when the user is logged in.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanAccountDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanAccountDetailResponse
        /// </returns>
        public GetTokenPlanAccountDetailResponse GetTokenPlanAccountDetailWithOptions(GetTokenPlanAccountDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenPlanAccountDetail",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/account",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenPlanAccountDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan account details and organization information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the TokenPlan management platform account information when the user is logged in.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanAccountDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanAccountDetailResponse
        /// </returns>
        public async Task<GetTokenPlanAccountDetailResponse> GetTokenPlanAccountDetailWithOptionsAsync(GetTokenPlanAccountDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenPlanAccountDetail",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/account",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenPlanAccountDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan account details and organization information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the TokenPlan management platform account information when the user is logged in.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanAccountDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanAccountDetailResponse
        /// </returns>
        public GetTokenPlanAccountDetailResponse GetTokenPlanAccountDetail(GetTokenPlanAccountDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenPlanAccountDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan account details and organization information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the TokenPlan management platform account information when the user is logged in.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanAccountDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanAccountDetailResponse
        /// </returns>
        public async Task<GetTokenPlanAccountDetailResponse> GetTokenPlanAccountDetailAsync(GetTokenPlanAccountDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenPlanAccountDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns only the generated token and expiration time. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the international site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanInviteLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanInviteLinkResponse
        /// </returns>
        public GetTokenPlanInviteLinkResponse GetTokenPlanInviteLinkWithOptions(GetTokenPlanInviteLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenPlanInviteLink",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/link/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenPlanInviteLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns only the generated token and expiration time. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the international site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanInviteLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanInviteLinkResponse
        /// </returns>
        public async Task<GetTokenPlanInviteLinkResponse> GetTokenPlanInviteLinkWithOptionsAsync(GetTokenPlanInviteLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenPlanInviteLink",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/link/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenPlanInviteLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns only the generated token and expiration time. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the international site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanInviteLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanInviteLinkResponse
        /// </returns>
        public GetTokenPlanInviteLinkResponse GetTokenPlanInviteLink(GetTokenPlanInviteLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenPlanInviteLinkWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns only the generated token and expiration time. The invitation link is assembled in the following format: <c>https://{host}/accept-invite?token=[token]&amp;orgId=[orgId]</c></para>
        /// <list type="bullet">
        /// <item><description>For the China site, the host is tokenplan-enterprise.bailian.aliyunportal.com.</description></item>
        /// <item><description>For the international site, the host is tokenplan-enterprise.modelstudio.aliyunportal.com.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenPlanInviteLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanInviteLinkResponse
        /// </returns>
        public async Task<GetTokenPlanInviteLinkResponse> GetTokenPlanInviteLinkAsync(GetTokenPlanInviteLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenPlanInviteLinkWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public GetTokenPlanOrgInviteConfigResponse GetTokenPlanOrgInviteConfigWithOptions(GetTokenPlanOrgInviteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenPlanOrgInviteConfig",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/config/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenPlanOrgInviteConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public async Task<GetTokenPlanOrgInviteConfigResponse> GetTokenPlanOrgInviteConfigWithOptionsAsync(GetTokenPlanOrgInviteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenPlanOrgInviteConfig",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/config/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenPlanOrgInviteConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public GetTokenPlanOrgInviteConfigResponse GetTokenPlanOrgInviteConfig(GetTokenPlanOrgInviteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenPlanOrgInviteConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the TokenPlan member invitation configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public async Task<GetTokenPlanOrgInviteConfigResponse> GetTokenPlanOrgInviteConfigAsync(GetTokenPlanOrgInviteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenPlanOrgInviteConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of API key authentication credentials.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
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
        /// <para>Retrieves a list of API key authentication credentials.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
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
        /// <para>Retrieves a list of API key authentication credentials.</para>
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
        /// <para>Retrieves a list of API key authentication credentials.</para>
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
        /// <para>Queries the list of organization members including seat information. Supports filtering by name, status, and seat assignment, and supports pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationMembersResponse
        /// </returns>
        public ListOrganizationMembersResponse ListOrganizationMembersWithOptions(ListOrganizationMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasSeat))
            {
                query["HasSeat"] = request.HasSeat;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationMembers",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of organization members including seat information. Supports filtering by name, status, and seat assignment, and supports pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationMembersResponse
        /// </returns>
        public async Task<ListOrganizationMembersResponse> ListOrganizationMembersWithOptionsAsync(ListOrganizationMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasSeat))
            {
                query["HasSeat"] = request.HasSeat;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationMembers",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of organization members including seat information. Supports filtering by name, status, and seat assignment, and supports pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationMembersResponse
        /// </returns>
        public ListOrganizationMembersResponse ListOrganizationMembers(ListOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOrganizationMembersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of organization members including seat information. Supports filtering by name, status, and seat assignment, and supports pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationMembersResponse
        /// </returns>
        public async Task<ListOrganizationMembersResponse> ListOrganizationMembersAsync(ListOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOrganizationMembersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of shared packages by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionSharedPackagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionSharedPackagesResponse
        /// </returns>
        public ListSubscriptionSharedPackagesResponse ListSubscriptionSharedPackagesWithOptions(ListSubscriptionSharedPackagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionSharedPackages",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/shared-packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionSharedPackagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of shared packages by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionSharedPackagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionSharedPackagesResponse
        /// </returns>
        public async Task<ListSubscriptionSharedPackagesResponse> ListSubscriptionSharedPackagesWithOptionsAsync(ListSubscriptionSharedPackagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionSharedPackages",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/subscription/shared-packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionSharedPackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of shared packages by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionSharedPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionSharedPackagesResponse
        /// </returns>
        public ListSubscriptionSharedPackagesResponse ListSubscriptionSharedPackages(ListSubscriptionSharedPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubscriptionSharedPackagesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of shared packages by paging.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubscriptionSharedPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubscriptionSharedPackagesResponse
        /// </returns>
        public async Task<ListSubscriptionSharedPackagesResponse> ListSubscriptionSharedPackagesAsync(ListSubscriptionSharedPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubscriptionSharedPackagesWithOptionsAsync(request, headers, runtime);
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
        /// <para>Removes organization members. Before removal, checks whether the member holds a seat. If the member holds a seat, the removal is rejected.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOrganizationMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveOrganizationMemberResponse
        /// </returns>
        public RemoveOrganizationMemberResponse RemoveOrganizationMemberWithOptions(RemoveOrganizationMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveOrganizationMember",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/member-removals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveOrganizationMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes organization members. Before removal, checks whether the member holds a seat. If the member holds a seat, the removal is rejected.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOrganizationMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveOrganizationMemberResponse
        /// </returns>
        public async Task<RemoveOrganizationMemberResponse> RemoveOrganizationMemberWithOptionsAsync(RemoveOrganizationMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveOrganizationMember",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/member-removals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveOrganizationMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes organization members. Before removal, checks whether the member holds a seat. If the member holds a seat, the removal is rejected.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOrganizationMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveOrganizationMemberResponse
        /// </returns>
        public RemoveOrganizationMemberResponse RemoveOrganizationMember(RemoveOrganizationMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveOrganizationMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes organization members. Before removal, checks whether the member holds a seat. If the member holds a seat, the removal is rejected.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveOrganizationMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveOrganizationMemberResponse
        /// </returns>
        public async Task<RemoveOrganizationMemberResponse> RemoveOrganizationMemberAsync(RemoveOrganizationMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveOrganizationMemberWithOptionsAsync(request, headers, runtime);
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
        /// <para>Revokes a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenPlanInviteLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenPlanInviteLinkResponse
        /// </returns>
        public RevokeTokenPlanInviteLinkResponse RevokeTokenPlanInviteLinkWithOptions(RevokeTokenPlanInviteLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeTokenPlanInviteLink",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/link/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeTokenPlanInviteLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenPlanInviteLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenPlanInviteLinkResponse
        /// </returns>
        public async Task<RevokeTokenPlanInviteLinkResponse> RevokeTokenPlanInviteLinkWithOptionsAsync(RevokeTokenPlanInviteLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeTokenPlanInviteLink",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/link/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeTokenPlanInviteLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenPlanInviteLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenPlanInviteLinkResponse
        /// </returns>
        public RevokeTokenPlanInviteLinkResponse RevokeTokenPlanInviteLink(RevokeTokenPlanInviteLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeTokenPlanInviteLinkWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a TokenPlan member invitation link.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenPlanInviteLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenPlanInviteLinkResponse
        /// </returns>
        public async Task<RevokeTokenPlanInviteLinkResponse> RevokeTokenPlanInviteLinkAsync(RevokeTokenPlanInviteLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeTokenPlanInviteLinkWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a UAC API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API Key value changes. The API Key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateTokenPlanKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RotateTokenPlanKeyResponse
        /// </returns>
        public RotateTokenPlanKeyResponse RotateTokenPlanKeyWithOptions(RotateTokenPlanKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["ApiKeyId"] = request.ApiKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RotateTokenPlanKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/api-key-rotations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RotateTokenPlanKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a UAC API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API Key value changes. The API Key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateTokenPlanKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RotateTokenPlanKeyResponse
        /// </returns>
        public async Task<RotateTokenPlanKeyResponse> RotateTokenPlanKeyWithOptionsAsync(RotateTokenPlanKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["ApiKeyId"] = request.ApiKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RotateTokenPlanKey",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/api-key-rotations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RotateTokenPlanKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a UAC API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API Key value changes. The API Key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateTokenPlanKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// RotateTokenPlanKeyResponse
        /// </returns>
        public RotateTokenPlanKeyResponse RotateTokenPlanKey(RotateTokenPlanKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RotateTokenPlanKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a UAC API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only the API Key value changes. The API Key ID remains unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateTokenPlanKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// RotateTokenPlanKeyResponse
        /// </returns>
        public async Task<RotateTokenPlanKeyResponse> RotateTokenPlanKeyAsync(RotateTokenPlanKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RotateTokenPlanKeyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the member invitation settings for a TokenPlan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public SetTokenPlanOrgInviteConfigResponse SetTokenPlanOrgInviteConfigWithOptions(SetTokenPlanOrgInviteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRoleId))
            {
                query["DefaultRoleId"] = request.DefaultRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatAssignStrategy))
            {
                query["SeatAssignStrategy"] = request.SeatAssignStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTokenPlanOrgInviteConfig",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/config/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTokenPlanOrgInviteConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the member invitation settings for a TokenPlan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public async Task<SetTokenPlanOrgInviteConfigResponse> SetTokenPlanOrgInviteConfigWithOptionsAsync(SetTokenPlanOrgInviteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRoleId))
            {
                query["DefaultRoleId"] = request.DefaultRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatAssignStrategy))
            {
                query["SeatAssignStrategy"] = request.SeatAssignStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTokenPlanOrgInviteConfig",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/invite/config/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTokenPlanOrgInviteConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the member invitation settings for a TokenPlan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public SetTokenPlanOrgInviteConfigResponse SetTokenPlanOrgInviteConfig(SetTokenPlanOrgInviteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SetTokenPlanOrgInviteConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the member invitation settings for a TokenPlan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTokenPlanOrgInviteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTokenPlanOrgInviteConfigResponse
        /// </returns>
        public async Task<SetTokenPlanOrgInviteConfigResponse> SetTokenPlanOrgInviteConfigAsync(SetTokenPlanOrgInviteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SetTokenPlanOrgInviteConfigWithOptionsAsync(request, headers, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies organization information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationResponse
        /// </returns>
        public UpdateOrganizationResponse UpdateOrganizationWithOptions(UpdateOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganization",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies organization information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationResponse
        /// </returns>
        public async Task<UpdateOrganizationResponse> UpdateOrganizationWithOptionsAsync(UpdateOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganization",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies organization information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationResponse
        /// </returns>
        public UpdateOrganizationResponse UpdateOrganization(UpdateOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOrganizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies organization information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationResponse
        /// </returns>
        public async Task<UpdateOrganizationResponse> UpdateOrganizationAsync(UpdateOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOrganizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织成员角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationMemberResponse
        /// </returns>
        public UpdateOrganizationMemberResponse UpdateOrganizationMemberWithOptions(UpdateOrganizationMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRoleCode))
            {
                query["NewRoleCode"] = request.NewRoleCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationMember",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/members/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织成员角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationMemberResponse
        /// </returns>
        public async Task<UpdateOrganizationMemberResponse> UpdateOrganizationMemberWithOptionsAsync(UpdateOrganizationMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRoleCode))
            {
                query["NewRoleCode"] = request.NewRoleCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOrganizationMember",
                Version = "2026-02-10",
                Protocol = "HTTPS",
                Pathname = "/tokenplan/organization/members/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织成员角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationMemberResponse
        /// </returns>
        public UpdateOrganizationMemberResponse UpdateOrganizationMember(UpdateOrganizationMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOrganizationMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织成员角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOrganizationMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOrganizationMemberResponse
        /// </returns>
        public async Task<UpdateOrganizationMemberResponse> UpdateOrganizationMemberAsync(UpdateOrganizationMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOrganizationMemberWithOptionsAsync(request, headers, runtime);
        }

    }
}
