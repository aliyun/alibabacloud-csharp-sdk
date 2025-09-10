// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Imagerecog20190930.Models;

namespace AlibabaCloud.SDK.Imagerecog20190930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("imagerecog", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }

        public Dictionary<string, object> _postOSSObject(string bucketName, Dictionary<string, object> data)
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
            TeaResponse response_ = TeaCore.DoAction(request_);

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

        public async Task<Dictionary<string, object>> _postOSSObjectAsync(string bucketName, Dictionary<string, object> data)
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
            TeaResponse response_ = await TeaCore.DoActionAsync(request_);

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

        /// <param name="request">
        /// ClassifyingRubbishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClassifyingRubbishResponse
        /// </returns>
        public ClassifyingRubbishResponse ClassifyingRubbishWithOptions(ClassifyingRubbishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClassifyingRubbish",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClassifyingRubbishResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ClassifyingRubbishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClassifyingRubbishResponse
        /// </returns>
        public async Task<ClassifyingRubbishResponse> ClassifyingRubbishWithOptionsAsync(ClassifyingRubbishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClassifyingRubbish",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClassifyingRubbishResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ClassifyingRubbishRequest
        /// </param>
        /// 
        /// <returns>
        /// ClassifyingRubbishResponse
        /// </returns>
        public ClassifyingRubbishResponse ClassifyingRubbish(ClassifyingRubbishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClassifyingRubbishWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ClassifyingRubbishRequest
        /// </param>
        /// 
        /// <returns>
        /// ClassifyingRubbishResponse
        /// </returns>
        public async Task<ClassifyingRubbishResponse> ClassifyingRubbishAsync(ClassifyingRubbishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClassifyingRubbishWithOptionsAsync(request, runtime);
        }

        public ClassifyingRubbishResponse ClassifyingRubbishAdvance(ClassifyingRubbishAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            ClassifyingRubbishRequest classifyingRubbishReq = new ClassifyingRubbishRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, classifyingRubbishReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                classifyingRubbishReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ClassifyingRubbishResponse classifyingRubbishResp = ClassifyingRubbishWithOptions(classifyingRubbishReq, runtime);
            return classifyingRubbishResp;
        }

        public async Task<ClassifyingRubbishResponse> ClassifyingRubbishAdvanceAsync(ClassifyingRubbishAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            ClassifyingRubbishRequest classifyingRubbishReq = new ClassifyingRubbishRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, classifyingRubbishReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                classifyingRubbishReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ClassifyingRubbishResponse classifyingRubbishResp = await ClassifyingRubbishWithOptionsAsync(classifyingRubbishReq, runtime);
            return classifyingRubbishResp;
        }

        /// <param name="request">
        /// DetectImageElementsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectImageElementsResponse
        /// </returns>
        public DetectImageElementsResponse DetectImageElementsWithOptions(DetectImageElementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageElements",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageElementsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectImageElementsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectImageElementsResponse
        /// </returns>
        public async Task<DetectImageElementsResponse> DetectImageElementsWithOptionsAsync(DetectImageElementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageElements",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageElementsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectImageElementsRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectImageElementsResponse
        /// </returns>
        public DetectImageElementsResponse DetectImageElements(DetectImageElementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageElementsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DetectImageElementsRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectImageElementsResponse
        /// </returns>
        public async Task<DetectImageElementsResponse> DetectImageElementsAsync(DetectImageElementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageElementsWithOptionsAsync(request, runtime);
        }

        public DetectImageElementsResponse DetectImageElementsAdvance(DetectImageElementsAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            DetectImageElementsRequest detectImageElementsReq = new DetectImageElementsRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectImageElementsReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UrlObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                detectImageElementsReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            DetectImageElementsResponse detectImageElementsResp = DetectImageElementsWithOptions(detectImageElementsReq, runtime);
            return detectImageElementsResp;
        }

        public async Task<DetectImageElementsResponse> DetectImageElementsAdvanceAsync(DetectImageElementsAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            DetectImageElementsRequest detectImageElementsReq = new DetectImageElementsRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectImageElementsReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UrlObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                detectImageElementsReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            DetectImageElementsResponse detectImageElementsResp = await DetectImageElementsWithOptionsAsync(detectImageElementsReq, runtime);
            return detectImageElementsResp;
        }

        /// <param name="request">
        /// EvaluateCertificateQualityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvaluateCertificateQualityResponse
        /// </returns>
        public EvaluateCertificateQualityResponse EvaluateCertificateQualityWithOptions(EvaluateCertificateQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluateCertificateQuality",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateCertificateQualityResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EvaluateCertificateQualityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvaluateCertificateQualityResponse
        /// </returns>
        public async Task<EvaluateCertificateQualityResponse> EvaluateCertificateQualityWithOptionsAsync(EvaluateCertificateQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluateCertificateQuality",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateCertificateQualityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EvaluateCertificateQualityRequest
        /// </param>
        /// 
        /// <returns>
        /// EvaluateCertificateQualityResponse
        /// </returns>
        public EvaluateCertificateQualityResponse EvaluateCertificateQuality(EvaluateCertificateQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EvaluateCertificateQualityWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EvaluateCertificateQualityRequest
        /// </param>
        /// 
        /// <returns>
        /// EvaluateCertificateQualityResponse
        /// </returns>
        public async Task<EvaluateCertificateQualityResponse> EvaluateCertificateQualityAsync(EvaluateCertificateQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EvaluateCertificateQualityWithOptionsAsync(request, runtime);
        }

        public EvaluateCertificateQualityResponse EvaluateCertificateQualityAdvance(EvaluateCertificateQualityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            EvaluateCertificateQualityRequest evaluateCertificateQualityReq = new EvaluateCertificateQualityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, evaluateCertificateQualityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                evaluateCertificateQualityReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            EvaluateCertificateQualityResponse evaluateCertificateQualityResp = EvaluateCertificateQualityWithOptions(evaluateCertificateQualityReq, runtime);
            return evaluateCertificateQualityResp;
        }

        public async Task<EvaluateCertificateQualityResponse> EvaluateCertificateQualityAdvanceAsync(EvaluateCertificateQualityAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            EvaluateCertificateQualityRequest evaluateCertificateQualityReq = new EvaluateCertificateQualityRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, evaluateCertificateQualityReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                evaluateCertificateQualityReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            EvaluateCertificateQualityResponse evaluateCertificateQualityResp = await EvaluateCertificateQualityWithOptionsAsync(evaluateCertificateQualityReq, runtime);
            return evaluateCertificateQualityResp;
        }

        /// <param name="request">
        /// GetAsyncJobResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncJobResultResponse
        /// </returns>
        public GetAsyncJobResultResponse GetAsyncJobResultWithOptions(GetAsyncJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncJobResult",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncJobResultResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAsyncJobResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncJobResultResponse
        /// </returns>
        public async Task<GetAsyncJobResultResponse> GetAsyncJobResultWithOptionsAsync(GetAsyncJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncJobResult",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncJobResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAsyncJobResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncJobResultResponse
        /// </returns>
        public GetAsyncJobResultResponse GetAsyncJobResult(GetAsyncJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncJobResultWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAsyncJobResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncJobResultResponse
        /// </returns>
        public async Task<GetAsyncJobResultResponse> GetAsyncJobResultAsync(GetAsyncJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncJobResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>菜品识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodResponse
        /// </returns>
        public RecognizeFoodResponse RecognizeFoodWithOptions(RecognizeFoodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFood",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>菜品识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodResponse
        /// </returns>
        public async Task<RecognizeFoodResponse> RecognizeFoodWithOptionsAsync(RecognizeFoodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFood",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>菜品识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodResponse
        /// </returns>
        public RecognizeFoodResponse RecognizeFood(RecognizeFoodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFoodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>菜品识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeFoodRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeFoodResponse
        /// </returns>
        public async Task<RecognizeFoodResponse> RecognizeFoodAsync(RecognizeFoodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFoodWithOptionsAsync(request, runtime);
        }

        public RecognizeFoodResponse RecognizeFoodAdvance(RecognizeFoodAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeFoodRequest recognizeFoodReq = new RecognizeFoodRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeFoodReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                recognizeFoodReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeFoodResponse recognizeFoodResp = RecognizeFoodWithOptions(recognizeFoodReq, runtime);
            return recognizeFoodResp;
        }

        public async Task<RecognizeFoodResponse> RecognizeFoodAdvanceAsync(RecognizeFoodAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeFoodRequest recognizeFoodReq = new RecognizeFoodRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeFoodReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                recognizeFoodReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeFoodResponse recognizeFoodResp = await RecognizeFoodWithOptionsAsync(recognizeFoodReq, runtime);
            return recognizeFoodResp;
        }

        /// <param name="request">
        /// RecognizeImageColorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageColorResponse
        /// </returns>
        public RecognizeImageColorResponse RecognizeImageColorWithOptions(RecognizeImageColorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorCount))
            {
                body["ColorCount"] = request.ColorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeImageColor",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeImageColorResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RecognizeImageColorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageColorResponse
        /// </returns>
        public async Task<RecognizeImageColorResponse> RecognizeImageColorWithOptionsAsync(RecognizeImageColorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorCount))
            {
                body["ColorCount"] = request.ColorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeImageColor",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeImageColorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RecognizeImageColorRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageColorResponse
        /// </returns>
        public RecognizeImageColorResponse RecognizeImageColor(RecognizeImageColorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeImageColorWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RecognizeImageColorRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageColorResponse
        /// </returns>
        public async Task<RecognizeImageColorResponse> RecognizeImageColorAsync(RecognizeImageColorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeImageColorWithOptionsAsync(request, runtime);
        }

        public RecognizeImageColorResponse RecognizeImageColorAdvance(RecognizeImageColorAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeImageColorRequest recognizeImageColorReq = new RecognizeImageColorRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeImageColorReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UrlObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                recognizeImageColorReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeImageColorResponse recognizeImageColorResp = RecognizeImageColorWithOptions(recognizeImageColorReq, runtime);
            return recognizeImageColorResp;
        }

        public async Task<RecognizeImageColorResponse> RecognizeImageColorAdvanceAsync(RecognizeImageColorAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeImageColorRequest recognizeImageColorReq = new RecognizeImageColorRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeImageColorReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UrlObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                recognizeImageColorReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeImageColorResponse recognizeImageColorResp = await RecognizeImageColorWithOptionsAsync(recognizeImageColorReq, runtime);
            return recognizeImageColorResp;
        }

        /// <param name="request">
        /// RecognizeImageStyleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageStyleResponse
        /// </returns>
        public RecognizeImageStyleResponse RecognizeImageStyleWithOptions(RecognizeImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeImageStyle",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeImageStyleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RecognizeImageStyleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageStyleResponse
        /// </returns>
        public async Task<RecognizeImageStyleResponse> RecognizeImageStyleWithOptionsAsync(RecognizeImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeImageStyle",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeImageStyleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RecognizeImageStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageStyleResponse
        /// </returns>
        public RecognizeImageStyleResponse RecognizeImageStyle(RecognizeImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeImageStyleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RecognizeImageStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeImageStyleResponse
        /// </returns>
        public async Task<RecognizeImageStyleResponse> RecognizeImageStyleAsync(RecognizeImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeImageStyleWithOptionsAsync(request, runtime);
        }

        public RecognizeImageStyleResponse RecognizeImageStyleAdvance(RecognizeImageStyleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeImageStyleRequest recognizeImageStyleReq = new RecognizeImageStyleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeImageStyleReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UrlObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                recognizeImageStyleReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeImageStyleResponse recognizeImageStyleResp = RecognizeImageStyleWithOptions(recognizeImageStyleReq, runtime);
            return recognizeImageStyleResp;
        }

        public async Task<RecognizeImageStyleResponse> RecognizeImageStyleAdvanceAsync(RecognizeImageStyleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeImageStyleRequest recognizeImageStyleReq = new RecognizeImageStyleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeImageStyleReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UrlObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                recognizeImageStyleReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeImageStyleResponse recognizeImageStyleResp = await RecognizeImageStyleWithOptionsAsync(recognizeImageStyleReq, runtime);
            return recognizeImageStyleResp;
        }

        /// <param name="request">
        /// RecognizeSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSceneResponse
        /// </returns>
        public RecognizeSceneResponse RecognizeSceneWithOptions(RecognizeSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeScene",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RecognizeSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSceneResponse
        /// </returns>
        public async Task<RecognizeSceneResponse> RecognizeSceneWithOptionsAsync(RecognizeSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeScene",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RecognizeSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSceneResponse
        /// </returns>
        public RecognizeSceneResponse RecognizeScene(RecognizeSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeSceneWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RecognizeSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeSceneResponse
        /// </returns>
        public async Task<RecognizeSceneResponse> RecognizeSceneAsync(RecognizeSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeSceneWithOptionsAsync(request, runtime);
        }

        public RecognizeSceneResponse RecognizeSceneAdvance(RecognizeSceneAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeSceneRequest recognizeSceneReq = new RecognizeSceneRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeSceneReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                recognizeSceneReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeSceneResponse recognizeSceneResp = RecognizeSceneWithOptions(recognizeSceneReq, runtime);
            return recognizeSceneResp;
        }

        public async Task<RecognizeSceneResponse> RecognizeSceneAdvanceAsync(RecognizeSceneAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            RecognizeSceneRequest recognizeSceneReq = new RecognizeSceneRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeSceneReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                recognizeSceneReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecognizeSceneResponse recognizeSceneResp = await RecognizeSceneWithOptionsAsync(recognizeSceneReq, runtime);
            return recognizeSceneResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>广告素材分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaggingAdImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaggingAdImageResponse
        /// </returns>
        public TaggingAdImageResponse TaggingAdImageWithOptions(TaggingAdImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaggingAdImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaggingAdImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>广告素材分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaggingAdImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaggingAdImageResponse
        /// </returns>
        public async Task<TaggingAdImageResponse> TaggingAdImageWithOptionsAsync(TaggingAdImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaggingAdImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaggingAdImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>广告素材分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaggingAdImageRequest
        /// </param>
        /// 
        /// <returns>
        /// TaggingAdImageResponse
        /// </returns>
        public TaggingAdImageResponse TaggingAdImage(TaggingAdImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaggingAdImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>广告素材分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TaggingAdImageRequest
        /// </param>
        /// 
        /// <returns>
        /// TaggingAdImageResponse
        /// </returns>
        public async Task<TaggingAdImageResponse> TaggingAdImageAsync(TaggingAdImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaggingAdImageWithOptionsAsync(request, runtime);
        }

        public TaggingAdImageResponse TaggingAdImageAdvance(TaggingAdImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            TaggingAdImageRequest taggingAdImageReq = new TaggingAdImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, taggingAdImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                taggingAdImageReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            TaggingAdImageResponse taggingAdImageResp = TaggingAdImageWithOptions(taggingAdImageReq, runtime);
            return taggingAdImageResp;
        }

        public async Task<TaggingAdImageResponse> TaggingAdImageAdvanceAsync(TaggingAdImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            TaggingAdImageRequest taggingAdImageReq = new TaggingAdImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, taggingAdImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                taggingAdImageReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            TaggingAdImageResponse taggingAdImageResp = await TaggingAdImageWithOptionsAsync(taggingAdImageReq, runtime);
            return taggingAdImageResp;
        }

        /// <param name="request">
        /// TaggingImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaggingImageResponse
        /// </returns>
        public TaggingImageResponse TaggingImageWithOptions(TaggingImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaggingImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaggingImageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// TaggingImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TaggingImageResponse
        /// </returns>
        public async Task<TaggingImageResponse> TaggingImageWithOptionsAsync(TaggingImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaggingImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaggingImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// TaggingImageRequest
        /// </param>
        /// 
        /// <returns>
        /// TaggingImageResponse
        /// </returns>
        public TaggingImageResponse TaggingImage(TaggingImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaggingImageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TaggingImageRequest
        /// </param>
        /// 
        /// <returns>
        /// TaggingImageResponse
        /// </returns>
        public async Task<TaggingImageResponse> TaggingImageAsync(TaggingImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaggingImageWithOptionsAsync(request, runtime);
        }

        public TaggingImageResponse TaggingImageAdvance(TaggingImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            TaggingImageRequest taggingImageReq = new TaggingImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, taggingImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                taggingImageReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            TaggingImageResponse taggingImageResp = TaggingImageWithOptions(taggingImageReq, runtime);
            return taggingImageResp;
        }

        public async Task<TaggingImageResponse> TaggingImageAdvanceAsync(TaggingImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imagerecog"},
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
            TaggingImageRequest taggingImageReq = new TaggingImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, taggingImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageURLObject,
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
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                taggingImageReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            TaggingImageResponse taggingImageResp = await TaggingImageWithOptionsAsync(taggingImageReq, runtime);
            return taggingImageResp;
        }

    }
}
