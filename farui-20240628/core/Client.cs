// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.FaRui20240628.Models;

namespace AlibabaCloud.SDK.FaRui20240628
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("farui", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public CreateTextFileResponse CreateTextFileWithOptions(string WorkspaceId, CreateTextFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractId))
            {
                body["ContractId"] = request.ContractId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileName))
            {
                body["TextFileName"] = request.TextFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrl))
            {
                body["TextFileUrl"] = request.TextFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextFile",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/data/textFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public async Task<CreateTextFileResponse> CreateTextFileWithOptionsAsync(string WorkspaceId, CreateTextFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractId))
            {
                body["ContractId"] = request.ContractId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileName))
            {
                body["TextFileName"] = request.TextFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrl))
            {
                body["TextFileUrl"] = request.TextFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextFile",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/data/textFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public CreateTextFileResponse CreateTextFile(string WorkspaceId, CreateTextFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTextFileWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public async Task<CreateTextFileResponse> CreateTextFileAsync(string WorkspaceId, CreateTextFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTextFileWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        public CreateTextFileResponse CreateTextFileAdvance(string WorkspaceId, CreateTextFileAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "FaRui"},
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
            CreateTextFileRequest createTextFileReq = new CreateTextFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createTextFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.TextFileUrlObject,
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
                createTextFileReq.TextFileUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CreateTextFileResponse createTextFileResp = CreateTextFileWithOptions(WorkspaceId, createTextFileReq, headers, runtime);
            return createTextFileResp;
        }

        public async Task<CreateTextFileResponse> CreateTextFileAdvanceAsync(string WorkspaceId, CreateTextFileAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "FaRui"},
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
            CreateTextFileRequest createTextFileReq = new CreateTextFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createTextFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.TextFileUrlObject,
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
                createTextFileReq.TextFileUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CreateTextFileResponse createTextFileResp = await CreateTextFileWithOptionsAsync(WorkspaceId, createTextFileReq, headers, runtime);
            return createTextFileResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合同抽取</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractExtractRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractExtractResponse
        /// </returns>
        public RunContractExtractResponse RunContractExtractWithOptions(string workspaceId, RunContractExtractRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractExtractShrinkRequest request = new RunContractExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FieldsToExtract))
            {
                request.FieldsToExtractShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FieldsToExtract, "fieldsToExtract", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldsToExtractShrink))
            {
                body["fieldsToExtract"] = request.FieldsToExtractShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrl))
            {
                body["fileOssUrl"] = request.FileOssUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractExtract",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/pop/contract/extraction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractExtractResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合同抽取</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractExtractRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractExtractResponse
        /// </returns>
        public async Task<RunContractExtractResponse> RunContractExtractWithOptionsAsync(string workspaceId, RunContractExtractRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractExtractShrinkRequest request = new RunContractExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FieldsToExtract))
            {
                request.FieldsToExtractShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FieldsToExtract, "fieldsToExtract", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldsToExtractShrink))
            {
                body["fieldsToExtract"] = request.FieldsToExtractShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileOssUrl))
            {
                body["fileOssUrl"] = request.FileOssUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractExtract",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/pop/contract/extraction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractExtractResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合同抽取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractExtractRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractExtractResponse
        /// </returns>
        public RunContractExtractResponse RunContractExtract(string workspaceId, RunContractExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunContractExtractWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合同抽取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractExtractRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractExtractResponse
        /// </returns>
        public async Task<RunContractExtractResponse> RunContractExtractAsync(string workspaceId, RunContractExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunContractExtractWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public RunContractResultGenerationResponse RunContractResultGenerationWithOptions(string workspaceId, RunContractResultGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractResultGenerationShrinkRequest request = new RunContractResultGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/result/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractResultGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public async Task<RunContractResultGenerationResponse> RunContractResultGenerationWithOptionsAsync(string workspaceId, RunContractResultGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractResultGenerationShrinkRequest request = new RunContractResultGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/result/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractResultGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public RunContractResultGenerationResponse RunContractResultGeneration(string workspaceId, RunContractResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunContractResultGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public async Task<RunContractResultGenerationResponse> RunContractResultGenerationAsync(string workspaceId, RunContractResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunContractResultGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public RunContractRuleGenerationResponse RunContractRuleGenerationWithOptions(string workspaceId, RunContractRuleGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractRuleGenerationShrinkRequest request = new RunContractRuleGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractRuleGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/rule/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractRuleGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public async Task<RunContractRuleGenerationResponse> RunContractRuleGenerationWithOptionsAsync(string workspaceId, RunContractRuleGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractRuleGenerationShrinkRequest request = new RunContractRuleGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractRuleGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/rule/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractRuleGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public RunContractRuleGenerationResponse RunContractRuleGeneration(string workspaceId, RunContractRuleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunContractRuleGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public async Task<RunContractRuleGenerationResponse> RunContractRuleGenerationAsync(string workspaceId, RunContractRuleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunContractRuleGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public RunLegalAdviceConsultationResponse RunLegalAdviceConsultationWithOptions(string workspaceId, RunLegalAdviceConsultationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunLegalAdviceConsultationShrinkRequest request = new RunLegalAdviceConsultationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLegalAdviceConsultation",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/legalAdvice/consult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLegalAdviceConsultationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public async Task<RunLegalAdviceConsultationResponse> RunLegalAdviceConsultationWithOptionsAsync(string workspaceId, RunLegalAdviceConsultationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunLegalAdviceConsultationShrinkRequest request = new RunLegalAdviceConsultationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLegalAdviceConsultation",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/legalAdvice/consult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLegalAdviceConsultationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public RunLegalAdviceConsultationResponse RunLegalAdviceConsultation(string workspaceId, RunLegalAdviceConsultationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunLegalAdviceConsultationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public async Task<RunLegalAdviceConsultationResponse> RunLegalAdviceConsultationAsync(string workspaceId, RunLegalAdviceConsultationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunLegalAdviceConsultationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public RunSearchCaseFullTextResponse RunSearchCaseFullTextWithOptions(string workspaceId, RunSearchCaseFullTextRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchCaseFullTextShrinkRequest request = new RunSearchCaseFullTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SortKeyAndDirection))
            {
                request.SortKeyAndDirectionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SortKeyAndDirection, "sortKeyAndDirection", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferLevel))
            {
                body["referLevel"] = request.ReferLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKeyAndDirectionShrink))
            {
                body["sortKeyAndDirection"] = request.SortKeyAndDirectionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchCaseFullText",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/case/fulltext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchCaseFullTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public async Task<RunSearchCaseFullTextResponse> RunSearchCaseFullTextWithOptionsAsync(string workspaceId, RunSearchCaseFullTextRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchCaseFullTextShrinkRequest request = new RunSearchCaseFullTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SortKeyAndDirection))
            {
                request.SortKeyAndDirectionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SortKeyAndDirection, "sortKeyAndDirection", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferLevel))
            {
                body["referLevel"] = request.ReferLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKeyAndDirectionShrink))
            {
                body["sortKeyAndDirection"] = request.SortKeyAndDirectionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchCaseFullText",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/case/fulltext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchCaseFullTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public RunSearchCaseFullTextResponse RunSearchCaseFullText(string workspaceId, RunSearchCaseFullTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunSearchCaseFullTextWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public async Task<RunSearchCaseFullTextResponse> RunSearchCaseFullTextAsync(string workspaceId, RunSearchCaseFullTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunSearchCaseFullTextWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchLawQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public RunSearchLawQueryResponse RunSearchLawQueryWithOptions(string workspaceId, RunSearchLawQueryRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchLawQueryShrinkRequest request = new RunSearchLawQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchLawQuery",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/law/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchLawQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchLawQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public async Task<RunSearchLawQueryResponse> RunSearchLawQueryWithOptionsAsync(string workspaceId, RunSearchLawQueryRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchLawQueryShrinkRequest request = new RunSearchLawQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchLawQuery",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/law/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchLawQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchLawQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public RunSearchLawQueryResponse RunSearchLawQuery(string workspaceId, RunSearchLawQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunSearchLawQueryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchLawQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public async Task<RunSearchLawQueryResponse> RunSearchLawQueryAsync(string workspaceId, RunSearchLawQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunSearchLawQueryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
