// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth20190307.Models;

namespace AlibabaCloud.SDK.Cloudauth20190307
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add AIGC Face Detection Capability</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AIGCFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AIGCFaceVerifyResponse
        /// </returns>
        public AIGCFaceVerifyResponse AIGCFaceVerifyWithOptions(AIGCFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                query["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                query["OssObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AIGCFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AIGCFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add AIGC Face Detection Capability</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AIGCFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AIGCFaceVerifyResponse
        /// </returns>
        public async Task<AIGCFaceVerifyResponse> AIGCFaceVerifyWithOptionsAsync(AIGCFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                query["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                query["OssObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AIGCFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AIGCFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add AIGC Face Detection Capability</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AIGCFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// AIGCFaceVerifyResponse
        /// </returns>
        public AIGCFaceVerifyResponse AIGCFaceVerify(AIGCFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AIGCFaceVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add AIGC Face Detection Capability</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AIGCFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// AIGCFaceVerifyResponse
        /// </returns>
        public async Task<AIGCFaceVerifyResponse> AIGCFaceVerifyAsync(AIGCFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AIGCFaceVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Bank card verification, including: two elements (name + bank card number), three elements (name + ID number + bank card number), and four elements (name + ID number + mobile phone number + bank card number) consistency verification.</para>
        /// <list type="bullet">
        /// <item><description>Service address:<list type="bullet">
        /// <item><description>Beijing region: cloudauth.cn-beijing.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-beijing.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Shanghai region: cloudauth.cn-shanghai.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-shanghai.aliyuncs.com (IPv6).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyResponse
        /// </returns>
        public BankMetaVerifyResponse BankMetaVerifyWithOptions(BankMetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCard))
            {
                query["BankCard"] = request.BankCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMode))
            {
                query["VerifyMode"] = request.VerifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BankMetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BankMetaVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Bank card verification, including: two elements (name + bank card number), three elements (name + ID number + bank card number), and four elements (name + ID number + mobile phone number + bank card number) consistency verification.</para>
        /// <list type="bullet">
        /// <item><description>Service address:<list type="bullet">
        /// <item><description>Beijing region: cloudauth.cn-beijing.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-beijing.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Shanghai region: cloudauth.cn-shanghai.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-shanghai.aliyuncs.com (IPv6).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyResponse
        /// </returns>
        public async Task<BankMetaVerifyResponse> BankMetaVerifyWithOptionsAsync(BankMetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCard))
            {
                query["BankCard"] = request.BankCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMode))
            {
                query["VerifyMode"] = request.VerifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BankMetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BankMetaVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Bank card verification, including: two elements (name + bank card number), three elements (name + ID number + bank card number), and four elements (name + ID number + mobile phone number + bank card number) consistency verification.</para>
        /// <list type="bullet">
        /// <item><description>Service address:<list type="bullet">
        /// <item><description>Beijing region: cloudauth.cn-beijing.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-beijing.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Shanghai region: cloudauth.cn-shanghai.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-shanghai.aliyuncs.com (IPv6).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyResponse
        /// </returns>
        public BankMetaVerifyResponse BankMetaVerify(BankMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BankMetaVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Bank card verification, including: two elements (name + bank card number), three elements (name + ID number + bank card number), and four elements (name + ID number + mobile phone number + bank card number) consistency verification.</para>
        /// <list type="bullet">
        /// <item><description>Service address:<list type="bullet">
        /// <item><description>Beijing region: cloudauth.cn-beijing.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-beijing.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Shanghai region: cloudauth.cn-shanghai.aliyuncs.com (IPv4) or cloudauth-dualstack.cn-shanghai.aliyuncs.com (IPv6).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyResponse
        /// </returns>
        public async Task<BankMetaVerifyResponse> BankMetaVerifyAsync(BankMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BankMetaVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-grade Pure Server-Side API for Face Comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>API Name: CompareFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>API Description: An interface to achieve real-person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Photo Format Requirements</h4>
        /// <para>When performing face comparison, please upload 2 facial photos that meet all the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo/recent database photo, with a complete, clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overly dark, overly bright, or halo effects on the face, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended to scale the shorter side to 720 pixels, with a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompareFaceVerifyResponse
        /// </returns>
        public CompareFaceVerifyResponse CompareFaceVerifyWithOptions(CompareFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCertifyId))
            {
                body["SourceCertifyId"] = request.SourceCertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFaceContrastPicture))
            {
                body["SourceFaceContrastPicture"] = request.SourceFaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFaceContrastPictureUrl))
            {
                body["SourceFaceContrastPictureUrl"] = request.SourceFaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOssBucketName))
            {
                body["SourceOssBucketName"] = request.SourceOssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOssObjectName))
            {
                body["SourceOssObjectName"] = request.SourceOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCertifyId))
            {
                body["TargetCertifyId"] = request.TargetCertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFaceContrastPicture))
            {
                body["TargetFaceContrastPicture"] = request.TargetFaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFaceContrastPictureUrl))
            {
                body["TargetFaceContrastPictureUrl"] = request.TargetFaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssBucketName))
            {
                body["TargetOssBucketName"] = request.TargetOssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssObjectName))
            {
                body["TargetOssObjectName"] = request.TargetOssObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompareFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-grade Pure Server-Side API for Face Comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>API Name: CompareFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>API Description: An interface to achieve real-person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Photo Format Requirements</h4>
        /// <para>When performing face comparison, please upload 2 facial photos that meet all the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo/recent database photo, with a complete, clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overly dark, overly bright, or halo effects on the face, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended to scale the shorter side to 720 pixels, with a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompareFaceVerifyResponse
        /// </returns>
        public async Task<CompareFaceVerifyResponse> CompareFaceVerifyWithOptionsAsync(CompareFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                body["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCertifyId))
            {
                body["SourceCertifyId"] = request.SourceCertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFaceContrastPicture))
            {
                body["SourceFaceContrastPicture"] = request.SourceFaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFaceContrastPictureUrl))
            {
                body["SourceFaceContrastPictureUrl"] = request.SourceFaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOssBucketName))
            {
                body["SourceOssBucketName"] = request.SourceOssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOssObjectName))
            {
                body["SourceOssObjectName"] = request.SourceOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCertifyId))
            {
                body["TargetCertifyId"] = request.TargetCertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFaceContrastPicture))
            {
                body["TargetFaceContrastPicture"] = request.TargetFaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFaceContrastPictureUrl))
            {
                body["TargetFaceContrastPictureUrl"] = request.TargetFaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssBucketName))
            {
                body["TargetOssBucketName"] = request.TargetOssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssObjectName))
            {
                body["TargetOssObjectName"] = request.TargetOssObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompareFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-grade Pure Server-Side API for Face Comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>API Name: CompareFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>API Description: An interface to achieve real-person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Photo Format Requirements</h4>
        /// <para>When performing face comparison, please upload 2 facial photos that meet all the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo/recent database photo, with a complete, clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overly dark, overly bright, or halo effects on the face, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended to scale the shorter side to 720 pixels, with a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CompareFaceVerifyResponse
        /// </returns>
        public CompareFaceVerifyResponse CompareFaceVerify(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFaceVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-grade Pure Server-Side API for Face Comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>API Name: CompareFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>API Description: An interface to achieve real-person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Photo Format Requirements</h4>
        /// <para>When performing face comparison, please upload 2 facial photos that meet all the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo/recent database photo, with a complete, clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overly dark, overly bright, or halo effects on the face, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended to scale the shorter side to 720 pixels, with a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CompareFaceVerifyResponse
        /// </returns>
        public async Task<CompareFaceVerifyResponse> CompareFaceVerifyAsync(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFaceVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invoke CompareFaces for face comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Compares two face images and outputs the similarity score of the faces in the two images as the result.</para>
        /// <list type="bullet">
        /// <item><description>At least one of the specified comparison images should be a face photo (FacePic).</description></item>
        /// <item><description>If an image contains multiple faces, the algorithm will automatically select the largest face in the image.</description></item>
        /// <item><description>If one of the two comparison images does not detect a face, the system will return an error message stating \&quot;No face detected\&quot;.
        /// When uploading images, you need to provide the HTTP address or base64 encoding of the image.</description></item>
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded in base64, formatted as <c>base64://&lt;base64 string of the image&gt;</c>.
        /// Image Restrictions</description></item>
        /// <item><description>Does not support relative or absolute paths for local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2MB to avoid timeout during retrieval by the algorithm.</description></item>
        /// <item><description>The body of a single request has a size limit of 8MB; please calculate the total size of all images and other information in the request to ensure it does not exceed this limit.</description></item>
        /// <item><description>When using base64 to transmit images, the request method must be changed to POST; the header description such as <c>data:image/png;base64,</c> should be removed from the base64 string of the image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompareFacesResponse
        /// </returns>
        public CompareFacesResponse CompareFacesWithOptions(CompareFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceImageType))
            {
                body["SourceImageType"] = request.SourceImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceImageValue))
            {
                body["SourceImageValue"] = request.SourceImageValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageType))
            {
                body["TargetImageType"] = request.TargetImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageValue))
            {
                body["TargetImageValue"] = request.TargetImageValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareFaces",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompareFacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invoke CompareFaces for face comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Compares two face images and outputs the similarity score of the faces in the two images as the result.</para>
        /// <list type="bullet">
        /// <item><description>At least one of the specified comparison images should be a face photo (FacePic).</description></item>
        /// <item><description>If an image contains multiple faces, the algorithm will automatically select the largest face in the image.</description></item>
        /// <item><description>If one of the two comparison images does not detect a face, the system will return an error message stating \&quot;No face detected\&quot;.
        /// When uploading images, you need to provide the HTTP address or base64 encoding of the image.</description></item>
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded in base64, formatted as <c>base64://&lt;base64 string of the image&gt;</c>.
        /// Image Restrictions</description></item>
        /// <item><description>Does not support relative or absolute paths for local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2MB to avoid timeout during retrieval by the algorithm.</description></item>
        /// <item><description>The body of a single request has a size limit of 8MB; please calculate the total size of all images and other information in the request to ensure it does not exceed this limit.</description></item>
        /// <item><description>When using base64 to transmit images, the request method must be changed to POST; the header description such as <c>data:image/png;base64,</c> should be removed from the base64 string of the image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompareFacesResponse
        /// </returns>
        public async Task<CompareFacesResponse> CompareFacesWithOptionsAsync(CompareFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceImageType))
            {
                body["SourceImageType"] = request.SourceImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceImageValue))
            {
                body["SourceImageValue"] = request.SourceImageValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageType))
            {
                body["TargetImageType"] = request.TargetImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageValue))
            {
                body["TargetImageValue"] = request.TargetImageValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareFaces",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompareFacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invoke CompareFaces for face comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Compares two face images and outputs the similarity score of the faces in the two images as the result.</para>
        /// <list type="bullet">
        /// <item><description>At least one of the specified comparison images should be a face photo (FacePic).</description></item>
        /// <item><description>If an image contains multiple faces, the algorithm will automatically select the largest face in the image.</description></item>
        /// <item><description>If one of the two comparison images does not detect a face, the system will return an error message stating \&quot;No face detected\&quot;.
        /// When uploading images, you need to provide the HTTP address or base64 encoding of the image.</description></item>
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded in base64, formatted as <c>base64://&lt;base64 string of the image&gt;</c>.
        /// Image Restrictions</description></item>
        /// <item><description>Does not support relative or absolute paths for local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2MB to avoid timeout during retrieval by the algorithm.</description></item>
        /// <item><description>The body of a single request has a size limit of 8MB; please calculate the total size of all images and other information in the request to ensure it does not exceed this limit.</description></item>
        /// <item><description>When using base64 to transmit images, the request method must be changed to POST; the header description such as <c>data:image/png;base64,</c> should be removed from the base64 string of the image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFacesRequest
        /// </param>
        /// 
        /// <returns>
        /// CompareFacesResponse
        /// </returns>
        public CompareFacesResponse CompareFaces(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invoke CompareFaces for face comparison.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Compares two face images and outputs the similarity score of the faces in the two images as the result.</para>
        /// <list type="bullet">
        /// <item><description>At least one of the specified comparison images should be a face photo (FacePic).</description></item>
        /// <item><description>If an image contains multiple faces, the algorithm will automatically select the largest face in the image.</description></item>
        /// <item><description>If one of the two comparison images does not detect a face, the system will return an error message stating \&quot;No face detected\&quot;.
        /// When uploading images, you need to provide the HTTP address or base64 encoding of the image.</description></item>
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded in base64, formatted as <c>base64://&lt;base64 string of the image&gt;</c>.
        /// Image Restrictions</description></item>
        /// <item><description>Does not support relative or absolute paths for local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2MB to avoid timeout during retrieval by the algorithm.</description></item>
        /// <item><description>The body of a single request has a size limit of 8MB; please calculate the total size of all images and other information in the request to ensure it does not exceed this limit.</description></item>
        /// <item><description>When using base64 to transmit images, the request method must be changed to POST; the header description such as <c>data:image/png;base64,</c> should be removed from the base64 string of the image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CompareFacesRequest
        /// </param>
        /// 
        /// <returns>
        /// CompareFacesResponse
        /// </returns>
        public async Task<CompareFacesResponse> CompareFacesAsync(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to submit authentication materials for verification and comparison, and it synchronously returns the authentication result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Interface Name: ContrastFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>Interface Description: An interface for real person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real person authentication, please ensure that the images you upload meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed, and natural expression, facing the camera directly.</description></item>
        /// <item><description>Clear and properly exposed photo, without overly dark, bright, or haloed faces, and with minimal angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, with the shorter side recommended to be resized to 720 pixels, and a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContrastFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContrastFaceVerifyResponse
        /// </returns>
        public ContrastFaceVerifyResponse ContrastFaceVerifyWithOptions(ContrastFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                body["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                body["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFile))
            {
                body["FaceContrastFile"] = request.FaceContrastFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                body["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContrastFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContrastFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to submit authentication materials for verification and comparison, and it synchronously returns the authentication result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Interface Name: ContrastFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>Interface Description: An interface for real person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real person authentication, please ensure that the images you upload meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed, and natural expression, facing the camera directly.</description></item>
        /// <item><description>Clear and properly exposed photo, without overly dark, bright, or haloed faces, and with minimal angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, with the shorter side recommended to be resized to 720 pixels, and a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContrastFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContrastFaceVerifyResponse
        /// </returns>
        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyWithOptionsAsync(ContrastFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                body["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                body["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFile))
            {
                body["FaceContrastFile"] = request.FaceContrastFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                body["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContrastFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContrastFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to submit authentication materials for verification and comparison, and it synchronously returns the authentication result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Interface Name: ContrastFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>Interface Description: An interface for real person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real person authentication, please ensure that the images you upload meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed, and natural expression, facing the camera directly.</description></item>
        /// <item><description>Clear and properly exposed photo, without overly dark, bright, or haloed faces, and with minimal angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, with the shorter side recommended to be resized to 720 pixels, and a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContrastFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// ContrastFaceVerifyResponse
        /// </returns>
        public ContrastFaceVerifyResponse ContrastFaceVerify(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContrastFaceVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is used to submit authentication materials for verification and comparison, and it synchronously returns the authentication result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Interface Name: ContrastFaceVerify.</description></item>
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>Interface Description: An interface for real person authentication through server-side integration.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real person authentication, please ensure that the images you upload meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed, and natural expression, facing the camera directly.</description></item>
        /// <item><description>Clear and properly exposed photo, without overly dark, bright, or haloed faces, and with minimal angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, with the shorter side recommended to be resized to 720 pixels, and a compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in cases of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ContrastFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// ContrastFaceVerifyResponse
        /// </returns>
        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAsync(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContrastFaceVerifyWithOptionsAsync(request, runtime);
        }

        public ContrastFaceVerifyResponse ContrastFaceVerifyAdvance(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FaceContrastFileObject,
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
                contrastFaceVerifyReq.FaceContrastFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ContrastFaceVerifyResponse contrastFaceVerifyResp = ContrastFaceVerifyWithOptions(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAdvanceAsync(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FaceContrastFileObject,
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
                contrastFaceVerifyReq.FaceContrastFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            ContrastFaceVerifyResponse contrastFaceVerifyResp = await ContrastFaceVerifyWithOptionsAsync(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateAuthKey to get the authorization key, which is used for offline face recognition SDK activation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.</para>
        /// <remarks>
        /// <para>The authorization key is valid for 30 minutes and cannot be reused. It is recommended to re-obtain it before each activation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAuthKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthKeyResponse
        /// </returns>
        public CreateAuthKeyResponse CreateAuthKeyWithOptions(CreateAuthKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthYears))
            {
                query["AuthYears"] = request.AuthYears;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                query["Test"] = request.Test;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeviceId))
            {
                query["UserDeviceId"] = request.UserDeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthKey",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateAuthKey to get the authorization key, which is used for offline face recognition SDK activation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.</para>
        /// <remarks>
        /// <para>The authorization key is valid for 30 minutes and cannot be reused. It is recommended to re-obtain it before each activation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAuthKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthKeyResponse
        /// </returns>
        public async Task<CreateAuthKeyResponse> CreateAuthKeyWithOptionsAsync(CreateAuthKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthYears))
            {
                query["AuthYears"] = request.AuthYears;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                query["Test"] = request.Test;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeviceId))
            {
                query["UserDeviceId"] = request.UserDeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthKey",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateAuthKey to get the authorization key, which is used for offline face recognition SDK activation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.</para>
        /// <remarks>
        /// <para>The authorization key is valid for 30 minutes and cannot be reused. It is recommended to re-obtain it before each activation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAuthKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthKeyResponse
        /// </returns>
        public CreateAuthKeyResponse CreateAuthKey(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateAuthKey to get the authorization key, which is used for offline face recognition SDK activation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.</para>
        /// <remarks>
        /// <para>The authorization key is valid for 30 minutes and cannot be reused. It is recommended to re-obtain it before each activation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAuthKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthKeyResponse
        /// </returns>
        public async Task<CreateAuthKeyResponse> CreateAuthKeyAsync(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateVerifySetting to create a verification scenario configuration. This operation is equivalent to creating a new verification scenario on the console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySettingResponse
        /// </returns>
        public CreateVerifySettingResponse CreateVerifySettingWithOptions(CreateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                query["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuideStep))
            {
                query["GuideStep"] = request.GuideStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyStep))
            {
                query["PrivacyStep"] = request.PrivacyStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultStep))
            {
                query["ResultStep"] = request.ResultStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                query["Solution"] = request.Solution;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVerifySetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVerifySettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateVerifySetting to create a verification scenario configuration. This operation is equivalent to creating a new verification scenario on the console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySettingResponse
        /// </returns>
        public async Task<CreateVerifySettingResponse> CreateVerifySettingWithOptionsAsync(CreateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                query["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuideStep))
            {
                query["GuideStep"] = request.GuideStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivacyStep))
            {
                query["PrivacyStep"] = request.PrivacyStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultStep))
            {
                query["ResultStep"] = request.ResultStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                query["Solution"] = request.Solution;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVerifySetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVerifySettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateVerifySetting to create a verification scenario configuration. This operation is equivalent to creating a new verification scenario on the console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySettingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySettingResponse
        /// </returns>
        public CreateVerifySettingResponse CreateVerifySetting(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call CreateVerifySetting to create a verification scenario configuration. This operation is equivalent to creating a new verification scenario on the console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVerifySettingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVerifySettingResponse
        /// </returns>
        public async Task<CreateVerifySettingResponse> CreateVerifySettingAsync(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Product Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload e-commerce product images to perform tampering, quality (clarity), and similar image detection, returning risk labels and scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialProductVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialProductVerifyV2Response
        /// </returns>
        public CredentialProductVerifyV2Response CredentialProductVerifyV2WithOptions(CredentialProductVerifyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFile))
            {
                body["ImageFile"] = request.ImageFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialProductVerifyV2",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialProductVerifyV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Product Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload e-commerce product images to perform tampering, quality (clarity), and similar image detection, returning risk labels and scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialProductVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialProductVerifyV2Response
        /// </returns>
        public async Task<CredentialProductVerifyV2Response> CredentialProductVerifyV2WithOptionsAsync(CredentialProductVerifyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFile))
            {
                body["ImageFile"] = request.ImageFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialProductVerifyV2",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialProductVerifyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Product Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload e-commerce product images to perform tampering, quality (clarity), and similar image detection, returning risk labels and scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialProductVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// CredentialProductVerifyV2Response
        /// </returns>
        public CredentialProductVerifyV2Response CredentialProductVerifyV2(CredentialProductVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialProductVerifyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Product Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload e-commerce product images to perform tampering, quality (clarity), and similar image detection, returning risk labels and scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialProductVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// CredentialProductVerifyV2Response
        /// </returns>
        public async Task<CredentialProductVerifyV2Response> CredentialProductVerifyV2Async(CredentialProductVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialProductVerifyV2WithOptionsAsync(request, runtime);
        }

        public CredentialProductVerifyV2Response CredentialProductVerifyV2Advance(CredentialProductVerifyV2AdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            CredentialProductVerifyV2Request credentialProductVerifyV2Req = new CredentialProductVerifyV2Request();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, credentialProductVerifyV2Req);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFileObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageFileObject,
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
                credentialProductVerifyV2Req.ImageFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CredentialProductVerifyV2Response credentialProductVerifyV2Resp = CredentialProductVerifyV2WithOptions(credentialProductVerifyV2Req, runtime);
            return credentialProductVerifyV2Resp;
        }

        public async Task<CredentialProductVerifyV2Response> CredentialProductVerifyV2AdvanceAsync(CredentialProductVerifyV2AdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            CredentialProductVerifyV2Request credentialProductVerifyV2Req = new CredentialProductVerifyV2Request();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, credentialProductVerifyV2Req);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFileObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageFileObject,
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
                credentialProductVerifyV2Req.ImageFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CredentialProductVerifyV2Response credentialProductVerifyV2Resp = await CredentialProductVerifyV2WithOptionsAsync(credentialProductVerifyV2Req, runtime);
            return credentialProductVerifyV2Resp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential verification</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CredentialVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyResponse
        /// </returns>
        public CredentialVerifyResponse CredentialVerifyWithOptions(CredentialVerifyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CredentialVerifyShrinkRequest request = new CredentialVerifyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MerchantDetail))
            {
                request.MerchantDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MerchantDetail, "MerchantDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNum))
            {
                query["CertNum"] = request.CertNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCheck))
            {
                query["IsCheck"] = request.IsCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOCR))
            {
                query["IsOCR"] = request.IsOCR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantDetailShrink))
            {
                query["MerchantDetail"] = request.MerchantDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptModel))
            {
                query["PromptModel"] = request.PromptModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageContext))
            {
                body["ImageContext"] = request.ImageContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential verification</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CredentialVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyResponse
        /// </returns>
        public async Task<CredentialVerifyResponse> CredentialVerifyWithOptionsAsync(CredentialVerifyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CredentialVerifyShrinkRequest request = new CredentialVerifyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MerchantDetail))
            {
                request.MerchantDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MerchantDetail, "MerchantDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNum))
            {
                query["CertNum"] = request.CertNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCheck))
            {
                query["IsCheck"] = request.IsCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOCR))
            {
                query["IsOCR"] = request.IsOCR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantDetailShrink))
            {
                query["MerchantDetail"] = request.MerchantDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptModel))
            {
                query["PromptModel"] = request.PromptModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageContext))
            {
                body["ImageContext"] = request.ImageContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential verification</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyResponse
        /// </returns>
        public CredentialVerifyResponse CredentialVerify(CredentialVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential verification</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyResponse
        /// </returns>
        public async Task<CredentialVerifyResponse> CredentialVerifyAsync(CredentialVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image tampering and forgery detection, and image semantic understanding. Return the risk detection results.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CredentialVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyV2Response
        /// </returns>
        public CredentialVerifyV2Response CredentialVerifyV2WithOptions(CredentialVerifyV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CredentialVerifyV2ShrinkRequest request = new CredentialVerifyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MerchantDetail))
            {
                request.MerchantDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MerchantDetail, "MerchantDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNum))
            {
                query["CertNum"] = request.CertNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCheck))
            {
                query["IsCheck"] = request.IsCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOcr))
            {
                query["IsOcr"] = request.IsOcr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantDetailShrink))
            {
                query["MerchantDetail"] = request.MerchantDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptModel))
            {
                query["PromptModel"] = request.PromptModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageContext))
            {
                body["ImageContext"] = request.ImageContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFile))
            {
                body["ImageFile"] = request.ImageFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialVerifyV2",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialVerifyV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image tampering and forgery detection, and image semantic understanding. Return the risk detection results.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CredentialVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyV2Response
        /// </returns>
        public async Task<CredentialVerifyV2Response> CredentialVerifyV2WithOptionsAsync(CredentialVerifyV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CredentialVerifyV2ShrinkRequest request = new CredentialVerifyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MerchantDetail))
            {
                request.MerchantDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MerchantDetail, "MerchantDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNum))
            {
                query["CertNum"] = request.CertNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCheck))
            {
                query["IsCheck"] = request.IsCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOcr))
            {
                query["IsOcr"] = request.IsOcr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantDetailShrink))
            {
                query["MerchantDetail"] = request.MerchantDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptModel))
            {
                query["PromptModel"] = request.PromptModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageContext))
            {
                body["ImageContext"] = request.ImageContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFile))
            {
                body["ImageFile"] = request.ImageFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialVerifyV2",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialVerifyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image tampering and forgery detection, and image semantic understanding. Return the risk detection results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyV2Response
        /// </returns>
        public CredentialVerifyV2Response CredentialVerifyV2(CredentialVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialVerifyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image tampering and forgery detection, and image semantic understanding. Return the risk detection results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyV2Response
        /// </returns>
        public async Task<CredentialVerifyV2Response> CredentialVerifyV2Async(CredentialVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialVerifyV2WithOptionsAsync(request, runtime);
        }

        public CredentialVerifyV2Response CredentialVerifyV2Advance(CredentialVerifyV2AdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            CredentialVerifyV2Request credentialVerifyV2Req = new CredentialVerifyV2Request();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, credentialVerifyV2Req);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFileObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageFileObject,
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
                credentialVerifyV2Req.ImageFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CredentialVerifyV2Response credentialVerifyV2Resp = CredentialVerifyV2WithOptions(credentialVerifyV2Req, runtime);
            return credentialVerifyV2Resp;
        }

        public async Task<CredentialVerifyV2Response> CredentialVerifyV2AdvanceAsync(CredentialVerifyV2AdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            CredentialVerifyV2Request credentialVerifyV2Req = new CredentialVerifyV2Request();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, credentialVerifyV2Req);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFileObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageFileObject,
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
                credentialVerifyV2Req.ImageFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CredentialVerifyV2Response credentialVerifyV2Resp = await CredentialVerifyV2WithOptionsAsync(credentialVerifyV2Req, runtime);
            return credentialVerifyV2Resp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification Service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The Face Deepfake Detection API is currently in the free public beta stage, which will end on August 30, 2024, at 23:59:59. During the public beta, the QPS (Queries Per Second) cannot exceed 3 times/second.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectResponse
        /// </returns>
        public DeepfakeDetectResponse DeepfakeDetectWithOptions(DeepfakeDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceInputType))
            {
                query["FaceInputType"] = request.FaceInputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceUrl))
            {
                query["FaceUrl"] = request.FaceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceBase64))
            {
                body["FaceBase64"] = request.FaceBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeepfakeDetect",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeepfakeDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification Service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The Face Deepfake Detection API is currently in the free public beta stage, which will end on August 30, 2024, at 23:59:59. During the public beta, the QPS (Queries Per Second) cannot exceed 3 times/second.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectResponse
        /// </returns>
        public async Task<DeepfakeDetectResponse> DeepfakeDetectWithOptionsAsync(DeepfakeDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceInputType))
            {
                query["FaceInputType"] = request.FaceInputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceUrl))
            {
                query["FaceUrl"] = request.FaceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceBase64))
            {
                body["FaceBase64"] = request.FaceBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeepfakeDetect",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeepfakeDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification Service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The Face Deepfake Detection API is currently in the free public beta stage, which will end on August 30, 2024, at 23:59:59. During the public beta, the QPS (Queries Per Second) cannot exceed 3 times/second.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectResponse
        /// </returns>
        public DeepfakeDetectResponse DeepfakeDetect(DeepfakeDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeepfakeDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification Service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>The Face Deepfake Detection API is currently in the free public beta stage, which will end on August 30, 2024, at 23:59:59. During the public beta, the QPS (Queries Per Second) cannot exceed 3 times/second.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectResponse
        /// </returns>
        public async Task<DeepfakeDetectResponse> DeepfakeDetectAsync(DeepfakeDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeepfakeDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial Level Sensitive Data Deletion Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes all personal information fields in the request, including name, ID number, phone number, IP, images, videos, and device information, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFaceVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceVerifyResultResponse
        /// </returns>
        public DeleteFaceVerifyResultResponse DeleteFaceVerifyResultWithOptions(DeleteFaceVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAfterQuery))
            {
                query["DeleteAfterQuery"] = request.DeleteAfterQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceVerifyResult",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceVerifyResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial Level Sensitive Data Deletion Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes all personal information fields in the request, including name, ID number, phone number, IP, images, videos, and device information, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFaceVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceVerifyResultResponse
        /// </returns>
        public async Task<DeleteFaceVerifyResultResponse> DeleteFaceVerifyResultWithOptionsAsync(DeleteFaceVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAfterQuery))
            {
                query["DeleteAfterQuery"] = request.DeleteAfterQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceVerifyResult",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceVerifyResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial Level Sensitive Data Deletion Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes all personal information fields in the request, including name, ID number, phone number, IP, images, videos, and device information, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFaceVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceVerifyResultResponse
        /// </returns>
        public DeleteFaceVerifyResultResponse DeleteFaceVerifyResult(DeleteFaceVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceVerifyResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial Level Sensitive Data Deletion Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes all personal information fields in the request, including name, ID number, phone number, IP, images, videos, and device information, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFaceVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceVerifyResultResponse
        /// </returns>
        public async Task<DeleteFaceVerifyResultResponse> DeleteFaceVerifyResultAsync(DeleteFaceVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceVerifyResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain Authentication Results from Image Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After receiving the callback notification, you can use this interface on the server side to obtain the corresponding authentication status and information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCardVerifyResponse
        /// </returns>
        public DescribeCardVerifyResponse DescribeCardVerifyWithOptions(DescribeCardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCardVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain Authentication Results from Image Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After receiving the callback notification, you can use this interface on the server side to obtain the corresponding authentication status and information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCardVerifyResponse
        /// </returns>
        public async Task<DescribeCardVerifyResponse> DescribeCardVerifyWithOptionsAsync(DescribeCardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCardVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain Authentication Results from Image Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After receiving the callback notification, you can use this interface on the server side to obtain the corresponding authentication status and information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCardVerifyResponse
        /// </returns>
        public DescribeCardVerifyResponse DescribeCardVerify(DescribeCardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCardVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain Authentication Results from Image Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After receiving the callback notification, you can use this interface on the server side to obtain the corresponding authentication status and information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCardVerifyResponse
        /// </returns>
        public async Task<DescribeCardVerifyResponse> DescribeCardVerifyAsync(DescribeCardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCardVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeDeviceInfo to query device-related information, such as the validity period of authorization, business identifiers customized by the access party, and device ID, etc.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfoWithOptions(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredEndDay))
            {
                query["ExpiredEndDay"] = request.ExpiredEndDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredStartDay))
            {
                query["ExpiredStartDay"] = request.ExpiredStartDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeviceId))
            {
                query["UserDeviceId"] = request.UserDeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceInfo",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeDeviceInfo to query device-related information, such as the validity period of authorization, business identifiers customized by the access party, and device ID, etc.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoWithOptionsAsync(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredEndDay))
            {
                query["ExpiredEndDay"] = request.ExpiredEndDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredStartDay))
            {
                query["ExpiredStartDay"] = request.ExpiredStartDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeviceId))
            {
                query["UserDeviceId"] = request.UserDeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceInfo",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeDeviceInfo to query device-related information, such as the validity period of authorization, business identifiers customized by the access party, and device ID, etc.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfo(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeDeviceInfo to query device-related information, such as the validity period of authorization, business identifiers customized by the access party, and device ID, etc.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceInfoResponse
        /// </returns>
        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoAsync(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-Grade Face Guard Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaceGuardRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceGuardRiskResponse
        /// </returns>
        public DescribeFaceGuardRiskResponse DescribeFaceGuardRiskWithOptions(DescribeFaceGuardRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaceGuardRisk",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaceGuardRiskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-Grade Face Guard Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaceGuardRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceGuardRiskResponse
        /// </returns>
        public async Task<DescribeFaceGuardRiskResponse> DescribeFaceGuardRiskWithOptionsAsync(DescribeFaceGuardRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaceGuardRisk",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaceGuardRiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-Grade Face Guard Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaceGuardRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceGuardRiskResponse
        /// </returns>
        public DescribeFaceGuardRiskResponse DescribeFaceGuardRisk(DescribeFaceGuardRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceGuardRiskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Financial-Grade Face Guard Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFaceGuardRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceGuardRiskResponse
        /// </returns>
        public async Task<DescribeFaceGuardRiskResponse> DescribeFaceGuardRiskAsync(DescribeFaceGuardRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceGuardRiskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After the mobile end of the integrator receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceVerifyResponse
        /// </returns>
        public DescribeFaceVerifyResponse DescribeFaceVerifyWithOptions(DescribeFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureReturnType))
            {
                query["PictureReturnType"] = request.PictureReturnType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After the mobile end of the integrator receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceVerifyResponse
        /// </returns>
        public async Task<DescribeFaceVerifyResponse> DescribeFaceVerifyWithOptionsAsync(DescribeFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureReturnType))
            {
                query["PictureReturnType"] = request.PictureReturnType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After the mobile end of the integrator receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceVerifyResponse
        /// </returns>
        public DescribeFaceVerifyResponse DescribeFaceVerify(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After the mobile end of the integrator receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com.</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFaceVerifyResponse
        /// </returns>
        public async Task<DescribeFaceVerifyResponse> DescribeFaceVerifyAsync(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeOssUploadToken to get the Token required for uploading photos to OSS.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOssUploadTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOssUploadTokenResponse
        /// </returns>
        public DescribeOssUploadTokenResponse DescribeOssUploadTokenWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssUploadToken",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssUploadTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeOssUploadToken to get the Token required for uploading photos to OSS.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOssUploadTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOssUploadTokenResponse
        /// </returns>
        public async Task<DescribeOssUploadTokenResponse> DescribeOssUploadTokenWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssUploadToken",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssUploadTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeOssUploadToken to get the Token required for uploading photos to OSS.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeOssUploadTokenResponse
        /// </returns>
        public DescribeOssUploadTokenResponse DescribeOssUploadToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssUploadTokenWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeOssUploadToken to get the Token required for uploading photos to OSS.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeOssUploadTokenResponse
        /// </returns>
        public async Task<DescribeOssUploadTokenResponse> DescribeOssUploadTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssUploadTokenWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Open API adds financial-grade data statistics API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePageFaceVerifyDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePageFaceVerifyDataResponse
        /// </returns>
        public DescribePageFaceVerifyDataResponse DescribePageFaceVerifyDataWithOptions(DescribePageFaceVerifyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePageFaceVerifyData",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePageFaceVerifyDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Open API adds financial-grade data statistics API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePageFaceVerifyDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePageFaceVerifyDataResponse
        /// </returns>
        public async Task<DescribePageFaceVerifyDataResponse> DescribePageFaceVerifyDataWithOptionsAsync(DescribePageFaceVerifyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePageFaceVerifyData",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePageFaceVerifyDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Open API adds financial-grade data statistics API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePageFaceVerifyDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePageFaceVerifyDataResponse
        /// </returns>
        public DescribePageFaceVerifyDataResponse DescribePageFaceVerifyData(DescribePageFaceVerifyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePageFaceVerifyDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Open API adds financial-grade data statistics API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePageFaceVerifyDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePageFaceVerifyDataResponse
        /// </returns>
        public async Task<DescribePageFaceVerifyDataResponse> DescribePageFaceVerifyDataAsync(DescribePageFaceVerifyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePageFaceVerifyDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Real Person Authentication Call Statistics Pagination Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmartStatisticsPageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmartStatisticsPageListResponse
        /// </returns>
        public DescribeSmartStatisticsPageListResponse DescribeSmartStatisticsPageListWithOptions(DescribeSmartStatisticsPageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmartStatisticsPageList",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmartStatisticsPageListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Real Person Authentication Call Statistics Pagination Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmartStatisticsPageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmartStatisticsPageListResponse
        /// </returns>
        public async Task<DescribeSmartStatisticsPageListResponse> DescribeSmartStatisticsPageListWithOptionsAsync(DescribeSmartStatisticsPageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSmartStatisticsPageList",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSmartStatisticsPageListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Real Person Authentication Call Statistics Pagination Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmartStatisticsPageListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmartStatisticsPageListResponse
        /// </returns>
        public DescribeSmartStatisticsPageListResponse DescribeSmartStatisticsPageList(DescribeSmartStatisticsPageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartStatisticsPageListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Real Person Authentication Call Statistics Pagination Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSmartStatisticsPageListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSmartStatisticsPageListResponse
        /// </returns>
        public async Task<DescribeSmartStatisticsPageListResponse> DescribeSmartStatisticsPageListAsync(DescribeSmartStatisticsPageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartStatisticsPageListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the result of real-person authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Prerequisites: Before accessing this API, please ensure that you have completed the necessary preparations. For more details, see <a href="https://help.aliyun.com/document_detail/127471.html">Real Person Authentication Server-side Preparation</a> and <a href="https://help.aliyun.com/document_detail/127717.html">Liveness Face Verification Server-side Preparation</a>.</para>
        /// <remarks>
        /// <para>Alibaba Cloud Real Person Authentication only stores authentication data for the last 180 days. For any subsequent business use, please call this interface in a timely manner to retrieve and store the data yourself to avoid any impact on usage.
        /// Request Method: HTTPS POST and GET.
        /// Interface Description: After the mobile end of the access party receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.
        /// Applicable Scope: This interface is applicable to the authentication solution with SDK + server-side integration.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyResultResponse
        /// </returns>
        public DescribeVerifyResultResponse DescribeVerifyResultWithOptions(DescribeVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyResult",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifyResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the result of real-person authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Prerequisites: Before accessing this API, please ensure that you have completed the necessary preparations. For more details, see <a href="https://help.aliyun.com/document_detail/127471.html">Real Person Authentication Server-side Preparation</a> and <a href="https://help.aliyun.com/document_detail/127717.html">Liveness Face Verification Server-side Preparation</a>.</para>
        /// <remarks>
        /// <para>Alibaba Cloud Real Person Authentication only stores authentication data for the last 180 days. For any subsequent business use, please call this interface in a timely manner to retrieve and store the data yourself to avoid any impact on usage.
        /// Request Method: HTTPS POST and GET.
        /// Interface Description: After the mobile end of the access party receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.
        /// Applicable Scope: This interface is applicable to the authentication solution with SDK + server-side integration.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyResultResponse
        /// </returns>
        public async Task<DescribeVerifyResultResponse> DescribeVerifyResultWithOptionsAsync(DescribeVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyResult",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifyResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the result of real-person authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Prerequisites: Before accessing this API, please ensure that you have completed the necessary preparations. For more details, see <a href="https://help.aliyun.com/document_detail/127471.html">Real Person Authentication Server-side Preparation</a> and <a href="https://help.aliyun.com/document_detail/127717.html">Liveness Face Verification Server-side Preparation</a>.</para>
        /// <remarks>
        /// <para>Alibaba Cloud Real Person Authentication only stores authentication data for the last 180 days. For any subsequent business use, please call this interface in a timely manner to retrieve and store the data yourself to avoid any impact on usage.
        /// Request Method: HTTPS POST and GET.
        /// Interface Description: After the mobile end of the access party receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.
        /// Applicable Scope: This interface is applicable to the authentication solution with SDK + server-side integration.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyResultResponse
        /// </returns>
        public DescribeVerifyResultResponse DescribeVerifyResult(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the result of real-person authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Prerequisites: Before accessing this API, please ensure that you have completed the necessary preparations. For more details, see <a href="https://help.aliyun.com/document_detail/127471.html">Real Person Authentication Server-side Preparation</a> and <a href="https://help.aliyun.com/document_detail/127717.html">Liveness Face Verification Server-side Preparation</a>.</para>
        /// <remarks>
        /// <para>Alibaba Cloud Real Person Authentication only stores authentication data for the last 180 days. For any subsequent business use, please call this interface in a timely manner to retrieve and store the data yourself to avoid any impact on usage.
        /// Request Method: HTTPS POST and GET.
        /// Interface Description: After the mobile end of the access party receives the callback, its server can call this interface to obtain the corresponding authentication status and authentication information.
        /// Applicable Scope: This interface is applicable to the authentication solution with SDK + server-side integration.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyResultResponse
        /// </returns>
        public async Task<DescribeVerifyResultResponse> DescribeVerifyResultAsync(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifySDK to get the offline SDK download address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.
        /// Interface Description: Obtain the SDK generation result based on the task ID for generating an offline facial recognition SDK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySDKRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySDKResponse
        /// </returns>
        public DescribeVerifySDKResponse DescribeVerifySDKWithOptions(DescribeVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeVerifySDK",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifySDKResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifySDK to get the offline SDK download address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.
        /// Interface Description: Obtain the SDK generation result based on the task ID for generating an offline facial recognition SDK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySDKRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySDKResponse
        /// </returns>
        public async Task<DescribeVerifySDKResponse> DescribeVerifySDKWithOptionsAsync(DescribeVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeVerifySDK",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifySDKResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifySDK to get the offline SDK download address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.
        /// Interface Description: Obtain the SDK generation result based on the task ID for generating an offline facial recognition SDK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySDKRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySDKResponse
        /// </returns>
        public DescribeVerifySDKResponse DescribeVerifySDK(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySDKWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifySDK to get the offline SDK download address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests via HTTPS POST and GET methods.
        /// Interface Description: Obtain the SDK generation result based on the task ID for generating an offline facial recognition SDK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifySDKRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifySDKResponse
        /// </returns>
        public async Task<DescribeVerifySDKResponse> DescribeVerifySDKAsync(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySDKWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifyToken to initiate an authentication request and obtain an authentication Token. This interface is suitable for authentication solutions using SDK + server-side integration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparations have been completed. For details, see <a href="https://help.aliyun.com/document_detail/127536.html">Overview of Real Person Authentication Solution Integration Process</a> and <a href="https://help.aliyun.com/document_detail/127687.html">Overview of Live Face Verification Solution (Liveness Detection Solution) Integration Process</a>.
        /// Request Method: HTTPS POST and GET
        /// API Description: Before each authentication, use this interface to obtain an authentication Token (VerifyToken), which is used to link various interfaces in the authentication request.
        /// Applicable Scope: This interface is suitable for wireless SDK integration.
        /// Image Address: Use HTTP or HTTPS addresses that are publicly accessible over the Internet. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.
        /// Image Restrictions:</para>
        /// <list type="bullet">
        /// <item><description>Relative or absolute paths of local images are not supported.</description></item>
        /// <item><description>The size of a single image should be controlled within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image must be at least 64*64 pixels (px).</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request to ensure it does not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyTokenResponse
        /// </returns>
        public DescribeVerifyTokenResponse DescribeVerifyTokenWithOptions(DescribeVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackSeed))
            {
                query["CallbackSeed"] = request.CallbackSeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceRetainedImageUrl))
            {
                query["FaceRetainedImageUrl"] = request.FaceRetainedImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailedRedirectUrl))
            {
                query["FailedRedirectUrl"] = request.FailedRedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardBackImageUrl))
            {
                query["IdCardBackImageUrl"] = request.IdCardBackImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardFrontImageUrl))
            {
                query["IdCardFrontImageUrl"] = request.IdCardFrontImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassedRedirectUrl))
            {
                query["PassedRedirectUrl"] = request.PassedRedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIp))
            {
                query["UserIp"] = request.UserIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPhoneNumber))
            {
                query["UserPhoneNumber"] = request.UserPhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserRegistTime))
            {
                query["UserRegistTime"] = request.UserRegistTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyToken",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifyTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifyToken to initiate an authentication request and obtain an authentication Token. This interface is suitable for authentication solutions using SDK + server-side integration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparations have been completed. For details, see <a href="https://help.aliyun.com/document_detail/127536.html">Overview of Real Person Authentication Solution Integration Process</a> and <a href="https://help.aliyun.com/document_detail/127687.html">Overview of Live Face Verification Solution (Liveness Detection Solution) Integration Process</a>.
        /// Request Method: HTTPS POST and GET
        /// API Description: Before each authentication, use this interface to obtain an authentication Token (VerifyToken), which is used to link various interfaces in the authentication request.
        /// Applicable Scope: This interface is suitable for wireless SDK integration.
        /// Image Address: Use HTTP or HTTPS addresses that are publicly accessible over the Internet. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.
        /// Image Restrictions:</para>
        /// <list type="bullet">
        /// <item><description>Relative or absolute paths of local images are not supported.</description></item>
        /// <item><description>The size of a single image should be controlled within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image must be at least 64*64 pixels (px).</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request to ensure it does not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyTokenResponse
        /// </returns>
        public async Task<DescribeVerifyTokenResponse> DescribeVerifyTokenWithOptionsAsync(DescribeVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackSeed))
            {
                query["CallbackSeed"] = request.CallbackSeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceRetainedImageUrl))
            {
                query["FaceRetainedImageUrl"] = request.FaceRetainedImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailedRedirectUrl))
            {
                query["FailedRedirectUrl"] = request.FailedRedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardBackImageUrl))
            {
                query["IdCardBackImageUrl"] = request.IdCardBackImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardFrontImageUrl))
            {
                query["IdCardFrontImageUrl"] = request.IdCardFrontImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassedRedirectUrl))
            {
                query["PassedRedirectUrl"] = request.PassedRedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIp))
            {
                query["UserIp"] = request.UserIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPhoneNumber))
            {
                query["UserPhoneNumber"] = request.UserPhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserRegistTime))
            {
                query["UserRegistTime"] = request.UserRegistTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVerifyToken",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVerifyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifyToken to initiate an authentication request and obtain an authentication Token. This interface is suitable for authentication solutions using SDK + server-side integration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparations have been completed. For details, see <a href="https://help.aliyun.com/document_detail/127536.html">Overview of Real Person Authentication Solution Integration Process</a> and <a href="https://help.aliyun.com/document_detail/127687.html">Overview of Live Face Verification Solution (Liveness Detection Solution) Integration Process</a>.
        /// Request Method: HTTPS POST and GET
        /// API Description: Before each authentication, use this interface to obtain an authentication Token (VerifyToken), which is used to link various interfaces in the authentication request.
        /// Applicable Scope: This interface is suitable for wireless SDK integration.
        /// Image Address: Use HTTP or HTTPS addresses that are publicly accessible over the Internet. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.
        /// Image Restrictions:</para>
        /// <list type="bullet">
        /// <item><description>Relative or absolute paths of local images are not supported.</description></item>
        /// <item><description>The size of a single image should be controlled within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image must be at least 64*64 pixels (px).</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request to ensure it does not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyTokenResponse
        /// </returns>
        public DescribeVerifyTokenResponse DescribeVerifyToken(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeVerifyToken to initiate an authentication request and obtain an authentication Token. This interface is suitable for authentication solutions using SDK + server-side integration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparations have been completed. For details, see <a href="https://help.aliyun.com/document_detail/127536.html">Overview of Real Person Authentication Solution Integration Process</a> and <a href="https://help.aliyun.com/document_detail/127687.html">Overview of Live Face Verification Solution (Liveness Detection Solution) Integration Process</a>.
        /// Request Method: HTTPS POST and GET
        /// API Description: Before each authentication, use this interface to obtain an authentication Token (VerifyToken), which is used to link various interfaces in the authentication request.
        /// Applicable Scope: This interface is suitable for wireless SDK integration.
        /// Image Address: Use HTTP or HTTPS addresses that are publicly accessible over the Internet. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.
        /// Image Restrictions:</para>
        /// <list type="bullet">
        /// <item><description>Relative or absolute paths of local images are not supported.</description></item>
        /// <item><description>The size of a single image should be controlled within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image must be at least 64*64 pixels (px).</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request to ensure it does not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeVerifyTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVerifyTokenResponse
        /// </returns>
        public async Task<DescribeVerifyTokenResponse> DescribeVerifyTokenAsync(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detect Validity Attributes in Face Photos</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Detects the validity-related attributes of faces in the input photo, which helps the business side to determine whether the photo meets their own business retention or comparison requirements. The currently supported face validity-related attributes include: whether it is a face, whether it is blurry, whether glasses are worn, face pose, whether it is a smile, etc.
        /// Instructions for Uploading Image Addresses: When passing in images, you need to upload their corresponding HTTP, OSS addresses, or Base64 encoding.</para>
        /// <list type="bullet">
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded through base64, with the format being <c>base64://&lt;image base64 string&gt;</c>.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm timeout.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request; please calculate the total size of all images and other information in the request and do not exceed the limit.</description></item>
        /// <item><description>When using Base64 to pass images, the request method needs to be changed to POST; the header description of the image Base64 string, such as <c>data:image/png;base64</c>, should be removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectFaceAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectFaceAttributesResponse
        /// </returns>
        public DetectFaceAttributesResponse DetectFaceAttributesWithOptions(DetectFaceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialValue))
            {
                body["MaterialValue"] = request.MaterialValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectFaceAttributes",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectFaceAttributesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detect Validity Attributes in Face Photos</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Detects the validity-related attributes of faces in the input photo, which helps the business side to determine whether the photo meets their own business retention or comparison requirements. The currently supported face validity-related attributes include: whether it is a face, whether it is blurry, whether glasses are worn, face pose, whether it is a smile, etc.
        /// Instructions for Uploading Image Addresses: When passing in images, you need to upload their corresponding HTTP, OSS addresses, or Base64 encoding.</para>
        /// <list type="bullet">
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded through base64, with the format being <c>base64://&lt;image base64 string&gt;</c>.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm timeout.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request; please calculate the total size of all images and other information in the request and do not exceed the limit.</description></item>
        /// <item><description>When using Base64 to pass images, the request method needs to be changed to POST; the header description of the image Base64 string, such as <c>data:image/png;base64</c>, should be removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectFaceAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectFaceAttributesResponse
        /// </returns>
        public async Task<DetectFaceAttributesResponse> DetectFaceAttributesWithOptionsAsync(DetectFaceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialValue))
            {
                body["MaterialValue"] = request.MaterialValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectFaceAttributes",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectFaceAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detect Validity Attributes in Face Photos</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Detects the validity-related attributes of faces in the input photo, which helps the business side to determine whether the photo meets their own business retention or comparison requirements. The currently supported face validity-related attributes include: whether it is a face, whether it is blurry, whether glasses are worn, face pose, whether it is a smile, etc.
        /// Instructions for Uploading Image Addresses: When passing in images, you need to upload their corresponding HTTP, OSS addresses, or Base64 encoding.</para>
        /// <list type="bullet">
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded through base64, with the format being <c>base64://&lt;image base64 string&gt;</c>.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm timeout.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request; please calculate the total size of all images and other information in the request and do not exceed the limit.</description></item>
        /// <item><description>When using Base64 to pass images, the request method needs to be changed to POST; the header description of the image Base64 string, such as <c>data:image/png;base64</c>, should be removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectFaceAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectFaceAttributesResponse
        /// </returns>
        public DetectFaceAttributesResponse DetectFaceAttributes(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectFaceAttributesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detect Validity Attributes in Face Photos</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Only supports sending requests via HTTPS POST.
        /// Interface Description: Detects the validity-related attributes of faces in the input photo, which helps the business side to determine whether the photo meets their own business retention or comparison requirements. The currently supported face validity-related attributes include: whether it is a face, whether it is blurry, whether glasses are worn, face pose, whether it is a smile, etc.
        /// Instructions for Uploading Image Addresses: When passing in images, you need to upload their corresponding HTTP, OSS addresses, or Base64 encoding.</para>
        /// <list type="bullet">
        /// <item><description>HTTP Address: A publicly accessible HTTP address. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>Base64 Encoding: An image encoded through base64, with the format being <c>base64://&lt;image base64 string&gt;</c>.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm timeout.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request; please calculate the total size of all images and other information in the request and do not exceed the limit.</description></item>
        /// <item><description>When using Base64 to pass images, the request method needs to be changed to POST; the header description of the image Base64 string, such as <c>data:image/png;base64</c>, should be removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectFaceAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectFaceAttributesResponse
        /// </returns>
        public async Task<DetectFaceAttributesResponse> DetectFaceAttributesAsync(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectFaceAttributesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-Factor Validity Verification API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyResponse
        /// </returns>
        public Id2MetaPeriodVerifyResponse Id2MetaPeriodVerifyWithOptions(Id2MetaPeriodVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityEndDate))
            {
                body["ValidityEndDate"] = request.ValidityEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityStartDate))
            {
                body["ValidityStartDate"] = request.ValidityStartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaPeriodVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaPeriodVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-Factor Validity Verification API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyResponse
        /// </returns>
        public async Task<Id2MetaPeriodVerifyResponse> Id2MetaPeriodVerifyWithOptionsAsync(Id2MetaPeriodVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityEndDate))
            {
                body["ValidityEndDate"] = request.ValidityEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityStartDate))
            {
                body["ValidityStartDate"] = request.ValidityStartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaPeriodVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaPeriodVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-Factor Validity Verification API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyResponse
        /// </returns>
        public Id2MetaPeriodVerifyResponse Id2MetaPeriodVerify(Id2MetaPeriodVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaPeriodVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-Factor Validity Verification API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyResponse
        /// </returns>
        public async Task<Id2MetaPeriodVerifyResponse> Id2MetaPeriodVerifyAsync(Id2MetaPeriodVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaPeriodVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Standard</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaStandardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaStandardVerifyResponse
        /// </returns>
        public Id2MetaStandardVerifyResponse Id2MetaStandardVerifyWithOptions(Id2MetaStandardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaStandardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaStandardVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Standard</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaStandardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaStandardVerifyResponse
        /// </returns>
        public async Task<Id2MetaStandardVerifyResponse> Id2MetaStandardVerifyWithOptionsAsync(Id2MetaStandardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaStandardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaStandardVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Standard</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaStandardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaStandardVerifyResponse
        /// </returns>
        public Id2MetaStandardVerifyResponse Id2MetaStandardVerify(Id2MetaStandardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaStandardVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Standard</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaStandardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaStandardVerifyResponse
        /// </returns>
        public async Task<Id2MetaStandardVerifyResponse> Id2MetaStandardVerifyAsync(Id2MetaStandardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaStandardVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyResponse
        /// </returns>
        public Id2MetaVerifyResponse Id2MetaVerifyWithOptions(Id2MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyResponse
        /// </returns>
        public async Task<Id2MetaVerifyResponse> Id2MetaVerifyWithOptionsAsync(Id2MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyResponse
        /// </returns>
        public Id2MetaVerifyResponse Id2MetaVerify(Id2MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Two-Factor Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyResponse
        /// </returns>
        public async Task<Id2MetaVerifyResponse> Id2MetaVerifyAsync(Id2MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ID Two-Factor Image Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload both sides of the ID card, and get the verification result of the two factors from an authoritative data source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyWithOCRRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyWithOCRResponse
        /// </returns>
        public Id2MetaVerifyWithOCRResponse Id2MetaVerifyWithOCRWithOptions(Id2MetaVerifyWithOCRRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFile))
            {
                body["CertFile"] = request.CertFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalFile))
            {
                body["CertNationalFile"] = request.CertNationalFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalUrl))
            {
                body["CertNationalUrl"] = request.CertNationalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertUrl))
            {
                body["CertUrl"] = request.CertUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerifyWithOCR",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyWithOCRResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ID Two-Factor Image Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload both sides of the ID card, and get the verification result of the two factors from an authoritative data source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyWithOCRRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyWithOCRResponse
        /// </returns>
        public async Task<Id2MetaVerifyWithOCRResponse> Id2MetaVerifyWithOCRWithOptionsAsync(Id2MetaVerifyWithOCRRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFile))
            {
                body["CertFile"] = request.CertFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalFile))
            {
                body["CertNationalFile"] = request.CertNationalFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalUrl))
            {
                body["CertNationalUrl"] = request.CertNationalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertUrl))
            {
                body["CertUrl"] = request.CertUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerifyWithOCR",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyWithOCRResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ID Two-Factor Image Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload both sides of the ID card, and get the verification result of the two factors from an authoritative data source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyWithOCRRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyWithOCRResponse
        /// </returns>
        public Id2MetaVerifyWithOCRResponse Id2MetaVerifyWithOCR(Id2MetaVerifyWithOCRRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaVerifyWithOCRWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ID Two-Factor Image Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upload both sides of the ID card, and get the verification result of the two factors from an authoritative data source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyWithOCRRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyWithOCRResponse
        /// </returns>
        public async Task<Id2MetaVerifyWithOCRResponse> Id2MetaVerifyWithOCRAsync(Id2MetaVerifyWithOCRRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaVerifyWithOCRWithOptionsAsync(request, runtime);
        }

        public Id2MetaVerifyWithOCRResponse Id2MetaVerifyWithOCRAdvance(Id2MetaVerifyWithOCRAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            Id2MetaVerifyWithOCRRequest id2MetaVerifyWithOCRReq = new Id2MetaVerifyWithOCRRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, id2MetaVerifyWithOCRReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFileObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.CertFileObject,
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
                id2MetaVerifyWithOCRReq.CertFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalFileObject))
            {
                object tmpResp1 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.CertNationalFileObject,
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
                id2MetaVerifyWithOCRReq.CertNationalFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            Id2MetaVerifyWithOCRResponse id2MetaVerifyWithOCRResp = Id2MetaVerifyWithOCRWithOptions(id2MetaVerifyWithOCRReq, runtime);
            return id2MetaVerifyWithOCRResp;
        }

        public async Task<Id2MetaVerifyWithOCRResponse> Id2MetaVerifyWithOCRAdvanceAsync(Id2MetaVerifyWithOCRAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            Id2MetaVerifyWithOCRRequest id2MetaVerifyWithOCRReq = new Id2MetaVerifyWithOCRRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, id2MetaVerifyWithOCRReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFileObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.CertFileObject,
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
                id2MetaVerifyWithOCRReq.CertFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNationalFileObject))
            {
                object tmpResp1 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp1);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.CertNationalFileObject,
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
                id2MetaVerifyWithOCRReq.CertNationalFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            Id2MetaVerifyWithOCRResponse id2MetaVerifyWithOCRResp = await Id2MetaVerifyWithOCRWithOptionsAsync(id2MetaVerifyWithOCRReq, runtime);
            return id2MetaVerifyWithOCRResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Three Elements Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input name, ID number, and face photo to verify their authenticity and consistency through authoritative sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id3MetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id3MetaVerifyResponse
        /// </returns>
        public Id3MetaVerifyResponse Id3MetaVerifyWithOptions(Id3MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceFile))
            {
                body["FaceFile"] = request.FaceFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceUrl))
            {
                body["FaceUrl"] = request.FaceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id3MetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id3MetaVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Three Elements Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input name, ID number, and face photo to verify their authenticity and consistency through authoritative sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id3MetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id3MetaVerifyResponse
        /// </returns>
        public async Task<Id3MetaVerifyResponse> Id3MetaVerifyWithOptionsAsync(Id3MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceFile))
            {
                body["FaceFile"] = request.FaceFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceUrl))
            {
                body["FaceUrl"] = request.FaceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id3MetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id3MetaVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Three Elements Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input name, ID number, and face photo to verify their authenticity and consistency through authoritative sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id3MetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id3MetaVerifyResponse
        /// </returns>
        public Id3MetaVerifyResponse Id3MetaVerify(Id3MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id3MetaVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identity Three Elements Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input name, ID number, and face photo to verify their authenticity and consistency through authoritative sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Id3MetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Id3MetaVerifyResponse
        /// </returns>
        public async Task<Id3MetaVerifyResponse> Id3MetaVerifyAsync(Id3MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id3MetaVerifyWithOptionsAsync(request, runtime);
        }

        public Id3MetaVerifyResponse Id3MetaVerifyAdvance(Id3MetaVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            Id3MetaVerifyRequest id3MetaVerifyReq = new Id3MetaVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, id3MetaVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceFileObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FaceFileObject,
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
                id3MetaVerifyReq.FaceFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            Id3MetaVerifyResponse id3MetaVerifyResp = Id3MetaVerifyWithOptions(id3MetaVerifyReq, runtime);
            return id3MetaVerifyResp;
        }

        public async Task<Id3MetaVerifyResponse> Id3MetaVerifyAdvanceAsync(Id3MetaVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                {"Product", "Cloudauth"},
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
            Id3MetaVerifyRequest id3MetaVerifyReq = new Id3MetaVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, id3MetaVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceFileObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.FaceFileObject,
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
                id3MetaVerifyReq.FaceFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            Id3MetaVerifyResponse id3MetaVerifyResp = await Id3MetaVerifyWithOptionsAsync(id3MetaVerifyReq, runtime);
            return id3MetaVerifyResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate an authentication request for image verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before each authentication, use this interface to obtain the CertifyId, which is used to link various interfaces in the authentication request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InitCardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitCardVerifyResponse
        /// </returns>
        public InitCardVerifyResponse InitCardVerifyWithOptions(InitCardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardPageNumber))
            {
                query["CardPageNumber"] = request.CardPageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                query["CardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocScanMode))
            {
                query["DocScanMode"] = request.DocScanMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSave))
            {
                query["PictureSave"] = request.PictureSave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMeta))
            {
                query["VerifyMeta"] = request.VerifyMeta;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitCardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitCardVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate an authentication request for image verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before each authentication, use this interface to obtain the CertifyId, which is used to link various interfaces in the authentication request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InitCardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitCardVerifyResponse
        /// </returns>
        public async Task<InitCardVerifyResponse> InitCardVerifyWithOptionsAsync(InitCardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardPageNumber))
            {
                query["CardPageNumber"] = request.CardPageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                query["CardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocScanMode))
            {
                query["DocScanMode"] = request.DocScanMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSave))
            {
                query["PictureSave"] = request.PictureSave;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMeta))
            {
                query["VerifyMeta"] = request.VerifyMeta;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitCardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitCardVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate an authentication request for image verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before each authentication, use this interface to obtain the CertifyId, which is used to link various interfaces in the authentication request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InitCardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// InitCardVerifyResponse
        /// </returns>
        public InitCardVerifyResponse InitCardVerify(InitCardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitCardVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiate an authentication request for image verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before each authentication, use this interface to obtain the CertifyId, which is used to link various interfaces in the authentication request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InitCardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// InitCardVerifyResponse
        /// </returns>
        public async Task<InitCardVerifyResponse> InitCardVerifyAsync(InitCardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitCardVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Real-Person Server Initialization Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>This interface uses different parameters for different product solutions. For details, please refer to the <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/product-overview/introduction/?spm=a2c4g.11186623.help-menu-2401581.d_0_0.13f644ecRzFHfm&scm=20140722.H_99169._.OR_help-T_cn~zh-V_1">official documentation</a>.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real-person authentication, please provide images that meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overexposure, underexposure, or halo effects, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended short side scaled to 720 pixels, compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in the case of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitFaceVerifyResponse
        /// </returns>
        public InitFaceVerifyResponse InitFaceVerifyWithOptions(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppQualityCheck))
            {
                query["AppQualityCheck"] = request.AppQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Birthday))
            {
                query["Birthday"] = request.Birthday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraSelection))
            {
                query["CameraSelection"] = request.CameraSelection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyUrlStyle))
            {
                query["CertifyUrlStyle"] = request.CertifyUrlStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyUrlType))
            {
                query["CertifyUrlType"] = request.CertifyUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                query["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGuardOutput))
            {
                query["FaceGuardOutput"] = request.FaceGuardOutput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedMultiFaceCheck))
            {
                query["NeedMultiFaceCheck"] = request.NeedMultiFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                query["OssObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedurePriority))
            {
                query["ProcedurePriority"] = request.ProcedurePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RarelyCharacters))
            {
                query["RarelyCharacters"] = request.RarelyCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadImg))
            {
                query["ReadImg"] = request.ReadImg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                query["ReturnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuitableType))
            {
                query["SuitableType"] = request.SuitableType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiCustomUrl))
            {
                query["UiCustomUrl"] = request.UiCustomUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityDate))
            {
                query["ValidityDate"] = request.ValidityDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoEvidence))
            {
                query["VideoEvidence"] = request.VideoEvidence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoluntaryCustomizedContent))
            {
                query["VoluntaryCustomizedContent"] = request.VoluntaryCustomizedContent;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthId))
            {
                body["AuthId"] = request.AuthId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Real-Person Server Initialization Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>This interface uses different parameters for different product solutions. For details, please refer to the <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/product-overview/introduction/?spm=a2c4g.11186623.help-menu-2401581.d_0_0.13f644ecRzFHfm&scm=20140722.H_99169._.OR_help-T_cn~zh-V_1">official documentation</a>.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real-person authentication, please provide images that meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overexposure, underexposure, or halo effects, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended short side scaled to 720 pixels, compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in the case of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitFaceVerifyResponse
        /// </returns>
        public async Task<InitFaceVerifyResponse> InitFaceVerifyWithOptionsAsync(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppQualityCheck))
            {
                query["AppQualityCheck"] = request.AppQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Birthday))
            {
                query["Birthday"] = request.Birthday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraSelection))
            {
                query["CameraSelection"] = request.CameraSelection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyUrlStyle))
            {
                query["CertifyUrlStyle"] = request.CertifyUrlStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyUrlType))
            {
                query["CertifyUrlType"] = request.CertifyUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                query["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGuardOutput))
            {
                query["FaceGuardOutput"] = request.FaceGuardOutput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedMultiFaceCheck))
            {
                query["NeedMultiFaceCheck"] = request.NeedMultiFaceCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                query["OssObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderNo))
            {
                query["OuterOrderNo"] = request.OuterOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedurePriority))
            {
                query["ProcedurePriority"] = request.ProcedurePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RarelyCharacters))
            {
                query["RarelyCharacters"] = request.RarelyCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadImg))
            {
                query["ReadImg"] = request.ReadImg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                query["ReturnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuitableType))
            {
                query["SuitableType"] = request.SuitableType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UiCustomUrl))
            {
                query["UiCustomUrl"] = request.UiCustomUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityDate))
            {
                query["ValidityDate"] = request.ValidityDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoEvidence))
            {
                query["VideoEvidence"] = request.VideoEvidence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoluntaryCustomizedContent))
            {
                query["VoluntaryCustomizedContent"] = request.VoluntaryCustomizedContent;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthId))
            {
                body["AuthId"] = request.AuthId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Real-Person Server Initialization Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>This interface uses different parameters for different product solutions. For details, please refer to the <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/product-overview/introduction/?spm=a2c4g.11186623.help-menu-2401581.d_0_0.13f644ecRzFHfm&scm=20140722.H_99169._.OR_help-T_cn~zh-V_1">official documentation</a>.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real-person authentication, please provide images that meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overexposure, underexposure, or halo effects, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended short side scaled to 720 pixels, compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in the case of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// InitFaceVerifyResponse
        /// </returns>
        public InitFaceVerifyResponse InitFaceVerify(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitFaceVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Real-Person Server Initialization Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service Address: cloudauth.aliyuncs.com</description></item>
        /// <item><description>Request Method: HTTPS POST and GET.</description></item>
        /// <item><description>This interface uses different parameters for different product solutions. For details, please refer to the <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/product-overview/introduction/?spm=a2c4g.11186623.help-menu-2401581.d_0_0.13f644ecRzFHfm&scm=20140722.H_99169._.OR_help-T_cn~zh-V_1">official documentation</a>.</description></item>
        /// </list>
        /// <h4>Image Format Requirements</h4>
        /// <para>When performing real-person authentication, please provide images that meet all of the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Recent photo with a clear, unobstructed face, natural expression, and facing the camera directly.</description></item>
        /// <item><description>Clear photo with normal exposure, no overexposure, underexposure, or halo effects, and no significant angle deviation.</description></item>
        /// <item><description>Resolution not exceeding 1920<em>1080, at least 640</em>480, recommended short side scaled to 720 pixels, compression ratio greater than 0.9.</description></item>
        /// <item><description>Photo size: &lt;1MB.</description></item>
        /// <item><description>Supports 90, 180, and 270-degree photos; in the case of multiple faces, the largest face will be selected.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// InitFaceVerifyResponse
        /// </returns>
        public async Task<InitFaceVerifyResponse> InitFaceVerifyAsync(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitFaceVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertWhiteListSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertWhiteListSettingResponse
        /// </returns>
        public InsertWhiteListSettingResponse InsertWhiteListSettingWithOptions(InsertWhiteListSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidDay))
            {
                query["ValidDay"] = request.ValidDay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertWhiteListSetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertWhiteListSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertWhiteListSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertWhiteListSettingResponse
        /// </returns>
        public async Task<InsertWhiteListSettingResponse> InsertWhiteListSettingWithOptionsAsync(InsertWhiteListSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidDay))
            {
                query["ValidDay"] = request.ValidDay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertWhiteListSetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertWhiteListSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertWhiteListSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertWhiteListSettingResponse
        /// </returns>
        public InsertWhiteListSettingResponse InsertWhiteListSetting(InsertWhiteListSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertWhiteListSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertWhiteListSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertWhiteListSettingResponse
        /// </returns>
        public async Task<InsertWhiteListSettingResponse> InsertWhiteListSettingAsync(InsertWhiteListSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertWhiteListSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Silent Liveness Face (LivenessFaceVerify) refers to a service that performs real face detection by inputting pre-obtained face images through an API. The algorithm primarily identifies whether the face is from a screen recording, printed picture, or other types of liveness attacks. This service is suitable for low-risk business scenarios or in conjunction with offline facial recognition SDKs. If your business has higher requirements for real face security, it is recommended to integrate App or WebSDK mode, or integrate with Deepfake face detection services to assist in identifying more dimensions of face forgery risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Invoke the LivenessFaceVerify interface to perform liveness detection on a face image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LivenessFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LivenessFaceVerifyResponse
        /// </returns>
        public LivenessFaceVerifyResponse LivenessFaceVerifyWithOptions(LivenessFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                body["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                body["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LivenessFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LivenessFaceVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Silent Liveness Face (LivenessFaceVerify) refers to a service that performs real face detection by inputting pre-obtained face images through an API. The algorithm primarily identifies whether the face is from a screen recording, printed picture, or other types of liveness attacks. This service is suitable for low-risk business scenarios or in conjunction with offline facial recognition SDKs. If your business has higher requirements for real face security, it is recommended to integrate App or WebSDK mode, or integrate with Deepfake face detection services to assist in identifying more dimensions of face forgery risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Invoke the LivenessFaceVerify interface to perform liveness detection on a face image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LivenessFaceVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LivenessFaceVerifyResponse
        /// </returns>
        public async Task<LivenessFaceVerifyResponse> LivenessFaceVerifyWithOptionsAsync(LivenessFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                body["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                body["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                body["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPicture))
            {
                body["FaceContrastPicture"] = request.FaceContrastPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastPictureUrl))
            {
                body["FaceContrastPictureUrl"] = request.FaceContrastPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LivenessFaceVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LivenessFaceVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Silent Liveness Face (LivenessFaceVerify) refers to a service that performs real face detection by inputting pre-obtained face images through an API. The algorithm primarily identifies whether the face is from a screen recording, printed picture, or other types of liveness attacks. This service is suitable for low-risk business scenarios or in conjunction with offline facial recognition SDKs. If your business has higher requirements for real face security, it is recommended to integrate App or WebSDK mode, or integrate with Deepfake face detection services to assist in identifying more dimensions of face forgery risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Invoke the LivenessFaceVerify interface to perform liveness detection on a face image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LivenessFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// LivenessFaceVerifyResponse
        /// </returns>
        public LivenessFaceVerifyResponse LivenessFaceVerify(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LivenessFaceVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Silent Liveness Face (LivenessFaceVerify) refers to a service that performs real face detection by inputting pre-obtained face images through an API. The algorithm primarily identifies whether the face is from a screen recording, printed picture, or other types of liveness attacks. This service is suitable for low-risk business scenarios or in conjunction with offline facial recognition SDKs. If your business has higher requirements for real face security, it is recommended to integrate App or WebSDK mode, or integrate with Deepfake face detection services to assist in identifying more dimensions of face forgery risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Invoke the LivenessFaceVerify interface to perform liveness detection on a face image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LivenessFaceVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// LivenessFaceVerifyResponse
        /// </returns>
        public async Task<LivenessFaceVerifyResponse> LivenessFaceVerifyAsync(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LivenessFaceVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Two-Factor Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number and name, verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyResponse
        /// </returns>
        public Mobile2MetaVerifyResponse Mobile2MetaVerifyWithOptions(Mobile2MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile2MetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile2MetaVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Two-Factor Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number and name, verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyResponse
        /// </returns>
        public async Task<Mobile2MetaVerifyResponse> Mobile2MetaVerifyWithOptionsAsync(Mobile2MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile2MetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile2MetaVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Two-Factor Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number and name, verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyResponse
        /// </returns>
        public Mobile2MetaVerifyResponse Mobile2MetaVerify(Mobile2MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile2MetaVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Two-Factor Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number and name, verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyResponse
        /// </returns>
        public async Task<Mobile2MetaVerifyResponse> Mobile2MetaVerifyAsync(Mobile2MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile2MetaVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources. If they do not match, the reason for the mismatch is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailStandardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailStandardVerifyResponse
        /// </returns>
        public Mobile3MetaDetailStandardVerifyResponse Mobile3MetaDetailStandardVerifyWithOptions(Mobile3MetaDetailStandardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaDetailStandardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaDetailStandardVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources. If they do not match, the reason for the mismatch is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailStandardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailStandardVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaDetailStandardVerifyResponse> Mobile3MetaDetailStandardVerifyWithOptionsAsync(Mobile3MetaDetailStandardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaDetailStandardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaDetailStandardVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources. If they do not match, the reason for the mismatch is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailStandardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailStandardVerifyResponse
        /// </returns>
        public Mobile3MetaDetailStandardVerifyResponse Mobile3MetaDetailStandardVerify(Mobile3MetaDetailStandardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaDetailStandardVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources. If they do not match, the reason for the mismatch is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailStandardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailStandardVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaDetailStandardVerifyResponse> Mobile3MetaDetailStandardVerifyAsync(Mobile3MetaDetailStandardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaDetailStandardVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Mobile Three-Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailVerifyResponse
        /// </returns>
        public Mobile3MetaDetailVerifyResponse Mobile3MetaDetailVerifyWithOptions(Mobile3MetaDetailVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaDetailVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaDetailVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Mobile Three-Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaDetailVerifyResponse> Mobile3MetaDetailVerifyWithOptionsAsync(Mobile3MetaDetailVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaDetailVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaDetailVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Mobile Three-Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailVerifyResponse
        /// </returns>
        public Mobile3MetaDetailVerifyResponse Mobile3MetaDetailVerify(Mobile3MetaDetailVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaDetailVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detailed Mobile Three-Element Verification Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaDetailVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaDetailVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaDetailVerifyResponse> Mobile3MetaDetailVerifyAsync(Mobile3MetaDetailVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaDetailVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Simplified Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleStandardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleStandardVerifyResponse
        /// </returns>
        public Mobile3MetaSimpleStandardVerifyResponse Mobile3MetaSimpleStandardVerifyWithOptions(Mobile3MetaSimpleStandardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaSimpleStandardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaSimpleStandardVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Simplified Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleStandardVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleStandardVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaSimpleStandardVerifyResponse> Mobile3MetaSimpleStandardVerifyWithOptionsAsync(Mobile3MetaSimpleStandardVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaSimpleStandardVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaSimpleStandardVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Simplified Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleStandardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleStandardVerifyResponse
        /// </returns>
        public Mobile3MetaSimpleStandardVerifyResponse Mobile3MetaSimpleStandardVerify(Mobile3MetaSimpleStandardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaSimpleStandardVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Simplified Three-Element Verification for Phone Number_Standard Version</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input the phone number, name, and ID number to verify their authenticity and consistency through authoritative data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleStandardVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleStandardVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaSimpleStandardVerifyResponse> Mobile3MetaSimpleStandardVerifyAsync(Mobile3MetaSimpleStandardVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaSimpleStandardVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Three Elements Simplified Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleVerifyResponse
        /// </returns>
        public Mobile3MetaSimpleVerifyResponse Mobile3MetaSimpleVerifyWithOptions(Mobile3MetaSimpleVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaSimpleVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaSimpleVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Three Elements Simplified Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaSimpleVerifyResponse> Mobile3MetaSimpleVerifyWithOptionsAsync(Mobile3MetaSimpleVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                body["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaSimpleVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaSimpleVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Three Elements Simplified Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleVerifyResponse
        /// </returns>
        public Mobile3MetaSimpleVerifyResponse Mobile3MetaSimpleVerify(Mobile3MetaSimpleVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaSimpleVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mobile Three Elements Simplified Interface</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Service address: cloudauth.aliyuncs.com (IPv4) or cloudauth-dualstack.aliyuncs.com (IPv6).</description></item>
        /// <item><description>Request method: POST and GET.</description></item>
        /// <item><description>Transfer protocol: HTTPS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// Mobile3MetaSimpleVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaSimpleVerifyResponse
        /// </returns>
        public async Task<Mobile3MetaSimpleVerifyResponse> Mobile3MetaSimpleVerifyAsync(Mobile3MetaSimpleVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaSimpleVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Number Detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileDetectResponse
        /// </returns>
        public MobileDetectResponse MobileDetectWithOptions(MobileDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobiles))
            {
                body["Mobiles"] = request.Mobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileDetect",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Number Detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileDetectResponse
        /// </returns>
        public async Task<MobileDetectResponse> MobileDetectWithOptionsAsync(MobileDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobiles))
            {
                body["Mobiles"] = request.Mobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileDetect",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Number Detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileDetectResponse
        /// </returns>
        public MobileDetectResponse MobileDetect(MobileDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Number Detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileDetectResponse
        /// </returns>
        public async Task<MobileDetectResponse> MobileDetectAsync(MobileDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online status of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineStatusResponse
        /// </returns>
        public MobileOnlineStatusResponse MobileOnlineStatusWithOptions(MobileOnlineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileOnlineStatus",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileOnlineStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online status of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineStatusResponse
        /// </returns>
        public async Task<MobileOnlineStatusResponse> MobileOnlineStatusWithOptionsAsync(MobileOnlineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileOnlineStatus",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileOnlineStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online status of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineStatusResponse
        /// </returns>
        public MobileOnlineStatusResponse MobileOnlineStatus(MobileOnlineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileOnlineStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online status of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineStatusResponse
        /// </returns>
        public async Task<MobileOnlineStatusResponse> MobileOnlineStatusAsync(MobileOnlineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileOnlineStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online duration of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineTimeResponse
        /// </returns>
        public MobileOnlineTimeResponse MobileOnlineTimeWithOptions(MobileOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileOnlineTime",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileOnlineTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online duration of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineTimeResponse
        /// </returns>
        public async Task<MobileOnlineTimeResponse> MobileOnlineTimeWithOptionsAsync(MobileOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MobileOnlineTime",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MobileOnlineTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online duration of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineTimeResponse
        /// </returns>
        public MobileOnlineTimeResponse MobileOnlineTime(MobileOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileOnlineTimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the online duration of a mobile number</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MobileOnlineTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// MobileOnlineTimeResponse
        /// </returns>
        public async Task<MobileOnlineTimeResponse> MobileOnlineTimeAsync(MobileOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileOnlineTimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call ModifyDeviceInfo to update device-related information, such as extending the device authorization validity period, updating the business party\&quot;s custom business identifier, and device ID. Suitable for scenarios like renewing the device validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDeviceInfoResponse
        /// </returns>
        public ModifyDeviceInfoResponse ModifyDeviceInfoWithOptions(ModifyDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredDay))
            {
                query["ExpiredDay"] = request.ExpiredDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeviceId))
            {
                query["UserDeviceId"] = request.UserDeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDeviceInfo",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call ModifyDeviceInfo to update device-related information, such as extending the device authorization validity period, updating the business party\&quot;s custom business identifier, and device ID. Suitable for scenarios like renewing the device validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDeviceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDeviceInfoResponse
        /// </returns>
        public async Task<ModifyDeviceInfoResponse> ModifyDeviceInfoWithOptionsAsync(ModifyDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredDay))
            {
                query["ExpiredDay"] = request.ExpiredDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeviceId))
            {
                query["UserDeviceId"] = request.UserDeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDeviceInfo",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call ModifyDeviceInfo to update device-related information, such as extending the device authorization validity period, updating the business party\&quot;s custom business identifier, and device ID. Suitable for scenarios like renewing the device validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDeviceInfoResponse
        /// </returns>
        public ModifyDeviceInfoResponse ModifyDeviceInfo(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call ModifyDeviceInfo to update device-related information, such as extending the device authorization validity period, updating the business party\&quot;s custom business identifier, and device ID. Suitable for scenarios like renewing the device validity period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request Method: Supports sending requests using HTTPS POST and GET methods.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDeviceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDeviceInfoResponse
        /// </returns>
        public async Task<ModifyDeviceInfoResponse> ModifyDeviceInfoAsync(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Paging Query for Real Person Whitelist Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageQueryWhiteListSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageQueryWhiteListSettingResponse
        /// </returns>
        public PageQueryWhiteListSettingResponse PageQueryWhiteListSettingWithOptions(PageQueryWhiteListSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidEndDate))
            {
                query["ValidEndDate"] = request.ValidEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidStartDate))
            {
                query["ValidStartDate"] = request.ValidStartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageQueryWhiteListSetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageQueryWhiteListSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Paging Query for Real Person Whitelist Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageQueryWhiteListSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageQueryWhiteListSettingResponse
        /// </returns>
        public async Task<PageQueryWhiteListSettingResponse> PageQueryWhiteListSettingWithOptionsAsync(PageQueryWhiteListSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidEndDate))
            {
                query["ValidEndDate"] = request.ValidEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidStartDate))
            {
                query["ValidStartDate"] = request.ValidStartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageQueryWhiteListSetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageQueryWhiteListSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Paging Query for Real Person Whitelist Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageQueryWhiteListSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// PageQueryWhiteListSettingResponse
        /// </returns>
        public PageQueryWhiteListSettingResponse PageQueryWhiteListSetting(PageQueryWhiteListSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageQueryWhiteListSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Paging Query for Real Person Whitelist Configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageQueryWhiteListSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// PageQueryWhiteListSettingResponse
        /// </returns>
        public async Task<PageQueryWhiteListSettingResponse> PageQueryWhiteListSettingAsync(PageQueryWhiteListSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageQueryWhiteListSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveWhiteListSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveWhiteListSettingResponse
        /// </returns>
        public RemoveWhiteListSettingResponse RemoveWhiteListSettingWithOptions(RemoveWhiteListSettingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveWhiteListSettingShrinkRequest request = new RemoveWhiteListSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ids))
            {
                request.IdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ids, "Ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdsShrink))
            {
                query["Ids"] = request.IdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWhiteListSetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveWhiteListSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveWhiteListSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveWhiteListSettingResponse
        /// </returns>
        public async Task<RemoveWhiteListSettingResponse> RemoveWhiteListSettingWithOptionsAsync(RemoveWhiteListSettingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveWhiteListSettingShrinkRequest request = new RemoveWhiteListSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ids))
            {
                request.IdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ids, "Ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdsShrink))
            {
                query["Ids"] = request.IdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWhiteListSetting",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveWhiteListSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveWhiteListSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveWhiteListSettingResponse
        /// </returns>
        public RemoveWhiteListSettingResponse RemoveWhiteListSetting(RemoveWhiteListSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveWhiteListSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Real Person Whitelist</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveWhiteListSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveWhiteListSettingResponse
        /// </returns>
        public async Task<RemoveWhiteListSettingResponse> RemoveWhiteListSettingAsync(RemoveWhiteListSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveWhiteListSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Five-Item Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query basic vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Vehicle5ItemQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Vehicle5ItemQueryResponse
        /// </returns>
        public Vehicle5ItemQueryResponse Vehicle5ItemQueryWithOptions(Vehicle5ItemQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Vehicle5ItemQuery",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Vehicle5ItemQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Five-Item Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query basic vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Vehicle5ItemQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Vehicle5ItemQueryResponse
        /// </returns>
        public async Task<Vehicle5ItemQueryResponse> Vehicle5ItemQueryWithOptionsAsync(Vehicle5ItemQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Vehicle5ItemQuery",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Vehicle5ItemQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Five-Item Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query basic vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Vehicle5ItemQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// Vehicle5ItemQueryResponse
        /// </returns>
        public Vehicle5ItemQueryResponse Vehicle5ItemQuery(Vehicle5ItemQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Vehicle5ItemQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Five-Item Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query basic vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// Vehicle5ItemQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// Vehicle5ItemQueryResponse
        /// </returns>
        public async Task<Vehicle5ItemQueryResponse> Vehicle5ItemQueryAsync(Vehicle5ItemQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Vehicle5ItemQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Insurance Date Inquiry</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the vehicle insurance date through the license plate number, vehicle type, and vehicle identification number (VIN).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleInsureQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleInsureQueryResponse
        /// </returns>
        public VehicleInsureQueryResponse VehicleInsureQueryWithOptions(VehicleInsureQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vin))
            {
                query["Vin"] = request.Vin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleInsureQuery",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleInsureQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Insurance Date Inquiry</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the vehicle insurance date through the license plate number, vehicle type, and vehicle identification number (VIN).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleInsureQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleInsureQueryResponse
        /// </returns>
        public async Task<VehicleInsureQueryResponse> VehicleInsureQueryWithOptionsAsync(VehicleInsureQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vin))
            {
                query["Vin"] = request.Vin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleInsureQuery",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleInsureQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Insurance Date Inquiry</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the vehicle insurance date through the license plate number, vehicle type, and vehicle identification number (VIN).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleInsureQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// VehicleInsureQueryResponse
        /// </returns>
        public VehicleInsureQueryResponse VehicleInsureQuery(VehicleInsureQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleInsureQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Insurance Date Inquiry</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the vehicle insurance date through the license plate number, vehicle type, and vehicle identification number (VIN).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleInsureQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// VehicleInsureQueryResponse
        /// </returns>
        public async Task<VehicleInsureQueryResponse> VehicleInsureQueryAsync(VehicleInsureQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleInsureQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, vehicle license plate, and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyResponse
        /// </returns>
        public VehicleMetaVerifyResponse VehicleMetaVerifyWithOptions(VehicleMetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMetaType))
            {
                query["VerifyMetaType"] = request.VerifyMetaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleMetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleMetaVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, vehicle license plate, and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyResponse
        /// </returns>
        public async Task<VehicleMetaVerifyResponse> VehicleMetaVerifyWithOptionsAsync(VehicleMetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMetaType))
            {
                query["VerifyMetaType"] = request.VerifyMetaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleMetaVerify",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleMetaVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, vehicle license plate, and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyResponse
        /// </returns>
        public VehicleMetaVerifyResponse VehicleMetaVerify(VehicleMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleMetaVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, vehicle license plate, and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyResponse
        /// </returns>
        public async Task<VehicleMetaVerifyResponse> VehicleMetaVerifyAsync(VehicleMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleMetaVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, license plate number, and vehicle type, and supports returning detailed vehicle information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyV2Response
        /// </returns>
        public VehicleMetaVerifyV2Response VehicleMetaVerifyV2WithOptions(VehicleMetaVerifyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMetaType))
            {
                query["VerifyMetaType"] = request.VerifyMetaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleMetaVerifyV2",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleMetaVerifyV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, license plate number, and vehicle type, and supports returning detailed vehicle information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyV2Response
        /// </returns>
        public async Task<VehicleMetaVerifyV2Response> VehicleMetaVerifyV2WithOptionsAsync(VehicleMetaVerifyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMetaType))
            {
                query["VerifyMetaType"] = request.VerifyMetaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleMetaVerifyV2",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleMetaVerifyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, license plate number, and vehicle type, and supports returning detailed vehicle information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyV2Response
        /// </returns>
        public VehicleMetaVerifyV2Response VehicleMetaVerifyV2(VehicleMetaVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleMetaVerifyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enhanced Vehicle Element Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verifies the consistency of name, ID number, license plate number, and vehicle type, and supports returning detailed vehicle information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleMetaVerifyV2Request
        /// </param>
        /// 
        /// <returns>
        /// VehicleMetaVerifyV2Response
        /// </returns>
        public async Task<VehicleMetaVerifyV2Response> VehicleMetaVerifyV2Async(VehicleMetaVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleMetaVerifyV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query detailed vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleQueryResponse
        /// </returns>
        public VehicleQueryResponse VehicleQueryWithOptions(VehicleQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleQuery",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query detailed vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VehicleQueryResponse
        /// </returns>
        public async Task<VehicleQueryResponse> VehicleQueryWithOptionsAsync(VehicleQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleNum))
            {
                query["VehicleNum"] = request.VehicleNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VehicleType))
            {
                query["VehicleType"] = request.VehicleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VehicleQuery",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VehicleQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query detailed vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// VehicleQueryResponse
        /// </returns>
        public VehicleQueryResponse VehicleQuery(VehicleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Vehicle Information Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query detailed vehicle information through the license plate number and vehicle type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VehicleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// VehicleQueryResponse
        /// </returns>
        public async Task<VehicleQueryResponse> VehicleQueryAsync(VehicleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call VerifyMaterial, in a pure server-side access authentication solution, input name, ID number, portrait photo, and front and back photos of the ID card (optional) for real-person authentication, and return the authentication result synchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparatory work has been completed. For details, please refer to <a href="https://help.aliyun.com/document_detail/127471.html">Server-side Access Preparation</a>.
        /// Request Method: HTTPS POST and GET.
        /// API Description: The server of the access party submits the authentication materials to the real-person authentication service for verification and comparison, with the results returned synchronously.
        /// Applicable Scope: This interface is only applicable to pure server-side access authentication solutions.
        /// Image Upload Address Explanation:</para>
        /// <list type="bullet">
        /// <item><description>HTTP or HTTPS address: Supports publicly accessible HTTP or HTTPS addresses. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>OSS address: If the images from the access party are local files, Alibaba Cloud also provides an upload SDK, supporting the business party to upload the images to the specified OSS bucket of the real-person authentication service, and use the obtained OSS address as the image address parameter in the interface. If your business needs to use the upload SDK, please submit a <a href="https://selfservice.console.aliyun.com/ticket/category/cloudauth/today">ticket</a> to contact us for acquisition.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image should be at least 64*64 pixels.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request, and do not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyMaterialResponse
        /// </returns>
        public VerifyMaterialResponse VerifyMaterialWithOptions(VerifyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceImageUrl))
            {
                query["FaceImageUrl"] = request.FaceImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardBackImageUrl))
            {
                query["IdCardBackImageUrl"] = request.IdCardBackImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardFrontImageUrl))
            {
                query["IdCardFrontImageUrl"] = request.IdCardFrontImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMaterial",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMaterialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call VerifyMaterial, in a pure server-side access authentication solution, input name, ID number, portrait photo, and front and back photos of the ID card (optional) for real-person authentication, and return the authentication result synchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparatory work has been completed. For details, please refer to <a href="https://help.aliyun.com/document_detail/127471.html">Server-side Access Preparation</a>.
        /// Request Method: HTTPS POST and GET.
        /// API Description: The server of the access party submits the authentication materials to the real-person authentication service for verification and comparison, with the results returned synchronously.
        /// Applicable Scope: This interface is only applicable to pure server-side access authentication solutions.
        /// Image Upload Address Explanation:</para>
        /// <list type="bullet">
        /// <item><description>HTTP or HTTPS address: Supports publicly accessible HTTP or HTTPS addresses. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>OSS address: If the images from the access party are local files, Alibaba Cloud also provides an upload SDK, supporting the business party to upload the images to the specified OSS bucket of the real-person authentication service, and use the obtained OSS address as the image address parameter in the interface. If your business needs to use the upload SDK, please submit a <a href="https://selfservice.console.aliyun.com/ticket/category/cloudauth/today">ticket</a> to contact us for acquisition.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image should be at least 64*64 pixels.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request, and do not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyMaterialResponse
        /// </returns>
        public async Task<VerifyMaterialResponse> VerifyMaterialWithOptionsAsync(VerifyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceImageUrl))
            {
                query["FaceImageUrl"] = request.FaceImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardBackImageUrl))
            {
                query["IdCardBackImageUrl"] = request.IdCardBackImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardFrontImageUrl))
            {
                query["IdCardFrontImageUrl"] = request.IdCardFrontImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNumber))
            {
                query["IdCardNumber"] = request.IdCardNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMaterial",
                Version = "2019-03-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call VerifyMaterial, in a pure server-side access authentication solution, input name, ID number, portrait photo, and front and back photos of the ID card (optional) for real-person authentication, and return the authentication result synchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparatory work has been completed. For details, please refer to <a href="https://help.aliyun.com/document_detail/127471.html">Server-side Access Preparation</a>.
        /// Request Method: HTTPS POST and GET.
        /// API Description: The server of the access party submits the authentication materials to the real-person authentication service for verification and comparison, with the results returned synchronously.
        /// Applicable Scope: This interface is only applicable to pure server-side access authentication solutions.
        /// Image Upload Address Explanation:</para>
        /// <list type="bullet">
        /// <item><description>HTTP or HTTPS address: Supports publicly accessible HTTP or HTTPS addresses. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>OSS address: If the images from the access party are local files, Alibaba Cloud also provides an upload SDK, supporting the business party to upload the images to the specified OSS bucket of the real-person authentication service, and use the obtained OSS address as the image address parameter in the interface. If your business needs to use the upload SDK, please submit a <a href="https://selfservice.console.aliyun.com/ticket/category/cloudauth/today">ticket</a> to contact us for acquisition.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image should be at least 64*64 pixels.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request, and do not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyMaterialResponse
        /// </returns>
        public VerifyMaterialResponse VerifyMaterial(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMaterialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call VerifyMaterial, in a pure server-side access authentication solution, input name, ID number, portrait photo, and front and back photos of the ID card (optional) for real-person authentication, and return the authentication result synchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Preparation for Access: When integrating this API, please ensure that the corresponding preparatory work has been completed. For details, please refer to <a href="https://help.aliyun.com/document_detail/127471.html">Server-side Access Preparation</a>.
        /// Request Method: HTTPS POST and GET.
        /// API Description: The server of the access party submits the authentication materials to the real-person authentication service for verification and comparison, with the results returned synchronously.
        /// Applicable Scope: This interface is only applicable to pure server-side access authentication solutions.
        /// Image Upload Address Explanation:</para>
        /// <list type="bullet">
        /// <item><description>HTTP or HTTPS address: Supports publicly accessible HTTP or HTTPS addresses. For example, <c>http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</c>.</description></item>
        /// <item><description>OSS address: If the images from the access party are local files, Alibaba Cloud also provides an upload SDK, supporting the business party to upload the images to the specified OSS bucket of the real-person authentication service, and use the obtained OSS address as the image address parameter in the interface. If your business needs to use the upload SDK, please submit a <a href="https://selfservice.console.aliyun.com/ticket/category/cloudauth/today">ticket</a> to contact us for acquisition.
        /// Image Limitations:</description></item>
        /// <item><description>Does not support relative or absolute paths of local images.</description></item>
        /// <item><description>Please keep the size of a single image within 2 MB to avoid algorithm retrieval timeout.</description></item>
        /// <item><description>The face area in the image should be at least 64*64 pixels.</description></item>
        /// <item><description>There is an 8 MB size limit for the Body of a single request. Please calculate the total size of all images and other information in the request, and do not exceed the limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyMaterialResponse
        /// </returns>
        public async Task<VerifyMaterialResponse> VerifyMaterialAsync(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMaterialWithOptionsAsync(request, runtime);
        }

    }
}
