// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.RealTranslationAgent20260622.Models;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("realtranslationagent", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>取消翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTranslationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTranslationTaskResponse
        /// </returns>
        public CancelTranslationTaskResponse CancelTranslationTaskWithOptions(CancelTranslationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTranslationTask",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTranslationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTranslationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTranslationTaskResponse
        /// </returns>
        public async Task<CancelTranslationTaskResponse> CancelTranslationTaskWithOptionsAsync(CancelTranslationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTranslationTask",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTranslationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTranslationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelTranslationTaskResponse
        /// </returns>
        public CancelTranslationTaskResponse CancelTranslationTask(CancelTranslationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelTranslationTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTranslationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelTranslationTaskResponse
        /// </returns>
        public async Task<CancelTranslationTaskResponse> CancelTranslationTaskAsync(CancelTranslationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelTranslationTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取原文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOriginalFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOriginalFileUrlResponse
        /// </returns>
        public GetOriginalFileUrlResponse GetOriginalFileUrlWithOptions(GetOriginalFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOriginalFileUrl",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOriginalFileUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取原文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOriginalFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOriginalFileUrlResponse
        /// </returns>
        public async Task<GetOriginalFileUrlResponse> GetOriginalFileUrlWithOptionsAsync(GetOriginalFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOriginalFileUrl",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOriginalFileUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取原文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOriginalFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOriginalFileUrlResponse
        /// </returns>
        public GetOriginalFileUrlResponse GetOriginalFileUrl(GetOriginalFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOriginalFileUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取原文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOriginalFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOriginalFileUrlResponse
        /// </returns>
        public async Task<GetOriginalFileUrlResponse> GetOriginalFileUrlAsync(GetOriginalFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOriginalFileUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取译文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslatedFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranslatedFileUrlResponse
        /// </returns>
        public GetTranslatedFileUrlResponse GetTranslatedFileUrlWithOptions(GetTranslatedFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranslatedFileUrl",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranslatedFileUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取译文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslatedFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranslatedFileUrlResponse
        /// </returns>
        public async Task<GetTranslatedFileUrlResponse> GetTranslatedFileUrlWithOptionsAsync(GetTranslatedFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranslatedFileUrl",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranslatedFileUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取译文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslatedFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTranslatedFileUrlResponse
        /// </returns>
        public GetTranslatedFileUrlResponse GetTranslatedFileUrl(GetTranslatedFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranslatedFileUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取译文文件下载URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslatedFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTranslatedFileUrlResponse
        /// </returns>
        public async Task<GetTranslatedFileUrlResponse> GetTranslatedFileUrlAsync(GetTranslatedFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranslatedFileUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranslationTaskResponse
        /// </returns>
        public GetTranslationTaskResponse GetTranslationTaskWithOptions(GetTranslationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranslationTask",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranslationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranslationTaskResponse
        /// </returns>
        public async Task<GetTranslationTaskResponse> GetTranslationTaskWithOptionsAsync(GetTranslationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranslationTask",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranslationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTranslationTaskResponse
        /// </returns>
        public GetTranslationTaskResponse GetTranslationTask(GetTranslationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranslationTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTranslationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTranslationTaskResponse
        /// </returns>
        public async Task<GetTranslationTaskResponse> GetTranslationTaskAsync(GetTranslationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranslationTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTranslationTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTranslationTasksResponse
        /// </returns>
        public ListTranslationTasksResponse ListTranslationTasksWithOptions(ListTranslationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalFileName))
            {
                query["OriginalFileName"] = request.OriginalFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
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
                Action = "ListTranslationTasks",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranslationTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTranslationTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTranslationTasksResponse
        /// </returns>
        public async Task<ListTranslationTasksResponse> ListTranslationTasksWithOptionsAsync(ListTranslationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalFileName))
            {
                query["OriginalFileName"] = request.OriginalFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
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
                Action = "ListTranslationTasks",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranslationTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTranslationTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTranslationTasksResponse
        /// </returns>
        public ListTranslationTasksResponse ListTranslationTasks(ListTranslationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTranslationTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取翻译任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTranslationTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTranslationTasksResponse
        /// </returns>
        public async Task<ListTranslationTasksResponse> ListTranslationTasksAsync(ListTranslationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTranslationTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交翻译任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitTranslationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTranslationTaskResponse
        /// </returns>
        public SubmitTranslationTaskResponse SubmitTranslationTaskWithOptions(SubmitTranslationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTranslationTaskShrinkRequest request = new SubmitTranslationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomTerms))
            {
                request.CustomTermsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomTerms, "CustomTerms", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTermsShrink))
            {
                query["CustomTerms"] = request.CustomTermsShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseTaskId))
            {
                body["BaseTaskId"] = request.BaseTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTranslationTask",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTranslationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交翻译任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitTranslationTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTranslationTaskResponse
        /// </returns>
        public async Task<SubmitTranslationTaskResponse> SubmitTranslationTaskWithOptionsAsync(SubmitTranslationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTranslationTaskShrinkRequest request = new SubmitTranslationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomTerms))
            {
                request.CustomTermsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomTerms, "CustomTerms", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTermsShrink))
            {
                query["CustomTerms"] = request.CustomTermsShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseTaskId))
            {
                body["BaseTaskId"] = request.BaseTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTranslationTask",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTranslationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTranslationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTranslationTaskResponse
        /// </returns>
        public SubmitTranslationTaskResponse SubmitTranslationTask(SubmitTranslationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTranslationTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTranslationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTranslationTaskResponse
        /// </returns>
        public async Task<SubmitTranslationTaskResponse> SubmitTranslationTaskAsync(SubmitTranslationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTranslationTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadTranslationFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadTranslationFileResponse
        /// </returns>
        public UploadTranslationFileResponse UploadTranslationFileWithOptions(UploadTranslationFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                query["File"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadTranslationFile",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadTranslationFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadTranslationFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadTranslationFileResponse
        /// </returns>
        public async Task<UploadTranslationFileResponse> UploadTranslationFileWithOptionsAsync(UploadTranslationFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APIKey))
            {
                query["APIKey"] = request.APIKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                query["File"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadTranslationFile",
                Version = "2026-06-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadTranslationFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadTranslationFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadTranslationFileResponse
        /// </returns>
        public UploadTranslationFileResponse UploadTranslationFile(UploadTranslationFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadTranslationFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadTranslationFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadTranslationFileResponse
        /// </returns>
        public async Task<UploadTranslationFileResponse> UploadTranslationFileAsync(UploadTranslationFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadTranslationFileWithOptionsAsync(request, runtime);
        }

        public UploadTranslationFileResponse UploadTranslationFileAdvance(UploadTranslationFileAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "RealTranslationAgent"},
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
            UploadTranslationFileRequest uploadTranslationFileReq = new UploadTranslationFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadTranslationFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FileObject,
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
                uploadTranslationFileReq.File = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            UploadTranslationFileResponse uploadTranslationFileResp = UploadTranslationFileWithOptions(uploadTranslationFileReq, runtime);
            return uploadTranslationFileResp;
        }

        public async Task<UploadTranslationFileResponse> UploadTranslationFileAdvanceAsync(UploadTranslationFileAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "RealTranslationAgent"},
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
            UploadTranslationFileRequest uploadTranslationFileReq = new UploadTranslationFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadTranslationFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FileObject,
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
                uploadTranslationFileReq.File = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            UploadTranslationFileResponse uploadTranslationFileResp = await UploadTranslationFileWithOptionsAsync(uploadTranslationFileReq, runtime);
            return uploadTranslationFileResp;
        }

    }
}
