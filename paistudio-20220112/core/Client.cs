// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PaiStudio20220112.Models;

namespace AlibabaCloud.SDK.PaiStudio20220112
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "pai.cn-beijing.aliyuncs.com"},
                {"cn-hangzhou", "pai.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "pai.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "pai.cn-shenzhen.aliyuncs.com"},
                {"cn-hongkong", "pai.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "pai.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "pai.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "pai.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "pai.ap-southeast-5.aliyuncs.com"},
                {"us-west-1", "pai.us-west-1.aliyuncs.com"},
                {"us-east-1", "pai.us-east-1.aliyuncs.com"},
                {"eu-central-1", "pai.eu-central-1.aliyuncs.com"},
                {"me-east-1", "pai.me-east-1.aliyuncs.com"},
                {"ap-south-1", "pai.ap-south-1.aliyuncs.com"},
                {"cn-qingdao", "pai.cn-qingdao.aliyuncs.com"},
                {"cn-zhangjiakou", "pai.cn-zhangjiakou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("paistudio", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 检查WebTerminal
         *
         * @param request CheckInstanceWebTerminalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInstanceWebTerminalResponse
         */
        public CheckInstanceWebTerminalResponse CheckInstanceWebTerminalWithOptions(string TrainingJobId, string InstanceId, CheckInstanceWebTerminalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInfo))
            {
                body["CheckInfo"] = request.CheckInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceWebTerminal",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/webterminals/action/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceWebTerminalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检查WebTerminal
         *
         * @param request CheckInstanceWebTerminalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInstanceWebTerminalResponse
         */
        public async Task<CheckInstanceWebTerminalResponse> CheckInstanceWebTerminalWithOptionsAsync(string TrainingJobId, string InstanceId, CheckInstanceWebTerminalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckInfo))
            {
                body["CheckInfo"] = request.CheckInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceWebTerminal",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/webterminals/action/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceWebTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检查WebTerminal
         *
         * @param request CheckInstanceWebTerminalRequest
         * @return CheckInstanceWebTerminalResponse
         */
        public CheckInstanceWebTerminalResponse CheckInstanceWebTerminal(string TrainingJobId, string InstanceId, CheckInstanceWebTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInstanceWebTerminalWithOptions(TrainingJobId, InstanceId, request, headers, runtime);
        }

        /**
         * @summary 检查WebTerminal
         *
         * @param request CheckInstanceWebTerminalRequest
         * @return CheckInstanceWebTerminalResponse
         */
        public async Task<CheckInstanceWebTerminalResponse> CheckInstanceWebTerminalAsync(string TrainingJobId, string InstanceId, CheckInstanceWebTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInstanceWebTerminalWithOptionsAsync(TrainingJobId, InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建新的算法
         *
         * @param request CreateAlgorithmRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlgorithmResponse
         */
        public CreateAlgorithmResponse CreateAlgorithmWithOptions(CreateAlgorithmRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmDescription))
            {
                body["AlgorithmDescription"] = request.AlgorithmDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                body["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
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
                Action = "CreateAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建新的算法
         *
         * @param request CreateAlgorithmRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlgorithmResponse
         */
        public async Task<CreateAlgorithmResponse> CreateAlgorithmWithOptionsAsync(CreateAlgorithmRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmDescription))
            {
                body["AlgorithmDescription"] = request.AlgorithmDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                body["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
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
                Action = "CreateAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建新的算法
         *
         * @param request CreateAlgorithmRequest
         * @return CreateAlgorithmResponse
         */
        public CreateAlgorithmResponse CreateAlgorithm(CreateAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAlgorithmWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建新的算法
         *
         * @param request CreateAlgorithmRequest
         * @return CreateAlgorithmResponse
         */
        public async Task<CreateAlgorithmResponse> CreateAlgorithmAsync(CreateAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAlgorithmWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @param tmpReq CreateAlgorithmVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlgorithmVersionResponse
         */
        public CreateAlgorithmVersionResponse CreateAlgorithmVersionWithOptions(string AlgorithmId, string AlgorithmVersion, CreateAlgorithmVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAlgorithmVersionShrinkRequest request = new CreateAlgorithmVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlgorithmSpec))
            {
                request.AlgorithmSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlgorithmSpec, "AlgorithmSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmSpecShrink))
            {
                body["AlgorithmSpec"] = request.AlgorithmSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlgorithmVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @param tmpReq CreateAlgorithmVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlgorithmVersionResponse
         */
        public async Task<CreateAlgorithmVersionResponse> CreateAlgorithmVersionWithOptionsAsync(string AlgorithmId, string AlgorithmVersion, CreateAlgorithmVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAlgorithmVersionShrinkRequest request = new CreateAlgorithmVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlgorithmSpec))
            {
                request.AlgorithmSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlgorithmSpec, "AlgorithmSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmSpecShrink))
            {
                body["AlgorithmSpec"] = request.AlgorithmSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlgorithmVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @param request CreateAlgorithmVersionRequest
         * @return CreateAlgorithmVersionResponse
         */
        public CreateAlgorithmVersionResponse CreateAlgorithmVersion(string AlgorithmId, string AlgorithmVersion, CreateAlgorithmVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAlgorithmVersionWithOptions(AlgorithmId, AlgorithmVersion, request, headers, runtime);
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @param request CreateAlgorithmVersionRequest
         * @return CreateAlgorithmVersionResponse
         */
        public async Task<CreateAlgorithmVersionResponse> CreateAlgorithmVersionAsync(string AlgorithmId, string AlgorithmVersion, CreateAlgorithmVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAlgorithmVersionWithOptionsAsync(AlgorithmId, AlgorithmVersion, request, headers, runtime);
        }

        /**
         * @summary 创建WebTerminal
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceWebTerminalResponse
         */
        public CreateInstanceWebTerminalResponse CreateInstanceWebTerminalWithOptions(string TrainingJobId, string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceWebTerminal",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/webterminals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceWebTerminalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建WebTerminal
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceWebTerminalResponse
         */
        public async Task<CreateInstanceWebTerminalResponse> CreateInstanceWebTerminalWithOptionsAsync(string TrainingJobId, string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceWebTerminal",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/webterminals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceWebTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建WebTerminal
         *
         * @return CreateInstanceWebTerminalResponse
         */
        public CreateInstanceWebTerminalResponse CreateInstanceWebTerminal(string TrainingJobId, string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWebTerminalWithOptions(TrainingJobId, InstanceId, headers, runtime);
        }

        /**
         * @summary 创建WebTerminal
         *
         * @return CreateInstanceWebTerminalResponse
         */
        public async Task<CreateInstanceWebTerminalResponse> CreateInstanceWebTerminalAsync(string TrainingJobId, string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWebTerminalWithOptionsAsync(TrainingJobId, InstanceId, headers, runtime);
        }

        /**
         * @summary 创建Quota
         *
         * @param request CreateQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaResponse
         */
        public CreateQuotaResponse CreateQuotaWithOptions(CreateQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocateStrategy))
            {
                body["AllocateStrategy"] = request.AllocateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["Min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentQuotaId))
            {
                body["ParentQuotaId"] = request.ParentQuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueStrategy))
            {
                body["QueueStrategy"] = request.QueueStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaConfig))
            {
                body["QuotaConfig"] = request.QuotaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                body["QuotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                body["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建Quota
         *
         * @param request CreateQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQuotaResponse
         */
        public async Task<CreateQuotaResponse> CreateQuotaWithOptionsAsync(CreateQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllocateStrategy))
            {
                body["AllocateStrategy"] = request.AllocateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["Min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentQuotaId))
            {
                body["ParentQuotaId"] = request.ParentQuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueStrategy))
            {
                body["QueueStrategy"] = request.QueueStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaConfig))
            {
                body["QuotaConfig"] = request.QuotaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                body["QuotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                body["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建Quota
         *
         * @param request CreateQuotaRequest
         * @return CreateQuotaResponse
         */
        public CreateQuotaResponse CreateQuota(CreateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateQuotaWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建Quota
         *
         * @param request CreateQuotaRequest
         * @return CreateQuotaResponse
         */
        public async Task<CreateQuotaResponse> CreateQuotaAsync(CreateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateQuotaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建资源组
         *
         * @param request CreateResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceGroupResponse
         */
        public CreateResourceGroupResponse CreateResourceGroupWithOptions(CreateResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputingResourceProvider))
            {
                body["ComputingResourceProvider"] = request.ComputingResourceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建资源组
         *
         * @param request CreateResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceGroupResponse
         */
        public async Task<CreateResourceGroupResponse> CreateResourceGroupWithOptionsAsync(CreateResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputingResourceProvider))
            {
                body["ComputingResourceProvider"] = request.ComputingResourceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建资源组
         *
         * @param request CreateResourceGroupRequest
         * @return CreateResourceGroupResponse
         */
        public CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建资源组
         *
         * @param request CreateResourceGroupRequest
         * @return CreateResourceGroupResponse
         */
        public async Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建TrainingJob
         *
         * @param request CreateTrainingJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrainingJobResponse
         */
        public CreateTrainingJobResponse CreateTrainingJobWithOptions(CreateTrainingJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                body["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmProvider))
            {
                body["AlgorithmProvider"] = request.AlgorithmProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmSpec))
            {
                body["AlgorithmSpec"] = request.AlgorithmSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmVersion))
            {
                body["AlgorithmVersion"] = request.AlgorithmVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDir))
            {
                body["CodeDir"] = request.CodeDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeResource))
            {
                body["ComputeResource"] = request.ComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environments))
            {
                body["Environments"] = request.Environments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentConfig))
            {
                body["ExperimentConfig"] = request.ExperimentConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HyperParameters))
            {
                body["HyperParameters"] = request.HyperParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputChannels))
            {
                body["InputChannels"] = request.InputChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputChannels))
            {
                body["OutputChannels"] = request.OutputChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonRequirements))
            {
                body["PythonRequirements"] = request.PythonRequirements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Settings))
            {
                body["Settings"] = request.Settings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobDescription))
            {
                body["TrainingJobDescription"] = request.TrainingJobDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobName))
            {
                body["TrainingJobName"] = request.TrainingJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
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
                Action = "CreateTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建TrainingJob
         *
         * @param request CreateTrainingJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrainingJobResponse
         */
        public async Task<CreateTrainingJobResponse> CreateTrainingJobWithOptionsAsync(CreateTrainingJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                body["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmProvider))
            {
                body["AlgorithmProvider"] = request.AlgorithmProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmSpec))
            {
                body["AlgorithmSpec"] = request.AlgorithmSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmVersion))
            {
                body["AlgorithmVersion"] = request.AlgorithmVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeDir))
            {
                body["CodeDir"] = request.CodeDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeResource))
            {
                body["ComputeResource"] = request.ComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environments))
            {
                body["Environments"] = request.Environments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentConfig))
            {
                body["ExperimentConfig"] = request.ExperimentConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HyperParameters))
            {
                body["HyperParameters"] = request.HyperParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputChannels))
            {
                body["InputChannels"] = request.InputChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputChannels))
            {
                body["OutputChannels"] = request.OutputChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonRequirements))
            {
                body["PythonRequirements"] = request.PythonRequirements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheduler))
            {
                body["Scheduler"] = request.Scheduler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Settings))
            {
                body["Settings"] = request.Settings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobDescription))
            {
                body["TrainingJobDescription"] = request.TrainingJobDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobName))
            {
                body["TrainingJobName"] = request.TrainingJobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
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
                Action = "CreateTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建TrainingJob
         *
         * @param request CreateTrainingJobRequest
         * @return CreateTrainingJobResponse
         */
        public CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTrainingJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建TrainingJob
         *
         * @param request CreateTrainingJobRequest
         * @return CreateTrainingJobResponse
         */
        public async Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTrainingJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除算法
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlgorithmResponse
         */
        public DeleteAlgorithmResponse DeleteAlgorithmWithOptions(string AlgorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除算法
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlgorithmResponse
         */
        public async Task<DeleteAlgorithmResponse> DeleteAlgorithmWithOptionsAsync(string AlgorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除算法
         *
         * @return DeleteAlgorithmResponse
         */
        public DeleteAlgorithmResponse DeleteAlgorithm(string AlgorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlgorithmWithOptions(AlgorithmId, headers, runtime);
        }

        /**
         * @summary 删除算法
         *
         * @return DeleteAlgorithmResponse
         */
        public async Task<DeleteAlgorithmResponse> DeleteAlgorithmAsync(string AlgorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlgorithmWithOptionsAsync(AlgorithmId, headers, runtime);
        }

        /**
         * @summary 删除算法版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlgorithmVersionResponse
         */
        public DeleteAlgorithmVersionResponse DeleteAlgorithmVersionWithOptions(string AlgorithmId, string AlgorithmVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlgorithmVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除算法版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlgorithmVersionResponse
         */
        public async Task<DeleteAlgorithmVersionResponse> DeleteAlgorithmVersionWithOptionsAsync(string AlgorithmId, string AlgorithmVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlgorithmVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除算法版本
         *
         * @return DeleteAlgorithmVersionResponse
         */
        public DeleteAlgorithmVersionResponse DeleteAlgorithmVersion(string AlgorithmId, string AlgorithmVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlgorithmVersionWithOptions(AlgorithmId, AlgorithmVersion, headers, runtime);
        }

        /**
         * @summary 删除算法版本
         *
         * @return DeleteAlgorithmVersionResponse
         */
        public async Task<DeleteAlgorithmVersionResponse> DeleteAlgorithmVersionAsync(string AlgorithmId, string AlgorithmVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlgorithmVersionWithOptionsAsync(AlgorithmId, AlgorithmVersion, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMachineGroupResponse
         */
        // Deprecated
        public DeleteMachineGroupResponse DeleteMachineGroupWithOptions(string MachineGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMachineGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMachineGroupResponse
         */
        // Deprecated
        public async Task<DeleteMachineGroupResponse> DeleteMachineGroupWithOptionsAsync(string MachineGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMachineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @return DeleteMachineGroupResponse
         */
        // Deprecated
        public DeleteMachineGroupResponse DeleteMachineGroup(string MachineGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMachineGroupWithOptions(MachineGroupID, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @return DeleteMachineGroupResponse
         */
        // Deprecated
        public async Task<DeleteMachineGroupResponse> DeleteMachineGroupAsync(string MachineGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMachineGroupWithOptionsAsync(MachineGroupID, headers, runtime);
        }

        /**
         * @summary 删除Quota
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQuotaResponse
         */
        public DeleteQuotaResponse DeleteQuotaWithOptions(string QuotaId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除Quota
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQuotaResponse
         */
        public async Task<DeleteQuotaResponse> DeleteQuotaWithOptionsAsync(string QuotaId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除Quota
         *
         * @return DeleteQuotaResponse
         */
        public DeleteQuotaResponse DeleteQuota(string QuotaId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteQuotaWithOptions(QuotaId, headers, runtime);
        }

        /**
         * @summary 删除Quota
         *
         * @return DeleteQuotaResponse
         */
        public async Task<DeleteQuotaResponse> DeleteQuotaAsync(string QuotaId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteQuotaWithOptionsAsync(QuotaId, headers, runtime);
        }

        /**
         * @summary 删除资源组
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceGroupResponse
         */
        public DeleteResourceGroupResponse DeleteResourceGroupWithOptions(string ResourceGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除资源组
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceGroupResponse
         */
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroupWithOptionsAsync(string ResourceGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除资源组
         *
         * @return DeleteResourceGroupResponse
         */
        public DeleteResourceGroupResponse DeleteResourceGroup(string ResourceGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceGroupWithOptions(ResourceGroupID, headers, runtime);
        }

        /**
         * @summary 删除资源组
         *
         * @return DeleteResourceGroupResponse
         */
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroupAsync(string ResourceGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceGroupWithOptionsAsync(ResourceGroupID, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteResourceGroupMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceGroupMachineGroupResponse
         */
        // Deprecated
        public DeleteResourceGroupMachineGroupResponse DeleteResourceGroupMachineGroupWithOptions(string MachineGroupID, string ResourceGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceGroupMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceGroupMachineGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteResourceGroupMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceGroupMachineGroupResponse
         */
        // Deprecated
        public async Task<DeleteResourceGroupMachineGroupResponse> DeleteResourceGroupMachineGroupWithOptionsAsync(string MachineGroupID, string ResourceGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceGroupMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceGroupMachineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteResourceGroupMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @return DeleteResourceGroupMachineGroupResponse
         */
        // Deprecated
        public DeleteResourceGroupMachineGroupResponse DeleteResourceGroupMachineGroup(string MachineGroupID, string ResourceGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceGroupMachineGroupWithOptions(MachineGroupID, ResourceGroupID, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteResourceGroupMachineGroup is deprecated
         *
         * @summary delete machine group
         *
         * @return DeleteResourceGroupMachineGroupResponse
         */
        // Deprecated
        public async Task<DeleteResourceGroupMachineGroupResponse> DeleteResourceGroupMachineGroupAsync(string MachineGroupID, string ResourceGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceGroupMachineGroupWithOptionsAsync(MachineGroupID, ResourceGroupID, headers, runtime);
        }

        /**
         * @summary 删除一个TrainingJob
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrainingJobResponse
         */
        public DeleteTrainingJobResponse DeleteTrainingJobWithOptions(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除一个TrainingJob
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrainingJobResponse
         */
        public async Task<DeleteTrainingJobResponse> DeleteTrainingJobWithOptionsAsync(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除一个TrainingJob
         *
         * @return DeleteTrainingJobResponse
         */
        public DeleteTrainingJobResponse DeleteTrainingJob(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTrainingJobWithOptions(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 删除一个TrainingJob
         *
         * @return DeleteTrainingJobResponse
         */
        public async Task<DeleteTrainingJobResponse> DeleteTrainingJobAsync(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTrainingJobWithOptionsAsync(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 删除TrainingJob的Labels
         *
         * @param request DeleteTrainingJobLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrainingJobLabelsResponse
         */
        public DeleteTrainingJobLabelsResponse DeleteTrainingJobLabelsWithOptions(string TrainingJobId, DeleteTrainingJobLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                query["Keys"] = request.Keys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrainingJobLabels",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrainingJobLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除TrainingJob的Labels
         *
         * @param request DeleteTrainingJobLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrainingJobLabelsResponse
         */
        public async Task<DeleteTrainingJobLabelsResponse> DeleteTrainingJobLabelsWithOptionsAsync(string TrainingJobId, DeleteTrainingJobLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                query["Keys"] = request.Keys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrainingJobLabels",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrainingJobLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除TrainingJob的Labels
         *
         * @param request DeleteTrainingJobLabelsRequest
         * @return DeleteTrainingJobLabelsResponse
         */
        public DeleteTrainingJobLabelsResponse DeleteTrainingJobLabels(string TrainingJobId, DeleteTrainingJobLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTrainingJobLabelsWithOptions(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 删除TrainingJob的Labels
         *
         * @param request DeleteTrainingJobLabelsRequest
         * @return DeleteTrainingJobLabelsResponse
         */
        public async Task<DeleteTrainingJobLabelsResponse> DeleteTrainingJobLabelsAsync(string TrainingJobId, DeleteTrainingJobLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTrainingJobLabelsWithOptionsAsync(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取一个算法信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAlgorithmResponse
         */
        public GetAlgorithmResponse GetAlgorithmWithOptions(string AlgorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取一个算法信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAlgorithmResponse
         */
        public async Task<GetAlgorithmResponse> GetAlgorithmWithOptionsAsync(string AlgorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取一个算法信息
         *
         * @return GetAlgorithmResponse
         */
        public GetAlgorithmResponse GetAlgorithm(string AlgorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlgorithmWithOptions(AlgorithmId, headers, runtime);
        }

        /**
         * @summary 获取一个算法信息
         *
         * @return GetAlgorithmResponse
         */
        public async Task<GetAlgorithmResponse> GetAlgorithmAsync(string AlgorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlgorithmWithOptionsAsync(AlgorithmId, headers, runtime);
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAlgorithmVersionResponse
         */
        public GetAlgorithmVersionResponse GetAlgorithmVersionWithOptions(string AlgorithmId, string AlgorithmVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAlgorithmVersionResponse
         */
        public async Task<GetAlgorithmVersionResponse> GetAlgorithmVersionWithOptionsAsync(string AlgorithmId, string AlgorithmVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @return GetAlgorithmVersionResponse
         */
        public GetAlgorithmVersionResponse GetAlgorithmVersion(string AlgorithmId, string AlgorithmVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlgorithmVersionWithOptions(AlgorithmId, AlgorithmVersion, headers, runtime);
        }

        /**
         * @summary 创建一个新的算法版本
         *
         * @return GetAlgorithmVersionResponse
         */
        public async Task<GetAlgorithmVersionResponse> GetAlgorithmVersionAsync(string AlgorithmId, string AlgorithmVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlgorithmVersionWithOptionsAsync(AlgorithmId, AlgorithmVersion, headers, runtime);
        }

        /**
         * @deprecated OpenAPI GetMachineGroup is deprecated
         *
         * @summary get machine group
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMachineGroupResponse
         */
        // Deprecated
        public GetMachineGroupResponse GetMachineGroupWithOptions(string MachineGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GetMachineGroup is deprecated
         *
         * @summary get machine group
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMachineGroupResponse
         */
        // Deprecated
        public async Task<GetMachineGroupResponse> GetMachineGroupWithOptionsAsync(string MachineGroupID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GetMachineGroup is deprecated
         *
         * @summary get machine group
         *
         * @return GetMachineGroupResponse
         */
        // Deprecated
        public GetMachineGroupResponse GetMachineGroup(string MachineGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMachineGroupWithOptions(MachineGroupID, headers, runtime);
        }

        /**
         * @deprecated OpenAPI GetMachineGroup is deprecated
         *
         * @summary get machine group
         *
         * @return GetMachineGroupResponse
         */
        // Deprecated
        public async Task<GetMachineGroupResponse> GetMachineGroupAsync(string MachineGroupID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMachineGroupWithOptionsAsync(MachineGroupID, headers, runtime);
        }

        /**
         * @summary get resource group node metrics
         *
         * @param request GetNodeMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeMetricsResponse
         */
        public GetNodeMetricsResponse GetNodeMetricsWithOptions(string ResourceGroupID, string MetricType, GetNodeMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GPUType))
            {
                query["GPUType"] = request.GPUType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/nodemetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricType),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get resource group node metrics
         *
         * @param request GetNodeMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeMetricsResponse
         */
        public async Task<GetNodeMetricsResponse> GetNodeMetricsWithOptionsAsync(string ResourceGroupID, string MetricType, GetNodeMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GPUType))
            {
                query["GPUType"] = request.GPUType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/nodemetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MetricType),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get resource group node metrics
         *
         * @param request GetNodeMetricsRequest
         * @return GetNodeMetricsResponse
         */
        public GetNodeMetricsResponse GetNodeMetrics(string ResourceGroupID, string MetricType, GetNodeMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNodeMetricsWithOptions(ResourceGroupID, MetricType, request, headers, runtime);
        }

        /**
         * @summary get resource group node metrics
         *
         * @param request GetNodeMetricsRequest
         * @return GetNodeMetricsResponse
         */
        public async Task<GetNodeMetricsResponse> GetNodeMetricsAsync(string ResourceGroupID, string MetricType, GetNodeMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNodeMetricsWithOptionsAsync(ResourceGroupID, MetricType, request, headers, runtime);
        }

        /**
         * @summary 获取Quota
         *
         * @param request GetQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaResponse
         */
        public GetQuotaResponse GetQuotaWithOptions(string QuotaId, GetQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Quota
         *
         * @param request GetQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaResponse
         */
        public async Task<GetQuotaResponse> GetQuotaWithOptionsAsync(string QuotaId, GetQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Quota
         *
         * @param request GetQuotaRequest
         * @return GetQuotaResponse
         */
        public GetQuotaResponse GetQuota(string QuotaId, GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaWithOptions(QuotaId, request, headers, runtime);
        }

        /**
         * @summary 获取Quota
         *
         * @param request GetQuotaRequest
         * @return GetQuotaResponse
         */
        public async Task<GetQuotaResponse> GetQuotaAsync(string QuotaId, GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaWithOptionsAsync(QuotaId, request, headers, runtime);
        }

        /**
         * @summary get resource group by group id
         *
         * @param tmpReq GetResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupResponse
         */
        public GetResourceGroupResponse GetResourceGroupWithOptions(string ResourceGroupID, GetResourceGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceGroupShrinkRequest request = new GetResourceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAIWorkspaceDataEnabled))
            {
                query["IsAIWorkspaceDataEnabled"] = request.IsAIWorkspaceDataEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get resource group by group id
         *
         * @param tmpReq GetResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupResponse
         */
        public async Task<GetResourceGroupResponse> GetResourceGroupWithOptionsAsync(string ResourceGroupID, GetResourceGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceGroupShrinkRequest request = new GetResourceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAIWorkspaceDataEnabled))
            {
                query["IsAIWorkspaceDataEnabled"] = request.IsAIWorkspaceDataEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get resource group by group id
         *
         * @param request GetResourceGroupRequest
         * @return GetResourceGroupResponse
         */
        public GetResourceGroupResponse GetResourceGroup(string ResourceGroupID, GetResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceGroupWithOptions(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary get resource group by group id
         *
         * @param request GetResourceGroupRequest
         * @return GetResourceGroupResponse
         */
        public async Task<GetResourceGroupResponse> GetResourceGroupAsync(string ResourceGroupID, GetResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceGroupWithOptionsAsync(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary get machine group
         *
         * @param tmpReq GetResourceGroupMachineGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupMachineGroupResponse
         */
        public GetResourceGroupMachineGroupResponse GetResourceGroupMachineGroupWithOptions(string MachineGroupID, string ResourceGroupID, GetResourceGroupMachineGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceGroupMachineGroupShrinkRequest request = new GetResourceGroupMachineGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupMachineGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get machine group
         *
         * @param tmpReq GetResourceGroupMachineGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupMachineGroupResponse
         */
        public async Task<GetResourceGroupMachineGroupResponse> GetResourceGroupMachineGroupWithOptionsAsync(string MachineGroupID, string ResourceGroupID, GetResourceGroupMachineGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceGroupMachineGroupShrinkRequest request = new GetResourceGroupMachineGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupMachineGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/machinegroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MachineGroupID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupMachineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get machine group
         *
         * @param request GetResourceGroupMachineGroupRequest
         * @return GetResourceGroupMachineGroupResponse
         */
        public GetResourceGroupMachineGroupResponse GetResourceGroupMachineGroup(string MachineGroupID, string ResourceGroupID, GetResourceGroupMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceGroupMachineGroupWithOptions(MachineGroupID, ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary get machine group
         *
         * @param request GetResourceGroupMachineGroupRequest
         * @return GetResourceGroupMachineGroupResponse
         */
        public async Task<GetResourceGroupMachineGroupResponse> GetResourceGroupMachineGroupAsync(string MachineGroupID, string ResourceGroupID, GetResourceGroupMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceGroupMachineGroupWithOptionsAsync(MachineGroupID, ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary get resource group requested resource by resource group id
         *
         * @param request GetResourceGroupRequestRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupRequestResponse
         */
        public GetResourceGroupRequestResponse GetResourceGroupRequestWithOptions(GetResourceGroupRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodStatus))
            {
                query["PodStatus"] = request.PodStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupID))
            {
                query["ResourceGroupID"] = request.ResourceGroupID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupRequest",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/data/request",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get resource group requested resource by resource group id
         *
         * @param request GetResourceGroupRequestRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupRequestResponse
         */
        public async Task<GetResourceGroupRequestResponse> GetResourceGroupRequestWithOptionsAsync(GetResourceGroupRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodStatus))
            {
                query["PodStatus"] = request.PodStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupID))
            {
                query["ResourceGroupID"] = request.ResourceGroupID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupRequest",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/data/request",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get resource group requested resource by resource group id
         *
         * @param request GetResourceGroupRequestRequest
         * @return GetResourceGroupRequestResponse
         */
        public GetResourceGroupRequestResponse GetResourceGroupRequest(GetResourceGroupRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceGroupRequestWithOptions(request, headers, runtime);
        }

        /**
         * @summary get resource group requested resource by resource group id
         *
         * @param request GetResourceGroupRequestRequest
         * @return GetResourceGroupRequestResponse
         */
        public async Task<GetResourceGroupRequestResponse> GetResourceGroupRequestAsync(GetResourceGroupRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceGroupRequestWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary get resource group total resource by group id
         *
         * @param request GetResourceGroupTotalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupTotalResponse
         */
        public GetResourceGroupTotalResponse GetResourceGroupTotalWithOptions(GetResourceGroupTotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupID))
            {
                query["ResourceGroupID"] = request.ResourceGroupID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupTotal",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/data/total",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupTotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get resource group total resource by group id
         *
         * @param request GetResourceGroupTotalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupTotalResponse
         */
        public async Task<GetResourceGroupTotalResponse> GetResourceGroupTotalWithOptionsAsync(GetResourceGroupTotalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupID))
            {
                query["ResourceGroupID"] = request.ResourceGroupID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupTotal",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/data/total",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get resource group total resource by group id
         *
         * @param request GetResourceGroupTotalRequest
         * @return GetResourceGroupTotalResponse
         */
        public GetResourceGroupTotalResponse GetResourceGroupTotal(GetResourceGroupTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceGroupTotalWithOptions(request, headers, runtime);
        }

        /**
         * @summary get resource group total resource by group id
         *
         * @param request GetResourceGroupTotalRequest
         * @return GetResourceGroupTotalResponse
         */
        public async Task<GetResourceGroupTotalResponse> GetResourceGroupTotalAsync(GetResourceGroupTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceGroupTotalWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 调用GetToken获取临时鉴权信息
         *
         * @param request GetTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTokenResponse
         */
        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobId))
            {
                query["TrainingJobId"] = request.TrainingJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用GetToken获取临时鉴权信息
         *
         * @param request GetTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTokenResponse
         */
        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobId))
            {
                query["TrainingJobId"] = request.TrainingJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用GetToken获取临时鉴权信息
         *
         * @param request GetTokenRequest
         * @return GetTokenResponse
         */
        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 调用GetToken获取临时鉴权信息
         *
         * @param request GetTokenRequest
         * @return GetTokenResponse
         */
        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取TrainingJob的详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrainingJobResponse
         */
        public GetTrainingJobResponse GetTrainingJobWithOptions(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取TrainingJob的详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrainingJobResponse
         */
        public async Task<GetTrainingJobResponse> GetTrainingJobWithOptionsAsync(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取TrainingJob的详情
         *
         * @return GetTrainingJobResponse
         */
        public GetTrainingJobResponse GetTrainingJob(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrainingJobWithOptions(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 获取TrainingJob的详情
         *
         * @return GetTrainingJobResponse
         */
        public async Task<GetTrainingJobResponse> GetTrainingJobAsync(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrainingJobWithOptionsAsync(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 获取Training Job的算法错误信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrainingJobErrorInfoResponse
         */
        public GetTrainingJobErrorInfoResponse GetTrainingJobErrorInfoWithOptions(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainingJobErrorInfo",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/errorinfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainingJobErrorInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job的算法错误信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrainingJobErrorInfoResponse
         */
        public async Task<GetTrainingJobErrorInfoResponse> GetTrainingJobErrorInfoWithOptionsAsync(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainingJobErrorInfo",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/errorinfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainingJobErrorInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job的算法错误信息
         *
         * @return GetTrainingJobErrorInfoResponse
         */
        public GetTrainingJobErrorInfoResponse GetTrainingJobErrorInfo(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrainingJobErrorInfoWithOptions(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 获取Training Job的算法错误信息
         *
         * @return GetTrainingJobErrorInfoResponse
         */
        public async Task<GetTrainingJobErrorInfoResponse> GetTrainingJobErrorInfoAsync(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrainingJobErrorInfoWithOptionsAsync(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 获取TrainingJob最近的Metrics
         *
         * @param request GetTrainingJobLatestMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrainingJobLatestMetricsResponse
         */
        public GetTrainingJobLatestMetricsResponse GetTrainingJobLatestMetricsWithOptions(string TrainingJobId, GetTrainingJobLatestMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainingJobLatestMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/latestmetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainingJobLatestMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取TrainingJob最近的Metrics
         *
         * @param request GetTrainingJobLatestMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrainingJobLatestMetricsResponse
         */
        public async Task<GetTrainingJobLatestMetricsResponse> GetTrainingJobLatestMetricsWithOptionsAsync(string TrainingJobId, GetTrainingJobLatestMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrainingJobLatestMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/latestmetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrainingJobLatestMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取TrainingJob最近的Metrics
         *
         * @param request GetTrainingJobLatestMetricsRequest
         * @return GetTrainingJobLatestMetricsResponse
         */
        public GetTrainingJobLatestMetricsResponse GetTrainingJobLatestMetrics(string TrainingJobId, GetTrainingJobLatestMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrainingJobLatestMetricsWithOptions(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取TrainingJob最近的Metrics
         *
         * @param request GetTrainingJobLatestMetricsRequest
         * @return GetTrainingJobLatestMetricsResponse
         */
        public async Task<GetTrainingJobLatestMetricsResponse> GetTrainingJobLatestMetricsAsync(string TrainingJobId, GetTrainingJobLatestMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrainingJobLatestMetricsWithOptionsAsync(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary get user view  metrics
         *
         * @param request GetUserViewMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserViewMetricsResponse
         */
        public GetUserViewMetricsResponse GetUserViewMetricsWithOptions(string ResourceGroupID, GetUserViewMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
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
                Action = "GetUserViewMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/usermetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserViewMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get user view  metrics
         *
         * @param request GetUserViewMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserViewMetricsResponse
         */
        public async Task<GetUserViewMetricsResponse> GetUserViewMetricsWithOptionsAsync(string ResourceGroupID, GetUserViewMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
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
                Action = "GetUserViewMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/usermetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserViewMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get user view  metrics
         *
         * @param request GetUserViewMetricsRequest
         * @return GetUserViewMetricsResponse
         */
        public GetUserViewMetricsResponse GetUserViewMetrics(string ResourceGroupID, GetUserViewMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserViewMetricsWithOptions(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary get user view  metrics
         *
         * @param request GetUserViewMetricsRequest
         * @return GetUserViewMetricsResponse
         */
        public async Task<GetUserViewMetricsResponse> GetUserViewMetricsAsync(string ResourceGroupID, GetUserViewMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserViewMetricsWithOptionsAsync(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary 获取算法的所有版本信息
         *
         * @param request ListAlgorithmVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlgorithmVersionsResponse
         */
        public ListAlgorithmVersionsResponse ListAlgorithmVersionsWithOptions(string AlgorithmId, ListAlgorithmVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAlgorithmVersions",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlgorithmVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取算法的所有版本信息
         *
         * @param request ListAlgorithmVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlgorithmVersionsResponse
         */
        public async Task<ListAlgorithmVersionsResponse> ListAlgorithmVersionsWithOptionsAsync(string AlgorithmId, ListAlgorithmVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAlgorithmVersions",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlgorithmVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取算法的所有版本信息
         *
         * @param request ListAlgorithmVersionsRequest
         * @return ListAlgorithmVersionsResponse
         */
        public ListAlgorithmVersionsResponse ListAlgorithmVersions(string AlgorithmId, ListAlgorithmVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlgorithmVersionsWithOptions(AlgorithmId, request, headers, runtime);
        }

        /**
         * @summary 获取算法的所有版本信息
         *
         * @param request ListAlgorithmVersionsRequest
         * @return ListAlgorithmVersionsResponse
         */
        public async Task<ListAlgorithmVersionsResponse> ListAlgorithmVersionsAsync(string AlgorithmId, ListAlgorithmVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlgorithmVersionsWithOptionsAsync(AlgorithmId, request, headers, runtime);
        }

        /**
         * @summary 获取算法列表
         *
         * @param request ListAlgorithmsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlgorithmsResponse
         */
        public ListAlgorithmsResponse ListAlgorithmsWithOptions(ListAlgorithmsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmId))
            {
                query["AlgorithmId"] = request.AlgorithmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                query["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmProvider))
            {
                query["AlgorithmProvider"] = request.AlgorithmProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAlgorithms",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlgorithmsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取算法列表
         *
         * @param request ListAlgorithmsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlgorithmsResponse
         */
        public async Task<ListAlgorithmsResponse> ListAlgorithmsWithOptionsAsync(ListAlgorithmsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmId))
            {
                query["AlgorithmId"] = request.AlgorithmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                query["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmProvider))
            {
                query["AlgorithmProvider"] = request.AlgorithmProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAlgorithms",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlgorithmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取算法列表
         *
         * @param request ListAlgorithmsRequest
         * @return ListAlgorithmsResponse
         */
        public ListAlgorithmsResponse ListAlgorithms(ListAlgorithmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlgorithmsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取算法列表
         *
         * @param request ListAlgorithmsRequest
         * @return ListAlgorithmsResponse
         */
        public async Task<ListAlgorithmsResponse> ListAlgorithmsAsync(ListAlgorithmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlgorithmsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取资源节点列表
         *
         * @param request ListNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public ListNodesResponse ListNodesWithOptions(ListNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterByQuotaId))
            {
                query["FilterByQuotaId"] = request.FilterByQuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterByResourceGroupIds))
            {
                query["FilterByResourceGroupIds"] = request.FilterByResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GPUType))
            {
                query["GPUType"] = request.GPUType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                query["NodeNames"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStatuses))
            {
                query["NodeStatuses"] = request.NodeStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeTypes))
            {
                query["NodeTypes"] = request.NodeTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatuses))
            {
                query["OrderStatuses"] = request.OrderStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取资源节点列表
         *
         * @param request ListNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterByQuotaId))
            {
                query["FilterByQuotaId"] = request.FilterByQuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterByResourceGroupIds))
            {
                query["FilterByResourceGroupIds"] = request.FilterByResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GPUType))
            {
                query["GPUType"] = request.GPUType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                query["NodeNames"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStatuses))
            {
                query["NodeStatuses"] = request.NodeStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeTypes))
            {
                query["NodeTypes"] = request.NodeTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatuses))
            {
                query["OrderStatuses"] = request.OrderStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取资源节点列表
         *
         * @param request ListNodesRequest
         * @return ListNodesResponse
         */
        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNodesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取资源节点列表
         *
         * @param request ListNodesRequest
         * @return ListNodesResponse
         */
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNodesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取Quota列表
         *
         * @param request ListQuotasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotasResponse
         */
        public ListQuotasResponse ListQuotasWithOptions(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutMode))
            {
                query["LayoutMode"] = request.LayoutMode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentQuotaId))
            {
                query["ParentQuotaId"] = request.ParentQuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaIds))
            {
                query["QuotaIds"] = request.QuotaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                query["QuotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                query["Statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Quota列表
         *
         * @param request ListQuotasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQuotasResponse
         */
        public async Task<ListQuotasResponse> ListQuotasWithOptionsAsync(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutMode))
            {
                query["LayoutMode"] = request.LayoutMode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentQuotaId))
            {
                query["ParentQuotaId"] = request.ParentQuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaIds))
            {
                query["QuotaIds"] = request.QuotaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                query["QuotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                query["Statuses"] = request.Statuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Quota列表
         *
         * @param request ListQuotasRequest
         * @return ListQuotasResponse
         */
        public ListQuotasResponse ListQuotas(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQuotasWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取Quota列表
         *
         * @param request ListQuotasRequest
         * @return ListQuotasResponse
         */
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQuotasWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary list machine groups
         *
         * @param request ListResourceGroupMachineGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceGroupMachineGroupsResponse
         */
        public ListResourceGroupMachineGroupsResponse ListResourceGroupMachineGroupsWithOptions(string ResourceGroupID, ListResourceGroupMachineGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorID))
            {
                query["CreatorID"] = request.CreatorID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                query["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInstanceId))
            {
                query["OrderInstanceId"] = request.OrderInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                query["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                query["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceGroupMachineGroups",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/machinegroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceGroupMachineGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list machine groups
         *
         * @param request ListResourceGroupMachineGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceGroupMachineGroupsResponse
         */
        public async Task<ListResourceGroupMachineGroupsResponse> ListResourceGroupMachineGroupsWithOptionsAsync(string ResourceGroupID, ListResourceGroupMachineGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorID))
            {
                query["CreatorID"] = request.CreatorID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                query["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInstanceId))
            {
                query["OrderInstanceId"] = request.OrderInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                query["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                query["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceGroupMachineGroups",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID) + "/machinegroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceGroupMachineGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list machine groups
         *
         * @param request ListResourceGroupMachineGroupsRequest
         * @return ListResourceGroupMachineGroupsResponse
         */
        public ListResourceGroupMachineGroupsResponse ListResourceGroupMachineGroups(string ResourceGroupID, ListResourceGroupMachineGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceGroupMachineGroupsWithOptions(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary list machine groups
         *
         * @param request ListResourceGroupMachineGroupsRequest
         * @return ListResourceGroupMachineGroupsResponse
         */
        public async Task<ListResourceGroupMachineGroupsResponse> ListResourceGroupMachineGroupsAsync(string ResourceGroupID, ListResourceGroupMachineGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceGroupMachineGroupsWithOptionsAsync(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary list resource group
         *
         * @param request ListResourceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceGroupsResponse
         */
        public ListResourceGroupsResponse ListResourceGroupsWithOptions(ListResourceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputingResourceProvider))
            {
                query["ComputingResourceProvider"] = request.ComputingResourceProvider;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAll))
            {
                query["ShowAll"] = request.ShowAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceGroups",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list resource group
         *
         * @param request ListResourceGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceGroupsResponse
         */
        public async Task<ListResourceGroupsResponse> ListResourceGroupsWithOptionsAsync(ListResourceGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputingResourceProvider))
            {
                query["ComputingResourceProvider"] = request.ComputingResourceProvider;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAll))
            {
                query["ShowAll"] = request.ShowAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceGroups",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list resource group
         *
         * @param request ListResourceGroupsRequest
         * @return ListResourceGroupsResponse
         */
        public ListResourceGroupsResponse ListResourceGroups(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary list resource group
         *
         * @param request ListResourceGroupsRequest
         * @return ListResourceGroupsResponse
         */
        public async Task<ListResourceGroupsResponse> ListResourceGroupsAsync(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取指定TrainingJob的事件。
         *
         * @param request ListTrainingJobEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobEventsResponse
         */
        public ListTrainingJobEventsResponse ListTrainingJobEventsWithOptions(string TrainingJobId, ListTrainingJobEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobEvents",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定TrainingJob的事件。
         *
         * @param request ListTrainingJobEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobEventsResponse
         */
        public async Task<ListTrainingJobEventsResponse> ListTrainingJobEventsWithOptionsAsync(string TrainingJobId, ListTrainingJobEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobEvents",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定TrainingJob的事件。
         *
         * @param request ListTrainingJobEventsRequest
         * @return ListTrainingJobEventsResponse
         */
        public ListTrainingJobEventsResponse ListTrainingJobEvents(string TrainingJobId, ListTrainingJobEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrainingJobEventsWithOptions(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取指定TrainingJob的事件。
         *
         * @param request ListTrainingJobEventsRequest
         * @return ListTrainingJobEventsResponse
         */
        public async Task<ListTrainingJobEventsResponse> ListTrainingJobEventsAsync(string TrainingJobId, ListTrainingJobEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrainingJobEventsWithOptionsAsync(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取指定Instance（TrainingJob的运行单元）的日志。
         *
         * @param request ListTrainingJobInstanceEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobInstanceEventsResponse
         */
        public ListTrainingJobInstanceEventsResponse ListTrainingJobInstanceEventsWithOptions(string TrainingJobId, string InstanceId, ListTrainingJobInstanceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobInstanceEvents",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobInstanceEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定Instance（TrainingJob的运行单元）的日志。
         *
         * @param request ListTrainingJobInstanceEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobInstanceEventsResponse
         */
        public async Task<ListTrainingJobInstanceEventsResponse> ListTrainingJobInstanceEventsWithOptionsAsync(string TrainingJobId, string InstanceId, ListTrainingJobInstanceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobInstanceEvents",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobInstanceEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定Instance（TrainingJob的运行单元）的日志。
         *
         * @param request ListTrainingJobInstanceEventsRequest
         * @return ListTrainingJobInstanceEventsResponse
         */
        public ListTrainingJobInstanceEventsResponse ListTrainingJobInstanceEvents(string TrainingJobId, string InstanceId, ListTrainingJobInstanceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrainingJobInstanceEventsWithOptions(TrainingJobId, InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取指定Instance（TrainingJob的运行单元）的日志。
         *
         * @param request ListTrainingJobInstanceEventsRequest
         * @return ListTrainingJobInstanceEventsResponse
         */
        public async Task<ListTrainingJobInstanceEventsResponse> ListTrainingJobInstanceEventsAsync(string TrainingJobId, string InstanceId, ListTrainingJobInstanceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrainingJobInstanceEventsWithOptionsAsync(TrainingJobId, InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取Training Job实例的Metrics
         *
         * @param request ListTrainingJobInstanceMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobInstanceMetricsResponse
         */
        public ListTrainingJobInstanceMetricsResponse ListTrainingJobInstanceMetricsWithOptions(string TrainingJobId, ListTrainingJobInstanceMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobInstanceMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instancemetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobInstanceMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job实例的Metrics
         *
         * @param request ListTrainingJobInstanceMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobInstanceMetricsResponse
         */
        public async Task<ListTrainingJobInstanceMetricsResponse> ListTrainingJobInstanceMetricsWithOptionsAsync(string TrainingJobId, ListTrainingJobInstanceMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStep))
            {
                query["TimeStep"] = request.TimeStep;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobInstanceMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/instancemetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobInstanceMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job实例的Metrics
         *
         * @param request ListTrainingJobInstanceMetricsRequest
         * @return ListTrainingJobInstanceMetricsResponse
         */
        public ListTrainingJobInstanceMetricsResponse ListTrainingJobInstanceMetrics(string TrainingJobId, ListTrainingJobInstanceMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrainingJobInstanceMetricsWithOptions(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取Training Job实例的Metrics
         *
         * @param request ListTrainingJobInstanceMetricsRequest
         * @return ListTrainingJobInstanceMetricsResponse
         */
        public async Task<ListTrainingJobInstanceMetricsResponse> ListTrainingJobInstanceMetricsAsync(string TrainingJobId, ListTrainingJobInstanceMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrainingJobInstanceMetricsWithOptionsAsync(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取Training Job的日志
         *
         * @param request ListTrainingJobLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobLogsResponse
         */
        public ListTrainingJobLogsResponse ListTrainingJobLogsWithOptions(string TrainingJobId, ListTrainingJobLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerId))
            {
                query["WorkerId"] = request.WorkerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobLogs",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job的日志
         *
         * @param request ListTrainingJobLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobLogsResponse
         */
        public async Task<ListTrainingJobLogsResponse> ListTrainingJobLogsWithOptionsAsync(string TrainingJobId, ListTrainingJobLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerId))
            {
                query["WorkerId"] = request.WorkerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobLogs",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job的日志
         *
         * @param request ListTrainingJobLogsRequest
         * @return ListTrainingJobLogsResponse
         */
        public ListTrainingJobLogsResponse ListTrainingJobLogs(string TrainingJobId, ListTrainingJobLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrainingJobLogsWithOptions(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取Training Job的日志
         *
         * @param request ListTrainingJobLogsRequest
         * @return ListTrainingJobLogsResponse
         */
        public async Task<ListTrainingJobLogsResponse> ListTrainingJobLogsAsync(string TrainingJobId, ListTrainingJobLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrainingJobLogsWithOptionsAsync(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取Training Job的Metrics
         *
         * @param request ListTrainingJobMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobMetricsResponse
         */
        public ListTrainingJobMetricsResponse ListTrainingJobMetricsWithOptions(string TrainingJobId, ListTrainingJobMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job的Metrics
         *
         * @param request ListTrainingJobMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobMetricsResponse
         */
        public async Task<ListTrainingJobMetricsResponse> ListTrainingJobMetricsWithOptionsAsync(string TrainingJobId, ListTrainingJobMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobMetrics",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job的Metrics
         *
         * @param request ListTrainingJobMetricsRequest
         * @return ListTrainingJobMetricsResponse
         */
        public ListTrainingJobMetricsResponse ListTrainingJobMetrics(string TrainingJobId, ListTrainingJobMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrainingJobMetricsWithOptions(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取Training Job的Metrics
         *
         * @param request ListTrainingJobMetricsRequest
         * @return ListTrainingJobMetricsResponse
         */
        public async Task<ListTrainingJobMetricsResponse> ListTrainingJobMetricsAsync(string TrainingJobId, ListTrainingJobMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrainingJobMetricsWithOptionsAsync(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 获取Training Job 产出的所有模型信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobOutputModelsResponse
         */
        public ListTrainingJobOutputModelsResponse ListTrainingJobOutputModelsWithOptions(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobOutputModels",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/outputmodels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobOutputModelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job 产出的所有模型信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobOutputModelsResponse
         */
        public async Task<ListTrainingJobOutputModelsResponse> ListTrainingJobOutputModelsWithOptionsAsync(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrainingJobOutputModels",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/outputmodels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobOutputModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Training Job 产出的所有模型信息
         *
         * @return ListTrainingJobOutputModelsResponse
         */
        public ListTrainingJobOutputModelsResponse ListTrainingJobOutputModels(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrainingJobOutputModelsWithOptions(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 获取Training Job 产出的所有模型信息
         *
         * @return ListTrainingJobOutputModelsResponse
         */
        public async Task<ListTrainingJobOutputModelsResponse> ListTrainingJobOutputModelsAsync(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrainingJobOutputModelsWithOptionsAsync(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 获取TrainingJob的列表
         *
         * @param tmpReq ListTrainingJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobsResponse
         */
        public ListTrainingJobsResponse ListTrainingJobsWithOptions(ListTrainingJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTrainingJobsShrinkRequest request = new ListTrainingJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                query["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmProvider))
            {
                query["AlgorithmProvider"] = request.AlgorithmProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsTempAlgo))
            {
                query["IsTempAlgo"] = request.IsTempAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobId))
            {
                query["TrainingJobId"] = request.TrainingJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobName))
            {
                query["TrainingJobName"] = request.TrainingJobName;
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
                Action = "ListTrainingJobs",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取TrainingJob的列表
         *
         * @param tmpReq ListTrainingJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrainingJobsResponse
         */
        public async Task<ListTrainingJobsResponse> ListTrainingJobsWithOptionsAsync(ListTrainingJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTrainingJobsShrinkRequest request = new ListTrainingJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmName))
            {
                query["AlgorithmName"] = request.AlgorithmName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmProvider))
            {
                query["AlgorithmProvider"] = request.AlgorithmProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsTempAlgo))
            {
                query["IsTempAlgo"] = request.IsTempAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobId))
            {
                query["TrainingJobId"] = request.TrainingJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingJobName))
            {
                query["TrainingJobName"] = request.TrainingJobName;
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
                Action = "ListTrainingJobs",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrainingJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取TrainingJob的列表
         *
         * @param request ListTrainingJobsRequest
         * @return ListTrainingJobsResponse
         */
        public ListTrainingJobsResponse ListTrainingJobs(ListTrainingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrainingJobsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取TrainingJob的列表
         *
         * @param request ListTrainingJobsRequest
         * @return ListTrainingJobsResponse
         */
        public async Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrainingJobsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 扩缩容Quota
         *
         * @param request ScaleQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleQuotaResponse
         */
        public ScaleQuotaResponse ScaleQuotaWithOptions(string QuotaId, ScaleQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["Min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                body["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId) + "/action/scale",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 扩缩容Quota
         *
         * @param request ScaleQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleQuotaResponse
         */
        public async Task<ScaleQuotaResponse> ScaleQuotaWithOptionsAsync(string QuotaId, ScaleQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["Min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                body["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId) + "/action/scale",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 扩缩容Quota
         *
         * @param request ScaleQuotaRequest
         * @return ScaleQuotaResponse
         */
        public ScaleQuotaResponse ScaleQuota(string QuotaId, ScaleQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleQuotaWithOptions(QuotaId, request, headers, runtime);
        }

        /**
         * @summary 扩缩容Quota
         *
         * @param request ScaleQuotaRequest
         * @return ScaleQuotaResponse
         */
        public async Task<ScaleQuotaResponse> ScaleQuotaAsync(string QuotaId, ScaleQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleQuotaWithOptionsAsync(QuotaId, request, headers, runtime);
        }

        /**
         * @summary 停止一个TrainingJob
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopTrainingJobResponse
         */
        public StopTrainingJobResponse StopTrainingJobWithOptions(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 停止一个TrainingJob
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopTrainingJobResponse
         */
        public async Task<StopTrainingJobResponse> StopTrainingJobWithOptionsAsync(string TrainingJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTrainingJob",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 停止一个TrainingJob
         *
         * @return StopTrainingJobResponse
         */
        public StopTrainingJobResponse StopTrainingJob(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTrainingJobWithOptions(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 停止一个TrainingJob
         *
         * @return StopTrainingJobResponse
         */
        public async Task<StopTrainingJobResponse> StopTrainingJobAsync(string TrainingJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTrainingJobWithOptionsAsync(TrainingJobId, headers, runtime);
        }

        /**
         * @summary 更新算法
         *
         * @param request UpdateAlgorithmRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAlgorithmResponse
         */
        public UpdateAlgorithmResponse UpdateAlgorithmWithOptions(string AlgorithmId, UpdateAlgorithmRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmDescription))
            {
                body["AlgorithmDescription"] = request.AlgorithmDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新算法
         *
         * @param request UpdateAlgorithmRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAlgorithmResponse
         */
        public async Task<UpdateAlgorithmResponse> UpdateAlgorithmWithOptionsAsync(string AlgorithmId, UpdateAlgorithmRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmDescription))
            {
                body["AlgorithmDescription"] = request.AlgorithmDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlgorithm",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新算法
         *
         * @param request UpdateAlgorithmRequest
         * @return UpdateAlgorithmResponse
         */
        public UpdateAlgorithmResponse UpdateAlgorithm(string AlgorithmId, UpdateAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAlgorithmWithOptions(AlgorithmId, request, headers, runtime);
        }

        /**
         * @summary 更新算法
         *
         * @param request UpdateAlgorithmRequest
         * @return UpdateAlgorithmResponse
         */
        public async Task<UpdateAlgorithmResponse> UpdateAlgorithmAsync(string AlgorithmId, UpdateAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAlgorithmWithOptionsAsync(AlgorithmId, request, headers, runtime);
        }

        /**
         * @summary 更新算法
         *
         * @param tmpReq UpdateAlgorithmVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAlgorithmVersionResponse
         */
        public UpdateAlgorithmVersionResponse UpdateAlgorithmVersionWithOptions(string AlgorithmId, string AlgorithmVersion, UpdateAlgorithmVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAlgorithmVersionShrinkRequest request = new UpdateAlgorithmVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlgorithmSpec))
            {
                request.AlgorithmSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlgorithmSpec, "AlgorithmSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmSpecShrink))
            {
                body["AlgorithmSpec"] = request.AlgorithmSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlgorithmVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新算法
         *
         * @param tmpReq UpdateAlgorithmVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAlgorithmVersionResponse
         */
        public async Task<UpdateAlgorithmVersionResponse> UpdateAlgorithmVersionWithOptionsAsync(string AlgorithmId, string AlgorithmVersion, UpdateAlgorithmVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAlgorithmVersionShrinkRequest request = new UpdateAlgorithmVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlgorithmSpec))
            {
                request.AlgorithmSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlgorithmSpec, "AlgorithmSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmSpecShrink))
            {
                body["AlgorithmSpec"] = request.AlgorithmSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlgorithmVersion",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlgorithmVersion),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlgorithmVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新算法
         *
         * @param request UpdateAlgorithmVersionRequest
         * @return UpdateAlgorithmVersionResponse
         */
        public UpdateAlgorithmVersionResponse UpdateAlgorithmVersion(string AlgorithmId, string AlgorithmVersion, UpdateAlgorithmVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAlgorithmVersionWithOptions(AlgorithmId, AlgorithmVersion, request, headers, runtime);
        }

        /**
         * @summary 更新算法
         *
         * @param request UpdateAlgorithmVersionRequest
         * @return UpdateAlgorithmVersionResponse
         */
        public async Task<UpdateAlgorithmVersionResponse> UpdateAlgorithmVersionAsync(string AlgorithmId, string AlgorithmVersion, UpdateAlgorithmVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAlgorithmVersionWithOptionsAsync(AlgorithmId, AlgorithmVersion, request, headers, runtime);
        }

        /**
         * @summary 更新Quota
         *
         * @param request UpdateQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQuotaResponse
         */
        public UpdateQuotaResponse UpdateQuotaWithOptions(string QuotaId, UpdateQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueStrategy))
            {
                body["QueueStrategy"] = request.QueueStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaConfig))
            {
                body["QuotaConfig"] = request.QuotaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                body["QuotaName"] = request.QuotaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新Quota
         *
         * @param request UpdateQuotaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQuotaResponse
         */
        public async Task<UpdateQuotaResponse> UpdateQuotaWithOptionsAsync(string QuotaId, UpdateQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueStrategy))
            {
                body["QueueStrategy"] = request.QueueStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaConfig))
            {
                body["QuotaConfig"] = request.QuotaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                body["QuotaName"] = request.QuotaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuota",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(QuotaId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新Quota
         *
         * @param request UpdateQuotaRequest
         * @return UpdateQuotaResponse
         */
        public UpdateQuotaResponse UpdateQuota(string QuotaId, UpdateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateQuotaWithOptions(QuotaId, request, headers, runtime);
        }

        /**
         * @summary 更新Quota
         *
         * @param request UpdateQuotaRequest
         * @return UpdateQuotaResponse
         */
        public async Task<UpdateQuotaResponse> UpdateQuotaAsync(string QuotaId, UpdateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateQuotaWithOptionsAsync(QuotaId, request, headers, runtime);
        }

        /**
         * @summary 更新Resource Group
         *
         * @param request UpdateResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceGroupResponse
         */
        public UpdateResourceGroupResponse UpdateResourceGroupWithOptions(string ResourceGroupID, UpdateResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unbind))
            {
                body["Unbind"] = request.Unbind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新Resource Group
         *
         * @param request UpdateResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceGroupResponse
         */
        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupWithOptionsAsync(string ResourceGroupID, UpdateResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unbind))
            {
                body["Unbind"] = request.Unbind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceGroup",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceGroupID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新Resource Group
         *
         * @param request UpdateResourceGroupRequest
         * @return UpdateResourceGroupResponse
         */
        public UpdateResourceGroupResponse UpdateResourceGroup(string ResourceGroupID, UpdateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceGroupWithOptions(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary 更新Resource Group
         *
         * @param request UpdateResourceGroupRequest
         * @return UpdateResourceGroupResponse
         */
        public async Task<UpdateResourceGroupResponse> UpdateResourceGroupAsync(string ResourceGroupID, UpdateResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceGroupWithOptionsAsync(ResourceGroupID, request, headers, runtime);
        }

        /**
         * @summary 更新一个TrainingJob的Labels
         *
         * @param request UpdateTrainingJobLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrainingJobLabelsResponse
         */
        public UpdateTrainingJobLabelsResponse UpdateTrainingJobLabelsWithOptions(string TrainingJobId, UpdateTrainingJobLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrainingJobLabels",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrainingJobLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新一个TrainingJob的Labels
         *
         * @param request UpdateTrainingJobLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrainingJobLabelsResponse
         */
        public async Task<UpdateTrainingJobLabelsResponse> UpdateTrainingJobLabelsWithOptionsAsync(string TrainingJobId, UpdateTrainingJobLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrainingJobLabels",
                Version = "2022-01-12",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trainingjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrainingJobId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrainingJobLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新一个TrainingJob的Labels
         *
         * @param request UpdateTrainingJobLabelsRequest
         * @return UpdateTrainingJobLabelsResponse
         */
        public UpdateTrainingJobLabelsResponse UpdateTrainingJobLabels(string TrainingJobId, UpdateTrainingJobLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTrainingJobLabelsWithOptions(TrainingJobId, request, headers, runtime);
        }

        /**
         * @summary 更新一个TrainingJob的Labels
         *
         * @param request UpdateTrainingJobLabelsRequest
         * @return UpdateTrainingJobLabelsResponse
         */
        public async Task<UpdateTrainingJobLabelsResponse> UpdateTrainingJobLabelsAsync(string TrainingJobId, UpdateTrainingJobLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTrainingJobLabelsWithOptionsAsync(TrainingJobId, request, headers, runtime);
        }

    }
}
