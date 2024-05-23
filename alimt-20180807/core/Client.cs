// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alimt20180807.Models;

namespace AlibabaCloud.SDK.Alimt20180807
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "mt.cn-hangzhou.aliyuncs.com"},
                {"ap-northeast-1", "mt.aliyuncs.com"},
                {"ap-northeast-2-pop", "mt.aliyuncs.com"},
                {"ap-south-1", "mt.aliyuncs.com"},
                {"ap-southeast-1", "mt.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "mt.aliyuncs.com"},
                {"ap-southeast-3", "mt.aliyuncs.com"},
                {"ap-southeast-5", "mt.aliyuncs.com"},
                {"cn-beijing", "mt.aliyuncs.com"},
                {"cn-beijing-finance-1", "mt.aliyuncs.com"},
                {"cn-beijing-finance-pop", "mt.aliyuncs.com"},
                {"cn-beijing-gov-1", "mt.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "mt.aliyuncs.com"},
                {"cn-chengdu", "mt.aliyuncs.com"},
                {"cn-edge-1", "mt.aliyuncs.com"},
                {"cn-fujian", "mt.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "mt.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "mt.aliyuncs.com"},
                {"cn-hangzhou-finance", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "mt.aliyuncs.com"},
                {"cn-hangzhou-test-306", "mt.aliyuncs.com"},
                {"cn-hongkong", "mt.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "mt.aliyuncs.com"},
                {"cn-huhehaote", "mt.aliyuncs.com"},
                {"cn-north-2-gov-1", "mt.aliyuncs.com"},
                {"cn-qingdao", "mt.aliyuncs.com"},
                {"cn-qingdao-nebula", "mt.aliyuncs.com"},
                {"cn-shanghai", "mt.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "mt.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "mt.aliyuncs.com"},
                {"cn-shanghai-finance-1", "mt.aliyuncs.com"},
                {"cn-shanghai-inner", "mt.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "mt.aliyuncs.com"},
                {"cn-shenzhen", "mt.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "mt.aliyuncs.com"},
                {"cn-shenzhen-inner", "mt.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "mt.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "mt.aliyuncs.com"},
                {"cn-wuhan", "mt.aliyuncs.com"},
                {"cn-yushanfang", "mt.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "mt.aliyuncs.com"},
                {"cn-zhangjiakou", "mt.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "mt.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "mt.aliyuncs.com"},
                {"eu-central-1", "mt.aliyuncs.com"},
                {"eu-west-1", "mt.aliyuncs.com"},
                {"eu-west-1-oxs", "mt.aliyuncs.com"},
                {"me-east-1", "mt.aliyuncs.com"},
                {"rus-west-1-pop", "mt.aliyuncs.com"},
                {"us-east-1", "mt.aliyuncs.com"},
                {"us-west-1", "mt.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("alimt", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request MachineTranslateECommerceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MachineTranslateECommerceResponse
         */
        public MachineTranslateECommerceResponse MachineTranslateECommerceWithOptions(MachineTranslateECommerceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFormat))
            {
                body["ContentFormat"] = request.ContentFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                body["SourceText"] = request.SourceText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MachineTranslateECommerce",
                Version = "2018-08-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MachineTranslateECommerceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request MachineTranslateECommerceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MachineTranslateECommerceResponse
         */
        public async Task<MachineTranslateECommerceResponse> MachineTranslateECommerceWithOptionsAsync(MachineTranslateECommerceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFormat))
            {
                body["ContentFormat"] = request.ContentFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                body["SourceText"] = request.SourceText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MachineTranslateECommerce",
                Version = "2018-08-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MachineTranslateECommerceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request MachineTranslateECommerceRequest
         * @return MachineTranslateECommerceResponse
         */
        public MachineTranslateECommerceResponse MachineTranslateECommerce(MachineTranslateECommerceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MachineTranslateECommerceWithOptions(request, runtime);
        }

        /**
         * @param request MachineTranslateECommerceRequest
         * @return MachineTranslateECommerceResponse
         */
        public async Task<MachineTranslateECommerceResponse> MachineTranslateECommerceAsync(MachineTranslateECommerceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MachineTranslateECommerceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request MachineTranslateGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MachineTranslateGeneralResponse
         */
        public MachineTranslateGeneralResponse MachineTranslateGeneralWithOptions(MachineTranslateGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFormat))
            {
                body["ContentFormat"] = request.ContentFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                body["SourceText"] = request.SourceText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MachineTranslateGeneral",
                Version = "2018-08-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MachineTranslateGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request MachineTranslateGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MachineTranslateGeneralResponse
         */
        public async Task<MachineTranslateGeneralResponse> MachineTranslateGeneralWithOptionsAsync(MachineTranslateGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFormat))
            {
                body["ContentFormat"] = request.ContentFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                body["SourceText"] = request.SourceText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MachineTranslateGeneral",
                Version = "2018-08-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MachineTranslateGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request MachineTranslateGeneralRequest
         * @return MachineTranslateGeneralResponse
         */
        public MachineTranslateGeneralResponse MachineTranslateGeneral(MachineTranslateGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MachineTranslateGeneralWithOptions(request, runtime);
        }

        /**
         * @param request MachineTranslateGeneralRequest
         * @return MachineTranslateGeneralResponse
         */
        public async Task<MachineTranslateGeneralResponse> MachineTranslateGeneralAsync(MachineTranslateGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MachineTranslateGeneralWithOptionsAsync(request, runtime);
        }

    }
}
