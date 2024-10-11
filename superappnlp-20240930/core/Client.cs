// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.SuperappNlp20240930.Models;

namespace AlibabaCloud.SDK.SuperappNlp20240930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("superappnlp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>地址解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NlpAddressNormalizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NlpAddressNormalizationResponse
        /// </returns>
        public NlpAddressNormalizationResponse NlpAddressNormalizationWithOptions(NlpAddressNormalizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityStdManual))
            {
                query["CityStdManual"] = request.CityStdManual;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityStr))
            {
                query["CityStr"] = request.CityStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictStdManual))
            {
                query["DistrictStdManual"] = request.DistrictStdManual;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceStdManual))
            {
                query["ProvinceStdManual"] = request.ProvinceStdManual;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceStr))
            {
                query["ProvinceStr"] = request.ProvinceStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStr))
            {
                query["QueryStr"] = request.QueryStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NlpAddressNormalization",
                Version = "2024-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NlpAddressNormalizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>地址解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NlpAddressNormalizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NlpAddressNormalizationResponse
        /// </returns>
        public async Task<NlpAddressNormalizationResponse> NlpAddressNormalizationWithOptionsAsync(NlpAddressNormalizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityStdManual))
            {
                query["CityStdManual"] = request.CityStdManual;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityStr))
            {
                query["CityStr"] = request.CityStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictStdManual))
            {
                query["DistrictStdManual"] = request.DistrictStdManual;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceStdManual))
            {
                query["ProvinceStdManual"] = request.ProvinceStdManual;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceStr))
            {
                query["ProvinceStr"] = request.ProvinceStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStr))
            {
                query["QueryStr"] = request.QueryStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NlpAddressNormalization",
                Version = "2024-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NlpAddressNormalizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>地址解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NlpAddressNormalizationRequest
        /// </param>
        /// 
        /// <returns>
        /// NlpAddressNormalizationResponse
        /// </returns>
        public NlpAddressNormalizationResponse NlpAddressNormalization(NlpAddressNormalizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NlpAddressNormalizationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>地址解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NlpAddressNormalizationRequest
        /// </param>
        /// 
        /// <returns>
        /// NlpAddressNormalizationResponse
        /// </returns>
        public async Task<NlpAddressNormalizationResponse> NlpAddressNormalizationAsync(NlpAddressNormalizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NlpAddressNormalizationWithOptionsAsync(request, runtime);
        }

    }
}
