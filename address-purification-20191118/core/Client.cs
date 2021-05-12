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

        public GetAddressDivisionCodeResponse GetAddressDivisionCodeWithOptions(GetAddressDivisionCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressDivisionCodeResponse>(DoRPCRequest("GetAddressDivisionCode", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAddressDivisionCodeResponse> GetAddressDivisionCodeWithOptionsAsync(GetAddressDivisionCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressDivisionCodeResponse>(await DoRPCRequestAsync("GetAddressDivisionCode", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StructureAddressResponse StructureAddressWithOptions(StructureAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StructureAddressResponse>(DoRPCRequest("StructureAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StructureAddressResponse> StructureAddressWithOptionsAsync(StructureAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StructureAddressResponse>(await DoRPCRequestAsync("StructureAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ExtractExpressResponse ExtractExpressWithOptions(ExtractExpressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractExpressResponse>(DoRPCRequest("ExtractExpress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExtractExpressResponse> ExtractExpressWithOptionsAsync(ExtractExpressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractExpressResponse>(await DoRPCRequestAsync("ExtractExpress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExtractExpressResponse ExtractExpress(ExtractExpressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtractExpressWithOptions(request, runtime);
        }

        public async Task<ExtractExpressResponse> ExtractExpressAsync(ExtractExpressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtractExpressWithOptionsAsync(request, runtime);
        }

        public ExtractNameResponse ExtractNameWithOptions(ExtractNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractNameResponse>(DoRPCRequest("ExtractName", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExtractNameResponse> ExtractNameWithOptionsAsync(ExtractNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractNameResponse>(await DoRPCRequestAsync("ExtractName", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetAddressBlockMappingResponse GetAddressBlockMappingWithOptions(GetAddressBlockMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressBlockMappingResponse>(DoRPCRequest("GetAddressBlockMapping", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAddressBlockMappingResponse> GetAddressBlockMappingWithOptionsAsync(GetAddressBlockMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressBlockMappingResponse>(await DoRPCRequestAsync("GetAddressBlockMapping", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAddressBlockMappingResponse GetAddressBlockMapping(GetAddressBlockMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddressBlockMappingWithOptions(request, runtime);
        }

        public async Task<GetAddressBlockMappingResponse> GetAddressBlockMappingAsync(GetAddressBlockMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddressBlockMappingWithOptionsAsync(request, runtime);
        }

        public GetAddressSearchResponse GetAddressSearchWithOptions(GetAddressSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressSearchResponse>(DoRPCRequest("GetAddressSearch", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAddressSearchResponse> GetAddressSearchWithOptionsAsync(GetAddressSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressSearchResponse>(await DoRPCRequestAsync("GetAddressSearch", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAddressSearchResponse GetAddressSearch(GetAddressSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddressSearchWithOptions(request, runtime);
        }

        public async Task<GetAddressSearchResponse> GetAddressSearchAsync(GetAddressSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddressSearchWithOptionsAsync(request, runtime);
        }

        public PredictPOIResponse PredictPOIWithOptions(PredictPOIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictPOIResponse>(DoRPCRequest("PredictPOI", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PredictPOIResponse> PredictPOIWithOptionsAsync(PredictPOIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictPOIResponse>(await DoRPCRequestAsync("PredictPOI", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PredictPOIResponse PredictPOI(PredictPOIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictPOIWithOptions(request, runtime);
        }

        public async Task<PredictPOIResponse> PredictPOIAsync(PredictPOIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictPOIWithOptionsAsync(request, runtime);
        }

        public ClassifyPOIResponse ClassifyPOIWithOptions(ClassifyPOIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClassifyPOIResponse>(DoRPCRequest("ClassifyPOI", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClassifyPOIResponse> ClassifyPOIWithOptionsAsync(ClassifyPOIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClassifyPOIResponse>(await DoRPCRequestAsync("ClassifyPOI", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CorrectAddressResponse CorrectAddressWithOptions(CorrectAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CorrectAddressResponse>(DoRPCRequest("CorrectAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CorrectAddressResponse> CorrectAddressWithOptionsAsync(CorrectAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CorrectAddressResponse>(await DoRPCRequestAsync("CorrectAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetZipcodeResponse GetZipcodeWithOptions(GetZipcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetZipcodeResponse>(DoRPCRequest("GetZipcode", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetZipcodeResponse> GetZipcodeWithOptionsAsync(GetZipcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetZipcodeResponse>(await DoRPCRequestAsync("GetZipcode", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CompleteAddressResponse CompleteAddressWithOptions(CompleteAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteAddressResponse>(DoRPCRequest("CompleteAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompleteAddressResponse> CompleteAddressWithOptionsAsync(CompleteAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteAddressResponse>(await DoRPCRequestAsync("CompleteAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetAddressSimilarityResponse GetAddressSimilarityWithOptions(GetAddressSimilarityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressSimilarityResponse>(DoRPCRequest("GetAddressSimilarity", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAddressSimilarityResponse> GetAddressSimilarityWithOptionsAsync(GetAddressSimilarityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressSimilarityResponse>(await DoRPCRequestAsync("GetAddressSimilarity", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetAddressGeocodeResponse GetAddressGeocodeWithOptions(GetAddressGeocodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressGeocodeResponse>(DoRPCRequest("GetAddressGeocode", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAddressGeocodeResponse> GetAddressGeocodeWithOptionsAsync(GetAddressGeocodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressGeocodeResponse>(await DoRPCRequestAsync("GetAddressGeocode", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TransferCoordResponse TransferCoordWithOptions(TransferCoordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferCoordResponse>(DoRPCRequest("TransferCoord", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferCoordResponse> TransferCoordWithOptionsAsync(TransferCoordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferCoordResponse>(await DoRPCRequestAsync("TransferCoord", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransferCoordResponse TransferCoord(TransferCoordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferCoordWithOptions(request, runtime);
        }

        public async Task<TransferCoordResponse> TransferCoordAsync(TransferCoordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferCoordWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProjectShrinkRequest request = new UpdateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(DoRPCRequest("UpdateProject", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProjectShrinkRequest request = new UpdateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await DoRPCRequestAsync("UpdateProject", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ExtractPhoneResponse ExtractPhoneWithOptions(ExtractPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractPhoneResponse>(DoRPCRequest("ExtractPhone", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExtractPhoneResponse> ExtractPhoneWithOptionsAsync(ExtractPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractPhoneResponse>(await DoRPCRequestAsync("ExtractPhone", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetInputSearchResponse GetInputSearchWithOptions(GetInputSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInputSearchResponse>(DoRPCRequest("GetInputSearch", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInputSearchResponse> GetInputSearchWithOptionsAsync(GetInputSearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInputSearchResponse>(await DoRPCRequestAsync("GetInputSearch", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInputSearchResponse GetInputSearch(GetInputSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInputSearchWithOptions(request, runtime);
        }

        public async Task<GetInputSearchResponse> GetInputSearchAsync(GetInputSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInputSearchWithOptionsAsync(request, runtime);
        }

        public GetAddressEvaluateResponse GetAddressEvaluateWithOptions(GetAddressEvaluateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressEvaluateResponse>(DoRPCRequest("GetAddressEvaluate", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAddressEvaluateResponse> GetAddressEvaluateWithOptionsAsync(GetAddressEvaluateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAddressEvaluateResponse>(await DoRPCRequestAsync("GetAddressEvaluate", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAddressEvaluateResponse GetAddressEvaluate(GetAddressEvaluateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddressEvaluateWithOptions(request, runtime);
        }

        public async Task<GetAddressEvaluateResponse> GetAddressEvaluateAsync(GetAddressEvaluateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddressEvaluateWithOptionsAsync(request, runtime);
        }

        public ExtractAddressResponse ExtractAddressWithOptions(ExtractAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractAddressResponse>(DoRPCRequest("ExtractAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExtractAddressResponse> ExtractAddressWithOptionsAsync(ExtractAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExtractAddressResponse>(await DoRPCRequestAsync("ExtractAddress", "2019-11-18", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
