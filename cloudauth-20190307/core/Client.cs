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

        /**
         * @summary 新增AIGC人脸检测能力
         *
         * @param request AIGCFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AIGCFaceVerifyResponse
         */
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

        /**
         * @summary 新增AIGC人脸检测能力
         *
         * @param request AIGCFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AIGCFaceVerifyResponse
         */
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

        /**
         * @summary 新增AIGC人脸检测能力
         *
         * @param request AIGCFaceVerifyRequest
         * @return AIGCFaceVerifyResponse
         */
        public AIGCFaceVerifyResponse AIGCFaceVerify(AIGCFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AIGCFaceVerifyWithOptions(request, runtime);
        }

        /**
         * @summary 新增AIGC人脸检测能力
         *
         * @param request AIGCFaceVerifyRequest
         * @return AIGCFaceVerifyResponse
         */
        public async Task<AIGCFaceVerifyResponse> AIGCFaceVerifyAsync(AIGCFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AIGCFaceVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 银行卡要素核验接口
         *
         * @param request BankMetaVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BankMetaVerifyResponse
         */
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

        /**
         * @summary 银行卡要素核验接口
         *
         * @param request BankMetaVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BankMetaVerifyResponse
         */
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

        /**
         * @summary 银行卡要素核验接口
         *
         * @param request BankMetaVerifyRequest
         * @return BankMetaVerifyResponse
         */
        public BankMetaVerifyResponse BankMetaVerify(BankMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BankMetaVerifyWithOptions(request, runtime);
        }

        /**
         * @summary 银行卡要素核验接口
         *
         * @param request BankMetaVerifyRequest
         * @return BankMetaVerifyResponse
         */
        public async Task<BankMetaVerifyResponse> BankMetaVerifyAsync(BankMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BankMetaVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CompareFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompareFaceVerifyResponse
         */
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

        /**
         * @param request CompareFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompareFaceVerifyResponse
         */
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

        /**
         * @param request CompareFaceVerifyRequest
         * @return CompareFaceVerifyResponse
         */
        public CompareFaceVerifyResponse CompareFaceVerify(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFaceVerifyWithOptions(request, runtime);
        }

        /**
         * @param request CompareFaceVerifyRequest
         * @return CompareFaceVerifyResponse
         */
        public async Task<CompareFaceVerifyResponse> CompareFaceVerifyAsync(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFaceVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CompareFacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompareFacesResponse
         */
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

        /**
         * @param request CompareFacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompareFacesResponse
         */
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

        /**
         * @param request CompareFacesRequest
         * @return CompareFacesResponse
         */
        public CompareFacesResponse CompareFaces(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFacesWithOptions(request, runtime);
        }

        /**
         * @param request CompareFacesRequest
         * @return CompareFacesResponse
         */
        public async Task<CompareFacesResponse> CompareFacesAsync(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFacesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ContrastFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContrastFaceVerifyResponse
         */
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

        /**
         * @param request ContrastFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContrastFaceVerifyResponse
         */
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

        /**
         * @param request ContrastFaceVerifyRequest
         * @return ContrastFaceVerifyResponse
         */
        public ContrastFaceVerifyResponse ContrastFaceVerify(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContrastFaceVerifyWithOptions(request, runtime);
        }

        /**
         * @param request ContrastFaceVerifyRequest
         * @return ContrastFaceVerifyResponse
         */
        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAsync(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContrastFaceVerifyWithOptionsAsync(request, runtime);
        }

        public ContrastFaceVerifyResponse ContrastFaceVerifyAdvance(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Product = "Cloudauth",
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
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FaceContrastFileObject,
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
                contrastFaceVerifyReq.FaceContrastFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ContrastFaceVerifyResponse contrastFaceVerifyResp = ContrastFaceVerifyWithOptions(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAdvanceAsync(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Product = "Cloudauth",
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
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FaceContrastFileObject,
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
                contrastFaceVerifyReq.FaceContrastFile = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            ContrastFaceVerifyResponse contrastFaceVerifyResp = await ContrastFaceVerifyWithOptionsAsync(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        /**
         * @param request CreateAuthKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuthKeyResponse
         */
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

        /**
         * @param request CreateAuthKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuthKeyResponse
         */
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

        /**
         * @param request CreateAuthKeyRequest
         * @return CreateAuthKeyResponse
         */
        public CreateAuthKeyResponse CreateAuthKey(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthKeyWithOptions(request, runtime);
        }

        /**
         * @param request CreateAuthKeyRequest
         * @return CreateAuthKeyResponse
         */
        public async Task<CreateAuthKeyResponse> CreateAuthKeyAsync(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateVerifySettingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVerifySettingResponse
         */
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

        /**
         * @param request CreateVerifySettingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVerifySettingResponse
         */
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

        /**
         * @param request CreateVerifySettingRequest
         * @return CreateVerifySettingResponse
         */
        public CreateVerifySettingResponse CreateVerifySetting(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySettingWithOptions(request, runtime);
        }

        /**
         * @param request CreateVerifySettingRequest
         * @return CreateVerifySettingResponse
         */
        public async Task<CreateVerifySettingResponse> CreateVerifySettingAsync(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySettingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 凭证核验
         *
         * @param request CredentialVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CredentialVerifyResponse
         */
        public CredentialVerifyResponse CredentialVerifyWithOptions(CredentialVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
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

        /**
         * @summary 凭证核验
         *
         * @param request CredentialVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CredentialVerifyResponse
         */
        public async Task<CredentialVerifyResponse> CredentialVerifyWithOptionsAsync(CredentialVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                query["MerchantId"] = request.MerchantId;
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

        /**
         * @summary 凭证核验
         *
         * @param request CredentialVerifyRequest
         * @return CredentialVerifyResponse
         */
        public CredentialVerifyResponse CredentialVerify(CredentialVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialVerifyWithOptions(request, runtime);
        }

        /**
         * @summary 凭证核验
         *
         * @param request CredentialVerifyRequest
         * @return CredentialVerifyResponse
         */
        public async Task<CredentialVerifyResponse> CredentialVerifyAsync(CredentialVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 人脸凭证核验服务
         *
         * @param request DeepfakeDetectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeepfakeDetectResponse
         */
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

        /**
         * @summary 人脸凭证核验服务
         *
         * @param request DeepfakeDetectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeepfakeDetectResponse
         */
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

        /**
         * @summary 人脸凭证核验服务
         *
         * @param request DeepfakeDetectRequest
         * @return DeepfakeDetectResponse
         */
        public DeepfakeDetectResponse DeepfakeDetect(DeepfakeDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeepfakeDetectWithOptions(request, runtime);
        }

        /**
         * @summary 人脸凭证核验服务
         *
         * @param request DeepfakeDetectRequest
         * @return DeepfakeDetectResponse
         */
        public async Task<DeepfakeDetectResponse> DeepfakeDetectAsync(DeepfakeDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeepfakeDetectWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDeviceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeviceInfoResponse
         */
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

        /**
         * @param request DescribeDeviceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeviceInfoResponse
         */
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

        /**
         * @param request DescribeDeviceInfoRequest
         * @return DescribeDeviceInfoResponse
         */
        public DescribeDeviceInfoResponse DescribeDeviceInfo(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceInfoWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDeviceInfoRequest
         * @return DescribeDeviceInfoResponse
         */
        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoAsync(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaceVerifyResponse
         */
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

        /**
         * @param request DescribeFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFaceVerifyResponse
         */
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

        /**
         * @param request DescribeFaceVerifyRequest
         * @return DescribeFaceVerifyResponse
         */
        public DescribeFaceVerifyResponse DescribeFaceVerify(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceVerifyWithOptions(request, runtime);
        }

        /**
         * @param request DescribeFaceVerifyRequest
         * @return DescribeFaceVerifyResponse
         */
        public async Task<DescribeFaceVerifyResponse> DescribeFaceVerifyAsync(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeOssUploadTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssUploadTokenResponse
         */
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

        /**
         * @param request DescribeOssUploadTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssUploadTokenResponse
         */
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

        /**
         * @return DescribeOssUploadTokenResponse
         */
        public DescribeOssUploadTokenResponse DescribeOssUploadToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssUploadTokenWithOptions(runtime);
        }

        /**
         * @return DescribeOssUploadTokenResponse
         */
        public async Task<DescribeOssUploadTokenResponse> DescribeOssUploadTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssUploadTokenWithOptionsAsync(runtime);
        }

        /**
         * @summary Open API新增金融级数据统计API
         *
         * @param request DescribePageFaceVerifyDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePageFaceVerifyDataResponse
         */
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

        /**
         * @summary Open API新增金融级数据统计API
         *
         * @param request DescribePageFaceVerifyDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePageFaceVerifyDataResponse
         */
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

        /**
         * @summary Open API新增金融级数据统计API
         *
         * @param request DescribePageFaceVerifyDataRequest
         * @return DescribePageFaceVerifyDataResponse
         */
        public DescribePageFaceVerifyDataResponse DescribePageFaceVerifyData(DescribePageFaceVerifyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePageFaceVerifyDataWithOptions(request, runtime);
        }

        /**
         * @summary Open API新增金融级数据统计API
         *
         * @param request DescribePageFaceVerifyDataRequest
         * @return DescribePageFaceVerifyDataResponse
         */
        public async Task<DescribePageFaceVerifyDataResponse> DescribePageFaceVerifyDataAsync(DescribePageFaceVerifyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePageFaceVerifyDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeSmartStatisticsPageListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSmartStatisticsPageListResponse
         */
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

        /**
         * @param request DescribeSmartStatisticsPageListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSmartStatisticsPageListResponse
         */
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

        /**
         * @param request DescribeSmartStatisticsPageListRequest
         * @return DescribeSmartStatisticsPageListResponse
         */
        public DescribeSmartStatisticsPageListResponse DescribeSmartStatisticsPageList(DescribeSmartStatisticsPageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartStatisticsPageListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeSmartStatisticsPageListRequest
         * @return DescribeSmartStatisticsPageListResponse
         */
        public async Task<DescribeSmartStatisticsPageListResponse> DescribeSmartStatisticsPageListAsync(DescribeSmartStatisticsPageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartStatisticsPageListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeVerifyResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVerifyResultResponse
         */
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

        /**
         * @param request DescribeVerifyResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVerifyResultResponse
         */
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

        /**
         * @param request DescribeVerifyResultRequest
         * @return DescribeVerifyResultResponse
         */
        public DescribeVerifyResultResponse DescribeVerifyResult(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyResultWithOptions(request, runtime);
        }

        /**
         * @param request DescribeVerifyResultRequest
         * @return DescribeVerifyResultResponse
         */
        public async Task<DescribeVerifyResultResponse> DescribeVerifyResultAsync(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyResultWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeVerifySDKRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVerifySDKResponse
         */
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

        /**
         * @param request DescribeVerifySDKRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVerifySDKResponse
         */
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

        /**
         * @param request DescribeVerifySDKRequest
         * @return DescribeVerifySDKResponse
         */
        public DescribeVerifySDKResponse DescribeVerifySDK(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySDKWithOptions(request, runtime);
        }

        /**
         * @param request DescribeVerifySDKRequest
         * @return DescribeVerifySDKResponse
         */
        public async Task<DescribeVerifySDKResponse> DescribeVerifySDKAsync(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySDKWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeVerifyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVerifyTokenResponse
         */
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

        /**
         * @param request DescribeVerifyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVerifyTokenResponse
         */
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

        /**
         * @param request DescribeVerifyTokenRequest
         * @return DescribeVerifyTokenResponse
         */
        public DescribeVerifyTokenResponse DescribeVerifyToken(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyTokenWithOptions(request, runtime);
        }

        /**
         * @param request DescribeVerifyTokenRequest
         * @return DescribeVerifyTokenResponse
         */
        public async Task<DescribeVerifyTokenResponse> DescribeVerifyTokenAsync(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DetectFaceAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectFaceAttributesResponse
         */
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

        /**
         * @param request DetectFaceAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectFaceAttributesResponse
         */
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

        /**
         * @param request DetectFaceAttributesRequest
         * @return DetectFaceAttributesResponse
         */
        public DetectFaceAttributesResponse DetectFaceAttributes(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectFaceAttributesWithOptions(request, runtime);
        }

        /**
         * @param request DetectFaceAttributesRequest
         * @return DetectFaceAttributesResponse
         */
        public async Task<DetectFaceAttributesResponse> DetectFaceAttributesAsync(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectFaceAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 身份二要素接口
         *
         * @param request Id2MetaVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Id2MetaVerifyResponse
         */
        public Id2MetaVerifyResponse Id2MetaVerifyWithOptions(Id2MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 身份二要素接口
         *
         * @param request Id2MetaVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Id2MetaVerifyResponse
         */
        public async Task<Id2MetaVerifyResponse> Id2MetaVerifyWithOptionsAsync(Id2MetaVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 身份二要素接口
         *
         * @param request Id2MetaVerifyRequest
         * @return Id2MetaVerifyResponse
         */
        public Id2MetaVerifyResponse Id2MetaVerify(Id2MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaVerifyWithOptions(request, runtime);
        }

        /**
         * @summary 身份二要素接口
         *
         * @param request Id2MetaVerifyRequest
         * @return Id2MetaVerifyResponse
         */
        public async Task<Id2MetaVerifyResponse> Id2MetaVerifyAsync(Id2MetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request InitFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InitFaceVerifyResponse
         */
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

        /**
         * @param request InitFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InitFaceVerifyResponse
         */
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

        /**
         * @param request InitFaceVerifyRequest
         * @return InitFaceVerifyResponse
         */
        public InitFaceVerifyResponse InitFaceVerify(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitFaceVerifyWithOptions(request, runtime);
        }

        /**
         * @param request InitFaceVerifyRequest
         * @return InitFaceVerifyResponse
         */
        public async Task<InitFaceVerifyResponse> InitFaceVerifyAsync(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitFaceVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request LivenessFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LivenessFaceVerifyResponse
         */
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

        /**
         * @param request LivenessFaceVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LivenessFaceVerifyResponse
         */
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

        /**
         * @param request LivenessFaceVerifyRequest
         * @return LivenessFaceVerifyResponse
         */
        public LivenessFaceVerifyResponse LivenessFaceVerify(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LivenessFaceVerifyWithOptions(request, runtime);
        }

        /**
         * @param request LivenessFaceVerifyRequest
         * @return LivenessFaceVerifyResponse
         */
        public async Task<LivenessFaceVerifyResponse> LivenessFaceVerifyAsync(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LivenessFaceVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 手机三要素详版接口
         *
         * @param request Mobile3MetaDetailVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Mobile3MetaDetailVerifyResponse
         */
        public Mobile3MetaDetailVerifyResponse Mobile3MetaDetailVerifyWithOptions(Mobile3MetaDetailVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 手机三要素详版接口
         *
         * @param request Mobile3MetaDetailVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Mobile3MetaDetailVerifyResponse
         */
        public async Task<Mobile3MetaDetailVerifyResponse> Mobile3MetaDetailVerifyWithOptionsAsync(Mobile3MetaDetailVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 手机三要素详版接口
         *
         * @param request Mobile3MetaDetailVerifyRequest
         * @return Mobile3MetaDetailVerifyResponse
         */
        public Mobile3MetaDetailVerifyResponse Mobile3MetaDetailVerify(Mobile3MetaDetailVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaDetailVerifyWithOptions(request, runtime);
        }

        /**
         * @summary 手机三要素详版接口
         *
         * @param request Mobile3MetaDetailVerifyRequest
         * @return Mobile3MetaDetailVerifyResponse
         */
        public async Task<Mobile3MetaDetailVerifyResponse> Mobile3MetaDetailVerifyAsync(Mobile3MetaDetailVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaDetailVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 手机号三要素简版接口
         *
         * @param request Mobile3MetaSimpleVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Mobile3MetaSimpleVerifyResponse
         */
        public Mobile3MetaSimpleVerifyResponse Mobile3MetaSimpleVerifyWithOptions(Mobile3MetaSimpleVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 手机号三要素简版接口
         *
         * @param request Mobile3MetaSimpleVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Mobile3MetaSimpleVerifyResponse
         */
        public async Task<Mobile3MetaSimpleVerifyResponse> Mobile3MetaSimpleVerifyWithOptionsAsync(Mobile3MetaSimpleVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 手机号三要素简版接口
         *
         * @param request Mobile3MetaSimpleVerifyRequest
         * @return Mobile3MetaSimpleVerifyResponse
         */
        public Mobile3MetaSimpleVerifyResponse Mobile3MetaSimpleVerify(Mobile3MetaSimpleVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaSimpleVerifyWithOptions(request, runtime);
        }

        /**
         * @summary 手机号三要素简版接口
         *
         * @param request Mobile3MetaSimpleVerifyRequest
         * @return Mobile3MetaSimpleVerifyResponse
         */
        public async Task<Mobile3MetaSimpleVerifyResponse> Mobile3MetaSimpleVerifyAsync(Mobile3MetaSimpleVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaSimpleVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 号码检测
         *
         * @param request MobileDetectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MobileDetectResponse
         */
        public MobileDetectResponse MobileDetectWithOptions(MobileDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobiles))
            {
                query["Mobiles"] = request.Mobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 号码检测
         *
         * @param request MobileDetectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MobileDetectResponse
         */
        public async Task<MobileDetectResponse> MobileDetectWithOptionsAsync(MobileDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobiles))
            {
                query["Mobiles"] = request.Mobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 号码检测
         *
         * @param request MobileDetectRequest
         * @return MobileDetectResponse
         */
        public MobileDetectResponse MobileDetect(MobileDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileDetectWithOptions(request, runtime);
        }

        /**
         * @summary 号码检测
         *
         * @param request MobileDetectRequest
         * @return MobileDetectResponse
         */
        public async Task<MobileDetectResponse> MobileDetectAsync(MobileDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileDetectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询手机号在网状态
         *
         * @param request MobileOnlineStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MobileOnlineStatusResponse
         */
        public MobileOnlineStatusResponse MobileOnlineStatusWithOptions(MobileOnlineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 查询手机号在网状态
         *
         * @param request MobileOnlineStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MobileOnlineStatusResponse
         */
        public async Task<MobileOnlineStatusResponse> MobileOnlineStatusWithOptionsAsync(MobileOnlineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 查询手机号在网状态
         *
         * @param request MobileOnlineStatusRequest
         * @return MobileOnlineStatusResponse
         */
        public MobileOnlineStatusResponse MobileOnlineStatus(MobileOnlineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileOnlineStatusWithOptions(request, runtime);
        }

        /**
         * @summary 查询手机号在网状态
         *
         * @param request MobileOnlineStatusRequest
         * @return MobileOnlineStatusResponse
         */
        public async Task<MobileOnlineStatusResponse> MobileOnlineStatusAsync(MobileOnlineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileOnlineStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询手机号在网时长
         *
         * @param request MobileOnlineTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MobileOnlineTimeResponse
         */
        public MobileOnlineTimeResponse MobileOnlineTimeWithOptions(MobileOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 查询手机号在网时长
         *
         * @param request MobileOnlineTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MobileOnlineTimeResponse
         */
        public async Task<MobileOnlineTimeResponse> MobileOnlineTimeWithOptionsAsync(MobileOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary 查询手机号在网时长
         *
         * @param request MobileOnlineTimeRequest
         * @return MobileOnlineTimeResponse
         */
        public MobileOnlineTimeResponse MobileOnlineTime(MobileOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileOnlineTimeWithOptions(request, runtime);
        }

        /**
         * @summary 查询手机号在网时长
         *
         * @param request MobileOnlineTimeRequest
         * @return MobileOnlineTimeResponse
         */
        public async Task<MobileOnlineTimeResponse> MobileOnlineTimeAsync(MobileOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileOnlineTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyDeviceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDeviceInfoResponse
         */
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

        /**
         * @param request ModifyDeviceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDeviceInfoResponse
         */
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

        /**
         * @param request ModifyDeviceInfoRequest
         * @return ModifyDeviceInfoResponse
         */
        public ModifyDeviceInfoResponse ModifyDeviceInfo(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceInfoWithOptions(request, runtime);
        }

        /**
         * @param request ModifyDeviceInfoRequest
         * @return ModifyDeviceInfoResponse
         */
        public async Task<ModifyDeviceInfoResponse> ModifyDeviceInfoAsync(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车五项信息识别
         *
         * @param request Vehicle5ItemQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Vehicle5ItemQueryResponse
         */
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

        /**
         * @summary 车五项信息识别
         *
         * @param request Vehicle5ItemQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return Vehicle5ItemQueryResponse
         */
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

        /**
         * @summary 车五项信息识别
         *
         * @param request Vehicle5ItemQueryRequest
         * @return Vehicle5ItemQueryResponse
         */
        public Vehicle5ItemQueryResponse Vehicle5ItemQuery(Vehicle5ItemQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Vehicle5ItemQueryWithOptions(request, runtime);
        }

        /**
         * @summary 车五项信息识别
         *
         * @param request Vehicle5ItemQueryRequest
         * @return Vehicle5ItemQueryResponse
         */
        public async Task<Vehicle5ItemQueryResponse> Vehicle5ItemQueryAsync(Vehicle5ItemQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Vehicle5ItemQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车辆投保日期查询
         *
         * @param request VehicleInsureQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleInsureQueryResponse
         */
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

        /**
         * @summary 车辆投保日期查询
         *
         * @param request VehicleInsureQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleInsureQueryResponse
         */
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

        /**
         * @summary 车辆投保日期查询
         *
         * @param request VehicleInsureQueryRequest
         * @return VehicleInsureQueryResponse
         */
        public VehicleInsureQueryResponse VehicleInsureQuery(VehicleInsureQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleInsureQueryWithOptions(request, runtime);
        }

        /**
         * @summary 车辆投保日期查询
         *
         * @param request VehicleInsureQueryRequest
         * @return VehicleInsureQueryResponse
         */
        public async Task<VehicleInsureQueryResponse> VehicleInsureQueryAsync(VehicleInsureQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleInsureQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车辆要素核验
         *
         * @param request VehicleMetaVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleMetaVerifyResponse
         */
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

        /**
         * @summary 车辆要素核验
         *
         * @param request VehicleMetaVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleMetaVerifyResponse
         */
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

        /**
         * @summary 车辆要素核验
         *
         * @param request VehicleMetaVerifyRequest
         * @return VehicleMetaVerifyResponse
         */
        public VehicleMetaVerifyResponse VehicleMetaVerify(VehicleMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleMetaVerifyWithOptions(request, runtime);
        }

        /**
         * @summary 车辆要素核验
         *
         * @param request VehicleMetaVerifyRequest
         * @return VehicleMetaVerifyResponse
         */
        public async Task<VehicleMetaVerifyResponse> VehicleMetaVerifyAsync(VehicleMetaVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleMetaVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车辆要素核验增强版
         *
         * @param request VehicleMetaVerifyV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleMetaVerifyV2Response
         */
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

        /**
         * @summary 车辆要素核验增强版
         *
         * @param request VehicleMetaVerifyV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleMetaVerifyV2Response
         */
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

        /**
         * @summary 车辆要素核验增强版
         *
         * @param request VehicleMetaVerifyV2Request
         * @return VehicleMetaVerifyV2Response
         */
        public VehicleMetaVerifyV2Response VehicleMetaVerifyV2(VehicleMetaVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleMetaVerifyV2WithOptions(request, runtime);
        }

        /**
         * @summary 车辆要素核验增强版
         *
         * @param request VehicleMetaVerifyV2Request
         * @return VehicleMetaVerifyV2Response
         */
        public async Task<VehicleMetaVerifyV2Response> VehicleMetaVerifyV2Async(VehicleMetaVerifyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleMetaVerifyV2WithOptionsAsync(request, runtime);
        }

        /**
         * @summary 车辆信息识别
         *
         * @param request VehicleQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleQueryResponse
         */
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

        /**
         * @summary 车辆信息识别
         *
         * @param request VehicleQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VehicleQueryResponse
         */
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

        /**
         * @summary 车辆信息识别
         *
         * @param request VehicleQueryRequest
         * @return VehicleQueryResponse
         */
        public VehicleQueryResponse VehicleQuery(VehicleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VehicleQueryWithOptions(request, runtime);
        }

        /**
         * @summary 车辆信息识别
         *
         * @param request VehicleQueryRequest
         * @return VehicleQueryResponse
         */
        public async Task<VehicleQueryResponse> VehicleQueryAsync(VehicleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VehicleQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request VerifyMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyMaterialResponse
         */
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

        /**
         * @param request VerifyMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyMaterialResponse
         */
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

        /**
         * @param request VerifyMaterialRequest
         * @return VerifyMaterialResponse
         */
        public VerifyMaterialResponse VerifyMaterial(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMaterialWithOptions(request, runtime);
        }

        /**
         * @param request VerifyMaterialRequest
         * @return VerifyMaterialResponse
         */
        public async Task<VerifyMaterialResponse> VerifyMaterialAsync(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMaterialWithOptionsAsync(request, runtime);
        }

    }
}
