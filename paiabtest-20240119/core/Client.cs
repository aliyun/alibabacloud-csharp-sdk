// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PAIABTest20240119.Models;

namespace AlibabaCloud.SDK.PAIABTest20240119
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("paiabtest", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 对层上的参数进行校验
         *
         * @param request CheckLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckLayerResponse
         */
        public CheckLayerResponse CheckLayerWithOptions(string LayerId, CheckLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamNames))
            {
                query["ParamNames"] = request.ParamNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId) + "/action/check",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 对层上的参数进行校验
         *
         * @param request CheckLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckLayerResponse
         */
        public async Task<CheckLayerResponse> CheckLayerWithOptionsAsync(string LayerId, CheckLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamNames))
            {
                query["ParamNames"] = request.ParamNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId) + "/action/check",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 对层上的参数进行校验
         *
         * @param request CheckLayerRequest
         * @return CheckLayerResponse
         */
        public CheckLayerResponse CheckLayer(string LayerId, CheckLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckLayerWithOptions(LayerId, request, headers, runtime);
        }

        /**
         * @summary 对层上的参数进行校验
         *
         * @param request CheckLayerRequest
         * @return CheckLayerResponse
         */
        public async Task<CheckLayerResponse> CheckLayerAsync(string LayerId, CheckLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /**
         * @summary 创建人群
         *
         * @param request CreateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCrowdResponse
         */
        public CreateCrowdResponse CreateCrowdWithOptions(CreateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
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
                Action = "CreateCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCrowdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建人群
         *
         * @param request CreateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCrowdResponse
         */
        public async Task<CreateCrowdResponse> CreateCrowdWithOptionsAsync(CreateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
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
                Action = "CreateCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建人群
         *
         * @param request CreateCrowdRequest
         * @return CreateCrowdResponse
         */
        public CreateCrowdResponse CreateCrowd(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCrowdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建人群
         *
         * @param request CreateCrowdRequest
         * @return CreateCrowdResponse
         */
        public async Task<CreateCrowdResponse> CreateCrowdAsync(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCrowdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实验域
         *
         * @param request CreateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
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
                Action = "CreateDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实验域
         *
         * @param request CreateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
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
                Action = "CreateDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实验域
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验域
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实验
         *
         * @param request CreateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentResponse
         */
        public CreateExperimentResponse CreateExperimentWithOptions(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreMetricId))
            {
                body["CoreMetricId"] = request.CoreMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FocusMetricIds))
            {
                body["FocusMetricIds"] = request.FocusMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
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
                Action = "CreateExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实验
         *
         * @param request CreateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentResponse
         */
        public async Task<CreateExperimentResponse> CreateExperimentWithOptionsAsync(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreMetricId))
            {
                body["CoreMetricId"] = request.CoreMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FocusMetricIds))
            {
                body["FocusMetricIds"] = request.FocusMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
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
                Action = "CreateExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实验
         *
         * @param request CreateExperimentRequest
         * @return CreateExperimentResponse
         */
        public CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验
         *
         * @param request CreateExperimentRequest
         * @return CreateExperimentResponse
         */
        public async Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实验版本
         *
         * @param request CreateExperimentVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentVersionResponse
         */
        public CreateExperimentVersionResponse CreateExperimentVersionWithOptions(CreateExperimentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                body["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实验版本
         *
         * @param request CreateExperimentVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentVersionResponse
         */
        public async Task<CreateExperimentVersionResponse> CreateExperimentVersionWithOptionsAsync(CreateExperimentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                body["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实验版本
         *
         * @param request CreateExperimentVersionRequest
         * @return CreateExperimentVersionResponse
         */
        public CreateExperimentVersionResponse CreateExperimentVersion(CreateExperimentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentVersionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验版本
         *
         * @param request CreateExperimentVersionRequest
         * @return CreateExperimentVersionResponse
         */
        public async Task<CreateExperimentVersionResponse> CreateExperimentVersionAsync(CreateExperimentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentVersionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建Feature
         *
         * @param request CreateFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureResponse
         */
        public CreateFeatureResponse CreateFeatureWithOptions(CreateFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建Feature
         *
         * @param request CreateFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureResponse
         */
        public async Task<CreateFeatureResponse> CreateFeatureWithOptionsAsync(CreateFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建Feature
         *
         * @param request CreateFeatureRequest
         * @return CreateFeatureResponse
         */
        public CreateFeatureResponse CreateFeature(CreateFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建Feature
         *
         * @param request CreateFeatureRequest
         * @return CreateFeatureResponse
         */
        public async Task<CreateFeatureResponse> CreateFeatureAsync(CreateFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实验层
         *
         * @param request CreateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLayerResponse
         */
        public CreateLayerResponse CreateLayerWithOptions(CreateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
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
                Action = "CreateLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实验层
         *
         * @param request CreateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLayerResponse
         */
        public async Task<CreateLayerResponse> CreateLayerWithOptionsAsync(CreateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
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
                Action = "CreateLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实验层
         *
         * @param request CreateLayerRequest
         * @return CreateLayerResponse
         */
        public CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLayerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验层
         *
         * @param request CreateLayerRequest
         * @return CreateLayerResponse
         */
        public async Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLayerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建指标
         *
         * @param request CreateMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMetricResponse
         */
        public CreateMetricResponse CreateMetricWithOptions(CreateMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupId))
            {
                body["MetricGroupId"] = request.MetricGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTableMetaId))
            {
                body["SourceTableMetaId"] = request.SourceTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建指标
         *
         * @param request CreateMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMetricResponse
         */
        public async Task<CreateMetricResponse> CreateMetricWithOptionsAsync(CreateMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupId))
            {
                body["MetricGroupId"] = request.MetricGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTableMetaId))
            {
                body["SourceTableMetaId"] = request.SourceTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建指标
         *
         * @param request CreateMetricRequest
         * @return CreateMetricResponse
         */
        public CreateMetricResponse CreateMetric(CreateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMetricWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建指标
         *
         * @param request CreateMetricRequest
         * @return CreateMetricResponse
         */
        public async Task<CreateMetricResponse> CreateMetricAsync(CreateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMetricWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建指标组
         *
         * @param request CreateMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMetricGroupResponse
         */
        public CreateMetricGroupResponse CreateMetricGroupWithOptions(CreateMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CreateMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建指标组
         *
         * @param request CreateMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMetricGroupResponse
         */
        public async Task<CreateMetricGroupResponse> CreateMetricGroupWithOptionsAsync(CreateMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CreateMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建指标组
         *
         * @param request CreateMetricGroupRequest
         * @return CreateMetricGroupResponse
         */
        public CreateMetricGroupResponse CreateMetricGroup(CreateMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMetricGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建指标组
         *
         * @param request CreateMetricGroupRequest
         * @return CreateMetricGroupResponse
         */
        public async Task<CreateMetricGroupResponse> CreateMetricGroupAsync(CreateMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMetricGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实验项目
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CreateProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实验项目
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CreateProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实验项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建数据表
         *
         * @param request CreateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTableMetaResponse
         */
        public CreateTableMetaResponse CreateTableMetaWithOptions(CreateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceInfo))
            {
                body["DatasourceInfo"] = request.DatasourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceType))
            {
                body["DatasourceType"] = request.DatasourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
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
                Action = "CreateTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建数据表
         *
         * @param request CreateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTableMetaResponse
         */
        public async Task<CreateTableMetaResponse> CreateTableMetaWithOptionsAsync(CreateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceInfo))
            {
                body["DatasourceInfo"] = request.DatasourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceType))
            {
                body["DatasourceType"] = request.DatasourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
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
                Action = "CreateTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建数据表
         *
         * @param request CreateTableMetaRequest
         * @return CreateTableMetaResponse
         */
        public CreateTableMetaResponse CreateTableMeta(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableMetaWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建数据表
         *
         * @param request CreateTableMetaRequest
         * @return CreateTableMetaResponse
         */
        public async Task<CreateTableMetaResponse> CreateTableMetaAsync(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableMetaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除指定的人群
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCrowdResponse
         */
        public DeleteCrowdResponse DeleteCrowdWithOptions(string CrowdId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrowdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定的人群
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCrowdResponse
         */
        public async Task<DeleteCrowdResponse> DeleteCrowdWithOptionsAsync(string CrowdId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定的人群
         *
         * @return DeleteCrowdResponse
         */
        public DeleteCrowdResponse DeleteCrowd(string CrowdId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCrowdWithOptions(CrowdId, headers, runtime);
        }

        /**
         * @summary 删除指定的人群
         *
         * @return DeleteCrowdResponse
         */
        public async Task<DeleteCrowdResponse> DeleteCrowdAsync(string CrowdId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCrowdWithOptionsAsync(CrowdId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验域
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(string DomainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验域
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(string DomainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验域
         *
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(string DomainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDomainWithOptions(DomainId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验域
         *
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(string DomainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDomainWithOptionsAsync(DomainId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentResponse
         */
        public DeleteExperimentResponse DeleteExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentResponse
         */
        public async Task<DeleteExperimentResponse> DeleteExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验
         *
         * @return DeleteExperimentResponse
         */
        public DeleteExperimentResponse DeleteExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验
         *
         * @return DeleteExperimentResponse
         */
        public async Task<DeleteExperimentResponse> DeleteExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentVersionResponse
         */
        public DeleteExperimentVersionResponse DeleteExperimentVersionWithOptions(string ExperimentVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentVersionResponse
         */
        public async Task<DeleteExperimentVersionResponse> DeleteExperimentVersionWithOptionsAsync(string ExperimentVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验版本
         *
         * @return DeleteExperimentVersionResponse
         */
        public DeleteExperimentVersionResponse DeleteExperimentVersion(string ExperimentVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentVersionWithOptions(ExperimentVersionId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验版本
         *
         * @return DeleteExperimentVersionResponse
         */
        public async Task<DeleteExperimentVersionResponse> DeleteExperimentVersionAsync(string ExperimentVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentVersionWithOptionsAsync(ExperimentVersionId, headers, runtime);
        }

        /**
         * @summary 删除Feature
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFeatureResponse
         */
        public DeleteFeatureResponse DeleteFeatureWithOptions(string FeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除Feature
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFeatureResponse
         */
        public async Task<DeleteFeatureResponse> DeleteFeatureWithOptionsAsync(string FeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除Feature
         *
         * @return DeleteFeatureResponse
         */
        public DeleteFeatureResponse DeleteFeature(string FeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFeatureWithOptions(FeatureId, headers, runtime);
        }

        /**
         * @summary 删除Feature
         *
         * @return DeleteFeatureResponse
         */
        public async Task<DeleteFeatureResponse> DeleteFeatureAsync(string FeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFeatureWithOptionsAsync(FeatureId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验层
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLayerResponse
         */
        public DeleteLayerResponse DeleteLayerWithOptions(string LayerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验层
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLayerResponse
         */
        public async Task<DeleteLayerResponse> DeleteLayerWithOptionsAsync(string LayerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定的实验层
         *
         * @return DeleteLayerResponse
         */
        public DeleteLayerResponse DeleteLayer(string LayerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLayerWithOptions(LayerId, headers, runtime);
        }

        /**
         * @summary 删除指定的实验层
         *
         * @return DeleteLayerResponse
         */
        public async Task<DeleteLayerResponse> DeleteLayerAsync(string LayerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLayerWithOptionsAsync(LayerId, headers, runtime);
        }

        /**
         * @summary 删除指定指标
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMetricResponse
         */
        public DeleteMetricResponse DeleteMetricWithOptions(string MetricId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定指标
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMetricResponse
         */
        public async Task<DeleteMetricResponse> DeleteMetricWithOptionsAsync(string MetricId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定指标
         *
         * @return DeleteMetricResponse
         */
        public DeleteMetricResponse DeleteMetric(string MetricId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMetricWithOptions(MetricId, headers, runtime);
        }

        /**
         * @summary 删除指定指标
         *
         * @return DeleteMetricResponse
         */
        public async Task<DeleteMetricResponse> DeleteMetricAsync(string MetricId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMetricWithOptionsAsync(MetricId, headers, runtime);
        }

        /**
         * @summary 删除指定的指标组
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMetricGroupResponse
         */
        public DeleteMetricGroupResponse DeleteMetricGroupWithOptions(string MetricGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定的指标组
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMetricGroupResponse
         */
        public async Task<DeleteMetricGroupResponse> DeleteMetricGroupWithOptionsAsync(string MetricGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定的指标组
         *
         * @return DeleteMetricGroupResponse
         */
        public DeleteMetricGroupResponse DeleteMetricGroup(string MetricGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMetricGroupWithOptions(MetricGroupId, headers, runtime);
        }

        /**
         * @summary 删除指定的指标组
         *
         * @return DeleteMetricGroupResponse
         */
        public async Task<DeleteMetricGroupResponse> DeleteMetricGroupAsync(string MetricGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMetricGroupWithOptionsAsync(MetricGroupId, headers, runtime);
        }

        /**
         * @summary 删除实验项目
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProjectWithOptions(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除实验项目
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除实验项目
         *
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProject(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(ProjectId, headers, runtime);
        }

        /**
         * @summary 删除实验项目
         *
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectAsync(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(ProjectId, headers, runtime);
        }

        /**
         * @summary 删除数据表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTableMetaResponse
         */
        public DeleteTableMetaResponse DeleteTableMetaWithOptions(string TableMetaId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除数据表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTableMetaResponse
         */
        public async Task<DeleteTableMetaResponse> DeleteTableMetaWithOptionsAsync(string TableMetaId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除数据表
         *
         * @return DeleteTableMetaResponse
         */
        public DeleteTableMetaResponse DeleteTableMeta(string TableMetaId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableMetaWithOptions(TableMetaId, headers, runtime);
        }

        /**
         * @summary 删除数据表
         *
         * @return DeleteTableMetaResponse
         */
        public async Task<DeleteTableMetaResponse> DeleteTableMetaAsync(string TableMetaId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableMetaWithOptionsAsync(TableMetaId, headers, runtime);
        }

        /**
         * @summary 获取指定人群详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCrowdResponse
         */
        public GetCrowdResponse GetCrowdWithOptions(string CrowdId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrowdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定人群详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCrowdResponse
         */
        public async Task<GetCrowdResponse> GetCrowdWithOptionsAsync(string CrowdId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定人群详情
         *
         * @return GetCrowdResponse
         */
        public GetCrowdResponse GetCrowd(string CrowdId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCrowdWithOptions(CrowdId, headers, runtime);
        }

        /**
         * @summary 获取指定人群详情
         *
         * @return GetCrowdResponse
         */
        public async Task<GetCrowdResponse> GetCrowdAsync(string CrowdId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCrowdWithOptionsAsync(CrowdId, headers, runtime);
        }

        /**
         * @summary 获取指定实验域详情
         *
         * @param request GetDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomainWithOptions(string DomainId, GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定实验域详情
         *
         * @param request GetDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainWithOptionsAsync(string DomainId, GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定实验域详情
         *
         * @param request GetDomainRequest
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomain(string DomainId, GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDomainWithOptions(DomainId, request, headers, runtime);
        }

        /**
         * @summary 获取指定实验域详情
         *
         * @param request GetDomainRequest
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainAsync(string DomainId, GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDomainWithOptionsAsync(DomainId, request, headers, runtime);
        }

        /**
         * @summary 获取指定实验的详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentResponse
         */
        public GetExperimentResponse GetExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定实验的详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentResponse
         */
        public async Task<GetExperimentResponse> GetExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定实验的详情
         *
         * @return GetExperimentResponse
         */
        public GetExperimentResponse GetExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary 获取指定实验的详情
         *
         * @return GetExperimentResponse
         */
        public async Task<GetExperimentResponse> GetExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary 获取指定实验版本的详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentVersionResponse
         */
        public GetExperimentVersionResponse GetExperimentVersionWithOptions(string ExperimentVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定实验版本的详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentVersionResponse
         */
        public async Task<GetExperimentVersionResponse> GetExperimentVersionWithOptionsAsync(string ExperimentVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定实验版本的详情
         *
         * @return GetExperimentVersionResponse
         */
        public GetExperimentVersionResponse GetExperimentVersion(string ExperimentVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentVersionWithOptions(ExperimentVersionId, headers, runtime);
        }

        /**
         * @summary 获取指定实验版本的详情
         *
         * @return GetExperimentVersionResponse
         */
        public async Task<GetExperimentVersionResponse> GetExperimentVersionAsync(string ExperimentVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentVersionWithOptionsAsync(ExperimentVersionId, headers, runtime);
        }

        /**
         * @summary 获取Feature详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureResponse
         */
        public GetFeatureResponse GetFeatureWithOptions(string FeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Feature详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureResponse
         */
        public async Task<GetFeatureResponse> GetFeatureWithOptionsAsync(string FeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Feature详情
         *
         * @return GetFeatureResponse
         */
        public GetFeatureResponse GetFeature(string FeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureWithOptions(FeatureId, headers, runtime);
        }

        /**
         * @summary 获取Feature详情
         *
         * @return GetFeatureResponse
         */
        public async Task<GetFeatureResponse> GetFeatureAsync(string FeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureWithOptionsAsync(FeatureId, headers, runtime);
        }

        /**
         * @summary 获取指定的实验层详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerResponse
         */
        public GetLayerResponse GetLayerWithOptions(string LayerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定的实验层详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerResponse
         */
        public async Task<GetLayerResponse> GetLayerWithOptionsAsync(string LayerId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定的实验层详情
         *
         * @return GetLayerResponse
         */
        public GetLayerResponse GetLayer(string LayerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerWithOptions(LayerId, headers, runtime);
        }

        /**
         * @summary 获取指定的实验层详情
         *
         * @return GetLayerResponse
         */
        public async Task<GetLayerResponse> GetLayerAsync(string LayerId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerWithOptionsAsync(LayerId, headers, runtime);
        }

        /**
         * @summary 获取指标详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricResponse
         */
        public GetMetricResponse GetMetricWithOptions(string MetricId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指标详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricResponse
         */
        public async Task<GetMetricResponse> GetMetricWithOptionsAsync(string MetricId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指标详情
         *
         * @return GetMetricResponse
         */
        public GetMetricResponse GetMetric(string MetricId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMetricWithOptions(MetricId, headers, runtime);
        }

        /**
         * @summary 获取指标详情
         *
         * @return GetMetricResponse
         */
        public async Task<GetMetricResponse> GetMetricAsync(string MetricId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMetricWithOptionsAsync(MetricId, headers, runtime);
        }

        /**
         * @summary 获取指标组的详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricGroupResponse
         */
        public GetMetricGroupResponse GetMetricGroupWithOptions(string MetricGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指标组的详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricGroupResponse
         */
        public async Task<GetMetricGroupResponse> GetMetricGroupWithOptionsAsync(string MetricGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指标组的详细信息
         *
         * @return GetMetricGroupResponse
         */
        public GetMetricGroupResponse GetMetricGroup(string MetricGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMetricGroupWithOptions(MetricGroupId, headers, runtime);
        }

        /**
         * @summary 获取指标组的详细信息
         *
         * @return GetMetricGroupResponse
         */
        public async Task<GetMetricGroupResponse> GetMetricGroupAsync(string MetricGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMetricGroupWithOptionsAsync(MetricGroupId, headers, runtime);
        }

        /**
         * @summary 获取指定的实验项目
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProjectWithOptions(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定的实验项目
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定的实验项目
         *
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProject(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(ProjectId, headers, runtime);
        }

        /**
         * @summary 获取指定的实验项目
         *
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectAsync(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(ProjectId, headers, runtime);
        }

        /**
         * @summary 获取数据表详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableMetaResponse
         */
        public GetTableMetaResponse GetTableMetaWithOptions(string TableMetaId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取数据表详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableMetaResponse
         */
        public async Task<GetTableMetaResponse> GetTableMetaWithOptionsAsync(string TableMetaId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据表详情
         *
         * @return GetTableMetaResponse
         */
        public GetTableMetaResponse GetTableMeta(string TableMetaId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableMetaWithOptions(TableMetaId, headers, runtime);
        }

        /**
         * @summary 获取数据表详情
         *
         * @return GetTableMetaResponse
         */
        public async Task<GetTableMetaResponse> GetTableMetaAsync(string TableMetaId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableMetaWithOptionsAsync(TableMetaId, headers, runtime);
        }

        /**
         * @summary 获取人群列表
         *
         * @param request ListCrowdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCrowdsResponse
         */
        public ListCrowdsResponse ListCrowdsWithOptions(ListCrowdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdId))
            {
                query["CrowdId"] = request.CrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdName))
            {
                query["CrowdName"] = request.CrowdName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListCrowds",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrowdsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取人群列表
         *
         * @param request ListCrowdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCrowdsResponse
         */
        public async Task<ListCrowdsResponse> ListCrowdsWithOptionsAsync(ListCrowdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdId))
            {
                query["CrowdId"] = request.CrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdName))
            {
                query["CrowdName"] = request.CrowdName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListCrowds",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrowdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取人群列表
         *
         * @param request ListCrowdsRequest
         * @return ListCrowdsResponse
         */
        public ListCrowdsResponse ListCrowds(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCrowdsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取人群列表
         *
         * @param request ListCrowdsRequest
         * @return ListCrowdsResponse
         */
        public async Task<ListCrowdsResponse> ListCrowdsAsync(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCrowdsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验域列表
         *
         * @param request ListDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomainsWithOptions(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListDomains",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实验域列表
         *
         * @param request ListDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsWithOptionsAsync(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListDomains",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实验域列表
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDomainsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验域列表
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDomainsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验版本列表
         *
         * @param request ListExperimentVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentVersionsResponse
         */
        public ListExperimentVersionsResponse ListExperimentVersionsWithOptions(ListExperimentVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperimentVersions",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实验版本列表
         *
         * @param request ListExperimentVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentVersionsResponse
         */
        public async Task<ListExperimentVersionsResponse> ListExperimentVersionsWithOptionsAsync(ListExperimentVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperimentVersions",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实验版本列表
         *
         * @param request ListExperimentVersionsRequest
         * @return ListExperimentVersionsResponse
         */
        public ListExperimentVersionsResponse ListExperimentVersions(ListExperimentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentVersionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验版本列表
         *
         * @param request ListExperimentVersionsRequest
         * @return ListExperimentVersionsResponse
         */
        public async Task<ListExperimentVersionsResponse> ListExperimentVersionsAsync(ListExperimentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentVersionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验列表
         *
         * @param request ListExperimentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentsResponse
         */
        public ListExperimentsResponse ListExperimentsWithOptions(ListExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentName))
            {
                query["ExperimentName"] = request.ExperimentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "ListExperiments",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实验列表
         *
         * @param request ListExperimentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentsResponse
         */
        public async Task<ListExperimentsResponse> ListExperimentsWithOptionsAsync(ListExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentName))
            {
                query["ExperimentName"] = request.ExperimentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "ListExperiments",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实验列表
         *
         * @param request ListExperimentsRequest
         * @return ListExperimentsResponse
         */
        public ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验列表
         *
         * @param request ListExperimentsRequest
         * @return ListExperimentsResponse
         */
        public async Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取Faeture列表
         *
         * @param request ListFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeaturesResponse
         */
        public ListFeaturesResponse ListFeaturesWithOptions(ListFeaturesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureId))
            {
                query["FeatureId"] = request.FeatureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListFeatures",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeaturesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Faeture列表
         *
         * @param request ListFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeaturesResponse
         */
        public async Task<ListFeaturesResponse> ListFeaturesWithOptionsAsync(ListFeaturesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureId))
            {
                query["FeatureId"] = request.FeatureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ListFeatures",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeaturesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Faeture列表
         *
         * @param request ListFeaturesRequest
         * @return ListFeaturesResponse
         */
        public ListFeaturesResponse ListFeatures(ListFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeaturesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取Faeture列表
         *
         * @param request ListFeaturesRequest
         * @return ListFeaturesResponse
         */
        public async Task<ListFeaturesResponse> ListFeaturesAsync(ListFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeaturesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验层列表
         *
         * @param request ListLayersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayersResponse
         */
        public ListLayersResponse ListLayersWithOptions(ListLayersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerName))
            {
                query["LayerName"] = request.LayerName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListLayers",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实验层列表
         *
         * @param request ListLayersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayersResponse
         */
        public async Task<ListLayersResponse> ListLayersWithOptionsAsync(ListLayersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerName))
            {
                query["LayerName"] = request.LayerName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListLayers",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实验层列表
         *
         * @param request ListLayersRequest
         * @return ListLayersResponse
         */
        public ListLayersResponse ListLayers(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验层列表
         *
         * @param request ListLayersRequest
         * @return ListLayersResponse
         */
        public async Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取指标组列表
         *
         * @param request ListMetricGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMetricGroupsResponse
         */
        public ListMetricGroupsResponse ListMetricGroupsWithOptions(ListMetricGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupId))
            {
                query["MetricGroupId"] = request.MetricGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupName))
            {
                query["MetricGroupName"] = request.MetricGroupName;
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
                Action = "ListMetricGroups",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMetricGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指标组列表
         *
         * @param request ListMetricGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMetricGroupsResponse
         */
        public async Task<ListMetricGroupsResponse> ListMetricGroupsWithOptionsAsync(ListMetricGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupId))
            {
                query["MetricGroupId"] = request.MetricGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupName))
            {
                query["MetricGroupName"] = request.MetricGroupName;
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
                Action = "ListMetricGroups",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMetricGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指标组列表
         *
         * @param request ListMetricGroupsRequest
         * @return ListMetricGroupsResponse
         */
        public ListMetricGroupsResponse ListMetricGroups(ListMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMetricGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取指标组列表
         *
         * @param request ListMetricGroupsRequest
         * @return ListMetricGroupsResponse
         */
        public async Task<ListMetricGroupsResponse> ListMetricGroupsAsync(ListMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMetricGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取指标列表
         *
         * @param request ListMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMetricsResponse
         */
        public ListMetricsResponse ListMetricsWithOptions(ListMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupId))
            {
                query["MetricGroupId"] = request.MetricGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricId))
            {
                query["MetricId"] = request.MetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMetrics",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指标列表
         *
         * @param request ListMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMetricsResponse
         */
        public async Task<ListMetricsResponse> ListMetricsWithOptionsAsync(ListMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricGroupId))
            {
                query["MetricGroupId"] = request.MetricGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricId))
            {
                query["MetricId"] = request.MetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMetrics",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指标列表
         *
         * @param request ListMetricsRequest
         * @return ListMetricsResponse
         */
        public ListMetricsResponse ListMetrics(ListMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMetricsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取指标列表
         *
         * @param request ListMetricsRequest
         * @return ListMetricsResponse
         */
        public async Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMetricsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验项目列表
         *
         * @param request ListProjectsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListProjects",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实验项目列表
         *
         * @param request ListProjectsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListProjects",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实验项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取数据表列表
         *
         * @param request ListTableMetasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTableMetasResponse
         */
        public ListTableMetasResponse ListTableMetasWithOptions(ListTableMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceType))
            {
                query["DatasourceType"] = request.DatasourceType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                query["TableMetaId"] = request.TableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaName))
            {
                query["TableMetaName"] = request.TableMetaName;
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
                Action = "ListTableMetas",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableMetasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取数据表列表
         *
         * @param request ListTableMetasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTableMetasResponse
         */
        public async Task<ListTableMetasResponse> ListTableMetasWithOptionsAsync(ListTableMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceType))
            {
                query["DatasourceType"] = request.DatasourceType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                query["TableMetaId"] = request.TableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaName))
            {
                query["TableMetaName"] = request.TableMetaName;
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
                Action = "ListTableMetas",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableMetasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据表列表
         *
         * @param request ListTableMetasRequest
         * @return ListTableMetasResponse
         */
        public ListTableMetasResponse ListTableMetas(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableMetasWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取数据表列表
         *
         * @param request ListTableMetasRequest
         * @return ListTableMetasResponse
         */
        public async Task<ListTableMetasResponse> ListTableMetasAsync(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableMetasWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 对实验版本推全
         *
         * @param request PushAllExperimentVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushAllExperimentVersionResponse
         */
        public PushAllExperimentVersionResponse PushAllExperimentVersionWithOptions(string ExperimentVersionId, PushAllExperimentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                body["FeatureName"] = request.FeatureName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushAllExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId) + "/action/pushall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushAllExperimentVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 对实验版本推全
         *
         * @param request PushAllExperimentVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushAllExperimentVersionResponse
         */
        public async Task<PushAllExperimentVersionResponse> PushAllExperimentVersionWithOptionsAsync(string ExperimentVersionId, PushAllExperimentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                body["FeatureName"] = request.FeatureName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushAllExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId) + "/action/pushall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushAllExperimentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 对实验版本推全
         *
         * @param request PushAllExperimentVersionRequest
         * @return PushAllExperimentVersionResponse
         */
        public PushAllExperimentVersionResponse PushAllExperimentVersion(string ExperimentVersionId, PushAllExperimentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushAllExperimentVersionWithOptions(ExperimentVersionId, request, headers, runtime);
        }

        /**
         * @summary 对实验版本推全
         *
         * @param request PushAllExperimentVersionRequest
         * @return PushAllExperimentVersionResponse
         */
        public async Task<PushAllExperimentVersionResponse> PushAllExperimentVersionAsync(string ExperimentVersionId, PushAllExperimentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushAllExperimentVersionWithOptionsAsync(ExperimentVersionId, request, headers, runtime);
        }

        /**
         * @summary 启动实验
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartExperimentResponse
         */
        public StartExperimentResponse StartExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动实验
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartExperimentResponse
         */
        public async Task<StartExperimentResponse> StartExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动实验
         *
         * @return StartExperimentResponse
         */
        public StartExperimentResponse StartExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary 启动实验
         *
         * @return StartExperimentResponse
         */
        public async Task<StartExperimentResponse> StartExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary 停止实验
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopExperimentResponse
         */
        public StopExperimentResponse StopExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 停止实验
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopExperimentResponse
         */
        public async Task<StopExperimentResponse> StopExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 停止实验
         *
         * @return StopExperimentResponse
         */
        public StopExperimentResponse StopExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /**
         * @summary 停止实验
         *
         * @return StopExperimentResponse
         */
        public async Task<StopExperimentResponse> StopExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCrowdResponse
         */
        public UpdateCrowdResponse UpdateCrowdWithOptions(string CrowdId, UpdateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCrowdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCrowdResponse
         */
        public async Task<UpdateCrowdResponse> UpdateCrowdWithOptionsAsync(string CrowdId, UpdateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCrowd",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @return UpdateCrowdResponse
         */
        public UpdateCrowdResponse UpdateCrowd(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @return UpdateCrowdResponse
         */
        public async Task<UpdateCrowdResponse> UpdateCrowdAsync(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 更新指定实验域
         *
         * @param request UpdateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainResponse
         */
        public UpdateDomainResponse UpdateDomainWithOptions(string DomainId, UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowIds))
            {
                body["CrowIds"] = request.CrowIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定实验域
         *
         * @param request UpdateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainResponse
         */
        public async Task<UpdateDomainResponse> UpdateDomainWithOptionsAsync(string DomainId, UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowIds))
            {
                body["CrowIds"] = request.CrowIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定实验域
         *
         * @param request UpdateDomainRequest
         * @return UpdateDomainResponse
         */
        public UpdateDomainResponse UpdateDomain(string DomainId, UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDomainWithOptions(DomainId, request, headers, runtime);
        }

        /**
         * @summary 更新指定实验域
         *
         * @param request UpdateDomainRequest
         * @return UpdateDomainResponse
         */
        public async Task<UpdateDomainResponse> UpdateDomainAsync(string DomainId, UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDomainWithOptionsAsync(DomainId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验
         *
         * @param request UpdateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentResponse
         */
        public UpdateExperimentResponse UpdateExperimentWithOptions(string ExperimentId, UpdateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreMetricId))
            {
                body["CoreMetricId"] = request.CoreMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FocusMetricIds))
            {
                body["FocusMetricIds"] = request.FocusMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验
         *
         * @param request UpdateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentResponse
         */
        public async Task<UpdateExperimentResponse> UpdateExperimentWithOptionsAsync(string ExperimentId, UpdateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Condition))
            {
                body["Condition"] = request.Condition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreMetricId))
            {
                body["CoreMetricId"] = request.CoreMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FocusMetricIds))
            {
                body["FocusMetricIds"] = request.FocusMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperiment",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验
         *
         * @param request UpdateExperimentRequest
         * @return UpdateExperimentResponse
         */
        public UpdateExperimentResponse UpdateExperiment(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验
         *
         * @param request UpdateExperimentRequest
         * @return UpdateExperimentResponse
         */
        public async Task<UpdateExperimentResponse> UpdateExperimentAsync(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验版本
         *
         * @param request UpdateExperimentVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentVersionResponse
         */
        public UpdateExperimentVersionResponse UpdateExperimentVersionWithOptions(string ExperimentVersionId, UpdateExperimentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验版本
         *
         * @param request UpdateExperimentVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentVersionResponse
         */
        public async Task<UpdateExperimentVersionResponse> UpdateExperimentVersionWithOptionsAsync(string ExperimentVersionId, UpdateExperimentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdIds))
            {
                body["CrowdIds"] = request.CrowdIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flow))
            {
                body["Flow"] = request.Flow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentVersion",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentversions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentVersionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验版本
         *
         * @param request UpdateExperimentVersionRequest
         * @return UpdateExperimentVersionResponse
         */
        public UpdateExperimentVersionResponse UpdateExperimentVersion(string ExperimentVersionId, UpdateExperimentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentVersionWithOptions(ExperimentVersionId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验版本
         *
         * @param request UpdateExperimentVersionRequest
         * @return UpdateExperimentVersionResponse
         */
        public async Task<UpdateExperimentVersionResponse> UpdateExperimentVersionAsync(string ExperimentVersionId, UpdateExperimentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentVersionWithOptionsAsync(ExperimentVersionId, request, headers, runtime);
        }

        /**
         * @summary 更新Feature
         *
         * @param request UpdateFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFeatureResponse
         */
        public UpdateFeatureResponse UpdateFeatureWithOptions(string FeatureId, UpdateFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新Feature
         *
         * @param request UpdateFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFeatureResponse
         */
        public async Task<UpdateFeatureResponse> UpdateFeatureWithOptionsAsync(string FeatureId, UpdateFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFeature",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/features/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新Feature
         *
         * @param request UpdateFeatureRequest
         * @return UpdateFeatureResponse
         */
        public UpdateFeatureResponse UpdateFeature(string FeatureId, UpdateFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFeatureWithOptions(FeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新Feature
         *
         * @param request UpdateFeatureRequest
         * @return UpdateFeatureResponse
         */
        public async Task<UpdateFeatureResponse> UpdateFeatureAsync(string FeatureId, UpdateFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFeatureWithOptionsAsync(FeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验层
         *
         * @param request UpdateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLayerResponse
         */
        public UpdateLayerResponse UpdateLayerWithOptions(string LayerId, UpdateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLayerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验层
         *
         * @param request UpdateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLayerResponse
         */
        public async Task<UpdateLayerResponse> UpdateLayerWithOptionsAsync(string LayerId, UpdateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                body["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLayer",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验层
         *
         * @param request UpdateLayerRequest
         * @return UpdateLayerResponse
         */
        public UpdateLayerResponse UpdateLayer(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLayerWithOptions(LayerId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验层
         *
         * @param request UpdateLayerRequest
         * @return UpdateLayerResponse
         */
        public async Task<UpdateLayerResponse> UpdateLayerAsync(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /**
         * @summary 更新指标
         *
         * @param request UpdateMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMetricResponse
         */
        public UpdateMetricResponse UpdateMetricWithOptions(string MetricId, UpdateMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTableMetaId))
            {
                body["SourceTableMetaId"] = request.SourceTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMetricResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指标
         *
         * @param request UpdateMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMetricResponse
         */
        public async Task<UpdateMetricResponse> UpdateMetricWithOptionsAsync(string MetricId, UpdateMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTableMetaId))
            {
                body["SourceTableMetaId"] = request.SourceTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMetric",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指标
         *
         * @param request UpdateMetricRequest
         * @return UpdateMetricResponse
         */
        public UpdateMetricResponse UpdateMetric(string MetricId, UpdateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMetricWithOptions(MetricId, request, headers, runtime);
        }

        /**
         * @summary 更新指标
         *
         * @param request UpdateMetricRequest
         * @return UpdateMetricResponse
         */
        public async Task<UpdateMetricResponse> UpdateMetricAsync(string MetricId, UpdateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMetricWithOptionsAsync(MetricId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的指标组
         *
         * @param request UpdateMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMetricGroupResponse
         */
        public UpdateMetricGroupResponse UpdateMetricGroupWithOptions(string MetricGroupId, UpdateMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricGroupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定的指标组
         *
         * @param request UpdateMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMetricGroupResponse
         */
        public async Task<UpdateMetricGroupResponse> UpdateMetricGroupWithOptionsAsync(string MetricGroupId, UpdateMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateMetricGroup",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricGroupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定的指标组
         *
         * @param request UpdateMetricGroupRequest
         * @return UpdateMetricGroupResponse
         */
        public UpdateMetricGroupResponse UpdateMetricGroup(string MetricGroupId, UpdateMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMetricGroupWithOptions(MetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的指标组
         *
         * @param request UpdateMetricGroupRequest
         * @return UpdateMetricGroupResponse
         */
        public async Task<UpdateMetricGroupResponse> UpdateMetricGroupAsync(string MetricGroupId, UpdateMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMetricGroupWithOptionsAsync(MetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验项目
         *
         * @param request UpdateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProjectWithOptions(string ProjectId, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验项目
         *
         * @param request UpdateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(string ProjectId, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定的实验项目
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProject(string ProjectId, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(ProjectId, request, headers, runtime);
        }

        /**
         * @summary 更新指定的实验项目
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectAsync(string ProjectId, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        /**
         * @summary 更新数据表
         *
         * @param request UpdateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTableMetaResponse
         */
        public UpdateTableMetaResponse UpdateTableMetaWithOptions(string TableMetaId, UpdateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新数据表
         *
         * @param request UpdateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTableMetaResponse
         */
        public async Task<UpdateTableMetaResponse> UpdateTableMetaWithOptionsAsync(string TableMetaId, UpdateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableMeta",
                Version = "2024-01-19",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新数据表
         *
         * @param request UpdateTableMetaRequest
         * @return UpdateTableMetaResponse
         */
        public UpdateTableMetaResponse UpdateTableMeta(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        /**
         * @summary 更新数据表
         *
         * @param request UpdateTableMetaRequest
         * @return UpdateTableMetaResponse
         */
        public async Task<UpdateTableMetaResponse> UpdateTableMetaAsync(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

    }
}
