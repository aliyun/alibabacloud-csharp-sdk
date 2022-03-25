// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Pai_dsw20210226.Models;

namespace AlibabaCloud.SDK.Pai_dsw20210226
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

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetList))
            {
                body["DatasetList"] = request.DatasetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environments))
            {
                body["Environments"] = request.Environments;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPublic))
            {
                body["IsPublic"] = request.IsPublic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasFileSystemId))
            {
                body["NasFileSystemId"] = request.NasFileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc.ToMap()))
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
                Action = "CreateInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetList))
            {
                body["DatasetList"] = request.DatasetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environments))
            {
                body["Environments"] = request.Environments;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPublic))
            {
                body["IsPublic"] = request.IsPublic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasFileSystemId))
            {
                body["NasFileSystemId"] = request.NasFileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc.ToMap()))
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
                Action = "CreateInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInstanceShutdownTimerResponse CreateInstanceShutdownTimer(string InstanceId, CreateInstanceShutdownTimerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceShutdownTimerWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateInstanceShutdownTimerResponse> CreateInstanceShutdownTimerAsync(string InstanceId, CreateInstanceShutdownTimerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceShutdownTimerWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateInstanceShutdownTimerResponse CreateInstanceShutdownTimerWithOptions(string InstanceId, CreateInstanceShutdownTimerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                body["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtlInMillis))
            {
                body["TtlInMillis"] = request.TtlInMillis;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceShutdownTimer",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/shutdownTimer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceShutdownTimerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceShutdownTimerResponse> CreateInstanceShutdownTimerWithOptionsAsync(string InstanceId, CreateInstanceShutdownTimerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                body["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtlInMillis))
            {
                body["TtlInMillis"] = request.TtlInMillis;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceShutdownTimer",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/shutdownTimer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceShutdownTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInstanceShutdownTimerV2Response CreateInstanceShutdownTimerV2(string InstanceId, CreateInstanceShutdownTimerV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceShutdownTimerV2WithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateInstanceShutdownTimerV2Response> CreateInstanceShutdownTimerV2Async(string InstanceId, CreateInstanceShutdownTimerV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceShutdownTimerV2WithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateInstanceShutdownTimerV2Response CreateInstanceShutdownTimerV2WithOptions(string InstanceId, CreateInstanceShutdownTimerV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
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
                Action = "CreateInstanceShutdownTimerV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/shutdowntimer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceShutdownTimerV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceShutdownTimerV2Response> CreateInstanceShutdownTimerV2WithOptionsAsync(string InstanceId, CreateInstanceShutdownTimerV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
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
                Action = "CreateInstanceShutdownTimerV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/shutdowntimer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceShutdownTimerV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInstanceSnapshotResponse CreateInstanceSnapshot(string InstanceId, CreateInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceSnapshotWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotAsync(string InstanceId, CreateInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceSnapshotWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateInstanceSnapshotResponse CreateInstanceSnapshotWithOptions(string InstanceId, CreateInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotDescription))
            {
                body["InstanceSnapshotDescription"] = request.InstanceSnapshotDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotName))
            {
                body["InstanceSnapshotName"] = request.InstanceSnapshotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotRepoUrl))
            {
                body["InstanceSnapshotRepoUrl"] = request.InstanceSnapshotRepoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotWithOptionsAsync(string InstanceId, CreateInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotDescription))
            {
                body["InstanceSnapshotDescription"] = request.InstanceSnapshotDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotName))
            {
                body["InstanceSnapshotName"] = request.InstanceSnapshotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotRepoUrl))
            {
                body["InstanceSnapshotRepoUrl"] = request.InstanceSnapshotRepoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInstanceSnapshotV2Response CreateInstanceSnapshotV2(string InstanceId, CreateInstanceSnapshotV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceSnapshotV2WithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateInstanceSnapshotV2Response> CreateInstanceSnapshotV2Async(string InstanceId, CreateInstanceSnapshotV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceSnapshotV2WithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateInstanceSnapshotV2Response CreateInstanceSnapshotV2WithOptions(string InstanceId, CreateInstanceSnapshotV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
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
                Action = "CreateInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceSnapshotV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceSnapshotV2Response> CreateInstanceSnapshotV2WithOptionsAsync(string InstanceId, CreateInstanceSnapshotV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
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
                Action = "CreateInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceSnapshotV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInstanceV2Response CreateInstanceV2(CreateInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceV2WithOptions(request, headers, runtime);
        }

        public async Task<CreateInstanceV2Response> CreateInstanceV2Async(CreateInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceV2WithOptionsAsync(request, headers, runtime);
        }

        public CreateInstanceV2Response CreateInstanceV2WithOptions(CreateInstanceV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["EnvironmentVariables"] = request.EnvironmentVariables;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc.ToMap()))
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
                Action = "CreateInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInstanceV2Response> CreateInstanceV2WithOptionsAsync(CreateInstanceV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["EnvironmentVariables"] = request.EnvironmentVariables;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc.ToMap()))
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
                Action = "CreateInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInstanceShutdownTimerResponse DeleteInstanceShutdownTimer(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceShutdownTimerWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DeleteInstanceShutdownTimerResponse> DeleteInstanceShutdownTimerAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceShutdownTimerWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DeleteInstanceShutdownTimerResponse DeleteInstanceShutdownTimerWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceShutdownTimer",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/shutdownTimer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceShutdownTimerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInstanceShutdownTimerResponse> DeleteInstanceShutdownTimerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceShutdownTimer",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/shutdownTimer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceShutdownTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInstanceShutdownTimerV2Response DeleteInstanceShutdownTimerV2(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceShutdownTimerV2WithOptions(InstanceId, headers, runtime);
        }

        public async Task<DeleteInstanceShutdownTimerV2Response> DeleteInstanceShutdownTimerV2Async(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceShutdownTimerV2WithOptionsAsync(InstanceId, headers, runtime);
        }

        public DeleteInstanceShutdownTimerV2Response DeleteInstanceShutdownTimerV2WithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceShutdownTimerV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/shutdowntimer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceShutdownTimerV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInstanceShutdownTimerV2Response> DeleteInstanceShutdownTimerV2WithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceShutdownTimerV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/shutdowntimer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceShutdownTimerV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(string InstanceId, string InstanceSnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceSnapshotWithOptions(InstanceId, InstanceSnapshotId, headers, runtime);
        }

        public async Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotAsync(string InstanceId, string InstanceSnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceSnapshotWithOptionsAsync(InstanceId, InstanceSnapshotId, headers, runtime);
        }

        public DeleteInstanceSnapshotResponse DeleteInstanceSnapshotWithOptions(string InstanceId, string InstanceSnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotWithOptionsAsync(string InstanceId, string InstanceSnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInstanceSnapshotV2Response DeleteInstanceSnapshotV2(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceSnapshotV2WithOptions(InstanceId, SnapshotId, headers, runtime);
        }

        public async Task<DeleteInstanceSnapshotV2Response> DeleteInstanceSnapshotV2Async(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceSnapshotV2WithOptionsAsync(InstanceId, SnapshotId, headers, runtime);
        }

        public DeleteInstanceSnapshotV2Response DeleteInstanceSnapshotV2WithOptions(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            SnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots/" + SnapshotId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceSnapshotV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInstanceSnapshotV2Response> DeleteInstanceSnapshotV2WithOptionsAsync(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            SnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots/" + SnapshotId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceSnapshotV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInstanceV2Response DeleteInstanceV2(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceV2WithOptions(InstanceId, headers, runtime);
        }

        public async Task<DeleteInstanceV2Response> DeleteInstanceV2Async(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceV2WithOptionsAsync(InstanceId, headers, runtime);
        }

        public DeleteInstanceV2Response DeleteInstanceV2WithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInstanceV2Response> DeleteInstanceV2WithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public FoobarResponse Foobar()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FoobarWithOptions(headers, runtime);
        }

        public async Task<FoobarResponse> FoobarAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FoobarWithOptionsAsync(headers, runtime);
        }

        public FoobarResponse FoobarWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Foobar",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/foobar",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FoobarResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FoobarResponse> FoobarWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Foobar",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/foobar",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FoobarResponse>(await CallApiAsync(params_, req, runtime));
        }

        public Foobar1Response Foobar1()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Foobar1WithOptions(headers, runtime);
        }

        public async Task<Foobar1Response> Foobar1Async()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Foobar1WithOptionsAsync(headers, runtime);
        }

        public Foobar1Response Foobar1WithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Foobar1",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/foobar1",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<Foobar1Response>(CallApi(params_, req, runtime));
        }

        public async Task<Foobar1Response> Foobar1WithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Foobar1",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/foobar1",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<Foobar1Response>(await CallApiAsync(params_, req, runtime));
        }

        public GetAuthorizationResponse GetAuthorization()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAuthorizationWithOptions(headers, runtime);
        }

        public async Task<GetAuthorizationResponse> GetAuthorizationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAuthorizationWithOptionsAsync(headers, runtime);
        }

        public GetAuthorizationResponse GetAuthorizationWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorization",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/authorization",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAuthorizationResponse> GetAuthorizationWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorization",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/authorization",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDashboardStatisticsResponse GetDashboardStatistics(GetDashboardStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDashboardStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<GetDashboardStatisticsResponse> GetDashboardStatisticsAsync(GetDashboardStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDashboardStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public GetDashboardStatisticsResponse GetDashboardStatisticsWithOptions(GetDashboardStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetDashboardStatistics",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/dashboard",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDashboardStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDashboardStatisticsResponse> GetDashboardStatisticsWithOptionsAsync(GetDashboardStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetDashboardStatistics",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/dashboard",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDashboardStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceResponse GetInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public GetInstanceResponse GetInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceShutdownTimerResponse GetInstanceShutdownTimer(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceShutdownTimerWithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetInstanceShutdownTimerResponse> GetInstanceShutdownTimerAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceShutdownTimerWithOptionsAsync(InstanceId, headers, runtime);
        }

        public GetInstanceShutdownTimerResponse GetInstanceShutdownTimerWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceShutdownTimer",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/shutdownTimer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceShutdownTimerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceShutdownTimerResponse> GetInstanceShutdownTimerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceShutdownTimer",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/shutdownTimer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceShutdownTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceShutdownTimerV2Response GetInstanceShutdownTimerV2(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceShutdownTimerV2WithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetInstanceShutdownTimerV2Response> GetInstanceShutdownTimerV2Async(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceShutdownTimerV2WithOptionsAsync(InstanceId, headers, runtime);
        }

        public GetInstanceShutdownTimerV2Response GetInstanceShutdownTimerV2WithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceShutdownTimerV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/shutdowntimer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceShutdownTimerV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceShutdownTimerV2Response> GetInstanceShutdownTimerV2WithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceShutdownTimerV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/shutdowntimer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceShutdownTimerV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceSnapshotResponse GetInstanceSnapshot(string InstanceId, string InstanceSnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceSnapshotWithOptions(InstanceId, InstanceSnapshotId, headers, runtime);
        }

        public async Task<GetInstanceSnapshotResponse> GetInstanceSnapshotAsync(string InstanceId, string InstanceSnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceSnapshotWithOptionsAsync(InstanceId, InstanceSnapshotId, headers, runtime);
        }

        public GetInstanceSnapshotResponse GetInstanceSnapshotWithOptions(string InstanceId, string InstanceSnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceSnapshotResponse> GetInstanceSnapshotWithOptionsAsync(string InstanceId, string InstanceSnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceSnapshotV2Response GetInstanceSnapshotV2(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceSnapshotV2WithOptions(InstanceId, SnapshotId, headers, runtime);
        }

        public async Task<GetInstanceSnapshotV2Response> GetInstanceSnapshotV2Async(string InstanceId, string SnapshotId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceSnapshotV2WithOptionsAsync(InstanceId, SnapshotId, headers, runtime);
        }

        public GetInstanceSnapshotV2Response GetInstanceSnapshotV2WithOptions(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            SnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots/" + SnapshotId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSnapshotV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceSnapshotV2Response> GetInstanceSnapshotV2WithOptionsAsync(string InstanceId, string SnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            SnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots/" + SnapshotId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSnapshotV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceV2Response GetInstanceV2(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceV2WithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetInstanceV2Response> GetInstanceV2Async(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceV2WithOptionsAsync(InstanceId, headers, runtime);
        }

        public GetInstanceV2Response GetInstanceV2WithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceV2Response> GetInstanceV2WithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstancesStatisticsResponse GetInstancesStatistics(GetInstancesStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstancesStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<GetInstancesStatisticsResponse> GetInstancesStatisticsAsync(GetInstancesStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstancesStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public GetInstancesStatisticsResponse GetInstancesStatisticsWithOptions(GetInstancesStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetInstancesStatistics",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstancesStatisticsResponse> GetInstancesStatisticsWithOptionsAsync(GetInstancesStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetInstancesStatistics",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserConfigV2Response GetUserConfigV2()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserConfigV2WithOptions(headers, runtime);
        }

        public async Task<GetUserConfigV2Response> GetUserConfigV2Async()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserConfigV2WithOptionsAsync(headers, runtime);
        }

        public GetUserConfigV2Response GetUserConfigV2WithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserConfigV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/userconfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserConfigV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserConfigV2Response> GetUserConfigV2WithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserConfigV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/userconfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserConfigV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ListEcsSpecsResponse ListEcsSpecs(ListEcsSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEcsSpecsWithOptions(request, headers, runtime);
        }

        public async Task<ListEcsSpecsResponse> ListEcsSpecsAsync(ListEcsSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEcsSpecsWithOptionsAsync(request, headers, runtime);
        }

        public ListEcsSpecsResponse ListEcsSpecsWithOptions(ListEcsSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorTypeEquals))
            {
                query["AcceleratorTypeEquals"] = request.AcceleratorTypeEquals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcsSpecs",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/ecsSpecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEcsSpecsResponse> ListEcsSpecsWithOptionsAsync(ListEcsSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorTypeEquals))
            {
                query["AcceleratorTypeEquals"] = request.AcceleratorTypeEquals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEcsSpecs",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/ecsSpecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEcsSpecsV2Response ListEcsSpecsV2(ListEcsSpecsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEcsSpecsV2WithOptions(request, headers, runtime);
        }

        public async Task<ListEcsSpecsV2Response> ListEcsSpecsV2Async(ListEcsSpecsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEcsSpecsV2WithOptionsAsync(request, headers, runtime);
        }

        public ListEcsSpecsV2Response ListEcsSpecsV2WithOptions(ListEcsSpecsV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListEcsSpecsV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/ecsspecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ListEcsSpecsV2Response> ListEcsSpecsV2WithOptionsAsync(ListEcsSpecsV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListEcsSpecsV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/ecsspecs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEcsSpecsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListImagesWithOptions(request, headers, runtime);
        }

        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListImagesWithOptionsAsync(request, headers, runtime);
        }

        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorTypeEquals))
            {
                query["AcceleratorTypeEquals"] = request.AcceleratorTypeEquals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameContains))
            {
                query["ImageNameContains"] = request.ImageNameContains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTypeEquals))
            {
                query["ImageTypeEquals"] = request.ImageTypeEquals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
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
                Action = "ListImages",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorTypeEquals))
            {
                query["AcceleratorTypeEquals"] = request.AcceleratorTypeEquals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameContains))
            {
                query["ImageNameContains"] = request.ImageNameContains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTypeEquals))
            {
                query["ImageTypeEquals"] = request.ImageTypeEquals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
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
                Action = "ListImages",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstanceSnapshotV2Response ListInstanceSnapshotV2(string InstanceId, ListInstanceSnapshotV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceSnapshotV2WithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListInstanceSnapshotV2Response> ListInstanceSnapshotV2Async(string InstanceId, ListInstanceSnapshotV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceSnapshotV2WithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListInstanceSnapshotV2Response ListInstanceSnapshotV2WithOptions(string InstanceId, ListInstanceSnapshotV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
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
                Action = "ListInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSnapshotV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstanceSnapshotV2Response> ListInstanceSnapshotV2WithOptionsAsync(string InstanceId, ListInstanceSnapshotV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
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
                Action = "ListInstanceSnapshotV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSnapshotV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstanceSnapshotsResponse ListInstanceSnapshots(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceSnapshotsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListInstanceSnapshotsResponse> ListInstanceSnapshotsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceSnapshotsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListInstanceSnapshotsResponse ListInstanceSnapshotsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceSnapshots",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstanceSnapshotsResponse> ListInstanceSnapshotsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceSnapshots",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstanceStatisticsV2Response ListInstanceStatisticsV2(ListInstanceStatisticsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceStatisticsV2WithOptions(request, headers, runtime);
        }

        public async Task<ListInstanceStatisticsV2Response> ListInstanceStatisticsV2Async(ListInstanceStatisticsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceStatisticsV2WithOptionsAsync(request, headers, runtime);
        }

        public ListInstanceStatisticsV2Response ListInstanceStatisticsV2WithOptions(ListInstanceStatisticsV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInstanceStatisticsV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instancestatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceStatisticsV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstanceStatisticsV2Response> ListInstanceStatisticsV2WithOptionsAsync(ListInstanceStatisticsV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInstanceStatisticsV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instancestatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceStatisticsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InWorkspace))
            {
                query["InWorkspace"] = request.InWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNameContains))
            {
                query["InstanceNameContains"] = request.InstanceNameContains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatusEquals))
            {
                query["InstanceStatusEquals"] = request.InstanceStatusEquals;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIdEquals))
            {
                query["WorkspaceIdEquals"] = request.WorkspaceIdEquals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InWorkspace))
            {
                query["InWorkspace"] = request.InWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNameContains))
            {
                query["InstanceNameContains"] = request.InstanceNameContains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatusEquals))
            {
                query["InstanceStatusEquals"] = request.InstanceStatusEquals;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIdEquals))
            {
                query["WorkspaceIdEquals"] = request.WorkspaceIdEquals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstancesStatusResponse ListInstancesStatus(ListInstancesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesStatusWithOptions(request, headers, runtime);
        }

        public async Task<ListInstancesStatusResponse> ListInstancesStatusAsync(ListInstancesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesStatusWithOptionsAsync(request, headers, runtime);
        }

        public ListInstancesStatusResponse ListInstancesStatusWithOptions(ListInstancesStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesStatus",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statuses/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstancesStatusResponse> ListInstancesStatusWithOptionsAsync(ListInstancesStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesStatus",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statuses/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstancesV2Response ListInstancesV2(ListInstancesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesV2WithOptions(request, headers, runtime);
        }

        public async Task<ListInstancesV2Response> ListInstancesV2Async(ListInstancesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesV2WithOptionsAsync(request, headers, runtime);
        }

        public ListInstancesV2Response ListInstancesV2WithOptions(ListInstancesV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
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
                Action = "ListInstancesV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstancesV2Response> ListInstancesV2WithOptionsAsync(ListInstancesV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
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
                Action = "ListInstancesV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public StartInstanceResponse StartInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<StartInstanceResponse> StartInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartInstanceV2Response StartInstanceV2(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartInstanceV2WithOptions(InstanceId, headers, runtime);
        }

        public async Task<StartInstanceV2Response> StartInstanceV2Async(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartInstanceV2WithOptionsAsync(InstanceId, headers, runtime);
        }

        public StartInstanceV2Response StartInstanceV2WithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<StartInstanceV2Response> StartInstanceV2WithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public StopInstanceResponse StopInstance(string InstanceId, StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(string InstanceId, StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(string InstanceId, StopInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
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
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(string InstanceId, StopInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
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
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopInstanceV2Response StopInstanceV2(string InstanceId, StopInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopInstanceV2WithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<StopInstanceV2Response> StopInstanceV2Async(string InstanceId, StopInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopInstanceV2WithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public StopInstanceV2Response StopInstanceV2WithOptions(string InstanceId, StopInstanceV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveImage))
            {
                body["SaveImage"] = request.SaveImage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<StopInstanceV2Response> StopInstanceV2WithOptionsAsync(string InstanceId, StopInstanceV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveImage))
            {
                body["SaveImage"] = request.SaveImage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateInstanceResponse UpdateInstance(string InstanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(string InstanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateInstanceResponse UpdateInstanceWithOptions(string InstanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(string InstanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateInstanceSnapshotResponse UpdateInstanceSnapshot(string InstanceId, string InstanceSnapshotId, UpdateInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceSnapshotWithOptions(InstanceId, InstanceSnapshotId, request, headers, runtime);
        }

        public async Task<UpdateInstanceSnapshotResponse> UpdateInstanceSnapshotAsync(string InstanceId, string InstanceSnapshotId, UpdateInstanceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceSnapshotWithOptionsAsync(InstanceId, InstanceSnapshotId, request, headers, runtime);
        }

        public UpdateInstanceSnapshotResponse UpdateInstanceSnapshotWithOptions(string InstanceId, string InstanceSnapshotId, UpdateInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotName))
            {
                body["InstanceSnapshotName"] = request.InstanceSnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateInstanceSnapshotResponse> UpdateInstanceSnapshotWithOptionsAsync(string InstanceId, string InstanceSnapshotId, UpdateInstanceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSnapshotName))
            {
                body["InstanceSnapshotName"] = request.InstanceSnapshotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceSnapshot",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateInstanceV2Response UpdateInstanceV2(string InstanceId, UpdateInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceV2WithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateInstanceV2Response> UpdateInstanceV2Async(string InstanceId, UpdateInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceV2WithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateInstanceV2Response UpdateInstanceV2WithOptions(string InstanceId, UpdateInstanceV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                body["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccumulatedRunningTimeInMs))
            {
                body["AccumulatedRunningTimeInMs"] = request.AccumulatedRunningTimeInMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["EnvironmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateTime))
            {
                body["GmtCreateTime"] = request.GmtCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedTime))
            {
                body["GmtModifiedTime"] = request.GmtModifiedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceShutdownTimer.ToMap()))
            {
                body["InstanceShutdownTimer"] = request.InstanceShutdownTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceUrl))
            {
                body["InstanceUrl"] = request.InstanceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JupyterlabUrl))
            {
                body["JupyterlabUrl"] = request.JupyterlabUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestSnapshot.ToMap()))
            {
                body["LatestSnapshot"] = request.LatestSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonCode))
            {
                body["ReasonCode"] = request.ReasonCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonMessage))
            {
                body["ReasonMessage"] = request.ReasonMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalUrl))
            {
                body["TerminalUrl"] = request.TerminalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc.ToMap()))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebIDEUrl))
            {
                body["WebIDEUrl"] = request.WebIDEUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                body["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateInstanceV2Response> UpdateInstanceV2WithOptionsAsync(string InstanceId, UpdateInstanceV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                body["AcceleratorType"] = request.AcceleratorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccumulatedRunningTimeInMs))
            {
                body["AccumulatedRunningTimeInMs"] = request.AccumulatedRunningTimeInMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Datasets))
            {
                body["Datasets"] = request.Datasets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpec))
            {
                body["EcsSpec"] = request.EcsSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["EnvironmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateTime))
            {
                body["GmtCreateTime"] = request.GmtCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModifiedTime))
            {
                body["GmtModifiedTime"] = request.GmtModifiedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceShutdownTimer.ToMap()))
            {
                body["InstanceShutdownTimer"] = request.InstanceShutdownTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceUrl))
            {
                body["InstanceUrl"] = request.InstanceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JupyterlabUrl))
            {
                body["JupyterlabUrl"] = request.JupyterlabUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestSnapshot.ToMap()))
            {
                body["LatestSnapshot"] = request.LatestSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonCode))
            {
                body["ReasonCode"] = request.ReasonCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonMessage))
            {
                body["ReasonMessage"] = request.ReasonMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalUrl))
            {
                body["TerminalUrl"] = request.TerminalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc.ToMap()))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebIDEUrl))
            {
                body["WebIDEUrl"] = request.WebIDEUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                body["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceV2",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v2/instances/" + InstanceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateV3InstanceByUserResponse UpdateV3InstanceByUser(UpdateV3InstanceByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateV3InstanceByUserWithOptions(request, headers, runtime);
        }

        public async Task<UpdateV3InstanceByUserResponse> UpdateV3InstanceByUserAsync(UpdateV3InstanceByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateV3InstanceByUserWithOptionsAsync(request, headers, runtime);
        }

        public UpdateV3InstanceByUserResponse UpdateV3InstanceByUserWithOptions(UpdateV3InstanceByUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "UpdateV3InstanceByUser",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/migrate/user",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateV3InstanceByUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateV3InstanceByUserResponse> UpdateV3InstanceByUserWithOptionsAsync(UpdateV3InstanceByUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "UpdateV3InstanceByUser",
                Version = "2021-02-26",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/migrate/user",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateV3InstanceByUserResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
