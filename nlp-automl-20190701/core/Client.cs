// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Nlp_automl20190701.Models;

namespace AlibabaCloud.SDK.Nlp_automl20190701
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("nlp-automl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public PredictMTModelByDocResponse PredictMTModelByDocWithOptions(PredictMTModelByDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PredictMTModelByDocResponse>(DoRequest("PredictMTModelByDoc", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<PredictMTModelByDocResponse> PredictMTModelByDocWithOptionsAsync(PredictMTModelByDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PredictMTModelByDocResponse>(await DoRequestAsync("PredictMTModelByDoc", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public PredictMTModelByDocResponse PredictMTModelByDoc(PredictMTModelByDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictMTModelByDocWithOptions(request, runtime);
        }

        public async Task<PredictMTModelByDocResponse> PredictMTModelByDocAsync(PredictMTModelByDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictMTModelByDocWithOptionsAsync(request, runtime);
        }

        public BindIntervenePackageAndModelResponse BindIntervenePackageAndModelWithOptions(BindIntervenePackageAndModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindIntervenePackageAndModelResponse>(DoRequest("BindIntervenePackageAndModel", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<BindIntervenePackageAndModelResponse> BindIntervenePackageAndModelWithOptionsAsync(BindIntervenePackageAndModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindIntervenePackageAndModelResponse>(await DoRequestAsync("BindIntervenePackageAndModel", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public BindIntervenePackageAndModelResponse BindIntervenePackageAndModel(BindIntervenePackageAndModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindIntervenePackageAndModelWithOptions(request, runtime);
        }

        public async Task<BindIntervenePackageAndModelResponse> BindIntervenePackageAndModelAsync(BindIntervenePackageAndModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindIntervenePackageAndModelWithOptionsAsync(request, runtime);
        }

        public AddMtIntervenePackageResponse AddMtIntervenePackageWithOptions(AddMtIntervenePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddMtIntervenePackageResponse>(DoRequest("AddMtIntervenePackage", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<AddMtIntervenePackageResponse> AddMtIntervenePackageWithOptionsAsync(AddMtIntervenePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddMtIntervenePackageResponse>(await DoRequestAsync("AddMtIntervenePackage", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public AddMtIntervenePackageResponse AddMtIntervenePackage(AddMtIntervenePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMtIntervenePackageWithOptions(request, runtime);
        }

        public async Task<AddMtIntervenePackageResponse> AddMtIntervenePackageAsync(AddMtIntervenePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMtIntervenePackageWithOptionsAsync(request, runtime);
        }

        public GetPredictDocResponse GetPredictDocWithOptions(GetPredictDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPredictDocResponse>(DoRequest("GetPredictDoc", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<GetPredictDocResponse> GetPredictDocWithOptionsAsync(GetPredictDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPredictDocResponse>(await DoRequestAsync("GetPredictDoc", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public GetPredictDocResponse GetPredictDoc(GetPredictDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPredictDocWithOptions(request, runtime);
        }

        public async Task<GetPredictDocResponse> GetPredictDocAsync(GetPredictDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPredictDocWithOptionsAsync(request, runtime);
        }

        public AddMTInterveneWordResponse AddMTInterveneWordWithOptions(AddMTInterveneWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddMTInterveneWordResponse>(DoRequest("AddMTInterveneWord", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<AddMTInterveneWordResponse> AddMTInterveneWordWithOptionsAsync(AddMTInterveneWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddMTInterveneWordResponse>(await DoRequestAsync("AddMTInterveneWord", "HTTPS", "POST", "2019-07-01", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public AddMTInterveneWordResponse AddMTInterveneWord(AddMTInterveneWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMTInterveneWordWithOptions(request, runtime);
        }

        public async Task<AddMTInterveneWordResponse> AddMTInterveneWordAsync(AddMTInterveneWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMTInterveneWordWithOptionsAsync(request, runtime);
        }

        public PredictMTModelResponse PredictMTModelWithOptions(PredictMTModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PredictMTModelResponse>(DoRequest("PredictMTModel", "HTTPS", "POST", "2019-07-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PredictMTModelResponse> PredictMTModelWithOptionsAsync(PredictMTModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PredictMTModelResponse>(await DoRequestAsync("PredictMTModel", "HTTPS", "POST", "2019-07-01", "AK", null, request.ToMap(), runtime));
        }

        public PredictMTModelResponse PredictMTModel(PredictMTModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictMTModelWithOptions(request, runtime);
        }

        public async Task<PredictMTModelResponse> PredictMTModelAsync(PredictMTModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictMTModelWithOptionsAsync(request, runtime);
        }

        public InvokeActionResponse InvokeActionWithOptions(InvokeActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeActionResponse>(DoRequest("InvokeAction", "HTTPS", "POST", "2019-07-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeActionResponse> InvokeActionWithOptionsAsync(InvokeActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeActionResponse>(await DoRequestAsync("InvokeAction", "HTTPS", "POST", "2019-07-01", "AK", null, request.ToMap(), runtime));
        }

        public InvokeActionResponse InvokeAction(InvokeActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeActionWithOptions(request, runtime);
        }

        public async Task<InvokeActionResponse> InvokeActionAsync(InvokeActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeActionWithOptionsAsync(request, runtime);
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
