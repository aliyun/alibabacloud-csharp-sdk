// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alinlp20200629.Models;

namespace AlibabaCloud.SDK.Alinlp20200629
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("alinlp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary ad画钟算法处理算法
         *
         * @param request ADClockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADClockResponse
         */
        public ADClockResponse ADClockWithOptions(ADClockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADClock",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADClockResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ad画钟算法处理算法
         *
         * @param request ADClockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADClockResponse
         */
        public async Task<ADClockResponse> ADClockWithOptionsAsync(ADClockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADClock",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADClockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ad画钟算法处理算法
         *
         * @param request ADClockRequest
         * @return ADClockResponse
         */
        public ADClockResponse ADClock(ADClockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ADClockWithOptions(request, runtime);
        }

        /**
         * @summary ad画钟算法处理算法
         *
         * @param request ADClockRequest
         * @return ADClockResponse
         */
        public async Task<ADClockResponse> ADClockAsync(ADClockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ADClockWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ad语音处理算法
         *
         * @param request ADMMURequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADMMUResponse
         */
        public ADMMUResponse ADMMUWithOptions(ADMMURequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADMMU",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADMMUResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ad语音处理算法
         *
         * @param request ADMMURequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADMMUResponse
         */
        public async Task<ADMMUResponse> ADMMUWithOptionsAsync(ADMMURequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADMMU",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADMMUResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ad语音处理算法
         *
         * @param request ADMMURequest
         * @return ADMMUResponse
         */
        public ADMMUResponse ADMMU(ADMMURequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ADMMUWithOptions(request, runtime);
        }

        /**
         * @summary ad语音处理算法
         *
         * @param request ADMMURequest
         * @return ADMMUResponse
         */
        public async Task<ADMMUResponse> ADMMUAsync(ADMMURequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ADMMUWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AD筛查能力，处理用户传入的答题音频和画钟图片从而计算风险结果
         *
         * @param request ADMiniCogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADMiniCogResponse
         */
        public ADMiniCogResponse ADMiniCogWithOptions(ADMiniCogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADMiniCog",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADMiniCogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary AD筛查能力，处理用户传入的答题音频和画钟图片从而计算风险结果
         *
         * @param request ADMiniCogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADMiniCogResponse
         */
        public async Task<ADMiniCogResponse> ADMiniCogWithOptionsAsync(ADMiniCogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADMiniCog",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADMiniCogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary AD筛查能力，处理用户传入的答题音频和画钟图片从而计算风险结果
         *
         * @param request ADMiniCogRequest
         * @return ADMiniCogResponse
         */
        public ADMiniCogResponse ADMiniCog(ADMiniCogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ADMiniCogWithOptions(request, runtime);
        }

        /**
         * @summary AD筛查能力，处理用户传入的答题音频和画钟图片从而计算风险结果
         *
         * @param request ADMiniCogRequest
         * @return ADMiniCogResponse
         */
        public async Task<ADMiniCogResponse> ADMiniCogAsync(ADMiniCogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ADMiniCogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AD筛查能力,提供给用户查询筛查结果，筛查结果来源自接口ADMIniCog
         *
         * @param request ADMiniCogResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADMiniCogResultResponse
         */
        public ADMiniCogResultResponse ADMiniCogResultWithOptions(ADMiniCogResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADMiniCogResult",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADMiniCogResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary AD筛查能力,提供给用户查询筛查结果，筛查结果来源自接口ADMIniCog
         *
         * @param request ADMiniCogResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ADMiniCogResultResponse
         */
        public async Task<ADMiniCogResultResponse> ADMiniCogResultWithOptionsAsync(ADMiniCogResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ADMiniCogResult",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ADMiniCogResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary AD筛查能力,提供给用户查询筛查结果，筛查结果来源自接口ADMIniCog
         *
         * @param request ADMiniCogResultRequest
         * @return ADMiniCogResultResponse
         */
        public ADMiniCogResultResponse ADMiniCogResult(ADMiniCogResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ADMiniCogResultWithOptions(request, runtime);
        }

        /**
         * @summary AD筛查能力,提供给用户查询筛查结果，筛查结果来源自接口ADMIniCog
         *
         * @param request ADMiniCogResultRequest
         * @return ADMiniCogResultResponse
         */
        public async Task<ADMiniCogResultResponse> ADMiniCogResultAsync(ADMiniCogResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ADMiniCogResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据条件删除服务数据
         *
         * @param tmpReq DeleteServiceDataByConditionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceDataByConditionsResponse
         */
        public DeleteServiceDataByConditionsResponse DeleteServiceDataByConditionsWithOptions(DeleteServiceDataByConditionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteServiceDataByConditionsShrinkRequest request = new DeleteServiceDataByConditionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                body["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDashScopeOpenAPISource))
            {
                body["X-DashScope-OpenAPISource"] = request.XDashScopeOpenAPISource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceDataByConditions",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceDataByConditionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据条件删除服务数据
         *
         * @param tmpReq DeleteServiceDataByConditionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceDataByConditionsResponse
         */
        public async Task<DeleteServiceDataByConditionsResponse> DeleteServiceDataByConditionsWithOptionsAsync(DeleteServiceDataByConditionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteServiceDataByConditionsShrinkRequest request = new DeleteServiceDataByConditionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                body["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDashScopeOpenAPISource))
            {
                body["X-DashScope-OpenAPISource"] = request.XDashScopeOpenAPISource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceDataByConditions",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceDataByConditionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据条件删除服务数据
         *
         * @param request DeleteServiceDataByConditionsRequest
         * @return DeleteServiceDataByConditionsResponse
         */
        public DeleteServiceDataByConditionsResponse DeleteServiceDataByConditions(DeleteServiceDataByConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceDataByConditionsWithOptions(request, runtime);
        }

        /**
         * @summary 根据条件删除服务数据
         *
         * @param request DeleteServiceDataByConditionsRequest
         * @return DeleteServiceDataByConditionsResponse
         */
        public async Task<DeleteServiceDataByConditionsResponse> DeleteServiceDataByConditionsAsync(DeleteServiceDataByConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceDataByConditionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据ids删除服务数据
         *
         * @param tmpReq DeleteServiceDataByIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceDataByIdsResponse
         */
        public DeleteServiceDataByIdsResponse DeleteServiceDataByIdsWithOptions(DeleteServiceDataByIdsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteServiceDataByIdsShrinkRequest request = new DeleteServiceDataByIdsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ids))
            {
                request.IdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ids, "Ids", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdsShrink))
            {
                body["Ids"] = request.IdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceDataByIds",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceDataByIdsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据ids删除服务数据
         *
         * @param tmpReq DeleteServiceDataByIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceDataByIdsResponse
         */
        public async Task<DeleteServiceDataByIdsResponse> DeleteServiceDataByIdsWithOptionsAsync(DeleteServiceDataByIdsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteServiceDataByIdsShrinkRequest request = new DeleteServiceDataByIdsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ids))
            {
                request.IdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ids, "Ids", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdsShrink))
            {
                body["Ids"] = request.IdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceDataByIds",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceDataByIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据ids删除服务数据
         *
         * @param request DeleteServiceDataByIdsRequest
         * @return DeleteServiceDataByIdsResponse
         */
        public DeleteServiceDataByIdsResponse DeleteServiceDataByIds(DeleteServiceDataByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceDataByIdsWithOptions(request, runtime);
        }

        /**
         * @summary 根据ids删除服务数据
         *
         * @param request DeleteServiceDataByIdsRequest
         * @return DeleteServiceDataByIdsResponse
         */
        public async Task<DeleteServiceDataByIdsResponse> DeleteServiceDataByIdsAsync(DeleteServiceDataByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceDataByIdsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 品牌预测
         *
         * @param request GetBrandChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBrandChEcomResponse
         */
        public GetBrandChEcomResponse GetBrandChEcomWithOptions(GetBrandChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetBrandChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBrandChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 品牌预测
         *
         * @param request GetBrandChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBrandChEcomResponse
         */
        public async Task<GetBrandChEcomResponse> GetBrandChEcomWithOptionsAsync(GetBrandChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetBrandChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBrandChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 品牌预测
         *
         * @param request GetBrandChEcomRequest
         * @return GetBrandChEcomResponse
         */
        public GetBrandChEcomResponse GetBrandChEcom(GetBrandChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBrandChEcomWithOptions(request, runtime);
        }

        /**
         * @summary 品牌预测
         *
         * @param request GetBrandChEcomRequest
         * @return GetBrandChEcomResponse
         */
        public async Task<GetBrandChEcomResponse> GetBrandChEcomAsync(GetBrandChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBrandChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 类目预测
         *
         * @param request GetCateChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCateChEcomResponse
         */
        public GetCateChEcomResponse GetCateChEcomWithOptions(GetCateChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetCateChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCateChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 类目预测
         *
         * @param request GetCateChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCateChEcomResponse
         */
        public async Task<GetCateChEcomResponse> GetCateChEcomWithOptionsAsync(GetCateChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetCateChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCateChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 类目预测
         *
         * @param request GetCateChEcomRequest
         * @return GetCateChEcomResponse
         */
        public GetCateChEcomResponse GetCateChEcom(GetCateChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCateChEcomWithOptions(request, runtime);
        }

        /**
         * @summary 类目预测
         *
         * @param request GetCateChEcomRequest
         * @return GetCateChEcomResponse
         */
        public async Task<GetCateChEcomResponse> GetCateChEcomAsync(GetCateChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCateChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetCheckDuplicationChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCheckDuplicationChMedicalResponse
         */
        public GetCheckDuplicationChMedicalResponse GetCheckDuplicationChMedicalWithOptions(GetCheckDuplicationChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginQ))
            {
                body["OriginQ"] = request.OriginQ;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginT))
            {
                body["OriginT"] = request.OriginT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckDuplicationChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCheckDuplicationChMedicalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetCheckDuplicationChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCheckDuplicationChMedicalResponse
         */
        public async Task<GetCheckDuplicationChMedicalResponse> GetCheckDuplicationChMedicalWithOptionsAsync(GetCheckDuplicationChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginQ))
            {
                body["OriginQ"] = request.OriginQ;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginT))
            {
                body["OriginT"] = request.OriginT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckDuplicationChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCheckDuplicationChMedicalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetCheckDuplicationChMedicalRequest
         * @return GetCheckDuplicationChMedicalResponse
         */
        public GetCheckDuplicationChMedicalResponse GetCheckDuplicationChMedical(GetCheckDuplicationChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCheckDuplicationChMedicalWithOptions(request, runtime);
        }

        /**
         * @param request GetCheckDuplicationChMedicalRequest
         * @return GetCheckDuplicationChMedicalResponse
         */
        public async Task<GetCheckDuplicationChMedicalResponse> GetCheckDuplicationChMedicalAsync(GetCheckDuplicationChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCheckDuplicationChMedicalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetDiagnosisChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDiagnosisChMedicalResponse
         */
        public GetDiagnosisChMedicalResponse GetDiagnosisChMedicalWithOptions(GetDiagnosisChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnosisChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosisChMedicalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetDiagnosisChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDiagnosisChMedicalResponse
         */
        public async Task<GetDiagnosisChMedicalResponse> GetDiagnosisChMedicalWithOptionsAsync(GetDiagnosisChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnosisChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosisChMedicalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetDiagnosisChMedicalRequest
         * @return GetDiagnosisChMedicalResponse
         */
        public GetDiagnosisChMedicalResponse GetDiagnosisChMedical(GetDiagnosisChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiagnosisChMedicalWithOptions(request, runtime);
        }

        /**
         * @param request GetDiagnosisChMedicalRequest
         * @return GetDiagnosisChMedicalResponse
         */
        public async Task<GetDiagnosisChMedicalResponse> GetDiagnosisChMedicalAsync(GetDiagnosisChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiagnosisChMedicalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetDpChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDpChEcomResponse
         */
        public GetDpChEcomResponse GetDpChEcomWithOptions(GetDpChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetDpChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDpChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetDpChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDpChEcomResponse
         */
        public async Task<GetDpChEcomResponse> GetDpChEcomWithOptionsAsync(GetDpChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetDpChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDpChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetDpChEcomRequest
         * @return GetDpChEcomResponse
         */
        public GetDpChEcomResponse GetDpChEcom(GetDpChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDpChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetDpChEcomRequest
         * @return GetDpChEcomResponse
         */
        public async Task<GetDpChEcomResponse> GetDpChEcomAsync(GetDpChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDpChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetDpChGeneralCTBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDpChGeneralCTBResponse
         */
        public GetDpChGeneralCTBResponse GetDpChGeneralCTBWithOptions(GetDpChGeneralCTBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetDpChGeneralCTB",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDpChGeneralCTBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetDpChGeneralCTBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDpChGeneralCTBResponse
         */
        public async Task<GetDpChGeneralCTBResponse> GetDpChGeneralCTBWithOptionsAsync(GetDpChGeneralCTBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetDpChGeneralCTB",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDpChGeneralCTBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetDpChGeneralCTBRequest
         * @return GetDpChGeneralCTBResponse
         */
        public GetDpChGeneralCTBResponse GetDpChGeneralCTB(GetDpChGeneralCTBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDpChGeneralCTBWithOptions(request, runtime);
        }

        /**
         * @param request GetDpChGeneralCTBRequest
         * @return GetDpChGeneralCTBResponse
         */
        public async Task<GetDpChGeneralCTBResponse> GetDpChGeneralCTBAsync(GetDpChGeneralCTBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDpChGeneralCTBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetDpChGeneralStanfordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDpChGeneralStanfordResponse
         */
        public GetDpChGeneralStanfordResponse GetDpChGeneralStanfordWithOptions(GetDpChGeneralStanfordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetDpChGeneralStanford",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDpChGeneralStanfordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetDpChGeneralStanfordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDpChGeneralStanfordResponse
         */
        public async Task<GetDpChGeneralStanfordResponse> GetDpChGeneralStanfordWithOptionsAsync(GetDpChGeneralStanfordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetDpChGeneralStanford",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDpChGeneralStanfordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetDpChGeneralStanfordRequest
         * @return GetDpChGeneralStanfordResponse
         */
        public GetDpChGeneralStanfordResponse GetDpChGeneralStanford(GetDpChGeneralStanfordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDpChGeneralStanfordWithOptions(request, runtime);
        }

        /**
         * @param request GetDpChGeneralStanfordRequest
         * @return GetDpChGeneralStanfordResponse
         */
        public async Task<GetDpChGeneralStanfordResponse> GetDpChGeneralStanfordAsync(GetDpChGeneralStanfordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDpChGeneralStanfordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetEcChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEcChGeneralResponse
         */
        public GetEcChGeneralResponse GetEcChGeneralWithOptions(GetEcChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetEcChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEcChGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetEcChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEcChGeneralResponse
         */
        public async Task<GetEcChGeneralResponse> GetEcChGeneralWithOptionsAsync(GetEcChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetEcChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEcChGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetEcChGeneralRequest
         * @return GetEcChGeneralResponse
         */
        public GetEcChGeneralResponse GetEcChGeneral(GetEcChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEcChGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetEcChGeneralRequest
         * @return GetEcChGeneralResponse
         */
        public async Task<GetEcChGeneralResponse> GetEcChGeneralAsync(GetEcChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEcChGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetEcEnGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEcEnGeneralResponse
         */
        public GetEcEnGeneralResponse GetEcEnGeneralWithOptions(GetEcEnGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetEcEnGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEcEnGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetEcEnGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEcEnGeneralResponse
         */
        public async Task<GetEcEnGeneralResponse> GetEcEnGeneralWithOptionsAsync(GetEcEnGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetEcEnGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEcEnGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetEcEnGeneralRequest
         * @return GetEcEnGeneralResponse
         */
        public GetEcEnGeneralResponse GetEcEnGeneral(GetEcEnGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEcEnGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetEcEnGeneralRequest
         * @return GetEcEnGeneralResponse
         */
        public async Task<GetEcEnGeneralResponse> GetEcEnGeneralAsync(GetEcEnGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEcEnGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @summary embedding
         *
         * @param request GetEmbeddingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmbeddingResponse
         */
        public GetEmbeddingResponse GetEmbeddingWithOptions(GetEmbeddingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextType))
            {
                body["TextType"] = request.TextType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmbedding",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmbeddingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary embedding
         *
         * @param request GetEmbeddingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmbeddingResponse
         */
        public async Task<GetEmbeddingResponse> GetEmbeddingWithOptionsAsync(GetEmbeddingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextType))
            {
                body["TextType"] = request.TextType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmbedding",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmbeddingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary embedding
         *
         * @param request GetEmbeddingRequest
         * @return GetEmbeddingResponse
         */
        public GetEmbeddingResponse GetEmbedding(GetEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEmbeddingWithOptions(request, runtime);
        }

        /**
         * @summary embedding
         *
         * @param request GetEmbeddingRequest
         * @return GetEmbeddingResponse
         */
        public async Task<GetEmbeddingResponse> GetEmbeddingAsync(GetEmbeddingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEmbeddingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 微购整合接口
         *
         * @param request GetItemPubChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetItemPubChEcomResponse
         */
        public GetItemPubChEcomResponse GetItemPubChEcomWithOptions(GetItemPubChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetItemPubChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetItemPubChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 微购整合接口
         *
         * @param request GetItemPubChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetItemPubChEcomResponse
         */
        public async Task<GetItemPubChEcomResponse> GetItemPubChEcomWithOptionsAsync(GetItemPubChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetItemPubChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetItemPubChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 微购整合接口
         *
         * @param request GetItemPubChEcomRequest
         * @return GetItemPubChEcomResponse
         */
        public GetItemPubChEcomResponse GetItemPubChEcom(GetItemPubChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetItemPubChEcomWithOptions(request, runtime);
        }

        /**
         * @summary 微购整合接口
         *
         * @param request GetItemPubChEcomRequest
         * @return GetItemPubChEcomResponse
         */
        public async Task<GetItemPubChEcomResponse> GetItemPubChEcomAsync(GetItemPubChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetItemPubChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetKeywordChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeywordChEcomResponse
         */
        public GetKeywordChEcomResponse GetKeywordChEcomWithOptions(GetKeywordChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                body["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetKeywordChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKeywordChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetKeywordChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeywordChEcomResponse
         */
        public async Task<GetKeywordChEcomResponse> GetKeywordChEcomWithOptionsAsync(GetKeywordChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                body["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetKeywordChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKeywordChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetKeywordChEcomRequest
         * @return GetKeywordChEcomResponse
         */
        public GetKeywordChEcomResponse GetKeywordChEcom(GetKeywordChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKeywordChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetKeywordChEcomRequest
         * @return GetKeywordChEcomResponse
         */
        public async Task<GetKeywordChEcomResponse> GetKeywordChEcomAsync(GetKeywordChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKeywordChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetKeywordEnEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeywordEnEcomResponse
         */
        public GetKeywordEnEcomResponse GetKeywordEnEcomWithOptions(GetKeywordEnEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetKeywordEnEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKeywordEnEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetKeywordEnEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeywordEnEcomResponse
         */
        public async Task<GetKeywordEnEcomResponse> GetKeywordEnEcomWithOptionsAsync(GetKeywordEnEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetKeywordEnEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKeywordEnEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetKeywordEnEcomRequest
         * @return GetKeywordEnEcomResponse
         */
        public GetKeywordEnEcomResponse GetKeywordEnEcom(GetKeywordEnEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKeywordEnEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetKeywordEnEcomRequest
         * @return GetKeywordEnEcomResponse
         */
        public async Task<GetKeywordEnEcomResponse> GetKeywordEnEcomAsync(GetKeywordEnEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKeywordEnEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMedicineChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMedicineChMedicalResponse
         */
        public GetMedicineChMedicalResponse GetMedicineChMedicalWithOptions(GetMedicineChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Factory))
            {
                body["Factory"] = request.Factory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                body["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                body["Unit"] = request.Unit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMedicineChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMedicineChMedicalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetMedicineChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMedicineChMedicalResponse
         */
        public async Task<GetMedicineChMedicalResponse> GetMedicineChMedicalWithOptionsAsync(GetMedicineChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Factory))
            {
                body["Factory"] = request.Factory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                body["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                body["Unit"] = request.Unit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMedicineChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMedicineChMedicalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetMedicineChMedicalRequest
         * @return GetMedicineChMedicalResponse
         */
        public GetMedicineChMedicalResponse GetMedicineChMedical(GetMedicineChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMedicineChMedicalWithOptions(request, runtime);
        }

        /**
         * @param request GetMedicineChMedicalRequest
         * @return GetMedicineChMedicalResponse
         */
        public async Task<GetMedicineChMedicalResponse> GetMedicineChMedicalAsync(GetMedicineChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMedicineChMedicalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetNerChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerChEcomResponse
         */
        public GetNerChEcomResponse GetNerChEcomWithOptions(GetNerChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LexerId))
            {
                body["LexerId"] = request.LexerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetNerChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerChEcomResponse
         */
        public async Task<GetNerChEcomResponse> GetNerChEcomWithOptionsAsync(GetNerChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LexerId))
            {
                body["LexerId"] = request.LexerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetNerChEcomRequest
         * @return GetNerChEcomResponse
         */
        public GetNerChEcomResponse GetNerChEcom(GetNerChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNerChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetNerChEcomRequest
         * @return GetNerChEcomResponse
         */
        public async Task<GetNerChEcomResponse> GetNerChEcomAsync(GetNerChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNerChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetNerChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerChMedicalResponse
         */
        public GetNerChMedicalResponse GetNerChMedicalWithOptions(GetNerChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerChMedicalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetNerChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerChMedicalResponse
         */
        public async Task<GetNerChMedicalResponse> GetNerChMedicalWithOptionsAsync(GetNerChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerChMedicalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetNerChMedicalRequest
         * @return GetNerChMedicalResponse
         */
        public GetNerChMedicalResponse GetNerChMedical(GetNerChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNerChMedicalWithOptions(request, runtime);
        }

        /**
         * @param request GetNerChMedicalRequest
         * @return GetNerChMedicalResponse
         */
        public async Task<GetNerChMedicalResponse> GetNerChMedicalAsync(GetNerChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNerChMedicalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetNerCustomizedChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerCustomizedChEcomResponse
         */
        public GetNerCustomizedChEcomResponse GetNerCustomizedChEcomWithOptions(GetNerCustomizedChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LexerId))
            {
                body["LexerId"] = request.LexerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerCustomizedChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerCustomizedChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetNerCustomizedChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerCustomizedChEcomResponse
         */
        public async Task<GetNerCustomizedChEcomResponse> GetNerCustomizedChEcomWithOptionsAsync(GetNerCustomizedChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LexerId))
            {
                body["LexerId"] = request.LexerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerCustomizedChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerCustomizedChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetNerCustomizedChEcomRequest
         * @return GetNerCustomizedChEcomResponse
         */
        public GetNerCustomizedChEcomResponse GetNerCustomizedChEcom(GetNerCustomizedChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNerCustomizedChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetNerCustomizedChEcomRequest
         * @return GetNerCustomizedChEcomResponse
         */
        public async Task<GetNerCustomizedChEcomResponse> GetNerCustomizedChEcomAsync(GetNerCustomizedChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNerCustomizedChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetNerCustomizedSeaEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerCustomizedSeaEcomResponse
         */
        public GetNerCustomizedSeaEcomResponse GetNerCustomizedSeaEcomWithOptions(GetNerCustomizedSeaEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerCustomizedSeaEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerCustomizedSeaEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetNerCustomizedSeaEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNerCustomizedSeaEcomResponse
         */
        public async Task<GetNerCustomizedSeaEcomResponse> GetNerCustomizedSeaEcomWithOptionsAsync(GetNerCustomizedSeaEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetNerCustomizedSeaEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNerCustomizedSeaEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetNerCustomizedSeaEcomRequest
         * @return GetNerCustomizedSeaEcomResponse
         */
        public GetNerCustomizedSeaEcomResponse GetNerCustomizedSeaEcom(GetNerCustomizedSeaEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNerCustomizedSeaEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetNerCustomizedSeaEcomRequest
         * @return GetNerCustomizedSeaEcomResponse
         */
        public async Task<GetNerCustomizedSeaEcomResponse> GetNerCustomizedSeaEcomAsync(GetNerCustomizedSeaEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNerCustomizedSeaEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @summary openNLU
         *
         * @param request GetOpenNLURequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOpenNLUResponse
         */
        public GetOpenNLUResponse GetOpenNLUWithOptions(GetOpenNLURequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["Examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sentence))
            {
                body["Sentence"] = request.Sentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOpenNLU",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenNLUResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary openNLU
         *
         * @param request GetOpenNLURequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOpenNLUResponse
         */
        public async Task<GetOpenNLUResponse> GetOpenNLUWithOptionsAsync(GetOpenNLURequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["Examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sentence))
            {
                body["Sentence"] = request.Sentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOpenNLU",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenNLUResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary openNLU
         *
         * @param request GetOpenNLURequest
         * @return GetOpenNLUResponse
         */
        public GetOpenNLUResponse GetOpenNLU(GetOpenNLURequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpenNLUWithOptions(request, runtime);
        }

        /**
         * @summary openNLU
         *
         * @param request GetOpenNLURequest
         * @return GetOpenNLUResponse
         */
        public async Task<GetOpenNLUResponse> GetOpenNLUAsync(GetOpenNLURequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpenNLUWithOptionsAsync(request, runtime);
        }

        /**
         * @summary openNLU高召回版
         *
         * @param request GetOpenNLUHighRecallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOpenNLUHighRecallResponse
         */
        public GetOpenNLUHighRecallResponse GetOpenNLUHighRecallWithOptions(GetOpenNLUHighRecallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["Examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sentence))
            {
                body["Sentence"] = request.Sentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOpenNLUHighRecall",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenNLUHighRecallResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary openNLU高召回版
         *
         * @param request GetOpenNLUHighRecallRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOpenNLUHighRecallResponse
         */
        public async Task<GetOpenNLUHighRecallResponse> GetOpenNLUHighRecallWithOptionsAsync(GetOpenNLUHighRecallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Examples))
            {
                body["Examples"] = request.Examples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sentence))
            {
                body["Sentence"] = request.Sentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOpenNLUHighRecall",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpenNLUHighRecallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary openNLU高召回版
         *
         * @param request GetOpenNLUHighRecallRequest
         * @return GetOpenNLUHighRecallResponse
         */
        public GetOpenNLUHighRecallResponse GetOpenNLUHighRecall(GetOpenNLUHighRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpenNLUHighRecallWithOptions(request, runtime);
        }

        /**
         * @summary openNLU高召回版
         *
         * @param request GetOpenNLUHighRecallRequest
         * @return GetOpenNLUHighRecallResponse
         */
        public async Task<GetOpenNLUHighRecallResponse> GetOpenNLUHighRecallAsync(GetOpenNLUHighRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpenNLUHighRecallWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetOperationChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOperationChMedicalResponse
         */
        public GetOperationChMedicalResponse GetOperationChMedicalWithOptions(GetOperationChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperationChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationChMedicalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetOperationChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOperationChMedicalResponse
         */
        public async Task<GetOperationChMedicalResponse> GetOperationChMedicalWithOptionsAsync(GetOperationChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperationChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationChMedicalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetOperationChMedicalRequest
         * @return GetOperationChMedicalResponse
         */
        public GetOperationChMedicalResponse GetOperationChMedical(GetOperationChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOperationChMedicalWithOptions(request, runtime);
        }

        /**
         * @param request GetOperationChMedicalRequest
         * @return GetOperationChMedicalResponse
         */
        public async Task<GetOperationChMedicalResponse> GetOperationChMedicalAsync(GetOperationChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOperationChMedicalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetPosChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPosChEcomResponse
         */
        public GetPosChEcomResponse GetPosChEcomWithOptions(GetPosChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPosChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPosChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetPosChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPosChEcomResponse
         */
        public async Task<GetPosChEcomResponse> GetPosChEcomWithOptionsAsync(GetPosChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPosChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPosChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetPosChEcomRequest
         * @return GetPosChEcomResponse
         */
        public GetPosChEcomResponse GetPosChEcom(GetPosChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPosChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetPosChEcomRequest
         * @return GetPosChEcomResponse
         */
        public async Task<GetPosChEcomResponse> GetPosChEcomAsync(GetPosChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPosChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetPosChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPosChGeneralResponse
         */
        public GetPosChGeneralResponse GetPosChGeneralWithOptions(GetPosChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPosChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPosChGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetPosChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPosChGeneralResponse
         */
        public async Task<GetPosChGeneralResponse> GetPosChGeneralWithOptionsAsync(GetPosChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPosChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPosChGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetPosChGeneralRequest
         * @return GetPosChGeneralResponse
         */
        public GetPosChGeneralResponse GetPosChGeneral(GetPosChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPosChGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetPosChGeneralRequest
         * @return GetPosChGeneralResponse
         */
        public async Task<GetPosChGeneralResponse> GetPosChGeneralAsync(GetPosChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPosChGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetPriceChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPriceChEcomResponse
         */
        public GetPriceChEcomResponse GetPriceChEcomWithOptions(GetPriceChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetPriceChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPriceChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetPriceChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPriceChEcomResponse
         */
        public async Task<GetPriceChEcomResponse> GetPriceChEcomWithOptionsAsync(GetPriceChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetPriceChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPriceChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetPriceChEcomRequest
         * @return GetPriceChEcomResponse
         */
        public GetPriceChEcomResponse GetPriceChEcom(GetPriceChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPriceChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetPriceChEcomRequest
         * @return GetPriceChEcomResponse
         */
        public async Task<GetPriceChEcomResponse> GetPriceChEcomAsync(GetPriceChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPriceChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 测试sse
         *
         * @param request GetSSETestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSSETestResponse
         */
        public GetSSETestResponse GetSSETestWithOptions(GetSSETestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSSETest",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSSETestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 测试sse
         *
         * @param request GetSSETestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSSETestResponse
         */
        public async Task<GetSSETestResponse> GetSSETestWithOptionsAsync(GetSSETestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSSETest",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSSETestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 测试sse
         *
         * @param request GetSSETestRequest
         * @return GetSSETestResponse
         */
        public GetSSETestResponse GetSSETest(GetSSETestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSSETestWithOptions(request, runtime);
        }

        /**
         * @summary 测试sse
         *
         * @param request GetSSETestRequest
         * @return GetSSETestResponse
         */
        public async Task<GetSSETestResponse> GetSSETestAsync(GetSSETestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSSETestWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetSaChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSaChGeneralResponse
         */
        public GetSaChGeneralResponse GetSaChGeneralWithOptions(GetSaChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetSaChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaChGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetSaChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSaChGeneralResponse
         */
        public async Task<GetSaChGeneralResponse> GetSaChGeneralWithOptionsAsync(GetSaChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetSaChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaChGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetSaChGeneralRequest
         * @return GetSaChGeneralResponse
         */
        public GetSaChGeneralResponse GetSaChGeneral(GetSaChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSaChGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetSaChGeneralRequest
         * @return GetSaChGeneralResponse
         */
        public async Task<GetSaChGeneralResponse> GetSaChGeneralAsync(GetSaChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSaChGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetSaSeaEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSaSeaEcomResponse
         */
        public GetSaSeaEcomResponse GetSaSeaEcomWithOptions(GetSaSeaEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetSaSeaEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaSeaEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetSaSeaEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSaSeaEcomResponse
         */
        public async Task<GetSaSeaEcomResponse> GetSaSeaEcomWithOptionsAsync(GetSaSeaEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetSaSeaEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaSeaEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetSaSeaEcomRequest
         * @return GetSaSeaEcomResponse
         */
        public GetSaSeaEcomResponse GetSaSeaEcom(GetSaSeaEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSaSeaEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetSaSeaEcomRequest
         * @return GetSaSeaEcomResponse
         */
        public async Task<GetSaSeaEcomResponse> GetSaSeaEcomAsync(GetSaSeaEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSaSeaEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取服务数据导入状态
         *
         * @param tmpReq GetServiceDataImportStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceDataImportStatusResponse
         */
        public GetServiceDataImportStatusResponse GetServiceDataImportStatusWithOptions(GetServiceDataImportStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetServiceDataImportStatusShrinkRequest request = new GetServiceDataImportStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataImportIds))
            {
                request.DataImportIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataImportIds, "DataImportIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataImportIdsShrink))
            {
                body["DataImportIds"] = request.DataImportIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDataImportStatus",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceDataImportStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取服务数据导入状态
         *
         * @param tmpReq GetServiceDataImportStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceDataImportStatusResponse
         */
        public async Task<GetServiceDataImportStatusResponse> GetServiceDataImportStatusWithOptionsAsync(GetServiceDataImportStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetServiceDataImportStatusShrinkRequest request = new GetServiceDataImportStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataImportIds))
            {
                request.DataImportIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataImportIds, "DataImportIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataImportIdsShrink))
            {
                body["DataImportIds"] = request.DataImportIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDataImportStatus",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceDataImportStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取服务数据导入状态
         *
         * @param request GetServiceDataImportStatusRequest
         * @return GetServiceDataImportStatusResponse
         */
        public GetServiceDataImportStatusResponse GetServiceDataImportStatus(GetServiceDataImportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceDataImportStatusWithOptions(request, runtime);
        }

        /**
         * @summary 获取服务数据导入状态
         *
         * @param request GetServiceDataImportStatusRequest
         * @return GetServiceDataImportStatusResponse
         */
        public async Task<GetServiceDataImportStatusResponse> GetServiceDataImportStatusAsync(GetServiceDataImportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceDataImportStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetSimilarityChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarityChMedicalResponse
         */
        public GetSimilarityChMedicalResponse GetSimilarityChMedicalWithOptions(GetSimilarityChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginQ))
            {
                body["OriginQ"] = request.OriginQ;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginT))
            {
                body["OriginT"] = request.OriginT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarityChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarityChMedicalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetSimilarityChMedicalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSimilarityChMedicalResponse
         */
        public async Task<GetSimilarityChMedicalResponse> GetSimilarityChMedicalWithOptionsAsync(GetSimilarityChMedicalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginQ))
            {
                body["OriginQ"] = request.OriginQ;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginT))
            {
                body["OriginT"] = request.OriginT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSimilarityChMedical",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSimilarityChMedicalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetSimilarityChMedicalRequest
         * @return GetSimilarityChMedicalResponse
         */
        public GetSimilarityChMedicalResponse GetSimilarityChMedical(GetSimilarityChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSimilarityChMedicalWithOptions(request, runtime);
        }

        /**
         * @param request GetSimilarityChMedicalRequest
         * @return GetSimilarityChMedicalResponse
         */
        public async Task<GetSimilarityChMedicalResponse> GetSimilarityChMedicalAsync(GetSimilarityChMedicalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSimilarityChMedicalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetSummaryChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSummaryChEcomResponse
         */
        public GetSummaryChEcomResponse GetSummaryChEcomWithOptions(GetSummaryChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetSummaryChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetSummaryChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSummaryChEcomResponse
         */
        public async Task<GetSummaryChEcomResponse> GetSummaryChEcomWithOptionsAsync(GetSummaryChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetSummaryChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetSummaryChEcomRequest
         * @return GetSummaryChEcomResponse
         */
        public GetSummaryChEcomResponse GetSummaryChEcom(GetSummaryChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSummaryChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetSummaryChEcomRequest
         * @return GetSummaryChEcomResponse
         */
        public async Task<GetSummaryChEcomResponse> GetSummaryChEcomAsync(GetSummaryChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSummaryChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据id查询tableqa服务基本信息
         *
         * @param request GetTableQAServiceInfoByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableQAServiceInfoByIdResponse
         */
        public GetTableQAServiceInfoByIdResponse GetTableQAServiceInfoByIdWithOptions(GetTableQAServiceInfoByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableQAServiceInfoById",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableQAServiceInfoByIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据id查询tableqa服务基本信息
         *
         * @param request GetTableQAServiceInfoByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableQAServiceInfoByIdResponse
         */
        public async Task<GetTableQAServiceInfoByIdResponse> GetTableQAServiceInfoByIdWithOptionsAsync(GetTableQAServiceInfoByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableQAServiceInfoById",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableQAServiceInfoByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据id查询tableqa服务基本信息
         *
         * @param request GetTableQAServiceInfoByIdRequest
         * @return GetTableQAServiceInfoByIdResponse
         */
        public GetTableQAServiceInfoByIdResponse GetTableQAServiceInfoById(GetTableQAServiceInfoByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableQAServiceInfoByIdWithOptions(request, runtime);
        }

        /**
         * @summary 根据id查询tableqa服务基本信息
         *
         * @param request GetTableQAServiceInfoByIdRequest
         * @return GetTableQAServiceInfoByIdResponse
         */
        public async Task<GetTableQAServiceInfoByIdResponse> GetTableQAServiceInfoByIdAsync(GetTableQAServiceInfoByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableQAServiceInfoByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetTcChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTcChEcomResponse
         */
        public GetTcChEcomResponse GetTcChEcomWithOptions(GetTcChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetTcChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTcChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetTcChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTcChEcomResponse
         */
        public async Task<GetTcChEcomResponse> GetTcChEcomWithOptionsAsync(GetTcChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetTcChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTcChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetTcChEcomRequest
         * @return GetTcChEcomResponse
         */
        public GetTcChEcomResponse GetTcChEcom(GetTcChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTcChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetTcChEcomRequest
         * @return GetTcChEcomResponse
         */
        public async Task<GetTcChEcomResponse> GetTcChEcomAsync(GetTcChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTcChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetTcChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTcChGeneralResponse
         */
        public GetTcChGeneralResponse GetTcChGeneralWithOptions(GetTcChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetTcChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTcChGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetTcChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTcChGeneralResponse
         */
        public async Task<GetTcChGeneralResponse> GetTcChGeneralWithOptionsAsync(GetTcChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetTcChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTcChGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetTcChGeneralRequest
         * @return GetTcChGeneralResponse
         */
        public GetTcChGeneralResponse GetTcChGeneral(GetTcChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTcChGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetTcChGeneralRequest
         * @return GetTcChGeneralResponse
         */
        public async Task<GetTcChGeneralResponse> GetTcChGeneralAsync(GetTcChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTcChGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetTsChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTsChEcomResponse
         */
        public GetTsChEcomResponse GetTsChEcomWithOptions(GetTsChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginQ))
            {
                body["OriginQ"] = request.OriginQ;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginT))
            {
                body["OriginT"] = request.OriginT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetTsChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTsChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetTsChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTsChEcomResponse
         */
        public async Task<GetTsChEcomResponse> GetTsChEcomWithOptionsAsync(GetTsChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginQ))
            {
                body["OriginQ"] = request.OriginQ;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginT))
            {
                body["OriginT"] = request.OriginT;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetTsChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTsChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetTsChEcomRequest
         * @return GetTsChEcomResponse
         */
        public GetTsChEcomResponse GetTsChEcom(GetTsChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTsChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetTsChEcomRequest
         * @return GetTsChEcomResponse
         */
        public async Task<GetTsChEcomResponse> GetTsChEcomAsync(GetTsChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTsChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetUserUploadSignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserUploadSignResponse
         */
        public GetUserUploadSignResponse GetUserUploadSignWithOptions(GetUserUploadSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserUploadSign",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserUploadSignResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetUserUploadSignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserUploadSignResponse
         */
        public async Task<GetUserUploadSignResponse> GetUserUploadSignWithOptionsAsync(GetUserUploadSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserUploadSign",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserUploadSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetUserUploadSignRequest
         * @return GetUserUploadSignResponse
         */
        public GetUserUploadSignResponse GetUserUploadSign(GetUserUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserUploadSignWithOptions(request, runtime);
        }

        /**
         * @param request GetUserUploadSignRequest
         * @return GetUserUploadSignResponse
         */
        public async Task<GetUserUploadSignResponse> GetUserUploadSignAsync(GetUserUploadSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserUploadSignWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWeChCommentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChCommentResponse
         */
        public GetWeChCommentResponse GetWeChCommentWithOptions(GetWeChCommentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChComment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChCommentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWeChCommentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChCommentResponse
         */
        public async Task<GetWeChCommentResponse> GetWeChCommentWithOptionsAsync(GetWeChCommentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChComment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChCommentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWeChCommentRequest
         * @return GetWeChCommentResponse
         */
        public GetWeChCommentResponse GetWeChComment(GetWeChCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWeChCommentWithOptions(request, runtime);
        }

        /**
         * @param request GetWeChCommentRequest
         * @return GetWeChCommentResponse
         */
        public async Task<GetWeChCommentResponse> GetWeChCommentAsync(GetWeChCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWeChCommentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWeChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChEcomResponse
         */
        public GetWeChEcomResponse GetWeChEcomWithOptions(GetWeChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWeChEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChEcomResponse
         */
        public async Task<GetWeChEcomResponse> GetWeChEcomWithOptionsAsync(GetWeChEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWeChEcomRequest
         * @return GetWeChEcomResponse
         */
        public GetWeChEcomResponse GetWeChEcom(GetWeChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWeChEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetWeChEcomRequest
         * @return GetWeChEcomResponse
         */
        public async Task<GetWeChEcomResponse> GetWeChEcomAsync(GetWeChEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWeChEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWeChEntertainmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChEntertainmentResponse
         */
        public GetWeChEntertainmentResponse GetWeChEntertainmentWithOptions(GetWeChEntertainmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChEntertainment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChEntertainmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWeChEntertainmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChEntertainmentResponse
         */
        public async Task<GetWeChEntertainmentResponse> GetWeChEntertainmentWithOptionsAsync(GetWeChEntertainmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChEntertainment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChEntertainmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWeChEntertainmentRequest
         * @return GetWeChEntertainmentResponse
         */
        public GetWeChEntertainmentResponse GetWeChEntertainment(GetWeChEntertainmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWeChEntertainmentWithOptions(request, runtime);
        }

        /**
         * @param request GetWeChEntertainmentRequest
         * @return GetWeChEntertainmentResponse
         */
        public async Task<GetWeChEntertainmentResponse> GetWeChEntertainmentAsync(GetWeChEntertainmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWeChEntertainmentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWeChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChGeneralResponse
         */
        public GetWeChGeneralResponse GetWeChGeneralWithOptions(GetWeChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
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
                Action = "GetWeChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWeChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChGeneralResponse
         */
        public async Task<GetWeChGeneralResponse> GetWeChGeneralWithOptionsAsync(GetWeChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
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
                Action = "GetWeChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWeChGeneralRequest
         * @return GetWeChGeneralResponse
         */
        public GetWeChGeneralResponse GetWeChGeneral(GetWeChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWeChGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetWeChGeneralRequest
         * @return GetWeChGeneralResponse
         */
        public async Task<GetWeChGeneralResponse> GetWeChGeneralAsync(GetWeChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWeChGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWeChSearchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChSearchResponse
         */
        public GetWeChSearchResponse GetWeChSearchWithOptions(GetWeChSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChSearch",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChSearchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWeChSearchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWeChSearchResponse
         */
        public async Task<GetWeChSearchResponse> GetWeChSearchWithOptionsAsync(GetWeChSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
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
                Action = "GetWeChSearch",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWeChSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWeChSearchRequest
         * @return GetWeChSearchResponse
         */
        public GetWeChSearchResponse GetWeChSearch(GetWeChSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWeChSearchWithOptions(request, runtime);
        }

        /**
         * @param request GetWeChSearchRequest
         * @return GetWeChSearchResponse
         */
        public async Task<GetWeChSearchResponse> GetWeChSearchAsync(GetWeChSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWeChSearchWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsChGeneralResponse
         */
        public GetWsChGeneralResponse GetWsChGeneralWithOptions(GetWsChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsChGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsChGeneralResponse
         */
        public async Task<GetWsChGeneralResponse> GetWsChGeneralWithOptionsAsync(GetWsChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsChGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsChGeneralRequest
         * @return GetWsChGeneralResponse
         */
        public GetWsChGeneralResponse GetWsChGeneral(GetWsChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsChGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetWsChGeneralRequest
         * @return GetWsChGeneralResponse
         */
        public async Task<GetWsChGeneralResponse> GetWsChGeneralAsync(GetWsChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsChGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEcomCommentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEcomCommentResponse
         */
        public GetWsCustomizedChEcomCommentResponse GetWsCustomizedChEcomCommentWithOptions(GetWsCustomizedChEcomCommentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEcomComment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEcomCommentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEcomCommentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEcomCommentResponse
         */
        public async Task<GetWsCustomizedChEcomCommentResponse> GetWsCustomizedChEcomCommentWithOptionsAsync(GetWsCustomizedChEcomCommentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEcomComment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEcomCommentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEcomCommentRequest
         * @return GetWsCustomizedChEcomCommentResponse
         */
        public GetWsCustomizedChEcomCommentResponse GetWsCustomizedChEcomComment(GetWsCustomizedChEcomCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedChEcomCommentWithOptions(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEcomCommentRequest
         * @return GetWsCustomizedChEcomCommentResponse
         */
        public async Task<GetWsCustomizedChEcomCommentResponse> GetWsCustomizedChEcomCommentAsync(GetWsCustomizedChEcomCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedChEcomCommentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEcomContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEcomContentResponse
         */
        public GetWsCustomizedChEcomContentResponse GetWsCustomizedChEcomContentWithOptions(GetWsCustomizedChEcomContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEcomContent",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEcomContentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEcomContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEcomContentResponse
         */
        public async Task<GetWsCustomizedChEcomContentResponse> GetWsCustomizedChEcomContentWithOptionsAsync(GetWsCustomizedChEcomContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEcomContent",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEcomContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEcomContentRequest
         * @return GetWsCustomizedChEcomContentResponse
         */
        public GetWsCustomizedChEcomContentResponse GetWsCustomizedChEcomContent(GetWsCustomizedChEcomContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedChEcomContentWithOptions(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEcomContentRequest
         * @return GetWsCustomizedChEcomContentResponse
         */
        public async Task<GetWsCustomizedChEcomContentResponse> GetWsCustomizedChEcomContentAsync(GetWsCustomizedChEcomContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedChEcomContentWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEcomTitleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEcomTitleResponse
         */
        public GetWsCustomizedChEcomTitleResponse GetWsCustomizedChEcomTitleWithOptions(GetWsCustomizedChEcomTitleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEcomTitle",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEcomTitleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEcomTitleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEcomTitleResponse
         */
        public async Task<GetWsCustomizedChEcomTitleResponse> GetWsCustomizedChEcomTitleWithOptionsAsync(GetWsCustomizedChEcomTitleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEcomTitle",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEcomTitleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEcomTitleRequest
         * @return GetWsCustomizedChEcomTitleResponse
         */
        public GetWsCustomizedChEcomTitleResponse GetWsCustomizedChEcomTitle(GetWsCustomizedChEcomTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedChEcomTitleWithOptions(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEcomTitleRequest
         * @return GetWsCustomizedChEcomTitleResponse
         */
        public async Task<GetWsCustomizedChEcomTitleResponse> GetWsCustomizedChEcomTitleAsync(GetWsCustomizedChEcomTitleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedChEcomTitleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEntertainmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEntertainmentResponse
         */
        public GetWsCustomizedChEntertainmentResponse GetWsCustomizedChEntertainmentWithOptions(GetWsCustomizedChEntertainmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEntertainment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEntertainmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEntertainmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChEntertainmentResponse
         */
        public async Task<GetWsCustomizedChEntertainmentResponse> GetWsCustomizedChEntertainmentWithOptionsAsync(GetWsCustomizedChEntertainmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChEntertainment",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChEntertainmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChEntertainmentRequest
         * @return GetWsCustomizedChEntertainmentResponse
         */
        public GetWsCustomizedChEntertainmentResponse GetWsCustomizedChEntertainment(GetWsCustomizedChEntertainmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedChEntertainmentWithOptions(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChEntertainmentRequest
         * @return GetWsCustomizedChEntertainmentResponse
         */
        public async Task<GetWsCustomizedChEntertainmentResponse> GetWsCustomizedChEntertainmentAsync(GetWsCustomizedChEntertainmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedChEntertainmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary a
         *
         * @param request GetWsCustomizedChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChGeneralResponse
         */
        public GetWsCustomizedChGeneralResponse GetWsCustomizedChGeneralWithOptions(GetWsCustomizedChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary a
         *
         * @param request GetWsCustomizedChGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChGeneralResponse
         */
        public async Task<GetWsCustomizedChGeneralResponse> GetWsCustomizedChGeneralWithOptionsAsync(GetWsCustomizedChGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary a
         *
         * @param request GetWsCustomizedChGeneralRequest
         * @return GetWsCustomizedChGeneralResponse
         */
        public GetWsCustomizedChGeneralResponse GetWsCustomizedChGeneral(GetWsCustomizedChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedChGeneralWithOptions(request, runtime);
        }

        /**
         * @summary a
         *
         * @param request GetWsCustomizedChGeneralRequest
         * @return GetWsCustomizedChGeneralResponse
         */
        public async Task<GetWsCustomizedChGeneralResponse> GetWsCustomizedChGeneralAsync(GetWsCustomizedChGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedChGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChO2ORequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChO2OResponse
         */
        public GetWsCustomizedChO2OResponse GetWsCustomizedChO2OWithOptions(GetWsCustomizedChO2ORequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChO2O",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChO2OResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChO2ORequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedChO2OResponse
         */
        public async Task<GetWsCustomizedChO2OResponse> GetWsCustomizedChO2OWithOptionsAsync(GetWsCustomizedChO2ORequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutType))
            {
                body["OutType"] = request.OutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenizerId))
            {
                body["TokenizerId"] = request.TokenizerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWsCustomizedChO2O",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedChO2OResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedChO2ORequest
         * @return GetWsCustomizedChO2OResponse
         */
        public GetWsCustomizedChO2OResponse GetWsCustomizedChO2O(GetWsCustomizedChO2ORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedChO2OWithOptions(request, runtime);
        }

        /**
         * @param request GetWsCustomizedChO2ORequest
         * @return GetWsCustomizedChO2OResponse
         */
        public async Task<GetWsCustomizedChO2OResponse> GetWsCustomizedChO2OAsync(GetWsCustomizedChO2ORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedChO2OWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsCustomizedSeaEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedSeaEcomResponse
         */
        public GetWsCustomizedSeaEcomResponse GetWsCustomizedSeaEcomWithOptions(GetWsCustomizedSeaEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetWsCustomizedSeaEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedSeaEcomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedSeaEcomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedSeaEcomResponse
         */
        public async Task<GetWsCustomizedSeaEcomResponse> GetWsCustomizedSeaEcomWithOptionsAsync(GetWsCustomizedSeaEcomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetWsCustomizedSeaEcom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedSeaEcomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedSeaEcomRequest
         * @return GetWsCustomizedSeaEcomResponse
         */
        public GetWsCustomizedSeaEcomResponse GetWsCustomizedSeaEcom(GetWsCustomizedSeaEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedSeaEcomWithOptions(request, runtime);
        }

        /**
         * @param request GetWsCustomizedSeaEcomRequest
         * @return GetWsCustomizedSeaEcomResponse
         */
        public async Task<GetWsCustomizedSeaEcomResponse> GetWsCustomizedSeaEcomAsync(GetWsCustomizedSeaEcomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedSeaEcomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetWsCustomizedSeaGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedSeaGeneralResponse
         */
        public GetWsCustomizedSeaGeneralResponse GetWsCustomizedSeaGeneralWithOptions(GetWsCustomizedSeaGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetWsCustomizedSeaGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedSeaGeneralResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedSeaGeneralRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWsCustomizedSeaGeneralResponse
         */
        public async Task<GetWsCustomizedSeaGeneralResponse> GetWsCustomizedSeaGeneralWithOptionsAsync(GetWsCustomizedSeaGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
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
                Action = "GetWsCustomizedSeaGeneral",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWsCustomizedSeaGeneralResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetWsCustomizedSeaGeneralRequest
         * @return GetWsCustomizedSeaGeneralResponse
         */
        public GetWsCustomizedSeaGeneralResponse GetWsCustomizedSeaGeneral(GetWsCustomizedSeaGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWsCustomizedSeaGeneralWithOptions(request, runtime);
        }

        /**
         * @param request GetWsCustomizedSeaGeneralRequest
         * @return GetWsCustomizedSeaGeneralResponse
         */
        public async Task<GetWsCustomizedSeaGeneralResponse> GetWsCustomizedSeaGeneralAsync(GetWsCustomizedSeaGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWsCustomizedSeaGeneralWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导入服务数据
         *
         * @param tmpReq ImportServiceDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportServiceDataResponse
         */
        public ImportServiceDataResponse ImportServiceDataWithOptions(ImportServiceDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportServiceDataShrinkRequest request = new ImportServiceDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Partition))
            {
                request.PartitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Partition, "Partition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionShrink))
            {
                body["Partition"] = request.PartitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPath))
            {
                body["SubPath"] = request.SubPath;
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
                Action = "ImportServiceData",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportServiceDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导入服务数据
         *
         * @param tmpReq ImportServiceDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportServiceDataResponse
         */
        public async Task<ImportServiceDataResponse> ImportServiceDataWithOptionsAsync(ImportServiceDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportServiceDataShrinkRequest request = new ImportServiceDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Partition))
            {
                request.PartitionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Partition, "Partition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionShrink))
            {
                body["Partition"] = request.PartitionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPath))
            {
                body["SubPath"] = request.SubPath;
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
                Action = "ImportServiceData",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportServiceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导入服务数据
         *
         * @param request ImportServiceDataRequest
         * @return ImportServiceDataResponse
         */
        public ImportServiceDataResponse ImportServiceData(ImportServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportServiceDataWithOptions(request, runtime);
        }

        /**
         * @summary 导入服务数据
         *
         * @param request ImportServiceDataRequest
         * @return ImportServiceDataResponse
         */
        public async Task<ImportServiceDataResponse> ImportServiceDataAsync(ImportServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportServiceDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param tmpReq ImportServiceDataV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportServiceDataV2Response
         */
        public ImportServiceDataV2Response ImportServiceDataV2WithOptions(ImportServiceDataV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportServiceDataV2ShrinkRequest request = new ImportServiceDataV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportServiceDataV2",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportServiceDataV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param tmpReq ImportServiceDataV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportServiceDataV2Response
         */
        public async Task<ImportServiceDataV2Response> ImportServiceDataV2WithOptionsAsync(ImportServiceDataV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportServiceDataV2ShrinkRequest request = new ImportServiceDataV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportServiceDataV2",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportServiceDataV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param request ImportServiceDataV2Request
         * @return ImportServiceDataV2Response
         */
        public ImportServiceDataV2Response ImportServiceDataV2(ImportServiceDataV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportServiceDataV2WithOptions(request, runtime);
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param request ImportServiceDataV2Request
         * @return ImportServiceDataV2Response
         */
        public async Task<ImportServiceDataV2Response> ImportServiceDataV2Async(ImportServiceDataV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportServiceDataV2WithOptionsAsync(request, runtime);
        }

        /**
         * @param request InsertCustomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertCustomResponse
         */
        public InsertCustomResponse InsertCustomWithOptions(InsertCustomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                body["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFileName))
            {
                body["CustomFileName"] = request.CustomFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUrl))
            {
                body["CustomUrl"] = request.CustomUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegFileName))
            {
                body["RegFileName"] = request.RegFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegUrl))
            {
                body["RegUrl"] = request.RegUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertCustom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertCustomResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request InsertCustomRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertCustomResponse
         */
        public async Task<InsertCustomResponse> InsertCustomWithOptionsAsync(InsertCustomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                body["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFileName))
            {
                body["CustomFileName"] = request.CustomFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUrl))
            {
                body["CustomUrl"] = request.CustomUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegFileName))
            {
                body["RegFileName"] = request.RegFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegUrl))
            {
                body["RegUrl"] = request.RegUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertCustom",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertCustomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request InsertCustomRequest
         * @return InsertCustomResponse
         */
        public InsertCustomResponse InsertCustom(InsertCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertCustomWithOptions(request, runtime);
        }

        /**
         * @param request InsertCustomRequest
         * @return InsertCustomResponse
         */
        public async Task<InsertCustomResponse> InsertCustomAsync(InsertCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertCustomWithOptionsAsync(request, runtime);
        }

        /**
         * @param request OpenAlinlpServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenAlinlpServiceResponse
         */
        public OpenAlinlpServiceResponse OpenAlinlpServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenAlinlpService",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenAlinlpServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request OpenAlinlpServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenAlinlpServiceResponse
         */
        public async Task<OpenAlinlpServiceResponse> OpenAlinlpServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenAlinlpService",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenAlinlpServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return OpenAlinlpServiceResponse
         */
        public OpenAlinlpServiceResponse OpenAlinlpService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenAlinlpServiceWithOptions(runtime);
        }

        /**
         * @return OpenAlinlpServiceResponse
         */
        public async Task<OpenAlinlpServiceResponse> OpenAlinlpServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenAlinlpServiceWithOptionsAsync(runtime);
        }

        /**
         * @summary 多轮改写
         *
         * @param tmpReq PostISConvRewriterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostISConvRewriterResponse
         */
        public PostISConvRewriterResponse PostISConvRewriterWithOptions(PostISConvRewriterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostISConvRewriterShrinkRequest request = new PostISConvRewriterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                body["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Debug))
            {
                body["Debug"] = request.Debug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                body["Parameters"] = request.ParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostISConvRewriter",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostISConvRewriterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 多轮改写
         *
         * @param tmpReq PostISConvRewriterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostISConvRewriterResponse
         */
        public async Task<PostISConvRewriterResponse> PostISConvRewriterWithOptionsAsync(PostISConvRewriterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostISConvRewriterShrinkRequest request = new PostISConvRewriterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                body["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Debug))
            {
                body["Debug"] = request.Debug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                body["Parameters"] = request.ParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostISConvRewriter",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostISConvRewriterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 多轮改写
         *
         * @param request PostISConvRewriterRequest
         * @return PostISConvRewriterResponse
         */
        public PostISConvRewriterResponse PostISConvRewriter(PostISConvRewriterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostISConvRewriterWithOptions(request, runtime);
        }

        /**
         * @summary 多轮改写
         *
         * @param request PostISConvRewriterRequest
         * @return PostISConvRewriterResponse
         */
        public async Task<PostISConvRewriterResponse> PostISConvRewriterAsync(PostISConvRewriterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostISConvRewriterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开放域搜索判定
         *
         * @param tmpReq PostISRetrieveRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostISRetrieveRouterResponse
         */
        public PostISRetrieveRouterResponse PostISRetrieveRouterWithOptions(PostISRetrieveRouterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostISRetrieveRouterShrinkRequest request = new PostISRetrieveRouterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Debug))
            {
                query["Debug"] = request.Debug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                body["Algorithm"] = request.Algorithm;
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
                Action = "PostISRetrieveRouter",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostISRetrieveRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开放域搜索判定
         *
         * @param tmpReq PostISRetrieveRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostISRetrieveRouterResponse
         */
        public async Task<PostISRetrieveRouterResponse> PostISRetrieveRouterWithOptionsAsync(PostISRetrieveRouterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostISRetrieveRouterShrinkRequest request = new PostISRetrieveRouterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Debug))
            {
                query["Debug"] = request.Debug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                body["Algorithm"] = request.Algorithm;
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
                Action = "PostISRetrieveRouter",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostISRetrieveRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开放域搜索判定
         *
         * @param request PostISRetrieveRouterRequest
         * @return PostISRetrieveRouterResponse
         */
        public PostISRetrieveRouterResponse PostISRetrieveRouter(PostISRetrieveRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostISRetrieveRouterWithOptions(request, runtime);
        }

        /**
         * @summary 开放域搜索判定
         *
         * @param request PostISRetrieveRouterRequest
         * @return PostISRetrieveRouterResponse
         */
        public async Task<PostISRetrieveRouterResponse> PostISRetrieveRouterAsync(PostISRetrieveRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostISRetrieveRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 对话搜索身份凭证生成
         *
         * @param request PostMSConvSearchTokenGeneratedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSConvSearchTokenGeneratedResponse
         */
        public PostMSConvSearchTokenGeneratedResponse PostMSConvSearchTokenGeneratedWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSConvSearchTokenGenerated",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSConvSearchTokenGeneratedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 对话搜索身份凭证生成
         *
         * @param request PostMSConvSearchTokenGeneratedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSConvSearchTokenGeneratedResponse
         */
        public async Task<PostMSConvSearchTokenGeneratedResponse> PostMSConvSearchTokenGeneratedWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSConvSearchTokenGenerated",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSConvSearchTokenGeneratedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 对话搜索身份凭证生成
         *
         * @return PostMSConvSearchTokenGeneratedResponse
         */
        public PostMSConvSearchTokenGeneratedResponse PostMSConvSearchTokenGenerated()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostMSConvSearchTokenGeneratedWithOptions(runtime);
        }

        /**
         * @summary 对话搜索身份凭证生成
         *
         * @return PostMSConvSearchTokenGeneratedResponse
         */
        public async Task<PostMSConvSearchTokenGeneratedResponse> PostMSConvSearchTokenGeneratedAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostMSConvSearchTokenGeneratedWithOptionsAsync(runtime);
        }

        /**
         * @summary 数据处理进度查询
         *
         * @param tmpReq PostMSDataProcessingCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSDataProcessingCountResponse
         */
        public PostMSDataProcessingCountResponse PostMSDataProcessingCountWithOptions(PostMSDataProcessingCountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostMSDataProcessingCountShrinkRequest request = new PostMSDataProcessingCountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIds))
            {
                request.DataIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIds, "DataIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIdsShrink))
            {
                body["DataIds"] = request.DataIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataImportId))
            {
                body["DataImportId"] = request.DataImportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDashScopeOpenAPISource))
            {
                body["X-DashScope-OpenAPISource"] = request.XDashScopeOpenAPISource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSDataProcessingCount",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSDataProcessingCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 数据处理进度查询
         *
         * @param tmpReq PostMSDataProcessingCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSDataProcessingCountResponse
         */
        public async Task<PostMSDataProcessingCountResponse> PostMSDataProcessingCountWithOptionsAsync(PostMSDataProcessingCountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostMSDataProcessingCountShrinkRequest request = new PostMSDataProcessingCountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIds))
            {
                request.DataIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIds, "DataIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIdsShrink))
            {
                body["DataIds"] = request.DataIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataImportId))
            {
                body["DataImportId"] = request.DataImportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDashScopeOpenAPISource))
            {
                body["X-DashScope-OpenAPISource"] = request.XDashScopeOpenAPISource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSDataProcessingCount",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSDataProcessingCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 数据处理进度查询
         *
         * @param request PostMSDataProcessingCountRequest
         * @return PostMSDataProcessingCountResponse
         */
        public PostMSDataProcessingCountResponse PostMSDataProcessingCount(PostMSDataProcessingCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostMSDataProcessingCountWithOptions(request, runtime);
        }

        /**
         * @summary 数据处理进度查询
         *
         * @param request PostMSDataProcessingCountRequest
         * @return PostMSDataProcessingCountResponse
         */
        public async Task<PostMSDataProcessingCountResponse> PostMSDataProcessingCountAsync(PostMSDataProcessingCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostMSDataProcessingCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 搜索增强
         *
         * @param tmpReq PostMSSearchEnhanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSSearchEnhanceResponse
         */
        public PostMSSearchEnhanceResponse PostMSSearchEnhanceWithOptions(PostMSSearchEnhanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostMSSearchEnhanceShrinkRequest request = new PostMSSearchEnhanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomConfigInfo))
            {
                request.CustomConfigInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomConfigInfo, "CustomConfigInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Fields))
            {
                request.FieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Fields, "Fields", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RankModelInfo))
            {
                request.RankModelInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RankModelInfo, "RankModelInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomConfigInfoShrink))
            {
                body["CustomConfigInfo"] = request.CustomConfigInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Debug))
            {
                body["Debug"] = request.Debug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldsShrink))
            {
                body["Fields"] = request.FieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScore))
            {
                body["MinScore"] = request.MinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queries))
            {
                body["Queries"] = request.Queries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankModelInfoShrink))
            {
                body["RankModelInfo"] = request.RankModelInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rows))
            {
                body["Rows"] = request.Rows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uq))
            {
                body["Uq"] = request.Uq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDashScopeOpenAPISource))
            {
                body["X-DashScope-OpenAPISource"] = request.XDashScopeOpenAPISource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSSearchEnhance",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSSearchEnhanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 搜索增强
         *
         * @param tmpReq PostMSSearchEnhanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSSearchEnhanceResponse
         */
        public async Task<PostMSSearchEnhanceResponse> PostMSSearchEnhanceWithOptionsAsync(PostMSSearchEnhanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostMSSearchEnhanceShrinkRequest request = new PostMSSearchEnhanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomConfigInfo))
            {
                request.CustomConfigInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomConfigInfo, "CustomConfigInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Fields))
            {
                request.FieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Fields, "Fields", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RankModelInfo))
            {
                request.RankModelInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RankModelInfo, "RankModelInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomConfigInfoShrink))
            {
                body["CustomConfigInfo"] = request.CustomConfigInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Debug))
            {
                body["Debug"] = request.Debug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldsShrink))
            {
                body["Fields"] = request.FieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScore))
            {
                body["MinScore"] = request.MinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queries))
            {
                body["Queries"] = request.Queries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankModelInfoShrink))
            {
                body["RankModelInfo"] = request.RankModelInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rows))
            {
                body["Rows"] = request.Rows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uq))
            {
                body["Uq"] = request.Uq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDashScopeOpenAPISource))
            {
                body["X-DashScope-OpenAPISource"] = request.XDashScopeOpenAPISource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSSearchEnhance",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSSearchEnhanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索增强
         *
         * @param request PostMSSearchEnhanceRequest
         * @return PostMSSearchEnhanceResponse
         */
        public PostMSSearchEnhanceResponse PostMSSearchEnhance(PostMSSearchEnhanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostMSSearchEnhanceWithOptions(request, runtime);
        }

        /**
         * @summary 搜索增强
         *
         * @param request PostMSSearchEnhanceRequest
         * @return PostMSSearchEnhanceResponse
         */
        public async Task<PostMSSearchEnhanceResponse> PostMSSearchEnhanceAsync(PostMSSearchEnhanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostMSSearchEnhanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param tmpReq PostMSServiceDataImportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSServiceDataImportResponse
         */
        public PostMSServiceDataImportResponse PostMSServiceDataImportWithOptions(PostMSServiceDataImportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostMSServiceDataImportShrinkRequest request = new PostMSServiceDataImportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSServiceDataImport",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSServiceDataImportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param tmpReq PostMSServiceDataImportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PostMSServiceDataImportResponse
         */
        public async Task<PostMSServiceDataImportResponse> PostMSServiceDataImportWithOptionsAsync(PostMSServiceDataImportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PostMSServiceDataImportShrinkRequest request = new PostMSServiceDataImportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostMSServiceDataImport",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostMSServiceDataImportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param request PostMSServiceDataImportRequest
         * @return PostMSServiceDataImportResponse
         */
        public PostMSServiceDataImportResponse PostMSServiceDataImport(PostMSServiceDataImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostMSServiceDataImportWithOptions(request, runtime);
        }

        /**
         * @summary 导入服务数据V2
         *
         * @param request PostMSServiceDataImportRequest
         * @return PostMSServiceDataImportResponse
         */
        public async Task<PostMSServiceDataImportResponse> PostMSServiceDataImportAsync(PostMSServiceDataImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostMSServiceDataImportWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RequestTableQARequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RequestTableQAResponse
         */
        public RequestTableQAResponse RequestTableQAWithOptions(RequestTableQARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestTableQA",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestTableQAResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RequestTableQARequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RequestTableQAResponse
         */
        public async Task<RequestTableQAResponse> RequestTableQAWithOptionsAsync(RequestTableQARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestTableQA",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestTableQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RequestTableQARequest
         * @return RequestTableQAResponse
         */
        public RequestTableQAResponse RequestTableQA(RequestTableQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RequestTableQAWithOptions(request, runtime);
        }

        /**
         * @param request RequestTableQARequest
         * @return RequestTableQAResponse
         */
        public async Task<RequestTableQAResponse> RequestTableQAAsync(RequestTableQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RequestTableQAWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 表格问答在线接口
         *
         * @param request RequestTableQAOnlineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RequestTableQAOnlineResponse
         */
        public RequestTableQAOnlineResponse RequestTableQAOnlineWithOptions(RequestTableQAOnlineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                body["BotId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["Question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestTableQAOnline",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestTableQAOnlineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 表格问答在线接口
         *
         * @param request RequestTableQAOnlineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RequestTableQAOnlineResponse
         */
        public async Task<RequestTableQAOnlineResponse> RequestTableQAOnlineWithOptionsAsync(RequestTableQAOnlineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotId))
            {
                body["BotId"] = request.BotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["Question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestTableQAOnline",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestTableQAOnlineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 表格问答在线接口
         *
         * @param request RequestTableQAOnlineRequest
         * @return RequestTableQAOnlineResponse
         */
        public RequestTableQAOnlineResponse RequestTableQAOnline(RequestTableQAOnlineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RequestTableQAOnlineWithOptions(request, runtime);
        }

        /**
         * @summary 表格问答在线接口
         *
         * @param request RequestTableQAOnlineRequest
         * @return RequestTableQAOnlineResponse
         */
        public async Task<RequestTableQAOnlineResponse> RequestTableQAOnlineAsync(RequestTableQAOnlineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RequestTableQAOnlineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新服务数据
         *
         * @param tmpReq UpdateServiceDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceDataResponse
         */
        public UpdateServiceDataResponse UpdateServiceDataWithOptions(UpdateServiceDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceDataShrinkRequest request = new UpdateServiceDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                body["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceData",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务数据
         *
         * @param tmpReq UpdateServiceDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceDataResponse
         */
        public async Task<UpdateServiceDataResponse> UpdateServiceDataWithOptionsAsync(UpdateServiceDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceDataShrinkRequest request = new UpdateServiceDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                body["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceData",
                Version = "2020-06-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务数据
         *
         * @param request UpdateServiceDataRequest
         * @return UpdateServiceDataResponse
         */
        public UpdateServiceDataResponse UpdateServiceData(UpdateServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceDataWithOptions(request, runtime);
        }

        /**
         * @summary 更新服务数据
         *
         * @param request UpdateServiceDataRequest
         * @return UpdateServiceDataResponse
         */
        public async Task<UpdateServiceDataResponse> UpdateServiceDataAsync(UpdateServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceDataWithOptionsAsync(request, runtime);
        }

    }
}
