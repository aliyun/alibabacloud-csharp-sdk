// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sandbox20260820.Models;

namespace AlibabaCloud.SDK.Sandbox20260820
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("sandbox", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateCacheResponse
        /// </returns>
        public CreateTemplateCacheResponse CreateTemplateCacheWithOptions(CreateTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateCacheResponse
        /// </returns>
        public async Task<CreateTemplateCacheResponse> CreateTemplateCacheWithOptionsAsync(CreateTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateCacheResponse
        /// </returns>
        public CreateTemplateCacheResponse CreateTemplateCache(CreateTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTemplateCacheWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateCacheResponse
        /// </returns>
        public async Task<CreateTemplateCacheResponse> CreateTemplateCacheAsync(CreateTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTemplateCacheWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplateWithOptions(string templateID, DeleteTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(string templateID, DeleteTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplate(string templateID, DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTemplateWithOptions(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(string templateID, DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTemplateWithOptionsAsync(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateCacheResponse
        /// </returns>
        public DeleteTemplateCacheResponse DeleteTemplateCacheWithOptions(string templateID, DeleteTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateCacheResponse
        /// </returns>
        public async Task<DeleteTemplateCacheResponse> DeleteTemplateCacheWithOptionsAsync(string templateID, DeleteTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateCacheResponse
        /// </returns>
        public DeleteTemplateCacheResponse DeleteTemplateCache(string templateID, DeleteTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTemplateCacheWithOptions(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateCacheResponse
        /// </returns>
        public async Task<DeleteTemplateCacheResponse> DeleteTemplateCacheAsync(string templateID, DeleteTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTemplateCacheWithOptionsAsync(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTemplateCacheResponse
        /// </returns>
        public DescribeTemplateCacheResponse DescribeTemplateCacheWithOptions(string templateID, DescribeTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTemplateCacheResponse
        /// </returns>
        public async Task<DescribeTemplateCacheResponse> DescribeTemplateCacheWithOptionsAsync(string templateID, DescribeTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTemplateCacheResponse
        /// </returns>
        public DescribeTemplateCacheResponse DescribeTemplateCache(string templateID, DescribeTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTemplateCacheWithOptions(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTemplateCacheResponse
        /// </returns>
        public async Task<DescribeTemplateCacheResponse> DescribeTemplateCacheAsync(string templateID, DescribeTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTemplateCacheWithOptionsAsync(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(string templateID, GetTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(string templateID, GetTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(string templateID, GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateWithOptions(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(string templateID, GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateWithOptionsAsync(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateCacheResponse
        /// </returns>
        public ListTemplateCacheResponse ListTemplateCacheWithOptions(ListTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateID))
            {
                query["templateID"] = request.TemplateID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateCacheRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateCacheResponse
        /// </returns>
        public async Task<ListTemplateCacheResponse> ListTemplateCacheWithOptionsAsync(ListTemplateCacheRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateID))
            {
                query["templateID"] = request.TemplateID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateCache",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/template-caches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateCacheResponse
        /// </returns>
        public ListTemplateCacheResponse ListTemplateCache(ListTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplateCacheWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询模板缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateCacheResponse
        /// </returns>
        public async Task<ListTemplateCacheResponse> ListTemplateCacheAsync(ListTemplateCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplateCacheWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplateWithOptions(string templateID, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(string templateID, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamID))
            {
                query["teamID"] = request.TeamID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2026-08-20",
                Protocol = "HTTPS",
                Pathname = "/pop/2026-08-20/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplate(string templateID, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTemplateWithOptions(templateID, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Template</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(string templateID, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTemplateWithOptionsAsync(templateID, request, headers, runtime);
        }

    }
}
