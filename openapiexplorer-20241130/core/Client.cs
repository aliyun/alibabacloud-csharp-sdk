// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OpenAPIExplorer20241130.Models;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("openapiexplorer", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>根据提供的错误码获取对应的解决方案</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过POST或GET方法调用。</description></item>
        /// <item><description><c>Accept-Language</c>请求头必须设置为<c>zh-CN</c>或<c>en-US</c>之一，用于指定返回结果的语言类型。</description></item>
        /// <item><description>错误码格式需符合特定规则，特别是针对OSS的错误码应遵循正则表达式<c>[0-9]{4}-[0-9]{8}</c>。</description></item>
        /// <item><description>当前实现中未使用<c>maxResults</c>和<c>nextToken</c>参数。</description></item>
        /// <item><description>如果请求失败，将根据不同的错误情况返回相应的错误代码及描述信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public GetErrorCodeSolutionsResponse GetErrorCodeSolutionsWithOptions(GetErrorCodeSolutionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMessage))
            {
                query["errorMessage"] = request.ErrorMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorCodeSolutions",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getErrorCodeSolutions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetErrorCodeSolutionsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetErrorCodeSolutionsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据提供的错误码获取对应的解决方案</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过POST或GET方法调用。</description></item>
        /// <item><description><c>Accept-Language</c>请求头必须设置为<c>zh-CN</c>或<c>en-US</c>之一，用于指定返回结果的语言类型。</description></item>
        /// <item><description>错误码格式需符合特定规则，特别是针对OSS的错误码应遵循正则表达式<c>[0-9]{4}-[0-9]{8}</c>。</description></item>
        /// <item><description>当前实现中未使用<c>maxResults</c>和<c>nextToken</c>参数。</description></item>
        /// <item><description>如果请求失败，将根据不同的错误情况返回相应的错误代码及描述信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public async Task<GetErrorCodeSolutionsResponse> GetErrorCodeSolutionsWithOptionsAsync(GetErrorCodeSolutionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMessage))
            {
                query["errorMessage"] = request.ErrorMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorCodeSolutions",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getErrorCodeSolutions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetErrorCodeSolutionsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetErrorCodeSolutionsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据提供的错误码获取对应的解决方案</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过POST或GET方法调用。</description></item>
        /// <item><description><c>Accept-Language</c>请求头必须设置为<c>zh-CN</c>或<c>en-US</c>之一，用于指定返回结果的语言类型。</description></item>
        /// <item><description>错误码格式需符合特定规则，特别是针对OSS的错误码应遵循正则表达式<c>[0-9]{4}-[0-9]{8}</c>。</description></item>
        /// <item><description>当前实现中未使用<c>maxResults</c>和<c>nextToken</c>参数。</description></item>
        /// <item><description>如果请求失败，将根据不同的错误情况返回相应的错误代码及描述信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public GetErrorCodeSolutionsResponse GetErrorCodeSolutions(GetErrorCodeSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetErrorCodeSolutionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据提供的错误码获取对应的解决方案</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过POST或GET方法调用。</description></item>
        /// <item><description><c>Accept-Language</c>请求头必须设置为<c>zh-CN</c>或<c>en-US</c>之一，用于指定返回结果的语言类型。</description></item>
        /// <item><description>错误码格式需符合特定规则，特别是针对OSS的错误码应遵循正则表达式<c>[0-9]{4}-[0-9]{8}</c>。</description></item>
        /// <item><description>当前实现中未使用<c>maxResults</c>和<c>nextToken</c>参数。</description></item>
        /// <item><description>如果请求失败，将根据不同的错误情况返回相应的错误代码及描述信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public async Task<GetErrorCodeSolutionsResponse> GetErrorCodeSolutionsAsync(GetErrorCodeSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetErrorCodeSolutionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API RequestId 查询当前账号调用OpenAPI的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public GetOwnRequestLogResponse GetOwnRequestLogWithOptions(GetOwnRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOwnRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getOwnRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOwnRequestLogResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOwnRequestLogResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API RequestId 查询当前账号调用OpenAPI的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public async Task<GetOwnRequestLogResponse> GetOwnRequestLogWithOptionsAsync(GetOwnRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOwnRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getOwnRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOwnRequestLogResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOwnRequestLogResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API RequestId 查询当前账号调用OpenAPI的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public GetOwnRequestLogResponse GetOwnRequestLog(GetOwnRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOwnRequestLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API RequestId 查询当前账号调用OpenAPI的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public async Task<GetOwnRequestLogResponse> GetOwnRequestLogAsync(GetOwnRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOwnRequestLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API请求ID查询特定请求的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public GetRequestLogResponse GetRequestLogWithOptions(GetRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRequestLogResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRequestLogResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API请求ID查询特定请求的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public async Task<GetRequestLogResponse> GetRequestLogWithOptionsAsync(GetRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRequestLogResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRequestLogResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API请求ID查询特定请求的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public GetRequestLogResponse GetRequestLog(GetRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRequestLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API请求ID查询特定请求的日志详情，用于故障排查。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口主要用于帮助用户通过提供具体的<c>apiRequestId</c>来获取相关API请求的详细日志信息。</description></item>
        /// <item><description><c>apiRequestId</c>必须是大写形式的UUID，并且应确保该ID确实来自于您之前对某个OpenAPI的实际调用。</description></item>
        /// <item><description>如果提供的<c>apiRequestId</c>无效或者没有找到对应的日志记录，系统将返回相应的错误提示。</description></item>
        /// <item><description>在使用此接口时，请注意检查您的网络环境以及权限设置，以保证能够顺利访问到所需资源。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public async Task<GetRequestLogResponse> GetRequestLogAsync(GetRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRequestLogWithOptionsAsync(request, headers, runtime);
        }

    }
}
