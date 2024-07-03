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
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("nlp-automl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request AddMTInterveneWordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMTInterveneWordResponse
         */
        public AddMTInterveneWordResponse AddMTInterveneWordWithOptions(AddMTInterveneWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                query["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                query["SourceText"] = request.SourceText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetText))
            {
                query["TargetText"] = request.TargetText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMTInterveneWord",
                Version = "2019-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMTInterveneWordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddMTInterveneWordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMTInterveneWordResponse
         */
        public async Task<AddMTInterveneWordResponse> AddMTInterveneWordWithOptionsAsync(AddMTInterveneWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                query["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                query["SourceText"] = request.SourceText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetText))
            {
                query["TargetText"] = request.TargetText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMTInterveneWord",
                Version = "2019-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMTInterveneWordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddMTInterveneWordRequest
         * @return AddMTInterveneWordResponse
         */
        public AddMTInterveneWordResponse AddMTInterveneWord(AddMTInterveneWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMTInterveneWordWithOptions(request, runtime);
        }

        /**
         * @param request AddMTInterveneWordRequest
         * @return AddMTInterveneWordResponse
         */
        public async Task<AddMTInterveneWordResponse> AddMTInterveneWordAsync(AddMTInterveneWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMTInterveneWordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetPredictDocRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPredictDocResponse
         */
        public GetPredictDocResponse GetPredictDocWithOptions(GetPredictDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                query["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPredictDoc",
                Version = "2019-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPredictDocResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetPredictDocRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPredictDocResponse
         */
        public async Task<GetPredictDocResponse> GetPredictDocWithOptionsAsync(GetPredictDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                query["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPredictDoc",
                Version = "2019-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPredictDocResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetPredictDocRequest
         * @return GetPredictDocResponse
         */
        public GetPredictDocResponse GetPredictDoc(GetPredictDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPredictDocWithOptions(request, runtime);
        }

        /**
         * @param request GetPredictDocRequest
         * @return GetPredictDocResponse
         */
        public async Task<GetPredictDocResponse> GetPredictDocAsync(GetPredictDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPredictDocWithOptionsAsync(request, runtime);
        }

        /**
         * @param request PredictMTModelByDocRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PredictMTModelByDocResponse
         */
        public PredictMTModelByDocResponse PredictMTModelByDocWithOptions(PredictMTModelByDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedXLIFF))
            {
                query["NeedXLIFF"] = request.NeedXLIFF;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileContent))
            {
                body["FileContent"] = request.FileContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PredictMTModelByDoc",
                Version = "2019-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PredictMTModelByDocResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request PredictMTModelByDocRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PredictMTModelByDocResponse
         */
        public async Task<PredictMTModelByDocResponse> PredictMTModelByDocWithOptionsAsync(PredictMTModelByDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedXLIFF))
            {
                query["NeedXLIFF"] = request.NeedXLIFF;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileContent))
            {
                body["FileContent"] = request.FileContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PredictMTModelByDoc",
                Version = "2019-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PredictMTModelByDocResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request PredictMTModelByDocRequest
         * @return PredictMTModelByDocResponse
         */
        public PredictMTModelByDocResponse PredictMTModelByDoc(PredictMTModelByDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictMTModelByDocWithOptions(request, runtime);
        }

        /**
         * @param request PredictMTModelByDocRequest
         * @return PredictMTModelByDocResponse
         */
        public async Task<PredictMTModelByDocResponse> PredictMTModelByDocAsync(PredictMTModelByDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictMTModelByDocWithOptionsAsync(request, runtime);
        }

    }
}
