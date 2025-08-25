// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Imageenhan20190930.Models;

namespace AlibabaCloud.SDK.Imageenhan20190930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("imageenhan", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// AssessCompositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssessCompositionResponse
        /// </returns>
        public AssessCompositionResponse AssessCompositionWithOptions(AssessCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AssessComposition",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssessCompositionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AssessCompositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssessCompositionResponse
        /// </returns>
        public async Task<AssessCompositionResponse> AssessCompositionWithOptionsAsync(AssessCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AssessComposition",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssessCompositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AssessCompositionRequest
        /// </param>
        /// 
        /// <returns>
        /// AssessCompositionResponse
        /// </returns>
        public AssessCompositionResponse AssessComposition(AssessCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssessCompositionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AssessCompositionRequest
        /// </param>
        /// 
        /// <returns>
        /// AssessCompositionResponse
        /// </returns>
        public async Task<AssessCompositionResponse> AssessCompositionAsync(AssessCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssessCompositionWithOptionsAsync(request, runtime);
        }

        public AssessCompositionResponse AssessCompositionAdvance(AssessCompositionAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            AssessCompositionRequest assessCompositionReq = new AssessCompositionRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, assessCompositionReq);
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
                assessCompositionReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            AssessCompositionResponse assessCompositionResp = AssessCompositionWithOptions(assessCompositionReq, runtime);
            return assessCompositionResp;
        }

        public async Task<AssessCompositionResponse> AssessCompositionAdvanceAsync(AssessCompositionAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            AssessCompositionRequest assessCompositionReq = new AssessCompositionRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, assessCompositionReq);
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
                assessCompositionReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            AssessCompositionResponse assessCompositionResp = await AssessCompositionWithOptionsAsync(assessCompositionReq, runtime);
            return assessCompositionResp;
        }

        /// <param name="request">
        /// AssessExposureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssessExposureResponse
        /// </returns>
        public AssessExposureResponse AssessExposureWithOptions(AssessExposureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AssessExposure",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssessExposureResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AssessExposureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssessExposureResponse
        /// </returns>
        public async Task<AssessExposureResponse> AssessExposureWithOptionsAsync(AssessExposureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AssessExposure",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssessExposureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AssessExposureRequest
        /// </param>
        /// 
        /// <returns>
        /// AssessExposureResponse
        /// </returns>
        public AssessExposureResponse AssessExposure(AssessExposureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssessExposureWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AssessExposureRequest
        /// </param>
        /// 
        /// <returns>
        /// AssessExposureResponse
        /// </returns>
        public async Task<AssessExposureResponse> AssessExposureAsync(AssessExposureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssessExposureWithOptionsAsync(request, runtime);
        }

        public AssessExposureResponse AssessExposureAdvance(AssessExposureAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            AssessExposureRequest assessExposureReq = new AssessExposureRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, assessExposureReq);
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
                assessExposureReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            AssessExposureResponse assessExposureResp = AssessExposureWithOptions(assessExposureReq, runtime);
            return assessExposureResp;
        }

        public async Task<AssessExposureResponse> AssessExposureAdvanceAsync(AssessExposureAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            AssessExposureRequest assessExposureReq = new AssessExposureRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, assessExposureReq);
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
                assessExposureReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            AssessExposureResponse assessExposureResp = await AssessExposureWithOptionsAsync(assessExposureReq, runtime);
            return assessExposureResp;
        }

        /// <param name="request">
        /// AssessSharpnessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssessSharpnessResponse
        /// </returns>
        public AssessSharpnessResponse AssessSharpnessWithOptions(AssessSharpnessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AssessSharpness",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssessSharpnessResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AssessSharpnessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssessSharpnessResponse
        /// </returns>
        public async Task<AssessSharpnessResponse> AssessSharpnessWithOptionsAsync(AssessSharpnessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AssessSharpness",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssessSharpnessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AssessSharpnessRequest
        /// </param>
        /// 
        /// <returns>
        /// AssessSharpnessResponse
        /// </returns>
        public AssessSharpnessResponse AssessSharpness(AssessSharpnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssessSharpnessWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AssessSharpnessRequest
        /// </param>
        /// 
        /// <returns>
        /// AssessSharpnessResponse
        /// </returns>
        public async Task<AssessSharpnessResponse> AssessSharpnessAsync(AssessSharpnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssessSharpnessWithOptionsAsync(request, runtime);
        }

        public AssessSharpnessResponse AssessSharpnessAdvance(AssessSharpnessAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            AssessSharpnessRequest assessSharpnessReq = new AssessSharpnessRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, assessSharpnessReq);
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
                assessSharpnessReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            AssessSharpnessResponse assessSharpnessResp = AssessSharpnessWithOptions(assessSharpnessReq, runtime);
            return assessSharpnessResp;
        }

        public async Task<AssessSharpnessResponse> AssessSharpnessAdvanceAsync(AssessSharpnessAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            AssessSharpnessRequest assessSharpnessReq = new AssessSharpnessRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, assessSharpnessReq);
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
                assessSharpnessReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            AssessSharpnessResponse assessSharpnessResp = await AssessSharpnessWithOptionsAsync(assessSharpnessReq, runtime);
            return assessSharpnessResp;
        }

        /// <param name="request">
        /// ChangeImageSizeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeImageSizeResponse
        /// </returns>
        public ChangeImageSizeResponse ChangeImageSizeWithOptions(ChangeImageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["Width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeImageSize",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeImageSizeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeImageSizeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeImageSizeResponse
        /// </returns>
        public async Task<ChangeImageSizeResponse> ChangeImageSizeWithOptionsAsync(ChangeImageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["Width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeImageSize",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeImageSizeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeImageSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeImageSizeResponse
        /// </returns>
        public ChangeImageSizeResponse ChangeImageSize(ChangeImageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeImageSizeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeImageSizeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeImageSizeResponse
        /// </returns>
        public async Task<ChangeImageSizeResponse> ChangeImageSizeAsync(ChangeImageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeImageSizeWithOptionsAsync(request, runtime);
        }

        public ChangeImageSizeResponse ChangeImageSizeAdvance(ChangeImageSizeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ChangeImageSizeRequest changeImageSizeReq = new ChangeImageSizeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, changeImageSizeReq);
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
                changeImageSizeReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ChangeImageSizeResponse changeImageSizeResp = ChangeImageSizeWithOptions(changeImageSizeReq, runtime);
            return changeImageSizeResp;
        }

        public async Task<ChangeImageSizeResponse> ChangeImageSizeAdvanceAsync(ChangeImageSizeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ChangeImageSizeRequest changeImageSizeReq = new ChangeImageSizeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, changeImageSizeReq);
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
                changeImageSizeReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ChangeImageSizeResponse changeImageSizeResp = await ChangeImageSizeWithOptionsAsync(changeImageSizeReq, runtime);
            return changeImageSizeResp;
        }

        /// <param name="request">
        /// ColorizeImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ColorizeImageResponse
        /// </returns>
        public ColorizeImageResponse ColorizeImageWithOptions(ColorizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ColorizeImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ColorizeImageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ColorizeImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ColorizeImageResponse
        /// </returns>
        public async Task<ColorizeImageResponse> ColorizeImageWithOptionsAsync(ColorizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ColorizeImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ColorizeImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ColorizeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// ColorizeImageResponse
        /// </returns>
        public ColorizeImageResponse ColorizeImage(ColorizeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ColorizeImageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ColorizeImageRequest
        /// </param>
        /// 
        /// <returns>
        /// ColorizeImageResponse
        /// </returns>
        public async Task<ColorizeImageResponse> ColorizeImageAsync(ColorizeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ColorizeImageWithOptionsAsync(request, runtime);
        }

        public ColorizeImageResponse ColorizeImageAdvance(ColorizeImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ColorizeImageRequest colorizeImageReq = new ColorizeImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, colorizeImageReq);
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
                colorizeImageReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ColorizeImageResponse colorizeImageResp = ColorizeImageWithOptions(colorizeImageReq, runtime);
            return colorizeImageResp;
        }

        public async Task<ColorizeImageResponse> ColorizeImageAdvanceAsync(ColorizeImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ColorizeImageRequest colorizeImageReq = new ColorizeImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, colorizeImageReq);
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
                colorizeImageReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ColorizeImageResponse colorizeImageResp = await ColorizeImageWithOptionsAsync(colorizeImageReq, runtime);
            return colorizeImageResp;
        }

        /// <param name="request">
        /// EnhanceImageColorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnhanceImageColorResponse
        /// </returns>
        public EnhanceImageColorResponse EnhanceImageColorWithOptions(EnhanceImageColorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnhanceImageColor",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnhanceImageColorResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EnhanceImageColorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnhanceImageColorResponse
        /// </returns>
        public async Task<EnhanceImageColorResponse> EnhanceImageColorWithOptionsAsync(EnhanceImageColorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnhanceImageColor",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnhanceImageColorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EnhanceImageColorRequest
        /// </param>
        /// 
        /// <returns>
        /// EnhanceImageColorResponse
        /// </returns>
        public EnhanceImageColorResponse EnhanceImageColor(EnhanceImageColorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnhanceImageColorWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EnhanceImageColorRequest
        /// </param>
        /// 
        /// <returns>
        /// EnhanceImageColorResponse
        /// </returns>
        public async Task<EnhanceImageColorResponse> EnhanceImageColorAsync(EnhanceImageColorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnhanceImageColorWithOptionsAsync(request, runtime);
        }

        public EnhanceImageColorResponse EnhanceImageColorAdvance(EnhanceImageColorAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            EnhanceImageColorRequest enhanceImageColorReq = new EnhanceImageColorRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, enhanceImageColorReq);
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
                enhanceImageColorReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            EnhanceImageColorResponse enhanceImageColorResp = EnhanceImageColorWithOptions(enhanceImageColorReq, runtime);
            return enhanceImageColorResp;
        }

        public async Task<EnhanceImageColorResponse> EnhanceImageColorAdvanceAsync(EnhanceImageColorAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            EnhanceImageColorRequest enhanceImageColorReq = new EnhanceImageColorRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, enhanceImageColorReq);
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
                enhanceImageColorReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            EnhanceImageColorResponse enhanceImageColorResp = await EnhanceImageColorWithOptionsAsync(enhanceImageColorReq, runtime);
            return enhanceImageColorResp;
        }

        /// <param name="request">
        /// ErasePersonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ErasePersonResponse
        /// </returns>
        public ErasePersonResponse ErasePersonWithOptions(ErasePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMask))
            {
                body["UserMask"] = request.UserMask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ErasePerson",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ErasePersonResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ErasePersonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ErasePersonResponse
        /// </returns>
        public async Task<ErasePersonResponse> ErasePersonWithOptionsAsync(ErasePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMask))
            {
                body["UserMask"] = request.UserMask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ErasePerson",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ErasePersonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ErasePersonRequest
        /// </param>
        /// 
        /// <returns>
        /// ErasePersonResponse
        /// </returns>
        public ErasePersonResponse ErasePerson(ErasePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ErasePersonWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ErasePersonRequest
        /// </param>
        /// 
        /// <returns>
        /// ErasePersonResponse
        /// </returns>
        public async Task<ErasePersonResponse> ErasePersonAsync(ErasePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ErasePersonWithOptionsAsync(request, runtime);
        }

        public ErasePersonResponse ErasePersonAdvance(ErasePersonAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ErasePersonRequest erasePersonReq = new ErasePersonRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, erasePersonReq);
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
                erasePersonReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMaskObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UserMaskObject,
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
                erasePersonReq.UserMask = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ErasePersonResponse erasePersonResp = ErasePersonWithOptions(erasePersonReq, runtime);
            return erasePersonResp;
        }

        public async Task<ErasePersonResponse> ErasePersonAdvanceAsync(ErasePersonAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ErasePersonRequest erasePersonReq = new ErasePersonRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, erasePersonReq);
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
                erasePersonReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMaskObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.UserMaskObject,
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
                erasePersonReq.UserMask = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ErasePersonResponse erasePersonResp = await ErasePersonWithOptionsAsync(erasePersonReq, runtime);
            return erasePersonResp;
        }

        /// <param name="request">
        /// ExtendImageStyleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExtendImageStyleResponse
        /// </returns>
        public ExtendImageStyleResponse ExtendImageStyleWithOptions(ExtendImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorUrl))
            {
                body["MajorUrl"] = request.MajorUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrl))
            {
                body["StyleUrl"] = request.StyleUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtendImageStyle",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtendImageStyleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ExtendImageStyleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExtendImageStyleResponse
        /// </returns>
        public async Task<ExtendImageStyleResponse> ExtendImageStyleWithOptionsAsync(ExtendImageStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorUrl))
            {
                body["MajorUrl"] = request.MajorUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrl))
            {
                body["StyleUrl"] = request.StyleUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtendImageStyle",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtendImageStyleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ExtendImageStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// ExtendImageStyleResponse
        /// </returns>
        public ExtendImageStyleResponse ExtendImageStyle(ExtendImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtendImageStyleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ExtendImageStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// ExtendImageStyleResponse
        /// </returns>
        public async Task<ExtendImageStyleResponse> ExtendImageStyleAsync(ExtendImageStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtendImageStyleWithOptionsAsync(request, runtime);
        }

        public ExtendImageStyleResponse ExtendImageStyleAdvance(ExtendImageStyleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ExtendImageStyleRequest extendImageStyleReq = new ExtendImageStyleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, extendImageStyleReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.MajorUrlObject,
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
                extendImageStyleReq.MajorUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrlObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.StyleUrlObject,
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
                extendImageStyleReq.StyleUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ExtendImageStyleResponse extendImageStyleResp = ExtendImageStyleWithOptions(extendImageStyleReq, runtime);
            return extendImageStyleResp;
        }

        public async Task<ExtendImageStyleResponse> ExtendImageStyleAdvanceAsync(ExtendImageStyleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ExtendImageStyleRequest extendImageStyleReq = new ExtendImageStyleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, extendImageStyleReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MajorUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.MajorUrlObject,
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
                extendImageStyleReq.MajorUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrlObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.StyleUrlObject,
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
                extendImageStyleReq.StyleUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ExtendImageStyleResponse extendImageStyleResp = await ExtendImageStyleWithOptionsAsync(extendImageStyleReq, runtime);
            return extendImageStyleResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像卡通化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCartoonizedImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCartoonizedImageResponse
        /// </returns>
        public GenerateCartoonizedImageResponse GenerateCartoonizedImageWithOptions(GenerateCartoonizedImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["Index"] = request.Index;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCartoonizedImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCartoonizedImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像卡通化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCartoonizedImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCartoonizedImageResponse
        /// </returns>
        public async Task<GenerateCartoonizedImageResponse> GenerateCartoonizedImageWithOptionsAsync(GenerateCartoonizedImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["Index"] = request.Index;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCartoonizedImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCartoonizedImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像卡通化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCartoonizedImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCartoonizedImageResponse
        /// </returns>
        public GenerateCartoonizedImageResponse GenerateCartoonizedImage(GenerateCartoonizedImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateCartoonizedImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像卡通化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCartoonizedImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCartoonizedImageResponse
        /// </returns>
        public async Task<GenerateCartoonizedImageResponse> GenerateCartoonizedImageAsync(GenerateCartoonizedImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateCartoonizedImageWithOptionsAsync(request, runtime);
        }

        public GenerateCartoonizedImageResponse GenerateCartoonizedImageAdvance(GenerateCartoonizedImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateCartoonizedImageRequest generateCartoonizedImageReq = new GenerateCartoonizedImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateCartoonizedImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageUrlObject,
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
                generateCartoonizedImageReq.ImageUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateCartoonizedImageResponse generateCartoonizedImageResp = GenerateCartoonizedImageWithOptions(generateCartoonizedImageReq, runtime);
            return generateCartoonizedImageResp;
        }

        public async Task<GenerateCartoonizedImageResponse> GenerateCartoonizedImageAdvanceAsync(GenerateCartoonizedImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateCartoonizedImageRequest generateCartoonizedImageReq = new GenerateCartoonizedImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateCartoonizedImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageUrlObject,
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
                generateCartoonizedImageReq.ImageUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateCartoonizedImageResponse generateCartoonizedImageResp = await GenerateCartoonizedImageWithOptionsAsync(generateCartoonizedImageReq, runtime);
            return generateCartoonizedImageResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图像微动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDynamicImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDynamicImageResponse
        /// </returns>
        public GenerateDynamicImageResponse GenerateDynamicImageWithOptions(GenerateDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
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
                Action = "GenerateDynamicImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDynamicImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图像微动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDynamicImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDynamicImageResponse
        /// </returns>
        public async Task<GenerateDynamicImageResponse> GenerateDynamicImageWithOptionsAsync(GenerateDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
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
                Action = "GenerateDynamicImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDynamicImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图像微动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDynamicImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDynamicImageResponse
        /// </returns>
        public GenerateDynamicImageResponse GenerateDynamicImage(GenerateDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDynamicImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图像微动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDynamicImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDynamicImageResponse
        /// </returns>
        public async Task<GenerateDynamicImageResponse> GenerateDynamicImageAsync(GenerateDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDynamicImageWithOptionsAsync(request, runtime);
        }

        public GenerateDynamicImageResponse GenerateDynamicImageAdvance(GenerateDynamicImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateDynamicImageRequest generateDynamicImageReq = new GenerateDynamicImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateDynamicImageReq);
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
                generateDynamicImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateDynamicImageResponse generateDynamicImageResp = GenerateDynamicImageWithOptions(generateDynamicImageReq, runtime);
            return generateDynamicImageResp;
        }

        public async Task<GenerateDynamicImageResponse> GenerateDynamicImageAdvanceAsync(GenerateDynamicImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateDynamicImageRequest generateDynamicImageReq = new GenerateDynamicImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateDynamicImageReq);
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
                generateDynamicImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateDynamicImageResponse generateDynamicImageResp = await GenerateDynamicImageWithOptionsAsync(generateDynamicImageReq, runtime);
            return generateDynamicImageResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextResponse
        /// </returns>
        public GenerateImageWithTextResponse GenerateImageWithTextWithOptions(GenerateImageWithTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                body["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateImageWithText",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateImageWithTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextResponse
        /// </returns>
        public async Task<GenerateImageWithTextResponse> GenerateImageWithTextWithOptionsAsync(GenerateImageWithTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                body["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateImageWithText",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateImageWithTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextResponse
        /// </returns>
        public GenerateImageWithTextResponse GenerateImageWithText(GenerateImageWithTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateImageWithTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextResponse
        /// </returns>
        public async Task<GenerateImageWithTextResponse> GenerateImageWithTextAsync(GenerateImageWithTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateImageWithTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本和参考图到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextAndImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextAndImageResponse
        /// </returns>
        public GenerateImageWithTextAndImageResponse GenerateImageWithTextAndImageWithOptions(GenerateImageWithTextAndImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatioMode))
            {
                body["AspectRatioMode"] = request.AspectRatioMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefImageUrl))
            {
                body["RefImageUrl"] = request.RefImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                body["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Similarity))
            {
                body["Similarity"] = request.Similarity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateImageWithTextAndImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateImageWithTextAndImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本和参考图到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextAndImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextAndImageResponse
        /// </returns>
        public async Task<GenerateImageWithTextAndImageResponse> GenerateImageWithTextAndImageWithOptionsAsync(GenerateImageWithTextAndImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatioMode))
            {
                body["AspectRatioMode"] = request.AspectRatioMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefImageUrl))
            {
                body["RefImageUrl"] = request.RefImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                body["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Similarity))
            {
                body["Similarity"] = request.Similarity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateImageWithTextAndImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateImageWithTextAndImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本和参考图到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextAndImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextAndImageResponse
        /// </returns>
        public GenerateImageWithTextAndImageResponse GenerateImageWithTextAndImage(GenerateImageWithTextAndImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateImageWithTextAndImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本和参考图到图像生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageWithTextAndImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageWithTextAndImageResponse
        /// </returns>
        public async Task<GenerateImageWithTextAndImageResponse> GenerateImageWithTextAndImageAsync(GenerateImageWithTextAndImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateImageWithTextAndImageWithOptionsAsync(request, runtime);
        }

        public GenerateImageWithTextAndImageResponse GenerateImageWithTextAndImageAdvance(GenerateImageWithTextAndImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateImageWithTextAndImageRequest generateImageWithTextAndImageReq = new GenerateImageWithTextAndImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateImageWithTextAndImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefImageUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.RefImageUrlObject,
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
                generateImageWithTextAndImageReq.RefImageUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateImageWithTextAndImageResponse generateImageWithTextAndImageResp = GenerateImageWithTextAndImageWithOptions(generateImageWithTextAndImageReq, runtime);
            return generateImageWithTextAndImageResp;
        }

        public async Task<GenerateImageWithTextAndImageResponse> GenerateImageWithTextAndImageAdvanceAsync(GenerateImageWithTextAndImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateImageWithTextAndImageRequest generateImageWithTextAndImageReq = new GenerateImageWithTextAndImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateImageWithTextAndImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefImageUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.RefImageUrlObject,
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
                generateImageWithTextAndImageReq.RefImageUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateImageWithTextAndImageResponse generateImageWithTextAndImageResp = await GenerateImageWithTextAndImageWithOptionsAsync(generateImageWithTextAndImageReq, runtime);
            return generateImageWithTextAndImageResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像超分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSuperResolutionImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateSuperResolutionImageResponse
        /// </returns>
        public GenerateSuperResolutionImageResponse GenerateSuperResolutionImageWithOptions(GenerateSuperResolutionImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQuality))
            {
                body["OutputQuality"] = request.OutputQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scale))
            {
                body["Scale"] = request.Scale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateSuperResolutionImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateSuperResolutionImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像超分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSuperResolutionImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateSuperResolutionImageResponse
        /// </returns>
        public async Task<GenerateSuperResolutionImageResponse> GenerateSuperResolutionImageWithOptionsAsync(GenerateSuperResolutionImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQuality))
            {
                body["OutputQuality"] = request.OutputQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scale))
            {
                body["Scale"] = request.Scale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateSuperResolutionImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateSuperResolutionImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像超分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSuperResolutionImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateSuperResolutionImageResponse
        /// </returns>
        public GenerateSuperResolutionImageResponse GenerateSuperResolutionImage(GenerateSuperResolutionImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateSuperResolutionImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成式图像超分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateSuperResolutionImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateSuperResolutionImageResponse
        /// </returns>
        public async Task<GenerateSuperResolutionImageResponse> GenerateSuperResolutionImageAsync(GenerateSuperResolutionImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateSuperResolutionImageWithOptionsAsync(request, runtime);
        }

        public GenerateSuperResolutionImageResponse GenerateSuperResolutionImageAdvance(GenerateSuperResolutionImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateSuperResolutionImageRequest generateSuperResolutionImageReq = new GenerateSuperResolutionImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateSuperResolutionImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageUrlObject,
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
                generateSuperResolutionImageReq.ImageUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateSuperResolutionImageResponse generateSuperResolutionImageResp = GenerateSuperResolutionImageWithOptions(generateSuperResolutionImageReq, runtime);
            return generateSuperResolutionImageResp;
        }

        public async Task<GenerateSuperResolutionImageResponse> GenerateSuperResolutionImageAdvanceAsync(GenerateSuperResolutionImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            GenerateSuperResolutionImageRequest generateSuperResolutionImageReq = new GenerateSuperResolutionImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, generateSuperResolutionImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageUrlObject,
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
                generateSuperResolutionImageReq.ImageUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            GenerateSuperResolutionImageResponse generateSuperResolutionImageResp = await GenerateSuperResolutionImageWithOptionsAsync(generateSuperResolutionImageReq, runtime);
            return generateSuperResolutionImageResp;
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncJobResult",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncJobResult",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
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

        /// <param name="request">
        /// ImageBlindCharacterWatermarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindCharacterWatermarkResponse
        /// </returns>
        public ImageBlindCharacterWatermarkResponse ImageBlindCharacterWatermarkWithOptions(ImageBlindCharacterWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["FunctionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURL))
            {
                body["OriginImageURL"] = request.OriginImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFileType))
            {
                body["OutputFileType"] = request.OutputFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityFactor))
            {
                body["QualityFactor"] = request.QualityFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURL))
            {
                body["WatermarkImageURL"] = request.WatermarkImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageBlindCharacterWatermark",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageBlindCharacterWatermarkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ImageBlindCharacterWatermarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindCharacterWatermarkResponse
        /// </returns>
        public async Task<ImageBlindCharacterWatermarkResponse> ImageBlindCharacterWatermarkWithOptionsAsync(ImageBlindCharacterWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["FunctionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURL))
            {
                body["OriginImageURL"] = request.OriginImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFileType))
            {
                body["OutputFileType"] = request.OutputFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityFactor))
            {
                body["QualityFactor"] = request.QualityFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURL))
            {
                body["WatermarkImageURL"] = request.WatermarkImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageBlindCharacterWatermark",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageBlindCharacterWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ImageBlindCharacterWatermarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindCharacterWatermarkResponse
        /// </returns>
        public ImageBlindCharacterWatermarkResponse ImageBlindCharacterWatermark(ImageBlindCharacterWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageBlindCharacterWatermarkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ImageBlindCharacterWatermarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindCharacterWatermarkResponse
        /// </returns>
        public async Task<ImageBlindCharacterWatermarkResponse> ImageBlindCharacterWatermarkAsync(ImageBlindCharacterWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageBlindCharacterWatermarkWithOptionsAsync(request, runtime);
        }

        public ImageBlindCharacterWatermarkResponse ImageBlindCharacterWatermarkAdvance(ImageBlindCharacterWatermarkAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ImageBlindCharacterWatermarkRequest imageBlindCharacterWatermarkReq = new ImageBlindCharacterWatermarkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, imageBlindCharacterWatermarkReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.OriginImageURLObject,
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
                imageBlindCharacterWatermarkReq.OriginImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURLObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.WatermarkImageURLObject,
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
                imageBlindCharacterWatermarkReq.WatermarkImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ImageBlindCharacterWatermarkResponse imageBlindCharacterWatermarkResp = ImageBlindCharacterWatermarkWithOptions(imageBlindCharacterWatermarkReq, runtime);
            return imageBlindCharacterWatermarkResp;
        }

        public async Task<ImageBlindCharacterWatermarkResponse> ImageBlindCharacterWatermarkAdvanceAsync(ImageBlindCharacterWatermarkAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ImageBlindCharacterWatermarkRequest imageBlindCharacterWatermarkReq = new ImageBlindCharacterWatermarkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, imageBlindCharacterWatermarkReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.OriginImageURLObject,
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
                imageBlindCharacterWatermarkReq.OriginImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURLObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.WatermarkImageURLObject,
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
                imageBlindCharacterWatermarkReq.WatermarkImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ImageBlindCharacterWatermarkResponse imageBlindCharacterWatermarkResp = await ImageBlindCharacterWatermarkWithOptionsAsync(imageBlindCharacterWatermarkReq, runtime);
            return imageBlindCharacterWatermarkResp;
        }

        /// <param name="request">
        /// ImageBlindPicWatermarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindPicWatermarkResponse
        /// </returns>
        public ImageBlindPicWatermarkResponse ImageBlindPicWatermarkWithOptions(ImageBlindPicWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["FunctionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoURL))
            {
                body["LogoURL"] = request.LogoURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURL))
            {
                body["OriginImageURL"] = request.OriginImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFileType))
            {
                body["OutputFileType"] = request.OutputFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityFactor))
            {
                body["QualityFactor"] = request.QualityFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURL))
            {
                body["WatermarkImageURL"] = request.WatermarkImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageBlindPicWatermark",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageBlindPicWatermarkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ImageBlindPicWatermarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindPicWatermarkResponse
        /// </returns>
        public async Task<ImageBlindPicWatermarkResponse> ImageBlindPicWatermarkWithOptionsAsync(ImageBlindPicWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["FunctionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoURL))
            {
                body["LogoURL"] = request.LogoURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURL))
            {
                body["OriginImageURL"] = request.OriginImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFileType))
            {
                body["OutputFileType"] = request.OutputFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityFactor))
            {
                body["QualityFactor"] = request.QualityFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURL))
            {
                body["WatermarkImageURL"] = request.WatermarkImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageBlindPicWatermark",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageBlindPicWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ImageBlindPicWatermarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindPicWatermarkResponse
        /// </returns>
        public ImageBlindPicWatermarkResponse ImageBlindPicWatermark(ImageBlindPicWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageBlindPicWatermarkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ImageBlindPicWatermarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageBlindPicWatermarkResponse
        /// </returns>
        public async Task<ImageBlindPicWatermarkResponse> ImageBlindPicWatermarkAsync(ImageBlindPicWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageBlindPicWatermarkWithOptionsAsync(request, runtime);
        }

        public ImageBlindPicWatermarkResponse ImageBlindPicWatermarkAdvance(ImageBlindPicWatermarkAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ImageBlindPicWatermarkRequest imageBlindPicWatermarkReq = new ImageBlindPicWatermarkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, imageBlindPicWatermarkReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoURLObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.LogoURLObject,
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
                imageBlindPicWatermarkReq.LogoURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURLObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.OriginImageURLObject,
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
                imageBlindPicWatermarkReq.OriginImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURLObject))
            {
                object tmpResp2 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp2);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.WatermarkImageURLObject,
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
                imageBlindPicWatermarkReq.WatermarkImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ImageBlindPicWatermarkResponse imageBlindPicWatermarkResp = ImageBlindPicWatermarkWithOptions(imageBlindPicWatermarkReq, runtime);
            return imageBlindPicWatermarkResp;
        }

        public async Task<ImageBlindPicWatermarkResponse> ImageBlindPicWatermarkAdvanceAsync(ImageBlindPicWatermarkAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ImageBlindPicWatermarkRequest imageBlindPicWatermarkReq = new ImageBlindPicWatermarkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, imageBlindPicWatermarkReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoURLObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.LogoURLObject,
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
                imageBlindPicWatermarkReq.LogoURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginImageURLObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.OriginImageURLObject,
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
                imageBlindPicWatermarkReq.OriginImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkImageURLObject))
            {
                object tmpResp2 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp2);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.WatermarkImageURLObject,
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
                imageBlindPicWatermarkReq.WatermarkImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ImageBlindPicWatermarkResponse imageBlindPicWatermarkResp = await ImageBlindPicWatermarkWithOptionsAsync(imageBlindPicWatermarkReq, runtime);
            return imageBlindPicWatermarkResp;
        }

        /// <param name="request">
        /// ImitatePhotoStyleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImitatePhotoStyleResponse
        /// </returns>
        public ImitatePhotoStyleResponse ImitatePhotoStyleWithOptions(ImitatePhotoStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrl))
            {
                body["StyleUrl"] = request.StyleUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImitatePhotoStyle",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImitatePhotoStyleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ImitatePhotoStyleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImitatePhotoStyleResponse
        /// </returns>
        public async Task<ImitatePhotoStyleResponse> ImitatePhotoStyleWithOptionsAsync(ImitatePhotoStyleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrl))
            {
                body["StyleUrl"] = request.StyleUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImitatePhotoStyle",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImitatePhotoStyleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ImitatePhotoStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// ImitatePhotoStyleResponse
        /// </returns>
        public ImitatePhotoStyleResponse ImitatePhotoStyle(ImitatePhotoStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImitatePhotoStyleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ImitatePhotoStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// ImitatePhotoStyleResponse
        /// </returns>
        public async Task<ImitatePhotoStyleResponse> ImitatePhotoStyleAsync(ImitatePhotoStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImitatePhotoStyleWithOptionsAsync(request, runtime);
        }

        public ImitatePhotoStyleResponse ImitatePhotoStyleAdvance(ImitatePhotoStyleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ImitatePhotoStyleRequest imitatePhotoStyleReq = new ImitatePhotoStyleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, imitatePhotoStyleReq);
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
                imitatePhotoStyleReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrlObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.StyleUrlObject,
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
                imitatePhotoStyleReq.StyleUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ImitatePhotoStyleResponse imitatePhotoStyleResp = ImitatePhotoStyleWithOptions(imitatePhotoStyleReq, runtime);
            return imitatePhotoStyleResp;
        }

        public async Task<ImitatePhotoStyleResponse> ImitatePhotoStyleAdvanceAsync(ImitatePhotoStyleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            ImitatePhotoStyleRequest imitatePhotoStyleReq = new ImitatePhotoStyleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, imitatePhotoStyleReq);
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
                imitatePhotoStyleReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleUrlObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.StyleUrlObject,
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
                imitatePhotoStyleReq.StyleUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ImitatePhotoStyleResponse imitatePhotoStyleResp = await ImitatePhotoStyleWithOptionsAsync(imitatePhotoStyleReq, runtime);
            return imitatePhotoStyleResp;
        }

        /// <param name="request">
        /// IntelligentCompositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IntelligentCompositionResponse
        /// </returns>
        public IntelligentCompositionResponse IntelligentCompositionWithOptions(IntelligentCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumBoxes))
            {
                body["NumBoxes"] = request.NumBoxes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntelligentComposition",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntelligentCompositionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// IntelligentCompositionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IntelligentCompositionResponse
        /// </returns>
        public async Task<IntelligentCompositionResponse> IntelligentCompositionWithOptionsAsync(IntelligentCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumBoxes))
            {
                body["NumBoxes"] = request.NumBoxes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IntelligentComposition",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntelligentCompositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// IntelligentCompositionRequest
        /// </param>
        /// 
        /// <returns>
        /// IntelligentCompositionResponse
        /// </returns>
        public IntelligentCompositionResponse IntelligentComposition(IntelligentCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IntelligentCompositionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// IntelligentCompositionRequest
        /// </param>
        /// 
        /// <returns>
        /// IntelligentCompositionResponse
        /// </returns>
        public async Task<IntelligentCompositionResponse> IntelligentCompositionAsync(IntelligentCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IntelligentCompositionWithOptionsAsync(request, runtime);
        }

        public IntelligentCompositionResponse IntelligentCompositionAdvance(IntelligentCompositionAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            IntelligentCompositionRequest intelligentCompositionReq = new IntelligentCompositionRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, intelligentCompositionReq);
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
                intelligentCompositionReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            IntelligentCompositionResponse intelligentCompositionResp = IntelligentCompositionWithOptions(intelligentCompositionReq, runtime);
            return intelligentCompositionResp;
        }

        public async Task<IntelligentCompositionResponse> IntelligentCompositionAdvanceAsync(IntelligentCompositionAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            IntelligentCompositionRequest intelligentCompositionReq = new IntelligentCompositionRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, intelligentCompositionReq);
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
                intelligentCompositionReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            IntelligentCompositionResponse intelligentCompositionResp = await IntelligentCompositionWithOptionsAsync(intelligentCompositionReq, runtime);
            return intelligentCompositionResp;
        }

        /// <param name="request">
        /// MakeSuperResolutionImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MakeSuperResolutionImageResponse
        /// </returns>
        public MakeSuperResolutionImageResponse MakeSuperResolutionImageWithOptions(MakeSuperResolutionImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQuality))
            {
                body["OutputQuality"] = request.OutputQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpscaleFactor))
            {
                body["UpscaleFactor"] = request.UpscaleFactor;
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
                Action = "MakeSuperResolutionImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeSuperResolutionImageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// MakeSuperResolutionImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MakeSuperResolutionImageResponse
        /// </returns>
        public async Task<MakeSuperResolutionImageResponse> MakeSuperResolutionImageWithOptionsAsync(MakeSuperResolutionImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQuality))
            {
                body["OutputQuality"] = request.OutputQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpscaleFactor))
            {
                body["UpscaleFactor"] = request.UpscaleFactor;
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
                Action = "MakeSuperResolutionImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeSuperResolutionImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// MakeSuperResolutionImageRequest
        /// </param>
        /// 
        /// <returns>
        /// MakeSuperResolutionImageResponse
        /// </returns>
        public MakeSuperResolutionImageResponse MakeSuperResolutionImage(MakeSuperResolutionImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MakeSuperResolutionImageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// MakeSuperResolutionImageRequest
        /// </param>
        /// 
        /// <returns>
        /// MakeSuperResolutionImageResponse
        /// </returns>
        public async Task<MakeSuperResolutionImageResponse> MakeSuperResolutionImageAsync(MakeSuperResolutionImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MakeSuperResolutionImageWithOptionsAsync(request, runtime);
        }

        public MakeSuperResolutionImageResponse MakeSuperResolutionImageAdvance(MakeSuperResolutionImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            MakeSuperResolutionImageRequest makeSuperResolutionImageReq = new MakeSuperResolutionImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, makeSuperResolutionImageReq);
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
                makeSuperResolutionImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            MakeSuperResolutionImageResponse makeSuperResolutionImageResp = MakeSuperResolutionImageWithOptions(makeSuperResolutionImageReq, runtime);
            return makeSuperResolutionImageResp;
        }

        public async Task<MakeSuperResolutionImageResponse> MakeSuperResolutionImageAdvanceAsync(MakeSuperResolutionImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            MakeSuperResolutionImageRequest makeSuperResolutionImageReq = new MakeSuperResolutionImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, makeSuperResolutionImageReq);
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
                makeSuperResolutionImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            MakeSuperResolutionImageResponse makeSuperResolutionImageResp = await MakeSuperResolutionImageWithOptionsAsync(makeSuperResolutionImageReq, runtime);
            return makeSuperResolutionImageResp;
        }

        /// <param name="request">
        /// RecolorHDImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecolorHDImageResponse
        /// </returns>
        public RecolorHDImageResponse RecolorHDImageWithOptions(RecolorHDImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorCount))
            {
                body["ColorCount"] = request.ColorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorTemplate))
            {
                body["ColorTemplate"] = request.ColorTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Degree))
            {
                body["Degree"] = request.Degree;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrl))
            {
                body["RefUrl"] = request.RefUrl;
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
                Action = "RecolorHDImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecolorHDImageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RecolorHDImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecolorHDImageResponse
        /// </returns>
        public async Task<RecolorHDImageResponse> RecolorHDImageWithOptionsAsync(RecolorHDImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorCount))
            {
                body["ColorCount"] = request.ColorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorTemplate))
            {
                body["ColorTemplate"] = request.ColorTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Degree))
            {
                body["Degree"] = request.Degree;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrl))
            {
                body["RefUrl"] = request.RefUrl;
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
                Action = "RecolorHDImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecolorHDImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RecolorHDImageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecolorHDImageResponse
        /// </returns>
        public RecolorHDImageResponse RecolorHDImage(RecolorHDImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecolorHDImageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RecolorHDImageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecolorHDImageResponse
        /// </returns>
        public async Task<RecolorHDImageResponse> RecolorHDImageAsync(RecolorHDImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecolorHDImageWithOptionsAsync(request, runtime);
        }

        public RecolorHDImageResponse RecolorHDImageAdvance(RecolorHDImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RecolorHDImageRequest recolorHDImageReq = new RecolorHDImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recolorHDImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.RefUrlObject,
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
                recolorHDImageReq.RefUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
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
                recolorHDImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecolorHDImageResponse recolorHDImageResp = RecolorHDImageWithOptions(recolorHDImageReq, runtime);
            return recolorHDImageResp;
        }

        public async Task<RecolorHDImageResponse> RecolorHDImageAdvanceAsync(RecolorHDImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RecolorHDImageRequest recolorHDImageReq = new RecolorHDImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recolorHDImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.RefUrlObject,
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
                recolorHDImageReq.RefUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
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
                recolorHDImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecolorHDImageResponse recolorHDImageResp = await RecolorHDImageWithOptionsAsync(recolorHDImageReq, runtime);
            return recolorHDImageResp;
        }

        /// <param name="request">
        /// RecolorImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecolorImageResponse
        /// </returns>
        public RecolorImageResponse RecolorImageWithOptions(RecolorImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorCount))
            {
                body["ColorCount"] = request.ColorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorTemplate))
            {
                body["ColorTemplate"] = request.ColorTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrl))
            {
                body["RefUrl"] = request.RefUrl;
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
                Action = "RecolorImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecolorImageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RecolorImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecolorImageResponse
        /// </returns>
        public async Task<RecolorImageResponse> RecolorImageWithOptionsAsync(RecolorImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorCount))
            {
                body["ColorCount"] = request.ColorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorTemplate))
            {
                body["ColorTemplate"] = request.ColorTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrl))
            {
                body["RefUrl"] = request.RefUrl;
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
                Action = "RecolorImage",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecolorImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RecolorImageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecolorImageResponse
        /// </returns>
        public RecolorImageResponse RecolorImage(RecolorImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecolorImageWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RecolorImageRequest
        /// </param>
        /// 
        /// <returns>
        /// RecolorImageResponse
        /// </returns>
        public async Task<RecolorImageResponse> RecolorImageAsync(RecolorImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecolorImageWithOptionsAsync(request, runtime);
        }

        public RecolorImageResponse RecolorImageAdvance(RecolorImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RecolorImageRequest recolorImageReq = new RecolorImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recolorImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrlObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.RefUrlObject,
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
                recolorImageReq.RefUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
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
                recolorImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecolorImageResponse recolorImageResp = RecolorImageWithOptions(recolorImageReq, runtime);
            return recolorImageResp;
        }

        public async Task<RecolorImageResponse> RecolorImageAdvanceAsync(RecolorImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RecolorImageRequest recolorImageReq = new RecolorImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recolorImageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefUrlObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.RefUrlObject,
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
                recolorImageReq.RefUrl = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
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
                recolorImageReq.Url = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RecolorImageResponse recolorImageResp = await RecolorImageWithOptionsAsync(recolorImageReq, runtime);
            return recolorImageResp;
        }

        /// <param name="request">
        /// RemoveImageSubtitlesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageSubtitlesResponse
        /// </returns>
        public RemoveImageSubtitlesResponse RemoveImageSubtitlesWithOptions(RemoveImageSubtitlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BH))
            {
                body["BH"] = request.BH;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BW))
            {
                body["BW"] = request.BW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BX))
            {
                body["BX"] = request.BX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BY))
            {
                body["BY"] = request.BY;
            }
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
                Action = "RemoveImageSubtitles",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageSubtitlesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RemoveImageSubtitlesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageSubtitlesResponse
        /// </returns>
        public async Task<RemoveImageSubtitlesResponse> RemoveImageSubtitlesWithOptionsAsync(RemoveImageSubtitlesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BH))
            {
                body["BH"] = request.BH;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BW))
            {
                body["BW"] = request.BW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BX))
            {
                body["BX"] = request.BX;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BY))
            {
                body["BY"] = request.BY;
            }
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
                Action = "RemoveImageSubtitles",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageSubtitlesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RemoveImageSubtitlesRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageSubtitlesResponse
        /// </returns>
        public RemoveImageSubtitlesResponse RemoveImageSubtitles(RemoveImageSubtitlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveImageSubtitlesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RemoveImageSubtitlesRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageSubtitlesResponse
        /// </returns>
        public async Task<RemoveImageSubtitlesResponse> RemoveImageSubtitlesAsync(RemoveImageSubtitlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveImageSubtitlesWithOptionsAsync(request, runtime);
        }

        public RemoveImageSubtitlesResponse RemoveImageSubtitlesAdvance(RemoveImageSubtitlesAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RemoveImageSubtitlesRequest removeImageSubtitlesReq = new RemoveImageSubtitlesRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, removeImageSubtitlesReq);
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
                removeImageSubtitlesReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RemoveImageSubtitlesResponse removeImageSubtitlesResp = RemoveImageSubtitlesWithOptions(removeImageSubtitlesReq, runtime);
            return removeImageSubtitlesResp;
        }

        public async Task<RemoveImageSubtitlesResponse> RemoveImageSubtitlesAdvanceAsync(RemoveImageSubtitlesAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RemoveImageSubtitlesRequest removeImageSubtitlesReq = new RemoveImageSubtitlesRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, removeImageSubtitlesReq);
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
                removeImageSubtitlesReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RemoveImageSubtitlesResponse removeImageSubtitlesResp = await RemoveImageSubtitlesWithOptionsAsync(removeImageSubtitlesReq, runtime);
            return removeImageSubtitlesResp;
        }

        /// <param name="request">
        /// RemoveImageWatermarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageWatermarkResponse
        /// </returns>
        public RemoveImageWatermarkResponse RemoveImageWatermarkWithOptions(RemoveImageWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RemoveImageWatermark",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageWatermarkResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RemoveImageWatermarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageWatermarkResponse
        /// </returns>
        public async Task<RemoveImageWatermarkResponse> RemoveImageWatermarkWithOptionsAsync(RemoveImageWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RemoveImageWatermark",
                Version = "2019-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RemoveImageWatermarkRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageWatermarkResponse
        /// </returns>
        public RemoveImageWatermarkResponse RemoveImageWatermark(RemoveImageWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveImageWatermarkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RemoveImageWatermarkRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveImageWatermarkResponse
        /// </returns>
        public async Task<RemoveImageWatermarkResponse> RemoveImageWatermarkAsync(RemoveImageWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveImageWatermarkWithOptionsAsync(request, runtime);
        }

        public RemoveImageWatermarkResponse RemoveImageWatermarkAdvance(RemoveImageWatermarkAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RemoveImageWatermarkRequest removeImageWatermarkReq = new RemoveImageWatermarkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, removeImageWatermarkReq);
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
                removeImageWatermarkReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RemoveImageWatermarkResponse removeImageWatermarkResp = RemoveImageWatermarkWithOptions(removeImageWatermarkReq, runtime);
            return removeImageWatermarkResp;
        }

        public async Task<RemoveImageWatermarkResponse> RemoveImageWatermarkAdvanceAsync(RemoveImageWatermarkAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "imageenhan"},
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
            RemoveImageWatermarkRequest removeImageWatermarkReq = new RemoveImageWatermarkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, removeImageWatermarkReq);
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
                removeImageWatermarkReq.ImageURL = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            RemoveImageWatermarkResponse removeImageWatermarkResp = await RemoveImageWatermarkWithOptionsAsync(removeImageWatermarkReq, runtime);
            return removeImageWatermarkResp;
        }

    }
}
