// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dataphin_public20230630.Models;

namespace AlibabaCloud.SDK.Dataphin_public20230630
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dataphin-public", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>新增租户成员</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddTenantMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersResponse
        /// </returns>
        public AddTenantMembersResponse AddTenantMembersWithOptions(AddTenantMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTenantMembersShrinkRequest request = new AddTenantMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddCommand))
            {
                request.AddCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddCommand, "AddCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddCommandShrink))
            {
                body["AddCommand"] = request.AddCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTenantMembers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTenantMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增租户成员</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddTenantMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersResponse
        /// </returns>
        public async Task<AddTenantMembersResponse> AddTenantMembersWithOptionsAsync(AddTenantMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTenantMembersShrinkRequest request = new AddTenantMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddCommand))
            {
                request.AddCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddCommand, "AddCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddCommandShrink))
            {
                body["AddCommand"] = request.AddCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTenantMembers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTenantMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增租户成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTenantMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersResponse
        /// </returns>
        public AddTenantMembersResponse AddTenantMembers(AddTenantMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTenantMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增租户成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTenantMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersResponse
        /// </returns>
        public async Task<AddTenantMembersResponse> AddTenantMembersAsync(AddTenantMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTenantMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过原始用户添加租户成员.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddTenantMembersBySourceUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersBySourceUserResponse
        /// </returns>
        public AddTenantMembersBySourceUserResponse AddTenantMembersBySourceUserWithOptions(AddTenantMembersBySourceUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTenantMembersBySourceUserShrinkRequest request = new AddTenantMembersBySourceUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddCommand))
            {
                request.AddCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddCommand, "AddCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddCommandShrink))
            {
                body["AddCommand"] = request.AddCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTenantMembersBySourceUser",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTenantMembersBySourceUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过原始用户添加租户成员.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddTenantMembersBySourceUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersBySourceUserResponse
        /// </returns>
        public async Task<AddTenantMembersBySourceUserResponse> AddTenantMembersBySourceUserWithOptionsAsync(AddTenantMembersBySourceUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTenantMembersBySourceUserShrinkRequest request = new AddTenantMembersBySourceUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddCommand))
            {
                request.AddCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddCommand, "AddCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddCommandShrink))
            {
                body["AddCommand"] = request.AddCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTenantMembersBySourceUser",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTenantMembersBySourceUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过原始用户添加租户成员.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTenantMembersBySourceUserRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersBySourceUserResponse
        /// </returns>
        public AddTenantMembersBySourceUserResponse AddTenantMembersBySourceUser(AddTenantMembersBySourceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTenantMembersBySourceUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过原始用户添加租户成员.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTenantMembersBySourceUserRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTenantMembersBySourceUserResponse
        /// </returns>
        public async Task<AddTenantMembersBySourceUserResponse> AddTenantMembersBySourceUserAsync(AddTenantMembersBySourceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTenantMembersBySourceUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddUserGroupMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserGroupMemberResponse
        /// </returns>
        public AddUserGroupMemberResponse AddUserGroupMemberWithOptions(AddUserGroupMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddUserGroupMemberShrinkRequest request = new AddUserGroupMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddCommand))
            {
                request.AddCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddCommand, "AddCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddCommandShrink))
            {
                body["AddCommand"] = request.AddCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserGroupMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserGroupMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddUserGroupMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserGroupMemberResponse
        /// </returns>
        public async Task<AddUserGroupMemberResponse> AddUserGroupMemberWithOptionsAsync(AddUserGroupMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddUserGroupMemberShrinkRequest request = new AddUserGroupMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddCommand))
            {
                request.AddCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddCommand, "AddCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddCommandShrink))
            {
                body["AddCommand"] = request.AddCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserGroupMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserGroupMemberResponse
        /// </returns>
        public AddUserGroupMemberResponse AddUserGroupMember(AddUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserGroupMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserGroupMemberResponse
        /// </returns>
        public async Task<AddUserGroupMemberResponse> AddUserGroupMemberAsync(AddUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserGroupMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查数据源连通性</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckDataSourceConnectivityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityResponse
        /// </returns>
        public CheckDataSourceConnectivityResponse CheckDataSourceConnectivityWithOptions(CheckDataSourceConnectivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckDataSourceConnectivityShrinkRequest request = new CheckDataSourceConnectivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckCommand))
            {
                request.CheckCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckCommand, "CheckCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckCommandShrink))
            {
                body["CheckCommand"] = request.CheckCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDataSourceConnectivity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDataSourceConnectivityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查数据源连通性</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckDataSourceConnectivityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityResponse
        /// </returns>
        public async Task<CheckDataSourceConnectivityResponse> CheckDataSourceConnectivityWithOptionsAsync(CheckDataSourceConnectivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckDataSourceConnectivityShrinkRequest request = new CheckDataSourceConnectivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckCommand))
            {
                request.CheckCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckCommand, "CheckCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckCommandShrink))
            {
                body["CheckCommand"] = request.CheckCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDataSourceConnectivity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDataSourceConnectivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查数据源连通性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDataSourceConnectivityRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityResponse
        /// </returns>
        public CheckDataSourceConnectivityResponse CheckDataSourceConnectivity(CheckDataSourceConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDataSourceConnectivityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查数据源连通性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDataSourceConnectivityRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityResponse
        /// </returns>
        public async Task<CheckDataSourceConnectivityResponse> CheckDataSourceConnectivityAsync(CheckDataSourceConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDataSourceConnectivityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查已创建的数据源是否正常连通</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDataSourceConnectivityByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityByIdResponse
        /// </returns>
        public CheckDataSourceConnectivityByIdResponse CheckDataSourceConnectivityByIdWithOptions(CheckDataSourceConnectivityByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDataSourceConnectivityById",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDataSourceConnectivityByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查已创建的数据源是否正常连通</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDataSourceConnectivityByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityByIdResponse
        /// </returns>
        public async Task<CheckDataSourceConnectivityByIdResponse> CheckDataSourceConnectivityByIdWithOptionsAsync(CheckDataSourceConnectivityByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDataSourceConnectivityById",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDataSourceConnectivityByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查已创建的数据源是否正常连通</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDataSourceConnectivityByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityByIdResponse
        /// </returns>
        public CheckDataSourceConnectivityByIdResponse CheckDataSourceConnectivityById(CheckDataSourceConnectivityByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDataSourceConnectivityByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查已创建的数据源是否正常连通</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDataSourceConnectivityByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDataSourceConnectivityByIdResponse
        /// </returns>
        public async Task<CheckDataSourceConnectivityByIdResponse> CheckDataSourceConnectivityByIdAsync(CheckDataSourceConnectivityByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDataSourceConnectivityByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验用户是否有指定资源权限点.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckResourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResourcePermissionResponse
        /// </returns>
        public CheckResourcePermissionResponse CheckResourcePermissionWithOptions(CheckResourcePermissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckResourcePermissionShrinkRequest request = new CheckResourcePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckCommand))
            {
                request.CheckCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckCommand, "CheckCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckCommandShrink))
            {
                body["CheckCommand"] = request.CheckCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResourcePermission",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourcePermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验用户是否有指定资源权限点.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CheckResourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResourcePermissionResponse
        /// </returns>
        public async Task<CheckResourcePermissionResponse> CheckResourcePermissionWithOptionsAsync(CheckResourcePermissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckResourcePermissionShrinkRequest request = new CheckResourcePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckCommand))
            {
                request.CheckCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckCommand, "CheckCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckCommandShrink))
            {
                body["CheckCommand"] = request.CheckCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResourcePermission",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourcePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验用户是否有指定资源权限点.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResourcePermissionResponse
        /// </returns>
        public CheckResourcePermissionResponse CheckResourcePermission(CheckResourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResourcePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验用户是否有指定资源权限点.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResourcePermissionResponse
        /// </returns>
        public async Task<CheckResourcePermissionResponse> CheckResourcePermissionAsync(CheckResourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResourcePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdHocFileResponse
        /// </returns>
        public CreateAdHocFileResponse CreateAdHocFileWithOptions(CreateAdHocFileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAdHocFileShrinkRequest request = new CreateAdHocFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdHocFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdHocFileResponse
        /// </returns>
        public async Task<CreateAdHocFileResponse> CreateAdHocFileWithOptionsAsync(CreateAdHocFileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAdHocFileShrinkRequest request = new CreateAdHocFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdHocFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdHocFileResponse
        /// </returns>
        public CreateAdHocFileResponse CreateAdHocFile(CreateAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAdHocFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdHocFileResponse
        /// </returns>
        public async Task<CreateAdHocFileResponse> CreateAdHocFileAsync(CreateAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAdHocFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchTaskResponse
        /// </returns>
        public CreateBatchTaskResponse CreateBatchTaskWithOptions(CreateBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBatchTaskShrinkRequest request = new CreateBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchTaskResponse
        /// </returns>
        public async Task<CreateBatchTaskResponse> CreateBatchTaskWithOptionsAsync(CreateBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBatchTaskShrinkRequest request = new CreateBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchTaskResponse
        /// </returns>
        public CreateBatchTaskResponse CreateBatchTask(CreateBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBatchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBatchTaskResponse
        /// </returns>
        public async Task<CreateBatchTaskResponse> CreateBatchTaskAsync(CreateBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBatchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizEntityResponse
        /// </returns>
        public CreateBizEntityResponse CreateBizEntityWithOptions(CreateBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBizEntityShrinkRequest request = new CreateBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizEntityResponse
        /// </returns>
        public async Task<CreateBizEntityResponse> CreateBizEntityWithOptionsAsync(CreateBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBizEntityShrinkRequest request = new CreateBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizEntityResponse
        /// </returns>
        public CreateBizEntityResponse CreateBizEntity(CreateBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBizEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizEntityResponse
        /// </returns>
        public async Task<CreateBizEntityResponse> CreateBizEntityAsync(CreateBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBizEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据板块。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBizUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizUnitResponse
        /// </returns>
        public CreateBizUnitResponse CreateBizUnitWithOptions(CreateBizUnitRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBizUnitShrinkRequest request = new CreateBizUnitShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizUnit",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizUnitResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据板块。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBizUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBizUnitResponse
        /// </returns>
        public async Task<CreateBizUnitResponse> CreateBizUnitWithOptionsAsync(CreateBizUnitRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBizUnitShrinkRequest request = new CreateBizUnitShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBizUnit",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBizUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizUnitResponse
        /// </returns>
        public CreateBizUnitResponse CreateBizUnit(CreateBizUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBizUnitWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBizUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBizUnitResponse
        /// </returns>
        public async Task<CreateBizUnitResponse> CreateBizUnitAsync(CreateBizUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBizUnitWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建主题域。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDomainResponse
        /// </returns>
        public CreateDataDomainResponse CreateDataDomainWithOptions(CreateDataDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataDomainShrinkRequest request = new CreateDataDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataDomain",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建主题域。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDomainResponse
        /// </returns>
        public async Task<CreateDataDomainResponse> CreateDataDomainWithOptionsAsync(CreateDataDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataDomainShrinkRequest request = new CreateDataDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataDomain",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDomainResponse
        /// </returns>
        public CreateDataDomainResponse CreateDataDomain(CreateDataDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDomainResponse
        /// </returns>
        public async Task<CreateDataDomainResponse> CreateDataDomainAsync(CreateDataDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建数据源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public CreateDataSourceResponse CreateDataSourceWithOptions(CreateDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataSourceShrinkRequest request = new CreateDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataSource",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建数据源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public async Task<CreateDataSourceResponse> CreateDataSourceWithOptionsAsync(CreateDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataSourceShrinkRequest request = new CreateDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataSource",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public CreateDirectoryResponse CreateDirectoryWithOptions(CreateDirectoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDirectoryShrinkRequest request = new CreateDirectoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDirectory",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public async Task<CreateDirectoryResponse> CreateDirectoryWithOptionsAsync(CreateDirectoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDirectoryShrinkRequest request = new CreateDirectoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDirectory",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDirectoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public async Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDirectoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用补数据接口 1.会生成补数据实例运行：影响相关产产出表数据 2.会进行任务运行：造成计算的费用以及存储的费用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNodeSupplementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNodeSupplementResponse
        /// </returns>
        public CreateNodeSupplementResponse CreateNodeSupplementWithOptions(CreateNodeSupplementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNodeSupplementShrinkRequest request = new CreateNodeSupplementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodeSupplement",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeSupplementResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用补数据接口 1.会生成补数据实例运行：影响相关产产出表数据 2.会进行任务运行：造成计算的费用以及存储的费用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNodeSupplementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNodeSupplementResponse
        /// </returns>
        public async Task<CreateNodeSupplementResponse> CreateNodeSupplementWithOptionsAsync(CreateNodeSupplementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNodeSupplementShrinkRequest request = new CreateNodeSupplementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodeSupplement",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeSupplementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用补数据接口 1.会生成补数据实例运行：影响相关产产出表数据 2.会进行任务运行：造成计算的费用以及存储的费用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNodeSupplementRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNodeSupplementResponse
        /// </returns>
        public CreateNodeSupplementResponse CreateNodeSupplement(CreateNodeSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNodeSupplementWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用补数据接口 1.会生成补数据实例运行：影响相关产产出表数据 2.会进行任务运行：造成计算的费用以及存储的费用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNodeSupplementRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNodeSupplementResponse
        /// </returns>
        public async Task<CreateNodeSupplementResponse> CreateNodeSupplementAsync(CreateNodeSupplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNodeSupplementWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集成任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePipelineNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineNodeResponse
        /// </returns>
        public CreatePipelineNodeResponse CreatePipelineNodeWithOptions(CreatePipelineNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePipelineNodeShrinkRequest request = new CreatePipelineNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreatePipelineNodeCommand))
            {
                request.CreatePipelineNodeCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreatePipelineNodeCommand, "CreatePipelineNodeCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatePipelineNodeCommandShrink))
            {
                body["CreatePipelineNodeCommand"] = request.CreatePipelineNodeCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集成任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePipelineNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineNodeResponse
        /// </returns>
        public async Task<CreatePipelineNodeResponse> CreatePipelineNodeWithOptionsAsync(CreatePipelineNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePipelineNodeShrinkRequest request = new CreatePipelineNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreatePipelineNodeCommand))
            {
                request.CreatePipelineNodeCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreatePipelineNodeCommand, "CreatePipelineNodeCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatePipelineNodeCommandShrink))
            {
                body["CreatePipelineNodeCommand"] = request.CreatePipelineNodeCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集成任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineNodeResponse
        /// </returns>
        public CreatePipelineNodeResponse CreatePipelineNode(CreatePipelineNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePipelineNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集成任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineNodeResponse
        /// </returns>
        public async Task<CreatePipelineNodeResponse> CreatePipelineNodeAsync(CreatePipelineNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePipelineNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流批一体任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateStreamBatchJobMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStreamBatchJobMappingResponse
        /// </returns>
        public CreateStreamBatchJobMappingResponse CreateStreamBatchJobMappingWithOptions(CreateStreamBatchJobMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStreamBatchJobMappingShrinkRequest request = new CreateStreamBatchJobMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamBatchJobMappingCreateCommand))
            {
                request.StreamBatchJobMappingCreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamBatchJobMappingCreateCommand, "StreamBatchJobMappingCreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamBatchJobMappingCreateCommandShrink))
            {
                body["StreamBatchJobMappingCreateCommand"] = request.StreamBatchJobMappingCreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStreamBatchJobMapping",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStreamBatchJobMappingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流批一体任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateStreamBatchJobMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStreamBatchJobMappingResponse
        /// </returns>
        public async Task<CreateStreamBatchJobMappingResponse> CreateStreamBatchJobMappingWithOptionsAsync(CreateStreamBatchJobMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStreamBatchJobMappingShrinkRequest request = new CreateStreamBatchJobMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamBatchJobMappingCreateCommand))
            {
                request.StreamBatchJobMappingCreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamBatchJobMappingCreateCommand, "StreamBatchJobMappingCreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamBatchJobMappingCreateCommandShrink))
            {
                body["StreamBatchJobMappingCreateCommand"] = request.StreamBatchJobMappingCreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStreamBatchJobMapping",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStreamBatchJobMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流批一体任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStreamBatchJobMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStreamBatchJobMappingResponse
        /// </returns>
        public CreateStreamBatchJobMappingResponse CreateStreamBatchJobMapping(CreateStreamBatchJobMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStreamBatchJobMappingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流批一体任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStreamBatchJobMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStreamBatchJobMappingResponse
        /// </returns>
        public async Task<CreateStreamBatchJobMappingResponse> CreateStreamBatchJobMappingAsync(CreateStreamBatchJobMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStreamBatchJobMappingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建用户组.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public CreateUserGroupResponse CreateUserGroupWithOptions(CreateUserGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserGroupShrinkRequest request = new CreateUserGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建用户组.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public async Task<CreateUserGroupResponse> CreateUserGroupWithOptionsAsync(CreateUserGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserGroupShrinkRequest request = new CreateUserGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateCommand))
            {
                request.CreateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateCommand, "CreateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCommandShrink))
            {
                body["CreateCommand"] = request.CreateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public async Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdHocFileResponse
        /// </returns>
        public DeleteAdHocFileResponse DeleteAdHocFileWithOptions(DeleteAdHocFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdHocFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdHocFileResponse
        /// </returns>
        public async Task<DeleteAdHocFileResponse> DeleteAdHocFileWithOptionsAsync(DeleteAdHocFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdHocFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdHocFileResponse
        /// </returns>
        public DeleteAdHocFileResponse DeleteAdHocFile(DeleteAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAdHocFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树即席查询文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdHocFileResponse
        /// </returns>
        public async Task<DeleteAdHocFileResponse> DeleteAdHocFileAsync(DeleteAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAdHocFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除离线计算任务，如果任务还没下线需要先下线再删除。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBatchTaskResponse
        /// </returns>
        public DeleteBatchTaskResponse DeleteBatchTaskWithOptions(DeleteBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteBatchTaskShrinkRequest request = new DeleteBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteCommand))
            {
                request.DeleteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteCommand, "DeleteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteCommandShrink))
            {
                body["DeleteCommand"] = request.DeleteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBatchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除离线计算任务，如果任务还没下线需要先下线再删除。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBatchTaskResponse
        /// </returns>
        public async Task<DeleteBatchTaskResponse> DeleteBatchTaskWithOptionsAsync(DeleteBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteBatchTaskShrinkRequest request = new DeleteBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteCommand))
            {
                request.DeleteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteCommand, "DeleteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteCommandShrink))
            {
                body["DeleteCommand"] = request.DeleteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBatchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除离线计算任务，如果任务还没下线需要先下线再删除。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBatchTaskResponse
        /// </returns>
        public DeleteBatchTaskResponse DeleteBatchTask(DeleteBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBatchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除离线计算任务，如果任务还没下线需要先下线再删除。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBatchTaskResponse
        /// </returns>
        public async Task<DeleteBatchTaskResponse> DeleteBatchTaskAsync(DeleteBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBatchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizEntityResponse
        /// </returns>
        public DeleteBizEntityResponse DeleteBizEntityWithOptions(DeleteBizEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUnitId))
            {
                query["BizUnitId"] = request.BizUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
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
                Action = "DeleteBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizEntityResponse
        /// </returns>
        public async Task<DeleteBizEntityResponse> DeleteBizEntityWithOptionsAsync(DeleteBizEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUnitId))
            {
                query["BizUnitId"] = request.BizUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
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
                Action = "DeleteBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizEntityResponse
        /// </returns>
        public DeleteBizEntityResponse DeleteBizEntity(DeleteBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBizEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizEntityResponse
        /// </returns>
        public async Task<DeleteBizEntityResponse> DeleteBizEntityAsync(DeleteBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBizEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizUnitResponse
        /// </returns>
        public DeleteBizUnitResponse DeleteBizUnitWithOptions(DeleteBizUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizUnit",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizUnitResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizUnitResponse
        /// </returns>
        public async Task<DeleteBizUnitResponse> DeleteBizUnitWithOptionsAsync(DeleteBizUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizUnit",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizUnitResponse
        /// </returns>
        public DeleteBizUnitResponse DeleteBizUnit(DeleteBizUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBizUnitWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBizUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBizUnitResponse
        /// </returns>
        public async Task<DeleteBizUnitResponse> DeleteBizUnitAsync(DeleteBizUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBizUnitWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataDomainResponse
        /// </returns>
        public DeleteDataDomainResponse DeleteDataDomainWithOptions(DeleteDataDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUnitId))
            {
                query["BizUnitId"] = request.BizUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataDomain",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataDomainResponse
        /// </returns>
        public async Task<DeleteDataDomainResponse> DeleteDataDomainWithOptionsAsync(DeleteDataDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUnitId))
            {
                query["BizUnitId"] = request.BizUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataDomain",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataDomainResponse
        /// </returns>
        public DeleteDataDomainResponse DeleteDataDomain(DeleteDataDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataDomainResponse
        /// </returns>
        public async Task<DeleteDataDomainResponse> DeleteDataDomainAsync(DeleteDataDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDataSourceShrinkRequest request = new DeleteDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteCommand))
            {
                request.DeleteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteCommand, "DeleteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteCommandShrink))
            {
                body["DeleteCommand"] = request.DeleteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDataSourceShrinkRequest request = new DeleteDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteCommand))
            {
                request.DeleteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteCommand, "DeleteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteCommandShrink))
            {
                body["DeleteCommand"] = request.DeleteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public DeleteDirectoryResponse DeleteDirectoryWithOptions(DeleteDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDirectory",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public async Task<DeleteDirectoryResponse> DeleteDirectoryWithOptionsAsync(DeleteDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDirectory",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDirectoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除菜单树文件目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public async Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDirectoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public DeleteUserGroupResponse DeleteUserGroupWithOptions(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public async Task<DeleteUserGroupResponse> DeleteUserGroupWithOptionsAsync(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExecuteAdHocTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAdHocTaskResponse
        /// </returns>
        public ExecuteAdHocTaskResponse ExecuteAdHocTaskWithOptions(ExecuteAdHocTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteAdHocTaskShrinkRequest request = new ExecuteAdHocTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteCommand))
            {
                request.ExecuteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteCommand, "ExecuteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteCommandShrink))
            {
                body["ExecuteCommand"] = request.ExecuteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteAdHocTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAdHocTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExecuteAdHocTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAdHocTaskResponse
        /// </returns>
        public async Task<ExecuteAdHocTaskResponse> ExecuteAdHocTaskWithOptionsAsync(ExecuteAdHocTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteAdHocTaskShrinkRequest request = new ExecuteAdHocTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteCommand))
            {
                request.ExecuteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteCommand, "ExecuteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteCommandShrink))
            {
                body["ExecuteCommand"] = request.ExecuteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteAdHocTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAdHocTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAdHocTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAdHocTaskResponse
        /// </returns>
        public ExecuteAdHocTaskResponse ExecuteAdHocTask(ExecuteAdHocTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteAdHocTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAdHocTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAdHocTaskResponse
        /// </returns>
        public async Task<ExecuteAdHocTaskResponse> ExecuteAdHocTaskAsync(ExecuteAdHocTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteAdHocTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行手动调度节点。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExecuteManualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteManualNodeResponse
        /// </returns>
        public ExecuteManualNodeResponse ExecuteManualNodeWithOptions(ExecuteManualNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteManualNodeShrinkRequest request = new ExecuteManualNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteCommand))
            {
                request.ExecuteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteCommand, "ExecuteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteCommandShrink))
            {
                body["ExecuteCommand"] = request.ExecuteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteManualNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteManualNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行手动调度节点。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExecuteManualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteManualNodeResponse
        /// </returns>
        public async Task<ExecuteManualNodeResponse> ExecuteManualNodeWithOptionsAsync(ExecuteManualNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteManualNodeShrinkRequest request = new ExecuteManualNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteCommand))
            {
                request.ExecuteCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteCommand, "ExecuteCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteCommandShrink))
            {
                body["ExecuteCommand"] = request.ExecuteCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteManualNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteManualNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行手动调度节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteManualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteManualNodeResponse
        /// </returns>
        public ExecuteManualNodeResponse ExecuteManualNode(ExecuteManualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteManualNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行手动调度节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteManualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteManualNodeResponse
        /// </returns>
        public async Task<ExecuteManualNodeResponse> ExecuteManualNodeAsync(ExecuteManualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteManualNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑下游(修复链路数据), 支持强制重跑下游。影响范围: 1. 会产生计算成本；2. 会影响数据产出</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FixDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FixDataResponse
        /// </returns>
        public FixDataResponse FixDataWithOptions(FixDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FixDataShrinkRequest request = new FixDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FixDataCommand))
            {
                request.FixDataCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FixDataCommand, "FixDataCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixDataCommandShrink))
            {
                body["FixDataCommand"] = request.FixDataCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FixData",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FixDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑下游(修复链路数据), 支持强制重跑下游。影响范围: 1. 会产生计算成本；2. 会影响数据产出</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FixDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FixDataResponse
        /// </returns>
        public async Task<FixDataResponse> FixDataWithOptionsAsync(FixDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FixDataShrinkRequest request = new FixDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FixDataCommand))
            {
                request.FixDataCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FixDataCommand, "FixDataCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixDataCommandShrink))
            {
                body["FixDataCommand"] = request.FixDataCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FixData",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FixDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑下游(修复链路数据), 支持强制重跑下游。影响范围: 1. 会产生计算成本；2. 会影响数据产出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FixDataRequest
        /// </param>
        /// 
        /// <returns>
        /// FixDataResponse
        /// </returns>
        public FixDataResponse FixData(FixDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FixDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑下游(修复链路数据), 支持强制重跑下游。影响范围: 1. 会产生计算成本；2. 会影响数据产出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FixDataRequest
        /// </param>
        /// 
        /// <returns>
        /// FixDataResponse
        /// </returns>
        public async Task<FixDataResponse> FixDataAsync(FixDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FixDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocFileResponse
        /// </returns>
        public GetAdHocFileResponse GetAdHocFileWithOptions(GetAdHocFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdHocFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocFileResponse
        /// </returns>
        public async Task<GetAdHocFileResponse> GetAdHocFileWithOptionsAsync(GetAdHocFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdHocFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocFileResponse
        /// </returns>
        public GetAdHocFileResponse GetAdHocFile(GetAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAdHocFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocFileResponse
        /// </returns>
        public async Task<GetAdHocFileResponse> GetAdHocFileAsync(GetAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAdHocFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询任务运行日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskLogResponse
        /// </returns>
        public GetAdHocTaskLogResponse GetAdHocTaskLogWithOptions(GetAdHocTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTaskId))
            {
                query["SubTaskId"] = request.SubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdHocTaskLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdHocTaskLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询任务运行日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskLogResponse
        /// </returns>
        public async Task<GetAdHocTaskLogResponse> GetAdHocTaskLogWithOptionsAsync(GetAdHocTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTaskId))
            {
                query["SubTaskId"] = request.SubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdHocTaskLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdHocTaskLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询任务运行日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskLogResponse
        /// </returns>
        public GetAdHocTaskLogResponse GetAdHocTaskLog(GetAdHocTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAdHocTaskLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询任务运行日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskLogResponse
        /// </returns>
        public async Task<GetAdHocTaskLogResponse> GetAdHocTaskLogAsync(GetAdHocTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAdHocTaskLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询的任务运行结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskResultResponse
        /// </returns>
        public GetAdHocTaskResultResponse GetAdHocTaskResultWithOptions(GetAdHocTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTaskId))
            {
                query["SubTaskId"] = request.SubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdHocTaskResult",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdHocTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询的任务运行结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskResultResponse
        /// </returns>
        public async Task<GetAdHocTaskResultResponse> GetAdHocTaskResultWithOptionsAsync(GetAdHocTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTaskId))
            {
                query["SubTaskId"] = request.SubTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdHocTaskResult",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdHocTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询的任务运行结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskResultResponse
        /// </returns>
        public GetAdHocTaskResultResponse GetAdHocTaskResult(GetAdHocTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAdHocTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取即席查询的任务运行结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdHocTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdHocTaskResultResponse
        /// </returns>
        public async Task<GetAdHocTaskResultResponse> GetAdHocTaskResultAsync(GetAdHocTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAdHocTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertEventResponse
        /// </returns>
        public GetAlertEventResponse GetAlertEventWithOptions(GetAlertEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertEvent",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertEventResponse
        /// </returns>
        public async Task<GetAlertEventResponse> GetAlertEventWithOptionsAsync(GetAlertEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertEvent",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertEventResponse
        /// </returns>
        public GetAlertEventResponse GetAlertEvent(GetAlertEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlertEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertEventResponse
        /// </returns>
        public async Task<GetAlertEventResponse> GetAlertEventAsync(GetAlertEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlertEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoResponse
        /// </returns>
        public GetBatchTaskInfoResponse GetBatchTaskInfoWithOptions(GetBatchTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAllUpStreams))
            {
                query["IncludeAllUpStreams"] = request.IncludeAllUpStreams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoResponse
        /// </returns>
        public async Task<GetBatchTaskInfoResponse> GetBatchTaskInfoWithOptionsAsync(GetBatchTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAllUpStreams))
            {
                query["IncludeAllUpStreams"] = request.IncludeAllUpStreams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoResponse
        /// </returns>
        public GetBatchTaskInfoResponse GetBatchTaskInfo(GetBatchTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchTaskInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoResponse
        /// </returns>
        public async Task<GetBatchTaskInfoResponse> GetBatchTaskInfoAsync(GetBatchTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchTaskInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务指定版本任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoByVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoByVersionResponse
        /// </returns>
        public GetBatchTaskInfoByVersionResponse GetBatchTaskInfoByVersionWithOptions(GetBatchTaskInfoByVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskInfoByVersion",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskInfoByVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务指定版本任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoByVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoByVersionResponse
        /// </returns>
        public async Task<GetBatchTaskInfoByVersionResponse> GetBatchTaskInfoByVersionWithOptionsAsync(GetBatchTaskInfoByVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskInfoByVersion",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskInfoByVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务指定版本任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoByVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoByVersionResponse
        /// </returns>
        public GetBatchTaskInfoByVersionResponse GetBatchTaskInfoByVersion(GetBatchTaskInfoByVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchTaskInfoByVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务指定版本任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskInfoByVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskInfoByVersionResponse
        /// </returns>
        public async Task<GetBatchTaskInfoByVersionResponse> GetBatchTaskInfoByVersionAsync(GetBatchTaskInfoByVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchTaskInfoByVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskUdfLineagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskUdfLineagesResponse
        /// </returns>
        public GetBatchTaskUdfLineagesResponse GetBatchTaskUdfLineagesWithOptions(GetBatchTaskUdfLineagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskUdfLineages",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskUdfLineagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskUdfLineagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskUdfLineagesResponse
        /// </returns>
        public async Task<GetBatchTaskUdfLineagesResponse> GetBatchTaskUdfLineagesWithOptionsAsync(GetBatchTaskUdfLineagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskUdfLineages",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskUdfLineagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskUdfLineagesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskUdfLineagesResponse
        /// </returns>
        public GetBatchTaskUdfLineagesResponse GetBatchTaskUdfLineages(GetBatchTaskUdfLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchTaskUdfLineagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskUdfLineagesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskUdfLineagesResponse
        /// </returns>
        public async Task<GetBatchTaskUdfLineagesResponse> GetBatchTaskUdfLineagesAsync(GetBatchTaskUdfLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchTaskUdfLineagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务版本列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskVersionsResponse
        /// </returns>
        public GetBatchTaskVersionsResponse GetBatchTaskVersionsWithOptions(GetBatchTaskVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskVersions",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务版本列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskVersionsResponse
        /// </returns>
        public async Task<GetBatchTaskVersionsResponse> GetBatchTaskVersionsWithOptionsAsync(GetBatchTaskVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchTaskVersions",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchTaskVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务版本列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskVersionsResponse
        /// </returns>
        public GetBatchTaskVersionsResponse GetBatchTaskVersions(GetBatchTaskVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchTaskVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线计算任务版本列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBatchTaskVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBatchTaskVersionsResponse
        /// </returns>
        public async Task<GetBatchTaskVersionsResponse> GetBatchTaskVersionsAsync(GetBatchTaskVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchTaskVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取业务实体详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoResponse
        /// </returns>
        public GetBizEntityInfoResponse GetBizEntityInfoWithOptions(GetBizEntityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
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
                Action = "GetBizEntityInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizEntityInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取业务实体详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoResponse
        /// </returns>
        public async Task<GetBizEntityInfoResponse> GetBizEntityInfoWithOptionsAsync(GetBizEntityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
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
                Action = "GetBizEntityInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizEntityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取业务实体详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoResponse
        /// </returns>
        public GetBizEntityInfoResponse GetBizEntityInfo(GetBizEntityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBizEntityInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取业务实体详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoResponse
        /// </returns>
        public async Task<GetBizEntityInfoResponse> GetBizEntityInfoAsync(GetBizEntityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBizEntityInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定版本的业务实体的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoByVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoByVersionResponse
        /// </returns>
        public GetBizEntityInfoByVersionResponse GetBizEntityInfoByVersionWithOptions(GetBizEntityInfoByVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizEntityInfoByVersion",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizEntityInfoByVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定版本的业务实体的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoByVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoByVersionResponse
        /// </returns>
        public async Task<GetBizEntityInfoByVersionResponse> GetBizEntityInfoByVersionWithOptionsAsync(GetBizEntityInfoByVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizEntityInfoByVersion",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizEntityInfoByVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定版本的业务实体的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoByVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoByVersionResponse
        /// </returns>
        public GetBizEntityInfoByVersionResponse GetBizEntityInfoByVersion(GetBizEntityInfoByVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBizEntityInfoByVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定版本的业务实体的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizEntityInfoByVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizEntityInfoByVersionResponse
        /// </returns>
        public async Task<GetBizEntityInfoByVersionResponse> GetBizEntityInfoByVersionAsync(GetBizEntityInfoByVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBizEntityInfoByVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据板块详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizUnitInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizUnitInfoResponse
        /// </returns>
        public GetBizUnitInfoResponse GetBizUnitInfoWithOptions(GetBizUnitInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizUnitInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizUnitInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据板块详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizUnitInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBizUnitInfoResponse
        /// </returns>
        public async Task<GetBizUnitInfoResponse> GetBizUnitInfoWithOptionsAsync(GetBizUnitInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBizUnitInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBizUnitInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据板块详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizUnitInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizUnitInfoResponse
        /// </returns>
        public GetBizUnitInfoResponse GetBizUnitInfo(GetBizUnitInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBizUnitInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据板块详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBizUnitInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBizUnitInfoResponse
        /// </returns>
        public async Task<GetBizUnitInfoResponse> GetBizUnitInfoAsync(GetBizUnitInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBizUnitInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据环境获取集群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterQueueInfoByEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterQueueInfoByEnvResponse
        /// </returns>
        public GetClusterQueueInfoByEnvResponse GetClusterQueueInfoByEnvWithOptions(GetClusterQueueInfoByEnvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamBatchMode))
            {
                query["StreamBatchMode"] = request.StreamBatchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterQueueInfoByEnv",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterQueueInfoByEnvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据环境获取集群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterQueueInfoByEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterQueueInfoByEnvResponse
        /// </returns>
        public async Task<GetClusterQueueInfoByEnvResponse> GetClusterQueueInfoByEnvWithOptionsAsync(GetClusterQueueInfoByEnvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamBatchMode))
            {
                query["StreamBatchMode"] = request.StreamBatchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterQueueInfoByEnv",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterQueueInfoByEnvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据环境获取集群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterQueueInfoByEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClusterQueueInfoByEnvResponse
        /// </returns>
        public GetClusterQueueInfoByEnvResponse GetClusterQueueInfoByEnv(GetClusterQueueInfoByEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClusterQueueInfoByEnvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据环境获取集群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterQueueInfoByEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClusterQueueInfoByEnvResponse
        /// </returns>
        public async Task<GetClusterQueueInfoByEnvResponse> GetClusterQueueInfoByEnvAsync(GetClusterQueueInfoByEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClusterQueueInfoByEnvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDomainInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataDomainInfoResponse
        /// </returns>
        public GetDataDomainInfoResponse GetDataDomainInfoWithOptions(GetDataDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataDomainInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataDomainInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDomainInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataDomainInfoResponse
        /// </returns>
        public async Task<GetDataDomainInfoResponse> GetDataDomainInfoWithOptionsAsync(GetDataDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataDomainInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataDomainInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDomainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataDomainInfoResponse
        /// </returns>
        public GetDataDomainInfoResponse GetDataDomainInfo(GetDataDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataDomainInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataDomainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataDomainInfoResponse
        /// </returns>
        public async Task<GetDataDomainInfoResponse> GetDataDomainInfoAsync(GetDataDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataDomainInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开发态对象上游依赖。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevObjectDependencyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDevObjectDependencyResponse
        /// </returns>
        public GetDevObjectDependencyResponse GetDevObjectDependencyWithOptions(GetDevObjectDependencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectFrom))
            {
                query["ObjectFrom"] = request.ObjectFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDevObjectDependency",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDevObjectDependencyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开发态对象上游依赖。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevObjectDependencyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDevObjectDependencyResponse
        /// </returns>
        public async Task<GetDevObjectDependencyResponse> GetDevObjectDependencyWithOptionsAsync(GetDevObjectDependencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectFrom))
            {
                query["ObjectFrom"] = request.ObjectFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDevObjectDependency",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDevObjectDependencyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开发态对象上游依赖。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevObjectDependencyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDevObjectDependencyResponse
        /// </returns>
        public GetDevObjectDependencyResponse GetDevObjectDependency(GetDevObjectDependencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevObjectDependencyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开发态对象上游依赖。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDevObjectDependencyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDevObjectDependencyResponse
        /// </returns>
        public async Task<GetDevObjectDependencyResponse> GetDevObjectDependencyAsync(GetDevObjectDependencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevObjectDependencyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件夹目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDirectoryTreeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryTreeResponse
        /// </returns>
        public GetDirectoryTreeResponse GetDirectoryTreeWithOptions(GetDirectoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectoryTree",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryTreeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件夹目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDirectoryTreeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryTreeResponse
        /// </returns>
        public async Task<GetDirectoryTreeResponse> GetDirectoryTreeWithOptionsAsync(GetDirectoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectoryTree",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件夹目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDirectoryTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryTreeResponse
        /// </returns>
        public GetDirectoryTreeResponse GetDirectoryTree(GetDirectoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDirectoryTreeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件夹目录树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDirectoryTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryTreeResponse
        /// </returns>
        public async Task<GetDirectoryTreeResponse> GetDirectoryTreeAsync(GetDirectoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDirectoryTreeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起始的实例查询该实例的下游</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInstanceDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceDownStreamResponse
        /// </returns>
        public GetInstanceDownStreamResponse GetInstanceDownStreamWithOptions(GetInstanceDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInstanceDownStreamShrinkRequest request = new GetInstanceDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceGet))
            {
                request.InstanceGetShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceGet, "InstanceGet", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownStreamDepth))
            {
                query["DownStreamDepth"] = request.DownStreamDepth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunStatus))
            {
                query["RunStatus"] = request.RunStatus;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGetShrink))
            {
                body["InstanceGet"] = request.InstanceGetShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceDownStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起始的实例查询该实例的下游</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInstanceDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceDownStreamResponse
        /// </returns>
        public async Task<GetInstanceDownStreamResponse> GetInstanceDownStreamWithOptionsAsync(GetInstanceDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInstanceDownStreamShrinkRequest request = new GetInstanceDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceGet))
            {
                request.InstanceGetShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceGet, "InstanceGet", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownStreamDepth))
            {
                query["DownStreamDepth"] = request.DownStreamDepth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunStatus))
            {
                query["RunStatus"] = request.RunStatus;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGetShrink))
            {
                body["InstanceGet"] = request.InstanceGetShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceDownStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起始的实例查询该实例的下游</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceDownStreamResponse
        /// </returns>
        public GetInstanceDownStreamResponse GetInstanceDownStream(GetInstanceDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceDownStreamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据起始的实例查询该实例的下游</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceDownStreamResponse
        /// </returns>
        public async Task<GetInstanceDownStreamResponse> GetInstanceDownStreamAsync(GetInstanceDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceDownStreamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例的上下游，支持逻辑表和代码任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInstanceUpDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUpDownStreamResponse
        /// </returns>
        public GetInstanceUpDownStreamResponse GetInstanceUpDownStreamWithOptions(GetInstanceUpDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInstanceUpDownStreamShrinkRequest request = new GetInstanceUpDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceId))
            {
                request.InstanceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceId, "InstanceId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownStreamDepth))
            {
                query["DownStreamDepth"] = request.DownStreamDepth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpStreamDepth))
            {
                query["UpStreamDepth"] = request.UpStreamDepth;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdShrink))
            {
                body["InstanceId"] = request.InstanceIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceUpDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceUpDownStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例的上下游，支持逻辑表和代码任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInstanceUpDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUpDownStreamResponse
        /// </returns>
        public async Task<GetInstanceUpDownStreamResponse> GetInstanceUpDownStreamWithOptionsAsync(GetInstanceUpDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInstanceUpDownStreamShrinkRequest request = new GetInstanceUpDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceId))
            {
                request.InstanceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceId, "InstanceId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownStreamDepth))
            {
                query["DownStreamDepth"] = request.DownStreamDepth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpStreamDepth))
            {
                query["UpStreamDepth"] = request.UpStreamDepth;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdShrink))
            {
                body["InstanceId"] = request.InstanceIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceUpDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceUpDownStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例的上下游，支持逻辑表和代码任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceUpDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUpDownStreamResponse
        /// </returns>
        public GetInstanceUpDownStreamResponse GetInstanceUpDownStream(GetInstanceUpDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceUpDownStreamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例的上下游，支持逻辑表和代码任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceUpDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUpDownStreamResponse
        /// </returns>
        public async Task<GetInstanceUpDownStreamResponse> GetInstanceUpDownStreamAsync(GetInstanceUpDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceUpDownStreamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新的待发布记录详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetLatestSubmitDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestSubmitDetailResponse
        /// </returns>
        public GetLatestSubmitDetailResponse GetLatestSubmitDetailWithOptions(GetLatestSubmitDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetLatestSubmitDetailShrinkRequest request = new GetLatestSubmitDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubmitDetailQuery))
            {
                request.SubmitDetailQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubmitDetailQuery, "SubmitDetailQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitDetailQueryShrink))
            {
                body["SubmitDetailQuery"] = request.SubmitDetailQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestSubmitDetail",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestSubmitDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新的待发布记录详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetLatestSubmitDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestSubmitDetailResponse
        /// </returns>
        public async Task<GetLatestSubmitDetailResponse> GetLatestSubmitDetailWithOptionsAsync(GetLatestSubmitDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetLatestSubmitDetailShrinkRequest request = new GetLatestSubmitDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubmitDetailQuery))
            {
                request.SubmitDetailQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubmitDetailQuery, "SubmitDetailQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitDetailQueryShrink))
            {
                body["SubmitDetailQuery"] = request.SubmitDetailQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestSubmitDetail",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestSubmitDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新的待发布记录详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLatestSubmitDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLatestSubmitDetailResponse
        /// </returns>
        public GetLatestSubmitDetailResponse GetLatestSubmitDetail(GetLatestSubmitDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLatestSubmitDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新的待发布记录详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLatestSubmitDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLatestSubmitDetailResponse
        /// </returns>
        public async Task<GetLatestSubmitDetailResponse> GetLatestSubmitDetailAsync(GetLatestSubmitDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLatestSubmitDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMyRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMyRolesResponse
        /// </returns>
        public GetMyRolesResponse GetMyRolesWithOptions(GetMyRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMyRoles",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMyRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMyRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMyRolesResponse
        /// </returns>
        public async Task<GetMyRolesResponse> GetMyRolesWithOptionsAsync(GetMyRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMyRoles",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMyRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMyRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMyRolesResponse
        /// </returns>
        public GetMyRolesResponse GetMyRoles(GetMyRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMyRolesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMyRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMyRolesResponse
        /// </returns>
        public async Task<GetMyRolesResponse> GetMyRolesAsync(GetMyRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMyRolesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户归属租户.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetMyTenantsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMyTenantsResponse
        /// </returns>
        public GetMyTenantsResponse GetMyTenantsWithOptions(GetMyTenantsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMyTenantsShrinkRequest request = new GetMyTenantsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FeatureCodeList))
            {
                request.FeatureCodeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FeatureCodeList, "FeatureCodeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureCodeListShrink))
            {
                body["FeatureCodeList"] = request.FeatureCodeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMyTenants",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMyTenantsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户归属租户.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetMyTenantsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMyTenantsResponse
        /// </returns>
        public async Task<GetMyTenantsResponse> GetMyTenantsWithOptionsAsync(GetMyTenantsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetMyTenantsShrinkRequest request = new GetMyTenantsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FeatureCodeList))
            {
                request.FeatureCodeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FeatureCodeList, "FeatureCodeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureCodeListShrink))
            {
                body["FeatureCodeList"] = request.FeatureCodeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMyTenants",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMyTenantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户归属租户.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMyTenantsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMyTenantsResponse
        /// </returns>
        public GetMyTenantsResponse GetMyTenants(GetMyTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMyTenantsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户归属租户.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMyTenantsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMyTenantsResponse
        /// </returns>
        public async Task<GetMyTenantsResponse> GetMyTenantsAsync(GetMyTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMyTenantsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用查询节点上下游接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetNodeUpDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeUpDownStreamResponse
        /// </returns>
        public GetNodeUpDownStreamResponse GetNodeUpDownStreamWithOptions(GetNodeUpDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodeUpDownStreamShrinkRequest request = new GetNodeUpDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodeId))
            {
                request.NodeIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodeId, "NodeId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownStreamDepth))
            {
                query["DownStreamDepth"] = request.DownStreamDepth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpStreamDepth))
            {
                query["UpStreamDepth"] = request.UpStreamDepth;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIdShrink))
            {
                body["NodeId"] = request.NodeIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeUpDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeUpDownStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用查询节点上下游接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetNodeUpDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeUpDownStreamResponse
        /// </returns>
        public async Task<GetNodeUpDownStreamResponse> GetNodeUpDownStreamWithOptionsAsync(GetNodeUpDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNodeUpDownStreamShrinkRequest request = new GetNodeUpDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodeId))
            {
                request.NodeIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodeId, "NodeId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownStreamDepth))
            {
                query["DownStreamDepth"] = request.DownStreamDepth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpStreamDepth))
            {
                query["UpStreamDepth"] = request.UpStreamDepth;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIdShrink))
            {
                body["NodeId"] = request.NodeIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeUpDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeUpDownStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用查询节点上下游接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeUpDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeUpDownStreamResponse
        /// </returns>
        public GetNodeUpDownStreamResponse GetNodeUpDownStream(GetNodeUpDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeUpDownStreamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用查询节点上下游接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeUpDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeUpDownStreamResponse
        /// </returns>
        public async Task<GetNodeUpDownStreamResponse> GetNodeUpDownStreamAsync(GetNodeUpDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeUpDownStreamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询补数据提交的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationSubmitStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOperationSubmitStatusResponse
        /// </returns>
        public GetOperationSubmitStatusResponse GetOperationSubmitStatusWithOptions(GetOperationSubmitStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperationSubmitStatus",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationSubmitStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询补数据提交的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationSubmitStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOperationSubmitStatusResponse
        /// </returns>
        public async Task<GetOperationSubmitStatusResponse> GetOperationSubmitStatusWithOptionsAsync(GetOperationSubmitStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperationSubmitStatus",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationSubmitStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询补数据提交的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationSubmitStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOperationSubmitStatusResponse
        /// </returns>
        public GetOperationSubmitStatusResponse GetOperationSubmitStatus(GetOperationSubmitStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOperationSubmitStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询补数据提交的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOperationSubmitStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOperationSubmitStatusResponse
        /// </returns>
        public async Task<GetOperationSubmitStatusResponse> GetOperationSubmitStatusAsync(GetOperationSubmitStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOperationSubmitStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询脚本的实例信息, 包括实例状态、运行时间等信息.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceResponse
        /// </returns>
        public GetPhysicalInstanceResponse GetPhysicalInstanceWithOptions(GetPhysicalInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalInstance",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询脚本的实例信息, 包括实例状态、运行时间等信息.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceResponse
        /// </returns>
        public async Task<GetPhysicalInstanceResponse> GetPhysicalInstanceWithOptionsAsync(GetPhysicalInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalInstance",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询脚本的实例信息, 包括实例状态、运行时间等信息.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceResponse
        /// </returns>
        public GetPhysicalInstanceResponse GetPhysicalInstance(GetPhysicalInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhysicalInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询脚本的实例信息, 包括实例状态、运行时间等信息.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceResponse
        /// </returns>
        public async Task<GetPhysicalInstanceResponse> GetPhysicalInstanceAsync(GetPhysicalInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhysicalInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例执行的日志，如果实例重跑了多次，则会有多条日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceLogResponse
        /// </returns>
        public GetPhysicalInstanceLogResponse GetPhysicalInstanceLogWithOptions(GetPhysicalInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalInstanceLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalInstanceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例执行的日志，如果实例重跑了多次，则会有多条日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceLogResponse
        /// </returns>
        public async Task<GetPhysicalInstanceLogResponse> GetPhysicalInstanceLogWithOptionsAsync(GetPhysicalInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalInstanceLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalInstanceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例执行的日志，如果实例重跑了多次，则会有多条日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceLogResponse
        /// </returns>
        public GetPhysicalInstanceLogResponse GetPhysicalInstanceLog(GetPhysicalInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhysicalInstanceLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例执行的日志，如果实例重跑了多次，则会有多条日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalInstanceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalInstanceLogResponse
        /// </returns>
        public async Task<GetPhysicalInstanceLogResponse> GetPhysicalInstanceLogAsync(GetPhysicalInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhysicalInstanceLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物理调度节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeResponse
        /// </returns>
        public GetPhysicalNodeResponse GetPhysicalNodeWithOptions(GetPhysicalNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物理调度节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeResponse
        /// </returns>
        public async Task<GetPhysicalNodeResponse> GetPhysicalNodeWithOptionsAsync(GetPhysicalNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物理调度节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeResponse
        /// </returns>
        public GetPhysicalNodeResponse GetPhysicalNode(GetPhysicalNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhysicalNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询物理调度节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeResponse
        /// </returns>
        public async Task<GetPhysicalNodeResponse> GetPhysicalNodeAsync(GetPhysicalNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhysicalNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据输出名查询对应的物理节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeByOutputNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeByOutputNameResponse
        /// </returns>
        public GetPhysicalNodeByOutputNameResponse GetPhysicalNodeByOutputNameWithOptions(GetPhysicalNodeByOutputNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputName))
            {
                query["OutputName"] = request.OutputName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNodeByOutputName",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeByOutputNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据输出名查询对应的物理节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeByOutputNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeByOutputNameResponse
        /// </returns>
        public async Task<GetPhysicalNodeByOutputNameResponse> GetPhysicalNodeByOutputNameWithOptionsAsync(GetPhysicalNodeByOutputNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputName))
            {
                query["OutputName"] = request.OutputName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNodeByOutputName",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeByOutputNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据输出名查询对应的物理节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeByOutputNameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeByOutputNameResponse
        /// </returns>
        public GetPhysicalNodeByOutputNameResponse GetPhysicalNodeByOutputName(GetPhysicalNodeByOutputNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhysicalNodeByOutputNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据输出名查询对应的物理节点。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeByOutputNameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeByOutputNameResponse
        /// </returns>
        public async Task<GetPhysicalNodeByOutputNameResponse> GetPhysicalNodeByOutputNameAsync(GetPhysicalNodeByOutputNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhysicalNodeByOutputNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点代码内容。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeContentResponse
        /// </returns>
        public GetPhysicalNodeContentResponse GetPhysicalNodeContentWithOptions(GetPhysicalNodeContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNodeContent",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点代码内容。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeContentResponse
        /// </returns>
        public async Task<GetPhysicalNodeContentResponse> GetPhysicalNodeContentWithOptionsAsync(GetPhysicalNodeContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNodeContent",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点代码内容。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeContentResponse
        /// </returns>
        public GetPhysicalNodeContentResponse GetPhysicalNodeContent(GetPhysicalNodeContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhysicalNodeContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点代码内容。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeContentResponse
        /// </returns>
        public async Task<GetPhysicalNodeContentResponse> GetPhysicalNodeContentAsync(GetPhysicalNodeContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhysicalNodeContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点的操作日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeOperationLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeOperationLogResponse
        /// </returns>
        public GetPhysicalNodeOperationLogResponse GetPhysicalNodeOperationLogWithOptions(GetPhysicalNodeOperationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNodeOperationLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeOperationLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点的操作日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeOperationLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeOperationLogResponse
        /// </returns>
        public async Task<GetPhysicalNodeOperationLogResponse> GetPhysicalNodeOperationLogWithOptionsAsync(GetPhysicalNodeOperationLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhysicalNodeOperationLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhysicalNodeOperationLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点的操作日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeOperationLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeOperationLogResponse
        /// </returns>
        public GetPhysicalNodeOperationLogResponse GetPhysicalNodeOperationLog(GetPhysicalNodeOperationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhysicalNodeOperationLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点的操作日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPhysicalNodeOperationLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPhysicalNodeOperationLogResponse
        /// </returns>
        public async Task<GetPhysicalNodeOperationLogResponse> GetPhysicalNodeOperationLogAsync(GetPhysicalNodeOperationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhysicalNodeOperationLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目生产账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectProduceUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectProduceUserResponse
        /// </returns>
        public GetProjectProduceUserResponse GetProjectProduceUserWithOptions(GetProjectProduceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectProduceUser",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectProduceUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目生产账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectProduceUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectProduceUserResponse
        /// </returns>
        public async Task<GetProjectProduceUserResponse> GetProjectProduceUserWithOptionsAsync(GetProjectProduceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectProduceUser",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectProduceUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目生产账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectProduceUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectProduceUserResponse
        /// </returns>
        public GetProjectProduceUserResponse GetProjectProduceUser(GetProjectProduceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectProduceUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目生产账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectProduceUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectProduceUserResponse
        /// </returns>
        public async Task<GetProjectProduceUserResponse> GetProjectProduceUserAsync(GetProjectProduceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectProduceUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据集群ID获取集群版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueEngineVersionByEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueueEngineVersionByEnvResponse
        /// </returns>
        public GetQueueEngineVersionByEnvResponse GetQueueEngineVersionByEnvWithOptions(GetQueueEngineVersionByEnvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamBatchMode))
            {
                query["StreamBatchMode"] = request.StreamBatchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueEngineVersionByEnv",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueEngineVersionByEnvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据集群ID获取集群版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueEngineVersionByEnvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueueEngineVersionByEnvResponse
        /// </returns>
        public async Task<GetQueueEngineVersionByEnvResponse> GetQueueEngineVersionByEnvWithOptionsAsync(GetQueueEngineVersionByEnvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamBatchMode))
            {
                query["StreamBatchMode"] = request.StreamBatchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueEngineVersionByEnv",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueEngineVersionByEnvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据集群ID获取集群版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueEngineVersionByEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueueEngineVersionByEnvResponse
        /// </returns>
        public GetQueueEngineVersionByEnvResponse GetQueueEngineVersionByEnv(GetQueueEngineVersionByEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueEngineVersionByEnvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据集群ID获取集群版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueEngineVersionByEnvRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueueEngineVersionByEnvResponse
        /// </returns>
        public async Task<GetQueueEngineVersionByEnvResponse> GetQueueEngineVersionByEnvAsync(GetQueueEngineVersionByEnvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueEngineVersionByEnvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算源对应集群的spark客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSparkLocalClientInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSparkLocalClientInfoResponse
        /// </returns>
        public GetSparkLocalClientInfoResponse GetSparkLocalClientInfoWithOptions(GetSparkLocalClientInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvEnum))
            {
                query["EnvEnum"] = request.EnvEnum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkLocalClientInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkLocalClientInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算源对应集群的spark客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSparkLocalClientInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSparkLocalClientInfoResponse
        /// </returns>
        public async Task<GetSparkLocalClientInfoResponse> GetSparkLocalClientInfoWithOptionsAsync(GetSparkLocalClientInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvEnum))
            {
                query["EnvEnum"] = request.EnvEnum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkLocalClientInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkLocalClientInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算源对应集群的spark客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSparkLocalClientInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSparkLocalClientInfoResponse
        /// </returns>
        public GetSparkLocalClientInfoResponse GetSparkLocalClientInfo(GetSparkLocalClientInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkLocalClientInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算源对应集群的spark客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSparkLocalClientInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSparkLocalClientInfoResponse
        /// </returns>
        public async Task<GetSparkLocalClientInfoResponse> GetSparkLocalClientInfoAsync(GetSparkLocalClientInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkLocalClientInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取补数据工作流所有业务日期的Dagrun信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunResponse
        /// </returns>
        public GetSupplementDagrunResponse GetSupplementDagrunWithOptions(GetSupplementDagrunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSupplementDagrun",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupplementDagrunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取补数据工作流所有业务日期的Dagrun信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunResponse
        /// </returns>
        public async Task<GetSupplementDagrunResponse> GetSupplementDagrunWithOptionsAsync(GetSupplementDagrunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplementId))
            {
                query["SupplementId"] = request.SupplementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSupplementDagrun",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupplementDagrunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取补数据工作流所有业务日期的Dagrun信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunResponse
        /// </returns>
        public GetSupplementDagrunResponse GetSupplementDagrun(GetSupplementDagrunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSupplementDagrunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取补数据工作流所有业务日期的Dagrun信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunResponse
        /// </returns>
        public async Task<GetSupplementDagrunResponse> GetSupplementDagrunAsync(GetSupplementDagrunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSupplementDagrunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出补数据工作流下具体一个业务日期的所有节点的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunInstanceResponse
        /// </returns>
        public GetSupplementDagrunInstanceResponse GetSupplementDagrunInstanceWithOptions(GetSupplementDagrunInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagrunId))
            {
                query["DagrunId"] = request.DagrunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSupplementDagrunInstance",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupplementDagrunInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出补数据工作流下具体一个业务日期的所有节点的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunInstanceResponse
        /// </returns>
        public async Task<GetSupplementDagrunInstanceResponse> GetSupplementDagrunInstanceWithOptionsAsync(GetSupplementDagrunInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagrunId))
            {
                query["DagrunId"] = request.DagrunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSupplementDagrunInstance",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupplementDagrunInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出补数据工作流下具体一个业务日期的所有节点的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunInstanceResponse
        /// </returns>
        public GetSupplementDagrunInstanceResponse GetSupplementDagrunInstance(GetSupplementDagrunInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSupplementDagrunInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出补数据工作流下具体一个业务日期的所有节点的实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplementDagrunInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSupplementDagrunInstanceResponse
        /// </returns>
        public async Task<GetSupplementDagrunInstanceResponse> GetSupplementDagrunInstanceAsync(GetSupplementDagrunInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSupplementDagrunInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过用户原始Id（如阿里云Id）获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserBySourceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserBySourceIdResponse
        /// </returns>
        public GetUserBySourceIdResponse GetUserBySourceIdWithOptions(GetUserBySourceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserBySourceId",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserBySourceIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过用户原始Id（如阿里云Id）获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserBySourceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserBySourceIdResponse
        /// </returns>
        public async Task<GetUserBySourceIdResponse> GetUserBySourceIdWithOptionsAsync(GetUserBySourceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserBySourceId",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserBySourceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过用户原始Id（如阿里云Id）获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserBySourceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserBySourceIdResponse
        /// </returns>
        public GetUserBySourceIdResponse GetUserBySourceId(GetUserBySourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserBySourceIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过用户原始Id（如阿里云Id）获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserBySourceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserBySourceIdResponse
        /// </returns>
        public async Task<GetUserBySourceIdResponse> GetUserBySourceIdAsync(GetUserBySourceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserBySourceIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户组详情.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public GetUserGroupResponse GetUserGroupWithOptions(GetUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户组详情.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public async Task<GetUserGroupResponse> GetUserGroupWithOptionsAsync(GetUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户组详情.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public GetUserGroupResponse GetUserGroup(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户组详情.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public async Task<GetUserGroupResponse> GetUserGroupAsync(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public GetUsersResponse GetUsersWithOptions(GetUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUsersShrinkRequest request = new GetUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIdList))
            {
                request.UserIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIdList, "UserIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdListShrink))
            {
                body["UserIdList"] = request.UserIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUsers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public async Task<GetUsersResponse> GetUsersWithOptionsAsync(GetUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUsersShrinkRequest request = new GetUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIdList))
            {
                request.UserIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIdList, "UserIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdListShrink))
            {
                body["UserIdList"] = request.UserIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUsers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public GetUsersResponse GetUsers(GetUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUsersResponse
        /// </returns>
        public async Task<GetUsersResponse> GetUsersAsync(GetUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过资源点对用户授权</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GrantResourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantResourcePermissionResponse
        /// </returns>
        public GrantResourcePermissionResponse GrantResourcePermissionWithOptions(GrantResourcePermissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantResourcePermissionShrinkRequest request = new GrantResourcePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GrantCommand))
            {
                request.GrantCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GrantCommand, "GrantCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantCommandShrink))
            {
                body["GrantCommand"] = request.GrantCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantResourcePermission",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantResourcePermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过资源点对用户授权</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GrantResourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantResourcePermissionResponse
        /// </returns>
        public async Task<GrantResourcePermissionResponse> GrantResourcePermissionWithOptionsAsync(GrantResourcePermissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantResourcePermissionShrinkRequest request = new GrantResourcePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GrantCommand))
            {
                request.GrantCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GrantCommand, "GrantCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantCommandShrink))
            {
                body["GrantCommand"] = request.GrantCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantResourcePermission",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantResourcePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过资源点对用户授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantResourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantResourcePermissionResponse
        /// </returns>
        public GrantResourcePermissionResponse GrantResourcePermission(GrantResourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantResourcePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过资源点对用户授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantResourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantResourcePermissionResponse
        /// </returns>
        public async Task<GrantResourcePermissionResponse> GrantResourcePermissionAsync(GrantResourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantResourcePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddableRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddableRolesResponse
        /// </returns>
        public ListAddableRolesResponse ListAddableRolesWithOptions(ListAddableRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddableRoles",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddableRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddableRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddableRolesResponse
        /// </returns>
        public async Task<ListAddableRolesResponse> ListAddableRolesWithOptionsAsync(ListAddableRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddableRoles",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddableRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddableRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddableRolesResponse
        /// </returns>
        public ListAddableRolesResponse ListAddableRoles(ListAddableRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAddableRolesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddableRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddableRolesResponse
        /// </returns>
        public async Task<ListAddableRolesResponse> ListAddableRolesAsync(ListAddableRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAddableRolesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可加入租户成员列表的用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAddableUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddableUsersResponse
        /// </returns>
        public ListAddableUsersResponse ListAddableUsersWithOptions(ListAddableUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAddableUsersShrinkRequest request = new ListAddableUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddableUsers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddableUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可加入租户成员列表的用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAddableUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddableUsersResponse
        /// </returns>
        public async Task<ListAddableUsersResponse> ListAddableUsersWithOptionsAsync(ListAddableUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAddableUsersShrinkRequest request = new ListAddableUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddableUsers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddableUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可加入租户成员列表的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddableUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddableUsersResponse
        /// </returns>
        public ListAddableUsersResponse ListAddableUsers(ListAddableUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAddableUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可加入租户成员列表的用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddableUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddableUsersResponse
        /// </returns>
        public async Task<ListAddableUsersResponse> ListAddableUsersAsync(ListAddableUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAddableUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个告警事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertEventsResponse
        /// </returns>
        public ListAlertEventsResponse ListAlertEventsWithOptions(ListAlertEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertEventsShrinkRequest request = new ListAlertEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertEvents",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个告警事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertEventsResponse
        /// </returns>
        public async Task<ListAlertEventsResponse> ListAlertEventsWithOptionsAsync(ListAlertEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertEventsShrinkRequest request = new ListAlertEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertEvents",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个告警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertEventsResponse
        /// </returns>
        public ListAlertEventsResponse ListAlertEvents(ListAlertEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlertEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个告警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertEventsResponse
        /// </returns>
        public async Task<ListAlertEventsResponse> ListAlertEventsAsync(ListAlertEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlertEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个推送记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertNotificationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertNotificationsResponse
        /// </returns>
        public ListAlertNotificationsResponse ListAlertNotificationsWithOptions(ListAlertNotificationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertNotificationsShrinkRequest request = new ListAlertNotificationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertNotifications",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertNotificationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个推送记录</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertNotificationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertNotificationsResponse
        /// </returns>
        public async Task<ListAlertNotificationsResponse> ListAlertNotificationsWithOptionsAsync(ListAlertNotificationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertNotificationsShrinkRequest request = new ListAlertNotificationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertNotifications",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertNotificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个推送记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertNotificationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertNotificationsResponse
        /// </returns>
        public ListAlertNotificationsResponse ListAlertNotifications(ListAlertNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlertNotificationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据条件查询多个推送记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertNotificationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertNotificationsResponse
        /// </returns>
        public async Task<ListAlertNotificationsResponse> ListAlertNotificationsAsync(ListAlertNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlertNotificationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据app查询api列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListApiByAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiByAppResponse
        /// </returns>
        public ListApiByAppResponse ListApiByAppWithOptions(ListApiByAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListApiByAppShrinkRequest request = new ListApiByAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageQuery))
            {
                request.PageQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageQuery, "PageQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageQueryShrink))
            {
                body["PageQuery"] = request.PageQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiByApp",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiByAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据app查询api列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListApiByAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiByAppResponse
        /// </returns>
        public async Task<ListApiByAppResponse> ListApiByAppWithOptionsAsync(ListApiByAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListApiByAppShrinkRequest request = new ListApiByAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageQuery))
            {
                request.PageQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageQuery, "PageQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageQueryShrink))
            {
                body["PageQuery"] = request.PageQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiByApp",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiByAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据app查询api列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiByAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiByAppResponse
        /// </returns>
        public ListApiByAppResponse ListApiByApp(ListApiByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiByAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据app查询api列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiByAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiByAppResponse
        /// </returns>
        public async Task<ListApiByAppResponse> ListApiByAppAsync(ListApiByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiByAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用已申请的API的具体的字段列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAuthorizedDataServiceApiDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedDataServiceApiDetailsResponse
        /// </returns>
        public ListAuthorizedDataServiceApiDetailsResponse ListAuthorizedDataServiceApiDetailsWithOptions(ListAuthorizedDataServiceApiDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAuthorizedDataServiceApiDetailsShrinkRequest request = new ListAuthorizedDataServiceApiDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedDataServiceApiDetails",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedDataServiceApiDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用已申请的API的具体的字段列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAuthorizedDataServiceApiDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedDataServiceApiDetailsResponse
        /// </returns>
        public async Task<ListAuthorizedDataServiceApiDetailsResponse> ListAuthorizedDataServiceApiDetailsWithOptionsAsync(ListAuthorizedDataServiceApiDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAuthorizedDataServiceApiDetailsShrinkRequest request = new ListAuthorizedDataServiceApiDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedDataServiceApiDetails",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedDataServiceApiDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用已申请的API的具体的字段列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedDataServiceApiDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedDataServiceApiDetailsResponse
        /// </returns>
        public ListAuthorizedDataServiceApiDetailsResponse ListAuthorizedDataServiceApiDetails(ListAuthorizedDataServiceApiDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizedDataServiceApiDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用已申请的API的具体的字段列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedDataServiceApiDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedDataServiceApiDetailsResponse
        /// </returns>
        public async Task<ListAuthorizedDataServiceApiDetailsResponse> ListAuthorizedDataServiceApiDetailsAsync(ListAuthorizedDataServiceApiDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizedDataServiceApiDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务实体列表。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListBizEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizEntitiesResponse
        /// </returns>
        public ListBizEntitiesResponse ListBizEntitiesWithOptions(ListBizEntitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListBizEntitiesShrinkRequest request = new ListBizEntitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizEntities",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizEntitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务实体列表。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListBizEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizEntitiesResponse
        /// </returns>
        public async Task<ListBizEntitiesResponse> ListBizEntitiesWithOptionsAsync(ListBizEntitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListBizEntitiesShrinkRequest request = new ListBizEntitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizEntities",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizEntitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务实体列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizEntitiesResponse
        /// </returns>
        public ListBizEntitiesResponse ListBizEntities(ListBizEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBizEntitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询业务实体列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizEntitiesResponse
        /// </returns>
        public async Task<ListBizEntitiesResponse> ListBizEntitiesAsync(ListBizEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBizEntitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前租户下的所有数据板块</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizUnitsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizUnitsResponse
        /// </returns>
        public ListBizUnitsResponse ListBizUnitsWithOptions(ListBizUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizUnits",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizUnitsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前租户下的所有数据板块</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizUnitsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBizUnitsResponse
        /// </returns>
        public async Task<ListBizUnitsResponse> ListBizUnitsWithOptionsAsync(ListBizUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBizUnits",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBizUnitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前租户下的所有数据板块</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizUnitsResponse
        /// </returns>
        public ListBizUnitsResponse ListBizUnits(ListBizUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBizUnitsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前租户下的所有数据板块</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBizUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBizUnitsResponse
        /// </returns>
        public async Task<ListBizUnitsResponse> ListBizUnitsAsync(ListBizUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBizUnitsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域列表。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDomainsResponse
        /// </returns>
        public ListDataDomainsResponse ListDataDomainsWithOptions(ListDataDomainsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataDomainsShrinkRequest request = new ListDataDomainsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataDomains",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域列表。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDomainsResponse
        /// </returns>
        public async Task<ListDataDomainsResponse> ListDataDomainsWithOptionsAsync(ListDataDomainsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataDomainsShrinkRequest request = new ListDataDomainsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataDomains",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDomainsResponse
        /// </returns>
        public ListDataDomainsResponse ListDataDomains(ListDataDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataDomainsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题域列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDomainsResponse
        /// </returns>
        public async Task<ListDataDomainsResponse> ListDataDomainsAsync(ListDataDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataDomainsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据源，所属结果包含数据源配置项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSourceWithConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceWithConfigResponse
        /// </returns>
        public ListDataSourceWithConfigResponse ListDataSourceWithConfigWithOptions(ListDataSourceWithConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourceWithConfigShrinkRequest request = new ListDataSourceWithConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceWithConfig",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceWithConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据源，所属结果包含数据源配置项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSourceWithConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceWithConfigResponse
        /// </returns>
        public async Task<ListDataSourceWithConfigResponse> ListDataSourceWithConfigWithOptionsAsync(ListDataSourceWithConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourceWithConfigShrinkRequest request = new ListDataSourceWithConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceWithConfig",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceWithConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据源，所属结果包含数据源配置项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceWithConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceWithConfigResponse
        /// </returns>
        public ListDataSourceWithConfigResponse ListDataSourceWithConfig(ListDataSourceWithConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceWithConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据源，所属结果包含数据源配置项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceWithConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceWithConfigResponse
        /// </returns>
        public async Task<ListDataSourceWithConfigResponse> ListDataSourceWithConfigAsync(ListDataSourceWithConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceWithConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历菜单树目录文件。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFilesResponse
        /// </returns>
        public ListFilesResponse ListFilesWithOptions(ListFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFilesShrinkRequest request = new ListFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFiles",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFilesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历菜单树目录文件。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListFilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFilesResponse
        /// </returns>
        public async Task<ListFilesResponse> ListFilesWithOptionsAsync(ListFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFilesShrinkRequest request = new ListFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFiles",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历菜单树目录文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFilesResponse
        /// </returns>
        public ListFilesResponse ListFiles(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>遍历菜单树目录文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFilesResponse
        /// </returns>
        public async Task<ListFilesResponse> ListFilesAsync(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFilesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点下游，创建补数据工作流时可以作为数据参考</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNodeDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeDownStreamResponse
        /// </returns>
        public ListNodeDownStreamResponse ListNodeDownStreamWithOptions(ListNodeDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodeDownStreamShrinkRequest request = new ListNodeDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeDownStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点下游，创建补数据工作流时可以作为数据参考</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNodeDownStreamRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeDownStreamResponse
        /// </returns>
        public async Task<ListNodeDownStreamResponse> ListNodeDownStreamWithOptionsAsync(ListNodeDownStreamRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodeDownStreamShrinkRequest request = new ListNodeDownStreamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeDownStream",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeDownStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点下游，创建补数据工作流时可以作为数据参考</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeDownStreamResponse
        /// </returns>
        public ListNodeDownStreamResponse ListNodeDownStream(ListNodeDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeDownStreamWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询节点下游，创建补数据工作流时可以作为数据参考</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeDownStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeDownStreamResponse
        /// </returns>
        public async Task<ListNodeDownStreamResponse> ListNodeDownStreamAsync(ListNodeDownStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeDownStreamWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点列表。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public ListNodesResponse ListNodesWithOptions(ListNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodesShrinkRequest request = new ListNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点列表。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodesShrinkRequest request = new ListNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度节点列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPublishRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishRecordsResponse
        /// </returns>
        public ListPublishRecordsResponse ListPublishRecordsWithOptions(ListPublishRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPublishRecordsShrinkRequest request = new ListPublishRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishRecords",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPublishRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishRecordsResponse
        /// </returns>
        public async Task<ListPublishRecordsResponse> ListPublishRecordsWithOptionsAsync(ListPublishRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPublishRecordsShrinkRequest request = new ListPublishRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishRecords",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishRecordsResponse
        /// </returns>
        public ListPublishRecordsResponse ListPublishRecords(ListPublishRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublishRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishRecordsResponse
        /// </returns>
        public async Task<ListPublishRecordsResponse> ListPublishRecordsAsync(ListPublishRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublishRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限操作列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListResourcePermissionOperationLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionOperationLogResponse
        /// </returns>
        public ListResourcePermissionOperationLogResponse ListResourcePermissionOperationLogWithOptions(ListResourcePermissionOperationLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourcePermissionOperationLogShrinkRequest request = new ListResourcePermissionOperationLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcePermissionOperationLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcePermissionOperationLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限操作列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListResourcePermissionOperationLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionOperationLogResponse
        /// </returns>
        public async Task<ListResourcePermissionOperationLogResponse> ListResourcePermissionOperationLogWithOptionsAsync(ListResourcePermissionOperationLogRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourcePermissionOperationLogShrinkRequest request = new ListResourcePermissionOperationLogShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcePermissionOperationLog",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcePermissionOperationLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限操作列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcePermissionOperationLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionOperationLogResponse
        /// </returns>
        public ListResourcePermissionOperationLogResponse ListResourcePermissionOperationLog(ListResourcePermissionOperationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourcePermissionOperationLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限操作列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcePermissionOperationLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionOperationLogResponse
        /// </returns>
        public async Task<ListResourcePermissionOperationLogResponse> ListResourcePermissionOperationLogAsync(ListResourcePermissionOperationLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourcePermissionOperationLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListResourcePermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionsResponse
        /// </returns>
        public ListResourcePermissionsResponse ListResourcePermissionsWithOptions(ListResourcePermissionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourcePermissionsShrinkRequest request = new ListResourcePermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcePermissions",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcePermissionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListResourcePermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionsResponse
        /// </returns>
        public async Task<ListResourcePermissionsResponse> ListResourcePermissionsWithOptionsAsync(ListResourcePermissionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourcePermissionsShrinkRequest request = new ListResourcePermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourcePermissions",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcePermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionsResponse
        /// </returns>
        public ListResourcePermissionsResponse ListResourcePermissions(ListResourcePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourcePermissionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取权限记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcePermissionsResponse
        /// </returns>
        public async Task<ListResourcePermissionsResponse> ListResourcePermissionsAsync(ListResourcePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourcePermissionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取待发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSubmitRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubmitRecordsResponse
        /// </returns>
        public ListSubmitRecordsResponse ListSubmitRecordsWithOptions(ListSubmitRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSubmitRecordsShrinkRequest request = new ListSubmitRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubmitRecords",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubmitRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取待发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSubmitRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubmitRecordsResponse
        /// </returns>
        public async Task<ListSubmitRecordsResponse> ListSubmitRecordsWithOptionsAsync(ListSubmitRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSubmitRecordsShrinkRequest request = new ListSubmitRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubmitRecords",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubmitRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取待发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubmitRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubmitRecordsResponse
        /// </returns>
        public ListSubmitRecordsResponse ListSubmitRecords(ListSubmitRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubmitRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取待发布记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubmitRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubmitRecordsResponse
        /// </returns>
        public async Task<ListSubmitRecordsResponse> ListSubmitRecordsAsync(ListSubmitRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubmitRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户成员列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTenantMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantMembersResponse
        /// </returns>
        public ListTenantMembersResponse ListTenantMembersWithOptions(ListTenantMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTenantMembersShrinkRequest request = new ListTenantMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantMembers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户成员列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTenantMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantMembersResponse
        /// </returns>
        public async Task<ListTenantMembersResponse> ListTenantMembersWithOptionsAsync(ListTenantMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTenantMembersShrinkRequest request = new ListTenantMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantMembers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTenantMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTenantMembersResponse
        /// </returns>
        public ListTenantMembersResponse ListTenantMembers(ListTenantMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTenantMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTenantMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTenantMembersResponse
        /// </returns>
        public async Task<ListTenantMembersResponse> ListTenantMembersAsync(ListTenantMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTenantMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组成员列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListUserGroupMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupMembersResponse
        /// </returns>
        public ListUserGroupMembersResponse ListUserGroupMembersWithOptions(ListUserGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserGroupMembersShrinkRequest request = new ListUserGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroupMembers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组成员列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListUserGroupMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupMembersResponse
        /// </returns>
        public async Task<ListUserGroupMembersResponse> ListUserGroupMembersWithOptionsAsync(ListUserGroupMembersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserGroupMembersShrinkRequest request = new ListUserGroupMembersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroupMembers",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组成员列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupMembersResponse
        /// </returns>
        public ListUserGroupMembersResponse ListUserGroupMembers(ListUserGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组成员列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupMembersResponse
        /// </returns>
        public async Task<ListUserGroupMembersResponse> ListUserGroupMembersAsync(ListUserGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListUserGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public ListUserGroupsResponse ListUserGroupsWithOptions(ListUserGroupsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserGroupsShrinkRequest request = new ListUserGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroups",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListUserGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public async Task<ListUserGroupsResponse> ListUserGroupsWithOptionsAsync(ListUserGroupsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserGroupsShrinkRequest request = new ListUserGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListQuery))
            {
                request.ListQueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListQuery, "ListQuery", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListQueryShrink))
            {
                body["ListQuery"] = request.ListQueryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroups",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户组列表分页查询.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public async Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineBatchTaskResponse
        /// </returns>
        public OfflineBatchTaskResponse OfflineBatchTaskWithOptions(OfflineBatchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineBatchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineBatchTaskResponse
        /// </returns>
        public async Task<OfflineBatchTaskResponse> OfflineBatchTaskWithOptionsAsync(OfflineBatchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineBatchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineBatchTaskResponse
        /// </returns>
        public OfflineBatchTaskResponse OfflineBatchTask(OfflineBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OfflineBatchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineBatchTaskResponse
        /// </returns>
        public async Task<OfflineBatchTaskResponse> OfflineBatchTaskAsync(OfflineBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OfflineBatchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线业务实体、</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OfflineBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineBizEntityResponse
        /// </returns>
        public OfflineBizEntityResponse OfflineBizEntityWithOptions(OfflineBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OfflineBizEntityShrinkRequest request = new OfflineBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OfflineCommand))
            {
                request.OfflineCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OfflineCommand, "OfflineCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineCommandShrink))
            {
                body["OfflineCommand"] = request.OfflineCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineBizEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线业务实体、</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OfflineBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineBizEntityResponse
        /// </returns>
        public async Task<OfflineBizEntityResponse> OfflineBizEntityWithOptionsAsync(OfflineBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OfflineBizEntityShrinkRequest request = new OfflineBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OfflineCommand))
            {
                request.OfflineCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OfflineCommand, "OfflineCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineCommandShrink))
            {
                body["OfflineCommand"] = request.OfflineCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineBizEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线业务实体、</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineBizEntityResponse
        /// </returns>
        public OfflineBizEntityResponse OfflineBizEntity(OfflineBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OfflineBizEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线业务实体、</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineBizEntityResponse
        /// </returns>
        public async Task<OfflineBizEntityResponse> OfflineBizEntityAsync(OfflineBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OfflineBizEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线业务实体。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OnlineBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineBizEntityResponse
        /// </returns>
        public OnlineBizEntityResponse OnlineBizEntityWithOptions(OnlineBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OnlineBizEntityShrinkRequest request = new OnlineBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OnlineCommand))
            {
                request.OnlineCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OnlineCommand, "OnlineCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineCommandShrink))
            {
                body["OnlineCommand"] = request.OnlineCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineBizEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线业务实体。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OnlineBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineBizEntityResponse
        /// </returns>
        public async Task<OnlineBizEntityResponse> OnlineBizEntityWithOptionsAsync(OnlineBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OnlineBizEntityShrinkRequest request = new OnlineBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OnlineCommand))
            {
                request.OnlineCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OnlineCommand, "OnlineCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineCommandShrink))
            {
                body["OnlineCommand"] = request.OnlineCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineBizEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineBizEntityResponse
        /// </returns>
        public OnlineBizEntityResponse OnlineBizEntity(OnlineBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnlineBizEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线业务实体。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineBizEntityResponse
        /// </returns>
        public async Task<OnlineBizEntityResponse> OnlineBizEntityAsync(OnlineBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnlineBizEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运维实例。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateInstanceResponse
        /// </returns>
        public OperateInstanceResponse OperateInstanceWithOptions(OperateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateInstanceShrinkRequest request = new OperateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperateCommand))
            {
                request.OperateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperateCommand, "OperateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCommandShrink))
            {
                body["OperateCommand"] = request.OperateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateInstance",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运维实例。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateInstanceResponse
        /// </returns>
        public async Task<OperateInstanceResponse> OperateInstanceWithOptionsAsync(OperateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateInstanceShrinkRequest request = new OperateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperateCommand))
            {
                request.OperateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperateCommand, "OperateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCommandShrink))
            {
                body["OperateCommand"] = request.OperateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateInstance",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运维实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateInstanceResponse
        /// </returns>
        public OperateInstanceResponse OperateInstance(OperateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运维实例。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateInstanceResponse
        /// </returns>
        public async Task<OperateInstanceResponse> OperateInstanceAsync(OperateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析离线计算任务的逻辑表依赖，注意解析结果上游依赖信息中可能包含自依赖节点（上游节点ID和解析代码的任务节点ID相同）需要用户自己进行处理。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ParseBatchTaskDependencyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ParseBatchTaskDependencyResponse
        /// </returns>
        public ParseBatchTaskDependencyResponse ParseBatchTaskDependencyWithOptions(ParseBatchTaskDependencyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ParseBatchTaskDependencyShrinkRequest request = new ParseBatchTaskDependencyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParseCommand))
            {
                request.ParseCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParseCommand, "ParseCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParseCommandShrink))
            {
                body["ParseCommand"] = request.ParseCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ParseBatchTaskDependency",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ParseBatchTaskDependencyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析离线计算任务的逻辑表依赖，注意解析结果上游依赖信息中可能包含自依赖节点（上游节点ID和解析代码的任务节点ID相同）需要用户自己进行处理。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ParseBatchTaskDependencyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ParseBatchTaskDependencyResponse
        /// </returns>
        public async Task<ParseBatchTaskDependencyResponse> ParseBatchTaskDependencyWithOptionsAsync(ParseBatchTaskDependencyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ParseBatchTaskDependencyShrinkRequest request = new ParseBatchTaskDependencyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParseCommand))
            {
                request.ParseCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParseCommand, "ParseCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParseCommandShrink))
            {
                body["ParseCommand"] = request.ParseCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ParseBatchTaskDependency",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ParseBatchTaskDependencyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析离线计算任务的逻辑表依赖，注意解析结果上游依赖信息中可能包含自依赖节点（上游节点ID和解析代码的任务节点ID相同）需要用户自己进行处理。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ParseBatchTaskDependencyRequest
        /// </param>
        /// 
        /// <returns>
        /// ParseBatchTaskDependencyResponse
        /// </returns>
        public ParseBatchTaskDependencyResponse ParseBatchTaskDependency(ParseBatchTaskDependencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ParseBatchTaskDependencyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析离线计算任务的逻辑表依赖，注意解析结果上游依赖信息中可能包含自依赖节点（上游节点ID和解析代码的任务节点ID相同）需要用户自己进行处理。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ParseBatchTaskDependencyRequest
        /// </param>
        /// 
        /// <returns>
        /// ParseBatchTaskDependencyResponse
        /// </returns>
        public async Task<ParseBatchTaskDependencyResponse> ParseBatchTaskDependencyAsync(ParseBatchTaskDependencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ParseBatchTaskDependencyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PausePhysicalNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PausePhysicalNodeResponse
        /// </returns>
        public PausePhysicalNodeResponse PausePhysicalNodeWithOptions(PausePhysicalNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PausePhysicalNodeShrinkRequest request = new PausePhysicalNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PauseCommand))
            {
                request.PauseCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PauseCommand, "PauseCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseCommandShrink))
            {
                body["PauseCommand"] = request.PauseCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PausePhysicalNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PausePhysicalNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PausePhysicalNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PausePhysicalNodeResponse
        /// </returns>
        public async Task<PausePhysicalNodeResponse> PausePhysicalNodeWithOptionsAsync(PausePhysicalNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PausePhysicalNodeShrinkRequest request = new PausePhysicalNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PauseCommand))
            {
                request.PauseCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PauseCommand, "PauseCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseCommandShrink))
            {
                body["PauseCommand"] = request.PauseCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PausePhysicalNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PausePhysicalNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PausePhysicalNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// PausePhysicalNodeResponse
        /// </returns>
        public PausePhysicalNodeResponse PausePhysicalNode(PausePhysicalNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PausePhysicalNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PausePhysicalNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// PausePhysicalNodeResponse
        /// </returns>
        public async Task<PausePhysicalNodeResponse> PausePhysicalNodeAsync(PausePhysicalNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PausePhysicalNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布对象</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PublishObjectListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishObjectListResponse
        /// </returns>
        public PublishObjectListResponse PublishObjectListWithOptions(PublishObjectListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PublishObjectListShrinkRequest request = new PublishObjectListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PublishCommand))
            {
                request.PublishCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PublishCommand, "PublishCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishCommandShrink))
            {
                body["PublishCommand"] = request.PublishCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishObjectList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishObjectListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布对象</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PublishObjectListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishObjectListResponse
        /// </returns>
        public async Task<PublishObjectListResponse> PublishObjectListWithOptionsAsync(PublishObjectListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PublishObjectListShrinkRequest request = new PublishObjectListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PublishCommand))
            {
                request.PublishCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PublishCommand, "PublishCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishCommandShrink))
            {
                body["PublishCommand"] = request.PublishCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishObjectList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishObjectListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布对象</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishObjectListRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishObjectListResponse
        /// </returns>
        public PublishObjectListResponse PublishObjectList(PublishObjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishObjectListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布对象</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishObjectListRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishObjectListResponse
        /// </returns>
        public async Task<PublishObjectListResponse> PublishObjectListAsync(PublishObjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishObjectListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除租户成员</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveTenantMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantMemberResponse
        /// </returns>
        public RemoveTenantMemberResponse RemoveTenantMemberWithOptions(RemoveTenantMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveTenantMemberShrinkRequest request = new RemoveTenantMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RemoveCommand))
            {
                request.RemoveCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RemoveCommand, "RemoveCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveCommandShrink))
            {
                body["RemoveCommand"] = request.RemoveCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTenantMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTenantMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除租户成员</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveTenantMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantMemberResponse
        /// </returns>
        public async Task<RemoveTenantMemberResponse> RemoveTenantMemberWithOptionsAsync(RemoveTenantMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveTenantMemberShrinkRequest request = new RemoveTenantMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RemoveCommand))
            {
                request.RemoveCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RemoveCommand, "RemoveCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveCommandShrink))
            {
                body["RemoveCommand"] = request.RemoveCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTenantMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTenantMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除租户成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTenantMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantMemberResponse
        /// </returns>
        public RemoveTenantMemberResponse RemoveTenantMember(RemoveTenantMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTenantMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除租户成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveTenantMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveTenantMemberResponse
        /// </returns>
        public async Task<RemoveTenantMemberResponse> RemoveTenantMemberAsync(RemoveTenantMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTenantMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveUserGroupMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserGroupMemberResponse
        /// </returns>
        public RemoveUserGroupMemberResponse RemoveUserGroupMemberWithOptions(RemoveUserGroupMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveUserGroupMemberShrinkRequest request = new RemoveUserGroupMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RemoveCommand))
            {
                request.RemoveCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RemoveCommand, "RemoveCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveCommandShrink))
            {
                body["RemoveCommand"] = request.RemoveCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserGroupMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserGroupMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveUserGroupMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserGroupMemberResponse
        /// </returns>
        public async Task<RemoveUserGroupMemberResponse> RemoveUserGroupMemberWithOptionsAsync(RemoveUserGroupMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveUserGroupMemberShrinkRequest request = new RemoveUserGroupMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RemoveCommand))
            {
                request.RemoveCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RemoveCommand, "RemoveCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveCommandShrink))
            {
                body["RemoveCommand"] = request.RemoveCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserGroupMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserGroupMemberResponse
        /// </returns>
        public RemoveUserGroupMemberResponse RemoveUserGroupMember(RemoveUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserGroupMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除用户组成员.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserGroupMemberResponse
        /// </returns>
        public async Task<RemoveUserGroupMemberResponse> RemoveUserGroupMemberAsync(RemoveUserGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserGroupMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResumePhysicalNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumePhysicalNodeResponse
        /// </returns>
        public ResumePhysicalNodeResponse ResumePhysicalNodeWithOptions(ResumePhysicalNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResumePhysicalNodeShrinkRequest request = new ResumePhysicalNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResumeCommand))
            {
                request.ResumeCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResumeCommand, "ResumeCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeCommandShrink))
            {
                body["ResumeCommand"] = request.ResumeCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumePhysicalNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumePhysicalNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResumePhysicalNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumePhysicalNodeResponse
        /// </returns>
        public async Task<ResumePhysicalNodeResponse> ResumePhysicalNodeWithOptionsAsync(ResumePhysicalNodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResumePhysicalNodeShrinkRequest request = new ResumePhysicalNodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResumeCommand))
            {
                request.ResumeCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResumeCommand, "ResumeCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResumeCommandShrink))
            {
                body["ResumeCommand"] = request.ResumeCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumePhysicalNode",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumePhysicalNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumePhysicalNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumePhysicalNodeResponse
        /// </returns>
        public ResumePhysicalNodeResponse ResumePhysicalNode(ResumePhysicalNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumePhysicalNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复物理节点调度。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumePhysicalNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumePhysicalNodeResponse
        /// </returns>
        public async Task<ResumePhysicalNodeResponse> ResumePhysicalNodeAsync(ResumePhysicalNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumePhysicalNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回收用户资源授权</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RevokeResourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeResourcePermissionResponse
        /// </returns>
        public RevokeResourcePermissionResponse RevokeResourcePermissionWithOptions(RevokeResourcePermissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevokeResourcePermissionShrinkRequest request = new RevokeResourcePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RevokeCommand))
            {
                request.RevokeCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RevokeCommand, "RevokeCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevokeCommandShrink))
            {
                body["RevokeCommand"] = request.RevokeCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeResourcePermission",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeResourcePermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回收用户资源授权</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RevokeResourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeResourcePermissionResponse
        /// </returns>
        public async Task<RevokeResourcePermissionResponse> RevokeResourcePermissionWithOptionsAsync(RevokeResourcePermissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevokeResourcePermissionShrinkRequest request = new RevokeResourcePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RevokeCommand))
            {
                request.RevokeCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RevokeCommand, "RevokeCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevokeCommandShrink))
            {
                body["RevokeCommand"] = request.RevokeCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeResourcePermission",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeResourcePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回收用户资源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeResourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeResourcePermissionResponse
        /// </returns>
        public RevokeResourcePermissionResponse RevokeResourcePermission(RevokeResourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeResourcePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回收用户资源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeResourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeResourcePermissionResponse
        /// </returns>
        public async Task<RevokeResourcePermissionResponse> RevokeResourcePermissionAsync(RevokeResourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeResourcePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAdHocTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAdHocTaskResponse
        /// </returns>
        public StopAdHocTaskResponse StopAdHocTaskWithOptions(StopAdHocTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAdHocTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAdHocTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAdHocTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAdHocTaskResponse
        /// </returns>
        public async Task<StopAdHocTaskResponse> StopAdHocTaskWithOptionsAsync(StopAdHocTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAdHocTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAdHocTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAdHocTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAdHocTaskResponse
        /// </returns>
        public StopAdHocTaskResponse StopAdHocTask(StopAdHocTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAdHocTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止即席查询任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAdHocTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAdHocTaskResponse
        /// </returns>
        public async Task<StopAdHocTaskResponse> StopAdHocTaskAsync(StopAdHocTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAdHocTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchTaskResponse
        /// </returns>
        public SubmitBatchTaskResponse SubmitBatchTaskWithOptions(SubmitBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitBatchTaskShrinkRequest request = new SubmitBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubmitCommand))
            {
                request.SubmitCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubmitCommand, "SubmitCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitCommandShrink))
            {
                body["SubmitCommand"] = request.SubmitCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBatchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchTaskResponse
        /// </returns>
        public async Task<SubmitBatchTaskResponse> SubmitBatchTaskWithOptionsAsync(SubmitBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitBatchTaskShrinkRequest request = new SubmitBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubmitCommand))
            {
                request.SubmitCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubmitCommand, "SubmitCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitCommandShrink))
            {
                body["SubmitCommand"] = request.SubmitCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBatchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchTaskResponse
        /// </returns>
        public SubmitBatchTaskResponse SubmitBatchTask(SubmitBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitBatchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitBatchTaskResponse
        /// </returns>
        public async Task<SubmitBatchTaskResponse> SubmitBatchTaskAsync(SubmitBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitBatchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdHocFileResponse
        /// </returns>
        public UpdateAdHocFileResponse UpdateAdHocFileWithOptions(UpdateAdHocFileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAdHocFileShrinkRequest request = new UpdateAdHocFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAdHocFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAdHocFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdHocFileResponse
        /// </returns>
        public async Task<UpdateAdHocFileResponse> UpdateAdHocFileWithOptionsAsync(UpdateAdHocFileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAdHocFileShrinkRequest request = new UpdateAdHocFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAdHocFile",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAdHocFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdHocFileResponse
        /// </returns>
        public UpdateAdHocFileResponse UpdateAdHocFile(UpdateAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAdHocFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑即席查询文件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAdHocFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdHocFileResponse
        /// </returns>
        public async Task<UpdateAdHocFileResponse> UpdateAdHocFileAsync(UpdateAdHocFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAdHocFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskResponse
        /// </returns>
        public UpdateBatchTaskResponse UpdateBatchTaskWithOptions(UpdateBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBatchTaskShrinkRequest request = new UpdateBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBatchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskResponse
        /// </returns>
        public async Task<UpdateBatchTaskResponse> UpdateBatchTaskWithOptionsAsync(UpdateBatchTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBatchTaskShrinkRequest request = new UpdateBatchTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatchTask",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskResponse
        /// </returns>
        public UpdateBatchTaskResponse UpdateBatchTask(UpdateBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBatchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBatchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskResponse
        /// </returns>
        public async Task<UpdateBatchTaskResponse> UpdateBatchTaskAsync(UpdateBatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBatchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBatchTaskUdfLineagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskUdfLineagesResponse
        /// </returns>
        public UpdateBatchTaskUdfLineagesResponse UpdateBatchTaskUdfLineagesWithOptions(UpdateBatchTaskUdfLineagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBatchTaskUdfLineagesShrinkRequest request = new UpdateBatchTaskUdfLineagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatchTaskUdfLineages",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchTaskUdfLineagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBatchTaskUdfLineagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskUdfLineagesResponse
        /// </returns>
        public async Task<UpdateBatchTaskUdfLineagesResponse> UpdateBatchTaskUdfLineagesWithOptionsAsync(UpdateBatchTaskUdfLineagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBatchTaskUdfLineagesShrinkRequest request = new UpdateBatchTaskUdfLineagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatchTaskUdfLineages",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchTaskUdfLineagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBatchTaskUdfLineagesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskUdfLineagesResponse
        /// </returns>
        public UpdateBatchTaskUdfLineagesResponse UpdateBatchTaskUdfLineages(UpdateBatchTaskUdfLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBatchTaskUdfLineagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑离线计算任务自定义血缘。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBatchTaskUdfLineagesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBatchTaskUdfLineagesResponse
        /// </returns>
        public async Task<UpdateBatchTaskUdfLineagesResponse> UpdateBatchTaskUdfLineagesAsync(UpdateBatchTaskUdfLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBatchTaskUdfLineagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体、</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizEntityResponse
        /// </returns>
        public UpdateBizEntityResponse UpdateBizEntityWithOptions(UpdateBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBizEntityShrinkRequest request = new UpdateBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体、</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBizEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizEntityResponse
        /// </returns>
        public async Task<UpdateBizEntityResponse> UpdateBizEntityWithOptionsAsync(UpdateBizEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBizEntityShrinkRequest request = new UpdateBizEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizEntity",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体、</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizEntityResponse
        /// </returns>
        public UpdateBizEntityResponse UpdateBizEntity(UpdateBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBizEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新业务实体、</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizEntityResponse
        /// </returns>
        public async Task<UpdateBizEntityResponse> UpdateBizEntityAsync(UpdateBizEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBizEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据板块。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBizUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizUnitResponse
        /// </returns>
        public UpdateBizUnitResponse UpdateBizUnitWithOptions(UpdateBizUnitRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBizUnitShrinkRequest request = new UpdateBizUnitShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizUnit",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizUnitResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据板块。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBizUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizUnitResponse
        /// </returns>
        public async Task<UpdateBizUnitResponse> UpdateBizUnitWithOptionsAsync(UpdateBizUnitRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBizUnitShrinkRequest request = new UpdateBizUnitShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBizUnit",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBizUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizUnitResponse
        /// </returns>
        public UpdateBizUnitResponse UpdateBizUnit(UpdateBizUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBizUnitWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据板块。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBizUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBizUnitResponse
        /// </returns>
        public async Task<UpdateBizUnitResponse> UpdateBizUnitAsync(UpdateBizUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBizUnitWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新主题域。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataDomainResponse
        /// </returns>
        public UpdateDataDomainResponse UpdateDataDomainWithOptions(UpdateDataDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataDomainShrinkRequest request = new UpdateDataDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataDomain",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新主题域。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataDomainResponse
        /// </returns>
        public async Task<UpdateDataDomainResponse> UpdateDataDomainWithOptionsAsync(UpdateDataDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataDomainShrinkRequest request = new UpdateDataDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataDomain",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataDomainResponse
        /// </returns>
        public UpdateDataDomainResponse UpdateDataDomain(UpdateDataDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新主题域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataDomainResponse
        /// </returns>
        public async Task<UpdateDataDomainResponse> UpdateDataDomainAsync(UpdateDataDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源基本信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataSourceBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceBasicInfoResponse
        /// </returns>
        public UpdateDataSourceBasicInfoResponse UpdateDataSourceBasicInfoWithOptions(UpdateDataSourceBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataSourceBasicInfoShrinkRequest request = new UpdateDataSourceBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSourceBasicInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源基本信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataSourceBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceBasicInfoResponse
        /// </returns>
        public async Task<UpdateDataSourceBasicInfoResponse> UpdateDataSourceBasicInfoWithOptionsAsync(UpdateDataSourceBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataSourceBasicInfoShrinkRequest request = new UpdateDataSourceBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSourceBasicInfo",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceBasicInfoResponse
        /// </returns>
        public UpdateDataSourceBasicInfoResponse UpdateDataSourceBasicInfo(UpdateDataSourceBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSourceBasicInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceBasicInfoResponse
        /// </returns>
        public async Task<UpdateDataSourceBasicInfoResponse> UpdateDataSourceBasicInfoAsync(UpdateDataSourceBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceBasicInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源连接配置项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataSourceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceConfigResponse
        /// </returns>
        public UpdateDataSourceConfigResponse UpdateDataSourceConfigWithOptions(UpdateDataSourceConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataSourceConfigShrinkRequest request = new UpdateDataSourceConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSourceConfig",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源连接配置项</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataSourceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceConfigResponse
        /// </returns>
        public async Task<UpdateDataSourceConfigResponse> UpdateDataSourceConfigWithOptionsAsync(UpdateDataSourceConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataSourceConfigShrinkRequest request = new UpdateDataSourceConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSourceConfig",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源连接配置项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceConfigResponse
        /// </returns>
        public UpdateDataSourceConfigResponse UpdateDataSourceConfig(UpdateDataSourceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSourceConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑数据源连接配置项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceConfigResponse
        /// </returns>
        public async Task<UpdateDataSourceConfigResponse> UpdateDataSourceConfigAsync(UpdateDataSourceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件所在目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileDirectoryResponse
        /// </returns>
        public UpdateFileDirectoryResponse UpdateFileDirectoryWithOptions(UpdateFileDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Directory))
            {
                query["Directory"] = request.Directory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileDirectory",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件所在目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileDirectoryResponse
        /// </returns>
        public async Task<UpdateFileDirectoryResponse> UpdateFileDirectoryWithOptionsAsync(UpdateFileDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Directory))
            {
                query["Directory"] = request.Directory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileDirectory",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件所在目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileDirectoryResponse
        /// </returns>
        public UpdateFileDirectoryResponse UpdateFileDirectory(UpdateFileDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFileDirectoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件所在目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileDirectoryResponse
        /// </returns>
        public async Task<UpdateFileDirectoryResponse> UpdateFileDirectoryAsync(UpdateFileDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFileDirectoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileNameResponse
        /// </returns>
        public UpdateFileNameResponse UpdateFileNameWithOptions(UpdateFileNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileName",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileNameResponse
        /// </returns>
        public async Task<UpdateFileNameResponse> UpdateFileNameWithOptionsAsync(UpdateFileNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileName",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileNameResponse
        /// </returns>
        public UpdateFileNameResponse UpdateFileName(UpdateFileNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFileNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改菜单树文件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFileNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileNameResponse
        /// </returns>
        public async Task<UpdateFileNameResponse> UpdateFileNameAsync(UpdateFileNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFileNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑租户成员</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTenantMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantMemberResponse
        /// </returns>
        public UpdateTenantMemberResponse UpdateTenantMemberWithOptions(UpdateTenantMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTenantMemberShrinkRequest request = new UpdateTenantMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTenantMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTenantMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑租户成员</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTenantMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantMemberResponse
        /// </returns>
        public async Task<UpdateTenantMemberResponse> UpdateTenantMemberWithOptionsAsync(UpdateTenantMemberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTenantMemberShrinkRequest request = new UpdateTenantMemberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTenantMember",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTenantMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑租户成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTenantMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantMemberResponse
        /// </returns>
        public UpdateTenantMemberResponse UpdateTenantMember(UpdateTenantMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTenantMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑租户成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTenantMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantMemberResponse
        /// </returns>
        public async Task<UpdateTenantMemberResponse> UpdateTenantMemberAsync(UpdateTenantMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTenantMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public UpdateUserGroupResponse UpdateUserGroupWithOptions(UpdateUserGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserGroupShrinkRequest request = new UpdateUserGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public async Task<UpdateUserGroupResponse> UpdateUserGroupWithOptionsAsync(UpdateUserGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserGroupShrinkRequest request = new UpdateUserGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateCommand))
            {
                request.UpdateCommandShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateCommand, "UpdateCommand", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateCommandShrink))
            {
                body["UpdateCommand"] = request.UpdateCommandShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGroup",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public UpdateUserGroupResponse UpdateUserGroup(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public async Task<UpdateUserGroupResponse> UpdateUserGroupAsync(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组启用开关.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupSwitchResponse
        /// </returns>
        public UpdateUserGroupSwitchResponse UpdateUserGroupSwitchWithOptions(UpdateUserGroupSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGroupSwitch",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupSwitchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组启用开关.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupSwitchResponse
        /// </returns>
        public async Task<UpdateUserGroupSwitchResponse> UpdateUserGroupSwitchWithOptionsAsync(UpdateUserGroupSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTenantId))
            {
                query["OpTenantId"] = request.OpTenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserGroupSwitch",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组启用开关.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupSwitchResponse
        /// </returns>
        public UpdateUserGroupSwitchResponse UpdateUserGroupSwitch(UpdateUserGroupSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserGroupSwitchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户组启用开关.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupSwitchResponse
        /// </returns>
        public async Task<UpdateUserGroupSwitchResponse> UpdateUserGroupSwitchAsync(UpdateUserGroupSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserGroupSwitchWithOptionsAsync(request, runtime);
        }

    }
}
