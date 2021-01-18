// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Facebody20200910.Models;

namespace AlibabaCloud.SDK.Facebody20200910
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("facebody", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * 行人检测快速版
         */
        public DetectIPCPedestrianOptimizedResponse DetectIPCPedestrianOptimized(DetectIPCPedestrianOptimizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DetectIPCPedestrianOptimizedWithOptions(request, headers, runtime);
        }

        /**
         * 行人检测快速版
         */
        public async Task<DetectIPCPedestrianOptimizedResponse> DetectIPCPedestrianOptimizedAsync(DetectIPCPedestrianOptimizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DetectIPCPedestrianOptimizedWithOptionsAsync(request, headers, runtime);
        }

        public DetectIPCPedestrianOptimizedResponse DetectIPCPedestrianOptimizedWithOptions(DetectIPCPedestrianOptimizedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageData))
            {
                body["imageData"] = request.ImageData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DetectIPCPedestrianOptimizedResponse>(DoROARequestWithForm("DetectIPCPedestrianOptimized", "2020-09-10", "HTTPS", "POST", "AK", "/viapi/k8s/facebody/detect-ipc-pedestrian-optimized", "json", req, runtime));
        }

        public async Task<DetectIPCPedestrianOptimizedResponse> DetectIPCPedestrianOptimizedWithOptionsAsync(DetectIPCPedestrianOptimizedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageData))
            {
                body["imageData"] = request.ImageData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DetectIPCPedestrianOptimizedResponse>(await DoROARequestWithFormAsync("DetectIPCPedestrianOptimized", "2020-09-10", "HTTPS", "POST", "AK", "/viapi/k8s/facebody/detect-ipc-pedestrian-optimized", "json", req, runtime));
        }

        public ExecuteServerSideVerificationResponse ExecuteServerSideVerification(ExecuteServerSideVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteServerSideVerificationWithOptions(request, headers, runtime);
        }

        public async Task<ExecuteServerSideVerificationResponse> ExecuteServerSideVerificationAsync(ExecuteServerSideVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteServerSideVerificationWithOptionsAsync(request, headers, runtime);
        }

        public ExecuteServerSideVerificationResponse ExecuteServerSideVerificationWithOptions(ExecuteServerSideVerificationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateName))
            {
                body["certificateName"] = request.CertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateNumber))
            {
                body["certificateNumber"] = request.CertificateNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacialPictureData))
            {
                body["facialPictureData"] = request.FacialPictureData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacialPictureUrl))
            {
                body["facialPictureUrl"] = request.FacialPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["sceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ExecuteServerSideVerificationResponse>(DoROARequestWithForm("ExecuteServerSideVerification", "2020-09-10", "HTTPS", "POST", "AK", "/viapi/thirdparty/realperson/execServerSideVerification", "json", req, runtime));
        }

        public async Task<ExecuteServerSideVerificationResponse> ExecuteServerSideVerificationWithOptionsAsync(ExecuteServerSideVerificationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateName))
            {
                body["certificateName"] = request.CertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateNumber))
            {
                body["certificateNumber"] = request.CertificateNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacialPictureData))
            {
                body["facialPictureData"] = request.FacialPictureData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacialPictureUrl))
            {
                body["facialPictureUrl"] = request.FacialPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["sceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ExecuteServerSideVerificationResponse>(await DoROARequestWithFormAsync("ExecuteServerSideVerification", "2020-09-10", "HTTPS", "POST", "AK", "/viapi/thirdparty/realperson/execServerSideVerification", "json", req, runtime));
        }

    }
}
