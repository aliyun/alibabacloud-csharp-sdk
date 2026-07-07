// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ecd20210602.Models;

namespace AlibabaCloud.SDK.Ecd20210602
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"us-west-1", "ecd.us-west-1.aliyuncs.com"},
                {"us-east-1", "ecd.us-east-1.aliyuncs.com"},
                {"me-east-1", "ecd.me-east-1.aliyuncs.com"},
                {"me-central-1", "ecd.me-central-1.aliyuncs.com"},
                {"eu-west-1", "ecd.eu-west-1.aliyuncs.com"},
                {"eu-central-1", "ecd.eu-central-1.aliyuncs.com"},
                {"cn-zhangjiakou", "ecd.cn-zhangjiakou.aliyuncs.com"},
                {"cn-wulanchabu", "ecd.cn-wulanchabu.aliyuncs.com"},
                {"cn-shenzhen", "ecd.cn-shenzhen.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ecd.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-shanghai", "ecd.cn-shanghai.aliyuncs.com"},
                {"cn-qingdao", "ecd.cn-qingdao.aliyuncs.com"},
                {"cn-nanjing", "ecd.cn-nanjing.aliyuncs.com"},
                {"cn-hongkong", "ecd.cn-hongkong.aliyuncs.com"},
                {"cn-hangzhou-finance", "ecd.cn-hangzhou-finance.aliyuncs.com"},
                {"cn-hangzhou", "ecd.cn-hangzhou.aliyuncs.com"},
                {"cn-guangzhou", "ecd.cn-guangzhou.aliyuncs.com"},
                {"cn-chengdu", "ecd.cn-chengdu.aliyuncs.com"},
                {"cn-beijing", "ecd.cn-beijing.aliyuncs.com"},
                {"ap-southeast-7", "ecd.ap-southeast-7.aliyuncs.com"},
                {"ap-southeast-6", "ecd.ap-southeast-6.aliyuncs.com"},
                {"ap-southeast-5", "ecd.ap-southeast-5.aliyuncs.com"},
                {"ap-southeast-1", "ecd.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-1", "ecd.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecd", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates a tenant skill.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTenantSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantSkillResponse
        /// </returns>
        public CreateTenantSkillResponse CreateTenantSkillWithOptions(CreateTenantSkillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantSkillShrinkRequest request = new CreateTenantSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EnvVars))
            {
                request.EnvVarsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EnvVars, "EnvVars", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvVarsShrink))
            {
                query["EnvVars"] = request.EnvVarsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconETag))
            {
                query["IconETag"] = request.IconETag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIcon))
            {
                query["SkillIcon"] = request.SkillIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillVersion))
            {
                query["SkillVersion"] = request.SkillVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slug))
            {
                query["Slug"] = request.Slug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskKey))
            {
                query["TaskKey"] = request.TaskKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantSkill",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tenant skill.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTenantSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantSkillResponse
        /// </returns>
        public async Task<CreateTenantSkillResponse> CreateTenantSkillWithOptionsAsync(CreateTenantSkillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantSkillShrinkRequest request = new CreateTenantSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EnvVars))
            {
                request.EnvVarsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EnvVars, "EnvVars", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvVarsShrink))
            {
                query["EnvVars"] = request.EnvVarsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconETag))
            {
                query["IconETag"] = request.IconETag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIcon))
            {
                query["SkillIcon"] = request.SkillIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillVersion))
            {
                query["SkillVersion"] = request.SkillVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slug))
            {
                query["Slug"] = request.Slug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskKey))
            {
                query["TaskKey"] = request.TaskKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantSkill",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tenant skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTenantSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantSkillResponse
        /// </returns>
        public CreateTenantSkillResponse CreateTenantSkill(CreateTenantSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tenant skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTenantSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantSkillResponse
        /// </returns>
        public async Task<CreateTenantSkillResponse> CreateTenantSkillAsync(CreateTenantSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes skills in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTenantSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantSkillsResponse
        /// </returns>
        public DeleteTenantSkillsResponse DeleteTenantSkillsWithOptions(DeleteTenantSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantSkills",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes skills in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTenantSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantSkillsResponse
        /// </returns>
        public async Task<DeleteTenantSkillsResponse> DeleteTenantSkillsWithOptionsAsync(DeleteTenantSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantSkills",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes skills in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTenantSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantSkillsResponse
        /// </returns>
        public DeleteTenantSkillsResponse DeleteTenantSkills(DeleteTenantSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTenantSkillsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes skills in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTenantSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantSkillsResponse
        /// </returns>
        public async Task<DeleteTenantSkillsResponse> DeleteTenantSkillsAsync(DeleteTenantSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTenantSkillsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OSS STS 令牌</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取到的SecurityToken有效期为15分钟。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOssStsTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssStsTokenResponse
        /// </returns>
        public GetOssStsTokenResponse GetOssStsTokenWithOptions(GetOssStsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetOssStsToken",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssStsTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OSS STS 令牌</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取到的SecurityToken有效期为15分钟。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOssStsTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssStsTokenResponse
        /// </returns>
        public async Task<GetOssStsTokenResponse> GetOssStsTokenWithOptionsAsync(GetOssStsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetOssStsToken",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssStsTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OSS STS 令牌</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取到的SecurityToken有效期为15分钟。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOssStsTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssStsTokenResponse
        /// </returns>
        public GetOssStsTokenResponse GetOssStsToken(GetOssStsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOssStsTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 OSS STS 令牌</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取到的SecurityToken有效期为15分钟。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOssStsTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssStsTokenResponse
        /// </returns>
        public async Task<GetOssStsTokenResponse> GetOssStsTokenAsync(GetOssStsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOssStsTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the parsed content of a skill package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ParseSkillPackage operation first. Poll this operation every 3 seconds.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseProgressResponse
        /// </returns>
        public GetParseProgressResponse GetParseProgressWithOptions(GetParseProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskKey))
            {
                query["TaskKey"] = request.TaskKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseProgress",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the parsed content of a skill package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ParseSkillPackage operation first. Poll this operation every 3 seconds.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseProgressResponse
        /// </returns>
        public async Task<GetParseProgressResponse> GetParseProgressWithOptionsAsync(GetParseProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskKey))
            {
                query["TaskKey"] = request.TaskKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseProgress",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the parsed content of a skill package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ParseSkillPackage operation first. Poll this operation every 3 seconds.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseProgressResponse
        /// </returns>
        public GetParseProgressResponse GetParseProgress(GetParseProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParseProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the parsed content of a skill package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ParseSkillPackage operation first. Poll this operation every 3 seconds.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseProgressResponse
        /// </returns>
        public async Task<GetParseProgressResponse> GetParseProgressAsync(GetParseProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParseProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities for which security policies are enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecureSkillIdentitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecureSkillIdentitiesResponse
        /// </returns>
        public ListSecureSkillIdentitiesResponse ListSecureSkillIdentitiesWithOptions(ListSecureSkillIdentitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecureSkillIdentities",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecureSkillIdentitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities for which security policies are enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecureSkillIdentitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecureSkillIdentitiesResponse
        /// </returns>
        public async Task<ListSecureSkillIdentitiesResponse> ListSecureSkillIdentitiesWithOptionsAsync(ListSecureSkillIdentitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecureSkillIdentities",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecureSkillIdentitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities for which security policies are enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecureSkillIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecureSkillIdentitiesResponse
        /// </returns>
        public ListSecureSkillIdentitiesResponse ListSecureSkillIdentities(ListSecureSkillIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecureSkillIdentitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities for which security policies are enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecureSkillIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecureSkillIdentitiesResponse
        /// </returns>
        public async Task<ListSecureSkillIdentitiesResponse> ListSecureSkillIdentitiesAsync(ListSecureSkillIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecureSkillIdentitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities authorized for a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Authorized objects support only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillAuthedIdentitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillAuthedIdentitiesResponse
        /// </returns>
        public ListSkillAuthedIdentitiesResponse ListSkillAuthedIdentitiesWithOptions(ListSkillAuthedIdentitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillAuthedIdentities",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillAuthedIdentitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities authorized for a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Authorized objects support only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillAuthedIdentitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillAuthedIdentitiesResponse
        /// </returns>
        public async Task<ListSkillAuthedIdentitiesResponse> ListSkillAuthedIdentitiesWithOptionsAsync(ListSkillAuthedIdentitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillAuthedIdentities",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillAuthedIdentitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities authorized for a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Authorized objects support only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillAuthedIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillAuthedIdentitiesResponse
        /// </returns>
        public ListSkillAuthedIdentitiesResponse ListSkillAuthedIdentities(ListSkillAuthedIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillAuthedIdentitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of identities authorized for a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Authorized objects support only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillAuthedIdentitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillAuthedIdentitiesResponse
        /// </returns>
        public async Task<ListSkillAuthedIdentitiesResponse> ListSkillAuthedIdentitiesAsync(ListSkillAuthedIdentitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillAuthedIdentitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkillsWithOptions(ListSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierType))
            {
                query["SupplierType"] = request.SupplierType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsWithOptionsAsync(ListSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierType))
            {
                query["SupplierType"] = request.SupplierType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkills(ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsAsync(ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses a skill package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ParseSkillPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ParseSkillPackageResponse
        /// </returns>
        public ParseSkillPackageResponse ParseSkillPackageWithOptions(ParseSkillPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectETag))
            {
                query["OssObjectETag"] = request.OssObjectETag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectKey))
            {
                query["OssObjectKey"] = request.OssObjectKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ParseSkillPackage",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ParseSkillPackageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses a skill package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ParseSkillPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ParseSkillPackageResponse
        /// </returns>
        public async Task<ParseSkillPackageResponse> ParseSkillPackageWithOptionsAsync(ParseSkillPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectETag))
            {
                query["OssObjectETag"] = request.OssObjectETag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectKey))
            {
                query["OssObjectKey"] = request.OssObjectKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ParseSkillPackage",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ParseSkillPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses a skill package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ParseSkillPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// ParseSkillPackageResponse
        /// </returns>
        public ParseSkillPackageResponse ParseSkillPackage(ParseSkillPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ParseSkillPackageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses a skill package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ParseSkillPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// ParseSkillPackageResponse
        /// </returns>
        public async Task<ParseSkillPackageResponse> ParseSkillPackageAsync(ParseSkillPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ParseSkillPackageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets skill permissions for an identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The authorized object supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillAuthResponse
        /// </returns>
        public SetIdentitySkillAuthResponse SetIdentitySkillAuthWithOptions(SetIdentitySkillAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                query["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identities))
            {
                query["Identities"] = request.Identities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetIdentitySkillAuth",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetIdentitySkillAuthResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets skill permissions for an identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The authorized object supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillAuthResponse
        /// </returns>
        public async Task<SetIdentitySkillAuthResponse> SetIdentitySkillAuthWithOptionsAsync(SetIdentitySkillAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                query["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identities))
            {
                query["Identities"] = request.Identities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetIdentitySkillAuth",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetIdentitySkillAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets skill permissions for an identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The authorized object supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillAuthResponse
        /// </returns>
        public SetIdentitySkillAuthResponse SetIdentitySkillAuth(SetIdentitySkillAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetIdentitySkillAuthWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets skill permissions for an identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The authorized object supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillAuthResponse
        /// </returns>
        public async Task<SetIdentitySkillAuthResponse> SetIdentitySkillAuthAsync(SetIdentitySkillAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetIdentitySkillAuthWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the security policy for identity skills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillSecurityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillSecurityResponse
        /// </returns>
        public SetIdentitySkillSecurityResponse SetIdentitySkillSecurityWithOptions(SetIdentitySkillSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityIds))
            {
                query["IdentityIds"] = request.IdentityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetIdentitySkillSecurity",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetIdentitySkillSecurityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the security policy for identity skills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillSecurityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillSecurityResponse
        /// </returns>
        public async Task<SetIdentitySkillSecurityResponse> SetIdentitySkillSecurityWithOptionsAsync(SetIdentitySkillSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityIds))
            {
                query["IdentityIds"] = request.IdentityIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetIdentitySkillSecurity",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetIdentitySkillSecurityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the security policy for identity skills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillSecurityRequest
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillSecurityResponse
        /// </returns>
        public SetIdentitySkillSecurityResponse SetIdentitySkillSecurity(SetIdentitySkillSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetIdentitySkillSecurityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the security policy for identity skills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The resource type supports only cloud computers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetIdentitySkillSecurityRequest
        /// </param>
        /// 
        /// <returns>
        /// SetIdentitySkillSecurityResponse
        /// </returns>
        public async Task<SetIdentitySkillSecurityResponse> SetIdentitySkillSecurityAsync(SetIdentitySkillSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetIdentitySkillSecurityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置租户技能启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTenantSkillEnabledRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTenantSkillEnabledResponse
        /// </returns>
        public SetTenantSkillEnabledResponse SetTenantSkillEnabledWithOptions(SetTenantSkillEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTenantSkillEnabled",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTenantSkillEnabledResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置租户技能启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTenantSkillEnabledRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTenantSkillEnabledResponse
        /// </returns>
        public async Task<SetTenantSkillEnabledResponse> SetTenantSkillEnabledWithOptionsAsync(SetTenantSkillEnabledRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillChannel))
            {
                query["SkillChannel"] = request.SkillChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTenantSkillEnabled",
                Version = "2021-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTenantSkillEnabledResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置租户技能启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTenantSkillEnabledRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTenantSkillEnabledResponse
        /// </returns>
        public SetTenantSkillEnabledResponse SetTenantSkillEnabled(SetTenantSkillEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTenantSkillEnabledWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置租户技能启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetTenantSkillEnabledRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTenantSkillEnabledResponse
        /// </returns>
        public async Task<SetTenantSkillEnabledResponse> SetTenantSkillEnabledAsync(SetTenantSkillEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTenantSkillEnabledWithOptionsAsync(request, runtime);
        }

    }
}
