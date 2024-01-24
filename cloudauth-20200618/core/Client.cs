// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth20200618.Models;

namespace AlibabaCloud.SDK.Cloudauth20200618
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ContrastSmartVerifyResponse ContrastSmartVerifyWithOptions(ContrastSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                body["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                body["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                body["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicFile))
            {
                body["FacePicFile"] = request.FacePicFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicString))
            {
                body["FacePicString"] = request.FacePicString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                body["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContrastSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContrastSmartVerifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ContrastSmartVerifyResponse> ContrastSmartVerifyWithOptionsAsync(ContrastSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                body["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                body["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                body["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicFile))
            {
                body["FacePicFile"] = request.FacePicFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicString))
            {
                body["FacePicString"] = request.FacePicString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                body["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContrastSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContrastSmartVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ContrastSmartVerifyResponse ContrastSmartVerify(ContrastSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContrastSmartVerifyWithOptions(request, runtime);
        }

        public async Task<ContrastSmartVerifyResponse> ContrastSmartVerifyAsync(ContrastSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContrastSmartVerifyWithOptionsAsync(request, runtime);
        }

        public ContrastSmartVerifyResponse ContrastSmartVerifyAdvance(ContrastSmartVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Cloudauth",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ContrastSmartVerifyRequest contrastSmartVerifyReq = new ContrastSmartVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastSmartVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FacePicFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                contrastSmartVerifyReq.FacePicFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ContrastSmartVerifyResponse contrastSmartVerifyResp = ContrastSmartVerifyWithOptions(contrastSmartVerifyReq, runtime);
            return contrastSmartVerifyResp;
        }

        public async Task<ContrastSmartVerifyResponse> ContrastSmartVerifyAdvanceAsync(ContrastSmartVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Cloudauth",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ContrastSmartVerifyRequest contrastSmartVerifyReq = new ContrastSmartVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastSmartVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FacePicFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                contrastSmartVerifyReq.FacePicFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ContrastSmartVerifyResponse contrastSmartVerifyResp = await ContrastSmartVerifyWithOptionsAsync(contrastSmartVerifyReq, runtime);
            return contrastSmartVerifyResp;
        }

        public DescribeSmartVerifyResponse DescribeSmartVerifyWithOptions(DescribeSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureReturnType))
            {
                body["PictureReturnType"] = request.PictureReturnType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmartVerifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSmartVerifyResponse> DescribeSmartVerifyWithOptionsAsync(DescribeSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureReturnType))
            {
                body["PictureReturnType"] = request.PictureReturnType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmartVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSmartVerifyResponse DescribeSmartVerify(DescribeSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartVerifyWithOptions(request, runtime);
        }

        public async Task<DescribeSmartVerifyResponse> DescribeSmartVerifyAsync(DescribeSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartVerifyWithOptionsAsync(request, runtime);
        }

        public DescribeSmsDetailResponse DescribeSmsDetailWithOptions(DescribeSmsDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                body["SendDate"] = request.SendDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                body["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                body["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmsDetail",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmsDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSmsDetailResponse> DescribeSmsDetailWithOptionsAsync(DescribeSmsDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendDate))
            {
                body["SendDate"] = request.SendDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                body["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                body["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmsDetail",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmsDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSmsDetailResponse DescribeSmsDetail(DescribeSmsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmsDetailWithOptions(request, runtime);
        }

        public async Task<DescribeSmsDetailResponse> DescribeSmsDetailAsync(DescribeSmsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmsDetailWithOptionsAsync(request, runtime);
        }

        public ElementSmartVerifyResponse ElementSmartVerifyWithOptions(ElementSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFile))
            {
                body["CertFile"] = request.CertFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                body["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalEmblemUrl))
            {
                body["CertNationalEmblemUrl"] = request.CertNationalEmblemUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                body["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                body["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertUrl))
            {
                body["CertUrl"] = request.CertUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ElementSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ElementSmartVerifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ElementSmartVerifyResponse> ElementSmartVerifyWithOptionsAsync(ElementSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFile))
            {
                body["CertFile"] = request.CertFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                body["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalEmblemUrl))
            {
                body["CertNationalEmblemUrl"] = request.CertNationalEmblemUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                body["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                body["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertUrl))
            {
                body["CertUrl"] = request.CertUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ElementSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ElementSmartVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ElementSmartVerifyResponse ElementSmartVerify(ElementSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ElementSmartVerifyWithOptions(request, runtime);
        }

        public async Task<ElementSmartVerifyResponse> ElementSmartVerifyAsync(ElementSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ElementSmartVerifyWithOptionsAsync(request, runtime);
        }

        public ElementSmartVerifyResponse ElementSmartVerifyAdvance(ElementSmartVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Cloudauth",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ElementSmartVerifyRequest elementSmartVerifyReq = new ElementSmartVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, elementSmartVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.CertFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                elementSmartVerifyReq.CertFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ElementSmartVerifyResponse elementSmartVerifyResp = ElementSmartVerifyWithOptions(elementSmartVerifyReq, runtime);
            return elementSmartVerifyResp;
        }

        public async Task<ElementSmartVerifyResponse> ElementSmartVerifyAdvanceAsync(ElementSmartVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Cloudauth",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ElementSmartVerifyRequest elementSmartVerifyReq = new ElementSmartVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, elementSmartVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.CertFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                elementSmartVerifyReq.CertFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ElementSmartVerifyResponse elementSmartVerifyResp = await ElementSmartVerifyWithOptionsAsync(elementSmartVerifyReq, runtime);
            return elementSmartVerifyResp;
        }

        public InitSmartVerifyResponse InitSmartVerifyWithOptions(InitSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                body["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                body["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                body["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                body["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                body["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdName))
            {
                body["IdName"] = request.IdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdNo))
            {
                body["IdNo"] = request.IdNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                body["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                body["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                body["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["OssObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitSmartVerifyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitSmartVerifyResponse> InitSmartVerifyWithOptionsAsync(InitSmartVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                body["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                body["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                body["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                body["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                body["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdName))
            {
                body["IdName"] = request.IdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdNo))
            {
                body["IdNo"] = request.IdNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                body["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                body["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                body["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["OssObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitSmartVerify",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitSmartVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitSmartVerifyResponse InitSmartVerify(InitSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitSmartVerifyWithOptions(request, runtime);
        }

        public async Task<InitSmartVerifyResponse> InitSmartVerifyAsync(InitSmartVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitSmartVerifyWithOptionsAsync(request, runtime);
        }

        public SendSmsResponse SendSmsWithOptions(SendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                body["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                body["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSms",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSmsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendSmsResponse> SendSmsWithOptionsAsync(SendSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignName))
            {
                body["SignName"] = request.SignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                body["TemplateParam"] = request.TemplateParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSms",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendSmsResponse SendSms(SendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendSmsWithOptions(request, runtime);
        }

        public async Task<SendSmsResponse> SendSmsAsync(SendSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendSmsWithOptionsAsync(request, runtime);
        }

        public VerifyBankElementResponse VerifyBankElementWithOptions(VerifyBankElementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardFile))
            {
                body["BankCardFile"] = request.BankCardFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                body["BankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardUrl))
            {
                body["BankCardUrl"] = request.BankCardUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdName))
            {
                body["IdName"] = request.IdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdNo))
            {
                body["IdNo"] = request.IdNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyBankElement",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyBankElementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyBankElementResponse> VerifyBankElementWithOptionsAsync(VerifyBankElementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardFile))
            {
                body["BankCardFile"] = request.BankCardFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                body["BankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardUrl))
            {
                body["BankCardUrl"] = request.BankCardUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdName))
            {
                body["IdName"] = request.IdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdNo))
            {
                body["IdNo"] = request.IdNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyBankElement",
                Version = "2020-06-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyBankElementResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyBankElementResponse VerifyBankElement(VerifyBankElementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyBankElementWithOptions(request, runtime);
        }

        public async Task<VerifyBankElementResponse> VerifyBankElementAsync(VerifyBankElementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyBankElementWithOptionsAsync(request, runtime);
        }

        public VerifyBankElementResponse VerifyBankElementAdvance(VerifyBankElementAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Cloudauth",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            VerifyBankElementRequest verifyBankElementReq = new VerifyBankElementRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, verifyBankElementReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.BankCardFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                verifyBankElementReq.BankCardFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            VerifyBankElementResponse verifyBankElementResp = VerifyBankElementWithOptions(verifyBankElementReq, runtime);
            return verifyBankElementResp;
        }

        public async Task<VerifyBankElementResponse> VerifyBankElementAdvanceAsync(VerifyBankElementAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "Cloudauth",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            VerifyBankElementRequest verifyBankElementReq = new VerifyBankElementRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, verifyBankElementReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.BankCardFileObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                verifyBankElementReq.BankCardFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            VerifyBankElementResponse verifyBankElementResp = await VerifyBankElementWithOptionsAsync(verifyBankElementReq, runtime);
            return verifyBankElementResp;
        }

    }
}
