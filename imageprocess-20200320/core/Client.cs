// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Imageprocess20200320.Models;

namespace AlibabaCloud.SDK.Imageprocess20200320
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("imageprocess", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>主动脉瘤肺动脉高压检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeChestVesselRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeChestVesselResponse
        /// </returns>
        public AnalyzeChestVesselResponse AnalyzeChestVesselWithOptions(AnalyzeChestVesselRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeChestVessel",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeChestVesselResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主动脉瘤肺动脉高压检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeChestVesselRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeChestVesselResponse
        /// </returns>
        public async Task<AnalyzeChestVesselResponse> AnalyzeChestVesselWithOptionsAsync(AnalyzeChestVesselRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeChestVessel",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeChestVesselResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主动脉瘤肺动脉高压检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeChestVesselRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeChestVesselResponse
        /// </returns>
        public AnalyzeChestVesselResponse AnalyzeChestVessel(AnalyzeChestVesselRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AnalyzeChestVesselWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主动脉瘤肺动脉高压检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeChestVesselRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeChestVesselResponse
        /// </returns>
        public async Task<AnalyzeChestVesselResponse> AnalyzeChestVesselAsync(AnalyzeChestVesselRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AnalyzeChestVesselWithOptionsAsync(request, runtime);
        }

        public AnalyzeChestVesselResponse AnalyzeChestVesselAdvance(AnalyzeChestVesselAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            AnalyzeChestVesselRequest analyzeChestVesselReq = new AnalyzeChestVesselRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, analyzeChestVesselReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        AnalyzeChestVesselRequest.AnalyzeChestVesselRequestURLList tmp = analyzeChestVesselReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            AnalyzeChestVesselResponse analyzeChestVesselResp = AnalyzeChestVesselWithOptions(analyzeChestVesselReq, runtime);
            return analyzeChestVesselResp;
        }

        public async Task<AnalyzeChestVesselResponse> AnalyzeChestVesselAdvanceAsync(AnalyzeChestVesselAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            AnalyzeChestVesselRequest analyzeChestVesselReq = new AnalyzeChestVesselRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, analyzeChestVesselReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        AnalyzeChestVesselRequest.AnalyzeChestVesselRequestURLList tmp = analyzeChestVesselReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            AnalyzeChestVesselResponse analyzeChestVesselResp = await AnalyzeChestVesselWithOptionsAsync(analyzeChestVesselReq, runtime);
            return analyzeChestVesselResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>骨密度估计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CalcBMDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CalcBMDResponse
        /// </returns>
        public CalcBMDResponse CalcBMDWithOptions(CalcBMDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalcBMD",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalcBMDResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>骨密度估计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CalcBMDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CalcBMDResponse
        /// </returns>
        public async Task<CalcBMDResponse> CalcBMDWithOptionsAsync(CalcBMDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalcBMD",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalcBMDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>骨密度估计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CalcBMDRequest
        /// </param>
        /// 
        /// <returns>
        /// CalcBMDResponse
        /// </returns>
        public CalcBMDResponse CalcBMD(CalcBMDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CalcBMDWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>骨密度估计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CalcBMDRequest
        /// </param>
        /// 
        /// <returns>
        /// CalcBMDResponse
        /// </returns>
        public async Task<CalcBMDResponse> CalcBMDAsync(CalcBMDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CalcBMDWithOptionsAsync(request, runtime);
        }

        public CalcBMDResponse CalcBMDAdvance(CalcBMDAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CalcBMDRequest calcBMDReq = new CalcBMDRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, calcBMDReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        CalcBMDRequest.CalcBMDRequestURLList tmp = calcBMDReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            CalcBMDResponse calcBMDResp = CalcBMDWithOptions(calcBMDReq, runtime);
            return calcBMDResp;
        }

        public async Task<CalcBMDResponse> CalcBMDAdvanceAsync(CalcBMDAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CalcBMDRequest calcBMDReq = new CalcBMDRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, calcBMDReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        CalcBMDRequest.CalcBMDRequestURLList tmp = calcBMDReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            CalcBMDResponse calcBMDResp = await CalcBMDWithOptionsAsync(calcBMDReq, runtime);
            return calcBMDResp;
        }

        /// <param name="request">
        /// CalcCACSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CalcCACSResponse
        /// </returns>
        public CalcCACSResponse CalcCACSWithOptions(CalcCACSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalcCACS",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalcCACSResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CalcCACSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CalcCACSResponse
        /// </returns>
        public async Task<CalcCACSResponse> CalcCACSWithOptionsAsync(CalcCACSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalcCACS",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalcCACSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CalcCACSRequest
        /// </param>
        /// 
        /// <returns>
        /// CalcCACSResponse
        /// </returns>
        public CalcCACSResponse CalcCACS(CalcCACSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CalcCACSWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CalcCACSRequest
        /// </param>
        /// 
        /// <returns>
        /// CalcCACSResponse
        /// </returns>
        public async Task<CalcCACSResponse> CalcCACSAsync(CalcCACSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CalcCACSWithOptionsAsync(request, runtime);
        }

        public CalcCACSResponse CalcCACSAdvance(CalcCACSAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CalcCACSRequest calcCACSReq = new CalcCACSRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, calcCACSReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        CalcCACSRequest.CalcCACSRequestURLList tmp = calcCACSReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            CalcCACSResponse calcCACSResp = CalcCACSWithOptions(calcCACSReq, runtime);
            return calcCACSResp;
        }

        public async Task<CalcCACSResponse> CalcCACSAdvanceAsync(CalcCACSAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CalcCACSRequest calcCACSReq = new CalcCACSRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, calcCACSReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        CalcCACSRequest.CalcCACSRequestURLList tmp = calcCACSReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            CalcCACSResponse calcCACSResp = await CalcCACSWithOptionsAsync(calcCACSReq, runtime);
            return calcCACSResp;
        }

        /// <param name="request">
        /// DetectCovid19CadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectCovid19CadResponse
        /// </returns>
        public DetectCovid19CadResponse DetectCovid19CadWithOptions(DetectCovid19CadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectCovid19Cad",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectCovid19CadResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectCovid19CadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectCovid19CadResponse
        /// </returns>
        public async Task<DetectCovid19CadResponse> DetectCovid19CadWithOptionsAsync(DetectCovid19CadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectCovid19Cad",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectCovid19CadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectCovid19CadRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectCovid19CadResponse
        /// </returns>
        public DetectCovid19CadResponse DetectCovid19Cad(DetectCovid19CadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectCovid19CadWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DetectCovid19CadRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectCovid19CadResponse
        /// </returns>
        public async Task<DetectCovid19CadResponse> DetectCovid19CadAsync(DetectCovid19CadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectCovid19CadWithOptionsAsync(request, runtime);
        }

        public DetectCovid19CadResponse DetectCovid19CadAdvance(DetectCovid19CadAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectCovid19CadRequest detectCovid19CadReq = new DetectCovid19CadRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectCovid19CadReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectCovid19CadRequest.DetectCovid19CadRequestURLList tmp = detectCovid19CadReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectCovid19CadResponse detectCovid19CadResp = DetectCovid19CadWithOptions(detectCovid19CadReq, runtime);
            return detectCovid19CadResp;
        }

        public async Task<DetectCovid19CadResponse> DetectCovid19CadAdvanceAsync(DetectCovid19CadAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectCovid19CadRequest detectCovid19CadReq = new DetectCovid19CadRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectCovid19CadReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectCovid19CadRequest.DetectCovid19CadRequestURLList tmp = detectCovid19CadReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectCovid19CadResponse detectCovid19CadResp = await DetectCovid19CadWithOptionsAsync(detectCovid19CadReq, runtime);
            return detectCovid19CadResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脂肪肝检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLiverSteatosisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectLiverSteatosisResponse
        /// </returns>
        public DetectLiverSteatosisResponse DetectLiverSteatosisWithOptions(DetectLiverSteatosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectLiverSteatosis",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectLiverSteatosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脂肪肝检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLiverSteatosisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectLiverSteatosisResponse
        /// </returns>
        public async Task<DetectLiverSteatosisResponse> DetectLiverSteatosisWithOptionsAsync(DetectLiverSteatosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectLiverSteatosis",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectLiverSteatosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脂肪肝检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLiverSteatosisRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectLiverSteatosisResponse
        /// </returns>
        public DetectLiverSteatosisResponse DetectLiverSteatosis(DetectLiverSteatosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectLiverSteatosisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>脂肪肝检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLiverSteatosisRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectLiverSteatosisResponse
        /// </returns>
        public async Task<DetectLiverSteatosisResponse> DetectLiverSteatosisAsync(DetectLiverSteatosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectLiverSteatosisWithOptionsAsync(request, runtime);
        }

        public DetectLiverSteatosisResponse DetectLiverSteatosisAdvance(DetectLiverSteatosisAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectLiverSteatosisRequest detectLiverSteatosisReq = new DetectLiverSteatosisRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectLiverSteatosisReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectLiverSteatosisRequest.DetectLiverSteatosisRequestURLList tmp = detectLiverSteatosisReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectLiverSteatosisResponse detectLiverSteatosisResp = DetectLiverSteatosisWithOptions(detectLiverSteatosisReq, runtime);
            return detectLiverSteatosisResp;
        }

        public async Task<DetectLiverSteatosisResponse> DetectLiverSteatosisAdvanceAsync(DetectLiverSteatosisAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectLiverSteatosisRequest detectLiverSteatosisReq = new DetectLiverSteatosisRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectLiverSteatosisReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectLiverSteatosisRequest.DetectLiverSteatosisRequestURLList tmp = detectLiverSteatosisReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectLiverSteatosisResponse detectLiverSteatosisResp = await DetectLiverSteatosisWithOptionsAsync(detectLiverSteatosisReq, runtime);
            return detectLiverSteatosisResp;
        }

        /// <param name="request">
        /// DetectLungNoduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectLungNoduleResponse
        /// </returns>
        public DetectLungNoduleResponse DetectLungNoduleWithOptions(DetectLungNoduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectLungNodule",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectLungNoduleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectLungNoduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectLungNoduleResponse
        /// </returns>
        public async Task<DetectLungNoduleResponse> DetectLungNoduleWithOptionsAsync(DetectLungNoduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectLungNodule",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectLungNoduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectLungNoduleRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectLungNoduleResponse
        /// </returns>
        public DetectLungNoduleResponse DetectLungNodule(DetectLungNoduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectLungNoduleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DetectLungNoduleRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectLungNoduleResponse
        /// </returns>
        public async Task<DetectLungNoduleResponse> DetectLungNoduleAsync(DetectLungNoduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectLungNoduleWithOptionsAsync(request, runtime);
        }

        public DetectLungNoduleResponse DetectLungNoduleAdvance(DetectLungNoduleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectLungNoduleRequest detectLungNoduleReq = new DetectLungNoduleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectLungNoduleReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectLungNoduleRequest.DetectLungNoduleRequestURLList tmp = detectLungNoduleReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectLungNoduleResponse detectLungNoduleResp = DetectLungNoduleWithOptions(detectLungNoduleReq, runtime);
            return detectLungNoduleResp;
        }

        public async Task<DetectLungNoduleResponse> DetectLungNoduleAdvanceAsync(DetectLungNoduleAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectLungNoduleRequest detectLungNoduleReq = new DetectLungNoduleRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectLungNoduleReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectLungNoduleRequest.DetectLungNoduleRequestURLList tmp = detectLungNoduleReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectLungNoduleResponse detectLungNoduleResp = await DetectLungNoduleWithOptionsAsync(detectLungNoduleReq, runtime);
            return detectLungNoduleResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>淋巴结检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLymphRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectLymphResponse
        /// </returns>
        public DetectLymphResponse DetectLymphWithOptions(DetectLymphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectLymph",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectLymphResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>淋巴结检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLymphRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectLymphResponse
        /// </returns>
        public async Task<DetectLymphResponse> DetectLymphWithOptionsAsync(DetectLymphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectLymph",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectLymphResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>淋巴结检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLymphRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectLymphResponse
        /// </returns>
        public DetectLymphResponse DetectLymph(DetectLymphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectLymphWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>淋巴结检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectLymphRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectLymphResponse
        /// </returns>
        public async Task<DetectLymphResponse> DetectLymphAsync(DetectLymphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectLymphWithOptionsAsync(request, runtime);
        }

        public DetectLymphResponse DetectLymphAdvance(DetectLymphAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectLymphRequest detectLymphReq = new DetectLymphRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectLymphReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectLymphRequest.DetectLymphRequestURLList tmp = detectLymphReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectLymphResponse detectLymphResp = DetectLymphWithOptions(detectLymphReq, runtime);
            return detectLymphResp;
        }

        public async Task<DetectLymphResponse> DetectLymphAdvanceAsync(DetectLymphAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectLymphRequest detectLymphReq = new DetectLymphRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectLymphReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectLymphRequest.DetectLymphRequestURLList tmp = detectLymphReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectLymphResponse detectLymphResp = await DetectLymphWithOptionsAsync(detectLymphReq, runtime);
            return detectLymphResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胰腺癌检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectPancRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectPancResponse
        /// </returns>
        public DetectPancResponse DetectPancWithOptions(DetectPancRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectPanc",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectPancResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胰腺癌检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectPancRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectPancResponse
        /// </returns>
        public async Task<DetectPancResponse> DetectPancWithOptionsAsync(DetectPancRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectPanc",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectPancResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胰腺癌检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectPancRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectPancResponse
        /// </returns>
        public DetectPancResponse DetectPanc(DetectPancRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectPancWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胰腺癌检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectPancRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectPancResponse
        /// </returns>
        public async Task<DetectPancResponse> DetectPancAsync(DetectPancRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectPancWithOptionsAsync(request, runtime);
        }

        public DetectPancResponse DetectPancAdvance(DetectPancAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectPancRequest detectPancReq = new DetectPancRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectPancReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectPancRequest.DetectPancRequestURLList tmp = detectPancReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectPancResponse detectPancResp = DetectPancWithOptions(detectPancReq, runtime);
            return detectPancResp;
        }

        public async Task<DetectPancResponse> DetectPancAdvanceAsync(DetectPancAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectPancRequest detectPancReq = new DetectPancRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectPancReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectPancRequest.DetectPancRequestURLList tmp = detectPancReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectPancResponse detectPancResp = await DetectPancWithOptionsAsync(detectPancReq, runtime);
            return detectPancResp;
        }

        /// <param name="request">
        /// DetectRibFractureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectRibFractureResponse
        /// </returns>
        public DetectRibFractureResponse DetectRibFractureWithOptions(DetectRibFractureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectRibFracture",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectRibFractureResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectRibFractureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectRibFractureResponse
        /// </returns>
        public async Task<DetectRibFractureResponse> DetectRibFractureWithOptionsAsync(DetectRibFractureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectRibFracture",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectRibFractureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectRibFractureRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectRibFractureResponse
        /// </returns>
        public DetectRibFractureResponse DetectRibFracture(DetectRibFractureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectRibFractureWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DetectRibFractureRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectRibFractureResponse
        /// </returns>
        public async Task<DetectRibFractureResponse> DetectRibFractureAsync(DetectRibFractureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectRibFractureWithOptionsAsync(request, runtime);
        }

        public DetectRibFractureResponse DetectRibFractureAdvance(DetectRibFractureAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectRibFractureRequest detectRibFractureReq = new DetectRibFractureRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectRibFractureReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectRibFractureRequest.DetectRibFractureRequestURLList tmp = detectRibFractureReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectRibFractureResponse detectRibFractureResp = DetectRibFractureWithOptions(detectRibFractureReq, runtime);
            return detectRibFractureResp;
        }

        public async Task<DetectRibFractureResponse> DetectRibFractureAdvanceAsync(DetectRibFractureAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectRibFractureRequest detectRibFractureReq = new DetectRibFractureRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectRibFractureReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        DetectRibFractureRequest.DetectRibFractureRequestURLList tmp = detectRibFractureReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            DetectRibFractureResponse detectRibFractureResp = await DetectRibFractureWithOptionsAsync(detectRibFractureReq, runtime);
            return detectRibFractureResp;
        }

        /// <param name="request">
        /// DetectSkinDiseaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectSkinDiseaseResponse
        /// </returns>
        public DetectSkinDiseaseResponse DetectSkinDiseaseWithOptions(DetectSkinDiseaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
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
                Action = "DetectSkinDisease",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectSkinDiseaseResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectSkinDiseaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectSkinDiseaseResponse
        /// </returns>
        public async Task<DetectSkinDiseaseResponse> DetectSkinDiseaseWithOptionsAsync(DetectSkinDiseaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
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
                Action = "DetectSkinDisease",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectSkinDiseaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DetectSkinDiseaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectSkinDiseaseResponse
        /// </returns>
        public DetectSkinDiseaseResponse DetectSkinDisease(DetectSkinDiseaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectSkinDiseaseWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DetectSkinDiseaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectSkinDiseaseResponse
        /// </returns>
        public async Task<DetectSkinDiseaseResponse> DetectSkinDiseaseAsync(DetectSkinDiseaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectSkinDiseaseWithOptionsAsync(request, runtime);
        }

        public DetectSkinDiseaseResponse DetectSkinDiseaseAdvance(DetectSkinDiseaseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectSkinDiseaseRequest detectSkinDiseaseReq = new DetectSkinDiseaseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectSkinDiseaseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
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
                detectSkinDiseaseReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            DetectSkinDiseaseResponse detectSkinDiseaseResp = DetectSkinDiseaseWithOptions(detectSkinDiseaseReq, runtime);
            return detectSkinDiseaseResp;
        }

        public async Task<DetectSkinDiseaseResponse> DetectSkinDiseaseAdvanceAsync(DetectSkinDiseaseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            DetectSkinDiseaseRequest detectSkinDiseaseReq = new DetectSkinDiseaseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectSkinDiseaseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.UrlObject,
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
                detectSkinDiseaseReq.Url = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            DetectSkinDiseaseResponse detectSkinDiseaseResp = await DetectSkinDiseaseWithOptionsAsync(detectSkinDiseaseReq, runtime);
            return detectSkinDiseaseResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FeedbackSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FeedbackSessionResponse
        /// </returns>
        public FeedbackSessionResponse FeedbackSessionWithOptions(FeedbackSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["Feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FeedbackSession",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FeedbackSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FeedbackSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FeedbackSessionResponse
        /// </returns>
        public async Task<FeedbackSessionResponse> FeedbackSessionWithOptionsAsync(FeedbackSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["Feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FeedbackSession",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FeedbackSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FeedbackSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// FeedbackSessionResponse
        /// </returns>
        public FeedbackSessionResponse FeedbackSession(FeedbackSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FeedbackSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FeedbackSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// FeedbackSessionResponse
        /// </returns>
        public async Task<FeedbackSessionResponse> FeedbackSessionAsync(FeedbackSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FeedbackSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫筛查结果报告生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateReportResponse
        /// </returns>
        public GenerateReportResponse GenerateReportWithOptions(GenerateReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateReportShrinkRequest request = new GenerateReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReportConfigs))
            {
                request.ReportConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReportConfigs, "ReportConfigs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportConfigsShrink))
            {
                body["ReportConfigs"] = request.ReportConfigsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateReport",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫筛查结果报告生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateReportResponse
        /// </returns>
        public async Task<GenerateReportResponse> GenerateReportWithOptionsAsync(GenerateReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateReportShrinkRequest request = new GenerateReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReportConfigs))
            {
                request.ReportConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReportConfigs, "ReportConfigs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportConfigsShrink))
            {
                body["ReportConfigs"] = request.ReportConfigsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateReport",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫筛查结果报告生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateReportResponse
        /// </returns>
        public GenerateReportResponse GenerateReport(GenerateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫筛查结果报告生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateReportResponse
        /// </returns>
        public async Task<GenerateReportResponse> GenerateReportAsync(GenerateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateReportWithOptionsAsync(request, runtime);
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
                Version = "2020-03-20",
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
                Version = "2020-03-20",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CVD心血管不良事件预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PredictCVDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PredictCVDResponse
        /// </returns>
        public PredictCVDResponse PredictCVDWithOptions(PredictCVDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PredictCVD",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PredictCVDResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CVD心血管不良事件预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PredictCVDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PredictCVDResponse
        /// </returns>
        public async Task<PredictCVDResponse> PredictCVDWithOptionsAsync(PredictCVDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PredictCVD",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PredictCVDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CVD心血管不良事件预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PredictCVDRequest
        /// </param>
        /// 
        /// <returns>
        /// PredictCVDResponse
        /// </returns>
        public PredictCVDResponse PredictCVD(PredictCVDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictCVDWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CVD心血管不良事件预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PredictCVDRequest
        /// </param>
        /// 
        /// <returns>
        /// PredictCVDResponse
        /// </returns>
        public async Task<PredictCVDResponse> PredictCVDAsync(PredictCVDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictCVDWithOptionsAsync(request, runtime);
        }

        public PredictCVDResponse PredictCVDAdvance(PredictCVDAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            PredictCVDRequest predictCVDReq = new PredictCVDRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, predictCVDReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        PredictCVDRequest.PredictCVDRequestURLList tmp = predictCVDReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            PredictCVDResponse predictCVDResp = PredictCVDWithOptions(predictCVDReq, runtime);
            return predictCVDResp;
        }

        public async Task<PredictCVDResponse> PredictCVDAdvanceAsync(PredictCVDAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            PredictCVDRequest predictCVDReq = new PredictCVDRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, predictCVDReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        PredictCVDRequest.PredictCVDRequestURLList tmp = predictCVDReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            PredictCVDResponse predictCVDResp = await PredictCVDWithOptionsAsync(predictCVDReq, runtime);
            return predictCVDResp;
        }

        /// <param name="request">
        /// RunCTRegistrationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCTRegistrationResponse
        /// </returns>
        public RunCTRegistrationResponse RunCTRegistrationWithOptions(RunCTRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FloatingList))
            {
                body["FloatingList"] = request.FloatingList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceList))
            {
                body["ReferenceList"] = request.ReferenceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCTRegistration",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCTRegistrationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RunCTRegistrationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCTRegistrationResponse
        /// </returns>
        public async Task<RunCTRegistrationResponse> RunCTRegistrationWithOptionsAsync(RunCTRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FloatingList))
            {
                body["FloatingList"] = request.FloatingList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceList))
            {
                body["ReferenceList"] = request.ReferenceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCTRegistration",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCTRegistrationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RunCTRegistrationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCTRegistrationResponse
        /// </returns>
        public RunCTRegistrationResponse RunCTRegistration(RunCTRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCTRegistrationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RunCTRegistrationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCTRegistrationResponse
        /// </returns>
        public async Task<RunCTRegistrationResponse> RunCTRegistrationAsync(RunCTRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCTRegistrationWithOptionsAsync(request, runtime);
        }

        public RunCTRegistrationResponse RunCTRegistrationAdvance(RunCTRegistrationAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            RunCTRegistrationRequest runCTRegistrationReq = new RunCTRegistrationRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, runCTRegistrationReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FloatingList))
            {
                int? i0 = 0;

                foreach (var item0 in request.FloatingList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.FloatingURLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.FloatingURLObject,
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
                        RunCTRegistrationRequest.RunCTRegistrationRequestFloatingList tmp = runCTRegistrationReq.FloatingList[i0.Value];
                        tmp.FloatingURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceList))
            {
                int? i1 = 0;

                foreach (var item0 in request.ReferenceList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.ReferenceURLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.ReferenceURLObject,
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
                        RunCTRegistrationRequest.RunCTRegistrationRequestReferenceList tmp = runCTRegistrationReq.ReferenceList[i1.Value];
                        tmp.ReferenceURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i1 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i1), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            RunCTRegistrationResponse runCTRegistrationResp = RunCTRegistrationWithOptions(runCTRegistrationReq, runtime);
            return runCTRegistrationResp;
        }

        public async Task<RunCTRegistrationResponse> RunCTRegistrationAdvanceAsync(RunCTRegistrationAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            RunCTRegistrationRequest runCTRegistrationReq = new RunCTRegistrationRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, runCTRegistrationReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FloatingList))
            {
                int? i0 = 0;

                foreach (var item0 in request.FloatingList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.FloatingURLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.FloatingURLObject,
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
                        RunCTRegistrationRequest.RunCTRegistrationRequestFloatingList tmp = runCTRegistrationReq.FloatingList[i0.Value];
                        tmp.FloatingURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceList))
            {
                int? i1 = 0;

                foreach (var item0 in request.ReferenceList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.ReferenceURLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.ReferenceURLObject,
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
                        RunCTRegistrationRequest.RunCTRegistrationRequestReferenceList tmp = runCTRegistrationReq.ReferenceList[i1.Value];
                        tmp.ReferenceURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i1 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i1), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            RunCTRegistrationResponse runCTRegistrationResp = await RunCTRegistrationWithOptionsAsync(runCTRegistrationReq, runtime);
            return runCTRegistrationResp;
        }

        /// <param name="request">
        /// RunMedQARequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMedQAResponse
        /// </returns>
        public RunMedQAResponse RunMedQAWithOptions(RunMedQARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerImageDataList))
            {
                body["AnswerImageDataList"] = request.AnswerImageDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerImageURLList))
            {
                body["AnswerImageURLList"] = request.AnswerImageURLList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerTextList))
            {
                body["AnswerTextList"] = request.AnswerTextList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                body["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionType))
            {
                body["QuestionType"] = request.QuestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMedQA",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMedQAResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RunMedQARequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMedQAResponse
        /// </returns>
        public async Task<RunMedQAResponse> RunMedQAWithOptionsAsync(RunMedQARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerImageDataList))
            {
                body["AnswerImageDataList"] = request.AnswerImageDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerImageURLList))
            {
                body["AnswerImageURLList"] = request.AnswerImageURLList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerTextList))
            {
                body["AnswerTextList"] = request.AnswerTextList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                body["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionType))
            {
                body["QuestionType"] = request.QuestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMedQA",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMedQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RunMedQARequest
        /// </param>
        /// 
        /// <returns>
        /// RunMedQAResponse
        /// </returns>
        public RunMedQAResponse RunMedQA(RunMedQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunMedQAWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RunMedQARequest
        /// </param>
        /// 
        /// <returns>
        /// RunMedQAResponse
        /// </returns>
        public async Task<RunMedQAResponse> RunMedQAAsync(RunMedQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunMedQAWithOptionsAsync(request, runtime);
        }

        public RunMedQAResponse RunMedQAAdvance(RunMedQAAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            RunMedQARequest runMedQAReq = new RunMedQARequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, runMedQAReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerImageURLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.AnswerImageURLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.AnswerImageURLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.AnswerImageURLObject,
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
                        RunMedQARequest.RunMedQARequestAnswerImageURLList tmp = runMedQAReq.AnswerImageURLList[i0.Value];
                        tmp.AnswerImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            RunMedQAResponse runMedQAResp = RunMedQAWithOptions(runMedQAReq, runtime);
            return runMedQAResp;
        }

        public async Task<RunMedQAResponse> RunMedQAAdvanceAsync(RunMedQAAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            RunMedQARequest runMedQAReq = new RunMedQARequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, runMedQAReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerImageURLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.AnswerImageURLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.AnswerImageURLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.AnswerImageURLObject,
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
                        RunMedQARequest.RunMedQARequestAnswerImageURLList tmp = runMedQAReq.AnswerImageURLList[i0.Value];
                        tmp.AnswerImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            RunMedQAResponse runMedQAResp = await RunMedQAWithOptionsAsync(runMedQAReq, runtime);
            return runMedQAResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结直肠癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenCRCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenCRCResponse
        /// </returns>
        public ScreenCRCResponse ScreenCRCWithOptions(ScreenCRCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenCRC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenCRCResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结直肠癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenCRCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenCRCResponse
        /// </returns>
        public async Task<ScreenCRCResponse> ScreenCRCWithOptionsAsync(ScreenCRCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenCRC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenCRCResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结直肠癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenCRCRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenCRCResponse
        /// </returns>
        public ScreenCRCResponse ScreenCRC(ScreenCRCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScreenCRCWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>结直肠癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenCRCRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenCRCResponse
        /// </returns>
        public async Task<ScreenCRCResponse> ScreenCRCAsync(ScreenCRCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScreenCRCWithOptionsAsync(request, runtime);
        }

        public ScreenCRCResponse ScreenCRCAdvance(ScreenCRCAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenCRCRequest screenCRCReq = new ScreenCRCRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenCRCReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenCRCRequest.ScreenCRCRequestURLList tmp = screenCRCReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenCRCResponse screenCRCResp = ScreenCRCWithOptions(screenCRCReq, runtime);
            return screenCRCResp;
        }

        public async Task<ScreenCRCResponse> ScreenCRCAdvanceAsync(ScreenCRCAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenCRCRequest screenCRCReq = new ScreenCRCRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenCRCReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenCRCRequest.ScreenCRCRequestURLList tmp = screenCRCReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenCRCResponse screenCRCResp = await ScreenCRCWithOptionsAsync(screenCRCReq, runtime);
            return screenCRCResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenChestCTRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenChestCTResponse
        /// </returns>
        public ScreenChestCTResponse ScreenChestCTWithOptions(ScreenChestCTRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                body["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                body["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenChestCT",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenChestCTResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenChestCTRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenChestCTResponse
        /// </returns>
        public async Task<ScreenChestCTResponse> ScreenChestCTWithOptionsAsync(ScreenChestCTRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                body["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                body["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenChestCT",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenChestCTResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenChestCTRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenChestCTResponse
        /// </returns>
        public ScreenChestCTResponse ScreenChestCT(ScreenChestCTRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScreenChestCTWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胸部CT平扫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenChestCTRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenChestCTResponse
        /// </returns>
        public async Task<ScreenChestCTResponse> ScreenChestCTAsync(ScreenChestCTRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScreenChestCTWithOptionsAsync(request, runtime);
        }

        public ScreenChestCTResponse ScreenChestCTAdvance(ScreenChestCTAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenChestCTRequest screenChestCTReq = new ScreenChestCTRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenChestCTReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenChestCTRequest.ScreenChestCTRequestURLList tmp = screenChestCTReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenChestCTResponse screenChestCTResp = ScreenChestCTWithOptions(screenChestCTReq, runtime);
            return screenChestCTResp;
        }

        public async Task<ScreenChestCTResponse> ScreenChestCTAdvanceAsync(ScreenChestCTAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenChestCTRequest screenChestCTReq = new ScreenChestCTRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenChestCTReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenChestCTRequest.ScreenChestCTRequestURLList tmp = screenChestCTReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenChestCTResponse screenChestCTResp = await ScreenChestCTWithOptionsAsync(screenChestCTReq, runtime);
            return screenChestCTResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食管癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenECRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenECResponse
        /// </returns>
        public ScreenECResponse ScreenECWithOptions(ScreenECRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenEC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenECResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食管癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenECRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenECResponse
        /// </returns>
        public async Task<ScreenECResponse> ScreenECWithOptionsAsync(ScreenECRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenEC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenECResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食管癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenECRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenECResponse
        /// </returns>
        public ScreenECResponse ScreenEC(ScreenECRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScreenECWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>食管癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenECRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenECResponse
        /// </returns>
        public async Task<ScreenECResponse> ScreenECAsync(ScreenECRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScreenECWithOptionsAsync(request, runtime);
        }

        public ScreenECResponse ScreenECAdvance(ScreenECAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenECRequest screenECReq = new ScreenECRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenECReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenECRequest.ScreenECRequestURLList tmp = screenECReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenECResponse screenECResp = ScreenECWithOptions(screenECReq, runtime);
            return screenECResp;
        }

        public async Task<ScreenECResponse> ScreenECAdvanceAsync(ScreenECAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenECRequest screenECReq = new ScreenECRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenECReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenECRequest.ScreenECRequestURLList tmp = screenECReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenECResponse screenECResp = await ScreenECWithOptionsAsync(screenECReq, runtime);
            return screenECResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胃癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenGCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenGCResponse
        /// </returns>
        public ScreenGCResponse ScreenGCWithOptions(ScreenGCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenGC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenGCResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胃癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenGCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenGCResponse
        /// </returns>
        public async Task<ScreenGCResponse> ScreenGCWithOptionsAsync(ScreenGCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenGC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenGCResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胃癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenGCRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenGCResponse
        /// </returns>
        public ScreenGCResponse ScreenGC(ScreenGCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScreenGCWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>胃癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenGCRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenGCResponse
        /// </returns>
        public async Task<ScreenGCResponse> ScreenGCAsync(ScreenGCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScreenGCWithOptionsAsync(request, runtime);
        }

        public ScreenGCResponse ScreenGCAdvance(ScreenGCAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenGCRequest screenGCReq = new ScreenGCRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenGCReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenGCRequest.ScreenGCRequestURLList tmp = screenGCReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenGCResponse screenGCResp = ScreenGCWithOptions(screenGCReq, runtime);
            return screenGCResp;
        }

        public async Task<ScreenGCResponse> ScreenGCAdvanceAsync(ScreenGCAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenGCRequest screenGCReq = new ScreenGCRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenGCReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenGCRequest.ScreenGCRequestURLList tmp = screenGCReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenGCResponse screenGCResp = await ScreenGCWithOptionsAsync(screenGCReq, runtime);
            return screenGCResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>肝癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenLCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenLCResponse
        /// </returns>
        public ScreenLCResponse ScreenLCWithOptions(ScreenLCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenLC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenLCResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>肝癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenLCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScreenLCResponse
        /// </returns>
        public async Task<ScreenLCResponse> ScreenLCWithOptionsAsync(ScreenLCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScreenLC",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScreenLCResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>肝癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenLCRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenLCResponse
        /// </returns>
        public ScreenLCResponse ScreenLC(ScreenLCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScreenLCWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>肝癌筛查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ScreenLCRequest
        /// </param>
        /// 
        /// <returns>
        /// ScreenLCResponse
        /// </returns>
        public async Task<ScreenLCResponse> ScreenLCAsync(ScreenLCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScreenLCWithOptionsAsync(request, runtime);
        }

        public ScreenLCResponse ScreenLCAdvance(ScreenLCAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenLCRequest screenLCReq = new ScreenLCRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenLCReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenLCRequest.ScreenLCRequestURLList tmp = screenLCReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenLCResponse screenLCResp = ScreenLCWithOptions(screenLCReq, runtime);
            return screenLCResp;
        }

        public async Task<ScreenLCResponse> ScreenLCAdvanceAsync(ScreenLCAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ScreenLCRequest screenLCReq = new ScreenLCRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, screenLCReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        ScreenLCRequest.ScreenLCRequestURLList tmp = screenLCReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            ScreenLCResponse screenLCResp = await ScreenLCWithOptionsAsync(screenLCReq, runtime);
            return screenLCResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗淋巴站分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentLymphNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SegmentLymphNodeResponse
        /// </returns>
        public SegmentLymphNodeResponse SegmentLymphNodeWithOptions(SegmentLymphNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyPart))
            {
                body["BodyPart"] = request.BodyPart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SegmentLymphNode",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SegmentLymphNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗淋巴站分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentLymphNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SegmentLymphNodeResponse
        /// </returns>
        public async Task<SegmentLymphNodeResponse> SegmentLymphNodeWithOptionsAsync(SegmentLymphNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyPart))
            {
                body["BodyPart"] = request.BodyPart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SegmentLymphNode",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SegmentLymphNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗淋巴站分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentLymphNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SegmentLymphNodeResponse
        /// </returns>
        public SegmentLymphNodeResponse SegmentLymphNode(SegmentLymphNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentLymphNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗淋巴站分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentLymphNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SegmentLymphNodeResponse
        /// </returns>
        public async Task<SegmentLymphNodeResponse> SegmentLymphNodeAsync(SegmentLymphNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentLymphNodeWithOptionsAsync(request, runtime);
        }

        public SegmentLymphNodeResponse SegmentLymphNodeAdvance(SegmentLymphNodeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SegmentLymphNodeRequest segmentLymphNodeReq = new SegmentLymphNodeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, segmentLymphNodeReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        SegmentLymphNodeRequest.SegmentLymphNodeRequestURLList tmp = segmentLymphNodeReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            SegmentLymphNodeResponse segmentLymphNodeResp = SegmentLymphNodeWithOptions(segmentLymphNodeReq, runtime);
            return segmentLymphNodeResp;
        }

        public async Task<SegmentLymphNodeResponse> SegmentLymphNodeAdvanceAsync(SegmentLymphNodeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SegmentLymphNodeRequest segmentLymphNodeReq = new SegmentLymphNodeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, segmentLymphNodeReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        SegmentLymphNodeRequest.SegmentLymphNodeRequestURLList tmp = segmentLymphNodeReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            SegmentLymphNodeResponse segmentLymphNodeResp = await SegmentLymphNodeWithOptionsAsync(segmentLymphNodeReq, runtime);
            return segmentLymphNodeResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多器官分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentOARRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SegmentOARResponse
        /// </returns>
        public SegmentOARResponse SegmentOARWithOptions(SegmentOARRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyPart))
            {
                body["BodyPart"] = request.BodyPart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contrast))
            {
                body["Contrast"] = request.Contrast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskList))
            {
                body["MaskList"] = request.MaskList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SegmentOAR",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SegmentOARResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多器官分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentOARRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SegmentOARResponse
        /// </returns>
        public async Task<SegmentOARResponse> SegmentOARWithOptionsAsync(SegmentOARRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyPart))
            {
                body["BodyPart"] = request.BodyPart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contrast))
            {
                body["Contrast"] = request.Contrast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskList))
            {
                body["MaskList"] = request.MaskList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SegmentOAR",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SegmentOARResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多器官分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentOARRequest
        /// </param>
        /// 
        /// <returns>
        /// SegmentOARResponse
        /// </returns>
        public SegmentOARResponse SegmentOAR(SegmentOARRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SegmentOARWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多器官分割</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SegmentOARRequest
        /// </param>
        /// 
        /// <returns>
        /// SegmentOARResponse
        /// </returns>
        public async Task<SegmentOARResponse> SegmentOARAsync(SegmentOARRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SegmentOARWithOptionsAsync(request, runtime);
        }

        public SegmentOARResponse SegmentOARAdvance(SegmentOARAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SegmentOARRequest segmentOARReq = new SegmentOARRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, segmentOARReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        SegmentOARRequest.SegmentOARRequestURLList tmp = segmentOARReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            SegmentOARResponse segmentOARResp = SegmentOARWithOptions(segmentOARReq, runtime);
            return segmentOARResp;
        }

        public async Task<SegmentOARResponse> SegmentOARAdvanceAsync(SegmentOARAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SegmentOARRequest segmentOARReq = new SegmentOARRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, segmentOARReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        SegmentOARRequest.SegmentOARRequestURLList tmp = segmentOARReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            SegmentOARResponse segmentOARResp = await SegmentOARWithOptionsAsync(segmentOARReq, runtime);
            return segmentOARResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗靶区勾画算法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TargetVolumeSegmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TargetVolumeSegmentResponse
        /// </returns>
        public TargetVolumeSegmentResponse TargetVolumeSegmentWithOptions(TargetVolumeSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancerType))
            {
                body["CancerType"] = request.CancerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVolumeType))
            {
                body["TargetVolumeType"] = request.TargetVolumeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TargetVolumeSegment",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TargetVolumeSegmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗靶区勾画算法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TargetVolumeSegmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TargetVolumeSegmentResponse
        /// </returns>
        public async Task<TargetVolumeSegmentResponse> TargetVolumeSegmentWithOptionsAsync(TargetVolumeSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancerType))
            {
                body["CancerType"] = request.CancerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFormat))
            {
                body["DataFormat"] = request.DataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVolumeType))
            {
                body["TargetVolumeType"] = request.TargetVolumeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                body["URLList"] = request.URLList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TargetVolumeSegment",
                Version = "2020-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TargetVolumeSegmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗靶区勾画算法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TargetVolumeSegmentRequest
        /// </param>
        /// 
        /// <returns>
        /// TargetVolumeSegmentResponse
        /// </returns>
        public TargetVolumeSegmentResponse TargetVolumeSegment(TargetVolumeSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TargetVolumeSegmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>放疗靶区勾画算法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TargetVolumeSegmentRequest
        /// </param>
        /// 
        /// <returns>
        /// TargetVolumeSegmentResponse
        /// </returns>
        public async Task<TargetVolumeSegmentResponse> TargetVolumeSegmentAsync(TargetVolumeSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TargetVolumeSegmentWithOptionsAsync(request, runtime);
        }

        public TargetVolumeSegmentResponse TargetVolumeSegmentAdvance(TargetVolumeSegmentAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            TargetVolumeSegmentRequest targetVolumeSegmentReq = new TargetVolumeSegmentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, targetVolumeSegmentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        TargetVolumeSegmentRequest.TargetVolumeSegmentRequestURLList tmp = targetVolumeSegmentReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            TargetVolumeSegmentResponse targetVolumeSegmentResp = TargetVolumeSegmentWithOptions(targetVolumeSegmentReq, runtime);
            return targetVolumeSegmentResp;
        }

        public async Task<TargetVolumeSegmentResponse> TargetVolumeSegmentAdvanceAsync(TargetVolumeSegmentAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
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
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imageprocess",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            TargetVolumeSegmentRequest targetVolumeSegmentReq = new TargetVolumeSegmentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, targetVolumeSegmentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URLList))
            {
                int? i0 = 0;

                foreach (var item0 in request.URLList) {
                    if (!AlibabaCloud.TeaUtil.Common.IsUnset(item0.URLObject))
                    {
                        authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                        ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                        ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                        ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                        fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                        {
                            Filename = authResponse.Body.ObjectKey,
                            Content = item0.URLObject,
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
                        TargetVolumeSegmentRequest.TargetVolumeSegmentRequestURLList tmp = targetVolumeSegmentReq.URLList[i0.Value];
                        tmp.URL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
                        i0 = AlibabaCloud.DarabonbaNumber.NumberUtil.Ltoi(AlibabaCloud.DarabonbaNumber.NumberUtil.Add(AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(i0), AlibabaCloud.DarabonbaNumber.NumberUtil.Itol(1)));
                    }
                }
            }
            TargetVolumeSegmentResponse targetVolumeSegmentResp = await TargetVolumeSegmentWithOptionsAsync(targetVolumeSegmentReq, runtime);
            return targetVolumeSegmentResp;
        }

    }
}
