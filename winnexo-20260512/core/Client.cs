// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.WinNexo20260512.Models;

namespace AlibabaCloud.SDK.WinNexo20260512
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("winnexo", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }

        public Dictionary<string, object> _postOSSObject(string bucketName, Dictionary<string, object> data, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"key", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Key, _key)},
                {"cert", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Cert, _cert)},
                {"ca", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Ca, _ca)},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", AlibabaCloud.OpenApiClient.Client.DefaultAny(runtime.IgnoreSSL, false)},
                {"tlsMinVersion", _tlsMinVersion},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, object> form = AlibabaCloud.TeaUtil.Common.AssertAsMap(data);
                    string boundary = AlibabaCloud.SDK.TeaFileform.Client.GetBoundary();
                    string tmp = AlibabaCloud.TeaUtil.Common.AssertAsString(form.Get("host"));
                    string host = "" + bucketName + "." + tmp;
                    request_.Protocol = "HTTPS";
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", host},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", AlibabaCloud.TeaUtil.Common.GetUserAgent("")},
                    };
                    request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
                    request_.Body = AlibabaCloud.SDK.TeaFileform.Client.ToFileForm(form, boundary);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
                        Dictionary<string, object> err = AlibabaCloud.TeaUtil.Common.AssertAsMap(respMap.Get("Error"));
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", err.Get("Code")},
                            {"message", err.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", err.Get("RequestId")},
                                {"hostId", err.Get("HostId")},
                            }},
                        });
                    }
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
                    return TeaConverter.merge<object>
                    (
                        respMap
                    );
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<Dictionary<string, object>> _postOSSObjectAsync(string bucketName, Dictionary<string, object> data, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"timeouted", "retry"},
                {"key", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Key, _key)},
                {"cert", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Cert, _cert)},
                {"ca", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Ca, _ca)},
                {"readTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ReadTimeout, _readTimeout)},
                {"connectTimeout", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.ConnectTimeout, _connectTimeout)},
                {"httpProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpProxy, _httpProxy)},
                {"httpsProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.HttpsProxy, _httpsProxy)},
                {"noProxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.NoProxy, _noProxy)},
                {"socks5Proxy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5Proxy, _socks5Proxy)},
                {"socks5NetWork", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.Socks5NetWork, _socks5NetWork)},
                {"maxIdleConns", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxIdleConns, _maxIdleConns)},
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", AlibabaCloud.OpenApiClient.Client.DefaultAny(runtime.IgnoreSSL, false)},
                {"tlsMinVersion", _tlsMinVersion},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, object> form = AlibabaCloud.TeaUtil.Common.AssertAsMap(data);
                    string boundary = AlibabaCloud.SDK.TeaFileform.Client.GetBoundary();
                    string tmp = AlibabaCloud.TeaUtil.Common.AssertAsString(form.Get("host"));
                    string host = "" + bucketName + "." + tmp;
                    request_.Protocol = "HTTPS";
                    request_.Method = "POST";
                    request_.Pathname = "/";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", host},
                        {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                        {"user-agent", AlibabaCloud.TeaUtil.Common.GetUserAgent("")},
                    };
                    request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
                    request_.Body = AlibabaCloud.SDK.TeaFileform.Client.ToFileForm(form, boundary);
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    string bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
                    if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
                    {
                        respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
                        Dictionary<string, object> err = AlibabaCloud.TeaUtil.Common.AssertAsMap(respMap.Get("Error"));
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"code", err.Get("Code")},
                            {"message", err.Get("Message")},
                            {"data", new Dictionary<string, object>
                            {
                                {"httpCode", response_.StatusCode},
                                {"requestId", err.Get("RequestId")},
                                {"hostId", err.Get("HostId")},
                            }},
                        });
                    }
                    respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
                    return TeaConverter.merge<object>
                    (
                        respMap
                    );
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
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
        /// <para>服务健康检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckHealthRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckHealthResponse
        /// </returns>
        public CheckHealthResponse CheckHealthWithOptions(CheckHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckHealth",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/checkHealth",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckHealthResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务健康检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckHealthRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckHealthResponse
        /// </returns>
        public async Task<CheckHealthResponse> CheckHealthWithOptionsAsync(CheckHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckHealth",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/checkHealth",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckHealthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务健康检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckHealthRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckHealthResponse
        /// </returns>
        public CheckHealthResponse CheckHealth(CheckHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckHealthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务健康检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckHealthRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckHealthResponse
        /// </returns>
        public async Task<CheckHealthResponse> CheckHealthAsync(CheckHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckHealthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConversationResponse
        /// </returns>
        public CreateConversationResponse CreateConversationWithOptions(CreateConversationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConversationShrinkRequest request = new CreateConversationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperatingObjectName))
            {
                request.OperatingObjectNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperatingObjectName, "operatingObjectName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["objectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectNameShrink))
            {
                body["operatingObjectName"] = request.OperatingObjectNameShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConversation",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createConversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConversationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConversationResponse
        /// </returns>
        public async Task<CreateConversationResponse> CreateConversationWithOptionsAsync(CreateConversationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConversationShrinkRequest request = new CreateConversationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperatingObjectName))
            {
                request.OperatingObjectNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperatingObjectName, "operatingObjectName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["objectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectNameShrink))
            {
                body["operatingObjectName"] = request.OperatingObjectNameShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConversation",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createConversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConversationResponse
        /// </returns>
        public CreateConversationResponse CreateConversation(CreateConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConversationResponse
        /// </returns>
        public async Task<CreateConversationResponse> CreateConversationAsync(CreateConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册纯自定义组织</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>注册一个纯自定义组织，用于后续通过 syncOrgStructure 推送部门树。
        ///     注册逻辑：
        ///     1. 校验 corpId 格式（小写字母/数字开头，3-64 位，允许中划线）
        ///     2. 委托 OrgSyncAuthorizedService 执行注册（内含权限校验 + 租户内唯一性检查）
        ///     3. 返回注册结果
        ///     注意：纯自定义组织仅支持部门树同步，不支持成员关系同步。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomOrgRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomOrgResponse
        /// </returns>
        public CreateCustomOrgResponse CreateCustomOrgWithOptions(CreateCustomOrgRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corpName"] = request.CorpName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomOrg",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createCustomOrg",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomOrgResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册纯自定义组织</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>注册一个纯自定义组织，用于后续通过 syncOrgStructure 推送部门树。
        ///     注册逻辑：
        ///     1. 校验 corpId 格式（小写字母/数字开头，3-64 位，允许中划线）
        ///     2. 委托 OrgSyncAuthorizedService 执行注册（内含权限校验 + 租户内唯一性检查）
        ///     3. 返回注册结果
        ///     注意：纯自定义组织仅支持部门树同步，不支持成员关系同步。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomOrgRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomOrgResponse
        /// </returns>
        public async Task<CreateCustomOrgResponse> CreateCustomOrgWithOptionsAsync(CreateCustomOrgRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corpName"] = request.CorpName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomOrg",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createCustomOrg",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomOrgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册纯自定义组织</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>注册一个纯自定义组织，用于后续通过 syncOrgStructure 推送部门树。
        ///     注册逻辑：
        ///     1. 校验 corpId 格式（小写字母/数字开头，3-64 位，允许中划线）
        ///     2. 委托 OrgSyncAuthorizedService 执行注册（内含权限校验 + 租户内唯一性检查）
        ///     3. 返回注册结果
        ///     注意：纯自定义组织仅支持部门树同步，不支持成员关系同步。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomOrgResponse
        /// </returns>
        public CreateCustomOrgResponse CreateCustomOrg(CreateCustomOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCustomOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册纯自定义组织</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>注册一个纯自定义组织，用于后续通过 syncOrgStructure 推送部门树。
        ///     注册逻辑：
        ///     1. 校验 corpId 格式（小写字母/数字开头，3-64 位，允许中划线）
        ///     2. 委托 OrgSyncAuthorizedService 执行注册（内含权限校验 + 租户内唯一性检查）
        ///     3. 返回注册结果
        ///     注意：纯自定义组织仅支持部门树同步，不支持成员关系同步。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomOrgResponse
        /// </returns>
        public async Task<CreateCustomOrgResponse> CreateCustomOrgAsync(CreateCustomOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCustomOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传到企业知识库，需管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将阿里钉在线文档添加到指定的企业知识库中。</description></item>
        /// <item><description>调用者必须具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description><c>source_type</c>固定为<c>ONLINE_DOC</c>，<c>platform</c>固定为<c>ALI_DING</c>，<c>scope</c>固定为<c>TENANT</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是当前租户下的有效目录ID。</description></item>
        /// <item><description><c>filePublicUrl</c>参数是必需的，表示要上传的阿里钉在线文档的公开访问URL。</description></item>
        /// <item><description>可选参数包括<c>operatingObjectName</c>（数字员工名称）、<c>description</c>（资源描述）、<c>knowledgeId</c>（知识库ID）和<c>sourceTags</c>（资源标签）等。</description></item>
        /// <item><description>成功响应会返回新创建资源的相关信息，如<c>sourceId</c>、<c>name</c>、<c>status</c>、<c>directoryId</c>及创建时间等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseAliDingDocRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseAliDingDocResponse
        /// </returns>
        public CreateKnowledgeBaseAliDingDocResponse CreateKnowledgeBaseAliDingDocWithOptions(CreateKnowledgeBaseAliDingDocRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseAliDingDoc",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseAlidingDoc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseAliDingDocResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传到企业知识库，需管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将阿里钉在线文档添加到指定的企业知识库中。</description></item>
        /// <item><description>调用者必须具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description><c>source_type</c>固定为<c>ONLINE_DOC</c>，<c>platform</c>固定为<c>ALI_DING</c>，<c>scope</c>固定为<c>TENANT</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是当前租户下的有效目录ID。</description></item>
        /// <item><description><c>filePublicUrl</c>参数是必需的，表示要上传的阿里钉在线文档的公开访问URL。</description></item>
        /// <item><description>可选参数包括<c>operatingObjectName</c>（数字员工名称）、<c>description</c>（资源描述）、<c>knowledgeId</c>（知识库ID）和<c>sourceTags</c>（资源标签）等。</description></item>
        /// <item><description>成功响应会返回新创建资源的相关信息，如<c>sourceId</c>、<c>name</c>、<c>status</c>、<c>directoryId</c>及创建时间等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseAliDingDocRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseAliDingDocResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseAliDingDocResponse> CreateKnowledgeBaseAliDingDocWithOptionsAsync(CreateKnowledgeBaseAliDingDocRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseAliDingDoc",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseAlidingDoc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseAliDingDocResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传到企业知识库，需管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将阿里钉在线文档添加到指定的企业知识库中。</description></item>
        /// <item><description>调用者必须具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description><c>source_type</c>固定为<c>ONLINE_DOC</c>，<c>platform</c>固定为<c>ALI_DING</c>，<c>scope</c>固定为<c>TENANT</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是当前租户下的有效目录ID。</description></item>
        /// <item><description><c>filePublicUrl</c>参数是必需的，表示要上传的阿里钉在线文档的公开访问URL。</description></item>
        /// <item><description>可选参数包括<c>operatingObjectName</c>（数字员工名称）、<c>description</c>（资源描述）、<c>knowledgeId</c>（知识库ID）和<c>sourceTags</c>（资源标签）等。</description></item>
        /// <item><description>成功响应会返回新创建资源的相关信息，如<c>sourceId</c>、<c>name</c>、<c>status</c>、<c>directoryId</c>及创建时间等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseAliDingDocRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseAliDingDocResponse
        /// </returns>
        public CreateKnowledgeBaseAliDingDocResponse CreateKnowledgeBaseAliDingDoc(CreateKnowledgeBaseAliDingDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKnowledgeBaseAliDingDocWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传到企业知识库，需管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将阿里钉在线文档添加到指定的企业知识库中。</description></item>
        /// <item><description>调用者必须具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description><c>source_type</c>固定为<c>ONLINE_DOC</c>，<c>platform</c>固定为<c>ALI_DING</c>，<c>scope</c>固定为<c>TENANT</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是当前租户下的有效目录ID。</description></item>
        /// <item><description><c>filePublicUrl</c>参数是必需的，表示要上传的阿里钉在线文档的公开访问URL。</description></item>
        /// <item><description>可选参数包括<c>operatingObjectName</c>（数字员工名称）、<c>description</c>（资源描述）、<c>knowledgeId</c>（知识库ID）和<c>sourceTags</c>（资源标签）等。</description></item>
        /// <item><description>成功响应会返回新创建资源的相关信息，如<c>sourceId</c>、<c>name</c>、<c>status</c>、<c>directoryId</c>及创建时间等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseAliDingDocRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseAliDingDocResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseAliDingDocResponse> CreateKnowledgeBaseAliDingDocAsync(CreateKnowledgeBaseAliDingDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKnowledgeBaseAliDingDocWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于在企业知识库中创建新的分类目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有<c>DEVELOPMENT_KB_MANAGE</c>权限的用户为企业知识库创建新的分类。</description></item>
        /// <item><description>创建时可指定父分类ID，若未指定，则新分类将直接挂载于企业知识库根目录下。</description></item>
        /// <item><description>系统会自动检查同名冲突及目录深度限制等问题。</description></item>
        /// <item><description><c>tenant_id</c>和<c>user_id</c>仅通过鉴权身份获取，请求体中即使提供也会被忽略。</description></item>
        /// <item><description>需要确保提供的<c>parentDirectoryId</c>（如果有的话）属于当前租户。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseDirectoryResponse
        /// </returns>
        public CreateKnowledgeBaseDirectoryResponse CreateKnowledgeBaseDirectoryWithOptions(CreateKnowledgeBaseDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                body["parentDirectoryId"] = request.ParentDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于在企业知识库中创建新的分类目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有<c>DEVELOPMENT_KB_MANAGE</c>权限的用户为企业知识库创建新的分类。</description></item>
        /// <item><description>创建时可指定父分类ID，若未指定，则新分类将直接挂载于企业知识库根目录下。</description></item>
        /// <item><description>系统会自动检查同名冲突及目录深度限制等问题。</description></item>
        /// <item><description><c>tenant_id</c>和<c>user_id</c>仅通过鉴权身份获取，请求体中即使提供也会被忽略。</description></item>
        /// <item><description>需要确保提供的<c>parentDirectoryId</c>（如果有的话）属于当前租户。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseDirectoryResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseDirectoryResponse> CreateKnowledgeBaseDirectoryWithOptionsAsync(CreateKnowledgeBaseDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                body["parentDirectoryId"] = request.ParentDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于在企业知识库中创建新的分类目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有<c>DEVELOPMENT_KB_MANAGE</c>权限的用户为企业知识库创建新的分类。</description></item>
        /// <item><description>创建时可指定父分类ID，若未指定，则新分类将直接挂载于企业知识库根目录下。</description></item>
        /// <item><description>系统会自动检查同名冲突及目录深度限制等问题。</description></item>
        /// <item><description><c>tenant_id</c>和<c>user_id</c>仅通过鉴权身份获取，请求体中即使提供也会被忽略。</description></item>
        /// <item><description>需要确保提供的<c>parentDirectoryId</c>（如果有的话）属于当前租户。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseDirectoryResponse
        /// </returns>
        public CreateKnowledgeBaseDirectoryResponse CreateKnowledgeBaseDirectory(CreateKnowledgeBaseDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKnowledgeBaseDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于在企业知识库中创建新的分类目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有<c>DEVELOPMENT_KB_MANAGE</c>权限的用户为企业知识库创建新的分类。</description></item>
        /// <item><description>创建时可指定父分类ID，若未指定，则新分类将直接挂载于企业知识库根目录下。</description></item>
        /// <item><description>系统会自动检查同名冲突及目录深度限制等问题。</description></item>
        /// <item><description><c>tenant_id</c>和<c>user_id</c>仅通过鉴权身份获取，请求体中即使提供也会被忽略。</description></item>
        /// <item><description>需要确保提供的<c>parentDirectoryId</c>（如果有的话）属于当前租户。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseDirectoryResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseDirectoryResponse> CreateKnowledgeBaseDirectoryAsync(CreateKnowledgeBaseDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKnowledgeBaseDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定文件上传至企业知识库，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于向企业知识库中上传文件。</description></item>
        /// <item><description>需要拥有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description>文件上传时必须提供文件的OSS持久化地址(<c>filePath</c>)。</description></item>
        /// <item><description>可选参数包括文件公开访问URL、原始文件名等，以增强文件信息的完整性。</description></item>
        /// <item><description>如果指定了<c>directoryId</c>，则文件会被放置在对应的企业知识库目录下；否则，默认绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>为资源添加标签，便于后续管理和检索。</description></item>
        /// <item><description>本操作会启动计费账单（UNSTRUCTURED_PARSE），请确保账户余额充足。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseFileResponse
        /// </returns>
        public CreateKnowledgeBaseFileResponse CreateKnowledgeBaseFileWithOptions(CreateKnowledgeBaseFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExt))
            {
                body["fileExt"] = request.FileExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定文件上传至企业知识库，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于向企业知识库中上传文件。</description></item>
        /// <item><description>需要拥有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description>文件上传时必须提供文件的OSS持久化地址(<c>filePath</c>)。</description></item>
        /// <item><description>可选参数包括文件公开访问URL、原始文件名等，以增强文件信息的完整性。</description></item>
        /// <item><description>如果指定了<c>directoryId</c>，则文件会被放置在对应的企业知识库目录下；否则，默认绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>为资源添加标签，便于后续管理和检索。</description></item>
        /// <item><description>本操作会启动计费账单（UNSTRUCTURED_PARSE），请确保账户余额充足。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseFileResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseFileResponse> CreateKnowledgeBaseFileWithOptionsAsync(CreateKnowledgeBaseFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExt))
            {
                body["fileExt"] = request.FileExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定文件上传至企业知识库，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于向企业知识库中上传文件。</description></item>
        /// <item><description>需要拥有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description>文件上传时必须提供文件的OSS持久化地址(<c>filePath</c>)。</description></item>
        /// <item><description>可选参数包括文件公开访问URL、原始文件名等，以增强文件信息的完整性。</description></item>
        /// <item><description>如果指定了<c>directoryId</c>，则文件会被放置在对应的企业知识库目录下；否则，默认绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>为资源添加标签，便于后续管理和检索。</description></item>
        /// <item><description>本操作会启动计费账单（UNSTRUCTURED_PARSE），请确保账户余额充足。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseFileResponse
        /// </returns>
        public CreateKnowledgeBaseFileResponse CreateKnowledgeBaseFile(CreateKnowledgeBaseFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKnowledgeBaseFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定文件上传至企业知识库，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于向企业知识库中上传文件。</description></item>
        /// <item><description>需要拥有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description>文件上传时必须提供文件的OSS持久化地址(<c>filePath</c>)。</description></item>
        /// <item><description>可选参数包括文件公开访问URL、原始文件名等，以增强文件信息的完整性。</description></item>
        /// <item><description>如果指定了<c>directoryId</c>，则文件会被放置在对应的企业知识库目录下；否则，默认绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>为资源添加标签，便于后续管理和检索。</description></item>
        /// <item><description>本操作会启动计费账单（UNSTRUCTURED_PARSE），请确保账户余额充足。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseFileResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseFileResponse> CreateKnowledgeBaseFileAsync(CreateKnowledgeBaseFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKnowledgeBaseFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容添加至指定的企业知识库中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向企业知识库上传纯文本信息，要求调用者具备相应的管理权限。</description></item>
        /// <item><description><c>textContent</c>字段为必填项，代表要上传的纯文本内容。</description></item>
        /// <item><description>可选参数包括数字员工名称(<c>operatingObjectName</c>)、资源描述(<c>description</c>)等，允许用户自定义更多细节。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会将上传的文本绑定到指定的知识库目录下；若未提供，则默认绑定到当前数字员工的根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>给资源打标签，方便后续管理和检索。</description></item>
        /// <item><description>调用此接口前，请确保已正确配置身份验证方式（支持AK、BearerToken及APP认证）并拥有<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseTextResponse
        /// </returns>
        public CreateKnowledgeBaseTextResponse CreateKnowledgeBaseTextWithOptions(CreateKnowledgeBaseTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseText",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容添加至指定的企业知识库中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向企业知识库上传纯文本信息，要求调用者具备相应的管理权限。</description></item>
        /// <item><description><c>textContent</c>字段为必填项，代表要上传的纯文本内容。</description></item>
        /// <item><description>可选参数包括数字员工名称(<c>operatingObjectName</c>)、资源描述(<c>description</c>)等，允许用户自定义更多细节。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会将上传的文本绑定到指定的知识库目录下；若未提供，则默认绑定到当前数字员工的根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>给资源打标签，方便后续管理和检索。</description></item>
        /// <item><description>调用此接口前，请确保已正确配置身份验证方式（支持AK、BearerToken及APP认证）并拥有<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseTextResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseTextResponse> CreateKnowledgeBaseTextWithOptionsAsync(CreateKnowledgeBaseTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseText",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createKnowledgeBaseText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容添加至指定的企业知识库中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向企业知识库上传纯文本信息，要求调用者具备相应的管理权限。</description></item>
        /// <item><description><c>textContent</c>字段为必填项，代表要上传的纯文本内容。</description></item>
        /// <item><description>可选参数包括数字员工名称(<c>operatingObjectName</c>)、资源描述(<c>description</c>)等，允许用户自定义更多细节。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会将上传的文本绑定到指定的知识库目录下；若未提供，则默认绑定到当前数字员工的根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>给资源打标签，方便后续管理和检索。</description></item>
        /// <item><description>调用此接口前，请确保已正确配置身份验证方式（支持AK、BearerToken及APP认证）并拥有<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseTextRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseTextResponse
        /// </returns>
        public CreateKnowledgeBaseTextResponse CreateKnowledgeBaseText(CreateKnowledgeBaseTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKnowledgeBaseTextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容添加至指定的企业知识库中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向企业知识库上传纯文本信息，要求调用者具备相应的管理权限。</description></item>
        /// <item><description><c>textContent</c>字段为必填项，代表要上传的纯文本内容。</description></item>
        /// <item><description>可选参数包括数字员工名称(<c>operatingObjectName</c>)、资源描述(<c>description</c>)等，允许用户自定义更多细节。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会将上传的文本绑定到指定的知识库目录下；若未提供，则默认绑定到当前数字员工的根目录。</description></item>
        /// <item><description>支持通过<c>sourceTags</c>给资源打标签，方便后续管理和检索。</description></item>
        /// <item><description>调用此接口前，请确保已正确配置身份验证方式（支持AK、BearerToken及APP认证）并拥有<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseTextRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseTextResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseTextResponse> CreateKnowledgeBaseTextAsync(CreateKnowledgeBaseTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKnowledgeBaseTextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉会议相关资料（如音视频、闪记链接等）上传至指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>ALI_DING_MEETING</c>，且作用范围 <c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>必须提供公开的音视频OSS地址 (<c>ossUrl</c>) 和原始的闪记链接 (<c>shanjiUrl</c>)。</description></item>
        /// <item><description>可选地，可以指定目标个人目录ID (<c>directoryId</c>)；若未指定，则自动绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持添加资源描述 (<c>description</c>) 和会议笔记内容 (<c>notes</c>)，其中会议笔记可用于辅助分析。</description></item>
        /// <item><description>此操作需要相应的权限认证，支持AK、BearerToken和APP三种认证方式之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAliDingMeetingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAliDingMeetingResponse
        /// </returns>
        public CreatePersonalAliDingMeetingResponse CreatePersonalAliDingMeetingWithOptions(CreatePersonalAliDingMeetingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShanjiUrl))
            {
                body["shanjiUrl"] = request.ShanjiUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalAliDingMeeting",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalAliDingMeeting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalAliDingMeetingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉会议相关资料（如音视频、闪记链接等）上传至指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>ALI_DING_MEETING</c>，且作用范围 <c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>必须提供公开的音视频OSS地址 (<c>ossUrl</c>) 和原始的闪记链接 (<c>shanjiUrl</c>)。</description></item>
        /// <item><description>可选地，可以指定目标个人目录ID (<c>directoryId</c>)；若未指定，则自动绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持添加资源描述 (<c>description</c>) 和会议笔记内容 (<c>notes</c>)，其中会议笔记可用于辅助分析。</description></item>
        /// <item><description>此操作需要相应的权限认证，支持AK、BearerToken和APP三种认证方式之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAliDingMeetingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAliDingMeetingResponse
        /// </returns>
        public async Task<CreatePersonalAliDingMeetingResponse> CreatePersonalAliDingMeetingWithOptionsAsync(CreatePersonalAliDingMeetingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShanjiUrl))
            {
                body["shanjiUrl"] = request.ShanjiUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalAliDingMeeting",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalAliDingMeeting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalAliDingMeetingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉会议相关资料（如音视频、闪记链接等）上传至指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>ALI_DING_MEETING</c>，且作用范围 <c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>必须提供公开的音视频OSS地址 (<c>ossUrl</c>) 和原始的闪记链接 (<c>shanjiUrl</c>)。</description></item>
        /// <item><description>可选地，可以指定目标个人目录ID (<c>directoryId</c>)；若未指定，则自动绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持添加资源描述 (<c>description</c>) 和会议笔记内容 (<c>notes</c>)，其中会议笔记可用于辅助分析。</description></item>
        /// <item><description>此操作需要相应的权限认证，支持AK、BearerToken和APP三种认证方式之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAliDingMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAliDingMeetingResponse
        /// </returns>
        public CreatePersonalAliDingMeetingResponse CreatePersonalAliDingMeeting(CreatePersonalAliDingMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalAliDingMeetingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉会议相关资料（如音视频、闪记链接等）上传至指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>ALI_DING_MEETING</c>，且作用范围 <c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>必须提供公开的音视频OSS地址 (<c>ossUrl</c>) 和原始的闪记链接 (<c>shanjiUrl</c>)。</description></item>
        /// <item><description>可选地，可以指定目标个人目录ID (<c>directoryId</c>)；若未指定，则自动绑定到当前数字员工默认根目录。</description></item>
        /// <item><description>支持添加资源描述 (<c>description</c>) 和会议笔记内容 (<c>notes</c>)，其中会议笔记可用于辅助分析。</description></item>
        /// <item><description>此操作需要相应的权限认证，支持AK、BearerToken和APP三种认证方式之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAliDingMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAliDingMeetingResponse
        /// </returns>
        public async Task<CreatePersonalAliDingMeetingResponse> CreatePersonalAliDingMeetingAsync(CreatePersonalAliDingMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalAliDingMeetingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉在线文档添加到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description>固定参数包括 <c>source_type=ONLINE_DOC</c>、<c>platform=ALI_DING</c> 和 <c>scope=PERSONAL</c>。</description></item>
        /// <item><description>如果未提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供了，则需确保该目录属于当前用户且在当前数字员工下存在。</description></item>
        /// <item><description>调用过程中会启动计量并记录相关操作日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，调用方提供的这些字段值将被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会通过服务抛出异常，并转换为POP错误码返回给调用者。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAlidingDocRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingDocResponse
        /// </returns>
        public CreatePersonalAlidingDocResponse CreatePersonalAlidingDocWithOptions(CreatePersonalAlidingDocRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalAlidingDoc",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalAliDingDoc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalAlidingDocResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉在线文档添加到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description>固定参数包括 <c>source_type=ONLINE_DOC</c>、<c>platform=ALI_DING</c> 和 <c>scope=PERSONAL</c>。</description></item>
        /// <item><description>如果未提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供了，则需确保该目录属于当前用户且在当前数字员工下存在。</description></item>
        /// <item><description>调用过程中会启动计量并记录相关操作日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，调用方提供的这些字段值将被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会通过服务抛出异常，并转换为POP错误码返回给调用者。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAlidingDocRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingDocResponse
        /// </returns>
        public async Task<CreatePersonalAlidingDocResponse> CreatePersonalAlidingDocWithOptionsAsync(CreatePersonalAlidingDocRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalAlidingDoc",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalAliDingDoc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalAlidingDocResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉在线文档添加到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description>固定参数包括 <c>source_type=ONLINE_DOC</c>、<c>platform=ALI_DING</c> 和 <c>scope=PERSONAL</c>。</description></item>
        /// <item><description>如果未提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供了，则需确保该目录属于当前用户且在当前数字员工下存在。</description></item>
        /// <item><description>调用过程中会启动计量并记录相关操作日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，调用方提供的这些字段值将被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会通过服务抛出异常，并转换为POP错误码返回给调用者。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAlidingDocRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingDocResponse
        /// </returns>
        public CreatePersonalAlidingDocResponse CreatePersonalAlidingDoc(CreatePersonalAlidingDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalAlidingDocWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉在线文档上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将阿里钉在线文档添加到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description>固定参数包括 <c>source_type=ONLINE_DOC</c>、<c>platform=ALI_DING</c> 和 <c>scope=PERSONAL</c>。</description></item>
        /// <item><description>如果未提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供了，则需确保该目录属于当前用户且在当前数字员工下存在。</description></item>
        /// <item><description>调用过程中会启动计量并记录相关操作日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，调用方提供的这些字段值将被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会通过服务抛出异常，并转换为POP错误码返回给调用者。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAlidingDocRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingDocResponse
        /// </returns>
        public async Task<CreatePersonalAlidingDocResponse> CreatePersonalAlidingDocAsync(CreatePersonalAlidingDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalAlidingDocWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉整体知识库添加到当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于创建一个阿里钉知识库，并将其挂载到指定数字员工的个人资源目录下。</description></item>
        /// <item><description><c>platform</c>固定为<c>ALI_DING</c>，<c>directory_type</c>固定为<c>PERSONAL</c>。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会验证该目录是否存在且属于当前租户和个人类型。</description></item>
        /// <item><description>创建过程中会初始化知识库根目录（状态设置为<c>RUNNING</c>），并根据提供的同步配置派发后台任务以拉取远程目录树和创建子节点。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，请求体中的这些字段会被忽略。</description></item>
        /// <item><description>同步配置可选，若启用需提供cron表达式；未传或禁用时，默认不进行定时同步。</description></item>
        /// <item><description>知识库名称可以自定义，如果不提供，则会在后台同步后自动填充。</description></item>
        /// <item><description>支持多值对象绑定，相关信息将被序列化并存储于知识库元数据中。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePersonalAlidingKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingKnowledgeBaseResponse
        /// </returns>
        public CreatePersonalAlidingKnowledgeBaseResponse CreatePersonalAlidingKnowledgeBaseWithOptions(CreatePersonalAlidingKnowledgeBaseRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePersonalAlidingKnowledgeBaseShrinkRequest request = new CreatePersonalAlidingKnowledgeBaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectBindings))
            {
                request.ObjectBindingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectBindings, "objectBindings", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SyncConfig))
            {
                request.SyncConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SyncConfig, "syncConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbName))
            {
                body["kbName"] = request.KbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUrl))
            {
                body["kbUrl"] = request.KbUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectBindingsShrink))
            {
                body["objectBindings"] = request.ObjectBindingsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncConfigShrink))
            {
                body["syncConfig"] = request.SyncConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalAlidingKnowledgeBase",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalAliDingKnowledgeBase",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalAlidingKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉整体知识库添加到当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于创建一个阿里钉知识库，并将其挂载到指定数字员工的个人资源目录下。</description></item>
        /// <item><description><c>platform</c>固定为<c>ALI_DING</c>，<c>directory_type</c>固定为<c>PERSONAL</c>。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会验证该目录是否存在且属于当前租户和个人类型。</description></item>
        /// <item><description>创建过程中会初始化知识库根目录（状态设置为<c>RUNNING</c>），并根据提供的同步配置派发后台任务以拉取远程目录树和创建子节点。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，请求体中的这些字段会被忽略。</description></item>
        /// <item><description>同步配置可选，若启用需提供cron表达式；未传或禁用时，默认不进行定时同步。</description></item>
        /// <item><description>知识库名称可以自定义，如果不提供，则会在后台同步后自动填充。</description></item>
        /// <item><description>支持多值对象绑定，相关信息将被序列化并存储于知识库元数据中。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePersonalAlidingKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingKnowledgeBaseResponse
        /// </returns>
        public async Task<CreatePersonalAlidingKnowledgeBaseResponse> CreatePersonalAlidingKnowledgeBaseWithOptionsAsync(CreatePersonalAlidingKnowledgeBaseRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePersonalAlidingKnowledgeBaseShrinkRequest request = new CreatePersonalAlidingKnowledgeBaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectBindings))
            {
                request.ObjectBindingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectBindings, "objectBindings", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SyncConfig))
            {
                request.SyncConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SyncConfig, "syncConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbName))
            {
                body["kbName"] = request.KbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUrl))
            {
                body["kbUrl"] = request.KbUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectBindingsShrink))
            {
                body["objectBindings"] = request.ObjectBindingsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncConfigShrink))
            {
                body["syncConfig"] = request.SyncConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalAlidingKnowledgeBase",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalAliDingKnowledgeBase",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalAlidingKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉整体知识库添加到当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于创建一个阿里钉知识库，并将其挂载到指定数字员工的个人资源目录下。</description></item>
        /// <item><description><c>platform</c>固定为<c>ALI_DING</c>，<c>directory_type</c>固定为<c>PERSONAL</c>。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会验证该目录是否存在且属于当前租户和个人类型。</description></item>
        /// <item><description>创建过程中会初始化知识库根目录（状态设置为<c>RUNNING</c>），并根据提供的同步配置派发后台任务以拉取远程目录树和创建子节点。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，请求体中的这些字段会被忽略。</description></item>
        /// <item><description>同步配置可选，若启用需提供cron表达式；未传或禁用时，默认不进行定时同步。</description></item>
        /// <item><description>知识库名称可以自定义，如果不提供，则会在后台同步后自动填充。</description></item>
        /// <item><description>支持多值对象绑定，相关信息将被序列化并存储于知识库元数据中。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAlidingKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingKnowledgeBaseResponse
        /// </returns>
        public CreatePersonalAlidingKnowledgeBaseResponse CreatePersonalAlidingKnowledgeBase(CreatePersonalAlidingKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalAlidingKnowledgeBaseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将阿里钉整体知识库添加到当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于创建一个阿里钉知识库，并将其挂载到指定数字员工的个人资源目录下。</description></item>
        /// <item><description><c>platform</c>固定为<c>ALI_DING</c>，<c>directory_type</c>固定为<c>PERSONAL</c>。</description></item>
        /// <item><description>如果提供了<c>directoryId</c>，则会验证该目录是否存在且属于当前租户和个人类型。</description></item>
        /// <item><description>创建过程中会初始化知识库根目录（状态设置为<c>RUNNING</c>），并根据提供的同步配置派发后台任务以拉取远程目录树和创建子节点。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，请求体中的这些字段会被忽略。</description></item>
        /// <item><description>同步配置可选，若启用需提供cron表达式；未传或禁用时，默认不进行定时同步。</description></item>
        /// <item><description>知识库名称可以自定义，如果不提供，则会在后台同步后自动填充。</description></item>
        /// <item><description>支持多值对象绑定，相关信息将被序列化并存储于知识库元数据中。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalAlidingKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalAlidingKnowledgeBaseResponse
        /// </returns>
        public async Task<CreatePersonalAlidingKnowledgeBaseResponse> CreatePersonalAlidingKnowledgeBaseAsync(CreatePersonalAlidingKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalAlidingKnowledgeBaseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将钉钉会议上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将钉钉会议作为资源上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>DINGTALK_MEETING</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供 <c>credentialId</c>，则使用系统默认配置。</description></item>
        /// <item><description>当未指定 <c>directoryId</c> 时，资源将自动绑定到当前数字员工的默认根目录下；若指定，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description>可选参数 <c>description</c> 和 <c>notes</c> 分别用于描述资源和记录会议笔记，其中 <c>notes</c> 会参与辅助分析。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDingtalkMeetingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDingtalkMeetingResponse
        /// </returns>
        public CreatePersonalDingtalkMeetingResponse CreatePersonalDingtalkMeetingWithOptions(CreatePersonalDingtalkMeetingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                body["credentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCode))
            {
                body["roomCode"] = request.RoomCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalDingtalkMeeting",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalDingtalkMeeting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalDingtalkMeetingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将钉钉会议上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将钉钉会议作为资源上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>DINGTALK_MEETING</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供 <c>credentialId</c>，则使用系统默认配置。</description></item>
        /// <item><description>当未指定 <c>directoryId</c> 时，资源将自动绑定到当前数字员工的默认根目录下；若指定，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description>可选参数 <c>description</c> 和 <c>notes</c> 分别用于描述资源和记录会议笔记，其中 <c>notes</c> 会参与辅助分析。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDingtalkMeetingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDingtalkMeetingResponse
        /// </returns>
        public async Task<CreatePersonalDingtalkMeetingResponse> CreatePersonalDingtalkMeetingWithOptionsAsync(CreatePersonalDingtalkMeetingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                body["credentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                body["notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCode))
            {
                body["roomCode"] = request.RoomCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalDingtalkMeeting",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalDingtalkMeeting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalDingtalkMeetingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将钉钉会议上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将钉钉会议作为资源上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>DINGTALK_MEETING</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供 <c>credentialId</c>，则使用系统默认配置。</description></item>
        /// <item><description>当未指定 <c>directoryId</c> 时，资源将自动绑定到当前数字员工的默认根目录下；若指定，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description>可选参数 <c>description</c> 和 <c>notes</c> 分别用于描述资源和记录会议笔记，其中 <c>notes</c> 会参与辅助分析。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDingtalkMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDingtalkMeetingResponse
        /// </returns>
        public CreatePersonalDingtalkMeetingResponse CreatePersonalDingtalkMeeting(CreatePersonalDingtalkMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalDingtalkMeetingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将钉钉会议上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于将钉钉会议作为资源上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>DINGTALK_MEETING</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供 <c>credentialId</c>，则使用系统默认配置。</description></item>
        /// <item><description>当未指定 <c>directoryId</c> 时，资源将自动绑定到当前数字员工的默认根目录下；若指定，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description>可选参数 <c>description</c> 和 <c>notes</c> 分别用于描述资源和记录会议笔记，其中 <c>notes</c> 会参与辅助分析。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDingtalkMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDingtalkMeetingResponse
        /// </returns>
        public async Task<CreatePersonalDingtalkMeetingResponse> CreatePersonalDingtalkMeetingAsync(CreatePersonalDingtalkMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalDingtalkMeetingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在我的资源下创建个人目录（分类）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在“我的资源”下创建个人目录（分类）。</description></item>
        /// <item><description>若未传 <c>parentDirectoryId</c>，系统将自动使用或创建当前数字员工的默认根目录作为父目录。</description></item>
        /// <item><description>若传入 <c>parentDirectoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，调用方在请求体中传入这些字段会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDirectoryResponse
        /// </returns>
        public CreatePersonalDirectoryResponse CreatePersonalDirectoryWithOptions(CreatePersonalDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                body["parentDirectoryId"] = request.ParentDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在我的资源下创建个人目录（分类）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在“我的资源”下创建个人目录（分类）。</description></item>
        /// <item><description>若未传 <c>parentDirectoryId</c>，系统将自动使用或创建当前数字员工的默认根目录作为父目录。</description></item>
        /// <item><description>若传入 <c>parentDirectoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，调用方在请求体中传入这些字段会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDirectoryResponse
        /// </returns>
        public async Task<CreatePersonalDirectoryResponse> CreatePersonalDirectoryWithOptionsAsync(CreatePersonalDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                body["parentDirectoryId"] = request.ParentDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在我的资源下创建个人目录（分类）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在“我的资源”下创建个人目录（分类）。</description></item>
        /// <item><description>若未传 <c>parentDirectoryId</c>，系统将自动使用或创建当前数字员工的默认根目录作为父目录。</description></item>
        /// <item><description>若传入 <c>parentDirectoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，调用方在请求体中传入这些字段会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDirectoryResponse
        /// </returns>
        public CreatePersonalDirectoryResponse CreatePersonalDirectory(CreatePersonalDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在我的资源下创建个人目录（分类）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在“我的资源”下创建个人目录（分类）。</description></item>
        /// <item><description>若未传 <c>parentDirectoryId</c>，系统将自动使用或创建当前数字员工的默认根目录作为父目录。</description></item>
        /// <item><description>若传入 <c>parentDirectoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，调用方在请求体中传入这些字段会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalDirectoryResponse
        /// </returns>
        public async Task<CreatePersonalDirectoryResponse> CreatePersonalDirectoryAsync(CreatePersonalDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将飞书妙记会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于将飞书妙记中的会议记录上传至指定数字员工的&quot;我的资源&quot;中。通过提供必要的参数，如飞书妙记的唯一标识符（<c>minuteToken</c>）和凭证 ID（<c>credentialId</c>），可以实现会议内容的迁移与保存。若未指定目标目录，则默认绑定到当前数字员工下的根目录。</para>
        /// <list type="bullet">
        /// <item><description><c>operatingObjectName</c>：执行操作的数字员工名称。</description></item>
        /// <item><description><c>name</c>：上传后资源在系统内的显示名称。</description></item>
        /// <item><description><c>minuteToken</c>：来自飞书妙记平台的会议唯一标识符。</description></item>
        /// <item><description><c>credentialId</c>：关联到特定认证信息的ID，用于验证请求合法性。</description></item>
        /// <item><description><c>directoryId</c>（可选）：指定要存放资源的目标个人目录ID；如果省略此字段，则资源将被自动放置于默认位置。</description></item>
        /// <item><description><c>description</c>（可选）：对所上传资源的简短描述或备注。
        /// 注意事项：</description></item>
        /// <item><description>确保提供的 <c>minuteToken</c> 和 <c>credentialId</c> 的有效性。</description></item>
        /// <item><description>当指定了 <c>directoryId</c> 时，请确认其属于调用者在当前数字员工环境下的可用个人目录之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFeishuMinuteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFeishuMinuteResponse
        /// </returns>
        public CreatePersonalFeishuMinuteResponse CreatePersonalFeishuMinuteWithOptions(CreatePersonalFeishuMinuteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                body["credentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinuteToken))
            {
                body["minuteToken"] = request.MinuteToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalFeishuMinute",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalFeishuMinute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalFeishuMinuteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将飞书妙记会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于将飞书妙记中的会议记录上传至指定数字员工的&quot;我的资源&quot;中。通过提供必要的参数，如飞书妙记的唯一标识符（<c>minuteToken</c>）和凭证 ID（<c>credentialId</c>），可以实现会议内容的迁移与保存。若未指定目标目录，则默认绑定到当前数字员工下的根目录。</para>
        /// <list type="bullet">
        /// <item><description><c>operatingObjectName</c>：执行操作的数字员工名称。</description></item>
        /// <item><description><c>name</c>：上传后资源在系统内的显示名称。</description></item>
        /// <item><description><c>minuteToken</c>：来自飞书妙记平台的会议唯一标识符。</description></item>
        /// <item><description><c>credentialId</c>：关联到特定认证信息的ID，用于验证请求合法性。</description></item>
        /// <item><description><c>directoryId</c>（可选）：指定要存放资源的目标个人目录ID；如果省略此字段，则资源将被自动放置于默认位置。</description></item>
        /// <item><description><c>description</c>（可选）：对所上传资源的简短描述或备注。
        /// 注意事项：</description></item>
        /// <item><description>确保提供的 <c>minuteToken</c> 和 <c>credentialId</c> 的有效性。</description></item>
        /// <item><description>当指定了 <c>directoryId</c> 时，请确认其属于调用者在当前数字员工环境下的可用个人目录之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFeishuMinuteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFeishuMinuteResponse
        /// </returns>
        public async Task<CreatePersonalFeishuMinuteResponse> CreatePersonalFeishuMinuteWithOptionsAsync(CreatePersonalFeishuMinuteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                body["credentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinuteToken))
            {
                body["minuteToken"] = request.MinuteToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalFeishuMinute",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalFeishuMinute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalFeishuMinuteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将飞书妙记会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于将飞书妙记中的会议记录上传至指定数字员工的&quot;我的资源&quot;中。通过提供必要的参数，如飞书妙记的唯一标识符（<c>minuteToken</c>）和凭证 ID（<c>credentialId</c>），可以实现会议内容的迁移与保存。若未指定目标目录，则默认绑定到当前数字员工下的根目录。</para>
        /// <list type="bullet">
        /// <item><description><c>operatingObjectName</c>：执行操作的数字员工名称。</description></item>
        /// <item><description><c>name</c>：上传后资源在系统内的显示名称。</description></item>
        /// <item><description><c>minuteToken</c>：来自飞书妙记平台的会议唯一标识符。</description></item>
        /// <item><description><c>credentialId</c>：关联到特定认证信息的ID，用于验证请求合法性。</description></item>
        /// <item><description><c>directoryId</c>（可选）：指定要存放资源的目标个人目录ID；如果省略此字段，则资源将被自动放置于默认位置。</description></item>
        /// <item><description><c>description</c>（可选）：对所上传资源的简短描述或备注。
        /// 注意事项：</description></item>
        /// <item><description>确保提供的 <c>minuteToken</c> 和 <c>credentialId</c> 的有效性。</description></item>
        /// <item><description>当指定了 <c>directoryId</c> 时，请确认其属于调用者在当前数字员工环境下的可用个人目录之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFeishuMinuteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFeishuMinuteResponse
        /// </returns>
        public CreatePersonalFeishuMinuteResponse CreatePersonalFeishuMinute(CreatePersonalFeishuMinuteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalFeishuMinuteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将飞书妙记会议文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于将飞书妙记中的会议记录上传至指定数字员工的&quot;我的资源&quot;中。通过提供必要的参数，如飞书妙记的唯一标识符（<c>minuteToken</c>）和凭证 ID（<c>credentialId</c>），可以实现会议内容的迁移与保存。若未指定目标目录，则默认绑定到当前数字员工下的根目录。</para>
        /// <list type="bullet">
        /// <item><description><c>operatingObjectName</c>：执行操作的数字员工名称。</description></item>
        /// <item><description><c>name</c>：上传后资源在系统内的显示名称。</description></item>
        /// <item><description><c>minuteToken</c>：来自飞书妙记平台的会议唯一标识符。</description></item>
        /// <item><description><c>credentialId</c>：关联到特定认证信息的ID，用于验证请求合法性。</description></item>
        /// <item><description><c>directoryId</c>（可选）：指定要存放资源的目标个人目录ID；如果省略此字段，则资源将被自动放置于默认位置。</description></item>
        /// <item><description><c>description</c>（可选）：对所上传资源的简短描述或备注。
        /// 注意事项：</description></item>
        /// <item><description>确保提供的 <c>minuteToken</c> 和 <c>credentialId</c> 的有效性。</description></item>
        /// <item><description>当指定了 <c>directoryId</c> 时，请确认其属于调用者在当前数字员工环境下的可用个人目录之一。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFeishuMinuteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFeishuMinuteResponse
        /// </returns>
        public async Task<CreatePersonalFeishuMinuteResponse> CreatePersonalFeishuMinuteAsync(CreatePersonalFeishuMinuteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalFeishuMinuteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将文件上传到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>FILE</c>，<c>scope</c> 固定为 <c>PERSONAL</c>，<c>platform</c> 固定为 <c>LOCAL</c>。</description></item>
        /// <item><description>文件必须提供OSS持久化地址 (<c>filePath</c>)，其他如公开访问URL、原始文件名等信息可选提供。</description></item>
        /// <item><description>如果不指定目标目录ID (<c>directoryId</c>)，则文件会被自动绑定到当前数字员工默认根目录下；如果指定，则需确保该目录属于调用者的个人目录。</description></item>
        /// <item><description>支持通过多种认证方式（AK、BearerToken、APP）进行安全验证。</description></item>
        /// <item><description>操作类型为写入(<c>write</c>)，并记录操作日志以供后续审计使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFileResponse
        /// </returns>
        public CreatePersonalFileResponse CreatePersonalFileWithOptions(CreatePersonalFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExt))
            {
                body["fileExt"] = request.FileExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将文件上传到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>FILE</c>，<c>scope</c> 固定为 <c>PERSONAL</c>，<c>platform</c> 固定为 <c>LOCAL</c>。</description></item>
        /// <item><description>文件必须提供OSS持久化地址 (<c>filePath</c>)，其他如公开访问URL、原始文件名等信息可选提供。</description></item>
        /// <item><description>如果不指定目标目录ID (<c>directoryId</c>)，则文件会被自动绑定到当前数字员工默认根目录下；如果指定，则需确保该目录属于调用者的个人目录。</description></item>
        /// <item><description>支持通过多种认证方式（AK、BearerToken、APP）进行安全验证。</description></item>
        /// <item><description>操作类型为写入(<c>write</c>)，并记录操作日志以供后续审计使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFileResponse
        /// </returns>
        public async Task<CreatePersonalFileResponse> CreatePersonalFileWithOptionsAsync(CreatePersonalFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExt))
            {
                body["fileExt"] = request.FileExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将文件上传到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>FILE</c>，<c>scope</c> 固定为 <c>PERSONAL</c>，<c>platform</c> 固定为 <c>LOCAL</c>。</description></item>
        /// <item><description>文件必须提供OSS持久化地址 (<c>filePath</c>)，其他如公开访问URL、原始文件名等信息可选提供。</description></item>
        /// <item><description>如果不指定目标目录ID (<c>directoryId</c>)，则文件会被自动绑定到当前数字员工默认根目录下；如果指定，则需确保该目录属于调用者的个人目录。</description></item>
        /// <item><description>支持通过多种认证方式（AK、BearerToken、APP）进行安全验证。</description></item>
        /// <item><description>操作类型为写入(<c>write</c>)，并记录操作日志以供后续审计使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFileResponse
        /// </returns>
        public CreatePersonalFileResponse CreatePersonalFile(CreatePersonalFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将文件上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将文件上传到指定数字员工的&quot;我的资源&quot;中。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>FILE</c>，<c>scope</c> 固定为 <c>PERSONAL</c>，<c>platform</c> 固定为 <c>LOCAL</c>。</description></item>
        /// <item><description>文件必须提供OSS持久化地址 (<c>filePath</c>)，其他如公开访问URL、原始文件名等信息可选提供。</description></item>
        /// <item><description>如果不指定目标目录ID (<c>directoryId</c>)，则文件会被自动绑定到当前数字员工默认根目录下；如果指定，则需确保该目录属于调用者的个人目录。</description></item>
        /// <item><description>支持通过多种认证方式（AK、BearerToken、APP）进行安全验证。</description></item>
        /// <item><description>操作类型为写入(<c>write</c>)，并记录操作日志以供后续审计使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalFileResponse
        /// </returns>
        public async Task<CreatePersonalFileResponse> CreatePersonalFileAsync(CreatePersonalFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向指定数字员工的个人资源中添加纯文本内容。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>TEXT</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，通过请求体传递这些参数将被忽略。</description></item>
        /// <item><description>调用过程中会启动计量并生成相应的<c>billing_id</c>。</description></item>
        /// <item><description>文本内容将被写入<c>unstructured_docs</c>，并生成初始资源记录。</description></item>
        /// <item><description>任何校验或执行失败都将抛出<c>RobjectException</c>异常，并由全局中间件转换为POP错误码返回给调用方。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTextResponse
        /// </returns>
        public CreatePersonalTextResponse CreatePersonalTextWithOptions(CreatePersonalTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalText",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向指定数字员工的个人资源中添加纯文本内容。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>TEXT</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，通过请求体传递这些参数将被忽略。</description></item>
        /// <item><description>调用过程中会启动计量并生成相应的<c>billing_id</c>。</description></item>
        /// <item><description>文本内容将被写入<c>unstructured_docs</c>，并生成初始资源记录。</description></item>
        /// <item><description>任何校验或执行失败都将抛出<c>RobjectException</c>异常，并由全局中间件转换为POP错误码返回给调用方。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTextResponse
        /// </returns>
        public async Task<CreatePersonalTextResponse> CreatePersonalTextWithOptionsAsync(CreatePersonalTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalText",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向指定数字员工的个人资源中添加纯文本内容。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>TEXT</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，通过请求体传递这些参数将被忽略。</description></item>
        /// <item><description>调用过程中会启动计量并生成相应的<c>billing_id</c>。</description></item>
        /// <item><description>文本内容将被写入<c>unstructured_docs</c>，并生成初始资源记录。</description></item>
        /// <item><description>任何校验或执行失败都将抛出<c>RobjectException</c>异常，并由全局中间件转换为POP错误码返回给调用方。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalTextRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTextResponse
        /// </returns>
        public CreatePersonalTextResponse CreatePersonalText(CreatePersonalTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePersonalTextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将纯文本内容上传至当前数字员工的个人资源库。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于向指定数字员工的个人资源中添加纯文本内容。</description></item>
        /// <item><description><c>source_type</c> 固定为 <c>TEXT</c>，<c>scope</c> 固定为 <c>PERSONAL</c>。</description></item>
        /// <item><description>如果不提供<c>directoryId</c>，则默认绑定到当前数字员工的根目录；若提供，则必须是调用者在该数字员工下的已有个人目录。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，通过请求体传递这些参数将被忽略。</description></item>
        /// <item><description>调用过程中会启动计量并生成相应的<c>billing_id</c>。</description></item>
        /// <item><description>文本内容将被写入<c>unstructured_docs</c>，并生成初始资源记录。</description></item>
        /// <item><description>任何校验或执行失败都将抛出<c>RobjectException</c>异常，并由全局中间件转换为POP错误码返回给调用方。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalTextRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTextResponse
        /// </returns>
        public async Task<CreatePersonalTextResponse> CreatePersonalTextAsync(CreatePersonalTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePersonalTextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将离线会议音频文件上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将离线会议的音频文件上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c>固定为<c>VOICE_MEETING</c>，<c>scope</c>固定为<c>PERSONAL</c>，且<c>voice_meeting_type</c>固定为<c>OFFLINE</c>。</description></item>
        /// <item><description>如果请求体中未提供<c>directoryId</c>，则资源将自动绑定到默认根目录；若提供了<c>directoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description>调用此接口会启动一个后台流程来处理音频文件转写，并返回新建资源的相关信息。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，即使请求体中包含这些字段也会被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会抛出<c>RobjectException</c>，并通过全局中间件转换为POP错误码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalVoiceMeetingRequest
        /// </param>
        /// <param name="headers">
        /// CreatePersonalVoiceMeetingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalVoiceMeetingResponse
        /// </returns>
        public CreatePersonalVoiceMeetingResponse CreatePersonalVoiceMeetingWithOptions(CreatePersonalVoiceMeetingRequest request, CreatePersonalVoiceMeetingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RequestId))
            {
                realHeaders["requestId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.RequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalVoiceMeeting",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalVoiceMeeting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalVoiceMeetingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将离线会议音频文件上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将离线会议的音频文件上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c>固定为<c>VOICE_MEETING</c>，<c>scope</c>固定为<c>PERSONAL</c>，且<c>voice_meeting_type</c>固定为<c>OFFLINE</c>。</description></item>
        /// <item><description>如果请求体中未提供<c>directoryId</c>，则资源将自动绑定到默认根目录；若提供了<c>directoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description>调用此接口会启动一个后台流程来处理音频文件转写，并返回新建资源的相关信息。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，即使请求体中包含这些字段也会被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会抛出<c>RobjectException</c>，并通过全局中间件转换为POP错误码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalVoiceMeetingRequest
        /// </param>
        /// <param name="headers">
        /// CreatePersonalVoiceMeetingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalVoiceMeetingResponse
        /// </returns>
        public async Task<CreatePersonalVoiceMeetingResponse> CreatePersonalVoiceMeetingWithOptionsAsync(CreatePersonalVoiceMeetingRequest request, CreatePersonalVoiceMeetingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RequestId))
            {
                realHeaders["requestId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.RequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalVoiceMeeting",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createPersonalVoiceMeeting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalVoiceMeetingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将离线会议音频文件上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将离线会议的音频文件上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c>固定为<c>VOICE_MEETING</c>，<c>scope</c>固定为<c>PERSONAL</c>，且<c>voice_meeting_type</c>固定为<c>OFFLINE</c>。</description></item>
        /// <item><description>如果请求体中未提供<c>directoryId</c>，则资源将自动绑定到默认根目录；若提供了<c>directoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description>调用此接口会启动一个后台流程来处理音频文件转写，并返回新建资源的相关信息。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，即使请求体中包含这些字段也会被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会抛出<c>RobjectException</c>，并通过全局中间件转换为POP错误码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalVoiceMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalVoiceMeetingResponse
        /// </returns>
        public CreatePersonalVoiceMeetingResponse CreatePersonalVoiceMeeting(CreatePersonalVoiceMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePersonalVoiceMeetingHeaders headers = new CreatePersonalVoiceMeetingHeaders();
            return CreatePersonalVoiceMeetingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将离线会议音频文件上传至当前数字员工的个人资源中。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将离线会议的音频文件上传到指定数字员工的“我的资源”中。</description></item>
        /// <item><description><c>source_type</c>固定为<c>VOICE_MEETING</c>，<c>scope</c>固定为<c>PERSONAL</c>，且<c>voice_meeting_type</c>固定为<c>OFFLINE</c>。</description></item>
        /// <item><description>如果请求体中未提供<c>directoryId</c>，则资源将自动绑定到默认根目录；若提供了<c>directoryId</c>，则必须是当前用户在当前数字员工下的已有个人目录。</description></item>
        /// <item><description>调用此接口会启动一个后台流程来处理音频文件转写，并返回新建资源的相关信息。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>和<c>user_id</c>仅从鉴权身份获取，即使请求体中包含这些字段也会被忽略。</description></item>
        /// <item><description>任何校验或执行失败都会抛出<c>RobjectException</c>，并通过全局中间件转换为POP错误码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePersonalVoiceMeetingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalVoiceMeetingResponse
        /// </returns>
        public async Task<CreatePersonalVoiceMeetingResponse> CreatePersonalVoiceMeetingAsync(CreatePersonalVoiceMeetingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePersonalVoiceMeetingHeaders headers = new CreatePersonalVoiceMeetingHeaders();
            return await CreatePersonalVoiceMeetingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduledTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public CreateScheduledTaskResponse CreateScheduledTaskWithOptions(CreateScheduledTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledTaskShrinkRequest request = new CreateScheduledTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Description))
            {
                request.DescriptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Description, "description", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Segments))
            {
                request.SegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Segments, "segments", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDetail))
            {
                request.TaskDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDetail, "taskDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TriggerConfig))
            {
                request.TriggerConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TriggerConfig, "triggerConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                body["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescriptionShrink))
            {
                body["description"] = request.DescriptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpen))
            {
                body["isOpen"] = request.IsOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SegmentsShrink))
            {
                body["segments"] = request.SegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailShrink))
            {
                body["taskDetail"] = request.TaskDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfigShrink))
            {
                body["triggerConfig"] = request.TriggerConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createScheduledTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateScheduledTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskWithOptionsAsync(CreateScheduledTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledTaskShrinkRequest request = new CreateScheduledTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Description))
            {
                request.DescriptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Description, "description", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Segments))
            {
                request.SegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Segments, "segments", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDetail))
            {
                request.TaskDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDetail, "taskDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TriggerConfig))
            {
                request.TriggerConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TriggerConfig, "triggerConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                body["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescriptionShrink))
            {
                body["description"] = request.DescriptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpen))
            {
                body["isOpen"] = request.IsOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SegmentsShrink))
            {
                body["segments"] = request.SegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailShrink))
            {
                body["taskDetail"] = request.TaskDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfigShrink))
            {
                body["triggerConfig"] = request.TriggerConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createScheduledTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public CreateScheduledTaskResponse CreateScheduledTask(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateScheduledTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskAsync(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateScheduledTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用租户和用户信息创建企业知识库目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在指定租户下创建新的企业知识库目录。</description></item>
        /// <item><description>可以通过设置 <c>parentId</c> 参数来指定新目录的父目录，如果不传则默认创建为根目录。</description></item>
        /// <item><description><c>path</c> 参数可选，不提供时系统会根据父目录自动计算路径。</description></item>
        /// <item><description>调用此接口需要具备相应的权限，并且支持多种认证方式包括 AK、BearerToken 和 APP 认证。</description></item>
        /// <item><description>创建成功后返回新目录的相关信息，如目录 ID、名称等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantDirectoryResponse
        /// </returns>
        public CreateTenantDirectoryResponse CreateTenantDirectoryWithOptions(CreateTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用租户和用户信息创建企业知识库目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在指定租户下创建新的企业知识库目录。</description></item>
        /// <item><description>可以通过设置 <c>parentId</c> 参数来指定新目录的父目录，如果不传则默认创建为根目录。</description></item>
        /// <item><description><c>path</c> 参数可选，不提供时系统会根据父目录自动计算路径。</description></item>
        /// <item><description>调用此接口需要具备相应的权限，并且支持多种认证方式包括 AK、BearerToken 和 APP 认证。</description></item>
        /// <item><description>创建成功后返回新目录的相关信息，如目录 ID、名称等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantDirectoryResponse
        /// </returns>
        public async Task<CreateTenantDirectoryResponse> CreateTenantDirectoryWithOptionsAsync(CreateTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用租户和用户信息创建企业知识库目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在指定租户下创建新的企业知识库目录。</description></item>
        /// <item><description>可以通过设置 <c>parentId</c> 参数来指定新目录的父目录，如果不传则默认创建为根目录。</description></item>
        /// <item><description><c>path</c> 参数可选，不提供时系统会根据父目录自动计算路径。</description></item>
        /// <item><description>调用此接口需要具备相应的权限，并且支持多种认证方式包括 AK、BearerToken 和 APP 认证。</description></item>
        /// <item><description>创建成功后返回新目录的相关信息，如目录 ID、名称等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantDirectoryResponse
        /// </returns>
        public CreateTenantDirectoryResponse CreateTenantDirectory(CreateTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTenantDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用租户和用户信息创建企业知识库目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于在指定租户下创建新的企业知识库目录。</description></item>
        /// <item><description>可以通过设置 <c>parentId</c> 参数来指定新目录的父目录，如果不传则默认创建为根目录。</description></item>
        /// <item><description><c>path</c> 参数可选，不提供时系统会根据父目录自动计算路径。</description></item>
        /// <item><description>调用此接口需要具备相应的权限，并且支持多种认证方式包括 AK、BearerToken 和 APP 认证。</description></item>
        /// <item><description>创建成功后返回新目录的相关信息，如目录 ID、名称等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTenantDirectoryResponse
        /// </returns>
        public async Task<CreateTenantDirectoryResponse> CreateTenantDirectoryAsync(CreateTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTenantDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户并加入租户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 创建用户。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids（系统角色枚举校验）
        ///     2. 判断用户是否已存在（用于返回 isNewUser 标记）
        ///     3. 调用 UserManagementService.add_tenant_member 完成创建/加入（密码由调用方强制传入 RSA 密文）
        ///     4. 返回创建结果（含 isNewUser 标记）
        ///     错误码：
        ///     - ERR.User.DeactivatedInTenant: 用户在租户中已停用，请使用 updateUser 恢复
        ///     - ERR.User.AlreadyInTenant: 用户已是租户活跃成员
        ///     - ERR.User.DisplayNameDuplicateInTenant: 租户内显示名重复</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserShrinkRequest request = new CreateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoleCodes))
            {
                request.RoleCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoleCodes, "roleCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordEncrypted))
            {
                body["passwordEncrypted"] = request.PasswordEncrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodesShrink))
            {
                body["roleCodes"] = request.RoleCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnAccountId))
            {
                body["wnAccountId"] = request.WnAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户并加入租户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 创建用户。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids（系统角色枚举校验）
        ///     2. 判断用户是否已存在（用于返回 isNewUser 标记）
        ///     3. 调用 UserManagementService.add_tenant_member 完成创建/加入（密码由调用方强制传入 RSA 密文）
        ///     4. 返回创建结果（含 isNewUser 标记）
        ///     错误码：
        ///     - ERR.User.DeactivatedInTenant: 用户在租户中已停用，请使用 updateUser 恢复
        ///     - ERR.User.AlreadyInTenant: 用户已是租户活跃成员
        ///     - ERR.User.DisplayNameDuplicateInTenant: 租户内显示名重复</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserShrinkRequest request = new CreateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoleCodes))
            {
                request.RoleCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoleCodes, "roleCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordEncrypted))
            {
                body["passwordEncrypted"] = request.PasswordEncrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodesShrink))
            {
                body["roleCodes"] = request.RoleCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnAccountId))
            {
                body["wnAccountId"] = request.WnAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/createUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户并加入租户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 创建用户。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids（系统角色枚举校验）
        ///     2. 判断用户是否已存在（用于返回 isNewUser 标记）
        ///     3. 调用 UserManagementService.add_tenant_member 完成创建/加入（密码由调用方强制传入 RSA 密文）
        ///     4. 返回创建结果（含 isNewUser 标记）
        ///     错误码：
        ///     - ERR.User.DeactivatedInTenant: 用户在租户中已停用，请使用 updateUser 恢复
        ///     - ERR.User.AlreadyInTenant: 用户已是租户活跃成员
        ///     - ERR.User.DisplayNameDuplicateInTenant: 租户内显示名重复</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户并加入租户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 创建用户。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids（系统角色枚举校验）
        ///     2. 判断用户是否已存在（用于返回 isNewUser 标记）
        ///     3. 调用 UserManagementService.add_tenant_member 完成创建/加入（密码由调用方强制传入 RSA 密文）
        ///     4. 返回创建结果（含 isNewUser 标记）
        ///     错误码：
        ///     - ERR.User.DeactivatedInTenant: 用户在租户中已停用，请使用 updateUser 恢复
        ///     - ERR.User.AlreadyInTenant: 用户已是租户活跃成员
        ///     - ERR.User.DisplayNameDuplicateInTenant: 租户内显示名重复</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatSessionResponse
        /// </returns>
        public DeleteChatSessionResponse DeleteChatSessionWithOptions(DeleteChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChatSession",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/deleteChatSession",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatSessionResponse
        /// </returns>
        public async Task<DeleteChatSessionResponse> DeleteChatSessionWithOptionsAsync(DeleteChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChatSession",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/deleteChatSession",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatSessionResponse
        /// </returns>
        public DeleteChatSessionResponse DeleteChatSession(DeleteChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteChatSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatSessionResponse
        /// </returns>
        public async Task<DeleteChatSessionResponse> DeleteChatSessionAsync(DeleteChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteChatSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除当前租户内的指定资源（知识）。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenantId</c> 仅来自鉴权身份；调用方传入会被忽略。</description></item>
        /// <item><description><c>sourceId</c> 通过 body 传递，注册路径为扁平的 <c>/openapi/deleteSource</c>，不含 <c>{sourceId}</c> 路径模板；请勿以路径段形式追加资源 ID，网关按扁平 URI 精确路由，会回 <c>InvalidAction.NotFound</c>。</description></item>
        /// <item><description>删除为不可逆操作，资源关联的解析结果与绑定关系会一并失效。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSourceResponse
        /// </returns>
        public DeleteSourceResponse DeleteSourceWithOptions(DeleteSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/deleteSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除当前租户内的指定资源（知识）。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenantId</c> 仅来自鉴权身份；调用方传入会被忽略。</description></item>
        /// <item><description><c>sourceId</c> 通过 body 传递，注册路径为扁平的 <c>/openapi/deleteSource</c>，不含 <c>{sourceId}</c> 路径模板；请勿以路径段形式追加资源 ID，网关按扁平 URI 精确路由，会回 <c>InvalidAction.NotFound</c>。</description></item>
        /// <item><description>删除为不可逆操作，资源关联的解析结果与绑定关系会一并失效。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSourceResponse
        /// </returns>
        public async Task<DeleteSourceResponse> DeleteSourceWithOptionsAsync(DeleteSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/deleteSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除当前租户内的指定资源（知识）。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenantId</c> 仅来自鉴权身份；调用方传入会被忽略。</description></item>
        /// <item><description><c>sourceId</c> 通过 body 传递，注册路径为扁平的 <c>/openapi/deleteSource</c>，不含 <c>{sourceId}</c> 路径模板；请勿以路径段形式追加资源 ID，网关按扁平 URI 精确路由，会回 <c>InvalidAction.NotFound</c>。</description></item>
        /// <item><description>删除为不可逆操作，资源关联的解析结果与绑定关系会一并失效。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSourceResponse
        /// </returns>
        public DeleteSourceResponse DeleteSource(DeleteSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除当前租户内的指定资源（知识）。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenantId</c> 仅来自鉴权身份；调用方传入会被忽略。</description></item>
        /// <item><description><c>sourceId</c> 通过 body 传递，注册路径为扁平的 <c>/openapi/deleteSource</c>，不含 <c>{sourceId}</c> 路径模板；请勿以路径段形式追加资源 ID，网关按扁平 URI 精确路由，会回 <c>InvalidAction.NotFound</c>。</description></item>
        /// <item><description>删除为不可逆操作，资源关联的解析结果与绑定关系会一并失效。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSourceResponse
        /// </returns>
        public async Task<DeleteSourceResponse> DeleteSourceAsync(DeleteSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定的企业知识库目录，支持不同删除模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许用户删除特定的企业知识库目录。</description></item>
        /// <item><description>用户可以通过设置<c>deleteMode</c>参数来选择不同的删除策略，包括拒绝删除（reject）、递归删除（recursive）或将目录移动到根目录（move_to_root）。</description></item>
        /// <item><description>如果不提供<c>deleteMode</c>，默认行为是拒绝删除。</description></item>
        /// <item><description>删除操作前会校验企业目录边界。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantDirectoryResponse
        /// </returns>
        public DeleteTenantDirectoryResponse DeleteTenantDirectoryWithOptions(DeleteTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteMode))
            {
                body["deleteMode"] = request.DeleteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/deleteTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定的企业知识库目录，支持不同删除模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许用户删除特定的企业知识库目录。</description></item>
        /// <item><description>用户可以通过设置<c>deleteMode</c>参数来选择不同的删除策略，包括拒绝删除（reject）、递归删除（recursive）或将目录移动到根目录（move_to_root）。</description></item>
        /// <item><description>如果不提供<c>deleteMode</c>，默认行为是拒绝删除。</description></item>
        /// <item><description>删除操作前会校验企业目录边界。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantDirectoryResponse
        /// </returns>
        public async Task<DeleteTenantDirectoryResponse> DeleteTenantDirectoryWithOptionsAsync(DeleteTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteMode))
            {
                body["deleteMode"] = request.DeleteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/deleteTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定的企业知识库目录，支持不同删除模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许用户删除特定的企业知识库目录。</description></item>
        /// <item><description>用户可以通过设置<c>deleteMode</c>参数来选择不同的删除策略，包括拒绝删除（reject）、递归删除（recursive）或将目录移动到根目录（move_to_root）。</description></item>
        /// <item><description>如果不提供<c>deleteMode</c>，默认行为是拒绝删除。</description></item>
        /// <item><description>删除操作前会校验企业目录边界。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantDirectoryResponse
        /// </returns>
        public DeleteTenantDirectoryResponse DeleteTenantDirectory(DeleteTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTenantDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于删除指定的企业知识库目录，支持不同删除模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许用户删除特定的企业知识库目录。</description></item>
        /// <item><description>用户可以通过设置<c>deleteMode</c>参数来选择不同的删除策略，包括拒绝删除（reject）、递归删除（recursive）或将目录移动到根目录（move_to_root）。</description></item>
        /// <item><description>如果不提供<c>deleteMode</c>，默认行为是拒绝删除。</description></item>
        /// <item><description>删除操作前会校验企业目录边界。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTenantDirectoryResponse
        /// </returns>
        public async Task<DeleteTenantDirectoryResponse> DeleteTenantDirectoryAsync(DeleteTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTenantDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>关闭用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 disable_token（ACTIVE → INACTIVE）
        ///     4. 返回 disabled=True
        ///     幂等性：若当前无 ACTIVE Token，deactivate_all 影响 0 行，不报错。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableTokenResponse
        /// </returns>
        public DisableTokenResponse DisableTokenWithOptions(DisableTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableToken",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/disableToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>关闭用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 disable_token（ACTIVE → INACTIVE）
        ///     4. 返回 disabled=True
        ///     幂等性：若当前无 ACTIVE Token，deactivate_all 影响 0 行，不报错。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableTokenResponse
        /// </returns>
        public async Task<DisableTokenResponse> DisableTokenWithOptionsAsync(DisableTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableToken",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/disableToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>关闭用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 disable_token（ACTIVE → INACTIVE）
        ///     4. 返回 disabled=True
        ///     幂等性：若当前无 ACTIVE Token，deactivate_all 影响 0 行，不报错。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableTokenResponse
        /// </returns>
        public DisableTokenResponse DisableToken(DisableTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>关闭用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 disable_token（ACTIVE → INACTIVE）
        ///     4. 返回 disabled=True
        ///     幂等性：若当前无 ACTIVE Token，deactivate_all 影响 0 行，不报错。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableTokenResponse
        /// </returns>
        public async Task<DisableTokenResponse> DisableTokenAsync(DisableTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开启用户的 INSTANCE Token（幂等）。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 enable_token：
        ///        - 已有 ACTIVE → 幂等返回（仅脱敏值，不重复下发明文）
        ///        - 有 INACTIVE → 重新激活（返回明文）
        ///        - 都没有 → 新建（返回明文）
        ///     安全约束：Token 明文仅在首次开启时返回一次，后续幂等调用不再下发明文。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableTokenResponse
        /// </returns>
        public EnableTokenResponse EnableTokenWithOptions(EnableTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableToken",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/enableToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开启用户的 INSTANCE Token（幂等）。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 enable_token：
        ///        - 已有 ACTIVE → 幂等返回（仅脱敏值，不重复下发明文）
        ///        - 有 INACTIVE → 重新激活（返回明文）
        ///        - 都没有 → 新建（返回明文）
        ///     安全约束：Token 明文仅在首次开启时返回一次，后续幂等调用不再下发明文。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableTokenResponse
        /// </returns>
        public async Task<EnableTokenResponse> EnableTokenWithOptionsAsync(EnableTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableToken",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/enableToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开启用户的 INSTANCE Token（幂等）。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 enable_token：
        ///        - 已有 ACTIVE → 幂等返回（仅脱敏值，不重复下发明文）
        ///        - 有 INACTIVE → 重新激活（返回明文）
        ///        - 都没有 → 新建（返回明文）
        ///     安全约束：Token 明文仅在首次开启时返回一次，后续幂等调用不再下发明文。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableTokenResponse
        /// </returns>
        public EnableTokenResponse EnableToken(EnableTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开启用户的 INSTANCE Token（幂等）。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 enable_token：
        ///        - 已有 ACTIVE → 幂等返回（仅脱敏值，不重复下发明文）
        ///        - 有 INACTIVE → 重新激活（返回明文）
        ///        - 都没有 → 新建（返回明文）
        ///     安全约束：Token 明文仅在首次开启时返回一次，后续幂等调用不再下发明文。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableTokenResponse
        /// </returns>
        public async Task<EnableTokenResponse> EnableTokenAsync(EnableTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatSessionResponse
        /// </returns>
        public GetChatSessionResponse GetChatSessionWithOptions(GetChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatSession",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getChatSession",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatSessionResponse
        /// </returns>
        public async Task<GetChatSessionResponse> GetChatSessionWithOptionsAsync(GetChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatSession",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getChatSession",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatSessionResponse
        /// </returns>
        public GetChatSessionResponse GetChatSession(GetChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChatSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatSessionResponse
        /// </returns>
        public async Task<GetChatSessionResponse> GetChatSessionAsync(GetChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChatSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户可读的 active Graph Schema</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>读取 active schema_content，并按 Token 用户的语义资源 READ 权限安全裁剪。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGraphSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGraphSchemaResponse
        /// </returns>
        public GetGraphSchemaResponse GetGraphSchemaWithOptions(GetGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GraphName))
            {
                body["graphName"] = request.GraphName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGraphSchema",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getGraphSchema",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGraphSchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户可读的 active Graph Schema</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>读取 active schema_content，并按 Token 用户的语义资源 READ 权限安全裁剪。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGraphSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGraphSchemaResponse
        /// </returns>
        public async Task<GetGraphSchemaResponse> GetGraphSchemaWithOptionsAsync(GetGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GraphName))
            {
                body["graphName"] = request.GraphName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGraphSchema",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getGraphSchema",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGraphSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户可读的 active Graph Schema</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>读取 active schema_content，并按 Token 用户的语义资源 READ 权限安全裁剪。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGraphSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGraphSchemaResponse
        /// </returns>
        public GetGraphSchemaResponse GetGraphSchema(GetGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGraphSchemaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户可读的 active Graph Schema</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>读取 active schema_content，并按 Token 用户的语义资源 READ 权限安全裁剪。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGraphSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGraphSchemaResponse
        /// </returns>
        public async Task<GetGraphSchemaResponse> GetGraphSchemaAsync(GetGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGraphSchemaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户最新创建的标准包实例的过期时间。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询指定租户下最新创建的标准包实例的过期时间。</description></item>
        /// <item><description>如果未找到相关标准包实例，<c>found</c> 字段将返回 <c>False</c>。</description></item>
        /// <item><description>支持通过 <c>tenantId</c> 参数指定查询的租户ID，默认使用调用方的租户ID。</description></item>
        /// <item><description>请求方法为 POST，且需要通过 HTTPS 协议进行调用。</description></item>
        /// <item><description>需要提供有效的认证信息（如 AK、BearerToken 或 APP）以完成请求。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceExpireTimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceExpireTimeResponse
        /// </returns>
        public GetInstanceExpireTimeResponse GetInstanceExpireTimeWithOptions(GetInstanceExpireTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceExpireTime",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getInstanceExpireTime",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceExpireTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户最新创建的标准包实例的过期时间。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询指定租户下最新创建的标准包实例的过期时间。</description></item>
        /// <item><description>如果未找到相关标准包实例，<c>found</c> 字段将返回 <c>False</c>。</description></item>
        /// <item><description>支持通过 <c>tenantId</c> 参数指定查询的租户ID，默认使用调用方的租户ID。</description></item>
        /// <item><description>请求方法为 POST，且需要通过 HTTPS 协议进行调用。</description></item>
        /// <item><description>需要提供有效的认证信息（如 AK、BearerToken 或 APP）以完成请求。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceExpireTimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceExpireTimeResponse
        /// </returns>
        public async Task<GetInstanceExpireTimeResponse> GetInstanceExpireTimeWithOptionsAsync(GetInstanceExpireTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceExpireTime",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getInstanceExpireTime",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceExpireTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户最新创建的标准包实例的过期时间。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询指定租户下最新创建的标准包实例的过期时间。</description></item>
        /// <item><description>如果未找到相关标准包实例，<c>found</c> 字段将返回 <c>False</c>。</description></item>
        /// <item><description>支持通过 <c>tenantId</c> 参数指定查询的租户ID，默认使用调用方的租户ID。</description></item>
        /// <item><description>请求方法为 POST，且需要通过 HTTPS 协议进行调用。</description></item>
        /// <item><description>需要提供有效的认证信息（如 AK、BearerToken 或 APP）以完成请求。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceExpireTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceExpireTimeResponse
        /// </returns>
        public GetInstanceExpireTimeResponse GetInstanceExpireTime(GetInstanceExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceExpireTimeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户最新创建的标准包实例的过期时间。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询指定租户下最新创建的标准包实例的过期时间。</description></item>
        /// <item><description>如果未找到相关标准包实例，<c>found</c> 字段将返回 <c>False</c>。</description></item>
        /// <item><description>支持通过 <c>tenantId</c> 参数指定查询的租户ID，默认使用调用方的租户ID。</description></item>
        /// <item><description>请求方法为 POST，且需要通过 HTTPS 协议进行调用。</description></item>
        /// <item><description>需要提供有效的认证信息（如 AK、BearerToken 或 APP）以完成请求。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceExpireTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceExpireTimeResponse
        /// </returns>
        public async Task<GetInstanceExpireTimeResponse> GetInstanceExpireTimeAsync(GetInstanceExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceExpireTimeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识在企业知识库中的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库下特定知识的详情。</description></item>
        /// <item><description>调用此接口需要具备 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// <item><description>知识详情包括但不限于知识类型、名称、描述等。</description></item>
        /// <item><description>请求时必须提供 <c>sourceId</c> 参数，标识要查询的知识。</description></item>
        /// <item><description><c>tenantId</c> 是可选参数，默认使用调用方的租户ID。</description></item>
        /// <item><description>支持通过 <c>AK</c>、<c>BearerToken</c> 或 <c>APP</c> 方式进行鉴权。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseSourceResponse
        /// </returns>
        public GetKnowledgeBaseSourceResponse GetKnowledgeBaseSourceWithOptions(GetKnowledgeBaseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBaseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getKnowledgeBaseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识在企业知识库中的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库下特定知识的详情。</description></item>
        /// <item><description>调用此接口需要具备 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// <item><description>知识详情包括但不限于知识类型、名称、描述等。</description></item>
        /// <item><description>请求时必须提供 <c>sourceId</c> 参数，标识要查询的知识。</description></item>
        /// <item><description><c>tenantId</c> 是可选参数，默认使用调用方的租户ID。</description></item>
        /// <item><description>支持通过 <c>AK</c>、<c>BearerToken</c> 或 <c>APP</c> 方式进行鉴权。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseSourceResponse
        /// </returns>
        public async Task<GetKnowledgeBaseSourceResponse> GetKnowledgeBaseSourceWithOptionsAsync(GetKnowledgeBaseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBaseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getKnowledgeBaseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识在企业知识库中的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库下特定知识的详情。</description></item>
        /// <item><description>调用此接口需要具备 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// <item><description>知识详情包括但不限于知识类型、名称、描述等。</description></item>
        /// <item><description>请求时必须提供 <c>sourceId</c> 参数，标识要查询的知识。</description></item>
        /// <item><description><c>tenantId</c> 是可选参数，默认使用调用方的租户ID。</description></item>
        /// <item><description>支持通过 <c>AK</c>、<c>BearerToken</c> 或 <c>APP</c> 方式进行鉴权。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseSourceResponse
        /// </returns>
        public GetKnowledgeBaseSourceResponse GetKnowledgeBaseSource(GetKnowledgeBaseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKnowledgeBaseSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定知识在企业知识库中的详细信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库下特定知识的详情。</description></item>
        /// <item><description>调用此接口需要具备 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// <item><description>知识详情包括但不限于知识类型、名称、描述等。</description></item>
        /// <item><description>请求时必须提供 <c>sourceId</c> 参数，标识要查询的知识。</description></item>
        /// <item><description><c>tenantId</c> 是可选参数，默认使用调用方的租户ID。</description></item>
        /// <item><description>支持通过 <c>AK</c>、<c>BearerToken</c> 或 <c>APP</c> 方式进行鉴权。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseSourceResponse
        /// </returns>
        public async Task<GetKnowledgeBaseSourceResponse> GetKnowledgeBaseSourceAsync(GetKnowledgeBaseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKnowledgeBaseSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionDetailResponse
        /// </returns>
        public GetScheduledTaskExecutionDetailResponse GetScheduledTaskExecutionDetailWithOptions(GetScheduledTaskExecutionDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["executionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledTaskExecutionDetail",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getScheduledTaskExecutionDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledTaskExecutionDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionDetailResponse
        /// </returns>
        public async Task<GetScheduledTaskExecutionDetailResponse> GetScheduledTaskExecutionDetailWithOptionsAsync(GetScheduledTaskExecutionDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["executionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledTaskExecutionDetail",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getScheduledTaskExecutionDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledTaskExecutionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionDetailResponse
        /// </returns>
        public GetScheduledTaskExecutionDetailResponse GetScheduledTaskExecutionDetail(GetScheduledTaskExecutionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScheduledTaskExecutionDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionDetailResponse
        /// </returns>
        public async Task<GetScheduledTaskExecutionDetailResponse> GetScheduledTaskExecutionDetailAsync(GetScheduledTaskExecutionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScheduledTaskExecutionDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionRecordsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionRecordsResponse
        /// </returns>
        public GetScheduledTaskExecutionRecordsResponse GetScheduledTaskExecutionRecordsWithOptions(GetScheduledTaskExecutionRecordsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                query["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledTaskExecutionRecords",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getScheduledTaskExecutionRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledTaskExecutionRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionRecordsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionRecordsResponse
        /// </returns>
        public async Task<GetScheduledTaskExecutionRecordsResponse> GetScheduledTaskExecutionRecordsWithOptionsAsync(GetScheduledTaskExecutionRecordsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                query["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledTaskExecutionRecords",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getScheduledTaskExecutionRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledTaskExecutionRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionRecordsResponse
        /// </returns>
        public GetScheduledTaskExecutionRecordsResponse GetScheduledTaskExecutionRecords(GetScheduledTaskExecutionRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScheduledTaskExecutionRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务执行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskExecutionRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskExecutionRecordsResponse
        /// </returns>
        public async Task<GetScheduledTaskExecutionRecordsResponse> GetScheduledTaskExecutionRecordsAsync(GetScheduledTaskExecutionRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScheduledTaskExecutionRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务理解详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetScheduledTaskUnderstandDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskUnderstandDetailResponse
        /// </returns>
        public GetScheduledTaskUnderstandDetailResponse GetScheduledTaskUnderstandDetailWithOptions(GetScheduledTaskUnderstandDetailRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetScheduledTaskUnderstandDetailShrinkRequest request = new GetScheduledTaskUnderstandDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Segments))
            {
                request.SegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Segments, "segments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                query["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                query["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SegmentsShrink))
            {
                query["segments"] = request.SegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInput))
            {
                query["userInput"] = request.UserInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledTaskUnderstandDetail",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getScheduledTaskUnderstandDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledTaskUnderstandDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务理解详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetScheduledTaskUnderstandDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskUnderstandDetailResponse
        /// </returns>
        public async Task<GetScheduledTaskUnderstandDetailResponse> GetScheduledTaskUnderstandDetailWithOptionsAsync(GetScheduledTaskUnderstandDetailRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetScheduledTaskUnderstandDetailShrinkRequest request = new GetScheduledTaskUnderstandDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Segments))
            {
                request.SegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Segments, "segments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                query["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                query["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SegmentsShrink))
            {
                query["segments"] = request.SegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInput))
            {
                query["userInput"] = request.UserInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledTaskUnderstandDetail",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getScheduledTaskUnderstandDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledTaskUnderstandDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务理解详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskUnderstandDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskUnderstandDetailResponse
        /// </returns>
        public GetScheduledTaskUnderstandDetailResponse GetScheduledTaskUnderstandDetail(GetScheduledTaskUnderstandDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScheduledTaskUnderstandDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务理解详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledTaskUnderstandDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledTaskUnderstandDetailResponse
        /// </returns>
        public async Task<GetScheduledTaskUnderstandDetailResponse> GetScheduledTaskUnderstandDetailAsync(GetScheduledTaskUnderstandDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScheduledTaskUnderstandDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>根据 SkillCode 或 SkillName 查询技能详情，包括元数据、入参 Schema、SKILL.md 摘要等。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header；不传时使用当前调用方的默认租户。</description></item>
        /// <item><description><b>SkillCode</b>：与 SkillName 二选一；同时传入时 SkillCode 优先。</description></item>
        /// <item><description><b>SkillName</b>：与 SkillCode 二选一；租户内不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>ViewMode</b>：可选，<c>draft</c>（草稿/编辑视角）或 <c>published</c>（已发布视角，默认）。</description></item>
        /// <item><description><b>IncludeSkillFiles</b>：可选，是否返回完整技能文件树（SKILL.md / scripts / templates），默认 <c>false</c>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkillWithOptions(GetSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSkillFiles))
            {
                body["includeSkillFiles"] = request.IncludeSkillFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillCode))
            {
                body["skillCode"] = request.SkillCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewMode))
            {
                body["viewMode"] = request.ViewMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSkill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>根据 SkillCode 或 SkillName 查询技能详情，包括元数据、入参 Schema、SKILL.md 摘要等。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header；不传时使用当前调用方的默认租户。</description></item>
        /// <item><description><b>SkillCode</b>：与 SkillName 二选一；同时传入时 SkillCode 优先。</description></item>
        /// <item><description><b>SkillName</b>：与 SkillCode 二选一；租户内不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>ViewMode</b>：可选，<c>draft</c>（草稿/编辑视角）或 <c>published</c>（已发布视角，默认）。</description></item>
        /// <item><description><b>IncludeSkillFiles</b>：可选，是否返回完整技能文件树（SKILL.md / scripts / templates），默认 <c>false</c>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillWithOptionsAsync(GetSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeSkillFiles))
            {
                body["includeSkillFiles"] = request.IncludeSkillFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillCode))
            {
                body["skillCode"] = request.SkillCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewMode))
            {
                body["viewMode"] = request.ViewMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSkill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>根据 SkillCode 或 SkillName 查询技能详情，包括元数据、入参 Schema、SKILL.md 摘要等。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header；不传时使用当前调用方的默认租户。</description></item>
        /// <item><description><b>SkillCode</b>：与 SkillName 二选一；同时传入时 SkillCode 优先。</description></item>
        /// <item><description><b>SkillName</b>：与 SkillCode 二选一；租户内不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>ViewMode</b>：可选，<c>draft</c>（草稿/编辑视角）或 <c>published</c>（已发布视角，默认）。</description></item>
        /// <item><description><b>IncludeSkillFiles</b>：可选，是否返回完整技能文件树（SKILL.md / scripts / templates），默认 <c>false</c>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkill(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSkillWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>根据 SkillCode 或 SkillName 查询技能详情，包括元数据、入参 Schema、SKILL.md 摘要等。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header；不传时使用当前调用方的默认租户。</description></item>
        /// <item><description><b>SkillCode</b>：与 SkillName 二选一；同时传入时 SkillCode 优先。</description></item>
        /// <item><description><b>SkillName</b>：与 SkillCode 二选一；租户内不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>ViewMode</b>：可选，<c>draft</c>（草稿/编辑视角）或 <c>published</c>（已发布视角，默认）。</description></item>
        /// <item><description><b>IncludeSkillFiles</b>：可选，是否返回完整技能文件树（SKILL.md / scripts / templates），默认 <c>false</c>。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillAsync(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSkillWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询技能执行结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过 <c>RunId</c> 查询异步任务的当前状态与结果。</para>
        /// <list type="bullet">
        /// <item><description><b>状态机</b>：Running（PENDING/RUNNING）→ Succeeded / Failed / Cancelled</description></item>
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传；后端会校验 RunId 必须属于当前租户，否则统一返回 <c>ERR.SkillHub.RunNotFound</c>（避免泄漏存在性）。</description></item>
        /// <item><description><b>IncludeLogs</b>：可选，是否返回执行日志，默认 <c>false</c>。
        /// 执行成功时 <c>Result.Content[]</c> 为 MCP 风格 Content 块数组（Text / File / Image）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillRunResponse
        /// </returns>
        public GetSkillRunResponse GetSkillRunWithOptions(GetSkillRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeLogs))
            {
                body["includeLogs"] = request.IncludeLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillRun",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSkillRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询技能执行结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过 <c>RunId</c> 查询异步任务的当前状态与结果。</para>
        /// <list type="bullet">
        /// <item><description><b>状态机</b>：Running（PENDING/RUNNING）→ Succeeded / Failed / Cancelled</description></item>
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传；后端会校验 RunId 必须属于当前租户，否则统一返回 <c>ERR.SkillHub.RunNotFound</c>（避免泄漏存在性）。</description></item>
        /// <item><description><b>IncludeLogs</b>：可选，是否返回执行日志，默认 <c>false</c>。
        /// 执行成功时 <c>Result.Content[]</c> 为 MCP 风格 Content 块数组（Text / File / Image）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillRunResponse
        /// </returns>
        public async Task<GetSkillRunResponse> GetSkillRunWithOptionsAsync(GetSkillRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeLogs))
            {
                body["includeLogs"] = request.IncludeLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillRun",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSkillRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询技能执行结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过 <c>RunId</c> 查询异步任务的当前状态与结果。</para>
        /// <list type="bullet">
        /// <item><description><b>状态机</b>：Running（PENDING/RUNNING）→ Succeeded / Failed / Cancelled</description></item>
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传；后端会校验 RunId 必须属于当前租户，否则统一返回 <c>ERR.SkillHub.RunNotFound</c>（避免泄漏存在性）。</description></item>
        /// <item><description><b>IncludeLogs</b>：可选，是否返回执行日志，默认 <c>false</c>。
        /// 执行成功时 <c>Result.Content[]</c> 为 MCP 风格 Content 块数组（Text / File / Image）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillRunResponse
        /// </returns>
        public GetSkillRunResponse GetSkillRun(GetSkillRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSkillRunWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询技能执行结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过 <c>RunId</c> 查询异步任务的当前状态与结果。</para>
        /// <list type="bullet">
        /// <item><description><b>状态机</b>：Running（PENDING/RUNNING）→ Succeeded / Failed / Cancelled</description></item>
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传；后端会校验 RunId 必须属于当前租户，否则统一返回 <c>ERR.SkillHub.RunNotFound</c>（避免泄漏存在性）。</description></item>
        /// <item><description><b>IncludeLogs</b>：可选，是否返回执行日志，默认 <c>false</c>。
        /// 执行成功时 <c>Result.Content[]</c> 为 MCP 风格 Content 块数组（Text / File / Image）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillRunResponse
        /// </returns>
        public async Task<GetSkillRunResponse> GetSkillRunAsync(GetSkillRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSkillRunWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定资源（知识）的详细信息，支持按需返回大体积明细字段。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenant_id</c> 仅来自鉴权身份；调用方在 body 中传入会被忽略。</description></item>
        /// <item><description>出参不暴露 <c>creator</c> / <c>modifier</c> 等审计字段；<c>unstructured_docs[ ].content</c> 默认不返回，以避免大体积响应。</description></item>
        /// <item><description>通过设置 <c>includeDetails</c> 参数为 <c>True</c> 可以获取包括 <c>settings</c>, <c>notes</c>, <c>structuredTables</c>, 和 <c>unstructuredDocs</c> 在内的更多细节信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSourceResponse
        /// </returns>
        public GetSourceResponse GetSourceWithOptions(GetSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDetails))
            {
                body["includeDetails"] = request.IncludeDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定资源（知识）的详细信息，支持按需返回大体积明细字段。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenant_id</c> 仅来自鉴权身份；调用方在 body 中传入会被忽略。</description></item>
        /// <item><description>出参不暴露 <c>creator</c> / <c>modifier</c> 等审计字段；<c>unstructured_docs[ ].content</c> 默认不返回，以避免大体积响应。</description></item>
        /// <item><description>通过设置 <c>includeDetails</c> 参数为 <c>True</c> 可以获取包括 <c>settings</c>, <c>notes</c>, <c>structuredTables</c>, 和 <c>unstructuredDocs</c> 在内的更多细节信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSourceResponse
        /// </returns>
        public async Task<GetSourceResponse> GetSourceWithOptionsAsync(GetSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDetails))
            {
                body["includeDetails"] = request.IncludeDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定资源（知识）的详细信息，支持按需返回大体积明细字段。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenant_id</c> 仅来自鉴权身份；调用方在 body 中传入会被忽略。</description></item>
        /// <item><description>出参不暴露 <c>creator</c> / <c>modifier</c> 等审计字段；<c>unstructured_docs[ ].content</c> 默认不返回，以避免大体积响应。</description></item>
        /// <item><description>通过设置 <c>includeDetails</c> 参数为 <c>True</c> 可以获取包括 <c>settings</c>, <c>notes</c>, <c>structuredTables</c>, 和 <c>unstructuredDocs</c> 在内的更多细节信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSourceResponse
        /// </returns>
        public GetSourceResponse GetSource(GetSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定资源（知识）的详细信息，支持按需返回大体积明细字段。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><c>tenant_id</c> 仅来自鉴权身份；调用方在 body 中传入会被忽略。</description></item>
        /// <item><description>出参不暴露 <c>creator</c> / <c>modifier</c> 等审计字段；<c>unstructured_docs[ ].content</c> 默认不返回，以避免大体积响应。</description></item>
        /// <item><description>通过设置 <c>includeDetails</c> 参数为 <c>True</c> 可以获取包括 <c>settings</c>, <c>notes</c>, <c>structuredTables</c>, 和 <c>unstructuredDocs</c> 在内的更多细节信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSourceResponse
        /// </returns>
        public async Task<GetSourceResponse> GetSourceAsync(GetSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成用于直接上传文件到OSS的签名URL。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许调用方根据提供的文件名等信息，获取一个可用于直接上传文件至阿里云OSS（对象存储服务）的签名URL。通过此URL，用户可以将文件直接上传至指定的OSS位置而无需经过中间服务器转发，从而提高效率和安全性。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c>/<c>user_id</c>仅来自鉴权身份，即使在请求体中提供也会被忽略。</description></item>
        /// <item><description><b>默认值</b>：如果未指定<c>expires</c>参数，则默认过期时间为3600秒（即1小时）。</description></item>
        /// <item><description><b>Content-Type</b>：如果不提供<c>contentType</c>，系统会尝试自动推断文件类型。</description></item>
        /// <item><description><b>归属范围</b>：通过<c>scope</c>参数定义数据源是属于个人还是企业知识库，默认情况下可能不需要设置。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceUploadSignatureRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSourceUploadSignatureResponse
        /// </returns>
        public GetSourceUploadSignatureResponse GetSourceUploadSignatureWithOptions(GetSourceUploadSignatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expires))
            {
                body["expires"] = request.Expires;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                body["filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSourceUploadSignature",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSourceUploadSignature",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSourceUploadSignatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成用于直接上传文件到OSS的签名URL。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许调用方根据提供的文件名等信息，获取一个可用于直接上传文件至阿里云OSS（对象存储服务）的签名URL。通过此URL，用户可以将文件直接上传至指定的OSS位置而无需经过中间服务器转发，从而提高效率和安全性。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c>/<c>user_id</c>仅来自鉴权身份，即使在请求体中提供也会被忽略。</description></item>
        /// <item><description><b>默认值</b>：如果未指定<c>expires</c>参数，则默认过期时间为3600秒（即1小时）。</description></item>
        /// <item><description><b>Content-Type</b>：如果不提供<c>contentType</c>，系统会尝试自动推断文件类型。</description></item>
        /// <item><description><b>归属范围</b>：通过<c>scope</c>参数定义数据源是属于个人还是企业知识库，默认情况下可能不需要设置。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceUploadSignatureRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSourceUploadSignatureResponse
        /// </returns>
        public async Task<GetSourceUploadSignatureResponse> GetSourceUploadSignatureWithOptionsAsync(GetSourceUploadSignatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expires))
            {
                body["expires"] = request.Expires;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                body["filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSourceUploadSignature",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getSourceUploadSignature",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSourceUploadSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成用于直接上传文件到OSS的签名URL。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许调用方根据提供的文件名等信息，获取一个可用于直接上传文件至阿里云OSS（对象存储服务）的签名URL。通过此URL，用户可以将文件直接上传至指定的OSS位置而无需经过中间服务器转发，从而提高效率和安全性。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c>/<c>user_id</c>仅来自鉴权身份，即使在请求体中提供也会被忽略。</description></item>
        /// <item><description><b>默认值</b>：如果未指定<c>expires</c>参数，则默认过期时间为3600秒（即1小时）。</description></item>
        /// <item><description><b>Content-Type</b>：如果不提供<c>contentType</c>，系统会尝试自动推断文件类型。</description></item>
        /// <item><description><b>归属范围</b>：通过<c>scope</c>参数定义数据源是属于个人还是企业知识库，默认情况下可能不需要设置。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceUploadSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSourceUploadSignatureResponse
        /// </returns>
        public GetSourceUploadSignatureResponse GetSourceUploadSignature(GetSourceUploadSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSourceUploadSignatureWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成用于直接上传文件到OSS的签名URL。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许调用方根据提供的文件名等信息，获取一个可用于直接上传文件至阿里云OSS（对象存储服务）的签名URL。通过此URL，用户可以将文件直接上传至指定的OSS位置而无需经过中间服务器转发，从而提高效率和安全性。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c>/<c>user_id</c>仅来自鉴权身份，即使在请求体中提供也会被忽略。</description></item>
        /// <item><description><b>默认值</b>：如果未指定<c>expires</c>参数，则默认过期时间为3600秒（即1小时）。</description></item>
        /// <item><description><b>Content-Type</b>：如果不提供<c>contentType</c>，系统会尝试自动推断文件类型。</description></item>
        /// <item><description><b>归属范围</b>：通过<c>scope</c>参数定义数据源是属于个人还是企业知识库，默认情况下可能不需要设置。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSourceUploadSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSourceUploadSignatureResponse
        /// </returns>
        public async Task<GetSourceUploadSignatureResponse> GetSourceUploadSignatureAsync(GetSourceUploadSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSourceUploadSignatureWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的 Token 状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询用户的 INSTANCE Token 状态。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 查询 ACTIVE INSTANCE Token
        ///     4. 存在 → 返回 enabled=True + 脱敏值 + 创建时间
        ///     5. 不存在 → 返回 enabled=False</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenInfoResponse
        /// </returns>
        public GetTokenInfoResponse GetTokenInfoWithOptions(GetTokenInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenInfo",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getTokenInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的 Token 状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询用户的 INSTANCE Token 状态。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 查询 ACTIVE INSTANCE Token
        ///     4. 存在 → 返回 enabled=True + 脱敏值 + 创建时间
        ///     5. 不存在 → 返回 enabled=False</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenInfoResponse
        /// </returns>
        public async Task<GetTokenInfoResponse> GetTokenInfoWithOptionsAsync(GetTokenInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTokenInfo",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getTokenInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的 Token 状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询用户的 INSTANCE Token 状态。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 查询 ACTIVE INSTANCE Token
        ///     4. 存在 → 返回 enabled=True + 脱敏值 + 创建时间
        ///     5. 不存在 → 返回 enabled=False</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenInfoResponse
        /// </returns>
        public GetTokenInfoResponse GetTokenInfo(GetTokenInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的 Token 状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询用户的 INSTANCE Token 状态。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 查询 ACTIVE INSTANCE Token
        ///     4. 存在 → 返回 enabled=True + 脱敏值 + 创建时间
        ///     5. 不存在 → 返回 enabled=False</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenInfoResponse
        /// </returns>
        public async Task<GetTokenInfoResponse> GetTokenInfoAsync(GetTokenInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 查询用户详情。
        ///     业务编排：
        ///     1. 按 wnUserId 或 accountId 定位用户
        ///     2. 查询用户在当前租户的映射信息（状态、加入时间、最后登录）
        ///     3. 查询用户在当前租户的角色列表
        ///     4. 查询用户在当前租户的用户组列表
        ///     5. 组装响应
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUserWithOptions(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnAccountId))
            {
                query["wnAccountId"] = request.WnAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                query["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 查询用户详情。
        ///     业务编排：
        ///     1. 按 wnUserId 或 accountId 定位用户
        ///     2. 查询用户在当前租户的映射信息（状态、加入时间、最后登录）
        ///     3. 查询用户在当前租户的角色列表
        ///     4. 查询用户在当前租户的用户组列表
        ///     5. 组装响应
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnAccountId))
            {
                query["wnAccountId"] = request.WnAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                query["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 查询用户详情。
        ///     业务编排：
        ///     1. 按 wnUserId 或 accountId 定位用户
        ///     2. 查询用户在当前租户的映射信息（状态、加入时间、最后登录）
        ///     3. 查询用户在当前租户的角色列表
        ///     4. 查询用户在当前租户的用户组列表
        ///     5. 组装响应
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 查询用户详情。
        ///     业务编排：
        ///     1. 按 wnUserId 或 accountId 定位用户
        ///     2. 查询用户在当前租户的映射信息（状态、加入时间、最后登录）
        ///     3. 查询用户在当前租户的角色列表
        ///     4. 查询用户在当前租户的用户组列表
        ///     5. 组装响应
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户的实时信用消耗、限额及剩余情况。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取当前登录用户的信用使用详情，包括信用限额、已消耗的信用额度以及剩余信用额度。</description></item>
        /// <item><description>数据来源于Redis实时缓存，确保了信息的即时性。</description></item>
        /// <item><description>支持通过租户ID来指定查询特定租户下的用户信用使用情况，默认情况下将使用调用方的默认租户。</description></item>
        /// <item><description>请求时可选择提供<c>RequestId</c>作为请求标识符，但这不是必需的。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserCreditUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreditUsageResponse
        /// </returns>
        public GetUserCreditUsageResponse GetUserCreditUsageWithOptions(GetUserCreditUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserCreditUsage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getUserCreditUsage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCreditUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户的实时信用消耗、限额及剩余情况。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取当前登录用户的信用使用详情，包括信用限额、已消耗的信用额度以及剩余信用额度。</description></item>
        /// <item><description>数据来源于Redis实时缓存，确保了信息的即时性。</description></item>
        /// <item><description>支持通过租户ID来指定查询特定租户下的用户信用使用情况，默认情况下将使用调用方的默认租户。</description></item>
        /// <item><description>请求时可选择提供<c>RequestId</c>作为请求标识符，但这不是必需的。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserCreditUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreditUsageResponse
        /// </returns>
        public async Task<GetUserCreditUsageResponse> GetUserCreditUsageWithOptionsAsync(GetUserCreditUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserCreditUsage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getUserCreditUsage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCreditUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户的实时信用消耗、限额及剩余情况。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取当前登录用户的信用使用详情，包括信用限额、已消耗的信用额度以及剩余信用额度。</description></item>
        /// <item><description>数据来源于Redis实时缓存，确保了信息的即时性。</description></item>
        /// <item><description>支持通过租户ID来指定查询特定租户下的用户信用使用情况，默认情况下将使用调用方的默认租户。</description></item>
        /// <item><description>请求时可选择提供<c>RequestId</c>作为请求标识符，但这不是必需的。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserCreditUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreditUsageResponse
        /// </returns>
        public GetUserCreditUsageResponse GetUserCreditUsage(GetUserCreditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserCreditUsageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前登录用户的实时信用消耗、限额及剩余情况。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取当前登录用户的信用使用详情，包括信用限额、已消耗的信用额度以及剩余信用额度。</description></item>
        /// <item><description>数据来源于Redis实时缓存，确保了信息的即时性。</description></item>
        /// <item><description>支持通过租户ID来指定查询特定租户下的用户信用使用情况，默认情况下将使用调用方的默认租户。</description></item>
        /// <item><description>请求时可选择提供<c>RequestId</c>作为请求标识符，但这不是必需的。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserCreditUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserCreditUsageResponse
        /// </returns>
        public async Task<GetUserCreditUsageResponse> GetUserCreditUsageAsync(GetUserCreditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserCreditUsageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI获取鉴权用户的完整信息，包括基本信息、租户列表等。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于返回当前鉴权用户的详细信息。</description></item>
        /// <item><description>当租户信息失效时，将返回对应的错误信息。</description></item>
        /// <item><description><c>tenantId</c>为可选参数，若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种认证方式：AK、BearerToken和APP认证。</description></item>
        /// <item><description>返回的数据中包含了用户的个人资料（如用户名、头像链接）、角色偏好设置以及所属的所有租户详情。</description></item>
        /// <item><description>特别注意，如果当前登录的租户是系统租户（即<c>tenantId=10000</c>），则会在响应中明确标识出来。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public GetUserInfoResponse GetUserInfoWithOptions(GetUserInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI获取鉴权用户的完整信息，包括基本信息、租户列表等。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于返回当前鉴权用户的详细信息。</description></item>
        /// <item><description>当租户信息失效时，将返回对应的错误信息。</description></item>
        /// <item><description><c>tenantId</c>为可选参数，若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种认证方式：AK、BearerToken和APP认证。</description></item>
        /// <item><description>返回的数据中包含了用户的个人资料（如用户名、头像链接）、角色偏好设置以及所属的所有租户详情。</description></item>
        /// <item><description>特别注意，如果当前登录的租户是系统租户（即<c>tenantId=10000</c>），则会在响应中明确标识出来。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(GetUserInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/getUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI获取鉴权用户的完整信息，包括基本信息、租户列表等。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于返回当前鉴权用户的详细信息。</description></item>
        /// <item><description>当租户信息失效时，将返回对应的错误信息。</description></item>
        /// <item><description><c>tenantId</c>为可选参数，若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种认证方式：AK、BearerToken和APP认证。</description></item>
        /// <item><description>返回的数据中包含了用户的个人资料（如用户名、头像链接）、角色偏好设置以及所属的所有租户详情。</description></item>
        /// <item><description>特别注意，如果当前登录的租户是系统租户（即<c>tenantId=10000</c>），则会在响应中明确标识出来。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public GetUserInfoResponse GetUserInfo(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI获取鉴权用户的完整信息，包括基本信息、租户列表等。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于返回当前鉴权用户的详细信息。</description></item>
        /// <item><description>当租户信息失效时，将返回对应的错误信息。</description></item>
        /// <item><description><c>tenantId</c>为可选参数，若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种认证方式：AK、BearerToken和APP认证。</description></item>
        /// <item><description>返回的数据中包含了用户的个人资料（如用户名、头像链接）、角色偏好设置以及所属的所有租户详情。</description></item>
        /// <item><description>特别注意，如果当前登录的租户是系统租户（即<c>tenantId=10000</c>），则会在响应中明确标识出来。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public async Task<GetUserInfoResponse> GetUserInfoAsync(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户/用户组使用数字员工</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>授权用户或用户组使用指定数字员工。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.grant_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 已存在的授权记录会被更新（expire_date / permissions）</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GrantAgentUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantAgentUsersResponse
        /// </returns>
        public GrantAgentUsersResponse GrantAgentUsersWithOptions(GrantAgentUsersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantAgentUsersShrinkRequest request = new GrantAgentUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permissions))
            {
                request.PermissionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permissions, "permissions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupIds))
            {
                request.UserGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupIds, "userGroupIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "userIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDate))
            {
                body["expireDate"] = request.ExpireDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionsShrink))
            {
                body["permissions"] = request.PermissionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIdsShrink))
            {
                body["userGroupIds"] = request.UserGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdsShrink))
            {
                body["userIds"] = request.UserIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantAgentUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/grantAgentUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantAgentUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户/用户组使用数字员工</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>授权用户或用户组使用指定数字员工。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.grant_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 已存在的授权记录会被更新（expire_date / permissions）</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GrantAgentUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantAgentUsersResponse
        /// </returns>
        public async Task<GrantAgentUsersResponse> GrantAgentUsersWithOptionsAsync(GrantAgentUsersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantAgentUsersShrinkRequest request = new GrantAgentUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permissions))
            {
                request.PermissionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permissions, "permissions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupIds))
            {
                request.UserGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupIds, "userGroupIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "userIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireDate))
            {
                body["expireDate"] = request.ExpireDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionsShrink))
            {
                body["permissions"] = request.PermissionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIdsShrink))
            {
                body["userGroupIds"] = request.UserGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdsShrink))
            {
                body["userIds"] = request.UserIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantAgentUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/grantAgentUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantAgentUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户/用户组使用数字员工</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>授权用户或用户组使用指定数字员工。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.grant_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 已存在的授权记录会被更新（expire_date / permissions）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GrantAgentUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantAgentUsersResponse
        /// </returns>
        public GrantAgentUsersResponse GrantAgentUsers(GrantAgentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantAgentUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户/用户组使用数字员工</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>授权用户或用户组使用指定数字员工。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.grant_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 已存在的授权记录会被更新（expire_date / permissions）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GrantAgentUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantAgentUsersResponse
        /// </returns>
        public async Task<GrantAgentUsersResponse> GrantAgentUsersAsync(GrantAgentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantAgentUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询或下钻查看租户的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持两种模式：当 <c>directoryId</c> 为空或为 &#39;root&#39; 时，返回知识库的顶层列表；当 <c>directoryId</c> 有具体值时，则进行下钻操作，返回指定目录下的子目录和资源。</description></item>
        /// <item><description><c>tenantId</c> 作为公共参数，若未提供则默认使用调用方的租户 ID。</description></item>
        /// <item><description>在下钻模式下（即 <c>directoryId</c> 非空），可以通过 <c>sourceTypes</c> 参数来过滤特定类型的资源。</description></item>
        /// <item><description>排序字段 (<c>sortField</c>) 和排序方向 (<c>sortOrder</c>) 可以自定义，但非法值将被重置为默认设置。</description></item>
        /// <item><description>搜索功能仅在获取顶层列表时有效，并且只支持模糊匹配名称或描述。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 严格从鉴权身份中获取，不允许通过请求体传递。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListAdminKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAdminKnowledgeBasesResponse
        /// </returns>
        public ListAdminKnowledgeBasesResponse ListAdminKnowledgeBasesWithOptions(ListAdminKnowledgeBasesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAdminKnowledgeBasesShrinkRequest request = new ListAdminKnowledgeBasesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTypes))
            {
                request.SourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTypes, "sourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypesShrink))
            {
                body["sourceTypes"] = request.SourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdminKnowledgeBases",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAdminKnowledgeBases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdminKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询或下钻查看租户的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持两种模式：当 <c>directoryId</c> 为空或为 &#39;root&#39; 时，返回知识库的顶层列表；当 <c>directoryId</c> 有具体值时，则进行下钻操作，返回指定目录下的子目录和资源。</description></item>
        /// <item><description><c>tenantId</c> 作为公共参数，若未提供则默认使用调用方的租户 ID。</description></item>
        /// <item><description>在下钻模式下（即 <c>directoryId</c> 非空），可以通过 <c>sourceTypes</c> 参数来过滤特定类型的资源。</description></item>
        /// <item><description>排序字段 (<c>sortField</c>) 和排序方向 (<c>sortOrder</c>) 可以自定义，但非法值将被重置为默认设置。</description></item>
        /// <item><description>搜索功能仅在获取顶层列表时有效，并且只支持模糊匹配名称或描述。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 严格从鉴权身份中获取，不允许通过请求体传递。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListAdminKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAdminKnowledgeBasesResponse
        /// </returns>
        public async Task<ListAdminKnowledgeBasesResponse> ListAdminKnowledgeBasesWithOptionsAsync(ListAdminKnowledgeBasesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAdminKnowledgeBasesShrinkRequest request = new ListAdminKnowledgeBasesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTypes))
            {
                request.SourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTypes, "sourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypesShrink))
            {
                body["sourceTypes"] = request.SourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdminKnowledgeBases",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAdminKnowledgeBases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdminKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询或下钻查看租户的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持两种模式：当 <c>directoryId</c> 为空或为 &#39;root&#39; 时，返回知识库的顶层列表；当 <c>directoryId</c> 有具体值时，则进行下钻操作，返回指定目录下的子目录和资源。</description></item>
        /// <item><description><c>tenantId</c> 作为公共参数，若未提供则默认使用调用方的租户 ID。</description></item>
        /// <item><description>在下钻模式下（即 <c>directoryId</c> 非空），可以通过 <c>sourceTypes</c> 参数来过滤特定类型的资源。</description></item>
        /// <item><description>排序字段 (<c>sortField</c>) 和排序方向 (<c>sortOrder</c>) 可以自定义，但非法值将被重置为默认设置。</description></item>
        /// <item><description>搜索功能仅在获取顶层列表时有效，并且只支持模糊匹配名称或描述。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 严格从鉴权身份中获取，不允许通过请求体传递。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdminKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAdminKnowledgeBasesResponse
        /// </returns>
        public ListAdminKnowledgeBasesResponse ListAdminKnowledgeBases(ListAdminKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAdminKnowledgeBasesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于查询或下钻查看租户的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持两种模式：当 <c>directoryId</c> 为空或为 &#39;root&#39; 时，返回知识库的顶层列表；当 <c>directoryId</c> 有具体值时，则进行下钻操作，返回指定目录下的子目录和资源。</description></item>
        /// <item><description><c>tenantId</c> 作为公共参数，若未提供则默认使用调用方的租户 ID。</description></item>
        /// <item><description>在下钻模式下（即 <c>directoryId</c> 非空），可以通过 <c>sourceTypes</c> 参数来过滤特定类型的资源。</description></item>
        /// <item><description>排序字段 (<c>sortField</c>) 和排序方向 (<c>sortOrder</c>) 可以自定义，但非法值将被重置为默认设置。</description></item>
        /// <item><description>搜索功能仅在获取顶层列表时有效，并且只支持模糊匹配名称或描述。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 严格从鉴权身份中获取，不允许通过请求体传递。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdminKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAdminKnowledgeBasesResponse
        /// </returns>
        public async Task<ListAdminKnowledgeBasesResponse> ListAdminKnowledgeBasesAsync(ListAdminKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAdminKnowledgeBasesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户全量数字员工列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询租户下全部数字员工列表（含停用）。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_agents 完成权限校验（APPLICATION_AGENT_VIEW）
        ///     3. 返回租户全量数字员工的富字段（operatingObjectName / displayName / authMode / isActive）
        ///     4. 系统级 Token 通过 ctx.skip_permission 自动放行
        ///     与 listAuthorizedAgents 区别：本接口返回租户全量（含停用、不做授权过滤），
        ///     并携带 displayName / isActive 等富字段，供管理端展示。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgentsWithOptions(ListAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAgents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户全量数字员工列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询租户下全部数字员工列表（含停用）。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_agents 完成权限校验（APPLICATION_AGENT_VIEW）
        ///     3. 返回租户全量数字员工的富字段（operatingObjectName / displayName / authMode / isActive）
        ///     4. 系统级 Token 通过 ctx.skip_permission 自动放行
        ///     与 listAuthorizedAgents 区别：本接口返回租户全量（含停用、不做授权过滤），
        ///     并携带 displayName / isActive 等富字段，供管理端展示。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsWithOptionsAsync(ListAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAgents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户全量数字员工列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询租户下全部数字员工列表（含停用）。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_agents 完成权限校验（APPLICATION_AGENT_VIEW）
        ///     3. 返回租户全量数字员工的富字段（operatingObjectName / displayName / authMode / isActive）
        ///     4. 系统级 Token 通过 ctx.skip_permission 自动放行
        ///     与 listAuthorizedAgents 区别：本接口返回租户全量（含停用、不做授权过滤），
        ///     并携带 displayName / isActive 等富字段，供管理端展示。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户全量数字员工列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询租户下全部数字员工列表（含停用）。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_agents 完成权限校验（APPLICATION_AGENT_VIEW）
        ///     3. 返回租户全量数字员工的富字段（operatingObjectName / displayName / authMode / isActive）
        ///     4. 系统级 Token 通过 ctx.skip_permission 自动放行
        ///     与 listAuthorizedAgents 区别：本接口返回租户全量（含停用、不做授权过滤），
        ///     并携带 displayName / isActive 等富字段，供管理端展示。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调用方有指定权限的数字员工名称列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前调用方（或指定目标用户）拥有指定权限（USE/MANAGE）的数字员工名称列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_agents 执行查询
        ///     3. skip_permission=True 时返回租户全量活跃 agent
        ///     4. 普通用户根据授权记录 + auth_mode 过滤
        ///     5. 传入 targetUserId（代查他人）时需 APPLICATION_AGENT_VIEW 门控，查询限定本租户；
        ///        目标用户非本租户成员时抛 USER_NOT_IN_TENANT（不静默返回空列表）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAgentsResponse
        /// </returns>
        public ListAuthorizedAgentsResponse ListAuthorizedAgentsWithOptions(ListAuthorizedAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                body["targetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedAgents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAuthorizedAgents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调用方有指定权限的数字员工名称列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前调用方（或指定目标用户）拥有指定权限（USE/MANAGE）的数字员工名称列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_agents 执行查询
        ///     3. skip_permission=True 时返回租户全量活跃 agent
        ///     4. 普通用户根据授权记录 + auth_mode 过滤
        ///     5. 传入 targetUserId（代查他人）时需 APPLICATION_AGENT_VIEW 门控，查询限定本租户；
        ///        目标用户非本租户成员时抛 USER_NOT_IN_TENANT（不静默返回空列表）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAgentsResponse
        /// </returns>
        public async Task<ListAuthorizedAgentsResponse> ListAuthorizedAgentsWithOptionsAsync(ListAuthorizedAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                body["targetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedAgents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAuthorizedAgents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调用方有指定权限的数字员工名称列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前调用方（或指定目标用户）拥有指定权限（USE/MANAGE）的数字员工名称列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_agents 执行查询
        ///     3. skip_permission=True 时返回租户全量活跃 agent
        ///     4. 普通用户根据授权记录 + auth_mode 过滤
        ///     5. 传入 targetUserId（代查他人）时需 APPLICATION_AGENT_VIEW 门控，查询限定本租户；
        ///        目标用户非本租户成员时抛 USER_NOT_IN_TENANT（不静默返回空列表）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAgentsResponse
        /// </returns>
        public ListAuthorizedAgentsResponse ListAuthorizedAgents(ListAuthorizedAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAuthorizedAgentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调用方有指定权限的数字员工名称列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询当前调用方（或指定目标用户）拥有指定权限（USE/MANAGE）的数字员工名称列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_agents 执行查询
        ///     3. skip_permission=True 时返回租户全量活跃 agent
        ///     4. 普通用户根据授权记录 + auth_mode 过滤
        ///     5. 传入 targetUserId（代查他人）时需 APPLICATION_AGENT_VIEW 门控，查询限定本租户；
        ///        目标用户非本租户成员时抛 USER_NOT_IN_TENANT（不静默返回空列表）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedAgentsResponse
        /// </returns>
        public async Task<ListAuthorizedAgentsResponse> ListAuthorizedAgentsAsync(ListAuthorizedAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAuthorizedAgentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工已授权的用户/用户组列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询某数字员工已授权的用户/用户组列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_users 执行查询
        ///     3. 权限校验由 AuthorizedService 层 @require_permission(APPLICATION_AGENT_VIEW) 完成
        ///     4. auth_mode=ALL_USERS 时仅展示有 MANAGE 权限的记录</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public ListAuthorizedUsersResponse ListAuthorizedUsersWithOptions(ListAuthorizedUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GranteeType))
            {
                body["granteeType"] = request.GranteeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAuthorizedUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工已授权的用户/用户组列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询某数字员工已授权的用户/用户组列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_users 执行查询
        ///     3. 权限校验由 AuthorizedService 层 @require_permission(APPLICATION_AGENT_VIEW) 完成
        ///     4. auth_mode=ALL_USERS 时仅展示有 MANAGE 权限的记录</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public async Task<ListAuthorizedUsersResponse> ListAuthorizedUsersWithOptionsAsync(ListAuthorizedUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GranteeType))
            {
                body["granteeType"] = request.GranteeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                body["permission"] = request.Permission;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAuthorizedUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工已授权的用户/用户组列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询某数字员工已授权的用户/用户组列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_users 执行查询
        ///     3. 权限校验由 AuthorizedService 层 @require_permission(APPLICATION_AGENT_VIEW) 完成
        ///     4. auth_mode=ALL_USERS 时仅展示有 MANAGE 权限的记录</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public ListAuthorizedUsersResponse ListAuthorizedUsers(ListAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAuthorizedUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工已授权的用户/用户组列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询某数字员工已授权的用户/用户组列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.list_authorized_users 执行查询
        ///     3. 权限校验由 AuthorizedService 层 @require_permission(APPLICATION_AGENT_VIEW) 完成
        ///     4. auth_mode=ALL_USERS 时仅展示有 MANAGE 权限的记录</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAuthorizedUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedUsersResponse
        /// </returns>
        public async Task<ListAuthorizedUsersResponse> ListAuthorizedUsersAsync(ListAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAuthorizedUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>枚举可用的组织同步配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>枚举当前租户下所有可用的组织同步配置。
        ///     返回统一格式的 configs 列表，涵盖四种平台类型：
        ///     - <b>wecom</b>：从 SsoProviderRegistry 获取活跃的企微 SSO 配置
        ///     - <b>saml</b>：从 SsoProviderRegistry 获取活跃的 SAML SSO 配置，corpId 取 idpEntityId
        ///     - <b>oauth2</b>：从 SsoProviderRegistry 获取活跃的 OAuth2 SSO 配置，corpId 取 clientId
        ///     - <b>custom</b>：从数据库查询该租户已注册的纯自定义组织
        ///     客户端根据返回的 platformType 区分处理逻辑，corpId 为后续同步接口的必传参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAvailableConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableConfigsResponse
        /// </returns>
        public ListAvailableConfigsResponse ListAvailableConfigsWithOptions(ListAvailableConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableConfigs",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAvailableConfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>枚举可用的组织同步配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>枚举当前租户下所有可用的组织同步配置。
        ///     返回统一格式的 configs 列表，涵盖四种平台类型：
        ///     - <b>wecom</b>：从 SsoProviderRegistry 获取活跃的企微 SSO 配置
        ///     - <b>saml</b>：从 SsoProviderRegistry 获取活跃的 SAML SSO 配置，corpId 取 idpEntityId
        ///     - <b>oauth2</b>：从 SsoProviderRegistry 获取活跃的 OAuth2 SSO 配置，corpId 取 clientId
        ///     - <b>custom</b>：从数据库查询该租户已注册的纯自定义组织
        ///     客户端根据返回的 platformType 区分处理逻辑，corpId 为后续同步接口的必传参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAvailableConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableConfigsResponse
        /// </returns>
        public async Task<ListAvailableConfigsResponse> ListAvailableConfigsWithOptionsAsync(ListAvailableConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableConfigs",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listAvailableConfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>枚举可用的组织同步配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>枚举当前租户下所有可用的组织同步配置。
        ///     返回统一格式的 configs 列表，涵盖四种平台类型：
        ///     - <b>wecom</b>：从 SsoProviderRegistry 获取活跃的企微 SSO 配置
        ///     - <b>saml</b>：从 SsoProviderRegistry 获取活跃的 SAML SSO 配置，corpId 取 idpEntityId
        ///     - <b>oauth2</b>：从 SsoProviderRegistry 获取活跃的 OAuth2 SSO 配置，corpId 取 clientId
        ///     - <b>custom</b>：从数据库查询该租户已注册的纯自定义组织
        ///     客户端根据返回的 platformType 区分处理逻辑，corpId 为后续同步接口的必传参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAvailableConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableConfigsResponse
        /// </returns>
        public ListAvailableConfigsResponse ListAvailableConfigs(ListAvailableConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAvailableConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>枚举可用的组织同步配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>枚举当前租户下所有可用的组织同步配置。
        ///     返回统一格式的 configs 列表，涵盖四种平台类型：
        ///     - <b>wecom</b>：从 SsoProviderRegistry 获取活跃的企微 SSO 配置
        ///     - <b>saml</b>：从 SsoProviderRegistry 获取活跃的 SAML SSO 配置，corpId 取 idpEntityId
        ///     - <b>oauth2</b>：从 SsoProviderRegistry 获取活跃的 OAuth2 SSO 配置，corpId 取 clientId
        ///     - <b>custom</b>：从数据库查询该租户已注册的纯自定义组织
        ///     客户端根据返回的 platformType 区分处理逻辑，corpId 为后续同步接口的必传参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAvailableConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableConfigsResponse
        /// </returns>
        public async Task<ListAvailableConfigsResponse> ListAvailableConfigsAsync(ListAvailableConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAvailableConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI查询并筛选账单列表，支持多种条件过滤。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询指定条件下的账单列表。</description></item>
        /// <item><description>支持按租户、用户、操作类型、状态、时间范围、业务来源等条件进行筛选。</description></item>
        /// <item><description>分页返回账单数据，默认每页显示20条记录。</description></item>
        /// <item><description>可选择是否过滤掉credit消耗为0的账单，默认过滤。</description></item>
        /// <item><description>请求时需提供必要的认证信息（如AK、BearerToken或APP认证）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBillingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBillingResponse
        /// </returns>
        public ListBillingResponse ListBillingWithOptions(ListBillingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreZero))
            {
                body["ignoreZero"] = request.IgnoreZero;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBilling",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listBilling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBillingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI查询并筛选账单列表，支持多种条件过滤。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询指定条件下的账单列表。</description></item>
        /// <item><description>支持按租户、用户、操作类型、状态、时间范围、业务来源等条件进行筛选。</description></item>
        /// <item><description>分页返回账单数据，默认每页显示20条记录。</description></item>
        /// <item><description>可选择是否过滤掉credit消耗为0的账单，默认过滤。</description></item>
        /// <item><description>请求时需提供必要的认证信息（如AK、BearerToken或APP认证）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBillingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBillingResponse
        /// </returns>
        public async Task<ListBillingResponse> ListBillingWithOptionsAsync(ListBillingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreZero))
            {
                body["ignoreZero"] = request.IgnoreZero;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBilling",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listBilling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBillingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI查询并筛选账单列表，支持多种条件过滤。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询指定条件下的账单列表。</description></item>
        /// <item><description>支持按租户、用户、操作类型、状态、时间范围、业务来源等条件进行筛选。</description></item>
        /// <item><description>分页返回账单数据，默认每页显示20条记录。</description></item>
        /// <item><description>可选择是否过滤掉credit消耗为0的账单，默认过滤。</description></item>
        /// <item><description>请求时需提供必要的认证信息（如AK、BearerToken或APP认证）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBillingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBillingResponse
        /// </returns>
        public ListBillingResponse ListBilling(ListBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBillingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过OpenAPI查询并筛选账单列表，支持多种条件过滤。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询指定条件下的账单列表。</description></item>
        /// <item><description>支持按租户、用户、操作类型、状态、时间范围、业务来源等条件进行筛选。</description></item>
        /// <item><description>分页返回账单数据，默认每页显示20条记录。</description></item>
        /// <item><description>可选择是否过滤掉credit消耗为0的账单，默认过滤。</description></item>
        /// <item><description>请求时需提供必要的认证信息（如AK、BearerToken或APP认证）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBillingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBillingResponse
        /// </returns>
        public async Task<ListBillingResponse> ListBillingAsync(ListBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBillingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按创建时间倒序列出当前用户的聊天会话。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持通过多种参数进行过滤和排序，包括租户 ID、分页大小、分页令牌、关键词搜索、数字员工名称以及更新时间区间。</description></item>
        /// <item><description>默认情况下，结果将按照 <c>UpdatedAt</c> 字段降序排列。</description></item>
        /// <item><description>如果提供了无效的 <c>NextToken</c> 或者 <c>PageSize</c> 超出了允许范围（1-100），API 将返回 400 错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public ListChatSessionsResponse ListChatSessionsWithOptions(ListChatSessionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeName))
            {
                query["digitalEmployeeName"] = request.DigitalEmployeeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatSessions",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listChatSessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按创建时间倒序列出当前用户的聊天会话。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持通过多种参数进行过滤和排序，包括租户 ID、分页大小、分页令牌、关键词搜索、数字员工名称以及更新时间区间。</description></item>
        /// <item><description>默认情况下，结果将按照 <c>UpdatedAt</c> 字段降序排列。</description></item>
        /// <item><description>如果提供了无效的 <c>NextToken</c> 或者 <c>PageSize</c> 超出了允许范围（1-100），API 将返回 400 错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public async Task<ListChatSessionsResponse> ListChatSessionsWithOptionsAsync(ListChatSessionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeName))
            {
                query["digitalEmployeeName"] = request.DigitalEmployeeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatSessions",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listChatSessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按创建时间倒序列出当前用户的聊天会话。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持通过多种参数进行过滤和排序，包括租户 ID、分页大小、分页令牌、关键词搜索、数字员工名称以及更新时间区间。</description></item>
        /// <item><description>默认情况下，结果将按照 <c>UpdatedAt</c> 字段降序排列。</description></item>
        /// <item><description>如果提供了无效的 <c>NextToken</c> 或者 <c>PageSize</c> 超出了允许范围（1-100），API 将返回 400 错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public ListChatSessionsResponse ListChatSessions(ListChatSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChatSessionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按创建时间倒序列出当前用户的聊天会话。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 支持通过多种参数进行过滤和排序，包括租户 ID、分页大小、分页令牌、关键词搜索、数字员工名称以及更新时间区间。</description></item>
        /// <item><description>默认情况下，结果将按照 <c>UpdatedAt</c> 字段降序排列。</description></item>
        /// <item><description>如果提供了无效的 <c>NextToken</c> 或者 <c>PageSize</c> 超出了允许范围（1-100），API 将返回 400 错误。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public async Task<ListChatSessionsResponse> ListChatSessionsAsync(ListChatSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChatSessionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户可用于语义查询的图谱列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列出身份租户下的已发布图谱。
        ///     CLI 映射为 <c>winnexo graph list</c>；<c>tenantId</c> 是必传公共参数，不进入请求体。
        ///     返回的 <c>graphName</c> 可直接用于 <c>querySemanticKnowledge</c>。该查询与现有前台
        ///     图谱列表保持一致，不做数字员工权限过滤；具体语义查询仍会校验 agent USE 权限。
        ///     数据库异常直接进入统一 5xx 错误处理，不会伪装为成功空列表。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGraphsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGraphsResponse
        /// </returns>
        public ListGraphsResponse ListGraphsWithOptions(ListGraphsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGraphs",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listGraphs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGraphsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户可用于语义查询的图谱列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列出身份租户下的已发布图谱。
        ///     CLI 映射为 <c>winnexo graph list</c>；<c>tenantId</c> 是必传公共参数，不进入请求体。
        ///     返回的 <c>graphName</c> 可直接用于 <c>querySemanticKnowledge</c>。该查询与现有前台
        ///     图谱列表保持一致，不做数字员工权限过滤；具体语义查询仍会校验 agent USE 权限。
        ///     数据库异常直接进入统一 5xx 错误处理，不会伪装为成功空列表。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGraphsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGraphsResponse
        /// </returns>
        public async Task<ListGraphsResponse> ListGraphsWithOptionsAsync(ListGraphsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGraphs",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listGraphs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGraphsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户可用于语义查询的图谱列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列出身份租户下的已发布图谱。
        ///     CLI 映射为 <c>winnexo graph list</c>；<c>tenantId</c> 是必传公共参数，不进入请求体。
        ///     返回的 <c>graphName</c> 可直接用于 <c>querySemanticKnowledge</c>。该查询与现有前台
        ///     图谱列表保持一致，不做数字员工权限过滤；具体语义查询仍会校验 agent USE 权限。
        ///     数据库异常直接进入统一 5xx 错误处理，不会伪装为成功空列表。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGraphsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGraphsResponse
        /// </returns>
        public ListGraphsResponse ListGraphs(ListGraphsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGraphsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询租户可用于语义查询的图谱列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列出身份租户下的已发布图谱。
        ///     CLI 映射为 <c>winnexo graph list</c>；<c>tenantId</c> 是必传公共参数，不进入请求体。
        ///     返回的 <c>graphName</c> 可直接用于 <c>querySemanticKnowledge</c>。该查询与现有前台
        ///     图谱列表保持一致，不做数字员工权限过滤；具体语义查询仍会校验 agent USE 权限。
        ///     数据库异常直接进入统一 5xx 错误处理，不会伪装为成功空列表。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGraphsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGraphsResponse
        /// </returns>
        public async Task<ListGraphsResponse> ListGraphsAsync(ListGraphsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGraphsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业知识库的分类目录树，支持按指定字段排序。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库的分类列表（子目录树），需要具备知识库查看权限。</description></item>
        /// <item><description>如果未提供 <c>directoryId</c> 参数，则返回企业知识库根目录下的所有分类树；如果提供了 <c>directoryId</c>，则以该目录为根返回其子目录树。</description></item>
        /// <item><description>支持通过 <c>sortField</c> 和 <c>sortOrder</c> 参数对结果进行排序，默认按照创建时间降序排列。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，并且调用者必须拥有 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseDirectoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseDirectoriesResponse
        /// </returns>
        public ListKnowledgeBaseDirectoriesResponse ListKnowledgeBaseDirectoriesWithOptions(ListKnowledgeBaseDirectoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBaseDirectories",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listKnowledgeBaseDirectories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBaseDirectoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业知识库的分类目录树，支持按指定字段排序。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库的分类列表（子目录树），需要具备知识库查看权限。</description></item>
        /// <item><description>如果未提供 <c>directoryId</c> 参数，则返回企业知识库根目录下的所有分类树；如果提供了 <c>directoryId</c>，则以该目录为根返回其子目录树。</description></item>
        /// <item><description>支持通过 <c>sortField</c> 和 <c>sortOrder</c> 参数对结果进行排序，默认按照创建时间降序排列。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，并且调用者必须拥有 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseDirectoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseDirectoriesResponse
        /// </returns>
        public async Task<ListKnowledgeBaseDirectoriesResponse> ListKnowledgeBaseDirectoriesWithOptionsAsync(ListKnowledgeBaseDirectoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBaseDirectories",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listKnowledgeBaseDirectories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBaseDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业知识库的分类目录树，支持按指定字段排序。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库的分类列表（子目录树），需要具备知识库查看权限。</description></item>
        /// <item><description>如果未提供 <c>directoryId</c> 参数，则返回企业知识库根目录下的所有分类树；如果提供了 <c>directoryId</c>，则以该目录为根返回其子目录树。</description></item>
        /// <item><description>支持通过 <c>sortField</c> 和 <c>sortOrder</c> 参数对结果进行排序，默认按照创建时间降序排列。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，并且调用者必须拥有 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseDirectoriesResponse
        /// </returns>
        public ListKnowledgeBaseDirectoriesResponse ListKnowledgeBaseDirectories(ListKnowledgeBaseDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKnowledgeBaseDirectoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业知识库的分类目录树，支持按指定字段排序。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于获取企业知识库的分类列表（子目录树），需要具备知识库查看权限。</description></item>
        /// <item><description>如果未提供 <c>directoryId</c> 参数，则返回企业知识库根目录下的所有分类树；如果提供了 <c>directoryId</c>，则以该目录为根返回其子目录树。</description></item>
        /// <item><description>支持通过 <c>sortField</c> 和 <c>sortOrder</c> 参数对结果进行排序，默认按照创建时间降序排列。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份，并且调用者必须拥有 <c>DEVELOPMENT_KB_VIEW</c> 功能权限。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseDirectoriesResponse
        /// </returns>
        public async Task<ListKnowledgeBaseDirectoriesResponse> ListKnowledgeBaseDirectoriesAsync(ListKnowledgeBaseDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKnowledgeBaseDirectoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前用户的产出列表，支持按条件过滤和分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询当前登录用户的产出列表。</description></item>
        /// <item><description><c>tenantId</c>作为公共参数，缺省时使用调用方默认租户。</description></item>
        /// <item><description>支持通过<c>operatingObjectName</c>、<c>itemType</c>、<c>keyword</c>等参数进行过滤查询。</description></item>
        /// <item><description>可以设置<c>sharedOnly</c>为<c>true</c>来仅展示开启分享的产出。</description></item>
        /// <item><description>分页信息通过<c>page</c>（页码）和<c>pageSize</c>（每页数量）控制，默认从第1页开始，每页显示20条记录。</description></item>
        /// <item><description>默认按更新时间倒序排列。</description></item>
        /// <item><description>调用者在请求体中传入的<c>tenant_id</c>或<c>user_id</c>将被忽略，这些信息仅来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOutputFilesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutputFilesResponse
        /// </returns>
        public ListOutputFilesResponse ListOutputFilesWithOptions(ListOutputFilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                body["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedOnly))
            {
                body["sharedOnly"] = request.SharedOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutputFiles",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listOutputFiles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutputFilesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前用户的产出列表，支持按条件过滤和分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询当前登录用户的产出列表。</description></item>
        /// <item><description><c>tenantId</c>作为公共参数，缺省时使用调用方默认租户。</description></item>
        /// <item><description>支持通过<c>operatingObjectName</c>、<c>itemType</c>、<c>keyword</c>等参数进行过滤查询。</description></item>
        /// <item><description>可以设置<c>sharedOnly</c>为<c>true</c>来仅展示开启分享的产出。</description></item>
        /// <item><description>分页信息通过<c>page</c>（页码）和<c>pageSize</c>（每页数量）控制，默认从第1页开始，每页显示20条记录。</description></item>
        /// <item><description>默认按更新时间倒序排列。</description></item>
        /// <item><description>调用者在请求体中传入的<c>tenant_id</c>或<c>user_id</c>将被忽略，这些信息仅来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOutputFilesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutputFilesResponse
        /// </returns>
        public async Task<ListOutputFilesResponse> ListOutputFilesWithOptionsAsync(ListOutputFilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                body["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedOnly))
            {
                body["sharedOnly"] = request.SharedOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutputFiles",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listOutputFiles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutputFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前用户的产出列表，支持按条件过滤和分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询当前登录用户的产出列表。</description></item>
        /// <item><description><c>tenantId</c>作为公共参数，缺省时使用调用方默认租户。</description></item>
        /// <item><description>支持通过<c>operatingObjectName</c>、<c>itemType</c>、<c>keyword</c>等参数进行过滤查询。</description></item>
        /// <item><description>可以设置<c>sharedOnly</c>为<c>true</c>来仅展示开启分享的产出。</description></item>
        /// <item><description>分页信息通过<c>page</c>（页码）和<c>pageSize</c>（每页数量）控制，默认从第1页开始，每页显示20条记录。</description></item>
        /// <item><description>默认按更新时间倒序排列。</description></item>
        /// <item><description>调用者在请求体中传入的<c>tenant_id</c>或<c>user_id</c>将被忽略，这些信息仅来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOutputFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutputFilesResponse
        /// </returns>
        public ListOutputFilesResponse ListOutputFiles(ListOutputFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOutputFilesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前用户的产出列表，支持按条件过滤和分页。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于查询当前登录用户的产出列表。</description></item>
        /// <item><description><c>tenantId</c>作为公共参数，缺省时使用调用方默认租户。</description></item>
        /// <item><description>支持通过<c>operatingObjectName</c>、<c>itemType</c>、<c>keyword</c>等参数进行过滤查询。</description></item>
        /// <item><description>可以设置<c>sharedOnly</c>为<c>true</c>来仅展示开启分享的产出。</description></item>
        /// <item><description>分页信息通过<c>page</c>（页码）和<c>pageSize</c>（每页数量）控制，默认从第1页开始，每页显示20条记录。</description></item>
        /// <item><description>默认按更新时间倒序排列。</description></item>
        /// <item><description>调用者在请求体中传入的<c>tenant_id</c>或<c>user_id</c>将被忽略，这些信息仅来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOutputFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutputFilesResponse
        /// </returns>
        public async Task<ListOutputFilesResponse> ListOutputFilesAsync(ListOutputFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOutputFilesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定数字员工资源目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于下钻查询&quot;我的资源&quot;目录下的子目录与资源。</description></item>
        /// <item><description>当 <c>directoryId</c> 设置为 &#39;root&#39; 时，服务将自动解析并返回当前数字员工默认根目录下的内容；若提供具体的目录 ID，则返回该目录下的子目录和资源。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，调用方在请求体中提供的这些字段将被忽略。</description></item>
        /// <item><description>支持通过 <c>sourceTypes</c> 参数筛选特定类型的资源，当此参数有值时，仅返回符合类型条件的资源而不包含子目录。</description></item>
        /// <item><description>排序支持按名称 (<c>name</c>)、创建时间 (<c>gmt_create</c>) 或修改时间 (<c>gmt_modified</c>) 进行升序或降序排列。</description></item>
        /// <item><description>分页功能允许用户自定义每页显示的数量（最大100）及当前查看的页码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListPersonalDirectoryContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPersonalDirectoryContentsResponse
        /// </returns>
        public ListPersonalDirectoryContentsResponse ListPersonalDirectoryContentsWithOptions(ListPersonalDirectoryContentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPersonalDirectoryContentsShrinkRequest request = new ListPersonalDirectoryContentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTypes))
            {
                request.SourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTypes, "sourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypesShrink))
            {
                body["sourceTypes"] = request.SourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPersonalDirectoryContents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listPersonalDirectoryContents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPersonalDirectoryContentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定数字员工资源目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于下钻查询&quot;我的资源&quot;目录下的子目录与资源。</description></item>
        /// <item><description>当 <c>directoryId</c> 设置为 &#39;root&#39; 时，服务将自动解析并返回当前数字员工默认根目录下的内容；若提供具体的目录 ID，则返回该目录下的子目录和资源。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，调用方在请求体中提供的这些字段将被忽略。</description></item>
        /// <item><description>支持通过 <c>sourceTypes</c> 参数筛选特定类型的资源，当此参数有值时，仅返回符合类型条件的资源而不包含子目录。</description></item>
        /// <item><description>排序支持按名称 (<c>name</c>)、创建时间 (<c>gmt_create</c>) 或修改时间 (<c>gmt_modified</c>) 进行升序或降序排列。</description></item>
        /// <item><description>分页功能允许用户自定义每页显示的数量（最大100）及当前查看的页码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListPersonalDirectoryContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPersonalDirectoryContentsResponse
        /// </returns>
        public async Task<ListPersonalDirectoryContentsResponse> ListPersonalDirectoryContentsWithOptionsAsync(ListPersonalDirectoryContentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPersonalDirectoryContentsShrinkRequest request = new ListPersonalDirectoryContentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTypes))
            {
                request.SourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTypes, "sourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypesShrink))
            {
                body["sourceTypes"] = request.SourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPersonalDirectoryContents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listPersonalDirectoryContents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPersonalDirectoryContentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定数字员工资源目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于下钻查询&quot;我的资源&quot;目录下的子目录与资源。</description></item>
        /// <item><description>当 <c>directoryId</c> 设置为 &#39;root&#39; 时，服务将自动解析并返回当前数字员工默认根目录下的内容；若提供具体的目录 ID，则返回该目录下的子目录和资源。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，调用方在请求体中提供的这些字段将被忽略。</description></item>
        /// <item><description>支持通过 <c>sourceTypes</c> 参数筛选特定类型的资源，当此参数有值时，仅返回符合类型条件的资源而不包含子目录。</description></item>
        /// <item><description>排序支持按名称 (<c>name</c>)、创建时间 (<c>gmt_create</c>) 或修改时间 (<c>gmt_modified</c>) 进行升序或降序排列。</description></item>
        /// <item><description>分页功能允许用户自定义每页显示的数量（最大100）及当前查看的页码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPersonalDirectoryContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPersonalDirectoryContentsResponse
        /// </returns>
        public ListPersonalDirectoryContentsResponse ListPersonalDirectoryContents(ListPersonalDirectoryContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPersonalDirectoryContentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定数字员工资源目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于下钻查询&quot;我的资源&quot;目录下的子目录与资源。</description></item>
        /// <item><description>当 <c>directoryId</c> 设置为 &#39;root&#39; 时，服务将自动解析并返回当前数字员工默认根目录下的内容；若提供具体的目录 ID，则返回该目录下的子目录和资源。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 只能来自鉴权身份信息，调用方在请求体中提供的这些字段将被忽略。</description></item>
        /// <item><description>支持通过 <c>sourceTypes</c> 参数筛选特定类型的资源，当此参数有值时，仅返回符合类型条件的资源而不包含子目录。</description></item>
        /// <item><description>排序支持按名称 (<c>name</c>)、创建时间 (<c>gmt_create</c>) 或修改时间 (<c>gmt_modified</c>) 进行升序或降序排列。</description></item>
        /// <item><description>分页功能允许用户自定义每页显示的数量（最大100）及当前查看的页码。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPersonalDirectoryContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPersonalDirectoryContentsResponse
        /// </returns>
        public async Task<ListPersonalDirectoryContentsResponse> ListPersonalDirectoryContentsAsync(ListPersonalDirectoryContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPersonalDirectoryContentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统内置角色列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询系统内置角色列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 UserManagementAuthorizedService.list_system_roles 完成权限校验（PLATFORM_USER_VIEW）
        ///     3. 按请求 Accept-Language 渲染角色名称与说明
        ///     4. 返回固定的 7 个系统内置角色
        ///     返回字段 roleCode 可直接用于 createUser / updateUser 的 roleCodes 参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listRoles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统内置角色列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询系统内置角色列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 UserManagementAuthorizedService.list_system_roles 完成权限校验（PLATFORM_USER_VIEW）
        ///     3. 按请求 Accept-Language 渲染角色名称与说明
        ///     4. 返回固定的 7 个系统内置角色
        ///     返回字段 roleCode 可直接用于 createUser / updateUser 的 roleCodes 参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listRoles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统内置角色列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询系统内置角色列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 UserManagementAuthorizedService.list_system_roles 完成权限校验（PLATFORM_USER_VIEW）
        ///     3. 按请求 Accept-Language 渲染角色名称与说明
        ///     4. 返回固定的 7 个系统内置角色
        ///     返回字段 roleCode 可直接用于 createUser / updateUser 的 roleCodes 参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRolesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统内置角色列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询系统内置角色列表。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 UserManagementAuthorizedService.list_system_roles 完成权限校验（PLATFORM_USER_VIEW）
        ///     3. 按请求 Accept-Language 渲染角色名称与说明
        ///     4. 返回固定的 7 个系统内置角色
        ///     返回字段 roleCode 可直接用于 createUser / updateUser 的 roleCodes 参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRolesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public ListScheduledTasksResponse ListScheduledTasksWithOptions(ListScheduledTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                query["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledTasks",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listScheduledTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public async Task<ListScheduledTasksResponse> ListScheduledTasksWithOptionsAsync(ListScheduledTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationGroupId))
            {
                query["collaborationGroupId"] = request.CollaborationGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledTasks",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listScheduledTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public ListScheduledTasksResponse ListScheduledTasks(ListScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScheduledTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取定时任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public async Task<ListScheduledTasksResponse> ListScheduledTasksAsync(ListScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScheduledTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出当前租户可见的技能。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于获取当前租户下所有可见的技能列表。支持按数字员工绑定关系、技能来源、标签、关键词等条件进行过滤，并支持分页。</para>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选，公共参数，由网关透传到后端 Header；不传时使用当前调用方所属的默认租户。</description></item>
        /// <item><description><b>FilterType</b>：可选，技能筛选维度。可选值：<c>ALL</c>(全部已发布)、<c>BUILTIN</c>(内置已发布)、<c>CUSTOM</c>(自定义已发布)、<c>DRAFT</c>(草稿箱，含未发布修改的已发布技能)。默认 <c>ALL</c>。</description></item>
        /// <item><description><b>Tags</b>：可选，按标签过滤，数组任一命中即匹配。</description></item>
        /// <item><description><b>Keyword</b>：可选，按技能名称或描述模糊匹配。</description></item>
        /// <item><description><b>Page</b>：可选，页码，最小 1，默认 1。</description></item>
        /// <item><description><b>PageSize</b>：可选，每页数量，范围 1~100，默认 20。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，数字员工名称，传入时按绑定关系过滤；必须配合 <c>BindStatus</c> 使用。</description></item>
        /// <item><description><b>BindStatus</b>：可选，绑定状态。可选值：<c>BOUND</c>(已绑定)、<c>UNBOUND</c>(未绑定的全局技能)。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>响应包含技能列表 <c>items</c>、总数 <c>total</c>、当前页 <c>page</c> 与每页数量 <c>pageSize</c>。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkillsWithOptions(ListSkillsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSkillsShrinkRequest request = new ListSkillsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindStatus))
            {
                body["bindStatus"] = request.BindStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                body["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listSkills",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出当前租户可见的技能。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于获取当前租户下所有可见的技能列表。支持按数字员工绑定关系、技能来源、标签、关键词等条件进行过滤，并支持分页。</para>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选，公共参数，由网关透传到后端 Header；不传时使用当前调用方所属的默认租户。</description></item>
        /// <item><description><b>FilterType</b>：可选，技能筛选维度。可选值：<c>ALL</c>(全部已发布)、<c>BUILTIN</c>(内置已发布)、<c>CUSTOM</c>(自定义已发布)、<c>DRAFT</c>(草稿箱，含未发布修改的已发布技能)。默认 <c>ALL</c>。</description></item>
        /// <item><description><b>Tags</b>：可选，按标签过滤，数组任一命中即匹配。</description></item>
        /// <item><description><b>Keyword</b>：可选，按技能名称或描述模糊匹配。</description></item>
        /// <item><description><b>Page</b>：可选，页码，最小 1，默认 1。</description></item>
        /// <item><description><b>PageSize</b>：可选，每页数量，范围 1~100，默认 20。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，数字员工名称，传入时按绑定关系过滤；必须配合 <c>BindStatus</c> 使用。</description></item>
        /// <item><description><b>BindStatus</b>：可选，绑定状态。可选值：<c>BOUND</c>(已绑定)、<c>UNBOUND</c>(未绑定的全局技能)。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>响应包含技能列表 <c>items</c>、总数 <c>total</c>、当前页 <c>page</c> 与每页数量 <c>pageSize</c>。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsWithOptionsAsync(ListSkillsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSkillsShrinkRequest request = new ListSkillsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindStatus))
            {
                body["bindStatus"] = request.BindStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                body["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listSkills",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出当前租户可见的技能。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于获取当前租户下所有可见的技能列表。支持按数字员工绑定关系、技能来源、标签、关键词等条件进行过滤，并支持分页。</para>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选，公共参数，由网关透传到后端 Header；不传时使用当前调用方所属的默认租户。</description></item>
        /// <item><description><b>FilterType</b>：可选，技能筛选维度。可选值：<c>ALL</c>(全部已发布)、<c>BUILTIN</c>(内置已发布)、<c>CUSTOM</c>(自定义已发布)、<c>DRAFT</c>(草稿箱，含未发布修改的已发布技能)。默认 <c>ALL</c>。</description></item>
        /// <item><description><b>Tags</b>：可选，按标签过滤，数组任一命中即匹配。</description></item>
        /// <item><description><b>Keyword</b>：可选，按技能名称或描述模糊匹配。</description></item>
        /// <item><description><b>Page</b>：可选，页码，最小 1，默认 1。</description></item>
        /// <item><description><b>PageSize</b>：可选，每页数量，范围 1~100，默认 20。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，数字员工名称，传入时按绑定关系过滤；必须配合 <c>BindStatus</c> 使用。</description></item>
        /// <item><description><b>BindStatus</b>：可选，绑定状态。可选值：<c>BOUND</c>(已绑定)、<c>UNBOUND</c>(未绑定的全局技能)。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>响应包含技能列表 <c>items</c>、总数 <c>total</c>、当前页 <c>page</c> 与每页数量 <c>pageSize</c>。</para>
        /// </description>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSkillsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出当前租户可见的技能。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于获取当前租户下所有可见的技能列表。支持按数字员工绑定关系、技能来源、标签、关键词等条件进行过滤，并支持分页。</para>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选，公共参数，由网关透传到后端 Header；不传时使用当前调用方所属的默认租户。</description></item>
        /// <item><description><b>FilterType</b>：可选，技能筛选维度。可选值：<c>ALL</c>(全部已发布)、<c>BUILTIN</c>(内置已发布)、<c>CUSTOM</c>(自定义已发布)、<c>DRAFT</c>(草稿箱，含未发布修改的已发布技能)。默认 <c>ALL</c>。</description></item>
        /// <item><description><b>Tags</b>：可选，按标签过滤，数组任一命中即匹配。</description></item>
        /// <item><description><b>Keyword</b>：可选，按技能名称或描述模糊匹配。</description></item>
        /// <item><description><b>Page</b>：可选，页码，最小 1，默认 1。</description></item>
        /// <item><description><b>PageSize</b>：可选，每页数量，范围 1~100，默认 20。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，数字员工名称，传入时按绑定关系过滤；必须配合 <c>BindStatus</c> 使用。</description></item>
        /// <item><description><b>BindStatus</b>：可选，绑定状态。可选值：<c>BOUND</c>(已绑定)、<c>UNBOUND</c>(未绑定的全局技能)。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>响应包含技能列表 <c>items</c>、总数 <c>total</c>、当前页 <c>page</c> 与每页数量 <c>pageSize</c>。</para>
        /// </description>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSkillsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按管理端口径分页查询企业知识库目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于分页查询企业知识库中的目录内容和资源。</description></item>
        /// <item><description>支持通过多种参数进行过滤和排序，如<c>directoryId</c>、<c>page</c>、<c>pageSize</c>、<c>sortField</c>、<c>sortOrder</c>等。</description></item>
        /// <item><description><c>sourceTypes</c>参数允许用户根据资源类型进行过滤，多个类型使用逗号分隔。</description></item>
        /// <item><description>当不传或传入<c>root</c>作为<c>directoryId</c>时，默认查询知识库根目录列表。</description></item>
        /// <item><description>默认的排序字段为<c>name</c>，默认排序方向为升序（<c>asc</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantDirectoryResponse
        /// </returns>
        public ListTenantDirectoryResponse ListTenantDirectoryWithOptions(ListTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                body["sourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按管理端口径分页查询企业知识库目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于分页查询企业知识库中的目录内容和资源。</description></item>
        /// <item><description>支持通过多种参数进行过滤和排序，如<c>directoryId</c>、<c>page</c>、<c>pageSize</c>、<c>sortField</c>、<c>sortOrder</c>等。</description></item>
        /// <item><description><c>sourceTypes</c>参数允许用户根据资源类型进行过滤，多个类型使用逗号分隔。</description></item>
        /// <item><description>当不传或传入<c>root</c>作为<c>directoryId</c>时，默认查询知识库根目录列表。</description></item>
        /// <item><description>默认的排序字段为<c>name</c>，默认排序方向为升序（<c>asc</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantDirectoryResponse
        /// </returns>
        public async Task<ListTenantDirectoryResponse> ListTenantDirectoryWithOptionsAsync(ListTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                body["sourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按管理端口径分页查询企业知识库目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于分页查询企业知识库中的目录内容和资源。</description></item>
        /// <item><description>支持通过多种参数进行过滤和排序，如<c>directoryId</c>、<c>page</c>、<c>pageSize</c>、<c>sortField</c>、<c>sortOrder</c>等。</description></item>
        /// <item><description><c>sourceTypes</c>参数允许用户根据资源类型进行过滤，多个类型使用逗号分隔。</description></item>
        /// <item><description>当不传或传入<c>root</c>作为<c>directoryId</c>时，默认查询知识库根目录列表。</description></item>
        /// <item><description>默认的排序字段为<c>name</c>，默认排序方向为升序（<c>asc</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTenantDirectoryResponse
        /// </returns>
        public ListTenantDirectoryResponse ListTenantDirectory(ListTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTenantDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>按管理端口径分页查询企业知识库目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于分页查询企业知识库中的目录内容和资源。</description></item>
        /// <item><description>支持通过多种参数进行过滤和排序，如<c>directoryId</c>、<c>page</c>、<c>pageSize</c>、<c>sortField</c>、<c>sortOrder</c>等。</description></item>
        /// <item><description><c>sourceTypes</c>参数允许用户根据资源类型进行过滤，多个类型使用逗号分隔。</description></item>
        /// <item><description>当不传或传入<c>root</c>作为<c>directoryId</c>时，默认查询知识库根目录列表。</description></item>
        /// <item><description>默认的排序字段为<c>name</c>，默认排序方向为升序（<c>asc</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTenantDirectoryResponse
        /// </returns>
        public async Task<ListTenantDirectoryResponse> ListTenantDirectoryAsync(ListTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTenantDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见知识库目录内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按企业知识库前台口径返回指定目录的子目录和 READY 资源。</description></item>
        /// <item><description>用户身份与目录可见范围均来自 OpenAPI 鉴权上下文。</description></item>
        /// <item><description><c>sourceTypes</c> 有值时仅返回资源；<c>keyword</c> 仅搜索当前目录层级。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public ListUserVisibleKnowledgeBaseContentsResponse ListUserVisibleKnowledgeBaseContentsWithOptions(ListUserVisibleKnowledgeBaseContentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                body["sourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserVisibleKnowledgeBaseContents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listUserVisibleKnowledgeBaseContents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVisibleKnowledgeBaseContentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见知识库目录内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按企业知识库前台口径返回指定目录的子目录和 READY 资源。</description></item>
        /// <item><description>用户身份与目录可见范围均来自 OpenAPI 鉴权上下文。</description></item>
        /// <item><description><c>sourceTypes</c> 有值时仅返回资源；<c>keyword</c> 仅搜索当前目录层级。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public async Task<ListUserVisibleKnowledgeBaseContentsResponse> ListUserVisibleKnowledgeBaseContentsWithOptionsAsync(ListUserVisibleKnowledgeBaseContentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                body["sourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserVisibleKnowledgeBaseContents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listUserVisibleKnowledgeBaseContents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVisibleKnowledgeBaseContentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见知识库目录内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按企业知识库前台口径返回指定目录的子目录和 READY 资源。</description></item>
        /// <item><description>用户身份与目录可见范围均来自 OpenAPI 鉴权上下文。</description></item>
        /// <item><description><c>sourceTypes</c> 有值时仅返回资源；<c>keyword</c> 仅搜索当前目录层级。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public ListUserVisibleKnowledgeBaseContentsResponse ListUserVisibleKnowledgeBaseContents(ListUserVisibleKnowledgeBaseContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserVisibleKnowledgeBaseContentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见知识库目录内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按企业知识库前台口径返回指定目录的子目录和 READY 资源。</description></item>
        /// <item><description>用户身份与目录可见范围均来自 OpenAPI 鉴权上下文。</description></item>
        /// <item><description><c>sourceTypes</c> 有值时仅返回资源；<c>keyword</c> 仅搜索当前目录层级。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public async Task<ListUserVisibleKnowledgeBaseContentsResponse> ListUserVisibleKnowledgeBaseContentsAsync(ListUserVisibleKnowledgeBaseContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserVisibleKnowledgeBaseContentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按 OpenAPI 鉴权身份映射的平台用户查询其可见企业知识库。</description></item>
        /// <item><description>租户和用户身份均由鉴权上下文确定，调用方不能通过业务参数扩大可见范围。</description></item>
        /// <item><description><c>tenantId</c> 为可选公共参数；<c>keyword</c> 可按知识库名称或描述过滤。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBasesResponse
        /// </returns>
        public ListUserVisibleKnowledgeBasesResponse ListUserVisibleKnowledgeBasesWithOptions(ListUserVisibleKnowledgeBasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserVisibleKnowledgeBases",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listUserVisibleKnowledgeBases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVisibleKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按 OpenAPI 鉴权身份映射的平台用户查询其可见企业知识库。</description></item>
        /// <item><description>租户和用户身份均由鉴权上下文确定，调用方不能通过业务参数扩大可见范围。</description></item>
        /// <item><description><c>tenantId</c> 为可选公共参数；<c>keyword</c> 可按知识库名称或描述过滤。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBasesResponse
        /// </returns>
        public async Task<ListUserVisibleKnowledgeBasesResponse> ListUserVisibleKnowledgeBasesWithOptionsAsync(ListUserVisibleKnowledgeBasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserVisibleKnowledgeBases",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listUserVisibleKnowledgeBases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserVisibleKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按 OpenAPI 鉴权身份映射的平台用户查询其可见企业知识库。</description></item>
        /// <item><description>租户和用户身份均由鉴权上下文确定，调用方不能通过业务参数扩大可见范围。</description></item>
        /// <item><description><c>tenantId</c> 为可选公共参数；<c>keyword</c> 可按知识库名称或描述过滤。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBasesResponse
        /// </returns>
        public ListUserVisibleKnowledgeBasesResponse ListUserVisibleKnowledgeBases(ListUserVisibleKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserVisibleKnowledgeBasesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询当前 OpenAPI 用户可见的企业知识库列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口按 OpenAPI 鉴权身份映射的平台用户查询其可见企业知识库。</description></item>
        /// <item><description>租户和用户身份均由鉴权上下文确定，调用方不能通过业务参数扩大可见范围。</description></item>
        /// <item><description><c>tenantId</c> 为可选公共参数；<c>keyword</c> 可按知识库名称或描述过滤。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserVisibleKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserVisibleKnowledgeBasesResponse
        /// </returns>
        public async Task<ListUserVisibleKnowledgeBasesResponse> ListUserVisibleKnowledgeBasesAsync(ListUserVisibleKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserVisibleKnowledgeBasesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询租户成员列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 分页查询租户成员列表。
        ///     业务编排：
        ///     1. 解析筛选条件（roleCodes → role_ids）
        ///     2. 调用 UserTenantMappingRepository.query_paged_tenant_members 分页查询
        ///     3. 将结果中的 role_id 转为 roleCode 并组装响应
        ///     错误码：
        ///     - 非法 roleCode 参数时抛出错误</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUsersShrinkRequest request = new ListUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "accountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoleCodes))
            {
                request.RoleCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoleCodes, "roleCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                body["accountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                body["isActive"] = request.IsActive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodesShrink))
            {
                body["roleCodes"] = request.RoleCodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询租户成员列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 分页查询租户成员列表。
        ///     业务编排：
        ///     1. 解析筛选条件（roleCodes → role_ids）
        ///     2. 调用 UserTenantMappingRepository.query_paged_tenant_members 分页查询
        ///     3. 将结果中的 role_id 转为 roleCode 并组装响应
        ///     错误码：
        ///     - 非法 roleCode 参数时抛出错误</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUsersShrinkRequest request = new ListUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "accountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoleCodes))
            {
                request.RoleCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoleCodes, "roleCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                body["accountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                body["isActive"] = request.IsActive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodesShrink))
            {
                body["roleCodes"] = request.RoleCodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询租户成员列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 分页查询租户成员列表。
        ///     业务编排：
        ///     1. 解析筛选条件（roleCodes → role_ids）
        ///     2. 调用 UserTenantMappingRepository.query_paged_tenant_members 分页查询
        ///     3. 将结果中的 role_id 转为 roleCode 并组装响应
        ///     错误码：
        ///     - 非法 roleCode 参数时抛出错误</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询租户成员列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 分页查询租户成员列表。
        ///     业务编排：
        ///     1. 解析筛选条件（roleCodes → role_ids）
        ///     2. 调用 UserTenantMappingRepository.query_paged_tenant_members 分页查询
        ///     3. 将结果中的 role_id 转为 roleCode 并组装响应
        ///     错误码：
        ///     - 非法 roleCode 参数时抛出错误</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下钻查询指定数字员工可见的知识库目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定数字员工在指定知识库目录下的所有子目录和资源。</description></item>
        /// <item><description>用户需拥有对目标数字员工的USE权限，且该数字员工必须有权访问请求中指定的目录及其子目录。</description></item>
        /// <item><description>请求时需要提供数字员工名称（<c>operatingObjectName</c>）及要查询的目录ID（<c>directoryId</c>），其他参数如分页信息、排序方式等为可选项。</description></item>
        /// <item><description>接口返回结果包括目录下的子目录和资源列表，并支持按页码分页显示。</description></item>
        /// <item><description><c>sourceStatus</c>字段固定过滤值为<c>READY</c>状态的资源。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，调用方即使在请求体中传递也会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public ListVisibleKnowledgeBaseContentsResponse ListVisibleKnowledgeBaseContentsWithOptions(ListVisibleKnowledgeBaseContentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVisibleKnowledgeBaseContentsShrinkRequest request = new ListVisibleKnowledgeBaseContentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTypes))
            {
                request.SourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTypes, "sourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypesShrink))
            {
                body["sourceTypes"] = request.SourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVisibleKnowledgeBaseContents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listVisibleKnowledgeBaseContents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVisibleKnowledgeBaseContentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下钻查询指定数字员工可见的知识库目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定数字员工在指定知识库目录下的所有子目录和资源。</description></item>
        /// <item><description>用户需拥有对目标数字员工的USE权限，且该数字员工必须有权访问请求中指定的目录及其子目录。</description></item>
        /// <item><description>请求时需要提供数字员工名称（<c>operatingObjectName</c>）及要查询的目录ID（<c>directoryId</c>），其他参数如分页信息、排序方式等为可选项。</description></item>
        /// <item><description>接口返回结果包括目录下的子目录和资源列表，并支持按页码分页显示。</description></item>
        /// <item><description><c>sourceStatus</c>字段固定过滤值为<c>READY</c>状态的资源。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，调用方即使在请求体中传递也会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public async Task<ListVisibleKnowledgeBaseContentsResponse> ListVisibleKnowledgeBaseContentsWithOptionsAsync(ListVisibleKnowledgeBaseContentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVisibleKnowledgeBaseContentsShrinkRequest request = new ListVisibleKnowledgeBaseContentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTypes))
            {
                request.SourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTypes, "sourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["sortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypesShrink))
            {
                body["sourceTypes"] = request.SourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVisibleKnowledgeBaseContents",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listVisibleKnowledgeBaseContents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVisibleKnowledgeBaseContentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下钻查询指定数字员工可见的知识库目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定数字员工在指定知识库目录下的所有子目录和资源。</description></item>
        /// <item><description>用户需拥有对目标数字员工的USE权限，且该数字员工必须有权访问请求中指定的目录及其子目录。</description></item>
        /// <item><description>请求时需要提供数字员工名称（<c>operatingObjectName</c>）及要查询的目录ID（<c>directoryId</c>），其他参数如分页信息、排序方式等为可选项。</description></item>
        /// <item><description>接口返回结果包括目录下的子目录和资源列表，并支持按页码分页显示。</description></item>
        /// <item><description><c>sourceStatus</c>字段固定过滤值为<c>READY</c>状态的资源。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，调用方即使在请求体中传递也会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public ListVisibleKnowledgeBaseContentsResponse ListVisibleKnowledgeBaseContents(ListVisibleKnowledgeBaseContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVisibleKnowledgeBaseContentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下钻查询指定数字员工可见的知识库目录下的子目录与资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口用于查询特定数字员工在指定知识库目录下的所有子目录和资源。</description></item>
        /// <item><description>用户需拥有对目标数字员工的USE权限，且该数字员工必须有权访问请求中指定的目录及其子目录。</description></item>
        /// <item><description>请求时需要提供数字员工名称（<c>operatingObjectName</c>）及要查询的目录ID（<c>directoryId</c>），其他参数如分页信息、排序方式等为可选项。</description></item>
        /// <item><description>接口返回结果包括目录下的子目录和资源列表，并支持按页码分页显示。</description></item>
        /// <item><description><c>sourceStatus</c>字段固定过滤值为<c>READY</c>状态的资源。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c>与<c>user_id</c>仅从鉴权身份获取，调用方即使在请求体中传递也会被忽略。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListVisibleKnowledgeBaseContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBaseContentsResponse
        /// </returns>
        public async Task<ListVisibleKnowledgeBaseContentsResponse> ListVisibleKnowledgeBaseContentsAsync(ListVisibleKnowledgeBaseContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVisibleKnowledgeBaseContentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工可访问的企业知识库顶层目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定数字员工（运营对象）在企业内可见的知识库顶层目录列表。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListVisibleKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// ListVisibleKnowledgeBasesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBasesResponse
        /// </returns>
        public ListVisibleKnowledgeBasesResponse ListVisibleKnowledgeBasesWithOptions(ListVisibleKnowledgeBasesRequest request, ListVisibleKnowledgeBasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RequestId))
            {
                realHeaders["requestId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.RequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVisibleKnowledgeBases",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listVisibleKnowledgeBases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVisibleKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工可访问的企业知识库顶层目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定数字员工（运营对象）在企业内可见的知识库顶层目录列表。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListVisibleKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// ListVisibleKnowledgeBasesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBasesResponse
        /// </returns>
        public async Task<ListVisibleKnowledgeBasesResponse> ListVisibleKnowledgeBasesWithOptionsAsync(ListVisibleKnowledgeBasesRequest request, ListVisibleKnowledgeBasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RequestId))
            {
                realHeaders["requestId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.RequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVisibleKnowledgeBases",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/listVisibleKnowledgeBases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVisibleKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工可访问的企业知识库顶层目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定数字员工（运营对象）在企业内可见的知识库顶层目录列表。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListVisibleKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBasesResponse
        /// </returns>
        public ListVisibleKnowledgeBasesResponse ListVisibleKnowledgeBases(ListVisibleKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVisibleKnowledgeBasesHeaders headers = new ListVisibleKnowledgeBasesHeaders();
            return ListVisibleKnowledgeBasesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工可访问的企业知识库顶层目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定数字员工（运营对象）在企业内可见的知识库顶层目录列表。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListVisibleKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVisibleKnowledgeBasesResponse
        /// </returns>
        public async Task<ListVisibleKnowledgeBasesResponse> ListVisibleKnowledgeBasesAsync(ListVisibleKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVisibleKnowledgeBasesHeaders headers = new ListVisibleKnowledgeBasesHeaders();
            return await ListVisibleKnowledgeBasesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在企业知识库目录间移动指定资源，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>鉴权流程</b>：<ol>
        /// <item><description>基础鉴权由根 router 统一完成（<c>request.state.openapi_identity</c>）。</description></item>
        /// <item><description>本 handler 校验 <c>DEVELOPMENT_KB_MANAGE</c> 功能权限。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>操作步骤</b>：<ol>
        /// <item><description>检查源目录与目标目录不能相同。</description></item>
        /// <item><description>确认目标目录存在。</description></item>
        /// <item><description>验证待移动的资源确实位于源目录中。</description></item>
        /// <item><description>更新资源的目录绑定关系。</description></item>
        /// <item><description>尽力更新 <c>source.settings[&quot;knowledge_id&quot;]</c> 为目标知识库 ID。</description></item>
        /// <item><description>尽力通知 DocumentAgent 同步 <c>knowledge_id</c> 和 <c>update_time</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全约束</b>：<list type="bullet">
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description>调用者需要拥有 KB 管理权限。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveKnowledgeBaseResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveKnowledgeBaseResourceResponse
        /// </returns>
        public MoveKnowledgeBaseResourceResponse MoveKnowledgeBaseResourceWithOptions(MoveKnowledgeBaseResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDirectoryId))
            {
                body["sourceDirectoryId"] = request.SourceDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDirectoryId))
            {
                body["targetDirectoryId"] = request.TargetDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveKnowledgeBaseResource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/moveKnowledgeBaseResource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveKnowledgeBaseResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在企业知识库目录间移动指定资源，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>鉴权流程</b>：<ol>
        /// <item><description>基础鉴权由根 router 统一完成（<c>request.state.openapi_identity</c>）。</description></item>
        /// <item><description>本 handler 校验 <c>DEVELOPMENT_KB_MANAGE</c> 功能权限。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>操作步骤</b>：<ol>
        /// <item><description>检查源目录与目标目录不能相同。</description></item>
        /// <item><description>确认目标目录存在。</description></item>
        /// <item><description>验证待移动的资源确实位于源目录中。</description></item>
        /// <item><description>更新资源的目录绑定关系。</description></item>
        /// <item><description>尽力更新 <c>source.settings[&quot;knowledge_id&quot;]</c> 为目标知识库 ID。</description></item>
        /// <item><description>尽力通知 DocumentAgent 同步 <c>knowledge_id</c> 和 <c>update_time</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全约束</b>：<list type="bullet">
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description>调用者需要拥有 KB 管理权限。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveKnowledgeBaseResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveKnowledgeBaseResourceResponse
        /// </returns>
        public async Task<MoveKnowledgeBaseResourceResponse> MoveKnowledgeBaseResourceWithOptionsAsync(MoveKnowledgeBaseResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["knowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDirectoryId))
            {
                body["sourceDirectoryId"] = request.SourceDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDirectoryId))
            {
                body["targetDirectoryId"] = request.TargetDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveKnowledgeBaseResource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/moveKnowledgeBaseResource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveKnowledgeBaseResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在企业知识库目录间移动指定资源，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>鉴权流程</b>：<ol>
        /// <item><description>基础鉴权由根 router 统一完成（<c>request.state.openapi_identity</c>）。</description></item>
        /// <item><description>本 handler 校验 <c>DEVELOPMENT_KB_MANAGE</c> 功能权限。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>操作步骤</b>：<ol>
        /// <item><description>检查源目录与目标目录不能相同。</description></item>
        /// <item><description>确认目标目录存在。</description></item>
        /// <item><description>验证待移动的资源确实位于源目录中。</description></item>
        /// <item><description>更新资源的目录绑定关系。</description></item>
        /// <item><description>尽力更新 <c>source.settings[&quot;knowledge_id&quot;]</c> 为目标知识库 ID。</description></item>
        /// <item><description>尽力通知 DocumentAgent 同步 <c>knowledge_id</c> 和 <c>update_time</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全约束</b>：<list type="bullet">
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description>调用者需要拥有 KB 管理权限。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveKnowledgeBaseResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveKnowledgeBaseResourceResponse
        /// </returns>
        public MoveKnowledgeBaseResourceResponse MoveKnowledgeBaseResource(MoveKnowledgeBaseResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MoveKnowledgeBaseResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在企业知识库目录间移动指定资源，需具备管理权限。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>鉴权流程</b>：<ol>
        /// <item><description>基础鉴权由根 router 统一完成（<c>request.state.openapi_identity</c>）。</description></item>
        /// <item><description>本 handler 校验 <c>DEVELOPMENT_KB_MANAGE</c> 功能权限。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>操作步骤</b>：<ol>
        /// <item><description>检查源目录与目标目录不能相同。</description></item>
        /// <item><description>确认目标目录存在。</description></item>
        /// <item><description>验证待移动的资源确实位于源目录中。</description></item>
        /// <item><description>更新资源的目录绑定关系。</description></item>
        /// <item><description>尽力更新 <c>source.settings[&quot;knowledge_id&quot;]</c> 为目标知识库 ID。</description></item>
        /// <item><description>尽力通知 DocumentAgent 同步 <c>knowledge_id</c> 和 <c>update_time</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全约束</b>：<list type="bullet">
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description>调用者需要拥有 KB 管理权限。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveKnowledgeBaseResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveKnowledgeBaseResourceResponse
        /// </returns>
        public async Task<MoveKnowledgeBaseResourceResponse> MoveKnowledgeBaseResourceAsync(MoveKnowledgeBaseResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MoveKnowledgeBaseResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在用户的个人目录之间移动指定资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>源目录与目标目录不能相同</b>，否则将返回 <c>ERR.Robject.UserDirectory.InvalidOperation</c> 错误。</description></item>
        /// <item><description><b>目标目录必须存在</b>，如果不存在则会返回 <c>ERR.Robject.UserDirectory.DirectoryNotFound</c> 错误。</description></item>
        /// <item><description><b>待移动的资源必须存在于源目录中</b>，若不在源目录中，则会收到 <c>ERR.Robject.UserDirectory.ResourceNotInDirectory</c> 错误。</description></item>
        /// <item><description>成功移动后，系统会尝试通知 DocumentAgent 更新资源的新路径 (<c>source_path</c>)，但此步骤为尽力而为（best-effort），即使失败也不会影响整体操作的成功状态，仅记录错误日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 的值只能来源于鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceResponse
        /// </returns>
        public MoveResourceResponse MoveResourceWithOptions(MoveResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDirectoryId))
            {
                body["sourceDirectoryId"] = request.SourceDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDirectoryId))
            {
                body["targetDirectoryId"] = request.TargetDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/moveResource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在用户的个人目录之间移动指定资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>源目录与目标目录不能相同</b>，否则将返回 <c>ERR.Robject.UserDirectory.InvalidOperation</c> 错误。</description></item>
        /// <item><description><b>目标目录必须存在</b>，如果不存在则会返回 <c>ERR.Robject.UserDirectory.DirectoryNotFound</c> 错误。</description></item>
        /// <item><description><b>待移动的资源必须存在于源目录中</b>，若不在源目录中，则会收到 <c>ERR.Robject.UserDirectory.ResourceNotInDirectory</c> 错误。</description></item>
        /// <item><description>成功移动后，系统会尝试通知 DocumentAgent 更新资源的新路径 (<c>source_path</c>)，但此步骤为尽力而为（best-effort），即使失败也不会影响整体操作的成功状态，仅记录错误日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 的值只能来源于鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceResponse
        /// </returns>
        public async Task<MoveResourceResponse> MoveResourceWithOptionsAsync(MoveResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDirectoryId))
            {
                body["sourceDirectoryId"] = request.SourceDirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDirectoryId))
            {
                body["targetDirectoryId"] = request.TargetDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/moveResource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在用户的个人目录之间移动指定资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>源目录与目标目录不能相同</b>，否则将返回 <c>ERR.Robject.UserDirectory.InvalidOperation</c> 错误。</description></item>
        /// <item><description><b>目标目录必须存在</b>，如果不存在则会返回 <c>ERR.Robject.UserDirectory.DirectoryNotFound</c> 错误。</description></item>
        /// <item><description><b>待移动的资源必须存在于源目录中</b>，若不在源目录中，则会收到 <c>ERR.Robject.UserDirectory.ResourceNotInDirectory</c> 错误。</description></item>
        /// <item><description>成功移动后，系统会尝试通知 DocumentAgent 更新资源的新路径 (<c>source_path</c>)，但此步骤为尽力而为（best-effort），即使失败也不会影响整体操作的成功状态，仅记录错误日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 的值只能来源于鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceResponse
        /// </returns>
        public MoveResourceResponse MoveResource(MoveResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MoveResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在用户的个人目录之间移动指定资源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>源目录与目标目录不能相同</b>，否则将返回 <c>ERR.Robject.UserDirectory.InvalidOperation</c> 错误。</description></item>
        /// <item><description><b>目标目录必须存在</b>，如果不存在则会返回 <c>ERR.Robject.UserDirectory.DirectoryNotFound</c> 错误。</description></item>
        /// <item><description><b>待移动的资源必须存在于源目录中</b>，若不在源目录中，则会收到 <c>ERR.Robject.UserDirectory.ResourceNotInDirectory</c> 错误。</description></item>
        /// <item><description>成功移动后，系统会尝试通知 DocumentAgent 更新资源的新路径 (<c>source_path</c>)，但此步骤为尽力而为（best-effort），即使失败也不会影响整体操作的成功状态，仅记录错误日志。</description></item>
        /// <item><description>安全性方面，<c>tenant_id</c> 的值只能来源于鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceResponse
        /// </returns>
        public async Task<MoveResourceResponse> MoveResourceAsync(MoveResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MoveResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览指定企业知识库下的知识内容</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于预览企业知识库下指定知识的内容。</description></item>
        /// <item><description>需要具备<c>DEVELOPMENT_KB_VIEW</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>sourceId</c>是必需参数，用来标识要预览的知识条目。</description></item>
        /// <item><description>可选参数<c>tenantId</c>允许指定租户ID；若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种类型的预览，包括但不限于图片、音频、视频及文本等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewKnowledgeBaseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewKnowledgeBaseSourceResponse
        /// </returns>
        public PreviewKnowledgeBaseSourceResponse PreviewKnowledgeBaseSourceWithOptions(PreviewKnowledgeBaseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewKnowledgeBaseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/previewKnowledgeBaseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewKnowledgeBaseSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览指定企业知识库下的知识内容</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于预览企业知识库下指定知识的内容。</description></item>
        /// <item><description>需要具备<c>DEVELOPMENT_KB_VIEW</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>sourceId</c>是必需参数，用来标识要预览的知识条目。</description></item>
        /// <item><description>可选参数<c>tenantId</c>允许指定租户ID；若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种类型的预览，包括但不限于图片、音频、视频及文本等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewKnowledgeBaseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewKnowledgeBaseSourceResponse
        /// </returns>
        public async Task<PreviewKnowledgeBaseSourceResponse> PreviewKnowledgeBaseSourceWithOptionsAsync(PreviewKnowledgeBaseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewKnowledgeBaseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/previewKnowledgeBaseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewKnowledgeBaseSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览指定企业知识库下的知识内容</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于预览企业知识库下指定知识的内容。</description></item>
        /// <item><description>需要具备<c>DEVELOPMENT_KB_VIEW</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>sourceId</c>是必需参数，用来标识要预览的知识条目。</description></item>
        /// <item><description>可选参数<c>tenantId</c>允许指定租户ID；若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种类型的预览，包括但不限于图片、音频、视频及文本等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewKnowledgeBaseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewKnowledgeBaseSourceResponse
        /// </returns>
        public PreviewKnowledgeBaseSourceResponse PreviewKnowledgeBaseSource(PreviewKnowledgeBaseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreviewKnowledgeBaseSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览指定企业知识库下的知识内容</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于预览企业知识库下指定知识的内容。</description></item>
        /// <item><description>需要具备<c>DEVELOPMENT_KB_VIEW</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>sourceId</c>是必需参数，用来标识要预览的知识条目。</description></item>
        /// <item><description>可选参数<c>tenantId</c>允许指定租户ID；若未提供，则使用调用方默认的租户ID。</description></item>
        /// <item><description>支持多种类型的预览，包括但不限于图片、音频、视频及文本等。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewKnowledgeBaseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewKnowledgeBaseSourceResponse
        /// </returns>
        public async Task<PreviewKnowledgeBaseSourceResponse> PreviewKnowledgeBaseSourceAsync(PreviewKnowledgeBaseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreviewKnowledgeBaseSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户预览其个人目录下的指定知识内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口仅允许用户预览属于自己的个人目录下的资源。</description></item>
        /// <item><description>鉴权流程包括基础鉴权和数据源归属校验，确保请求者只能访问其个人目录中的知识。</description></item>
        /// <item><description>请求时需提供知识的唯一标识 <c>sourceId</c>，系统将根据此ID及用户的租户信息查询并返回相应的预览信息。</description></item>
        /// <item><description>支持多种类型的预览，如图片、音频、视频等，并根据不同类型返回对应的预览URL或直接的内容展示。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewPersonalSourceRequest
        /// </param>
        /// <param name="headers">
        /// PreviewPersonalSourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewPersonalSourceResponse
        /// </returns>
        public PreviewPersonalSourceResponse PreviewPersonalSourceWithOptions(PreviewPersonalSourceRequest request, PreviewPersonalSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RequestId))
            {
                realHeaders["requestId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.RequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewPersonalSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/previewPersonalSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewPersonalSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户预览其个人目录下的指定知识内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口仅允许用户预览属于自己的个人目录下的资源。</description></item>
        /// <item><description>鉴权流程包括基础鉴权和数据源归属校验，确保请求者只能访问其个人目录中的知识。</description></item>
        /// <item><description>请求时需提供知识的唯一标识 <c>sourceId</c>，系统将根据此ID及用户的租户信息查询并返回相应的预览信息。</description></item>
        /// <item><description>支持多种类型的预览，如图片、音频、视频等，并根据不同类型返回对应的预览URL或直接的内容展示。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewPersonalSourceRequest
        /// </param>
        /// <param name="headers">
        /// PreviewPersonalSourceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewPersonalSourceResponse
        /// </returns>
        public async Task<PreviewPersonalSourceResponse> PreviewPersonalSourceWithOptionsAsync(PreviewPersonalSourceRequest request, PreviewPersonalSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RequestId))
            {
                realHeaders["requestId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.RequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewPersonalSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/previewPersonalSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewPersonalSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户预览其个人目录下的指定知识内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口仅允许用户预览属于自己的个人目录下的资源。</description></item>
        /// <item><description>鉴权流程包括基础鉴权和数据源归属校验，确保请求者只能访问其个人目录中的知识。</description></item>
        /// <item><description>请求时需提供知识的唯一标识 <c>sourceId</c>，系统将根据此ID及用户的租户信息查询并返回相应的预览信息。</description></item>
        /// <item><description>支持多种类型的预览，如图片、音频、视频等，并根据不同类型返回对应的预览URL或直接的内容展示。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewPersonalSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewPersonalSourceResponse
        /// </returns>
        public PreviewPersonalSourceResponse PreviewPersonalSource(PreviewPersonalSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreviewPersonalSourceHeaders headers = new PreviewPersonalSourceHeaders();
            return PreviewPersonalSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户预览其个人目录下的指定知识内容。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口仅允许用户预览属于自己的个人目录下的资源。</description></item>
        /// <item><description>鉴权流程包括基础鉴权和数据源归属校验，确保请求者只能访问其个人目录中的知识。</description></item>
        /// <item><description>请求时需提供知识的唯一标识 <c>sourceId</c>，系统将根据此ID及用户的租户信息查询并返回相应的预览信息。</description></item>
        /// <item><description>支持多种类型的预览，如图片、音频、视频等，并根据不同类型返回对应的预览URL或直接的内容展示。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewPersonalSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewPersonalSourceResponse
        /// </returns>
        public async Task<PreviewPersonalSourceResponse> PreviewPersonalSourceAsync(PreviewPersonalSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreviewPersonalSourceHeaders headers = new PreviewPersonalSourceHeaders();
            return await PreviewPersonalSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过运营对象名称分页查询主对象数据，支持过滤和搜索。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据给定的运营对象名称（如 <c>customer_1</c>）分页查询相关的主对象数据。</description></item>
        /// <item><description>支持通过关键字进行搜索，并且可以设置是否仅返回被标记为关注的对象。</description></item>
        /// <item><description>可以使用复杂的过滤条件来进一步筛选结果，包括但不限于等于、不等于、大于、小于等逻辑操作符。</description></item>
        /// <item><description>如果没有配置主对象类型，则会返回一个空的结果集。</description></item>
        /// <item><description>请求中包含的数据将经过鉴权与过滤处理，确保安全性和准确性。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPrimaryObjectDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPrimaryObjectDataResponse
        /// </returns>
        public QueryPrimaryObjectDataResponse QueryPrimaryObjectDataWithOptions(QueryPrimaryObjectDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyFavorites))
            {
                body["onlyFavorites"] = request.OnlyFavorites;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPrimaryObjectData",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/queryPrimaryObjectData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPrimaryObjectDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过运营对象名称分页查询主对象数据，支持过滤和搜索。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据给定的运营对象名称（如 <c>customer_1</c>）分页查询相关的主对象数据。</description></item>
        /// <item><description>支持通过关键字进行搜索，并且可以设置是否仅返回被标记为关注的对象。</description></item>
        /// <item><description>可以使用复杂的过滤条件来进一步筛选结果，包括但不限于等于、不等于、大于、小于等逻辑操作符。</description></item>
        /// <item><description>如果没有配置主对象类型，则会返回一个空的结果集。</description></item>
        /// <item><description>请求中包含的数据将经过鉴权与过滤处理，确保安全性和准确性。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPrimaryObjectDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPrimaryObjectDataResponse
        /// </returns>
        public async Task<QueryPrimaryObjectDataResponse> QueryPrimaryObjectDataWithOptionsAsync(QueryPrimaryObjectDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyFavorites))
            {
                body["onlyFavorites"] = request.OnlyFavorites;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPrimaryObjectData",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/queryPrimaryObjectData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPrimaryObjectDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过运营对象名称分页查询主对象数据，支持过滤和搜索。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据给定的运营对象名称（如 <c>customer_1</c>）分页查询相关的主对象数据。</description></item>
        /// <item><description>支持通过关键字进行搜索，并且可以设置是否仅返回被标记为关注的对象。</description></item>
        /// <item><description>可以使用复杂的过滤条件来进一步筛选结果，包括但不限于等于、不等于、大于、小于等逻辑操作符。</description></item>
        /// <item><description>如果没有配置主对象类型，则会返回一个空的结果集。</description></item>
        /// <item><description>请求中包含的数据将经过鉴权与过滤处理，确保安全性和准确性。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPrimaryObjectDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPrimaryObjectDataResponse
        /// </returns>
        public QueryPrimaryObjectDataResponse QueryPrimaryObjectData(QueryPrimaryObjectDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryPrimaryObjectDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过运营对象名称分页查询主对象数据，支持过滤和搜索。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于根据给定的运营对象名称（如 <c>customer_1</c>）分页查询相关的主对象数据。</description></item>
        /// <item><description>支持通过关键字进行搜索，并且可以设置是否仅返回被标记为关注的对象。</description></item>
        /// <item><description>可以使用复杂的过滤条件来进一步筛选结果，包括但不限于等于、不等于、大于、小于等逻辑操作符。</description></item>
        /// <item><description>如果没有配置主对象类型，则会返回一个空的结果集。</description></item>
        /// <item><description>请求中包含的数据将经过鉴权与过滤处理，确保安全性和准确性。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPrimaryObjectDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPrimaryObjectDataResponse
        /// </returns>
        public async Task<QueryPrimaryObjectDataResponse> QueryPrimaryObjectDataAsync(QueryPrimaryObjectDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryPrimaryObjectDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与用户问题相关的语义知识</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅开放 smart-query 的 schema_knowledge 语义召回能力。
        ///     CLI 映射为 <c>winnexo semantic query</c>。<c>tenantId</c> 由公共参数传入，<c>userId</c>
        ///     仅从 Token 身份读取，禁止请求体覆盖。服务会校验 <c>graphName + agentName</c> 归属、
        ///     active graph、数字员工启用状态及当前用户 USE 权限；跨图同名 agent 会失败关闭，
        ///     随后固定 <c>outputs=[schema_knowledge]</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySemanticKnowledgeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySemanticKnowledgeResponse
        /// </returns>
        public QuerySemanticKnowledgeResponse QuerySemanticKnowledgeWithOptions(QuerySemanticKnowledgeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GraphName))
            {
                body["graphName"] = request.GraphName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySemanticKnowledge",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/querySemanticKnowledge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySemanticKnowledgeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与用户问题相关的语义知识</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅开放 smart-query 的 schema_knowledge 语义召回能力。
        ///     CLI 映射为 <c>winnexo semantic query</c>。<c>tenantId</c> 由公共参数传入，<c>userId</c>
        ///     仅从 Token 身份读取，禁止请求体覆盖。服务会校验 <c>graphName + agentName</c> 归属、
        ///     active graph、数字员工启用状态及当前用户 USE 权限；跨图同名 agent 会失败关闭，
        ///     随后固定 <c>outputs=[schema_knowledge]</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySemanticKnowledgeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySemanticKnowledgeResponse
        /// </returns>
        public async Task<QuerySemanticKnowledgeResponse> QuerySemanticKnowledgeWithOptionsAsync(QuerySemanticKnowledgeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GraphName))
            {
                body["graphName"] = request.GraphName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySemanticKnowledge",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/querySemanticKnowledge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySemanticKnowledgeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与用户问题相关的语义知识</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅开放 smart-query 的 schema_knowledge 语义召回能力。
        ///     CLI 映射为 <c>winnexo semantic query</c>。<c>tenantId</c> 由公共参数传入，<c>userId</c>
        ///     仅从 Token 身份读取，禁止请求体覆盖。服务会校验 <c>graphName + agentName</c> 归属、
        ///     active graph、数字员工启用状态及当前用户 USE 权限；跨图同名 agent 会失败关闭，
        ///     随后固定 <c>outputs=[schema_knowledge]</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySemanticKnowledgeRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySemanticKnowledgeResponse
        /// </returns>
        public QuerySemanticKnowledgeResponse QuerySemanticKnowledge(QuerySemanticKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySemanticKnowledgeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询与用户问题相关的语义知识</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>仅开放 smart-query 的 schema_knowledge 语义召回能力。
        ///     CLI 映射为 <c>winnexo semantic query</c>。<c>tenantId</c> 由公共参数传入，<c>userId</c>
        ///     仅从 Token 身份读取，禁止请求体覆盖。服务会校验 <c>graphName + agentName</c> 归属、
        ///     active graph、数字员工启用状态及当前用户 USE 权限；跨图同名 agent 会失败关闭，
        ///     随后固定 <c>outputs=[schema_knowledge]</c>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySemanticKnowledgeRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySemanticKnowledgeResponse
        /// </returns>
        public async Task<QuerySemanticKnowledgeResponse> QuerySemanticKnowledgeAsync(QuerySemanticKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySemanticKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织同步结果</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据 taskId 查询组织同步任务的执行状态和结果。
        ///     任务状态流转：PENDING → RUNNING → COMPLETED / FAILED / TIMEOUT / CANCELED
        ///     建议客户端轮询间隔：3-5 秒。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySyncResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncResultResponse
        /// </returns>
        public QuerySyncResultResponse QuerySyncResultWithOptions(QuerySyncResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySyncResult",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/querySyncResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织同步结果</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据 taskId 查询组织同步任务的执行状态和结果。
        ///     任务状态流转：PENDING → RUNNING → COMPLETED / FAILED / TIMEOUT / CANCELED
        ///     建议客户端轮询间隔：3-5 秒。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySyncResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncResultResponse
        /// </returns>
        public async Task<QuerySyncResultResponse> QuerySyncResultWithOptionsAsync(QuerySyncResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySyncResult",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/querySyncResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织同步结果</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据 taskId 查询组织同步任务的执行状态和结果。
        ///     任务状态流转：PENDING → RUNNING → COMPLETED / FAILED / TIMEOUT / CANCELED
        ///     建议客户端轮询间隔：3-5 秒。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncResultResponse
        /// </returns>
        public QuerySyncResultResponse QuerySyncResult(QuerySyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySyncResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织同步结果</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据 taskId 查询组织同步任务的执行状态和结果。
        ///     任务状态流转：PENDING → RUNNING → COMPLETED / FAILED / TIMEOUT / CANCELED
        ///     建议客户端轮询间隔：3-5 秒。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncResultResponse
        /// </returns>
        public async Task<QuerySyncResultResponse> QuerySyncResultAsync(QuerySyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySyncResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从租户移除用户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 从租户移除用户。
        ///     业务编排：
        ///     1. 从 identity 获取 tenant_id
        ///     2. 调用 delete_user_from_tenant（内部含最后超管保护）
        ///     3. 返回成功
        ///     该操作会：
        ///     - 移除用户在租户下的所有角色关联
        ///     - 移除用户在租户下的所有用户组关联
        ///     - 撤销用户在租户下的全部数字员工使用授权
        ///     - 删除用户-租户映射</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserResponse
        /// </returns>
        public RemoveUserResponse RemoveUserWithOptions(RemoveUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                query["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/removeUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从租户移除用户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 从租户移除用户。
        ///     业务编排：
        ///     1. 从 identity 获取 tenant_id
        ///     2. 调用 delete_user_from_tenant（内部含最后超管保护）
        ///     3. 返回成功
        ///     该操作会：
        ///     - 移除用户在租户下的所有角色关联
        ///     - 移除用户在租户下的所有用户组关联
        ///     - 撤销用户在租户下的全部数字员工使用授权
        ///     - 删除用户-租户映射</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserResponse
        /// </returns>
        public async Task<RemoveUserResponse> RemoveUserWithOptionsAsync(RemoveUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                query["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/removeUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从租户移除用户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 从租户移除用户。
        ///     业务编排：
        ///     1. 从 identity 获取 tenant_id
        ///     2. 调用 delete_user_from_tenant（内部含最后超管保护）
        ///     3. 返回成功
        ///     该操作会：
        ///     - 移除用户在租户下的所有角色关联
        ///     - 移除用户在租户下的所有用户组关联
        ///     - 撤销用户在租户下的全部数字员工使用授权
        ///     - 删除用户-租户映射</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserResponse
        /// </returns>
        public RemoveUserResponse RemoveUser(RemoveUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从租户移除用户</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 从租户移除用户。
        ///     业务编排：
        ///     1. 从 identity 获取 tenant_id
        ///     2. 调用 delete_user_from_tenant（内部含最后超管保护）
        ///     3. 返回成功
        ///     该操作会：
        ///     - 移除用户在租户下的所有角色关联
        ///     - 移除用户在租户下的所有用户组关联
        ///     - 撤销用户在租户下的全部数字员工使用授权
        ///     - 删除用户-租户映射</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserResponse
        /// </returns>
        public async Task<RemoveUserResponse> RemoveUserAsync(RemoveUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定企业知识库内数据源的名称。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有相应权限的用户修改企业知识库中的特定数据源名称。</description></item>
        /// <item><description>需要提供待修改的数据源ID(<c>sourceId</c>)及新的名称(<c>newName</c>)。</description></item>
        /// <item><description>修改操作仅更新数据源的名字字段，不会触发其他处理流程。</description></item>
        /// <item><description>成功执行后，系统会发布<c>SOURCE_CHANGED</c>事件以供前端刷新显示，并尝试通知DocumentAgent同步最新的source_name信息，但此步骤失败不会影响主流程的完成状态。</description></item>
        /// <item><description>如果提供的<c>sourceId</c>不存在，则返回错误码<c>ERR.Robject.Source.NotFound</c>。</description></item>
        /// <item><description>此API调用需具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description>支持通过AK、BearerToken或APP方式进行身份验证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameKnowledgeBaseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameKnowledgeBaseSourceResponse
        /// </returns>
        public RenameKnowledgeBaseSourceResponse RenameKnowledgeBaseSourceWithOptions(RenameKnowledgeBaseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                body["newName"] = request.NewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameKnowledgeBaseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/renameKnowledgeBaseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameKnowledgeBaseSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定企业知识库内数据源的名称。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有相应权限的用户修改企业知识库中的特定数据源名称。</description></item>
        /// <item><description>需要提供待修改的数据源ID(<c>sourceId</c>)及新的名称(<c>newName</c>)。</description></item>
        /// <item><description>修改操作仅更新数据源的名字字段，不会触发其他处理流程。</description></item>
        /// <item><description>成功执行后，系统会发布<c>SOURCE_CHANGED</c>事件以供前端刷新显示，并尝试通知DocumentAgent同步最新的source_name信息，但此步骤失败不会影响主流程的完成状态。</description></item>
        /// <item><description>如果提供的<c>sourceId</c>不存在，则返回错误码<c>ERR.Robject.Source.NotFound</c>。</description></item>
        /// <item><description>此API调用需具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description>支持通过AK、BearerToken或APP方式进行身份验证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameKnowledgeBaseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameKnowledgeBaseSourceResponse
        /// </returns>
        public async Task<RenameKnowledgeBaseSourceResponse> RenameKnowledgeBaseSourceWithOptionsAsync(RenameKnowledgeBaseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                body["newName"] = request.NewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameKnowledgeBaseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/renameKnowledgeBaseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameKnowledgeBaseSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定企业知识库内数据源的名称。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有相应权限的用户修改企业知识库中的特定数据源名称。</description></item>
        /// <item><description>需要提供待修改的数据源ID(<c>sourceId</c>)及新的名称(<c>newName</c>)。</description></item>
        /// <item><description>修改操作仅更新数据源的名字字段，不会触发其他处理流程。</description></item>
        /// <item><description>成功执行后，系统会发布<c>SOURCE_CHANGED</c>事件以供前端刷新显示，并尝试通知DocumentAgent同步最新的source_name信息，但此步骤失败不会影响主流程的完成状态。</description></item>
        /// <item><description>如果提供的<c>sourceId</c>不存在，则返回错误码<c>ERR.Robject.Source.NotFound</c>。</description></item>
        /// <item><description>此API调用需具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description>支持通过AK、BearerToken或APP方式进行身份验证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameKnowledgeBaseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameKnowledgeBaseSourceResponse
        /// </returns>
        public RenameKnowledgeBaseSourceResponse RenameKnowledgeBaseSource(RenameKnowledgeBaseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenameKnowledgeBaseSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定企业知识库内数据源的名称。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口允许具有相应权限的用户修改企业知识库中的特定数据源名称。</description></item>
        /// <item><description>需要提供待修改的数据源ID(<c>sourceId</c>)及新的名称(<c>newName</c>)。</description></item>
        /// <item><description>修改操作仅更新数据源的名字字段，不会触发其他处理流程。</description></item>
        /// <item><description>成功执行后，系统会发布<c>SOURCE_CHANGED</c>事件以供前端刷新显示，并尝试通知DocumentAgent同步最新的source_name信息，但此步骤失败不会影响主流程的完成状态。</description></item>
        /// <item><description>如果提供的<c>sourceId</c>不存在，则返回错误码<c>ERR.Robject.Source.NotFound</c>。</description></item>
        /// <item><description>此API调用需具备<c>DEVELOPMENT_KB_MANAGE</c>功能权限。</description></item>
        /// <item><description>支持通过AK、BearerToken或APP方式进行身份验证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameKnowledgeBaseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameKnowledgeBaseSourceResponse
        /// </returns>
        public async Task<RenameKnowledgeBaseSourceResponse> RenameKnowledgeBaseSourceAsync(RenameKnowledgeBaseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenameKnowledgeBaseSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定数据源的名称，支持轻量级操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 仅更新数据源的 <c>name</c> 字段，不会触发 <c>process_source</c>。</description></item>
        /// <item><description>成功后会发布 <c>SOURCE_CHANGED</c> 事件供前端刷新显示。</description></item>
        /// <item><description>将尽力通知 DocumentAgent 同步新的 <c>source_name</c>，即使同步失败也不会阻断主流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则抛出 <c>ERR.Robject.Source.NotFound</c> 错误，并由全局中间件统一转换为 POP 错误码。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameSourceResponse
        /// </returns>
        public RenameSourceResponse RenameSourceWithOptions(RenameSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                body["newName"] = request.NewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/renameSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定数据源的名称，支持轻量级操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 仅更新数据源的 <c>name</c> 字段，不会触发 <c>process_source</c>。</description></item>
        /// <item><description>成功后会发布 <c>SOURCE_CHANGED</c> 事件供前端刷新显示。</description></item>
        /// <item><description>将尽力通知 DocumentAgent 同步新的 <c>source_name</c>，即使同步失败也不会阻断主流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则抛出 <c>ERR.Robject.Source.NotFound</c> 错误，并由全局中间件统一转换为 POP 错误码。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameSourceResponse
        /// </returns>
        public async Task<RenameSourceResponse> RenameSourceWithOptionsAsync(RenameSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                body["newName"] = request.NewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/renameSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定数据源的名称，支持轻量级操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 仅更新数据源的 <c>name</c> 字段，不会触发 <c>process_source</c>。</description></item>
        /// <item><description>成功后会发布 <c>SOURCE_CHANGED</c> 事件供前端刷新显示。</description></item>
        /// <item><description>将尽力通知 DocumentAgent 同步新的 <c>source_name</c>，即使同步失败也不会阻断主流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则抛出 <c>ERR.Robject.Source.NotFound</c> 错误，并由全局中间件统一转换为 POP 错误码。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameSourceResponse
        /// </returns>
        public RenameSourceResponse RenameSource(RenameSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenameSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更改指定数据源的名称，支持轻量级操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 仅更新数据源的 <c>name</c> 字段，不会触发 <c>process_source</c>。</description></item>
        /// <item><description>成功后会发布 <c>SOURCE_CHANGED</c> 事件供前端刷新显示。</description></item>
        /// <item><description>将尽力通知 DocumentAgent 同步新的 <c>source_name</c>，即使同步失败也不会阻断主流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则抛出 <c>ERR.Robject.Source.NotFound</c> 错误，并由全局中间件统一转换为 POP 错误码。</description></item>
        /// <item><description>安全约束：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameSourceResponse
        /// </returns>
        public async Task<RenameSourceResponse> RenameSourceAsync(RenameSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenameSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新解析当前租户内的指定数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于重新解析指定的数据源，支持同步或异步执行。请求时需提供数据源 ID，并可选择是否同步等待解析完成，默认为异步入队处理。此外，可以通过 <c>tenantId</c> 参数指定租户ID，但此参数非必填。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b>：若设置为 <c>true</c>，则会同步等待重新解析操作完成；默认值为 <c>false</c>，表示以异步方式处理请求。</description></item>
        /// <item><description>当服务返回 <c>None</c> 时，将被转换成 <c>SourceNotFound</c> 异常；其他异常情况将由 OpenAPI 的全局异常链进行处理。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReparseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReparseSourceResponse
        /// </returns>
        public ReparseSourceResponse ReparseSourceWithOptions(ReparseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReparseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/reparseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReparseSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新解析当前租户内的指定数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于重新解析指定的数据源，支持同步或异步执行。请求时需提供数据源 ID，并可选择是否同步等待解析完成，默认为异步入队处理。此外，可以通过 <c>tenantId</c> 参数指定租户ID，但此参数非必填。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b>：若设置为 <c>true</c>，则会同步等待重新解析操作完成；默认值为 <c>false</c>，表示以异步方式处理请求。</description></item>
        /// <item><description>当服务返回 <c>None</c> 时，将被转换成 <c>SourceNotFound</c> 异常；其他异常情况将由 OpenAPI 的全局异常链进行处理。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReparseSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReparseSourceResponse
        /// </returns>
        public async Task<ReparseSourceResponse> ReparseSourceWithOptionsAsync(ReparseSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReparseSource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/reparseSource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReparseSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新解析当前租户内的指定数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于重新解析指定的数据源，支持同步或异步执行。请求时需提供数据源 ID，并可选择是否同步等待解析完成，默认为异步入队处理。此外，可以通过 <c>tenantId</c> 参数指定租户ID，但此参数非必填。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b>：若设置为 <c>true</c>，则会同步等待重新解析操作完成；默认值为 <c>false</c>，表示以异步方式处理请求。</description></item>
        /// <item><description>当服务返回 <c>None</c> 时，将被转换成 <c>SourceNotFound</c> 异常；其他异常情况将由 OpenAPI 的全局异常链进行处理。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReparseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReparseSourceResponse
        /// </returns>
        public ReparseSourceResponse ReparseSource(ReparseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReparseSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新解析当前租户内的指定数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于重新解析指定的数据源，支持同步或异步执行。请求时需提供数据源 ID，并可选择是否同步等待解析完成，默认为异步入队处理。此外，可以通过 <c>tenantId</c> 参数指定租户ID，但此参数非必填。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b>：若设置为 <c>true</c>，则会同步等待重新解析操作完成；默认值为 <c>false</c>，表示以异步方式处理请求。</description></item>
        /// <item><description>当服务返回 <c>None</c> 时，将被转换成 <c>SourceNotFound</c> 异常；其他异常情况将由 OpenAPI 的全局异常链进行处理。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReparseSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReparseSourceResponse
        /// </returns>
        public async Task<ReparseSourceResponse> ReparseSourceAsync(ReparseSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReparseSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于替换指定的企业知识库中的FILE资源并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许用户更新企业自建知识库中特定的FILE类型的数据源，并通过提供新的文件路径和公开访问URL来触发系统对该数据源的重新解析。支持同步或异步模式下的操作执行，其中同步模式下客户端将等待直到解析过程完成。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b> 参数控制是否采用同步方式处理请求，默认为 <c>false</c>，即以异步方式进行。</description></item>
        /// <item><description>当不提供 <b>fileName</b> 或其值为空时，新上传的文件将保留原有的文件名。</description></item>
        /// <item><description>必须确保提供的 <b>filePath</b> 和 <b>filePublicUrl</b> 是有效的且指向同一个文件实体。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceKnowledgeBaseSourceFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceKnowledgeBaseSourceFileResponse
        /// </returns>
        public ReplaceKnowledgeBaseSourceFileResponse ReplaceKnowledgeBaseSourceFileWithOptions(ReplaceKnowledgeBaseSourceFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceKnowledgeBaseSourceFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/replaceKnowledgeBaseSourceFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceKnowledgeBaseSourceFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于替换指定的企业知识库中的FILE资源并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许用户更新企业自建知识库中特定的FILE类型的数据源，并通过提供新的文件路径和公开访问URL来触发系统对该数据源的重新解析。支持同步或异步模式下的操作执行，其中同步模式下客户端将等待直到解析过程完成。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b> 参数控制是否采用同步方式处理请求，默认为 <c>false</c>，即以异步方式进行。</description></item>
        /// <item><description>当不提供 <b>fileName</b> 或其值为空时，新上传的文件将保留原有的文件名。</description></item>
        /// <item><description>必须确保提供的 <b>filePath</b> 和 <b>filePublicUrl</b> 是有效的且指向同一个文件实体。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceKnowledgeBaseSourceFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceKnowledgeBaseSourceFileResponse
        /// </returns>
        public async Task<ReplaceKnowledgeBaseSourceFileResponse> ReplaceKnowledgeBaseSourceFileWithOptionsAsync(ReplaceKnowledgeBaseSourceFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceKnowledgeBaseSourceFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/replaceKnowledgeBaseSourceFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceKnowledgeBaseSourceFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于替换指定的企业知识库中的FILE资源并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许用户更新企业自建知识库中特定的FILE类型的数据源，并通过提供新的文件路径和公开访问URL来触发系统对该数据源的重新解析。支持同步或异步模式下的操作执行，其中同步模式下客户端将等待直到解析过程完成。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b> 参数控制是否采用同步方式处理请求，默认为 <c>false</c>，即以异步方式进行。</description></item>
        /// <item><description>当不提供 <b>fileName</b> 或其值为空时，新上传的文件将保留原有的文件名。</description></item>
        /// <item><description>必须确保提供的 <b>filePath</b> 和 <b>filePublicUrl</b> 是有效的且指向同一个文件实体。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceKnowledgeBaseSourceFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceKnowledgeBaseSourceFileResponse
        /// </returns>
        public ReplaceKnowledgeBaseSourceFileResponse ReplaceKnowledgeBaseSourceFile(ReplaceKnowledgeBaseSourceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReplaceKnowledgeBaseSourceFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于替换指定的企业知识库中的FILE资源并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API允许用户更新企业自建知识库中特定的FILE类型的数据源，并通过提供新的文件路径和公开访问URL来触发系统对该数据源的重新解析。支持同步或异步模式下的操作执行，其中同步模式下客户端将等待直到解析过程完成。</para>
        /// <list type="bullet">
        /// <item><description><b>forceSync</b> 参数控制是否采用同步方式处理请求，默认为 <c>false</c>，即以异步方式进行。</description></item>
        /// <item><description>当不提供 <b>fileName</b> 或其值为空时，新上传的文件将保留原有的文件名。</description></item>
        /// <item><description>必须确保提供的 <b>filePath</b> 和 <b>filePublicUrl</b> 是有效的且指向同一个文件实体。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceKnowledgeBaseSourceFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceKnowledgeBaseSourceFileResponse
        /// </returns>
        public async Task<ReplaceKnowledgeBaseSourceFileResponse> ReplaceKnowledgeBaseSourceFileAsync(ReplaceKnowledgeBaseSourceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReplaceKnowledgeBaseSourceFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于全量替换指定数据源下的对象绑定信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于全量替换特定数据源的对象绑定（先删除现有绑定，再插入新的绑定）。如果传入空列表，则表示清空所有绑定。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description><b>错误处理</b>：若指定的数据源不存在，将抛出 <c>ERR.Robject.InvalidParameter</c> 错误，并由全局中间件转换为 POP 错误码。</description></item>
        /// <item><description><b>同步通知</b>：替换成功后会尽力同步通知 DocumentAgent 更新 <c>semantics.object_bindings</c>，但失败仅记录日志，不会阻断主流程。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ReplaceObjectBindingsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceObjectBindingsResponse
        /// </returns>
        public ReplaceObjectBindingsResponse ReplaceObjectBindingsWithOptions(ReplaceObjectBindingsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReplaceObjectBindingsShrinkRequest request = new ReplaceObjectBindingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectBindings))
            {
                request.ObjectBindingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectBindings, "objectBindings", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectBindingsShrink))
            {
                body["objectBindings"] = request.ObjectBindingsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceObjectBindings",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/replaceObjectBindings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceObjectBindingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于全量替换指定数据源下的对象绑定信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于全量替换特定数据源的对象绑定（先删除现有绑定，再插入新的绑定）。如果传入空列表，则表示清空所有绑定。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description><b>错误处理</b>：若指定的数据源不存在，将抛出 <c>ERR.Robject.InvalidParameter</c> 错误，并由全局中间件转换为 POP 错误码。</description></item>
        /// <item><description><b>同步通知</b>：替换成功后会尽力同步通知 DocumentAgent 更新 <c>semantics.object_bindings</c>，但失败仅记录日志，不会阻断主流程。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ReplaceObjectBindingsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceObjectBindingsResponse
        /// </returns>
        public async Task<ReplaceObjectBindingsResponse> ReplaceObjectBindingsWithOptionsAsync(ReplaceObjectBindingsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReplaceObjectBindingsShrinkRequest request = new ReplaceObjectBindingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectBindings))
            {
                request.ObjectBindingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectBindings, "objectBindings", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectBindingsShrink))
            {
                body["objectBindings"] = request.ObjectBindingsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceObjectBindings",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/replaceObjectBindings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceObjectBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于全量替换指定数据源下的对象绑定信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于全量替换特定数据源的对象绑定（先删除现有绑定，再插入新的绑定）。如果传入空列表，则表示清空所有绑定。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description><b>错误处理</b>：若指定的数据源不存在，将抛出 <c>ERR.Robject.InvalidParameter</c> 错误，并由全局中间件转换为 POP 错误码。</description></item>
        /// <item><description><b>同步通知</b>：替换成功后会尽力同步通知 DocumentAgent 更新 <c>semantics.object_bindings</c>，但失败仅记录日志，不会阻断主流程。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceObjectBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceObjectBindingsResponse
        /// </returns>
        public ReplaceObjectBindingsResponse ReplaceObjectBindings(ReplaceObjectBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReplaceObjectBindingsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于全量替换指定数据源下的对象绑定信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于全量替换特定数据源的对象绑定（先删除现有绑定，再插入新的绑定）。如果传入空列表，则表示清空所有绑定。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自鉴权身份。</description></item>
        /// <item><description><b>错误处理</b>：若指定的数据源不存在，将抛出 <c>ERR.Robject.InvalidParameter</c> 错误，并由全局中间件转换为 POP 错误码。</description></item>
        /// <item><description><b>同步通知</b>：替换成功后会尽力同步通知 DocumentAgent 更新 <c>semantics.object_bindings</c>，但失败仅记录日志，不会阻断主流程。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceObjectBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceObjectBindingsResponse
        /// </returns>
        public async Task<ReplaceObjectBindingsResponse> ReplaceObjectBindingsAsync(ReplaceObjectBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReplaceObjectBindingsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户替换其创建的个人文件资源，并触发系统重新解析该文件。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>此 API 用于替换当前平台用户创建的个人 FILE 资源，并触发系统对该文件的重新解析。</description></item>
        /// <item><description><c>tenant_id</c>、操作人和创建者约束只读取鉴权身份。缺少平台用户时请求将被拒绝，以防止绕过所有权校验。</description></item>
        /// <item><description>如果服务端返回 <c>None</c>，则会被转换为 <c>NotFound</c> 异常；其他异常由 OpenAPI 全局异常链处理。</description></item>
        /// <item><description>该接口支持同步或异步等待重新解析完成，默认为异步入队（通过设置 <c>forceSync</c> 参数控制）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceSourceFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceSourceFileResponse
        /// </returns>
        public ReplaceSourceFileResponse ReplaceSourceFileWithOptions(ReplaceSourceFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceSourceFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/replaceSourceFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceSourceFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户替换其创建的个人文件资源，并触发系统重新解析该文件。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>此 API 用于替换当前平台用户创建的个人 FILE 资源，并触发系统对该文件的重新解析。</description></item>
        /// <item><description><c>tenant_id</c>、操作人和创建者约束只读取鉴权身份。缺少平台用户时请求将被拒绝，以防止绕过所有权校验。</description></item>
        /// <item><description>如果服务端返回 <c>None</c>，则会被转换为 <c>NotFound</c> 异常；其他异常由 OpenAPI 全局异常链处理。</description></item>
        /// <item><description>该接口支持同步或异步等待重新解析完成，默认为异步入队（通过设置 <c>forceSync</c> 参数控制）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceSourceFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceSourceFileResponse
        /// </returns>
        public async Task<ReplaceSourceFileResponse> ReplaceSourceFileWithOptionsAsync(ReplaceSourceFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePublicUrl))
            {
                body["filePublicUrl"] = request.FilePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileRecordId))
            {
                body["fileRecordId"] = request.FileRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceSourceFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/replaceSourceFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceSourceFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户替换其创建的个人文件资源，并触发系统重新解析该文件。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>此 API 用于替换当前平台用户创建的个人 FILE 资源，并触发系统对该文件的重新解析。</description></item>
        /// <item><description><c>tenant_id</c>、操作人和创建者约束只读取鉴权身份。缺少平台用户时请求将被拒绝，以防止绕过所有权校验。</description></item>
        /// <item><description>如果服务端返回 <c>None</c>，则会被转换为 <c>NotFound</c> 异常；其他异常由 OpenAPI 全局异常链处理。</description></item>
        /// <item><description>该接口支持同步或异步等待重新解析完成，默认为异步入队（通过设置 <c>forceSync</c> 参数控制）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceSourceFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceSourceFileResponse
        /// </returns>
        public ReplaceSourceFileResponse ReplaceSourceFile(ReplaceSourceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReplaceSourceFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>允许用户替换其创建的个人文件资源，并触发系统重新解析该文件。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>此 API 用于替换当前平台用户创建的个人 FILE 资源，并触发系统对该文件的重新解析。</description></item>
        /// <item><description><c>tenant_id</c>、操作人和创建者约束只读取鉴权身份。缺少平台用户时请求将被拒绝，以防止绕过所有权校验。</description></item>
        /// <item><description>如果服务端返回 <c>None</c>，则会被转换为 <c>NotFound</c> 异常；其他异常由 OpenAPI 全局异常链处理。</description></item>
        /// <item><description>该接口支持同步或异步等待重新解析完成，默认为异步入队（通过设置 <c>forceSync</c> 参数控制）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplaceSourceFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceSourceFileResponse
        /// </returns>
        public async Task<ReplaceSourceFileResponse> ReplaceSourceFileAsync(ReplaceSourceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReplaceSourceFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 重置用户密码。
        ///     业务编排：
        ///     1. 调用 UserManagementService.reset_member_password 传入 password_encrypted（必填）
        ///        → service 内部完成 RSA 解密 + 复杂度校验 + bcrypt hash + 写入
        ///     2. 返回重置结果
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下
        ///     - ERR.User.WinnexoPasswordRequired: 用户无密码凭证（非 WINNEXO 类型）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public ResetPasswordResponse ResetPasswordWithOptions(ResetPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordEncrypted))
            {
                body["passwordEncrypted"] = request.PasswordEncrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetPassword",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/resetPassword",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 重置用户密码。
        ///     业务编排：
        ///     1. 调用 UserManagementService.reset_member_password 传入 password_encrypted（必填）
        ///        → service 内部完成 RSA 解密 + 复杂度校验 + bcrypt hash + 写入
        ///     2. 返回重置结果
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下
        ///     - ERR.User.WinnexoPasswordRequired: 用户无密码凭证（非 WINNEXO 类型）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public async Task<ResetPasswordResponse> ResetPasswordWithOptionsAsync(ResetPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordEncrypted))
            {
                body["passwordEncrypted"] = request.PasswordEncrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetPassword",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/resetPassword",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 重置用户密码。
        ///     业务编排：
        ///     1. 调用 UserManagementService.reset_member_password 传入 password_encrypted（必填）
        ///        → service 内部完成 RSA 解密 + 复杂度校验 + bcrypt hash + 写入
        ///     2. 返回重置结果
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下
        ///     - ERR.User.WinnexoPasswordRequired: 用户无密码凭证（非 WINNEXO 类型）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResetPasswordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 重置用户密码。
        ///     业务编排：
        ///     1. 调用 UserManagementService.reset_member_password 传入 password_encrypted（必填）
        ///        → service 内部完成 RSA 解密 + 复杂度校验 + bcrypt hash + 写入
        ///     2. 返回重置结果
        ///     错误码：
        ///     - ERR.User.NotFound: 用户不存在
        ///     - ERR.User.NotInTenant: 用户不在当前租户下
        ///     - ERR.User.WinnexoPasswordRequired: 用户无密码凭证（非 WINNEXO 类型）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetPasswordResponse
        /// </returns>
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResetPasswordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重置用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 reset_token：
        ///        - 旧 ACTIVE Token → RESET（永久失效）
        ///        - 生成新 ACTIVE Token
        ///     4. 返回新 Token 明文 + 脱敏值
        ///     注意：重置后旧 Token 永久失效且不可恢复。新 Token 明文仅在本次响应中返回。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetTokenResponse
        /// </returns>
        public ResetTokenResponse ResetTokenWithOptions(ResetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetToken",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/resetToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重置用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 reset_token：
        ///        - 旧 ACTIVE Token → RESET（永久失效）
        ///        - 生成新 ACTIVE Token
        ///     4. 返回新 Token 明文 + 脱敏值
        ///     注意：重置后旧 Token 永久失效且不可恢复。新 Token 明文仅在本次响应中返回。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetTokenResponse
        /// </returns>
        public async Task<ResetTokenResponse> ResetTokenWithOptionsAsync(ResetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetToken",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/resetToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重置用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 reset_token：
        ///        - 旧 ACTIVE Token → RESET（永久失效）
        ///        - 生成新 ACTIVE Token
        ///     4. 返回新 Token 明文 + 脱敏值
        ///     注意：重置后旧 Token 永久失效且不可恢复。新 Token 明文仅在本次响应中返回。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetTokenResponse
        /// </returns>
        public ResetTokenResponse ResetToken(ResetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResetTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置 API Token</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>重置用户的 INSTANCE Token。
        ///     业务逻辑：
        ///     1. 从 identity 取 user_id（强制 caller_type=user）
        ///     2. 构造 AuthContext，委托 UserTokenAuthorizedService 完成权限校验
        ///     3. 调用 reset_token：
        ///        - 旧 ACTIVE Token → RESET（永久失效）
        ///        - 生成新 ACTIVE Token
        ///     4. 返回新 Token 明文 + 脱敏值
        ///     注意：重置后旧 Token 永久失效且不可恢复。新 Token 明文仅在本次响应中返回。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetTokenResponse
        /// </returns>
        public async Task<ResetTokenResponse> ResetTokenAsync(ResetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResetTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录及其子目录下的所有失败数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定用户个人目录（包括其所有子目录）中状态为FAILED的数据源。请求将立即返回，实际的重试任务将在后台异步执行。请注意，只有当前登录用户有权访问且属于其创建的资源才能被重试。</para>
        /// <h3>安全与权限</h3>
        /// <list type="bullet">
        /// <item><description>此操作需要适当的RAM权限。</description></item>
        /// <item><description>只能对当前用户所属租户内的资源进行操作。</description></item>
        /// <item><description>确保<c>tenantId</c>和<c>userId</c>来自经过验证的身份信息。</description></item>
        /// </list>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>directoryId</c>是必需参数，指定了要检查和重试失败数据源的目标目录。</description></item>
        /// <item><description>如果没有提供<c>tenantId</c>，则默认使用调用方的租户ID。</description></item>
        /// <item><description>API支持多种认证方式，包括AK、BearerToken以及APP认证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryDirectoryFailedSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryDirectoryFailedSourcesResponse
        /// </returns>
        public RetryDirectoryFailedSourcesResponse RetryDirectoryFailedSourcesWithOptions(RetryDirectoryFailedSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryDirectoryFailedSources",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/retryDirectoryFailedSources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryDirectoryFailedSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录及其子目录下的所有失败数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定用户个人目录（包括其所有子目录）中状态为FAILED的数据源。请求将立即返回，实际的重试任务将在后台异步执行。请注意，只有当前登录用户有权访问且属于其创建的资源才能被重试。</para>
        /// <h3>安全与权限</h3>
        /// <list type="bullet">
        /// <item><description>此操作需要适当的RAM权限。</description></item>
        /// <item><description>只能对当前用户所属租户内的资源进行操作。</description></item>
        /// <item><description>确保<c>tenantId</c>和<c>userId</c>来自经过验证的身份信息。</description></item>
        /// </list>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>directoryId</c>是必需参数，指定了要检查和重试失败数据源的目标目录。</description></item>
        /// <item><description>如果没有提供<c>tenantId</c>，则默认使用调用方的租户ID。</description></item>
        /// <item><description>API支持多种认证方式，包括AK、BearerToken以及APP认证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryDirectoryFailedSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryDirectoryFailedSourcesResponse
        /// </returns>
        public async Task<RetryDirectoryFailedSourcesResponse> RetryDirectoryFailedSourcesWithOptionsAsync(RetryDirectoryFailedSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryDirectoryFailedSources",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/retryDirectoryFailedSources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryDirectoryFailedSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录及其子目录下的所有失败数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定用户个人目录（包括其所有子目录）中状态为FAILED的数据源。请求将立即返回，实际的重试任务将在后台异步执行。请注意，只有当前登录用户有权访问且属于其创建的资源才能被重试。</para>
        /// <h3>安全与权限</h3>
        /// <list type="bullet">
        /// <item><description>此操作需要适当的RAM权限。</description></item>
        /// <item><description>只能对当前用户所属租户内的资源进行操作。</description></item>
        /// <item><description>确保<c>tenantId</c>和<c>userId</c>来自经过验证的身份信息。</description></item>
        /// </list>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>directoryId</c>是必需参数，指定了要检查和重试失败数据源的目标目录。</description></item>
        /// <item><description>如果没有提供<c>tenantId</c>，则默认使用调用方的租户ID。</description></item>
        /// <item><description>API支持多种认证方式，包括AK、BearerToken以及APP认证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryDirectoryFailedSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryDirectoryFailedSourcesResponse
        /// </returns>
        public RetryDirectoryFailedSourcesResponse RetryDirectoryFailedSources(RetryDirectoryFailedSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryDirectoryFailedSourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录及其子目录下的所有失败数据源。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定用户个人目录（包括其所有子目录）中状态为FAILED的数据源。请求将立即返回，实际的重试任务将在后台异步执行。请注意，只有当前登录用户有权访问且属于其创建的资源才能被重试。</para>
        /// <h3>安全与权限</h3>
        /// <list type="bullet">
        /// <item><description>此操作需要适当的RAM权限。</description></item>
        /// <item><description>只能对当前用户所属租户内的资源进行操作。</description></item>
        /// <item><description>确保<c>tenantId</c>和<c>userId</c>来自经过验证的身份信息。</description></item>
        /// </list>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>directoryId</c>是必需参数，指定了要检查和重试失败数据源的目标目录。</description></item>
        /// <item><description>如果没有提供<c>tenantId</c>，则默认使用调用方的租户ID。</description></item>
        /// <item><description>API支持多种认证方式，包括AK、BearerToken以及APP认证。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryDirectoryFailedSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryDirectoryFailedSourcesResponse
        /// </returns>
        public async Task<RetryDirectoryFailedSourcesResponse> RetryDirectoryFailedSourcesAsync(RetryDirectoryFailedSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryDirectoryFailedSourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录下所有失败状态的数据源</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定企业知识库目录（包括其子目录）下的所有处于FAILED状态的数据源。请求将立即返回，实际的重试操作将在后台异步执行。</para>
        /// <list type="bullet">
        /// <item><description><b>鉴权</b>：除了基础鉴权外，还需具备<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// <item><description><b>安全约束</b>：仅允许具有相应租户和用户身份的调用者访问，并且需要KB管理权限；管理员可以对任何用户的失败资源发起重试。</description></item>
        /// <item><description><b>参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c> (必填)：指定要检查和重试失败数据源的企业知识库目录ID。</description></item>
        /// <item><description><c>tenantId</c> (可选)：指定租户ID，默认使用调用方的默认租户。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>响应</b>：成功时返回已入队等待重试的数据源数量及详情等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryKnowledgeBaseFailedSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryKnowledgeBaseFailedSourcesResponse
        /// </returns>
        public RetryKnowledgeBaseFailedSourcesResponse RetryKnowledgeBaseFailedSourcesWithOptions(RetryKnowledgeBaseFailedSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryKnowledgeBaseFailedSources",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/retryKnowledgeBaseFailedSources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryKnowledgeBaseFailedSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录下所有失败状态的数据源</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定企业知识库目录（包括其子目录）下的所有处于FAILED状态的数据源。请求将立即返回，实际的重试操作将在后台异步执行。</para>
        /// <list type="bullet">
        /// <item><description><b>鉴权</b>：除了基础鉴权外，还需具备<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// <item><description><b>安全约束</b>：仅允许具有相应租户和用户身份的调用者访问，并且需要KB管理权限；管理员可以对任何用户的失败资源发起重试。</description></item>
        /// <item><description><b>参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c> (必填)：指定要检查和重试失败数据源的企业知识库目录ID。</description></item>
        /// <item><description><c>tenantId</c> (可选)：指定租户ID，默认使用调用方的默认租户。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>响应</b>：成功时返回已入队等待重试的数据源数量及详情等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryKnowledgeBaseFailedSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryKnowledgeBaseFailedSourcesResponse
        /// </returns>
        public async Task<RetryKnowledgeBaseFailedSourcesResponse> RetryKnowledgeBaseFailedSourcesWithOptionsAsync(RetryKnowledgeBaseFailedSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryKnowledgeBaseFailedSources",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/retryKnowledgeBaseFailedSources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryKnowledgeBaseFailedSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录下所有失败状态的数据源</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定企业知识库目录（包括其子目录）下的所有处于FAILED状态的数据源。请求将立即返回，实际的重试操作将在后台异步执行。</para>
        /// <list type="bullet">
        /// <item><description><b>鉴权</b>：除了基础鉴权外，还需具备<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// <item><description><b>安全约束</b>：仅允许具有相应租户和用户身份的调用者访问，并且需要KB管理权限；管理员可以对任何用户的失败资源发起重试。</description></item>
        /// <item><description><b>参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c> (必填)：指定要检查和重试失败数据源的企业知识库目录ID。</description></item>
        /// <item><description><c>tenantId</c> (可选)：指定租户ID，默认使用调用方的默认租户。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>响应</b>：成功时返回已入队等待重试的数据源数量及详情等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryKnowledgeBaseFailedSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryKnowledgeBaseFailedSourcesResponse
        /// </returns>
        public RetryKnowledgeBaseFailedSourcesResponse RetryKnowledgeBaseFailedSources(RetryKnowledgeBaseFailedSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryKnowledgeBaseFailedSourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量重试指定目录下所有失败状态的数据源</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该API用于获取并重试指定企业知识库目录（包括其子目录）下的所有处于FAILED状态的数据源。请求将立即返回，实际的重试操作将在后台异步执行。</para>
        /// <list type="bullet">
        /// <item><description><b>鉴权</b>：除了基础鉴权外，还需具备<c>DEVELOPMENT_KB_MANAGE</c>权限。</description></item>
        /// <item><description><b>安全约束</b>：仅允许具有相应租户和用户身份的调用者访问，并且需要KB管理权限；管理员可以对任何用户的失败资源发起重试。</description></item>
        /// <item><description><b>参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c> (必填)：指定要检查和重试失败数据源的企业知识库目录ID。</description></item>
        /// <item><description><c>tenantId</c> (可选)：指定租户ID，默认使用调用方的默认租户。</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>响应</b>：成功时返回已入队等待重试的数据源数量及详情等信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryKnowledgeBaseFailedSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryKnowledgeBaseFailedSourcesResponse
        /// </returns>
        public async Task<RetryKnowledgeBaseFailedSourcesResponse> RetryKnowledgeBaseFailedSourcesAsync(RetryKnowledgeBaseFailedSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryKnowledgeBaseFailedSourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销用户/用户组的数字员工使用权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>撤销用户或用户组对指定数字员工的使用权限。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.revoke_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 撤销用户直接授权后，用户可能仍通过用户组获得授权</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RevokeAgentUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeAgentUsersResponse
        /// </returns>
        public RevokeAgentUsersResponse RevokeAgentUsersWithOptions(RevokeAgentUsersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevokeAgentUsersShrinkRequest request = new RevokeAgentUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupIds))
            {
                request.UserGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupIds, "userGroupIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "userIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIdsShrink))
            {
                body["userGroupIds"] = request.UserGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdsShrink))
            {
                body["userIds"] = request.UserIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeAgentUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/revokeAgentUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeAgentUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销用户/用户组的数字员工使用权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>撤销用户或用户组对指定数字员工的使用权限。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.revoke_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 撤销用户直接授权后，用户可能仍通过用户组获得授权</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RevokeAgentUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeAgentUsersResponse
        /// </returns>
        public async Task<RevokeAgentUsersResponse> RevokeAgentUsersWithOptionsAsync(RevokeAgentUsersRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RevokeAgentUsersShrinkRequest request = new RevokeAgentUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupIds))
            {
                request.UserGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupIds, "userGroupIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "userIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIdsShrink))
            {
                body["userGroupIds"] = request.UserGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdsShrink))
            {
                body["userIds"] = request.UserIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeAgentUsers",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/revokeAgentUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeAgentUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销用户/用户组的数字员工使用权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>撤销用户或用户组对指定数字员工的使用权限。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.revoke_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 撤销用户直接授权后，用户可能仍通过用户组获得授权</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeAgentUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeAgentUsersResponse
        /// </returns>
        public RevokeAgentUsersResponse RevokeAgentUsers(RevokeAgentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeAgentUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销用户/用户组的数字员工使用权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>撤销用户或用户组对指定数字员工的使用权限。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 请求体互斥校验：userIds / userGroupIds 二选一
        ///     3. 委托 AgentAuthorizationAuthorizedService.revoke_authorization 执行
        ///     4. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     5. 撤销用户直接授权后，用户可能仍通过用户组获得授权</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeAgentUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeAgentUsersResponse
        /// </returns>
        public async Task<RevokeAgentUsersResponse> RevokeAgentUsersAsync(RevokeAgentUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeAgentUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步触发技能执行，立即返回 RunId。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口仅支持异步模式：提交后立即返回 <c>RunId</c> 和 <c>Status=Running</c>，客户端通过 <c>GetSkillRun</c> 轮询最终结果。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header。</description></item>
        /// <item><description><b>SkillCode</b> / <b>SkillName</b>：二选一；SkillCode 优先；SkillName 不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>Arguments</b>：必填，技能入参对象，结构由 <c>GetSkill</c> 返回的 inputConfig 描述。</description></item>
        /// <item><description><b>ClientToken</b>：可选幂等键；当前版本仅记录到任务元数据，不做强幂等去重。
        /// 注意：同步模式（Async=false）、Stream、CallbackUrl 一期不支持，将在后续版本提供。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RunSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSkillResponse
        /// </returns>
        public RunSkillResponse RunSkillWithOptions(RunSkillRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSkillShrinkRequest request = new RunSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Arguments))
            {
                request.ArgumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Arguments, "arguments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgumentsShrink))
            {
                body["arguments"] = request.ArgumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillCode))
            {
                body["skillCode"] = request.SkillCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSkill",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/runSkill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步触发技能执行，立即返回 RunId。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口仅支持异步模式：提交后立即返回 <c>RunId</c> 和 <c>Status=Running</c>，客户端通过 <c>GetSkillRun</c> 轮询最终结果。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header。</description></item>
        /// <item><description><b>SkillCode</b> / <b>SkillName</b>：二选一；SkillCode 优先；SkillName 不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>Arguments</b>：必填，技能入参对象，结构由 <c>GetSkill</c> 返回的 inputConfig 描述。</description></item>
        /// <item><description><b>ClientToken</b>：可选幂等键；当前版本仅记录到任务元数据，不做强幂等去重。
        /// 注意：同步模式（Async=false）、Stream、CallbackUrl 一期不支持，将在后续版本提供。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RunSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSkillResponse
        /// </returns>
        public async Task<RunSkillResponse> RunSkillWithOptionsAsync(RunSkillRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSkillShrinkRequest request = new RunSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Arguments))
            {
                request.ArgumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Arguments, "arguments", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgumentsShrink))
            {
                body["arguments"] = request.ArgumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillCode))
            {
                body["skillCode"] = request.SkillCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSkill",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/runSkill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步触发技能执行，立即返回 RunId。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口仅支持异步模式：提交后立即返回 <c>RunId</c> 和 <c>Status=Running</c>，客户端通过 <c>GetSkillRun</c> 轮询最终结果。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header。</description></item>
        /// <item><description><b>SkillCode</b> / <b>SkillName</b>：二选一；SkillCode 优先；SkillName 不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>Arguments</b>：必填，技能入参对象，结构由 <c>GetSkill</c> 返回的 inputConfig 描述。</description></item>
        /// <item><description><b>ClientToken</b>：可选幂等键；当前版本仅记录到任务元数据，不做强幂等去重。
        /// 注意：同步模式（Async=false）、Stream、CallbackUrl 一期不支持，将在后续版本提供。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RunSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSkillResponse
        /// </returns>
        public RunSkillResponse RunSkill(RunSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunSkillWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步触发技能执行，立即返回 RunId。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口仅支持异步模式：提交后立即返回 <c>RunId</c> 和 <c>Status=Running</c>，客户端通过 <c>GetSkillRun</c> 轮询最终结果。</para>
        /// <list type="bullet">
        /// <item><description><b>TenantId</b>：可选公共参数，由网关透传到后端 Header。</description></item>
        /// <item><description><b>SkillCode</b> / <b>SkillName</b>：二选一；SkillCode 优先；SkillName 不唯一时返回 <c>ERR.SkillHub.SkillNameAmbiguous</c>。</description></item>
        /// <item><description><b>Arguments</b>：必填，技能入参对象，结构由 <c>GetSkill</c> 返回的 inputConfig 描述。</description></item>
        /// <item><description><b>ClientToken</b>：可选幂等键；当前版本仅记录到任务元数据，不做强幂等去重。
        /// 注意：同步模式（Async=false）、Stream、CallbackUrl 一期不支持，将在后续版本提供。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RunSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSkillResponse
        /// </returns>
        public async Task<RunSkillResponse> RunSkillAsync(RunSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunSkillWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将产出明细批量保存为个人资源，支持链接或复制模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将一批产出明细保存为用户的个人资源。</description></item>
        /// <item><description>支持两种保存方式：<c>link</c>（链接）和<c>copy</c>（复制）。选择<c>link</c>时，编辑产出会同步到资源；选择<c>copy</c>则创建快照，不限次数。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份。</description></item>
        /// <item><description>如果批内 <c>operating_object</c> 不一致且未传 <c>directoryId</c>，则整批请求前置失败。</description></item>
        /// <item><description>单条记录的处理结果不会影响其他记录的结果，单条失败信息会在响应中返回。</description></item>
        /// <item><description>批量操作最多支持50条记录。</description></item>
        /// <item><description>整批前置失败的情况由全局异常中间件统一返回POP兼容错误格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SaveOutputFileToResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveOutputFileToResourceResponse
        /// </returns>
        public SaveOutputFileToResourceResponse SaveOutputFileToResourceWithOptions(SaveOutputFileToResourceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveOutputFileToResourceShrinkRequest request = new SaveOutputFileToResourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "itemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                body["itemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveOutputFileToResource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/saveOutputFileToResource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOutputFileToResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将产出明细批量保存为个人资源，支持链接或复制模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将一批产出明细保存为用户的个人资源。</description></item>
        /// <item><description>支持两种保存方式：<c>link</c>（链接）和<c>copy</c>（复制）。选择<c>link</c>时，编辑产出会同步到资源；选择<c>copy</c>则创建快照，不限次数。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份。</description></item>
        /// <item><description>如果批内 <c>operating_object</c> 不一致且未传 <c>directoryId</c>，则整批请求前置失败。</description></item>
        /// <item><description>单条记录的处理结果不会影响其他记录的结果，单条失败信息会在响应中返回。</description></item>
        /// <item><description>批量操作最多支持50条记录。</description></item>
        /// <item><description>整批前置失败的情况由全局异常中间件统一返回POP兼容错误格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SaveOutputFileToResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveOutputFileToResourceResponse
        /// </returns>
        public async Task<SaveOutputFileToResourceResponse> SaveOutputFileToResourceWithOptionsAsync(SaveOutputFileToResourceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveOutputFileToResourceShrinkRequest request = new SaveOutputFileToResourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "itemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                body["itemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveOutputFileToResource",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/saveOutputFileToResource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOutputFileToResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将产出明细批量保存为个人资源，支持链接或复制模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将一批产出明细保存为用户的个人资源。</description></item>
        /// <item><description>支持两种保存方式：<c>link</c>（链接）和<c>copy</c>（复制）。选择<c>link</c>时，编辑产出会同步到资源；选择<c>copy</c>则创建快照，不限次数。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份。</description></item>
        /// <item><description>如果批内 <c>operating_object</c> 不一致且未传 <c>directoryId</c>，则整批请求前置失败。</description></item>
        /// <item><description>单条记录的处理结果不会影响其他记录的结果，单条失败信息会在响应中返回。</description></item>
        /// <item><description>批量操作最多支持50条记录。</description></item>
        /// <item><description>整批前置失败的情况由全局异常中间件统一返回POP兼容错误格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveOutputFileToResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveOutputFileToResourceResponse
        /// </returns>
        public SaveOutputFileToResourceResponse SaveOutputFileToResource(SaveOutputFileToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SaveOutputFileToResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将产出明细批量保存为个人资源，支持链接或复制模式。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于将一批产出明细保存为用户的个人资源。</description></item>
        /// <item><description>支持两种保存方式：<c>link</c>（链接）和<c>copy</c>（复制）。选择<c>link</c>时，编辑产出会同步到资源；选择<c>copy</c>则创建快照，不限次数。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅来自鉴权身份。</description></item>
        /// <item><description>如果批内 <c>operating_object</c> 不一致且未传 <c>directoryId</c>，则整批请求前置失败。</description></item>
        /// <item><description>单条记录的处理结果不会影响其他记录的结果，单条失败信息会在响应中返回。</description></item>
        /// <item><description>批量操作最多支持50条记录。</description></item>
        /// <item><description>整批前置失败的情况由全局异常中间件统一返回POP兼容错误格式。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveOutputFileToResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveOutputFileToResourceResponse
        /// </returns>
        public async Task<SaveOutputFileToResourceResponse> SaveOutputFileToResourceAsync(SaveOutputFileToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SaveOutputFileToResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步发送会话消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendAsyncChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendAsyncChatMessageResponse
        /// </returns>
        public SendAsyncChatMessageResponse SendAsyncChatMessageWithOptions(SendAsyncChatMessageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendAsyncChatMessageShrinkRequest request = new SendAsyncChatMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskExecution))
            {
                request.TaskExecutionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskExecution, "taskExecution", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectChat))
            {
                body["directChat"] = request.DirectChat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseLastSession))
            {
                body["reuseLastSession"] = request.ReuseLastSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionShrink))
            {
                body["taskExecution"] = request.TaskExecutionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendAsyncChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/sendAsyncChatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendAsyncChatMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步发送会话消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendAsyncChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendAsyncChatMessageResponse
        /// </returns>
        public async Task<SendAsyncChatMessageResponse> SendAsyncChatMessageWithOptionsAsync(SendAsyncChatMessageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendAsyncChatMessageShrinkRequest request = new SendAsyncChatMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskExecution))
            {
                request.TaskExecutionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskExecution, "taskExecution", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectChat))
            {
                body["directChat"] = request.DirectChat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseLastSession))
            {
                body["reuseLastSession"] = request.ReuseLastSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionShrink))
            {
                body["taskExecution"] = request.TaskExecutionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendAsyncChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/sendAsyncChatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendAsyncChatMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步发送会话消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendAsyncChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendAsyncChatMessageResponse
        /// </returns>
        public SendAsyncChatMessageResponse SendAsyncChatMessage(SendAsyncChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendAsyncChatMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步发送会话消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendAsyncChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendAsyncChatMessageResponse
        /// </returns>
        public async Task<SendAsyncChatMessageResponse> SendAsyncChatMessageAsync(SendAsyncChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendAsyncChatMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public SendChatMessageResponse SendChatMessageWithOptions(SendChatMessageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatMessageShrinkRequest request = new SendChatMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskExecution))
            {
                request.TaskExecutionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskExecution, "taskExecution", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectChat))
            {
                body["directChat"] = request.DirectChat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseLastSession))
            {
                body["reuseLastSession"] = request.ReuseLastSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionShrink))
            {
                body["taskExecution"] = request.TaskExecutionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/sendChatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public async Task<SendChatMessageResponse> SendChatMessageWithOptionsAsync(SendChatMessageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatMessageShrinkRequest request = new SendChatMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskExecution))
            {
                request.TaskExecutionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskExecution, "taskExecution", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectChat))
            {
                body["directChat"] = request.DirectChat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseLastSession))
            {
                body["reuseLastSession"] = request.ReuseLastSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionShrink))
            {
                body["taskExecution"] = request.TaskExecutionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/sendChatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public SendChatMessageResponse SendChatMessage(SendChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendChatMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public async Task<SendChatMessageResponse> SendChatMessageAsync(SendChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendChatMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止对话生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopChatMessageResponse
        /// </returns>
        public StopChatMessageResponse StopChatMessageWithOptions(StopChatMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/stopChatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopChatMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止对话生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopChatMessageResponse
        /// </returns>
        public async Task<StopChatMessageResponse> StopChatMessageWithOptionsAsync(StopChatMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/stopChatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopChatMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止对话生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// StopChatMessageResponse
        /// </returns>
        public StopChatMessageResponse StopChatMessage(StopChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopChatMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止对话生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// StopChatMessageResponse
        /// </returns>
        public async Task<StopChatMessageResponse> StopChatMessageAsync(StopChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopChatMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅会话消息流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StreamChatMessageResponse
        /// </returns>
        public StreamChatMessageResponse StreamChatMessageWithOptions(string messageId, StreamChatMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastEventId))
            {
                query["lastEventId"] = request.LastEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StreamChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/streamChatMessage/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StreamChatMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅会话消息流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StreamChatMessageResponse
        /// </returns>
        public async Task<StreamChatMessageResponse> StreamChatMessageWithOptionsAsync(string messageId, StreamChatMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastEventId))
            {
                query["lastEventId"] = request.LastEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StreamChatMessage",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/streamChatMessage/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StreamChatMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅会话消息流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// StreamChatMessageResponse
        /// </returns>
        public StreamChatMessageResponse StreamChatMessage(string messageId, StreamChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StreamChatMessageWithOptions(messageId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅会话消息流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// StreamChatMessageResponse
        /// </returns>
        public async Task<StreamChatMessageResponse> StreamChatMessageAsync(string messageId, StreamChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StreamChatMessageWithOptionsAsync(messageId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送组织架构同步</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>接收客户端推送的部门树和成员关系，创建异步同步任务。
        ///     处理流程：
        ///     1. 校验 platformType（仅允许 saml / oauth2 / custom）
        ///     2. 校验数据量限制（departments + members &lt;= 50000）
        ///     3. 校验 syncMembers 与 platformType 的兼容性
        ///     4. SAML/OAuth2 场景：解析或自动推导 ssoSettingsId
        ///     5. Custom 场景：校验 corpId 已通过 createCustomOrg 注册
        ///     6. 委托 OrgSyncAuthorizedService 创建任务（内含权限校验）
        ///     7. 返回 taskId 供轮询</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SyncOrgStructureRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncOrgStructureResponse
        /// </returns>
        public SyncOrgStructureResponse SyncOrgStructureWithOptions(SyncOrgStructureRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncOrgStructureShrinkRequest request = new SyncOrgStructureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Departments))
            {
                request.DepartmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Departments, "departments", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "members", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentsShrink))
            {
                body["departments"] = request.DepartmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformType))
            {
                body["platformType"] = request.PlatformType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSettingsId))
            {
                body["ssoSettingsId"] = request.SsoSettingsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncMembers))
            {
                body["syncMembers"] = request.SyncMembers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncOrgStructure",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/syncOrgStructure",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncOrgStructureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送组织架构同步</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>接收客户端推送的部门树和成员关系，创建异步同步任务。
        ///     处理流程：
        ///     1. 校验 platformType（仅允许 saml / oauth2 / custom）
        ///     2. 校验数据量限制（departments + members &lt;= 50000）
        ///     3. 校验 syncMembers 与 platformType 的兼容性
        ///     4. SAML/OAuth2 场景：解析或自动推导 ssoSettingsId
        ///     5. Custom 场景：校验 corpId 已通过 createCustomOrg 注册
        ///     6. 委托 OrgSyncAuthorizedService 创建任务（内含权限校验）
        ///     7. 返回 taskId 供轮询</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SyncOrgStructureRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncOrgStructureResponse
        /// </returns>
        public async Task<SyncOrgStructureResponse> SyncOrgStructureWithOptionsAsync(SyncOrgStructureRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncOrgStructureShrinkRequest request = new SyncOrgStructureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Departments))
            {
                request.DepartmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Departments, "departments", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Members))
            {
                request.MembersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Members, "members", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentsShrink))
            {
                body["departments"] = request.DepartmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersShrink))
            {
                body["members"] = request.MembersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformType))
            {
                body["platformType"] = request.PlatformType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSettingsId))
            {
                body["ssoSettingsId"] = request.SsoSettingsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncMembers))
            {
                body["syncMembers"] = request.SyncMembers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncOrgStructure",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/syncOrgStructure",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncOrgStructureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送组织架构同步</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>接收客户端推送的部门树和成员关系，创建异步同步任务。
        ///     处理流程：
        ///     1. 校验 platformType（仅允许 saml / oauth2 / custom）
        ///     2. 校验数据量限制（departments + members &lt;= 50000）
        ///     3. 校验 syncMembers 与 platformType 的兼容性
        ///     4. SAML/OAuth2 场景：解析或自动推导 ssoSettingsId
        ///     5. Custom 场景：校验 corpId 已通过 createCustomOrg 注册
        ///     6. 委托 OrgSyncAuthorizedService 创建任务（内含权限校验）
        ///     7. 返回 taskId 供轮询</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyncOrgStructureRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncOrgStructureResponse
        /// </returns>
        public SyncOrgStructureResponse SyncOrgStructure(SyncOrgStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncOrgStructureWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送组织架构同步</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>接收客户端推送的部门树和成员关系，创建异步同步任务。
        ///     处理流程：
        ///     1. 校验 platformType（仅允许 saml / oauth2 / custom）
        ///     2. 校验数据量限制（departments + members &lt;= 50000）
        ///     3. 校验 syncMembers 与 platformType 的兼容性
        ///     4. SAML/OAuth2 场景：解析或自动推导 ssoSettingsId
        ///     5. Custom 场景：校验 corpId 已通过 createCustomOrg 注册
        ///     6. 委托 OrgSyncAuthorizedService 创建任务（内含权限校验）
        ///     7. 返回 taskId 供轮询</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyncOrgStructureRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncOrgStructureResponse
        /// </returns>
        public async Task<SyncOrgStructureResponse> SyncOrgStructureAsync(SyncOrgStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncOrgStructureWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过此API可以对指定的主对象执行关注或取消关注操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>Precheck</b>:<ol>
        /// <item><description>添加关注时：系统会检查是否已对该主对象进行了关注以防止重复，并且会验证该主对象是否存在。</description></item>
        /// <item><description>取消关注时：这是一个幂等操作，无论用户之前是否已经关注了该对象，都会返回 <c>success=true</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全性</b>：支持AK、BearerToken和APP三种认证方式。</description></item>
        /// <item><description><b>请求频率限制</b>：每秒最多可发送100次请求。</description></item>
        /// <item><description><b>响应日志</b>：开启响应日志记录功能。</description></item>
        /// <item><description><b>租户相关性</b>：此API与特定租户相关联，默认使用调用方的租户ID。</description></item>
        /// <item><description><b>操作类型</b>：属于写入型操作。</description></item>
        /// <item><description><b>后端服务</b>：请求将被转发至内部服务进行处理，超时时间为3秒。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TogglePrimaryObjectFavoriteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TogglePrimaryObjectFavoriteResponse
        /// </returns>
        public TogglePrimaryObjectFavoriteResponse TogglePrimaryObjectFavoriteWithOptions(TogglePrimaryObjectFavoriteRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TogglePrimaryObjectFavoriteShrinkRequest request = new TogglePrimaryObjectFavoriteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectIds))
            {
                request.ObjectIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectIds, "objectIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectIdsShrink))
            {
                body["objectIds"] = request.ObjectIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TogglePrimaryObjectFavorite",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/togglePrimaryObjectFavorite",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TogglePrimaryObjectFavoriteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过此API可以对指定的主对象执行关注或取消关注操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>Precheck</b>:<ol>
        /// <item><description>添加关注时：系统会检查是否已对该主对象进行了关注以防止重复，并且会验证该主对象是否存在。</description></item>
        /// <item><description>取消关注时：这是一个幂等操作，无论用户之前是否已经关注了该对象，都会返回 <c>success=true</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全性</b>：支持AK、BearerToken和APP三种认证方式。</description></item>
        /// <item><description><b>请求频率限制</b>：每秒最多可发送100次请求。</description></item>
        /// <item><description><b>响应日志</b>：开启响应日志记录功能。</description></item>
        /// <item><description><b>租户相关性</b>：此API与特定租户相关联，默认使用调用方的租户ID。</description></item>
        /// <item><description><b>操作类型</b>：属于写入型操作。</description></item>
        /// <item><description><b>后端服务</b>：请求将被转发至内部服务进行处理，超时时间为3秒。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TogglePrimaryObjectFavoriteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TogglePrimaryObjectFavoriteResponse
        /// </returns>
        public async Task<TogglePrimaryObjectFavoriteResponse> TogglePrimaryObjectFavoriteWithOptionsAsync(TogglePrimaryObjectFavoriteRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TogglePrimaryObjectFavoriteShrinkRequest request = new TogglePrimaryObjectFavoriteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectIds))
            {
                request.ObjectIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectIds, "objectIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectIdsShrink))
            {
                body["objectIds"] = request.ObjectIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TogglePrimaryObjectFavorite",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/togglePrimaryObjectFavorite",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TogglePrimaryObjectFavoriteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过此API可以对指定的主对象执行关注或取消关注操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>Precheck</b>:<ol>
        /// <item><description>添加关注时：系统会检查是否已对该主对象进行了关注以防止重复，并且会验证该主对象是否存在。</description></item>
        /// <item><description>取消关注时：这是一个幂等操作，无论用户之前是否已经关注了该对象，都会返回 <c>success=true</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全性</b>：支持AK、BearerToken和APP三种认证方式。</description></item>
        /// <item><description><b>请求频率限制</b>：每秒最多可发送100次请求。</description></item>
        /// <item><description><b>响应日志</b>：开启响应日志记录功能。</description></item>
        /// <item><description><b>租户相关性</b>：此API与特定租户相关联，默认使用调用方的租户ID。</description></item>
        /// <item><description><b>操作类型</b>：属于写入型操作。</description></item>
        /// <item><description><b>后端服务</b>：请求将被转发至内部服务进行处理，超时时间为3秒。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TogglePrimaryObjectFavoriteRequest
        /// </param>
        /// 
        /// <returns>
        /// TogglePrimaryObjectFavoriteResponse
        /// </returns>
        public TogglePrimaryObjectFavoriteResponse TogglePrimaryObjectFavorite(TogglePrimaryObjectFavoriteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TogglePrimaryObjectFavoriteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过此API可以对指定的主对象执行关注或取消关注操作。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>Precheck</b>:<ol>
        /// <item><description>添加关注时：系统会检查是否已对该主对象进行了关注以防止重复，并且会验证该主对象是否存在。</description></item>
        /// <item><description>取消关注时：这是一个幂等操作，无论用户之前是否已经关注了该对象，都会返回 <c>success=true</c>。</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><b>安全性</b>：支持AK、BearerToken和APP三种认证方式。</description></item>
        /// <item><description><b>请求频率限制</b>：每秒最多可发送100次请求。</description></item>
        /// <item><description><b>响应日志</b>：开启响应日志记录功能。</description></item>
        /// <item><description><b>租户相关性</b>：此API与特定租户相关联，默认使用调用方的租户ID。</description></item>
        /// <item><description><b>操作类型</b>：属于写入型操作。</description></item>
        /// <item><description><b>后端服务</b>：请求将被转发至内部服务进行处理，超时时间为3秒。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TogglePrimaryObjectFavoriteRequest
        /// </param>
        /// 
        /// <returns>
        /// TogglePrimaryObjectFavoriteResponse
        /// </returns>
        public async Task<TogglePrimaryObjectFavoriteResponse> TogglePrimaryObjectFavoriteAsync(TogglePrimaryObjectFavoriteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TogglePrimaryObjectFavoriteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数字员工使用权限授权模式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>切换数字员工的使用权限授权模式。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.update_auth_mode 执行
        ///     3. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     4. SPECIFIED_USERS：需显式授权才能使用
        ///     5. ALL_USERS：所有用户无需授权即可使用（管理权限不受影响）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentAuthModeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentAuthModeResponse
        /// </returns>
        public UpdateAgentAuthModeResponse UpdateAgentAuthModeWithOptions(UpdateAgentAuthModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMode))
            {
                body["authMode"] = request.AuthMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentAuthMode",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateAgentAuthMode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentAuthModeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数字员工使用权限授权模式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>切换数字员工的使用权限授权模式。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.update_auth_mode 执行
        ///     3. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     4. SPECIFIED_USERS：需显式授权才能使用
        ///     5. ALL_USERS：所有用户无需授权即可使用（管理权限不受影响）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentAuthModeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentAuthModeResponse
        /// </returns>
        public async Task<UpdateAgentAuthModeResponse> UpdateAgentAuthModeWithOptionsAsync(UpdateAgentAuthModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMode))
            {
                body["authMode"] = request.AuthMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentAuthMode",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateAgentAuthMode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentAuthModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数字员工使用权限授权模式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>切换数字员工的使用权限授权模式。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.update_auth_mode 执行
        ///     3. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     4. SPECIFIED_USERS：需显式授权才能使用
        ///     5. ALL_USERS：所有用户无需授权即可使用（管理权限不受影响）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentAuthModeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentAuthModeResponse
        /// </returns>
        public UpdateAgentAuthModeResponse UpdateAgentAuthMode(UpdateAgentAuthModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentAuthModeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数字员工使用权限授权模式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>切换数字员工的使用权限授权模式。
        ///     业务逻辑：
        ///     1. 从 identity 构造 AuthContext
        ///     2. 委托 AgentAuthorizationAuthorizedService.update_auth_mode 执行
        ///     3. 前置校验：MANAGE 权限 + agent 存在性（由 AuthorizedService 层执行，先鉴权后暴露存在性）
        ///     4. SPECIFIED_USERS：需显式授权才能使用
        ///     5. ALL_USERS：所有用户无需授权即可使用（管理权限不受影响）</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentAuthModeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentAuthModeResponse
        /// </returns>
        public async Task<UpdateAgentAuthModeResponse> UpdateAgentAuthModeAsync(UpdateAgentAuthModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentAuthModeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChatSessionResponse
        /// </returns>
        public UpdateChatSessionResponse UpdateChatSessionWithOptions(UpdateChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChatSession",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateChatSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChatSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChatSessionResponse
        /// </returns>
        public async Task<UpdateChatSessionResponse> UpdateChatSessionWithOptionsAsync(UpdateChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChatSession",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateChatSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChatSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChatSessionResponse
        /// </returns>
        public UpdateChatSessionResponse UpdateChatSession(UpdateChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateChatSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChatSessionResponse
        /// </returns>
        public async Task<UpdateChatSessionResponse> UpdateChatSessionAsync(UpdateChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateChatSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新用户的个人目录基础信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于更新指定用户的个人目录信息，包括名称、描述、父目录等。请求时需确保提供的 <c>directoryId</c> 对应的目录存在且属于当前用户。此外，如果更改了目录的 <c>name</c> 或 <c>path</c>，系统将自动递归更新所有子目录的路径以保持一致性。特别注意，在调整父目录时，必须保证新父目录的有效性（即非自身或不会导致循环引用）。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自于鉴权身份。</description></item>
        /// <item><description><b>权限要求</b>：执行此操作需要相应的 RAM 权限。</description></item>
        /// <item><description><b>输入参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c>：必填，表示要更新的目录唯一标识。</description></item>
        /// <item><description><c>name</c>：选填，设置新的目录名称。</description></item>
        /// <item><description><c>description</c>：选填，提供新的目录描述。</description></item>
        /// <item><description><c>parentId</c>：选填，指定新的父目录ID。</description></item>
        /// <item><description><c>path</c>：选填，当传入时会级联更新当前及所有子目录的路径。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public UpdateDirectoryResponse UpdateDirectoryWithOptions(UpdateDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新用户的个人目录基础信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于更新指定用户的个人目录信息，包括名称、描述、父目录等。请求时需确保提供的 <c>directoryId</c> 对应的目录存在且属于当前用户。此外，如果更改了目录的 <c>name</c> 或 <c>path</c>，系统将自动递归更新所有子目录的路径以保持一致性。特别注意，在调整父目录时，必须保证新父目录的有效性（即非自身或不会导致循环引用）。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自于鉴权身份。</description></item>
        /// <item><description><b>权限要求</b>：执行此操作需要相应的 RAM 权限。</description></item>
        /// <item><description><b>输入参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c>：必填，表示要更新的目录唯一标识。</description></item>
        /// <item><description><c>name</c>：选填，设置新的目录名称。</description></item>
        /// <item><description><c>description</c>：选填，提供新的目录描述。</description></item>
        /// <item><description><c>parentId</c>：选填，指定新的父目录ID。</description></item>
        /// <item><description><c>path</c>：选填，当传入时会级联更新当前及所有子目录的路径。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public async Task<UpdateDirectoryResponse> UpdateDirectoryWithOptionsAsync(UpdateDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新用户的个人目录基础信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于更新指定用户的个人目录信息，包括名称、描述、父目录等。请求时需确保提供的 <c>directoryId</c> 对应的目录存在且属于当前用户。此外，如果更改了目录的 <c>name</c> 或 <c>path</c>，系统将自动递归更新所有子目录的路径以保持一致性。特别注意，在调整父目录时，必须保证新父目录的有效性（即非自身或不会导致循环引用）。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自于鉴权身份。</description></item>
        /// <item><description><b>权限要求</b>：执行此操作需要相应的 RAM 权限。</description></item>
        /// <item><description><b>输入参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c>：必填，表示要更新的目录唯一标识。</description></item>
        /// <item><description><c>name</c>：选填，设置新的目录名称。</description></item>
        /// <item><description><c>description</c>：选填，提供新的目录描述。</description></item>
        /// <item><description><c>parentId</c>：选填，指定新的父目录ID。</description></item>
        /// <item><description><c>path</c>：选填，当传入时会级联更新当前及所有子目录的路径。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public UpdateDirectoryResponse UpdateDirectory(UpdateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新用户的个人目录基础信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于更新指定用户的个人目录信息，包括名称、描述、父目录等。请求时需确保提供的 <c>directoryId</c> 对应的目录存在且属于当前用户。此外，如果更改了目录的 <c>name</c> 或 <c>path</c>，系统将自动递归更新所有子目录的路径以保持一致性。特别注意，在调整父目录时，必须保证新父目录的有效性（即非自身或不会导致循环引用）。</para>
        /// <list type="bullet">
        /// <item><description><b>安全约束</b>：<c>tenant_id</c> 和 <c>user_id</c> 必须来自于鉴权身份。</description></item>
        /// <item><description><b>权限要求</b>：执行此操作需要相应的 RAM 权限。</description></item>
        /// <item><description><b>输入参数</b>：<list type="bullet">
        /// <item><description><c>directoryId</c>：必填，表示要更新的目录唯一标识。</description></item>
        /// <item><description><c>name</c>：选填，设置新的目录名称。</description></item>
        /// <item><description><c>description</c>：选填，提供新的目录描述。</description></item>
        /// <item><description><c>parentId</c>：选填，指定新的父目录ID。</description></item>
        /// <item><description><c>path</c>：选填，当传入时会级联更新当前及所有子目录的路径。</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public async Task<UpdateDirectoryResponse> UpdateDirectoryAsync(UpdateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定的企业知识库分类信息，包括名称、描述及父目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于修改企业知识库中的某个分类。</description></item>
        /// <item><description>需要具有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>tenantId</c>参数为可选，若未提供，则默认使用调用者的租户ID。</description></item>
        /// <item><description>必须提供待修改的<c>directoryId</c>，而<c>name</c>、<c>description</c>和<c>parentDirectoryId</c>均为可选项，不提供则表示这些字段保持不变。</description></item>
        /// <item><description>当指定了新的<c>parentDirectoryId</c>时，系统会检查新父目录是否属于当前租户，并且不会导致循环引用问题。</description></item>
        /// <item><description>安全性方面，本API支持多种认证方式（AK、BearerToken、APP），并启用了RAM权限控制与操作审计。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseDirectoryResponse
        /// </returns>
        public UpdateKnowledgeBaseDirectoryResponse UpdateKnowledgeBaseDirectoryWithOptions(UpdateKnowledgeBaseDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                body["parentDirectoryId"] = request.ParentDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateKnowledgeBaseDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定的企业知识库分类信息，包括名称、描述及父目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于修改企业知识库中的某个分类。</description></item>
        /// <item><description>需要具有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>tenantId</c>参数为可选，若未提供，则默认使用调用者的租户ID。</description></item>
        /// <item><description>必须提供待修改的<c>directoryId</c>，而<c>name</c>、<c>description</c>和<c>parentDirectoryId</c>均为可选项，不提供则表示这些字段保持不变。</description></item>
        /// <item><description>当指定了新的<c>parentDirectoryId</c>时，系统会检查新父目录是否属于当前租户，并且不会导致循环引用问题。</description></item>
        /// <item><description>安全性方面，本API支持多种认证方式（AK、BearerToken、APP），并启用了RAM权限控制与操作审计。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseDirectoryResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseDirectoryResponse> UpdateKnowledgeBaseDirectoryWithOptionsAsync(UpdateKnowledgeBaseDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDirectoryId))
            {
                body["parentDirectoryId"] = request.ParentDirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateKnowledgeBaseDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定的企业知识库分类信息，包括名称、描述及父目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于修改企业知识库中的某个分类。</description></item>
        /// <item><description>需要具有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>tenantId</c>参数为可选，若未提供，则默认使用调用者的租户ID。</description></item>
        /// <item><description>必须提供待修改的<c>directoryId</c>，而<c>name</c>、<c>description</c>和<c>parentDirectoryId</c>均为可选项，不提供则表示这些字段保持不变。</description></item>
        /// <item><description>当指定了新的<c>parentDirectoryId</c>时，系统会检查新父目录是否属于当前租户，并且不会导致循环引用问题。</description></item>
        /// <item><description>安全性方面，本API支持多种认证方式（AK、BearerToken、APP），并启用了RAM权限控制与操作审计。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseDirectoryResponse
        /// </returns>
        public UpdateKnowledgeBaseDirectoryResponse UpdateKnowledgeBaseDirectory(UpdateKnowledgeBaseDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKnowledgeBaseDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定的企业知识库分类信息，包括名称、描述及父目录。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于修改企业知识库中的某个分类。</description></item>
        /// <item><description>需要具有<c>DEVELOPMENT_KB_MANAGE</c>功能权限才能调用此API。</description></item>
        /// <item><description><c>tenantId</c>参数为可选，若未提供，则默认使用调用者的租户ID。</description></item>
        /// <item><description>必须提供待修改的<c>directoryId</c>，而<c>name</c>、<c>description</c>和<c>parentDirectoryId</c>均为可选项，不提供则表示这些字段保持不变。</description></item>
        /// <item><description>当指定了新的<c>parentDirectoryId</c>时，系统会检查新父目录是否属于当前租户，并且不会导致循环引用问题。</description></item>
        /// <item><description>安全性方面，本API支持多种认证方式（AK、BearerToken、APP），并启用了RAM权限控制与操作审计。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseDirectoryResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseDirectoryResponse> UpdateKnowledgeBaseDirectoryAsync(UpdateKnowledgeBaseDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKnowledgeBaseDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于编辑企业自建知识库中的资源正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口允许用户更新指定的企业知识库数据源的正文内容，并可选择是否同步等待解析完成。通过设置<c>forceSync</c>参数，可以控制解析过程是同步还是异步执行，默认为异步处理。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：当<c>content</c>字段为空字符串时，表示清空原有内容。</description></item>
        /// <item><description><b>权限要求</b>：调用此接口需要具备相应的RAM操作权限（<c>winnexo:UpdateKnowledgeBaseSourceContent</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceContentResponse
        /// </returns>
        public UpdateKnowledgeBaseSourceContentResponse UpdateKnowledgeBaseSourceContentWithOptions(UpdateKnowledgeBaseSourceContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseSourceContent",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateKnowledgeBaseSourceContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseSourceContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于编辑企业自建知识库中的资源正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口允许用户更新指定的企业知识库数据源的正文内容，并可选择是否同步等待解析完成。通过设置<c>forceSync</c>参数，可以控制解析过程是同步还是异步执行，默认为异步处理。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：当<c>content</c>字段为空字符串时，表示清空原有内容。</description></item>
        /// <item><description><b>权限要求</b>：调用此接口需要具备相应的RAM操作权限（<c>winnexo:UpdateKnowledgeBaseSourceContent</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceContentResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseSourceContentResponse> UpdateKnowledgeBaseSourceContentWithOptionsAsync(UpdateKnowledgeBaseSourceContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseSourceContent",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateKnowledgeBaseSourceContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseSourceContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于编辑企业自建知识库中的资源正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口允许用户更新指定的企业知识库数据源的正文内容，并可选择是否同步等待解析完成。通过设置<c>forceSync</c>参数，可以控制解析过程是同步还是异步执行，默认为异步处理。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：当<c>content</c>字段为空字符串时，表示清空原有内容。</description></item>
        /// <item><description><b>权限要求</b>：调用此接口需要具备相应的RAM操作权限（<c>winnexo:UpdateKnowledgeBaseSourceContent</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceContentResponse
        /// </returns>
        public UpdateKnowledgeBaseSourceContentResponse UpdateKnowledgeBaseSourceContent(UpdateKnowledgeBaseSourceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKnowledgeBaseSourceContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于编辑企业自建知识库中的资源正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本接口允许用户更新指定的企业知识库数据源的正文内容，并可选择是否同步等待解析完成。通过设置<c>forceSync</c>参数，可以控制解析过程是同步还是异步执行，默认为异步处理。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：当<c>content</c>字段为空字符串时，表示清空原有内容。</description></item>
        /// <item><description><b>权限要求</b>：调用此接口需要具备相应的RAM操作权限（<c>winnexo:UpdateKnowledgeBaseSourceContent</c>）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceContentResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseSourceContentResponse> UpdateKnowledgeBaseSourceContentAsync(UpdateKnowledgeBaseSourceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKnowledgeBaseSourceContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定企业知识库数据源的资源标签。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新企业知识库中特定数据源的标签。</description></item>
        /// <item><description>需要具备知识库管理权限才能调用此接口。</description></item>
        /// <item><description><c>sourceTags</c> 参数接受 JSON 字符串列表形式，例如 <c>[&quot;tagA&quot;, &quot;tagB&quot;]</c>；若传入 <c>null</c> 则表示清空所有现有标签。</description></item>
        /// <item><description>更新操作仅影响 <c>sourceTags</c> 和 <c>gmt_modified</c> 字段，并不会触发 <c>process_source</c> 流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则会抛出 <c>ERR.Robject.Source.NotFound</c> 错误。</description></item>
        /// <item><description>接口支持通过 AK、BearerToken 或 APP 方式进行身份验证。</description></item>
        /// <item><description>调用时需确保 <c>tenant_id</c> 和 <c>user_id</c> 来自有效的鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceTagsResponse
        /// </returns>
        public UpdateKnowledgeBaseSourceTagsResponse UpdateKnowledgeBaseSourceTagsWithOptions(UpdateKnowledgeBaseSourceTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseSourceTags",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateKnowledgeBaseSourceTags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseSourceTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定企业知识库数据源的资源标签。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新企业知识库中特定数据源的标签。</description></item>
        /// <item><description>需要具备知识库管理权限才能调用此接口。</description></item>
        /// <item><description><c>sourceTags</c> 参数接受 JSON 字符串列表形式，例如 <c>[&quot;tagA&quot;, &quot;tagB&quot;]</c>；若传入 <c>null</c> 则表示清空所有现有标签。</description></item>
        /// <item><description>更新操作仅影响 <c>sourceTags</c> 和 <c>gmt_modified</c> 字段，并不会触发 <c>process_source</c> 流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则会抛出 <c>ERR.Robject.Source.NotFound</c> 错误。</description></item>
        /// <item><description>接口支持通过 AK、BearerToken 或 APP 方式进行身份验证。</description></item>
        /// <item><description>调用时需确保 <c>tenant_id</c> 和 <c>user_id</c> 来自有效的鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceTagsResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseSourceTagsResponse> UpdateKnowledgeBaseSourceTagsWithOptionsAsync(UpdateKnowledgeBaseSourceTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTags))
            {
                body["sourceTags"] = request.SourceTags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseSourceTags",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateKnowledgeBaseSourceTags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseSourceTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定企业知识库数据源的资源标签。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新企业知识库中特定数据源的标签。</description></item>
        /// <item><description>需要具备知识库管理权限才能调用此接口。</description></item>
        /// <item><description><c>sourceTags</c> 参数接受 JSON 字符串列表形式，例如 <c>[&quot;tagA&quot;, &quot;tagB&quot;]</c>；若传入 <c>null</c> 则表示清空所有现有标签。</description></item>
        /// <item><description>更新操作仅影响 <c>sourceTags</c> 和 <c>gmt_modified</c> 字段，并不会触发 <c>process_source</c> 流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则会抛出 <c>ERR.Robject.Source.NotFound</c> 错误。</description></item>
        /// <item><description>接口支持通过 AK、BearerToken 或 APP 方式进行身份验证。</description></item>
        /// <item><description>调用时需确保 <c>tenant_id</c> 和 <c>user_id</c> 来自有效的鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceTagsResponse
        /// </returns>
        public UpdateKnowledgeBaseSourceTagsResponse UpdateKnowledgeBaseSourceTags(UpdateKnowledgeBaseSourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKnowledgeBaseSourceTagsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定企业知识库数据源的资源标签。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于更新企业知识库中特定数据源的标签。</description></item>
        /// <item><description>需要具备知识库管理权限才能调用此接口。</description></item>
        /// <item><description><c>sourceTags</c> 参数接受 JSON 字符串列表形式，例如 <c>[&quot;tagA&quot;, &quot;tagB&quot;]</c>；若传入 <c>null</c> 则表示清空所有现有标签。</description></item>
        /// <item><description>更新操作仅影响 <c>sourceTags</c> 和 <c>gmt_modified</c> 字段，并不会触发 <c>process_source</c> 流程。</description></item>
        /// <item><description>如果指定的数据源不存在，则会抛出 <c>ERR.Robject.Source.NotFound</c> 错误。</description></item>
        /// <item><description>接口支持通过 AK、BearerToken 或 APP 方式进行身份验证。</description></item>
        /// <item><description>调用时需确保 <c>tenant_id</c> 和 <c>user_id</c> 来自有效的鉴权身份信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseSourceTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseSourceTagsResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseSourceTagsResponse> UpdateKnowledgeBaseSourceTagsAsync(UpdateKnowledgeBaseSourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKnowledgeBaseSourceTagsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateScheduledTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledTaskResponse
        /// </returns>
        public UpdateScheduledTaskResponse UpdateScheduledTaskWithOptions(UpdateScheduledTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateScheduledTaskShrinkRequest request = new UpdateScheduledTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Description))
            {
                request.DescriptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Description, "description", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Segments))
            {
                request.SegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Segments, "segments", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDetail))
            {
                request.TaskDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDetail, "taskDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TriggerConfig))
            {
                request.TriggerConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TriggerConfig, "triggerConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescriptionShrink))
            {
                body["description"] = request.DescriptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpen))
            {
                body["isOpen"] = request.IsOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SegmentsShrink))
            {
                body["segments"] = request.SegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailShrink))
            {
                body["taskDetail"] = request.TaskDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfigShrink))
            {
                body["triggerConfig"] = request.TriggerConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledTask",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateScheduledTask",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateScheduledTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledTaskResponse
        /// </returns>
        public async Task<UpdateScheduledTaskResponse> UpdateScheduledTaskWithOptionsAsync(UpdateScheduledTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateScheduledTaskShrinkRequest request = new UpdateScheduledTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Description))
            {
                request.DescriptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Description, "description", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DigitalEmployeeName))
            {
                request.DigitalEmployeeNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DigitalEmployeeName, "digitalEmployeeName", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Segments))
            {
                request.SegmentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Segments, "segments", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDetail))
            {
                request.TaskDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDetail, "taskDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TriggerConfig))
            {
                request.TriggerConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TriggerConfig, "triggerConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescriptionShrink))
            {
                body["description"] = request.DescriptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeNameShrink))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOpen))
            {
                body["isOpen"] = request.IsOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SegmentsShrink))
            {
                body["segments"] = request.SegmentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailShrink))
            {
                body["taskDetail"] = request.TaskDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfigShrink))
            {
                body["triggerConfig"] = request.TriggerConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledTask",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateScheduledTask",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledTaskResponse
        /// </returns>
        public UpdateScheduledTaskResponse UpdateScheduledTask(UpdateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateScheduledTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledTaskResponse
        /// </returns>
        public async Task<UpdateScheduledTaskResponse> UpdateScheduledTaskAsync(UpdateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateScheduledTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新租户内可编辑数据源的正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于更新指定租户内的数据源内容，并根据需要触发同步或异步的数据源重新解析。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅用于鉴权，不参与实际业务逻辑处理。</description></item>
        /// <item><description>当提供的正文为空字符串时，系统将按照现有服务契约执行操作。</description></item>
        /// <item><description>如果指定的数据源不存在，则返回标准的NotFound错误；其他异常情况则由全局异常链处理。</description></item>
        /// <item><description>可通过设置<c>forceSync</c>参数来决定是否等待解析过程完成（默认为异步入队）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSourceContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSourceContentResponse
        /// </returns>
        public UpdateSourceContentResponse UpdateSourceContentWithOptions(UpdateSourceContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSourceContent",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateSourceContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSourceContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新租户内可编辑数据源的正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于更新指定租户内的数据源内容，并根据需要触发同步或异步的数据源重新解析。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅用于鉴权，不参与实际业务逻辑处理。</description></item>
        /// <item><description>当提供的正文为空字符串时，系统将按照现有服务契约执行操作。</description></item>
        /// <item><description>如果指定的数据源不存在，则返回标准的NotFound错误；其他异常情况则由全局异常链处理。</description></item>
        /// <item><description>可通过设置<c>forceSync</c>参数来决定是否等待解析过程完成（默认为异步入队）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSourceContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSourceContentResponse
        /// </returns>
        public async Task<UpdateSourceContentResponse> UpdateSourceContentWithOptionsAsync(UpdateSourceContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSync))
            {
                body["forceSync"] = request.ForceSync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSourceContent",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateSourceContent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSourceContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新租户内可编辑数据源的正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于更新指定租户内的数据源内容，并根据需要触发同步或异步的数据源重新解析。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅用于鉴权，不参与实际业务逻辑处理。</description></item>
        /// <item><description>当提供的正文为空字符串时，系统将按照现有服务契约执行操作。</description></item>
        /// <item><description>如果指定的数据源不存在，则返回标准的NotFound错误；其他异常情况则由全局异常链处理。</description></item>
        /// <item><description>可通过设置<c>forceSync</c>参数来决定是否等待解析过程完成（默认为异步入队）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSourceContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSourceContentResponse
        /// </returns>
        public UpdateSourceContentResponse UpdateSourceContent(UpdateSourceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSourceContentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新租户内可编辑数据源的正文并触发重新解析。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于更新指定租户内的数据源内容，并根据需要触发同步或异步的数据源重新解析。</description></item>
        /// <item><description><c>tenant_id</c> 和 <c>user_id</c> 仅用于鉴权，不参与实际业务逻辑处理。</description></item>
        /// <item><description>当提供的正文为空字符串时，系统将按照现有服务契约执行操作。</description></item>
        /// <item><description>如果指定的数据源不存在，则返回标准的NotFound错误；其他异常情况则由全局异常链处理。</description></item>
        /// <item><description>可通过设置<c>forceSync</c>参数来决定是否等待解析过程完成（默认为异步入队）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSourceContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSourceContentResponse
        /// </returns>
        public async Task<UpdateSourceContentResponse> UpdateSourceContentAsync(UpdateSourceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSourceContentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定的企业知识库目录信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantDirectoryResponse
        /// </returns>
        public UpdateTenantDirectoryResponse UpdateTenantDirectoryWithOptions(UpdateTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTenantDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定的企业知识库目录信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTenantDirectoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantDirectoryResponse
        /// </returns>
        public async Task<UpdateTenantDirectoryResponse> UpdateTenantDirectoryWithOptionsAsync(UpdateTenantDirectoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTenantDirectory",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateTenantDirectory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTenantDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定的企业知识库目录信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantDirectoryResponse
        /// </returns>
        public UpdateTenantDirectoryResponse UpdateTenantDirectory(UpdateTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTenantDirectoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新指定的企业知识库目录信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTenantDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTenantDirectoryResponse
        /// </returns>
        public async Task<UpdateTenantDirectoryResponse> UpdateTenantDirectoryAsync(UpdateTenantDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTenantDirectoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户信息（含启停用）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 修改用户信息。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids
        ///     2. 若 isActive 有变更，先执行状态切换（含最后超管保护）
        ///     3. 调用 update_tenant_member 修改其他字段（displayName / roleCodes / userGroupIds）
        ///     4. 全部成功返回 HTTP 200
        ///     执行顺序说明：
        ///     - isActive 状态变更先于其他字段写入。两步不在同一事务中。
        ///     - 校验失败（如最后超管保护）→ 抛出异常，后续步骤不执行。
        ///     - 若 isActive 变更已落库但后续步骤异常，isActive 不会回滚。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserShrinkRequest request = new UpdateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoleCodes))
            {
                request.RoleCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoleCodes, "roleCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupIds))
            {
                request.UserGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupIds, "userGroupIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                body["isActive"] = request.IsActive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodesShrink))
            {
                body["roleCodes"] = request.RoleCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIdsShrink))
            {
                body["userGroupIds"] = request.UserGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户信息（含启停用）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 修改用户信息。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids
        ///     2. 若 isActive 有变更，先执行状态切换（含最后超管保护）
        ///     3. 调用 update_tenant_member 修改其他字段（displayName / roleCodes / userGroupIds）
        ///     4. 全部成功返回 HTTP 200
        ///     执行顺序说明：
        ///     - isActive 状态变更先于其他字段写入。两步不在同一事务中。
        ///     - 校验失败（如最后超管保护）→ 抛出异常，后续步骤不执行。
        ///     - 若 isActive 变更已落库但后续步骤异常，isActive 不会回滚。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserShrinkRequest request = new UpdateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RoleCodes))
            {
                request.RoleCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RoleCodes, "roleCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupIds))
            {
                request.UserGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupIds, "userGroupIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                body["isActive"] = request.IsActive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodesShrink))
            {
                body["roleCodes"] = request.RoleCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIdsShrink))
            {
                body["userGroupIds"] = request.UserGroupIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WnUserId))
            {
                body["wnUserId"] = request.WnUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户信息（含启停用）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 修改用户信息。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids
        ///     2. 若 isActive 有变更，先执行状态切换（含最后超管保护）
        ///     3. 调用 update_tenant_member 修改其他字段（displayName / roleCodes / userGroupIds）
        ///     4. 全部成功返回 HTTP 200
        ///     执行顺序说明：
        ///     - isActive 状态变更先于其他字段写入。两步不在同一事务中。
        ///     - 校验失败（如最后超管保护）→ 抛出异常，后续步骤不执行。
        ///     - 若 isActive 变更已落库但后续步骤异常，isActive 不会回滚。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户信息（含启停用）</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>OpenAPI 修改用户信息。
        ///     业务编排：
        ///     1. 解析 roleCodes → role_ids
        ///     2. 若 isActive 有变更，先执行状态切换（含最后超管保护）
        ///     3. 调用 update_tenant_member 修改其他字段（displayName / roleCodes / userGroupIds）
        ///     4. 全部成功返回 HTTP 200
        ///     执行顺序说明：
        ///     - isActive 状态变更先于其他字段写入。两步不在同一事务中。
        ///     - 校验失败（如最后超管保护）→ 抛出异常，后续步骤不执行。
        ///     - 若 isActive 变更已落库但后续步骤异常，isActive 不会回滚。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支持部分字段更新当前用户信息，并返回完整用户信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许调用者更新指定用户的部分或全部可选字段，未提供的字段将保持原有值。</description></item>
        /// <item><description>支持通过<c>tenantId</c>参数指定租户ID；若省略，则默认使用调用方的默认租户。</description></item>
        /// <item><description>更新成功后，响应体中会包含完整的用户信息对象。</description></item>
        /// <item><description>此接口要求认证，支持AK、BearerToken和APP三种安全方案。</description></item>
        /// <item><description>接口消费类型为JSON格式，且仅在HTTPS协议下可用。</description></item>
        /// <item><description>特别注意：<c>profileRoleInfo</c>字段仅当用户角色设置为Others时有效，用于描述用户的具体角色信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserInfoResponse
        /// </returns>
        public UpdateUserInfoResponse UpdateUserInfoWithOptions(UpdateUserInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguagePreference))
            {
                body["languagePreference"] = request.LanguagePreference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offering))
            {
                body["offering"] = request.Offering;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileRoleInfo))
            {
                body["profileRoleInfo"] = request.ProfileRoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfIntroduction))
            {
                body["selfIntroduction"] = request.SelfIntroduction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserInfo",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支持部分字段更新当前用户信息，并返回完整用户信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许调用者更新指定用户的部分或全部可选字段，未提供的字段将保持原有值。</description></item>
        /// <item><description>支持通过<c>tenantId</c>参数指定租户ID；若省略，则默认使用调用方的默认租户。</description></item>
        /// <item><description>更新成功后，响应体中会包含完整的用户信息对象。</description></item>
        /// <item><description>此接口要求认证，支持AK、BearerToken和APP三种安全方案。</description></item>
        /// <item><description>接口消费类型为JSON格式，且仅在HTTPS协议下可用。</description></item>
        /// <item><description>特别注意：<c>profileRoleInfo</c>字段仅当用户角色设置为Others时有效，用于描述用户的具体角色信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserInfoResponse
        /// </returns>
        public async Task<UpdateUserInfoResponse> UpdateUserInfoWithOptionsAsync(UpdateUserInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguagePreference))
            {
                body["languagePreference"] = request.LanguagePreference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offering))
            {
                body["offering"] = request.Offering;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileRoleInfo))
            {
                body["profileRoleInfo"] = request.ProfileRoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfIntroduction))
            {
                body["selfIntroduction"] = request.SelfIntroduction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserInfo",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/updateUserInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支持部分字段更新当前用户信息，并返回完整用户信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许调用者更新指定用户的部分或全部可选字段，未提供的字段将保持原有值。</description></item>
        /// <item><description>支持通过<c>tenantId</c>参数指定租户ID；若省略，则默认使用调用方的默认租户。</description></item>
        /// <item><description>更新成功后，响应体中会包含完整的用户信息对象。</description></item>
        /// <item><description>此接口要求认证，支持AK、BearerToken和APP三种安全方案。</description></item>
        /// <item><description>接口消费类型为JSON格式，且仅在HTTPS协议下可用。</description></item>
        /// <item><description>特别注意：<c>profileRoleInfo</c>字段仅当用户角色设置为Others时有效，用于描述用户的具体角色信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserInfoResponse
        /// </returns>
        public UpdateUserInfoResponse UpdateUserInfo(UpdateUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>支持部分字段更新当前用户信息，并返回完整用户信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API允许调用者更新指定用户的部分或全部可选字段，未提供的字段将保持原有值。</description></item>
        /// <item><description>支持通过<c>tenantId</c>参数指定租户ID；若省略，则默认使用调用方的默认租户。</description></item>
        /// <item><description>更新成功后，响应体中会包含完整的用户信息对象。</description></item>
        /// <item><description>此接口要求认证，支持AK、BearerToken和APP三种安全方案。</description></item>
        /// <item><description>接口消费类型为JSON格式，且仅在HTTPS协议下可用。</description></item>
        /// <item><description>特别注意：<c>profileRoleInfo</c>字段仅当用户角色设置为Others时有效，用于描述用户的具体角色信息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserInfoResponse
        /// </returns>
        public async Task<UpdateUserInfoResponse> UpdateUserInfoAsync(UpdateUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话上传本地文件</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于上传会话临时文件，采用<b>文件中转上传</b>模式（<c>fileTransfer</c>）：文件二进制不经本 API 的请求体传输，而是先落到 OSS，再把 OSS 地址通过 <c>FileUrl</c> 入参交给后端；后端从该地址取回字节并写入自己的 OSS，创建会话临时文件记录。</para>
        /// <h3>调用方式</h3>
        /// <list type="bullet">
        /// <item><description><b>推荐</b>：使用 SDK 生成的 <c>UploadChatFileAdvance</c> 方法，传入本地文件流，SDK 自动完成中转上传并回填 <c>FileUrl</c>。</description></item>
        /// <item><description><b>直传</b>：自行将文件上传到可被服务端访问的 OSS 地址，然后直接调用本 API 并传入 <c>FileUrl</c>。</description></item>
        /// </list>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b>：必填，文件的 OSS 地址。使用 Advance 方法时由 SDK 自动回填，无需手动赋值。</description></item>
        /// <item><description><b>FileName</b>：必填，原始文件名（含后缀，如 <c>report.pdf</c>）。中转生成的 OSS 地址不携带原始文件名，后端据此确定文件后缀与展示名，因此必须显式传入。</description></item>
        /// <item><description><b>ContentType</b>：可选，文件 MIME 类型；不传时按 <c>application/octet-stream</c> 处理。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，Agent 命名空间标识，决定文件入库路径。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>返回 OSS 对象路径 <c>objectName</c>、入库地址 <c>fileUrl</c>、公开访问地址 <c>filePublicUrl</c>（有效期 1 小时）、文件记录 ID <c>fileRecordId</c> 等；<c>uploadSignatureUrl</c> 在本模式下恒为空。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadChatFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadChatFileResponse
        /// </returns>
        public UploadChatFileResponse UploadChatFileWithOptions(UploadChatFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadChatFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/uploadChatFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadChatFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话上传本地文件</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于上传会话临时文件，采用<b>文件中转上传</b>模式（<c>fileTransfer</c>）：文件二进制不经本 API 的请求体传输，而是先落到 OSS，再把 OSS 地址通过 <c>FileUrl</c> 入参交给后端；后端从该地址取回字节并写入自己的 OSS，创建会话临时文件记录。</para>
        /// <h3>调用方式</h3>
        /// <list type="bullet">
        /// <item><description><b>推荐</b>：使用 SDK 生成的 <c>UploadChatFileAdvance</c> 方法，传入本地文件流，SDK 自动完成中转上传并回填 <c>FileUrl</c>。</description></item>
        /// <item><description><b>直传</b>：自行将文件上传到可被服务端访问的 OSS 地址，然后直接调用本 API 并传入 <c>FileUrl</c>。</description></item>
        /// </list>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b>：必填，文件的 OSS 地址。使用 Advance 方法时由 SDK 自动回填，无需手动赋值。</description></item>
        /// <item><description><b>FileName</b>：必填，原始文件名（含后缀，如 <c>report.pdf</c>）。中转生成的 OSS 地址不携带原始文件名，后端据此确定文件后缀与展示名，因此必须显式传入。</description></item>
        /// <item><description><b>ContentType</b>：可选，文件 MIME 类型；不传时按 <c>application/octet-stream</c> 处理。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，Agent 命名空间标识，决定文件入库路径。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>返回 OSS 对象路径 <c>objectName</c>、入库地址 <c>fileUrl</c>、公开访问地址 <c>filePublicUrl</c>（有效期 1 小时）、文件记录 ID <c>fileRecordId</c> 等；<c>uploadSignatureUrl</c> 在本模式下恒为空。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadChatFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadChatFileResponse
        /// </returns>
        public async Task<UploadChatFileResponse> UploadChatFileWithOptionsAsync(UploadChatFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatingObjectName))
            {
                body["operatingObjectName"] = request.OperatingObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadChatFile",
                Version = "2026-05-12",
                Protocol = "HTTPS",
                Pathname = "/openapi/uploadChatFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadChatFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话上传本地文件</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于上传会话临时文件，采用<b>文件中转上传</b>模式（<c>fileTransfer</c>）：文件二进制不经本 API 的请求体传输，而是先落到 OSS，再把 OSS 地址通过 <c>FileUrl</c> 入参交给后端；后端从该地址取回字节并写入自己的 OSS，创建会话临时文件记录。</para>
        /// <h3>调用方式</h3>
        /// <list type="bullet">
        /// <item><description><b>推荐</b>：使用 SDK 生成的 <c>UploadChatFileAdvance</c> 方法，传入本地文件流，SDK 自动完成中转上传并回填 <c>FileUrl</c>。</description></item>
        /// <item><description><b>直传</b>：自行将文件上传到可被服务端访问的 OSS 地址，然后直接调用本 API 并传入 <c>FileUrl</c>。</description></item>
        /// </list>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b>：必填，文件的 OSS 地址。使用 Advance 方法时由 SDK 自动回填，无需手动赋值。</description></item>
        /// <item><description><b>FileName</b>：必填，原始文件名（含后缀，如 <c>report.pdf</c>）。中转生成的 OSS 地址不携带原始文件名，后端据此确定文件后缀与展示名，因此必须显式传入。</description></item>
        /// <item><description><b>ContentType</b>：可选，文件 MIME 类型；不传时按 <c>application/octet-stream</c> 处理。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，Agent 命名空间标识，决定文件入库路径。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>返回 OSS 对象路径 <c>objectName</c>、入库地址 <c>fileUrl</c>、公开访问地址 <c>filePublicUrl</c>（有效期 1 小时）、文件记录 ID <c>fileRecordId</c> 等；<c>uploadSignatureUrl</c> 在本模式下恒为空。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadChatFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadChatFileResponse
        /// </returns>
        public UploadChatFileResponse UploadChatFile(UploadChatFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadChatFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话上传本地文件</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于上传会话临时文件，采用<b>文件中转上传</b>模式（<c>fileTransfer</c>）：文件二进制不经本 API 的请求体传输，而是先落到 OSS，再把 OSS 地址通过 <c>FileUrl</c> 入参交给后端；后端从该地址取回字节并写入自己的 OSS，创建会话临时文件记录。</para>
        /// <h3>调用方式</h3>
        /// <list type="bullet">
        /// <item><description><b>推荐</b>：使用 SDK 生成的 <c>UploadChatFileAdvance</c> 方法，传入本地文件流，SDK 自动完成中转上传并回填 <c>FileUrl</c>。</description></item>
        /// <item><description><b>直传</b>：自行将文件上传到可被服务端访问的 OSS 地址，然后直接调用本 API 并传入 <c>FileUrl</c>。</description></item>
        /// </list>
        /// <h3>入参</h3>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b>：必填，文件的 OSS 地址。使用 Advance 方法时由 SDK 自动回填，无需手动赋值。</description></item>
        /// <item><description><b>FileName</b>：必填，原始文件名（含后缀，如 <c>report.pdf</c>）。中转生成的 OSS 地址不携带原始文件名，后端据此确定文件后缀与展示名，因此必须显式传入。</description></item>
        /// <item><description><b>ContentType</b>：可选，文件 MIME 类型；不传时按 <c>application/octet-stream</c> 处理。</description></item>
        /// <item><description><b>OperatingObjectName</b>：可选，Agent 命名空间标识，决定文件入库路径。</description></item>
        /// </list>
        /// <h3>出参</h3>
        /// <para>返回 OSS 对象路径 <c>objectName</c>、入库地址 <c>fileUrl</c>、公开访问地址 <c>filePublicUrl</c>（有效期 1 小时）、文件记录 ID <c>fileRecordId</c> 等；<c>uploadSignatureUrl</c> 在本模式下恒为空。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadChatFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadChatFileResponse
        /// </returns>
        public async Task<UploadChatFileResponse> UploadChatFileAsync(UploadChatFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadChatFileWithOptionsAsync(request, headers, runtime);
        }

        public UploadChatFileResponse UploadChatFileAdvance(UploadChatFileAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            Aliyun.Credentials.Models.CredentialModel credentialModel = null;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"code", "InvalidCredentials"},
                    {"message", "Please set up the credentials correctly. If you are setting them through environment variables, please ensure that ALIBABA_CLOUD_ACCESS_KEY_ID and ALIBABA_CLOUD_ACCESS_KEY_SECRET are set correctly. See https://help.aliyun.com/zh/sdk/developer-reference/configure-the-alibaba-cloud-accesskey-environment-variable-on-linux-macos-and-windows-systems for more details."},
                });
            }
            credentialModel = this._credential.GetCredential();
            string accessKeyId = credentialModel.AccessKeyId;
            string accessKeySecret = credentialModel.AccessKeySecret;
            string securityToken = credentialModel.SecurityToken;
            string credentialType = credentialModel.Type;
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OpenApiClient.Client authClient = new AlibabaCloud.OpenApiClient.Client(authConfig);
            Dictionary<string, string> authRequest = new Dictionary<string, string>
            {
                {"Product", "WinNexo"},
                {"RegionId", _regionId},
            };
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest authReq = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(authRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params authParams = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeFileUpload",
                Version = "2019-12-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            Dictionary<string, object> authResponse = new Dictionary<string, object>(){};
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            Dictionary<string, object> ossHeader = new Dictionary<string, object>(){};
            Dictionary<string, object> tmpBody = new Dictionary<string, object>(){};
            bool? useAccelerate = false;
            Dictionary<string, string> authResponseBody = new Dictionary<string, string>(){};
            UploadChatFileRequest uploadChatFileReq = new UploadChatFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadChatFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new Dictionary<string, object>
                {
                    {"host", AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponseBody.Get("Endpoint"), useAccelerate, _endpointType)},
                    {"OSSAccessKeyId", authResponseBody.Get("AccessKeyId")},
                    {"policy", authResponseBody.Get("EncodedPolicy")},
                    {"Signature", authResponseBody.Get("Signature")},
                    {"key", authResponseBody.Get("ObjectKey")},
                    {"file", fileObj},
                    {"success_action_status", "201"},
                };
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader, runtime);
                uploadChatFileReq.FileUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            UploadChatFileResponse uploadChatFileResp = UploadChatFileWithOptions(uploadChatFileReq, headers, runtime);
            return uploadChatFileResp;
        }

        public async Task<UploadChatFileResponse> UploadChatFileAdvanceAsync(UploadChatFileAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            Aliyun.Credentials.Models.CredentialModel credentialModel = null;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"code", "InvalidCredentials"},
                    {"message", "Please set up the credentials correctly. If you are setting them through environment variables, please ensure that ALIBABA_CLOUD_ACCESS_KEY_ID and ALIBABA_CLOUD_ACCESS_KEY_SECRET are set correctly. See https://help.aliyun.com/zh/sdk/developer-reference/configure-the-alibaba-cloud-accesskey-environment-variable-on-linux-macos-and-windows-systems for more details."},
                });
            }
            credentialModel = await this._credential.GetCredentialAsync();
            string accessKeyId = credentialModel.AccessKeyId;
            string accessKeySecret = credentialModel.AccessKeySecret;
            string securityToken = credentialModel.SecurityToken;
            string credentialType = credentialModel.Type;
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OpenApiClient.Client authClient = new AlibabaCloud.OpenApiClient.Client(authConfig);
            Dictionary<string, string> authRequest = new Dictionary<string, string>
            {
                {"Product", "WinNexo"},
                {"RegionId", _regionId},
            };
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest authReq = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(authRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params authParams = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeFileUpload",
                Version = "2019-12-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            Dictionary<string, object> authResponse = new Dictionary<string, object>(){};
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            Dictionary<string, object> ossHeader = new Dictionary<string, object>(){};
            Dictionary<string, object> tmpBody = new Dictionary<string, object>(){};
            bool? useAccelerate = false;
            Dictionary<string, string> authResponseBody = new Dictionary<string, string>(){};
            UploadChatFileRequest uploadChatFileReq = new UploadChatFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadChatFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new Dictionary<string, object>
                {
                    {"host", AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponseBody.Get("Endpoint"), useAccelerate, _endpointType)},
                    {"OSSAccessKeyId", authResponseBody.Get("AccessKeyId")},
                    {"policy", authResponseBody.Get("EncodedPolicy")},
                    {"Signature", authResponseBody.Get("Signature")},
                    {"key", authResponseBody.Get("ObjectKey")},
                    {"file", fileObj},
                    {"success_action_status", "201"},
                };
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader, runtime);
                uploadChatFileReq.FileUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            UploadChatFileResponse uploadChatFileResp = await UploadChatFileWithOptionsAsync(uploadChatFileReq, headers, runtime);
            return uploadChatFileResp;
        }

    }
}
