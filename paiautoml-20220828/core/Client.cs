// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PaiAutoML20220828.Models;

namespace AlibabaCloud.SDK.PaiAutoML20220828
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("paiautoml", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary CreateAutofeExperiment
         *
         * @param request CreateAutofeExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutofeExperimentResponse
         */
        public CreateAutofeExperimentResponse CreateAutofeExperimentWithOptions(CreateAutofeExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutofeExperimentConfiguration))
            {
                body["AutofeExperimentConfiguration"] = request.AutofeExperimentConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutofeExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/autofe/experiment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutofeExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CreateAutofeExperiment
         *
         * @param request CreateAutofeExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutofeExperimentResponse
         */
        public async Task<CreateAutofeExperimentResponse> CreateAutofeExperimentWithOptionsAsync(CreateAutofeExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutofeExperimentConfiguration))
            {
                body["AutofeExperimentConfiguration"] = request.AutofeExperimentConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutofeExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/autofe/experiment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAutofeExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CreateAutofeExperiment
         *
         * @param request CreateAutofeExperimentRequest
         * @return CreateAutofeExperimentResponse
         */
        public CreateAutofeExperimentResponse CreateAutofeExperiment(CreateAutofeExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAutofeExperimentWithOptions(request, headers, runtime);
        }

        /**
         * @summary CreateAutofeExperiment
         *
         * @param request CreateAutofeExperimentRequest
         * @return CreateAutofeExperimentResponse
         */
        public async Task<CreateAutofeExperimentResponse> CreateAutofeExperimentAsync(CreateAutofeExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAutofeExperimentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Create an HyperParameter Optimization experiment.
         *
         * @param request CreateHpoExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHpoExperimentResponse
         */
        public CreateHpoExperimentResponse CreateHpoExperimentWithOptions(CreateHpoExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpoExperimentConfiguration))
            {
                body["HpoExperimentConfiguration"] = request.HpoExperimentConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHpoExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Create an HyperParameter Optimization experiment.
         *
         * @param request CreateHpoExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHpoExperimentResponse
         */
        public async Task<CreateHpoExperimentResponse> CreateHpoExperimentWithOptionsAsync(CreateHpoExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpoExperimentConfiguration))
            {
                body["HpoExperimentConfiguration"] = request.HpoExperimentConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHpoExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Create an HyperParameter Optimization experiment.
         *
         * @param request CreateHpoExperimentRequest
         * @return CreateHpoExperimentResponse
         */
        public CreateHpoExperimentResponse CreateHpoExperiment(CreateHpoExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHpoExperimentWithOptions(request, headers, runtime);
        }

        /**
         * @summary Create an HyperParameter Optimization experiment.
         *
         * @param request CreateHpoExperimentRequest
         * @return CreateHpoExperimentResponse
         */
        public async Task<CreateHpoExperimentResponse> CreateHpoExperimentAsync(CreateHpoExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHpoExperimentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary CreateServiceIdentityRole
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceIdentityRoleResponse
         */
        public CreateServiceIdentityRoleResponse CreateServiceIdentityRoleWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceIdentityRole",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/serviceidentityrole",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceIdentityRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CreateServiceIdentityRole
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceIdentityRoleResponse
         */
        public async Task<CreateServiceIdentityRoleResponse> CreateServiceIdentityRoleWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceIdentityRole",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/serviceidentityrole",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceIdentityRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CreateServiceIdentityRole
         *
         * @return CreateServiceIdentityRoleResponse
         */
        public CreateServiceIdentityRoleResponse CreateServiceIdentityRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceIdentityRoleWithOptions(headers, runtime);
        }

        /**
         * @summary CreateServiceIdentityRole
         *
         * @return CreateServiceIdentityRoleResponse
         */
        public async Task<CreateServiceIdentityRoleResponse> CreateServiceIdentityRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceIdentityRoleWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Delete an HPO experiment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHpoExperimentResponse
         */
        public DeleteHpoExperimentResponse DeleteHpoExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/delete",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHpoExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Delete an HPO experiment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHpoExperimentResponse
         */
        public async Task<DeleteHpoExperimentResponse> DeleteHpoExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/delete",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHpoExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Delete an HPO experiment
         *
         * @return DeleteHpoExperimentResponse
         */
        public DeleteHpoExperimentResponse DeleteHpoExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHpoExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary Delete an HPO experiment
         *
         * @return DeleteHpoExperimentResponse
         */
        public async Task<DeleteHpoExperimentResponse> DeleteHpoExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHpoExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary Get AutoFE Experiment。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutofeExperimentResponse
         */
        public GetAutofeExperimentResponse GetAutofeExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutofeExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/autofe/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutofeExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Get AutoFE Experiment。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutofeExperimentResponse
         */
        public async Task<GetAutofeExperimentResponse> GetAutofeExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutofeExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/autofe/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutofeExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Get AutoFE Experiment。
         *
         * @return GetAutofeExperimentResponse
         */
        public GetAutofeExperimentResponse GetAutofeExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAutofeExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary Get AutoFE Experiment。
         *
         * @return GetAutofeExperimentResponse
         */
        public async Task<GetAutofeExperimentResponse> GetAutofeExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAutofeExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary get hpo experiment by user id and exp id
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHpoExperimentResponse
         */
        public GetHpoExperimentResponse GetHpoExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHpoExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get hpo experiment by user id and exp id
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHpoExperimentResponse
         */
        public async Task<GetHpoExperimentResponse> GetHpoExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHpoExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get hpo experiment by user id and exp id
         *
         * @return GetHpoExperimentResponse
         */
        public GetHpoExperimentResponse GetHpoExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHpoExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary get hpo experiment by user id and exp id
         *
         * @return GetHpoExperimentResponse
         */
        public async Task<GetHpoExperimentResponse> GetHpoExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHpoExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary Get trial detail information
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHpoTrialResponse
         */
        public GetHpoTrialResponse GetHpoTrialWithOptions(string ExperimentId, string TrialId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHpoTrial",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHpoTrialResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Get trial detail information
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHpoTrialResponse
         */
        public async Task<GetHpoTrialResponse> GetHpoTrialWithOptionsAsync(string ExperimentId, string TrialId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHpoTrial",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHpoTrialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Get trial detail information
         *
         * @return GetHpoTrialResponse
         */
        public GetHpoTrialResponse GetHpoTrial(string ExperimentId, string TrialId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHpoTrialWithOptions(ExperimentId, TrialId, headers, runtime);
        }

        /**
         * @summary Get trial detail information
         *
         * @return GetHpoTrialResponse
         */
        public async Task<GetHpoTrialResponse> GetHpoTrialAsync(string ExperimentId, string TrialId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHpoTrialWithOptionsAsync(ExperimentId, TrialId, headers, runtime);
        }

        /**
         * @summary GetServiceIdentityRole, return role name if SLR exists, empty otherwise
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceIdentityRoleResponse
         */
        public GetServiceIdentityRoleResponse GetServiceIdentityRoleWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceIdentityRole",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/serviceidentityrole",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceIdentityRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetServiceIdentityRole, return role name if SLR exists, empty otherwise
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceIdentityRoleResponse
         */
        public async Task<GetServiceIdentityRoleResponse> GetServiceIdentityRoleWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceIdentityRole",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/serviceidentityrole",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceIdentityRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetServiceIdentityRole, return role name if SLR exists, empty otherwise
         *
         * @return GetServiceIdentityRoleResponse
         */
        public GetServiceIdentityRoleResponse GetServiceIdentityRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceIdentityRoleWithOptions(headers, runtime);
        }

        /**
         * @summary GetServiceIdentityRole, return role name if SLR exists, empty otherwise
         *
         * @return GetServiceIdentityRoleResponse
         */
        public async Task<GetServiceIdentityRoleResponse> GetServiceIdentityRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceIdentityRoleWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary list the content of a specified hpo experiment log
         *
         * @param request ListHpoExperimentLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoExperimentLogsResponse
         */
        public ListHpoExperimentLogsResponse ListHpoExperimentLogsWithOptions(string ExperimentId, ListHpoExperimentLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogName))
            {
                query["LogName"] = request.LogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoExperimentLogs",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoExperimentLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list the content of a specified hpo experiment log
         *
         * @param request ListHpoExperimentLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoExperimentLogsResponse
         */
        public async Task<ListHpoExperimentLogsResponse> ListHpoExperimentLogsWithOptionsAsync(string ExperimentId, ListHpoExperimentLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogName))
            {
                query["LogName"] = request.LogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoExperimentLogs",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoExperimentLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list the content of a specified hpo experiment log
         *
         * @param request ListHpoExperimentLogsRequest
         * @return ListHpoExperimentLogsResponse
         */
        public ListHpoExperimentLogsResponse ListHpoExperimentLogs(string ExperimentId, ListHpoExperimentLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHpoExperimentLogsWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary list the content of a specified hpo experiment log
         *
         * @param request ListHpoExperimentLogsRequest
         * @return ListHpoExperimentLogsResponse
         */
        public async Task<ListHpoExperimentLogsResponse> ListHpoExperimentLogsAsync(string ExperimentId, ListHpoExperimentLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHpoExperimentLogsWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary List HPO experiments
         *
         * @param request ListHpoExperimentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoExperimentsResponse
         */
        public ListHpoExperimentsResponse ListHpoExperimentsWithOptions(ListHpoExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeConfigData))
            {
                query["IncludeConfigData"] = request.IncludeConfigData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCreateTime))
            {
                query["MaxCreateTime"] = request.MaxCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCreateTime))
            {
                query["MinCreateTime"] = request.MinCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoExperiments",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoExperimentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary List HPO experiments
         *
         * @param request ListHpoExperimentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoExperimentsResponse
         */
        public async Task<ListHpoExperimentsResponse> ListHpoExperimentsWithOptionsAsync(ListHpoExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeConfigData))
            {
                query["IncludeConfigData"] = request.IncludeConfigData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCreateTime))
            {
                query["MaxCreateTime"] = request.MaxCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCreateTime))
            {
                query["MinCreateTime"] = request.MinCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoExperiments",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary List HPO experiments
         *
         * @param request ListHpoExperimentsRequest
         * @return ListHpoExperimentsResponse
         */
        public ListHpoExperimentsResponse ListHpoExperiments(ListHpoExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHpoExperimentsWithOptions(request, headers, runtime);
        }

        /**
         * @summary List HPO experiments
         *
         * @param request ListHpoExperimentsRequest
         * @return ListHpoExperimentsResponse
         */
        public async Task<ListHpoExperimentsResponse> ListHpoExperimentsAsync(ListHpoExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHpoExperimentsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 返回一个trial所对应的任务里所有已经执行的命令
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialCommandsResponse
         */
        public ListHpoTrialCommandsResponse ListHpoTrialCommandsWithOptions(string ExperimentId, string TrialId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrialCommands",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId) + "/commands",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialCommandsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 返回一个trial所对应的任务里所有已经执行的命令
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialCommandsResponse
         */
        public async Task<ListHpoTrialCommandsResponse> ListHpoTrialCommandsWithOptionsAsync(string ExperimentId, string TrialId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrialCommands",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId) + "/commands",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialCommandsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 返回一个trial所对应的任务里所有已经执行的命令
         *
         * @return ListHpoTrialCommandsResponse
         */
        public ListHpoTrialCommandsResponse ListHpoTrialCommands(string ExperimentId, string TrialId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHpoTrialCommandsWithOptions(ExperimentId, TrialId, headers, runtime);
        }

        /**
         * @summary 返回一个trial所对应的任务里所有已经执行的命令
         *
         * @return ListHpoTrialCommandsResponse
         */
        public async Task<ListHpoTrialCommandsResponse> ListHpoTrialCommandsAsync(string ExperimentId, string TrialId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHpoTrialCommandsWithOptionsAsync(ExperimentId, TrialId, headers, runtime);
        }

        /**
         * @summary List all log file names a trial have.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialLogNamesResponse
         */
        public ListHpoTrialLogNamesResponse ListHpoTrialLogNamesWithOptions(string ExperimentId, string TrialId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrialLogNames",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId) + "/lognames",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialLogNamesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary List all log file names a trial have.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialLogNamesResponse
         */
        public async Task<ListHpoTrialLogNamesResponse> ListHpoTrialLogNamesWithOptionsAsync(string ExperimentId, string TrialId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrialLogNames",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId) + "/lognames",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialLogNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary List all log file names a trial have.
         *
         * @return ListHpoTrialLogNamesResponse
         */
        public ListHpoTrialLogNamesResponse ListHpoTrialLogNames(string ExperimentId, string TrialId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHpoTrialLogNamesWithOptions(ExperimentId, TrialId, headers, runtime);
        }

        /**
         * @summary List all log file names a trial have.
         *
         * @return ListHpoTrialLogNamesResponse
         */
        public async Task<ListHpoTrialLogNamesResponse> ListHpoTrialLogNamesAsync(string ExperimentId, string TrialId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHpoTrialLogNamesWithOptionsAsync(ExperimentId, TrialId, headers, runtime);
        }

        /**
         * @summary List Trial log lines
         *
         * @param request ListHpoTrialLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialLogsResponse
         */
        public ListHpoTrialLogsResponse ListHpoTrialLogsWithOptions(string ExperimentId, string TrialId, ListHpoTrialLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogName))
            {
                query["LogName"] = request.LogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrialLogs",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary List Trial log lines
         *
         * @param request ListHpoTrialLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialLogsResponse
         */
        public async Task<ListHpoTrialLogsResponse> ListHpoTrialLogsWithOptionsAsync(string ExperimentId, string TrialId, ListHpoTrialLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogName))
            {
                query["LogName"] = request.LogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrialLogs",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trial/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrialId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary List Trial log lines
         *
         * @param request ListHpoTrialLogsRequest
         * @return ListHpoTrialLogsResponse
         */
        public ListHpoTrialLogsResponse ListHpoTrialLogs(string ExperimentId, string TrialId, ListHpoTrialLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHpoTrialLogsWithOptions(ExperimentId, TrialId, request, headers, runtime);
        }

        /**
         * @summary List Trial log lines
         *
         * @param request ListHpoTrialLogsRequest
         * @return ListHpoTrialLogsResponse
         */
        public async Task<ListHpoTrialLogsResponse> ListHpoTrialLogsAsync(string ExperimentId, string TrialId, ListHpoTrialLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHpoTrialLogsWithOptionsAsync(ExperimentId, TrialId, request, headers, runtime);
        }

        /**
         * @summary List HPO trials
         *
         * @param request ListHpoTrialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialsResponse
         */
        public ListHpoTrialsResponse ListHpoTrialsWithOptions(string ExperimentId, ListHpoTrialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrials",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary List HPO trials
         *
         * @param request ListHpoTrialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHpoTrialsResponse
         */
        public async Task<ListHpoTrialsResponse> ListHpoTrialsWithOptionsAsync(string ExperimentId, ListHpoTrialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHpoTrials",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/trials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHpoTrialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary List HPO trials
         *
         * @param request ListHpoTrialsRequest
         * @return ListHpoTrialsResponse
         */
        public ListHpoTrialsResponse ListHpoTrials(string ExperimentId, ListHpoTrialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHpoTrialsWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary List HPO trials
         *
         * @param request ListHpoTrialsRequest
         * @return ListHpoTrialsResponse
         */
        public async Task<ListHpoTrialsResponse> ListHpoTrialsAsync(string ExperimentId, ListHpoTrialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHpoTrialsWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary Restart HPO trials
         *
         * @param request RestartHpoTrialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartHpoTrialsResponse
         */
        public RestartHpoTrialsResponse RestartHpoTrialsWithOptions(string ExperimentId, RestartHpoTrialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialHyperParameters))
            {
                body["TrialHyperParameters"] = request.TrialHyperParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialIds))
            {
                body["TrialIds"] = request.TrialIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartHpoTrials",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/restart_trials",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartHpoTrialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Restart HPO trials
         *
         * @param request RestartHpoTrialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartHpoTrialsResponse
         */
        public async Task<RestartHpoTrialsResponse> RestartHpoTrialsWithOptionsAsync(string ExperimentId, RestartHpoTrialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialHyperParameters))
            {
                body["TrialHyperParameters"] = request.TrialHyperParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialIds))
            {
                body["TrialIds"] = request.TrialIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartHpoTrials",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/restart_trials",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartHpoTrialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Restart HPO trials
         *
         * @param request RestartHpoTrialsRequest
         * @return RestartHpoTrialsResponse
         */
        public RestartHpoTrialsResponse RestartHpoTrials(string ExperimentId, RestartHpoTrialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartHpoTrialsWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary Restart HPO trials
         *
         * @param request RestartHpoTrialsRequest
         * @return RestartHpoTrialsResponse
         */
        public async Task<RestartHpoTrialsResponse> RestartHpoTrialsAsync(string ExperimentId, RestartHpoTrialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartHpoTrialsWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary calling hpo StopExperiment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopHpoExperimentResponse
         */
        public StopHpoExperimentResponse StopHpoExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopHpoExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary calling hpo StopExperiment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopHpoExperimentResponse
         */
        public async Task<StopHpoExperimentResponse> StopHpoExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopHpoExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary calling hpo StopExperiment
         *
         * @return StopHpoExperimentResponse
         */
        public StopHpoExperimentResponse StopHpoExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopHpoExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary calling hpo StopExperiment
         *
         * @return StopHpoExperimentResponse
         */
        public async Task<StopHpoExperimentResponse> StopHpoExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopHpoExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary Stop an HPO trial.
         *
         * @param request StopHpoTrialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopHpoTrialsResponse
         */
        public StopHpoTrialsResponse StopHpoTrialsWithOptions(string ExperimentId, StopHpoTrialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialIds))
            {
                body["TrialIds"] = request.TrialIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopHpoTrials",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/stop_trials",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopHpoTrialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Stop an HPO trial.
         *
         * @param request StopHpoTrialsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopHpoTrialsResponse
         */
        public async Task<StopHpoTrialsResponse> StopHpoTrialsWithOptionsAsync(string ExperimentId, StopHpoTrialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialIds))
            {
                body["TrialIds"] = request.TrialIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopHpoTrials",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/stop_trials",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopHpoTrialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Stop an HPO trial.
         *
         * @param request StopHpoTrialsRequest
         * @return StopHpoTrialsResponse
         */
        public StopHpoTrialsResponse StopHpoTrials(string ExperimentId, StopHpoTrialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopHpoTrialsWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary Stop an HPO trial.
         *
         * @param request StopHpoTrialsRequest
         * @return StopHpoTrialsResponse
         */
        public async Task<StopHpoTrialsResponse> StopHpoTrialsAsync(string ExperimentId, StopHpoTrialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopHpoTrialsWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary Update a running HPO experiment\\"s configuration
         *
         * @param request UpdateHpoExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHpoExperimentResponse
         */
        public UpdateHpoExperimentResponse UpdateHpoExperimentWithOptions(string ExperimentId, UpdateHpoExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpoExperimentConfiguration))
            {
                body["HpoExperimentConfiguration"] = request.HpoExperimentConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHpoExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Update a running HPO experiment\\"s configuration
         *
         * @param request UpdateHpoExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHpoExperimentResponse
         */
        public async Task<UpdateHpoExperimentResponse> UpdateHpoExperimentWithOptionsAsync(string ExperimentId, UpdateHpoExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpoExperimentConfiguration))
            {
                body["HpoExperimentConfiguration"] = request.HpoExperimentConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHpoExperiment",
                Version = "2022-08-28",
                Protocol = "HTTPS",
                Pathname = "/api/automl/v1/hpo/experiment/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHpoExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Update a running HPO experiment\\"s configuration
         *
         * @param request UpdateHpoExperimentRequest
         * @return UpdateHpoExperimentResponse
         */
        public UpdateHpoExperimentResponse UpdateHpoExperiment(string ExperimentId, UpdateHpoExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHpoExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary Update a running HPO experiment\\"s configuration
         *
         * @param request UpdateHpoExperimentRequest
         * @return UpdateHpoExperimentResponse
         */
        public async Task<UpdateHpoExperimentResponse> UpdateHpoExperimentAsync(string ExperimentId, UpdateHpoExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHpoExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

    }
}
