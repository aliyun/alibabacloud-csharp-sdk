// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DianJin20240628.Models;

namespace AlibabaCloud.SDK.DianJin20240628
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dianjin", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
                    string host = AlibabaCloud.TeaUtil.Common.AssertAsString(form.Get("host"));
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
                    string host = AlibabaCloud.TeaUtil.Common.AssertAsString(form.Get("host"));
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
        /// <para>创建按年文档总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnnualDocSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnualDocSummaryTaskResponse
        /// </returns>
        public CreateAnnualDocSummaryTaskResponse CreateAnnualDocSummaryTaskWithOptions(string workspaceId, CreateAnnualDocSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnaYears))
            {
                body["anaYears"] = request.AnaYears;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocInfos))
            {
                body["docInfos"] = request.DocInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnualDocSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/doc/annual",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAnnualDocSummaryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建按年文档总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnnualDocSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnualDocSummaryTaskResponse
        /// </returns>
        public async Task<CreateAnnualDocSummaryTaskResponse> CreateAnnualDocSummaryTaskWithOptionsAsync(string workspaceId, CreateAnnualDocSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnaYears))
            {
                body["anaYears"] = request.AnaYears;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocInfos))
            {
                body["docInfos"] = request.DocInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnualDocSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/doc/annual",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAnnualDocSummaryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建按年文档总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnnualDocSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnualDocSummaryTaskResponse
        /// </returns>
        public CreateAnnualDocSummaryTaskResponse CreateAnnualDocSummaryTask(string workspaceId, CreateAnnualDocSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAnnualDocSummaryTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建按年文档总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnnualDocSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAnnualDocSummaryTaskResponse
        /// </returns>
        public async Task<CreateAnnualDocSummaryTaskResponse> CreateAnnualDocSummaryTaskAsync(string workspaceId, CreateAnnualDocSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAnnualDocSummaryTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogResponse
        /// </returns>
        public CreateDialogResponse CreateDialogWithOptions(string workspaceId, CreateDialogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLibrary))
            {
                body["enableLibrary"] = request.EnableLibrary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayCode))
            {
                body["playCode"] = request.PlayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QaLibraryList))
            {
                body["qaLibraryList"] = request.QaLibraryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfDirected))
            {
                body["selfDirected"] = request.SelfDirected;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDialog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDialogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogResponse
        /// </returns>
        public async Task<CreateDialogResponse> CreateDialogWithOptionsAsync(string workspaceId, CreateDialogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLibrary))
            {
                body["enableLibrary"] = request.EnableLibrary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayCode))
            {
                body["playCode"] = request.PlayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QaLibraryList))
            {
                body["qaLibraryList"] = request.QaLibraryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfDirected))
            {
                body["selfDirected"] = request.SelfDirected;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDialog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDialogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogResponse
        /// </returns>
        public CreateDialogResponse CreateDialog(string workspaceId, CreateDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDialogWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogResponse
        /// </returns>
        public async Task<CreateDialogResponse> CreateDialogAsync(string workspaceId, CreateDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDialogWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogAnalysisTaskResponse
        /// </returns>
        public CreateDialogAnalysisTaskResponse CreateDialogAnalysisTaskWithOptions(string workspaceId, CreateDialogAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisNodes))
            {
                body["analysisNodes"] = request.AnalysisNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationList))
            {
                body["conversationList"] = request.ConversationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayCode))
            {
                body["playCode"] = request.PlayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDialogAnalysisTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/analysis/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDialogAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogAnalysisTaskResponse
        /// </returns>
        public async Task<CreateDialogAnalysisTaskResponse> CreateDialogAnalysisTaskWithOptionsAsync(string workspaceId, CreateDialogAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisNodes))
            {
                body["analysisNodes"] = request.AnalysisNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationList))
            {
                body["conversationList"] = request.ConversationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayCode))
            {
                body["playCode"] = request.PlayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDialogAnalysisTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/analysis/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDialogAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogAnalysisTaskResponse
        /// </returns>
        public CreateDialogAnalysisTaskResponse CreateDialogAnalysisTask(string workspaceId, CreateDialogAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDialogAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDialogAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDialogAnalysisTaskResponse
        /// </returns>
        public async Task<CreateDialogAnalysisTaskResponse> CreateDialogAnalysisTaskAsync(string workspaceId, CreateDialogAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDialogAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocsSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDocsSummaryTaskResponse
        /// </returns>
        public CreateDocsSummaryTaskResponse CreateDocsSummaryTaskWithOptions(string workspaceId, CreateDocsSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocInfos))
            {
                body["docInfos"] = request.DocInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDocsSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/docs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDocsSummaryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocsSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDocsSummaryTaskResponse
        /// </returns>
        public async Task<CreateDocsSummaryTaskResponse> CreateDocsSummaryTaskWithOptionsAsync(string workspaceId, CreateDocsSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocInfos))
            {
                body["docInfos"] = request.DocInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDocsSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/docs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDocsSummaryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocsSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDocsSummaryTaskResponse
        /// </returns>
        public CreateDocsSummaryTaskResponse CreateDocsSummaryTask(string workspaceId, CreateDocsSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDocsSummaryTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDocsSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDocsSummaryTaskResponse
        /// </returns>
        public async Task<CreateDocsSummaryTaskResponse> CreateDocsSummaryTaskAsync(string workspaceId, CreateDocsSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDocsSummaryTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public CreateFinReportSummaryTaskResponse CreateFinReportSummaryTaskWithOptions(string workspaceId, CreateFinReportSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                body["endPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                body["startPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFinReportSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFinReportSummaryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public async Task<CreateFinReportSummaryTaskResponse> CreateFinReportSummaryTaskWithOptionsAsync(string workspaceId, CreateFinReportSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                body["endPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                body["startPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFinReportSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFinReportSummaryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public CreateFinReportSummaryTaskResponse CreateFinReportSummaryTask(string workspaceId, CreateFinReportSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFinReportSummaryTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public async Task<CreateFinReportSummaryTaskResponse> CreateFinReportSummaryTaskAsync(string workspaceId, CreateFinReportSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFinReportSummaryTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateImageDetectionTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public CreateImageDetectionTaskResponse CreateImageDetectionTaskWithOptions(string workspaceId, CreateImageDetectionTaskRequest request, CreateImageDetectionTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfo))
            {
                body["fileInfo"] = request.FileInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageDetectionTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/imageDetect/task/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageDetectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateImageDetectionTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageDetectionTaskResponse> CreateImageDetectionTaskWithOptionsAsync(string workspaceId, CreateImageDetectionTaskRequest request, CreateImageDetectionTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfo))
            {
                body["fileInfo"] = request.FileInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageDetectionTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/imageDetect/task/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageDetectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public CreateImageDetectionTaskResponse CreateImageDetectionTask(string workspaceId, CreateImageDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateImageDetectionTaskHeaders headers = new CreateImageDetectionTaskHeaders();
            return CreateImageDetectionTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建图片检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageDetectionTaskResponse> CreateImageDetectionTaskAsync(string workspaceId, CreateImageDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateImageDetectionTaskHeaders headers = new CreateImageDetectionTaskHeaders();
            return await CreateImageDetectionTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public CreateLibraryResponse CreateLibraryWithOptions(string workspaceId, CreateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public async Task<CreateLibraryResponse> CreateLibraryWithOptionsAsync(string workspaceId, CreateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public CreateLibraryResponse CreateLibrary(string workspaceId, CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public async Task<CreateLibraryResponse> CreateLibraryAsync(string workspaceId, CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public CreatePdfTranslateTaskResponse CreatePdfTranslateTaskWithOptions(string workspaceId, CreatePdfTranslateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                body["knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateTo))
            {
                body["translateTo"] = request.TranslateTo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdfTranslateTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/pdfTranslate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdfTranslateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public async Task<CreatePdfTranslateTaskResponse> CreatePdfTranslateTaskWithOptionsAsync(string workspaceId, CreatePdfTranslateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                body["knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateTo))
            {
                body["translateTo"] = request.TranslateTo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdfTranslateTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/pdfTranslate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdfTranslateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public CreatePdfTranslateTaskResponse CreatePdfTranslateTask(string workspaceId, CreatePdfTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePdfTranslateTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public async Task<CreatePdfTranslateTaskResponse> CreatePdfTranslateTaskAsync(string workspaceId, CreatePdfTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePdfTranslateTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public CreatePredefinedDocumentResponse CreatePredefinedDocumentWithOptions(string workspaceId, CreatePredefinedDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePredefinedDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/createPredefinedDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePredefinedDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public async Task<CreatePredefinedDocumentResponse> CreatePredefinedDocumentWithOptionsAsync(string workspaceId, CreatePredefinedDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePredefinedDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/createPredefinedDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePredefinedDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public CreatePredefinedDocumentResponse CreatePredefinedDocument(string workspaceId, CreatePredefinedDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePredefinedDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public async Task<CreatePredefinedDocumentResponse> CreatePredefinedDocumentAsync(string workspaceId, CreatePredefinedDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePredefinedDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckTaskResponse
        /// </returns>
        public CreateQualityCheckTaskResponse CreateQualityCheckTaskWithOptions(string workspaceId, CreateQualityCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationList))
            {
                body["conversationList"] = request.ConversationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtService))
            {
                body["gmtService"] = request.GmtService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityGroup))
            {
                body["qualityGroup"] = request.QualityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["sceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityCheckTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/qualitycheck/task/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckTaskResponse
        /// </returns>
        public async Task<CreateQualityCheckTaskResponse> CreateQualityCheckTaskWithOptionsAsync(string workspaceId, CreateQualityCheckTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationList))
            {
                body["conversationList"] = request.ConversationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtService))
            {
                body["gmtService"] = request.GmtService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityGroup))
            {
                body["qualityGroup"] = request.QualityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["sceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityCheckTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/qualitycheck/task/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckTaskResponse
        /// </returns>
        public CreateQualityCheckTaskResponse CreateQualityCheckTask(string workspaceId, CreateQualityCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateQualityCheckTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckTaskResponse
        /// </returns>
        public async Task<CreateQualityCheckTaskResponse> CreateQualityCheckTaskAsync(string workspaceId, CreateQualityCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateQualityCheckTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoCreationTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateVideoCreationTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoCreationTaskResponse
        /// </returns>
        public CreateVideoCreationTaskResponse CreateVideoCreationTaskWithOptions(string workspaceId, CreateVideoCreationTaskRequest request, CreateVideoCreationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationInstruction))
            {
                body["creationInstruction"] = request.CreationInstruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfo))
            {
                body["fileInfo"] = request.FileInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageDetectionTaskId))
            {
                body["imageDetectionTaskId"] = request.ImageDetectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoCreationTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/videoCreation/task/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoCreationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoCreationTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateVideoCreationTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoCreationTaskResponse
        /// </returns>
        public async Task<CreateVideoCreationTaskResponse> CreateVideoCreationTaskWithOptionsAsync(string workspaceId, CreateVideoCreationTaskRequest request, CreateVideoCreationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreationInstruction))
            {
                body["creationInstruction"] = request.CreationInstruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfo))
            {
                body["fileInfo"] = request.FileInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageDetectionTaskId))
            {
                body["imageDetectionTaskId"] = request.ImageDetectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoCreationTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/videoCreation/task/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoCreationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoCreationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoCreationTaskResponse
        /// </returns>
        public CreateVideoCreationTaskResponse CreateVideoCreationTask(string workspaceId, CreateVideoCreationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoCreationTaskHeaders headers = new CreateVideoCreationTaskHeaders();
            return CreateVideoCreationTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建视频生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoCreationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoCreationTaskResponse
        /// </returns>
        public async Task<CreateVideoCreationTaskResponse> CreateVideoCreationTaskAsync(string workspaceId, CreateVideoCreationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVideoCreationTaskHeaders headers = new CreateVideoCreationTaskHeaders();
            return await CreateVideoCreationTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public DeleteDocumentResponse DeleteDocumentWithOptions(string workspaceId, DeleteDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIds))
            {
                body["docIds"] = request.DocIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public async Task<DeleteDocumentResponse> DeleteDocumentWithOptionsAsync(string workspaceId, DeleteDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIds))
            {
                body["docIds"] = request.DocIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public DeleteDocumentResponse DeleteDocument(string workspaceId, DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public async Task<DeleteDocumentResponse> DeleteDocumentAsync(string workspaceId, DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public DeleteLibraryResponse DeleteLibraryWithOptions(string workspaceId, DeleteLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public async Task<DeleteLibraryResponse> DeleteLibraryWithOptionsAsync(string workspaceId, DeleteLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public DeleteLibraryResponse DeleteLibrary(string workspaceId, DeleteLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public async Task<DeleteLibraryResponse> DeleteLibraryAsync(string workspaceId, DeleteLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>端到端实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndToEndRealTimeDialogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EndToEndRealTimeDialogResponse
        /// </returns>
        public EndToEndRealTimeDialogResponse EndToEndRealTimeDialogWithOptions(string workspaceId, EndToEndRealTimeDialogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["asrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputFormat))
            {
                query["inputFormat"] = request.InputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                query["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["pitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                query["sampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["speechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsModelId))
            {
                query["ttsModelId"] = request.TtsModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["voiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndToEndRealTimeDialog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ws/realtime/dialog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndToEndRealTimeDialogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>端到端实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndToEndRealTimeDialogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EndToEndRealTimeDialogResponse
        /// </returns>
        public async Task<EndToEndRealTimeDialogResponse> EndToEndRealTimeDialogWithOptionsAsync(string workspaceId, EndToEndRealTimeDialogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["asrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputFormat))
            {
                query["inputFormat"] = request.InputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                query["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["pitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                query["sampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["speechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsModelId))
            {
                query["ttsModelId"] = request.TtsModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["voiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndToEndRealTimeDialog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/ws/realtime/dialog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndToEndRealTimeDialogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>端到端实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndToEndRealTimeDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// EndToEndRealTimeDialogResponse
        /// </returns>
        public EndToEndRealTimeDialogResponse EndToEndRealTimeDialog(string workspaceId, EndToEndRealTimeDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EndToEndRealTimeDialogWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>端到端实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EndToEndRealTimeDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// EndToEndRealTimeDialogResponse
        /// </returns>
        public async Task<EndToEndRealTimeDialogResponse> EndToEndRealTimeDialogAsync(string workspaceId, EndToEndRealTimeDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EndToEndRealTimeDialogWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public EvictTaskResponse EvictTaskWithOptions(string workspaceId, EvictTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvictTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/evict",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvictTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public async Task<EvictTaskResponse> EvictTaskWithOptionsAsync(string workspaceId, EvictTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvictTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/evict",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvictTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public EvictTaskResponse EvictTask(string workspaceId, EvictTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EvictTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public async Task<EvictTaskResponse> EvictTaskAsync(string workspaceId, EvictTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EvictTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文档解析问答QA</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenDocQaResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenDocQaResultResponse
        /// </returns>
        public GenDocQaResultResponse GenDocQaResultWithOptions(string workspaceId, GenDocQaResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenDocQaResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/qa/parse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenDocQaResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文档解析问答QA</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenDocQaResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenDocQaResultResponse
        /// </returns>
        public async Task<GenDocQaResultResponse> GenDocQaResultWithOptionsAsync(string workspaceId, GenDocQaResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenDocQaResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/qa/parse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenDocQaResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文档解析问答QA</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenDocQaResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GenDocQaResultResponse
        /// </returns>
        public GenDocQaResultResponse GenDocQaResult(string workspaceId, GenDocQaResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenDocQaResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据文档解析问答QA</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenDocQaResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GenDocQaResultResponse
        /// </returns>
        public async Task<GenDocQaResultResponse> GenDocQaResultAsync(string workspaceId, GenDocQaResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenDocQaResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
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
        /// GetAppConfigResponse
        /// </returns>
        public GetAppConfigResponse GetAppConfigWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppConfig",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/app/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
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
        /// GetAppConfigResponse
        /// </returns>
        public async Task<GetAppConfigResponse> GetAppConfigWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppConfig",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/app/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAppConfigResponse
        /// </returns>
        public GetAppConfigResponse GetAppConfig(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppConfigWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAppConfigResponse
        /// </returns>
        public async Task<GetAppConfigResponse> GetAppConfigAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppConfigWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问答结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatQuestionRespRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatQuestionRespResponse
        /// </returns>
        public GetChatQuestionRespResponse GetChatQuestionRespWithOptions(string workspaceId, GetChatQuestionRespRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatQuestionResp",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/chat/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatQuestionRespResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问答结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatQuestionRespRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatQuestionRespResponse
        /// </returns>
        public async Task<GetChatQuestionRespResponse> GetChatQuestionRespWithOptionsAsync(string workspaceId, GetChatQuestionRespRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                body["batchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatQuestionResp",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/chat/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatQuestionRespResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问答结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatQuestionRespRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatQuestionRespResponse
        /// </returns>
        public GetChatQuestionRespResponse GetChatQuestionResp(string workspaceId, GetChatQuestionRespRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChatQuestionRespWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取问答结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatQuestionRespRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatQuestionRespResponse
        /// </returns>
        public async Task<GetChatQuestionRespResponse> GetChatQuestionRespAsync(string workspaceId, GetChatQuestionRespRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChatQuestionRespWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogAnalysisResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDialogAnalysisResultResponse
        /// </returns>
        public GetDialogAnalysisResultResponse GetDialogAnalysisResultWithOptions(string workspaceId, GetDialogAnalysisResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                body["sessionIds"] = request.SessionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrl))
            {
                body["useUrl"] = request.UseUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDialogAnalysisResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDialogAnalysisResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogAnalysisResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDialogAnalysisResultResponse
        /// </returns>
        public async Task<GetDialogAnalysisResultResponse> GetDialogAnalysisResultWithOptionsAsync(string workspaceId, GetDialogAnalysisResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                body["sessionIds"] = request.SessionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrl))
            {
                body["useUrl"] = request.UseUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDialogAnalysisResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDialogAnalysisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDialogAnalysisResultResponse
        /// </returns>
        public GetDialogAnalysisResultResponse GetDialogAnalysisResult(string workspaceId, GetDialogAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDialogAnalysisResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDialogAnalysisResultResponse
        /// </returns>
        public async Task<GetDialogAnalysisResultResponse> GetDialogAnalysisResultAsync(string workspaceId, GetDialogAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDialogAnalysisResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDialogDetailResponse
        /// </returns>
        public GetDialogDetailResponse GetDialogDetailWithOptions(string workspaceId, GetDialogDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDialogDetail",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDialogDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDialogDetailResponse
        /// </returns>
        public async Task<GetDialogDetailResponse> GetDialogDetailWithOptionsAsync(string workspaceId, GetDialogDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDialogDetail",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDialogDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDialogDetailResponse
        /// </returns>
        public GetDialogDetailResponse GetDialogDetail(string workspaceId, GetDialogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDialogDetailWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDialogDetailResponse
        /// </returns>
        public async Task<GetDialogDetailResponse> GetDialogDetailAsync(string workspaceId, GetDialogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDialogDetailWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDialogLogResponse
        /// </returns>
        public GetDialogLogResponse GetDialogLogWithOptions(string workspaceId, GetDialogLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDialogLog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/dialog/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDialogLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDialogLogResponse
        /// </returns>
        public async Task<GetDialogLogResponse> GetDialogLogWithOptionsAsync(string workspaceId, GetDialogLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDialogLog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/dialog/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDialogLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDialogLogResponse
        /// </returns>
        public GetDialogLogResponse GetDialogLog(string workspaceId, GetDialogLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDialogLogWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDialogLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDialogLogResponse
        /// </returns>
        public async Task<GetDialogLogResponse> GetDialogLogAsync(string workspaceId, GetDialogLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDialogLogWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public GetDocumentChunkListResponse GetDocumentChunkListWithOptions(string workspaceId, GetDocumentChunkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdList))
            {
                body["chunkIdList"] = request.ChunkIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentChunkList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/getDocumentChunk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentChunkListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public async Task<GetDocumentChunkListResponse> GetDocumentChunkListWithOptionsAsync(string workspaceId, GetDocumentChunkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdList))
            {
                body["chunkIdList"] = request.ChunkIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentChunkList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/getDocumentChunk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentChunkListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public GetDocumentChunkListResponse GetDocumentChunkList(string workspaceId, GetDocumentChunkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentChunkListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public async Task<GetDocumentChunkListResponse> GetDocumentChunkListAsync(string workspaceId, GetDocumentChunkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentChunkListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public GetDocumentListResponse GetDocumentListWithOptions(string workspaceId, GetDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/listDocument",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public async Task<GetDocumentListResponse> GetDocumentListWithOptionsAsync(string workspaceId, GetDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/listDocument",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public GetDocumentListResponse GetDocumentList(string workspaceId, GetDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public async Task<GetDocumentListResponse> GetDocumentListAsync(string workspaceId, GetDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public GetDocumentUrlResponse GetDocumentUrlWithOptions(string workspaceId, GetDocumentUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentUrl",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public async Task<GetDocumentUrlResponse> GetDocumentUrlWithOptionsAsync(string workspaceId, GetDocumentUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentUrl",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public GetDocumentUrlResponse GetDocumentUrl(string workspaceId, GetDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentUrlWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public async Task<GetDocumentUrlResponse> GetDocumentUrlAsync(string workspaceId, GetDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentUrlWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public GetFilterDocumentListResponse GetFilterDocumentListWithOptions(string workspaceId, GetFilterDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.And))
            {
                body["and"] = request.And;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Or))
            {
                body["or"] = request.Or;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFilterDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/filterDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilterDocumentListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public async Task<GetFilterDocumentListResponse> GetFilterDocumentListWithOptionsAsync(string workspaceId, GetFilterDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.And))
            {
                body["and"] = request.And;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Or))
            {
                body["or"] = request.Or;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFilterDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/filterDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilterDocumentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public GetFilterDocumentListResponse GetFilterDocumentList(string workspaceId, GetFilterDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFilterDocumentListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public async Task<GetFilterDocumentListResponse> GetFilterDocumentListAsync(string workspaceId, GetFilterDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFilterDocumentListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public GetHistoryListByBizTypeResponse GetHistoryListByBizTypeWithOptions(string workspaceId, GetHistoryListByBizTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoryListByBizType",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/history/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryListByBizTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public async Task<GetHistoryListByBizTypeResponse> GetHistoryListByBizTypeWithOptionsAsync(string workspaceId, GetHistoryListByBizTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoryListByBizType",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/history/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryListByBizTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public GetHistoryListByBizTypeResponse GetHistoryListByBizType(string workspaceId, GetHistoryListByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHistoryListByBizTypeWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public async Task<GetHistoryListByBizTypeResponse> GetHistoryListByBizTypeAsync(string workspaceId, GetHistoryListByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHistoryListByBizTypeWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// GetImageDetectionTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public GetImageDetectionTaskResultResponse GetImageDetectionTaskResultWithOptions(string workspaceId, GetImageDetectionTaskResultRequest request, GetImageDetectionTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageDetectionTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/imageDetect/task/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageDetectionTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// GetImageDetectionTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageDetectionTaskResultResponse> GetImageDetectionTaskResultWithOptionsAsync(string workspaceId, GetImageDetectionTaskResultRequest request, GetImageDetectionTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageDetectionTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/imageDetect/task/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageDetectionTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public GetImageDetectionTaskResultResponse GetImageDetectionTaskResult(string workspaceId, GetImageDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetImageDetectionTaskResultHeaders headers = new GetImageDetectionTaskResultHeaders();
            return GetImageDetectionTaskResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageDetectionTaskResultResponse> GetImageDetectionTaskResultAsync(string workspaceId, GetImageDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetImageDetectionTaskResultHeaders headers = new GetImageDetectionTaskResultHeaders();
            return await GetImageDetectionTaskResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public GetLibraryResponse GetLibraryWithOptions(string workspaceId, GetLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public async Task<GetLibraryResponse> GetLibraryWithOptionsAsync(string workspaceId, GetLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public GetLibraryResponse GetLibrary(string workspaceId, GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public async Task<GetLibraryResponse> GetLibraryAsync(string workspaceId, GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public GetLibraryListResponse GetLibraryListWithOptions(string workspaceId, GetLibraryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibraryList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public async Task<GetLibraryListResponse> GetLibraryListWithOptionsAsync(string workspaceId, GetLibraryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibraryList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public GetLibraryListResponse GetLibraryList(string workspaceId, GetLibraryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLibraryListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public async Task<GetLibraryListResponse> GetLibraryListAsync(string workspaceId, GetLibraryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLibraryListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public GetParseResultResponse GetParseResultWithOptions(string workspaceId, GetParseResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrlResult))
            {
                body["useUrlResult"] = request.UseUrlResult;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/getParseResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public async Task<GetParseResultResponse> GetParseResultWithOptionsAsync(string workspaceId, GetParseResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrlResult))
            {
                body["useUrlResult"] = request.UseUrlResult;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/getParseResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public GetParseResultResponse GetParseResult(string workspaceId, GetParseResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetParseResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public async Task<GetParseResultResponse> GetParseResultAsync(string workspaceId, GetParseResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetParseResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckTaskResultResponse
        /// </returns>
        public GetQualityCheckTaskResultResponse GetQualityCheckTaskResultWithOptions(string workspaceId, GetQualityCheckTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityCheckTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/qualitycheck/task/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityCheckTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckTaskResultResponse
        /// </returns>
        public async Task<GetQualityCheckTaskResultResponse> GetQualityCheckTaskResultWithOptionsAsync(string workspaceId, GetQualityCheckTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityCheckTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/qualitycheck/task/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityCheckTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckTaskResultResponse
        /// </returns>
        public GetQualityCheckTaskResultResponse GetQualityCheckTaskResult(string workspaceId, GetQualityCheckTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQualityCheckTaskResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckTaskResultResponse
        /// </returns>
        public async Task<GetQualityCheckTaskResultResponse> GetQualityCheckTaskResultAsync(string workspaceId, GetQualityCheckTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQualityCheckTaskResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public GetSummaryTaskResultResponse GetSummaryTaskResultWithOptions(string workspaceId, GetSummaryTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSummaryTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public async Task<GetSummaryTaskResultResponse> GetSummaryTaskResultWithOptionsAsync(string workspaceId, GetSummaryTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSummaryTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public GetSummaryTaskResultResponse GetSummaryTaskResult(string workspaceId, GetSummaryTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSummaryTaskResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public async Task<GetSummaryTaskResultResponse> GetSummaryTaskResultAsync(string workspaceId, GetSummaryTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSummaryTaskResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public GetTaskResultResponse GetTaskResultWithOptions(string workspaceId, GetTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public async Task<GetTaskResultResponse> GetTaskResultWithOptionsAsync(string workspaceId, GetTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public GetTaskResultResponse GetTaskResult(string workspaceId, GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public async Task<GetTaskResultResponse> GetTaskResultAsync(string workspaceId, GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public GetTaskStatusResponse GetTaskStatusWithOptions(string workspaceId, GetTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(string workspaceId, GetTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public GetTaskStatusResponse GetTaskStatus(string workspaceId, GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskStatusWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(string workspaceId, GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskStatusWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频生成任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreationTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// GetVideoCreationTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreationTaskResultResponse
        /// </returns>
        public GetVideoCreationTaskResultResponse GetVideoCreationTaskResultWithOptions(string workspaceId, GetVideoCreationTaskResultRequest request, GetVideoCreationTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoCreationTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/videoCreation/task/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoCreationTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频生成任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreationTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// GetVideoCreationTaskResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreationTaskResultResponse
        /// </returns>
        public async Task<GetVideoCreationTaskResultResponse> GetVideoCreationTaskResultWithOptionsAsync(string workspaceId, GetVideoCreationTaskResultRequest request, GetVideoCreationTaskResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XLoadTest))
            {
                realHeaders["X-Load-Test"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XLoadTest);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoCreationTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/videoCreation/task/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoCreationTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频生成任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreationTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreationTaskResultResponse
        /// </returns>
        public GetVideoCreationTaskResultResponse GetVideoCreationTaskResult(string workspaceId, GetVideoCreationTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVideoCreationTaskResultHeaders headers = new GetVideoCreationTaskResultHeaders();
            return GetVideoCreationTaskResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取视频生成任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreationTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreationTaskResultResponse
        /// </returns>
        public async Task<GetVideoCreationTaskResultResponse> GetVideoCreationTaskResultAsync(string workspaceId, GetVideoCreationTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetVideoCreationTaskResultHeaders headers = new GetVideoCreationTaskResultHeaders();
            return await GetVideoCreationTaskResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public InvokePluginResponse InvokePluginWithOptions(string workspaceId, InvokePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokePlugin",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/plugin/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokePluginResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public async Task<InvokePluginResponse> InvokePluginWithOptionsAsync(string workspaceId, InvokePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokePlugin",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/plugin/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokePluginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public InvokePluginResponse InvokePlugin(string workspaceId, InvokePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvokePluginWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public async Task<InvokePluginResponse> InvokePluginAsync(string workspaceId, InvokePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvokePluginWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public PreviewDocumentResponse PreviewDocumentWithOptions(string workspaceId, PreviewDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public async Task<PreviewDocumentResponse> PreviewDocumentWithOptionsAsync(string workspaceId, PreviewDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public PreviewDocumentResponse PreviewDocument(string workspaceId, PreviewDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreviewDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public async Task<PreviewDocumentResponse> PreviewDocumentAsync(string workspaceId, PreviewDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreviewDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public ReIndexResponse ReIndexWithOptions(string workspaceId, ReIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReIndex",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/reIndex",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public async Task<ReIndexResponse> ReIndexWithOptionsAsync(string workspaceId, ReIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReIndex",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/reIndex",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public ReIndexResponse ReIndex(string workspaceId, ReIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReIndexWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public async Task<ReIndexResponse> ReIndexAsync(string workspaceId, ReIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReIndexWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealTimeDialogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RealTimeDialogResponse
        /// </returns>
        public RealTimeDialogResponse RealTimeDialogWithOptions(string workspaceId, RealTimeDialogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationModel))
            {
                body["conversationModel"] = request.ConversationModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogMemoryTurns))
            {
                body["dialogMemoryTurns"] = request.DialogMemoryTurns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recommend))
            {
                body["recommend"] = request.Recommend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContentPlayed))
            {
                body["scriptContentPlayed"] = request.ScriptContentPlayed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVad))
            {
                body["userVad"] = request.UserVad;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RealTimeDialog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/realtime/dialog/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RealTimeDialogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealTimeDialogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RealTimeDialogResponse
        /// </returns>
        public async Task<RealTimeDialogResponse> RealTimeDialogWithOptionsAsync(string workspaceId, RealTimeDialogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationModel))
            {
                body["conversationModel"] = request.ConversationModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogMemoryTurns))
            {
                body["dialogMemoryTurns"] = request.DialogMemoryTurns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recommend))
            {
                body["recommend"] = request.Recommend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptContentPlayed))
            {
                body["scriptContentPlayed"] = request.ScriptContentPlayed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVad))
            {
                body["userVad"] = request.UserVad;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RealTimeDialog",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/realtime/dialog/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RealTimeDialogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealTimeDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// RealTimeDialogResponse
        /// </returns>
        public RealTimeDialogResponse RealTimeDialog(string workspaceId, RealTimeDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RealTimeDialogWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealTimeDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// RealTimeDialogResponse
        /// </returns>
        public async Task<RealTimeDialogResponse> RealTimeDialogAsync(string workspaceId, RealTimeDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RealTimeDialogWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时会话辅助</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealtimeDialogAssistRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RealtimeDialogAssistResponse
        /// </returns>
        public RealtimeDialogAssistResponse RealtimeDialogAssistWithOptions(string workspaceId, RealtimeDialogAssistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationModel))
            {
                body["conversationModel"] = request.ConversationModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogMemoryTurns))
            {
                body["dialogMemoryTurns"] = request.DialogMemoryTurns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HangUpDialog))
            {
                body["hangUpDialog"] = request.HangUpDialog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RealtimeDialogAssist",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/realtime/dialog/assist",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RealtimeDialogAssistResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时会话辅助</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealtimeDialogAssistRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RealtimeDialogAssistResponse
        /// </returns>
        public async Task<RealtimeDialogAssistResponse> RealtimeDialogAssistWithOptionsAsync(string workspaceId, RealtimeDialogAssistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationModel))
            {
                body["conversationModel"] = request.ConversationModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogMemoryTurns))
            {
                body["dialogMemoryTurns"] = request.DialogMemoryTurns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HangUpDialog))
            {
                body["hangUpDialog"] = request.HangUpDialog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaData))
            {
                body["metaData"] = request.MetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RealtimeDialogAssist",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/realtime/dialog/assist",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RealtimeDialogAssistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时会话辅助</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealtimeDialogAssistRequest
        /// </param>
        /// 
        /// <returns>
        /// RealtimeDialogAssistResponse
        /// </returns>
        public RealtimeDialogAssistResponse RealtimeDialogAssist(string workspaceId, RealtimeDialogAssistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RealtimeDialogAssistWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时会话辅助</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RealtimeDialogAssistRequest
        /// </param>
        /// 
        /// <returns>
        /// RealtimeDialogAssistResponse
        /// </returns>
        public async Task<RealtimeDialogAssistResponse> RealtimeDialogAssistAsync(string workspaceId, RealtimeDialogAssistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RealtimeDialogAssistWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebuildTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebuildTaskResponse
        /// </returns>
        public RebuildTaskResponse RebuildTaskWithOptions(string workspaceId, RebuildTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebuildTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/rebuild",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebuildTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebuildTaskResponse
        /// </returns>
        public async Task<RebuildTaskResponse> RebuildTaskWithOptionsAsync(string workspaceId, RebuildTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebuildTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/rebuild",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebuildTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RebuildTaskResponse
        /// </returns>
        public RebuildTaskResponse RebuildTask(string workspaceId, RebuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RebuildTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebuildTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RebuildTaskResponse
        /// </returns>
        public async Task<RebuildTaskResponse> RebuildTaskAsync(string workspaceId, RebuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RebuildTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public RecallDocumentResponse RecallDocumentWithOptions(string workspaceId, RecallDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rearrangement))
            {
                body["rearrangement"] = request.Rearrangement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecallDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/recallDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public async Task<RecallDocumentResponse> RecallDocumentWithOptionsAsync(string workspaceId, RecallDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rearrangement))
            {
                body["rearrangement"] = request.Rearrangement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecallDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/recallDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public RecallDocumentResponse RecallDocument(string workspaceId, RecallDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecallDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public async Task<RecallDocumentResponse> RecallDocumentAsync(string workspaceId, RecallDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecallDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public RecognizeIntentionResponse RecognizeIntentionWithOptions(string workspaceId, RecognizeIntentionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conversation))
            {
                body["conversation"] = request.Conversation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIntentionList))
            {
                body["globalIntentionList"] = request.GlobalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HierarchicalIntentionList))
            {
                body["hierarchicalIntentionList"] = request.HierarchicalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionDomainCode))
            {
                body["intentionDomainCode"] = request.IntentionDomainCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionList))
            {
                body["intentionList"] = request.IntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recommend))
            {
                body["recommend"] = request.Recommend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIntention",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/recog/intent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIntentionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public async Task<RecognizeIntentionResponse> RecognizeIntentionWithOptionsAsync(string workspaceId, RecognizeIntentionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conversation))
            {
                body["conversation"] = request.Conversation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIntentionList))
            {
                body["globalIntentionList"] = request.GlobalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HierarchicalIntentionList))
            {
                body["hierarchicalIntentionList"] = request.HierarchicalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionDomainCode))
            {
                body["intentionDomainCode"] = request.IntentionDomainCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionList))
            {
                body["intentionList"] = request.IntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recommend))
            {
                body["recommend"] = request.Recommend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIntention",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/recog/intent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIntentionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public RecognizeIntentionResponse RecognizeIntention(string workspaceId, RecognizeIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecognizeIntentionWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public async Task<RecognizeIntentionResponse> RecognizeIntentionAsync(string workspaceId, RecognizeIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecognizeIntentionWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunAgentResponse
        /// </returns>
        public RunAgentResponse RunAgentWithOptions(string workspaceId, RunAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                body["botId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadId))
            {
                body["threadId"] = request.ThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseDraft))
            {
                body["useDraft"] = request.UseDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserContent))
            {
                body["userContent"] = request.UserContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInputs))
            {
                body["userInputs"] = request.UserInputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunAgent",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/bot/thread/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunAgentResponse
        /// </returns>
        public async Task<RunAgentResponse> RunAgentWithOptionsAsync(string workspaceId, RunAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                body["botId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadId))
            {
                body["threadId"] = request.ThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseDraft))
            {
                body["useDraft"] = request.UseDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserContent))
            {
                body["userContent"] = request.UserContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInputs))
            {
                body["userInputs"] = request.UserInputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunAgent",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/bot/thread/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunAgentResponse
        /// </returns>
        public RunAgentResponse RunAgent(string workspaceId, RunAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunAgentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunAgentResponse
        /// </returns>
        public async Task<RunAgentResponse> RunAgentAsync(string workspaceId, RunAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunAgentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public RunChatResultGenerationResponse RunChatResultGenerationWithOptions(string workspaceId, RunChatResultGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceParameters))
            {
                body["inferenceParameters"] = request.InferenceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunChatResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunChatResultGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public async Task<RunChatResultGenerationResponse> RunChatResultGenerationWithOptionsAsync(string workspaceId, RunChatResultGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceParameters))
            {
                body["inferenceParameters"] = request.InferenceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunChatResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunChatResultGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public RunChatResultGenerationResponse RunChatResultGeneration(string workspaceId, RunChatResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunChatResultGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public async Task<RunChatResultGenerationResponse> RunChatResultGenerationAsync(string workspaceId, RunChatResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunChatResultGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDialogAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDialogAnalysisResponse
        /// </returns>
        public RunDialogAnalysisResponse RunDialogAnalysisWithOptions(string workspaceId, RunDialogAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDialogAnalysis",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/stream/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDialogAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDialogAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDialogAnalysisResponse
        /// </returns>
        public async Task<RunDialogAnalysisResponse> RunDialogAnalysisWithOptionsAsync(string workspaceId, RunDialogAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDialogAnalysis",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/dialog/stream/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDialogAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDialogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDialogAnalysisResponse
        /// </returns>
        public RunDialogAnalysisResponse RunDialogAnalysis(string workspaceId, RunDialogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunDialogAnalysisWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式获取外呼会话分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDialogAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDialogAnalysisResponse
        /// </returns>
        public async Task<RunDialogAnalysisResponse> RunDialogAnalysisAsync(string workspaceId, RunDialogAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunDialogAnalysisWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public RunLibraryChatGenerationResponse RunLibraryChatGenerationWithOptions(string workspaceId, RunLibraryChatGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFollowUp))
            {
                body["enableFollowUp"] = request.EnableFollowUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMultiQuery))
            {
                body["enableMultiQuery"] = request.EnableMultiQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOpenQa))
            {
                body["enableOpenQa"] = request.EnableOpenQa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowUpLlm))
            {
                body["followUpLlm"] = request.FollowUpLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmType))
            {
                body["llmType"] = request.LlmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiQueryLlm))
            {
                body["multiQueryLlm"] = request.MultiQueryLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCriteria))
            {
                body["queryCriteria"] = request.QueryCriteria;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankType))
            {
                body["rerankType"] = request.RerankType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQueryList))
            {
                body["subQueryList"] = request.SubQueryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSearchParameter))
            {
                body["textSearchParameter"] = request.TextSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorSearchParameter))
            {
                body["vectorSearchParameter"] = request.VectorSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentReference))
            {
                body["withDocumentReference"] = request.WithDocumentReference;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLibraryChatGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/library/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLibraryChatGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public async Task<RunLibraryChatGenerationResponse> RunLibraryChatGenerationWithOptionsAsync(string workspaceId, RunLibraryChatGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFollowUp))
            {
                body["enableFollowUp"] = request.EnableFollowUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMultiQuery))
            {
                body["enableMultiQuery"] = request.EnableMultiQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOpenQa))
            {
                body["enableOpenQa"] = request.EnableOpenQa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowUpLlm))
            {
                body["followUpLlm"] = request.FollowUpLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmType))
            {
                body["llmType"] = request.LlmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiQueryLlm))
            {
                body["multiQueryLlm"] = request.MultiQueryLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCriteria))
            {
                body["queryCriteria"] = request.QueryCriteria;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankType))
            {
                body["rerankType"] = request.RerankType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQueryList))
            {
                body["subQueryList"] = request.SubQueryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSearchParameter))
            {
                body["textSearchParameter"] = request.TextSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorSearchParameter))
            {
                body["vectorSearchParameter"] = request.VectorSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentReference))
            {
                body["withDocumentReference"] = request.WithDocumentReference;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLibraryChatGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/library/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLibraryChatGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public RunLibraryChatGenerationResponse RunLibraryChatGeneration(string workspaceId, RunLibraryChatGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunLibraryChatGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public async Task<RunLibraryChatGenerationResponse> RunLibraryChatGenerationAsync(string workspaceId, RunLibraryChatGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunLibraryChatGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交问题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitChatQuestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitChatQuestionResponse
        /// </returns>
        public SubmitChatQuestionResponse SubmitChatQuestionWithOptions(string workspaceId, SubmitChatQuestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtService))
            {
                body["gmtService"] = request.GmtService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveScriptContent))
            {
                body["liveScriptContent"] = request.LiveScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSmallTalk))
            {
                body["openSmallTalk"] = request.OpenSmallTalk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionList))
            {
                body["questionList"] = request.QuestionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitChatQuestion",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/chat/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitChatQuestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交问题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitChatQuestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitChatQuestionResponse
        /// </returns>
        public async Task<SubmitChatQuestionResponse> SubmitChatQuestionWithOptionsAsync(string workspaceId, SubmitChatQuestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtService))
            {
                body["gmtService"] = request.GmtService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveScriptContent))
            {
                body["liveScriptContent"] = request.LiveScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSmallTalk))
            {
                body["openSmallTalk"] = request.OpenSmallTalk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionList))
            {
                body["questionList"] = request.QuestionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitChatQuestion",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/chat/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitChatQuestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交问题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitChatQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitChatQuestionResponse
        /// </returns>
        public SubmitChatQuestionResponse SubmitChatQuestion(string workspaceId, SubmitChatQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitChatQuestionWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交问题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitChatQuestionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitChatQuestionResponse
        /// </returns>
        public async Task<SubmitChatQuestionResponse> SubmitChatQuestionAsync(string workspaceId, SubmitChatQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitChatQuestionWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public UpdateDocumentResponse UpdateDocumentWithOptions(string workspaceId, UpdateDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/updateDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public async Task<UpdateDocumentResponse> UpdateDocumentWithOptionsAsync(string workspaceId, UpdateDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/updateDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public UpdateDocumentResponse UpdateDocument(string workspaceId, UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public async Task<UpdateDocumentResponse> UpdateDocumentAsync(string workspaceId, UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档的chunk</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentChunkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentChunkResponse
        /// </returns>
        public UpdateDocumentChunkResponse UpdateDocumentChunkWithOptions(string workspaceId, UpdateDocumentChunkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocumentChunk",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/updateDocumentChunk",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentChunkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档的chunk</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentChunkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentChunkResponse
        /// </returns>
        public async Task<UpdateDocumentChunkResponse> UpdateDocumentChunkWithOptionsAsync(string workspaceId, UpdateDocumentChunkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocumentChunk",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/updateDocumentChunk",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentChunkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档的chunk</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentChunkResponse
        /// </returns>
        public UpdateDocumentChunkResponse UpdateDocumentChunk(string workspaceId, UpdateDocumentChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDocumentChunkWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档的chunk</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentChunkResponse
        /// </returns>
        public async Task<UpdateDocumentChunkResponse> UpdateDocumentChunkAsync(string workspaceId, UpdateDocumentChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDocumentChunkWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public UpdateLibraryResponse UpdateLibraryWithOptions(string workspaceId, UpdateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public async Task<UpdateLibraryResponse> UpdateLibraryWithOptionsAsync(string workspaceId, UpdateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public UpdateLibraryResponse UpdateLibrary(string workspaceId, UpdateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public async Task<UpdateLibraryResponse> UpdateLibraryAsync(string workspaceId, UpdateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新QA问答库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQaLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQaLibraryResponse
        /// </returns>
        public UpdateQaLibraryResponse UpdateQaLibraryWithOptions(string workspaceId, UpdateQaLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParseQaResults))
            {
                body["parseQaResults"] = request.ParseQaResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QaLibraryId))
            {
                body["qaLibraryId"] = request.QaLibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQaLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/qa/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQaLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新QA问答库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQaLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQaLibraryResponse
        /// </returns>
        public async Task<UpdateQaLibraryResponse> UpdateQaLibraryWithOptionsAsync(string workspaceId, UpdateQaLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParseQaResults))
            {
                body["parseQaResults"] = request.ParseQaResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QaLibraryId))
            {
                body["qaLibraryId"] = request.QaLibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQaLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/virtualHuman/qa/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQaLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新QA问答库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQaLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQaLibraryResponse
        /// </returns>
        public UpdateQaLibraryResponse UpdateQaLibrary(string workspaceId, UpdateQaLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateQaLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新QA问答库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQaLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQaLibraryResponse
        /// </returns>
        public async Task<UpdateQaLibraryResponse> UpdateQaLibraryAsync(string workspaceId, UpdateQaLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateQaLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public UploadDocumentResponse UploadDocumentWithOptions(string workspaceId, UploadDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public async Task<UploadDocumentResponse> UploadDocumentWithOptionsAsync(string workspaceId, UploadDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public UploadDocumentResponse UploadDocument(string workspaceId, UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public async Task<UploadDocumentResponse> UploadDocumentAsync(string workspaceId, UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        public UploadDocumentResponse UploadDocumentAdvance(string workspaceId, UploadDocumentAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "DianJin"},
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
            UploadDocumentRequest uploadDocumentReq = new UploadDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadDocumentReq);
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
                    {"host", "" + authResponseBody.Get("Bucket") + "." + AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponseBody.Get("Endpoint"), useAccelerate, _endpointType)},
                    {"OSSAccessKeyId", authResponseBody.Get("AccessKeyId")},
                    {"policy", authResponseBody.Get("EncodedPolicy")},
                    {"Signature", authResponseBody.Get("Signature")},
                    {"key", authResponseBody.Get("ObjectKey")},
                    {"file", fileObj},
                    {"success_action_status", "201"},
                };
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader, runtime);
                uploadDocumentReq.FileUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            UploadDocumentResponse uploadDocumentResp = UploadDocumentWithOptions(workspaceId, uploadDocumentReq, headers, runtime);
            return uploadDocumentResp;
        }

        public async Task<UploadDocumentResponse> UploadDocumentAdvanceAsync(string workspaceId, UploadDocumentAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "DianJin"},
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
            UploadDocumentRequest uploadDocumentReq = new UploadDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadDocumentReq);
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
                    {"host", "" + authResponseBody.Get("Bucket") + "." + AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponseBody.Get("Endpoint"), useAccelerate, _endpointType)},
                    {"OSSAccessKeyId", authResponseBody.Get("AccessKeyId")},
                    {"policy", authResponseBody.Get("EncodedPolicy")},
                    {"Signature", authResponseBody.Get("Signature")},
                    {"key", authResponseBody.Get("ObjectKey")},
                    {"file", fileObj},
                    {"success_action_status", "201"},
                };
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader, runtime);
                uploadDocumentReq.FileUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            UploadDocumentResponse uploadDocumentResp = await UploadDocumentWithOptionsAsync(workspaceId, uploadDocumentReq, headers, runtime);
            return uploadDocumentResp;
        }

    }
}
