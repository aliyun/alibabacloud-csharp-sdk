// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Pai_dsw20220101.Models;

namespace AlibabaCloud.SDK.Pai_dsw20220101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("pai-dsw", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request CreateIdleInstanceCullerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIdleInstanceCullerResponse
         */
        public CreateIdleInstanceCullerResponse CreateIdleInstanceCullerWithOptions(string InstanceId, CreateIdleInstanceCullerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPercentThreshold))
            {
                body["CpuPercentThreshold"] = request.CpuPercentThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuPercentThreshold))
            {
                body["GpuPercentThreshold"] = request.GpuPercentThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIdleTimeInMinutes))
            {
                body["MaxIdleTimeInMinutes"] = request.MaxIdleTimeInMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdleInstanceCuller",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/idleinstanceculler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdleInstanceCullerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateIdleInstanceCullerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIdleInstanceCullerResponse
         */
        public async Task<CreateIdleInstanceCullerResponse> CreateIdleInstanceCullerWithOptionsAsync(string InstanceId, CreateIdleInstanceCullerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPercentThreshold))
            {
                body["CpuPercentThreshold"] = request.CpuPercentThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuPercentThreshold))
            {
                body["GpuPercentThreshold"] = request.GpuPercentThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIdleTimeInMinutes))
            {
                body["MaxIdleTimeInMinutes"] = request.MaxIdleTimeInMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdleInstanceCuller",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/idleinstanceculler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdleInstanceCullerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateIdleInstanceCullerRequest
         * @return CreateIdleInstanceCullerResponse
         */
        public CreateIdleInstanceCullerResponse CreateIdleInstanceCuller(string InstanceId, CreateIdleInstanceCullerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIdleInstanceCullerWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @param request CreateIdleInstanceCullerRequest
         * @return CreateIdleInstanceCullerResponse
         */
        public async Task<CreateIdleInstanceCullerResponse> CreateIdleInstanceCullerAsync(string InstanceId, CreateIdleInstanceCullerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIdleInstanceCullerWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建实例
         *
         * @param request CreateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                body["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudDisks))
            {
                body["CloudDisks"] = request.CloudDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfig))
            {
                body["CredentialConfig"] = request.CredentialConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Driver))
            {
                body["Driver"] = request.Driver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["EnvironmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageAuth))
            {
                body["ImageAuth"] = request.ImageAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestedResource))
            {
                body["RequestedResource"] = request.RequestedResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceSource))
            {
                body["WorkspaceSource"] = request.WorkspaceSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实例
         *
         * @param request CreateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                body["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudDisks))
            {
                body["CloudDisks"] = request.CloudDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfig))
            {
                body["CredentialConfig"] = request.CredentialConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Driver))
            {
                body["Driver"] = request.Driver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["EnvironmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageAuth))
            {
                body["ImageAuth"] = request.ImageAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestedResource))
            {
                body["RequestedResource"] = request.RequestedResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceSource))
            {
                body["WorkspaceSource"] = request.WorkspaceSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实例
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实例
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建定时关机任务
         *
         * @param request CreateInstanceShutdownTimerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceShutdownTimerResponse
         */
        public CreateInstanceShutdownTimerResponse CreateInstanceShutdownTimerWithOptions(string InstanceId, CreateInstanceShutdownTimerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["DueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemainingTimeInMs))
            {
                body["RemainingTimeInMs"] = request.RemainingTimeInMs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceShutdownTimer",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/shutdowntimer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceShutdownTimerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建定时关机任务
         *
         * @param request CreateInstanceShutdownTimerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceShutdownTimerResponse
         */
        public async Task<CreateInstanceShutdownTimerResponse> CreateInstanceShutdownTimerWithOptionsAsync(string InstanceId, CreateInstanceShutdownTimerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["DueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemainingTimeInMs))
            {
                body["RemainingTimeInMs"] = request.RemainingTimeInMs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceShutdownTimer",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/shutdowntimer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceShutdownTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建定时关机任务
         *
         * @param request CreateInstanceShutdownTimerRequest
         * @return CreateInstanceShutdownTimerResponse
         */
        public CreateInstanceShutdownTimerResponse CreateInstanceShutdownTimer(string InstanceId, CreateInstanceShutdownTimerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceShutdownTimerWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建定时关机任务
         *
         * @param request CreateInstanceShutdownTimerRequest
         * @return CreateInstanceShutdownTimerResponse
         */
        public async Task<CreateInstanceShutdownTimerResponse> CreateInstanceShutdownTimerAsync(string InstanceId, CreateInstanceShutdownTimerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceShutdownTimerWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建实例快照
         *
         * @param request CreateInstanceSnapshotRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceSnapshotResponse
         */
        public CreateInstanceSnapshotResponse CreateInstanceSnapshotWithOptions(string InstanceId, CreateInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludePaths))
            {
                body["ExcludePaths"] = request.ExcludePaths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                body["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotDescription))
            {
                body["SnapshotDescription"] = request.SnapshotDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                body["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实例快照
         *
         * @param request CreateInstanceSnapshotRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceSnapshotResponse
         */
        public async Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotWithOptionsAsync(string InstanceId, CreateInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludePaths))
            {
                body["ExcludePaths"] = request.ExcludePaths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                body["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotDescription))
            {
                body["SnapshotDescription"] = request.SnapshotDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                body["SnapshotName"] = request.SnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实例快照
         *
         * @param request CreateInstanceSnapshotRequest
         * @return CreateInstanceSnapshotResponse
         */
        public CreateInstanceSnapshotResponse CreateInstanceSnapshot(string InstanceId, CreateInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceSnapshotWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建实例快照
         *
         * @param request CreateInstanceSnapshotRequest
         * @return CreateInstanceSnapshotResponse
         */
        public async Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotAsync(string InstanceId, CreateInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceSnapshotWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIdleInstanceCullerResponse
         */
        public DeleteIdleInstanceCullerResponse DeleteIdleInstanceCullerWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdleInstanceCuller",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/idleinstanceculler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdleInstanceCullerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIdleInstanceCullerResponse
         */
        public async Task<DeleteIdleInstanceCullerResponse> DeleteIdleInstanceCullerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdleInstanceCuller",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/idleinstanceculler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdleInstanceCullerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DeleteIdleInstanceCullerResponse
         */
        public DeleteIdleInstanceCullerResponse DeleteIdleInstanceCuller(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIdleInstanceCullerWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @return DeleteIdleInstanceCullerResponse
         */
        public async Task<DeleteIdleInstanceCullerResponse> DeleteIdleInstanceCullerAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIdleInstanceCullerWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 删除实例
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除实例
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除实例
         *
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @summary 删除实例
         *
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 删除DSW实例的标签
         *
         * @param request DeleteInstanceLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceLabelsResponse
         */
        public DeleteInstanceLabelsResponse DeleteInstanceLabelsWithOptions(string InstanceId, DeleteInstanceLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceLabels",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除DSW实例的标签
         *
         * @param request DeleteInstanceLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceLabelsResponse
         */
        public async Task<DeleteInstanceLabelsResponse> DeleteInstanceLabelsWithOptionsAsync(string InstanceId, DeleteInstanceLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceLabels",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除DSW实例的标签
         *
         * @param request DeleteInstanceLabelsRequest
         * @return DeleteInstanceLabelsResponse
         */
        public DeleteInstanceLabelsResponse DeleteInstanceLabels(string InstanceId, DeleteInstanceLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceLabelsWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 删除DSW实例的标签
         *
         * @param request DeleteInstanceLabelsRequest
         * @return DeleteInstanceLabelsResponse
         */
        public async Task<DeleteInstanceLabelsResponse> DeleteInstanceLabelsAsync(string InstanceId, DeleteInstanceLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceLabelsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 删除定时关机任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceShutdownTimerResponse
         */
        public DeleteInstanceShutdownTimerResponse DeleteInstanceShutdownTimerWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceShutdownTimer",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/shutdowntimer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceShutdownTimerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除定时关机任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceShutdownTimerResponse
         */
        public async Task<DeleteInstanceShutdownTimerResponse> DeleteInstanceShutdownTimerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceShutdownTimer",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/shutdowntimer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceShutdownTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除定时关机任务
         *
         * @return DeleteInstanceShutdownTimerResponse
         */
        public DeleteInstanceShutdownTimerResponse DeleteInstanceShutdownTimer(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceShutdownTimerWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @summary 删除定时关机任务
         *
         * @return DeleteInstanceShutdownTimerResponse
         */
        public async Task<DeleteInstanceShutdownTimerResponse> DeleteInstanceShutdownTimerAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceShutdownTimerWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取实例快照详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceSnapshotResponse
         */
        public DeleteInstanceSnapshotResponse DeleteInstanceSnapshotWithOptions(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例快照详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceSnapshotResponse
         */
        public async Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotWithOptionsAsync(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例快照详情
         *
         * @return DeleteInstanceSnapshotResponse
         */
        public DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceSnapshotWithOptions(InstanceId, SnapshotId, headers, runtime);
        }

        /**
         * @summary 获取实例快照详情
         *
         * @return DeleteInstanceSnapshotResponse
         */
        public async Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotAsync(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceSnapshotWithOptionsAsync(InstanceId, SnapshotId, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIdleInstanceCullerResponse
         */
        public GetIdleInstanceCullerResponse GetIdleInstanceCullerWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdleInstanceCuller",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/idleinstanceculler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdleInstanceCullerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIdleInstanceCullerResponse
         */
        public async Task<GetIdleInstanceCullerResponse> GetIdleInstanceCullerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdleInstanceCuller",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/idleinstanceculler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdleInstanceCullerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetIdleInstanceCullerResponse
         */
        public GetIdleInstanceCullerResponse GetIdleInstanceCuller(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIdleInstanceCullerWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @return GetIdleInstanceCullerResponse
         */
        public async Task<GetIdleInstanceCullerResponse> GetIdleInstanceCullerAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIdleInstanceCullerWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取实例详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例详情
         *
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取实例详情
         *
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @param request GetInstanceEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceEventsResponse
         */
        public GetInstanceEventsResponse GetInstanceEventsWithOptions(string InstanceId, GetInstanceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEventsNum))
            {
                query["MaxEventsNum"] = request.MaxEventsNum;
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
                Action = "GetInstanceEvents",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetInstanceEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceEventsResponse
         */
        public async Task<GetInstanceEventsResponse> GetInstanceEventsWithOptionsAsync(string InstanceId, GetInstanceEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEventsNum))
            {
                query["MaxEventsNum"] = request.MaxEventsNum;
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
                Action = "GetInstanceEvents",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetInstanceEventsRequest
         * @return GetInstanceEventsResponse
         */
        public GetInstanceEventsResponse GetInstanceEvents(string InstanceId, GetInstanceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceEventsWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @param request GetInstanceEventsRequest
         * @return GetInstanceEventsResponse
         */
        public async Task<GetInstanceEventsResponse> GetInstanceEventsAsync(string InstanceId, GetInstanceEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceEventsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @param request GetInstanceMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceMetricsResponse
         */
        public GetInstanceMetricsResponse GetInstanceMetricsWithOptions(string InstanceId, GetInstanceMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "GetInstanceMetrics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instance/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetInstanceMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceMetricsResponse
         */
        public async Task<GetInstanceMetricsResponse> GetInstanceMetricsWithOptionsAsync(string InstanceId, GetInstanceMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "GetInstanceMetrics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instance/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetInstanceMetricsRequest
         * @return GetInstanceMetricsResponse
         */
        public GetInstanceMetricsResponse GetInstanceMetrics(string InstanceId, GetInstanceMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceMetricsWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @param request GetInstanceMetricsRequest
         * @return GetInstanceMetricsResponse
         */
        public async Task<GetInstanceMetricsResponse> GetInstanceMetricsAsync(string InstanceId, GetInstanceMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceMetricsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取定时关机任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceShutdownTimerResponse
         */
        public GetInstanceShutdownTimerResponse GetInstanceShutdownTimerWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceShutdownTimer",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/shutdowntimer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceShutdownTimerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取定时关机任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceShutdownTimerResponse
         */
        public async Task<GetInstanceShutdownTimerResponse> GetInstanceShutdownTimerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceShutdownTimer",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/shutdowntimer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceShutdownTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取定时关机任务
         *
         * @return GetInstanceShutdownTimerResponse
         */
        public GetInstanceShutdownTimerResponse GetInstanceShutdownTimer(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceShutdownTimerWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取定时关机任务
         *
         * @return GetInstanceShutdownTimerResponse
         */
        public async Task<GetInstanceShutdownTimerResponse> GetInstanceShutdownTimerAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceShutdownTimerWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取实例快照详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceSnapshotResponse
         */
        public GetInstanceSnapshotResponse GetInstanceSnapshotWithOptions(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例快照详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceSnapshotResponse
         */
        public async Task<GetInstanceSnapshotResponse> GetInstanceSnapshotWithOptionsAsync(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例快照详情
         *
         * @return GetInstanceSnapshotResponse
         */
        public GetInstanceSnapshotResponse GetInstanceSnapshot(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceSnapshotWithOptions(InstanceId, SnapshotId, headers, runtime);
        }

        /**
         * @summary 获取实例快照详情
         *
         * @return GetInstanceSnapshotResponse
         */
        public async Task<GetInstanceSnapshotResponse> GetInstanceSnapshotAsync(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceSnapshotWithOptionsAsync(InstanceId, SnapshotId, headers, runtime);
        }

        /**
         * @param request GetLifecycleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLifecycleResponse
         */
        public GetLifecycleResponse GetLifecycleWithOptions(string InstanceId, GetLifecycleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionNumber))
            {
                query["SessionNumber"] = request.SessionNumber;
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
                Action = "GetLifecycle",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/lifecycle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLifecycleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetLifecycleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLifecycleResponse
         */
        public async Task<GetLifecycleResponse> GetLifecycleWithOptionsAsync(string InstanceId, GetLifecycleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionNumber))
            {
                query["SessionNumber"] = request.SessionNumber;
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
                Action = "GetLifecycle",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/lifecycle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLifecycleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetLifecycleRequest
         * @return GetLifecycleResponse
         */
        public GetLifecycleResponse GetLifecycle(string InstanceId, GetLifecycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLifecycleWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @param request GetLifecycleRequest
         * @return GetLifecycleResponse
         */
        public async Task<GetLifecycleResponse> GetLifecycleAsync(string InstanceId, GetLifecycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLifecycleWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取metrics数据
         *
         * @param request GetMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricsResponse
         */
        public GetMetricsResponse GetMetricsWithOptions(string InstanceId, GetMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "GetMetrics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instance/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/cms/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取metrics数据
         *
         * @param request GetMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricsResponse
         */
        public async Task<GetMetricsResponse> GetMetricsWithOptionsAsync(string InstanceId, GetMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "GetMetrics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instance/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/cms/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取metrics数据
         *
         * @param request GetMetricsRequest
         * @return GetMetricsResponse
         */
        public GetMetricsResponse GetMetrics(string InstanceId, GetMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMetricsWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取metrics数据
         *
         * @param request GetMetricsRequest
         * @return GetMetricsResponse
         */
        public async Task<GetMetricsResponse> GetMetricsAsync(string InstanceId, GetMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMetricsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @param request GetResourceGroupStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupStatisticsResponse
         */
        public GetResourceGroupStatisticsResponse GetResourceGroupStatisticsWithOptions(GetResourceGroupStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupStatistics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resourcegroupstatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetResourceGroupStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceGroupStatisticsResponse
         */
        public async Task<GetResourceGroupStatisticsResponse> GetResourceGroupStatisticsWithOptionsAsync(GetResourceGroupStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceGroupStatistics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resourcegroupstatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceGroupStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetResourceGroupStatisticsRequest
         * @return GetResourceGroupStatisticsResponse
         */
        public GetResourceGroupStatisticsResponse GetResourceGroupStatistics(GetResourceGroupStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceGroupStatisticsWithOptions(request, headers, runtime);
        }

        /**
         * @param request GetResourceGroupStatisticsRequest
         * @return GetResourceGroupStatisticsResponse
         */
        public async Task<GetResourceGroupStatisticsResponse> GetResourceGroupStatisticsAsync(GetResourceGroupStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceGroupStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /**
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
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
         * @summary 获取用户配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserConfigResponse
         */
        public GetUserConfigResponse GetUserConfigWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/userconfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserConfigResponse
         */
        public async Task<GetUserConfigResponse> GetUserConfigWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserConfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/userconfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户配置
         *
         * @return GetUserConfigResponse
         */
        public GetUserConfigResponse GetUserConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserConfigWithOptions(headers, runtime);
        }

        /**
         * @summary 获取用户配置
         *
         * @return GetUserConfigResponse
         */
        public async Task<GetUserConfigResponse> GetUserConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserConfigWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取ECS规格列表
         *
         * @param request ListEcsSpecsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEcsSpecsResponse
         */
        public ListEcsSpecsResponse ListEcsSpecsWithOptions(ListEcsSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
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
                Action = "ListEcsSpecs",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/ecsspecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取ECS规格列表
         *
         * @param request ListEcsSpecsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEcsSpecsResponse
         */
        public async Task<ListEcsSpecsResponse> ListEcsSpecsWithOptionsAsync(ListEcsSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
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
                Action = "ListEcsSpecs",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/ecsspecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取ECS规格列表
         *
         * @param request ListEcsSpecsRequest
         * @return ListEcsSpecsResponse
         */
        public ListEcsSpecsResponse ListEcsSpecs(ListEcsSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEcsSpecsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取ECS规格列表
         *
         * @param request ListEcsSpecsRequest
         * @return ListEcsSpecsResponse
         */
        public async Task<ListEcsSpecsResponse> ListEcsSpecsAsync(ListEcsSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEcsSpecsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询实例快照列表
         *
         * @param request ListInstanceSnapshotRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceSnapshotResponse
         */
        public ListInstanceSnapshotResponse ListInstanceSnapshotWithOptions(string InstanceId, ListInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询实例快照列表
         *
         * @param request ListInstanceSnapshotRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceSnapshotResponse
         */
        public async Task<ListInstanceSnapshotResponse> ListInstanceSnapshotWithOptionsAsync(string InstanceId, ListInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInstanceSnapshot",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询实例快照列表
         *
         * @param request ListInstanceSnapshotRequest
         * @return ListInstanceSnapshotResponse
         */
        public ListInstanceSnapshotResponse ListInstanceSnapshot(string InstanceId, ListInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceSnapshotWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 查询实例快照列表
         *
         * @param request ListInstanceSnapshotRequest
         * @return ListInstanceSnapshotResponse
         */
        public async Task<ListInstanceSnapshotResponse> ListInstanceSnapshotAsync(string InstanceId, ListInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceSnapshotWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取实例统计信息
         *
         * @param request ListInstanceStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceStatisticsResponse
         */
        public ListInstanceStatisticsResponse ListInstanceStatisticsWithOptions(ListInstanceStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceStatistics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instancestatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例统计信息
         *
         * @param request ListInstanceStatisticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceStatisticsResponse
         */
        public async Task<ListInstanceStatisticsResponse> ListInstanceStatisticsWithOptionsAsync(ListInstanceStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceStatistics",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instancestatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例统计信息
         *
         * @param request ListInstanceStatisticsRequest
         * @return ListInstanceStatisticsResponse
         */
        public ListInstanceStatisticsResponse ListInstanceStatistics(ListInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceStatisticsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实例统计信息
         *
         * @param request ListInstanceStatisticsRequest
         * @return ListInstanceStatisticsResponse
         */
        public async Task<ListInstanceStatisticsResponse> ListInstanceStatisticsAsync(ListInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param tmpReq ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                query["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuType))
            {
                query["GpuType"] = request.GpuType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCpu))
            {
                query["MaxCpu"] = request.MaxCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxGpu))
            {
                query["MaxGpu"] = request.MaxGpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxGpuMemory))
            {
                query["MaxGpuMemory"] = request.MaxGpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMemory))
            {
                query["MaxMemory"] = request.MaxMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCpu))
            {
                query["MinCpu"] = request.MinCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinGpu))
            {
                query["MinGpu"] = request.MinGpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinGpuMemory))
            {
                query["MinGpuMemory"] = request.MinGpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinMemory))
            {
                query["MinMemory"] = request.MinMemory;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Action = "ListInstances",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                query["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuType))
            {
                query["GpuType"] = request.GpuType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCpu))
            {
                query["MaxCpu"] = request.MaxCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxGpu))
            {
                query["MaxGpu"] = request.MaxGpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxGpuMemory))
            {
                query["MaxGpuMemory"] = request.MaxGpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMemory))
            {
                query["MaxMemory"] = request.MaxMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCpu))
            {
                query["MinCpu"] = request.MinCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinGpu))
            {
                query["MinGpu"] = request.MinGpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinGpuMemory))
            {
                query["MinGpuMemory"] = request.MinGpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinMemory))
            {
                query["MinMemory"] = request.MinMemory;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Action = "ListInstances",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启动实例
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartInstanceResponse
         */
        public StartInstanceResponse StartInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动实例
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartInstanceResponse
         */
        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动实例
         *
         * @return StartInstanceResponse
         */
        public StartInstanceResponse StartInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartInstanceWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @summary 启动实例
         *
         * @return StartInstanceResponse
         */
        public async Task<StartInstanceResponse> StartInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 停止实例
         *
         * @param request StopInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopInstanceResponse
         */
        public StopInstanceResponse StopInstanceWithOptions(string InstanceId, StopInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveImage))
            {
                query["SaveImage"] = request.SaveImage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 停止实例
         *
         * @param request StopInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopInstanceResponse
         */
        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(string InstanceId, StopInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveImage))
            {
                query["SaveImage"] = request.SaveImage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 停止实例
         *
         * @param request StopInstanceRequest
         * @return StopInstanceResponse
         */
        public StopInstanceResponse StopInstance(string InstanceId, StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 停止实例
         *
         * @param request StopInstanceRequest
         * @return StopInstanceResponse
         */
        public async Task<StopInstanceResponse> StopInstanceAsync(string InstanceId, StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 更新实例
         *
         * @param request UpdateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstanceWithOptions(string InstanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                body["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudDisks))
            {
                body["CloudDisks"] = request.CloudDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfig))
            {
                body["CredentialConfig"] = request.CredentialConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateCredential))
            {
                body["DisassociateCredential"] = request.DisassociateCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateDatasets))
            {
                body["DisassociateDatasets"] = request.DisassociateDatasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateDriver))
            {
                body["DisassociateDriver"] = request.DisassociateDriver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateForwardInfos))
            {
                body["DisassociateForwardInfos"] = request.DisassociateForwardInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateVpc))
            {
                body["DisassociateVpc"] = request.DisassociateVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Driver))
            {
                body["Driver"] = request.Driver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageAuth))
            {
                body["ImageAuth"] = request.ImageAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestedResource))
            {
                body["RequestedResource"] = request.RequestedResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceSource))
            {
                body["WorkspaceSource"] = request.WorkspaceSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新实例
         *
         * @param request UpdateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(string InstanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Affinity))
            {
                body["Affinity"] = request.Affinity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudDisks))
            {
                body["CloudDisks"] = request.CloudDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfig))
            {
                body["CredentialConfig"] = request.CredentialConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateCredential))
            {
                body["DisassociateCredential"] = request.DisassociateCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateDatasets))
            {
                body["DisassociateDatasets"] = request.DisassociateDatasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateDriver))
            {
                body["DisassociateDriver"] = request.DisassociateDriver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateForwardInfos))
            {
                body["DisassociateForwardInfos"] = request.DisassociateForwardInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisassociateVpc))
            {
                body["DisassociateVpc"] = request.DisassociateVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Driver))
            {
                body["Driver"] = request.Driver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageAuth))
            {
                body["ImageAuth"] = request.ImageAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestedResource))
            {
                body["RequestedResource"] = request.RequestedResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceSource))
            {
                body["WorkspaceSource"] = request.WorkspaceSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新实例
         *
         * @param request UpdateInstanceRequest
         * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstance(string InstanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 更新实例
         *
         * @param request UpdateInstanceRequest
         * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(string InstanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 修改DSW实例的标签
         *
         * @param request UpdateInstanceLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceLabelsResponse
         */
        public UpdateInstanceLabelsResponse UpdateInstanceLabelsWithOptions(string InstanceId, UpdateInstanceLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateInstanceLabels",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改DSW实例的标签
         *
         * @param request UpdateInstanceLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceLabelsResponse
         */
        public async Task<UpdateInstanceLabelsResponse> UpdateInstanceLabelsWithOptionsAsync(string InstanceId, UpdateInstanceLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateInstanceLabels",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改DSW实例的标签
         *
         * @param request UpdateInstanceLabelsRequest
         * @return UpdateInstanceLabelsResponse
         */
        public UpdateInstanceLabelsResponse UpdateInstanceLabels(string InstanceId, UpdateInstanceLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceLabelsWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 修改DSW实例的标签
         *
         * @param request UpdateInstanceLabelsRequest
         * @return UpdateInstanceLabelsResponse
         */
        public async Task<UpdateInstanceLabelsResponse> UpdateInstanceLabelsAsync(string InstanceId, UpdateInstanceLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceLabelsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

    }
}
