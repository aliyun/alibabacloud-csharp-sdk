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
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("address-purification", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public GetAddressGeocodeResponse GetAddressGeocodeWithOptions(GetAddressGeocodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAddressGeocodeResponse>(DoRequest("GetAddressGeocode", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetAddressGeocodeResponse> GetAddressGeocodeWithOptionsAsync(GetAddressGeocodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAddressGeocodeResponse>(await DoRequestAsync("GetAddressGeocode", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public GetAddressGeocodeResponse GetAddressGeocode(GetAddressGeocodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddressGeocodeWithOptions(request, runtime);
        }

        public async Task<GetAddressGeocodeResponse> GetAddressGeocodeAsync(GetAddressGeocodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddressGeocodeWithOptionsAsync(request, runtime);
        }

        public CompleteAddressResponse CompleteAddressWithOptions(CompleteAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompleteAddressResponse>(DoRequest("CompleteAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CompleteAddressResponse> CompleteAddressWithOptionsAsync(CompleteAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompleteAddressResponse>(await DoRequestAsync("CompleteAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public CompleteAddressResponse CompleteAddress(CompleteAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteAddressWithOptions(request, runtime);
        }

        public async Task<CompleteAddressResponse> CompleteAddressAsync(CompleteAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteAddressWithOptionsAsync(request, runtime);
        }

        public GetZipcodeResponse GetZipcodeWithOptions(GetZipcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetZipcodeResponse>(DoRequest("GetZipcode", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetZipcodeResponse> GetZipcodeWithOptionsAsync(GetZipcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetZipcodeResponse>(await DoRequestAsync("GetZipcode", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

        public ExtractPhoneResponse ExtractPhoneWithOptions(ExtractPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExtractPhoneResponse>(DoRequest("ExtractPhone", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ExtractPhoneResponse> ExtractPhoneWithOptionsAsync(ExtractPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExtractPhoneResponse>(await DoRequestAsync("ExtractPhone", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

        public ExtractNameResponse ExtractNameWithOptions(ExtractNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExtractNameResponse>(DoRequest("ExtractName", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ExtractNameResponse> ExtractNameWithOptionsAsync(ExtractNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExtractNameResponse>(await DoRequestAsync("ExtractName", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

        public GetAddressDivisionCodeResponse GetAddressDivisionCodeWithOptions(GetAddressDivisionCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAddressDivisionCodeResponse>(DoRequest("GetAddressDivisionCode", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetAddressDivisionCodeResponse> GetAddressDivisionCodeWithOptionsAsync(GetAddressDivisionCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAddressDivisionCodeResponse>(await DoRequestAsync("GetAddressDivisionCode", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

        public ClassifyPOIResponse ClassifyPOIWithOptions(ClassifyPOIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClassifyPOIResponse>(DoRequest("ClassifyPOI", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ClassifyPOIResponse> ClassifyPOIWithOptionsAsync(ClassifyPOIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClassifyPOIResponse>(await DoRequestAsync("ClassifyPOI", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public ClassifyPOIResponse ClassifyPOI(ClassifyPOIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClassifyPOIWithOptions(request, runtime);
        }

        public async Task<ClassifyPOIResponse> ClassifyPOIAsync(ClassifyPOIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClassifyPOIWithOptionsAsync(request, runtime);
        }

        public StructureAddressResponse StructureAddressWithOptions(StructureAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StructureAddressResponse>(DoRequest("StructureAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StructureAddressResponse> StructureAddressWithOptionsAsync(StructureAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StructureAddressResponse>(await DoRequestAsync("StructureAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

        public ExtractAddressResponse ExtractAddressWithOptions(ExtractAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExtractAddressResponse>(DoRequest("ExtractAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ExtractAddressResponse> ExtractAddressWithOptionsAsync(ExtractAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExtractAddressResponse>(await DoRequestAsync("ExtractAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateProjectShrinkRequest request = new UpdateProjectShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Parameters);
            }
            return TeaModel.ToObject<UpdateProjectResponse>(DoRequest("UpdateProject", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateProjectShrinkRequest request = new UpdateProjectShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Parameters);
            }
            return TeaModel.ToObject<UpdateProjectResponse>(await DoRequestAsync("UpdateProject", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

        public CorrectAddressResponse CorrectAddressWithOptions(CorrectAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CorrectAddressResponse>(DoRequest("CorrectAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CorrectAddressResponse> CorrectAddressWithOptionsAsync(CorrectAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CorrectAddressResponse>(await DoRequestAsync("CorrectAddress", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

        public GetAddressSimilarityResponse GetAddressSimilarityWithOptions(GetAddressSimilarityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAddressSimilarityResponse>(DoRequest("GetAddressSimilarity", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetAddressSimilarityResponse> GetAddressSimilarityWithOptionsAsync(GetAddressSimilarityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAddressSimilarityResponse>(await DoRequestAsync("GetAddressSimilarity", "HTTPS", "POST", "2019-11-18", "AK", null, request.ToMap(), runtime));
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

    }
}
