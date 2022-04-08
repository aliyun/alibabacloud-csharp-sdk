// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Address_purification20191118.Models;

namespace AlibabaCloud.SDK.Address_purification20191118
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("address-purification", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CorrectAddressResponse CorrectAddressWithOptions(CorrectAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "CorrectAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorrectAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CorrectAddressResponse> CorrectAddressWithOptionsAsync(CorrectAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "CorrectAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorrectAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CorrectAddressResponse CorrectAddress(CorrectAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CorrectAddressWithOptions(request, runtime);
        }

        public async Task<CorrectAddressResponse> CorrectAddressAsync(CorrectAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CorrectAddressWithOptionsAsync(request, runtime);
        }

        public ExtractAddressResponse ExtractAddressWithOptions(ExtractAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "ExtractAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExtractAddressResponse> ExtractAddressWithOptionsAsync(ExtractAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "ExtractAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExtractAddressResponse ExtractAddress(ExtractAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtractAddressWithOptions(request, runtime);
        }

        public async Task<ExtractAddressResponse> ExtractAddressAsync(ExtractAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtractAddressWithOptionsAsync(request, runtime);
        }

        public ExtractNameResponse ExtractNameWithOptions(ExtractNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "ExtractName",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExtractNameResponse> ExtractNameWithOptionsAsync(ExtractNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "ExtractName",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExtractNameResponse ExtractName(ExtractNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtractNameWithOptions(request, runtime);
        }

        public async Task<ExtractNameResponse> ExtractNameAsync(ExtractNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtractNameWithOptionsAsync(request, runtime);
        }

        public ExtractPhoneResponse ExtractPhoneWithOptions(ExtractPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "ExtractPhone",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractPhoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExtractPhoneResponse> ExtractPhoneWithOptionsAsync(ExtractPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "ExtractPhone",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractPhoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExtractPhoneResponse ExtractPhone(ExtractPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtractPhoneWithOptions(request, runtime);
        }

        public async Task<ExtractPhoneResponse> ExtractPhoneAsync(ExtractPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtractPhoneWithOptionsAsync(request, runtime);
        }

        public GetAddressDivisionCodeResponse GetAddressDivisionCodeWithOptions(GetAddressDivisionCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "GetAddressDivisionCode",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddressDivisionCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAddressDivisionCodeResponse> GetAddressDivisionCodeWithOptionsAsync(GetAddressDivisionCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "GetAddressDivisionCode",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddressDivisionCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAddressDivisionCodeResponse GetAddressDivisionCode(GetAddressDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddressDivisionCodeWithOptions(request, runtime);
        }

        public async Task<GetAddressDivisionCodeResponse> GetAddressDivisionCodeAsync(GetAddressDivisionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddressDivisionCodeWithOptionsAsync(request, runtime);
        }

        public GetAddressSimilarityResponse GetAddressSimilarityWithOptions(GetAddressSimilarityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "GetAddressSimilarity",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddressSimilarityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAddressSimilarityResponse> GetAddressSimilarityWithOptionsAsync(GetAddressSimilarityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "GetAddressSimilarity",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddressSimilarityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAddressSimilarityResponse GetAddressSimilarity(GetAddressSimilarityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddressSimilarityWithOptions(request, runtime);
        }

        public async Task<GetAddressSimilarityResponse> GetAddressSimilarityAsync(GetAddressSimilarityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddressSimilarityWithOptionsAsync(request, runtime);
        }

        public GetZipcodeResponse GetZipcodeWithOptions(GetZipcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "GetZipcode",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetZipcodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetZipcodeResponse> GetZipcodeWithOptionsAsync(GetZipcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "GetZipcode",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetZipcodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetZipcodeResponse GetZipcode(GetZipcodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetZipcodeWithOptions(request, runtime);
        }

        public async Task<GetZipcodeResponse> GetZipcodeAsync(GetZipcodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetZipcodeWithOptionsAsync(request, runtime);
        }

        public StructureAddressResponse StructureAddressWithOptions(StructureAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "StructureAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StructureAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StructureAddressResponse> StructureAddressWithOptionsAsync(StructureAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                body["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                body["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                body["DefaultProvince"] = request.DefaultProvince;
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
                Action = "StructureAddress",
                Version = "2019-11-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StructureAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StructureAddressResponse StructureAddress(StructureAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StructureAddressWithOptions(request, runtime);
        }

        public async Task<StructureAddressResponse> StructureAddressAsync(StructureAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StructureAddressWithOptionsAsync(request, runtime);
        }

    }
}
