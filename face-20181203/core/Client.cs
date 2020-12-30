// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Face20181203.Models;

namespace AlibabaCloud.SDK.Face20181203
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("face", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddFaceResponse AddFaceWithOptions(AddFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceResponse>(DoRPCRequest("AddFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceResponse> AddFaceWithOptionsAsync(AddFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceResponse>(await DoRPCRequestAsync("AddFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddFaceResponse AddFace(AddFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceWithOptions(request, runtime);
        }

        public async Task<AddFaceResponse> AddFaceAsync(AddFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceWithOptionsAsync(request, runtime);
        }

        public DeleteFaceResponse DeleteFaceWithOptions(DeleteFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceResponse>(DoRPCRequest("DeleteFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceResponse> DeleteFaceWithOptionsAsync(DeleteFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceResponse>(await DoRPCRequestAsync("DeleteFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFaceResponse DeleteFace(DeleteFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceWithOptions(request, runtime);
        }

        public async Task<DeleteFaceResponse> DeleteFaceAsync(DeleteFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceWithOptionsAsync(request, runtime);
        }

        public DetectFaceResponse DetectFaceWithOptions(DetectFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectFaceResponse>(DoRPCRequest("DetectFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectFaceResponse> DetectFaceWithOptionsAsync(DetectFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectFaceResponse>(await DoRPCRequestAsync("DetectFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectFaceResponse DetectFace(DetectFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectFaceWithOptions(request, runtime);
        }

        public async Task<DetectFaceResponse> DetectFaceAsync(DetectFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectFaceWithOptionsAsync(request, runtime);
        }

        public GetFaceAttributeResponse GetFaceAttributeWithOptions(GetFaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceAttributeResponse>(DoRPCRequest("GetFaceAttribute", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFaceAttributeResponse> GetFaceAttributeWithOptionsAsync(GetFaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceAttributeResponse>(await DoRPCRequestAsync("GetFaceAttribute", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFaceAttributeResponse GetFaceAttribute(GetFaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFaceAttributeWithOptions(request, runtime);
        }

        public async Task<GetFaceAttributeResponse> GetFaceAttributeAsync(GetFaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFaceAttributeWithOptionsAsync(request, runtime);
        }

        public ListFaceResponse ListFaceWithOptions(ListFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceResponse>(DoRPCRequest("ListFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFaceResponse> ListFaceWithOptionsAsync(ListFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFaceResponse>(await DoRPCRequestAsync("ListFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFaceResponse ListFace(ListFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFaceWithOptions(request, runtime);
        }

        public async Task<ListFaceResponse> ListFaceAsync(ListFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFaceWithOptionsAsync(request, runtime);
        }

        public ListGroupResponse ListGroupWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListGroupResponse>(DoRPCRequest("ListGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListGroupResponse> ListGroupWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListGroupResponse>(await DoRPCRequestAsync("ListGroup", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListGroupResponse ListGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupWithOptions(runtime);
        }

        public async Task<ListGroupResponse> ListGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupWithOptionsAsync(runtime);
        }

        public RecognizeFaceResponse RecognizeFaceWithOptions(RecognizeFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeFaceResponse>(DoRPCRequest("RecognizeFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecognizeFaceResponse> RecognizeFaceWithOptionsAsync(RecognizeFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeFaceResponse>(await DoRPCRequestAsync("RecognizeFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecognizeFaceResponse RecognizeFace(RecognizeFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFaceWithOptions(request, runtime);
        }

        public async Task<RecognizeFaceResponse> RecognizeFaceAsync(RecognizeFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFaceWithOptionsAsync(request, runtime);
        }

        public VerifyFaceResponse VerifyFaceWithOptions(VerifyFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyFaceResponse>(DoRPCRequest("VerifyFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyFaceResponse> VerifyFaceWithOptionsAsync(VerifyFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyFaceResponse>(await DoRPCRequestAsync("VerifyFace", "2018-12-03", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyFaceResponse VerifyFace(VerifyFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyFaceWithOptions(request, runtime);
        }

        public async Task<VerifyFaceResponse> VerifyFaceAsync(VerifyFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyFaceWithOptionsAsync(request, runtime);
        }

    }
}
