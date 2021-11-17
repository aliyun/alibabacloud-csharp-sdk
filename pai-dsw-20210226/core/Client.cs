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

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateImageWithOptions(request, headers, runtime);
        }

        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateImageWithOptionsAsync(request, headers, runtime);
        }

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repository))
            {
                body["Repository"] = request.Repository;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateImageResponse>(DoROARequest("CreateImage", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/images", "json", req, runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repository))
            {
                body["Repository"] = request.Repository;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateImageResponse>(await DoROARequestAsync("CreateImage", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/images", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceResponse>(DoROARequest("CreateInstance", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/instances/", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceResponse>(await DoROARequestAsync("CreateInstance", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/instances/", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceShutdownTimerResponse>(DoROARequest("CreateInstanceShutdownTimer", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/instances/" + InstanceId + "/shutdownTimer", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceShutdownTimerResponse>(await DoROARequestAsync("CreateInstanceShutdownTimer", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/instances/" + InstanceId + "/shutdownTimer", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceSnapshotResponse>(DoROARequest("CreateInstanceSnapshot", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/instances/" + InstanceId + "/snapshots", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceSnapshotResponse>(await DoROARequestAsync("CreateInstanceSnapshot", "2021-02-26", "HTTPS", "POST", "AK", "/api/v1/instances/" + InstanceId + "/snapshots", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteInstanceResponse>(DoROARequest("DeleteInstance", "2021-02-26", "HTTPS", "DELETE", "AK", "/api/v1/instances/" + InstanceId, "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoROARequestAsync("DeleteInstance", "2021-02-26", "HTTPS", "DELETE", "AK", "/api/v1/instances/" + InstanceId, "json", req, runtime));
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
            return TeaModel.ToObject<DeleteInstanceShutdownTimerResponse>(DoROARequest("DeleteInstanceShutdownTimer", "2021-02-26", "HTTPS", "DELETE", "AK", "/api/v1/instances/" + InstanceId + "/shutdownTimer", "json", req, runtime));
        }

        public async Task<DeleteInstanceShutdownTimerResponse> DeleteInstanceShutdownTimerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteInstanceShutdownTimerResponse>(await DoROARequestAsync("DeleteInstanceShutdownTimer", "2021-02-26", "HTTPS", "DELETE", "AK", "/api/v1/instances/" + InstanceId + "/shutdownTimer", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteInstanceSnapshotResponse>(DoROARequest("DeleteInstanceSnapshot", "2021-02-26", "HTTPS", "DELETE", "AK", "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId, "json", req, runtime));
        }

        public async Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotWithOptionsAsync(string InstanceId, string InstanceSnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteInstanceSnapshotResponse>(await DoROARequestAsync("DeleteInstanceSnapshot", "2021-02-26", "HTTPS", "DELETE", "AK", "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId, "json", req, runtime));
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
            return TeaModel.ToObject<GetAuthorizationResponse>(DoROARequest("GetAuthorization", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/authorization", "json", req, runtime));
        }

        public async Task<GetAuthorizationResponse> GetAuthorizationWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetAuthorizationResponse>(await DoROARequestAsync("GetAuthorization", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/authorization", "json", req, runtime));
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
            return TeaModel.ToObject<GetDashboardStatisticsResponse>(DoROARequest("GetDashboardStatistics", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/statistics/dashboard", "json", req, runtime));
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
            return TeaModel.ToObject<GetDashboardStatisticsResponse>(await DoROARequestAsync("GetDashboardStatistics", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/statistics/dashboard", "json", req, runtime));
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
            return TeaModel.ToObject<GetInstanceResponse>(DoROARequest("GetInstance", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId, "json", req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceResponse>(await DoROARequestAsync("GetInstance", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId, "json", req, runtime));
        }

        public GetInstanceImageResponse GetInstanceImage(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceImageWithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetInstanceImageResponse> GetInstanceImageAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceImageWithOptionsAsync(InstanceId, headers, runtime);
        }

        public GetInstanceImageResponse GetInstanceImageWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceImageResponse>(DoROARequest("GetInstanceImage", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/image", "json", req, runtime));
        }

        public async Task<GetInstanceImageResponse> GetInstanceImageWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceImageResponse>(await DoROARequestAsync("GetInstanceImage", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/image", "json", req, runtime));
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
            return TeaModel.ToObject<GetInstanceShutdownTimerResponse>(DoROARequest("GetInstanceShutdownTimer", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/shutdownTimer", "json", req, runtime));
        }

        public async Task<GetInstanceShutdownTimerResponse> GetInstanceShutdownTimerWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceShutdownTimerResponse>(await DoROARequestAsync("GetInstanceShutdownTimer", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/shutdownTimer", "json", req, runtime));
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
            return TeaModel.ToObject<GetInstanceSnapshotResponse>(DoROARequest("GetInstanceSnapshot", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId, "json", req, runtime));
        }

        public async Task<GetInstanceSnapshotResponse> GetInstanceSnapshotWithOptionsAsync(string InstanceId, string InstanceSnapshotId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            InstanceSnapshotId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceSnapshotId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceSnapshotResponse>(await DoROARequestAsync("GetInstanceSnapshot", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId, "json", req, runtime));
        }

        public GetInstanceTypeResponse GetInstanceType(string InstanceTypeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceTypeWithOptions(InstanceTypeId, headers, runtime);
        }

        public async Task<GetInstanceTypeResponse> GetInstanceTypeAsync(string InstanceTypeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceTypeWithOptionsAsync(InstanceTypeId, headers, runtime);
        }

        public GetInstanceTypeResponse GetInstanceTypeWithOptions(string InstanceTypeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceTypeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceTypeId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceTypeResponse>(DoROARequest("GetInstanceType", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instanceTypes/" + InstanceTypeId, "json", req, runtime));
        }

        public async Task<GetInstanceTypeResponse> GetInstanceTypeWithOptionsAsync(string InstanceTypeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceTypeId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceTypeId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceTypeResponse>(await DoROARequestAsync("GetInstanceType", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instanceTypes/" + InstanceTypeId, "json", req, runtime));
        }

        public GetInstanceUrlResponse GetInstanceUrl(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceUrlWithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetInstanceUrlResponse> GetInstanceUrlAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceUrlWithOptionsAsync(InstanceId, headers, runtime);
        }

        public GetInstanceUrlResponse GetInstanceUrlWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceUrlResponse>(DoROARequest("GetInstanceUrl", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/url", "json", req, runtime));
        }

        public async Task<GetInstanceUrlResponse> GetInstanceUrlWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetInstanceUrlResponse>(await DoROARequestAsync("GetInstanceUrl", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/url", "json", req, runtime));
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
            return TeaModel.ToObject<GetInstancesStatisticsResponse>(DoROARequest("GetInstancesStatistics", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/statistics/instances", "json", req, runtime));
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
            return TeaModel.ToObject<GetInstancesStatisticsResponse>(await DoROARequestAsync("GetInstancesStatistics", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/statistics/instances", "json", req, runtime));
        }

        public GetUserConfigResponse GetUserConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserConfigWithOptions(headers, runtime);
        }

        public async Task<GetUserConfigResponse> GetUserConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserConfigWithOptionsAsync(headers, runtime);
        }

        public GetUserConfigResponse GetUserConfigWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUserConfigResponse>(DoROARequest("GetUserConfig", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/config", "json", req, runtime));
        }

        public async Task<GetUserConfigResponse> GetUserConfigWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUserConfigResponse>(await DoROARequestAsync("GetUserConfig", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/config", "json", req, runtime));
        }

        public GetUserResourceAuthorizationStatusResponse GetUserResourceAuthorizationStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserResourceAuthorizationStatusWithOptions(headers, runtime);
        }

        public async Task<GetUserResourceAuthorizationStatusResponse> GetUserResourceAuthorizationStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserResourceAuthorizationStatusWithOptionsAsync(headers, runtime);
        }

        public GetUserResourceAuthorizationStatusResponse GetUserResourceAuthorizationStatusWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUserResourceAuthorizationStatusResponse>(DoROARequest("GetUserResourceAuthorizationStatus", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/resourceAuthorizationStatus", "json", req, runtime));
        }

        public async Task<GetUserResourceAuthorizationStatusResponse> GetUserResourceAuthorizationStatusWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUserResourceAuthorizationStatusResponse>(await DoROARequestAsync("GetUserResourceAuthorizationStatus", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/resourceAuthorizationStatus", "json", req, runtime));
        }

        public GetUserResourceStatusResponse GetUserResourceStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserResourceStatusWithOptions(headers, runtime);
        }

        public async Task<GetUserResourceStatusResponse> GetUserResourceStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserResourceStatusWithOptionsAsync(headers, runtime);
        }

        public GetUserResourceStatusResponse GetUserResourceStatusWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUserResourceStatusResponse>(DoROARequest("GetUserResourceStatus", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/resourceStatus", "json", req, runtime));
        }

        public async Task<GetUserResourceStatusResponse> GetUserResourceStatusWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUserResourceStatusResponse>(await DoROARequestAsync("GetUserResourceStatus", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/resourceStatus", "json", req, runtime));
        }

        public GetUserSpecialVersionGpuResourceInfoResponse GetUserSpecialVersionGpuResourceInfo(GetUserSpecialVersionGpuResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserSpecialVersionGpuResourceInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetUserSpecialVersionGpuResourceInfoResponse> GetUserSpecialVersionGpuResourceInfoAsync(GetUserSpecialVersionGpuResourceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserSpecialVersionGpuResourceInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetUserSpecialVersionGpuResourceInfoResponse GetUserSpecialVersionGpuResourceInfoWithOptions(GetUserSpecialVersionGpuResourceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetUserSpecialVersionGpuResourceInfoResponse>(DoROARequest("GetUserSpecialVersionGpuResourceInfo", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/specialVersionGpuResourceInfo", "json", req, runtime));
        }

        public async Task<GetUserSpecialVersionGpuResourceInfoResponse> GetUserSpecialVersionGpuResourceInfoWithOptionsAsync(GetUserSpecialVersionGpuResourceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetUserSpecialVersionGpuResourceInfoResponse>(await DoROARequestAsync("GetUserSpecialVersionGpuResourceInfo", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/specialVersionGpuResourceInfo", "json", req, runtime));
        }

        public ListConfigsResponse ListConfigs()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigsWithOptions(headers, runtime);
        }

        public async Task<ListConfigsResponse> ListConfigsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigsWithOptionsAsync(headers, runtime);
        }

        public ListConfigsResponse ListConfigsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListConfigsResponse>(DoROARequest("ListConfigs", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/configs", "json", req, runtime));
        }

        public async Task<ListConfigsResponse> ListConfigsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListConfigsResponse>(await DoROARequestAsync("ListConfigs", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/configs", "json", req, runtime));
        }

        public ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetsWithOptions(request, headers, runtime);
        }

        public async Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetsWithOptionsAsync(request, headers, runtime);
        }

        public ListDatasetsResponse ListDatasetsWithOptions(ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListDatasetsResponse>(DoROARequest("ListDatasets", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/datasets", "json", req, runtime));
        }

        public async Task<ListDatasetsResponse> ListDatasetsWithOptionsAsync(ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListDatasetsResponse>(await DoROARequestAsync("ListDatasets", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/datasets", "json", req, runtime));
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
            return TeaModel.ToObject<ListEcsSpecsResponse>(DoROARequest("ListEcsSpecs", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/ecsSpecs", "json", req, runtime));
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
            return TeaModel.ToObject<ListEcsSpecsResponse>(await DoROARequestAsync("ListEcsSpecs", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/ecsSpecs", "json", req, runtime));
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
            return TeaModel.ToObject<ListImagesResponse>(DoROARequest("ListImages", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/images", "json", req, runtime));
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
            return TeaModel.ToObject<ListImagesResponse>(await DoROARequestAsync("ListImages", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/images", "json", req, runtime));
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
            return TeaModel.ToObject<ListInstanceSnapshotsResponse>(DoROARequest("ListInstanceSnapshots", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/snapshots", "json", req, runtime));
        }

        public async Task<ListInstanceSnapshotsResponse> ListInstanceSnapshotsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListInstanceSnapshotsResponse>(await DoROARequestAsync("ListInstanceSnapshots", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances/" + InstanceId + "/snapshots", "json", req, runtime));
        }

        public ListInstanceTypesResponse ListInstanceTypes(ListInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceTypesWithOptions(request, headers, runtime);
        }

        public async Task<ListInstanceTypesResponse> ListInstanceTypesAsync(ListInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceTypesWithOptionsAsync(request, headers, runtime);
        }

        public ListInstanceTypesResponse ListInstanceTypesWithOptions(ListInstanceTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceTypesResponse>(DoROARequest("ListInstanceTypes", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instanceTypes", "json", req, runtime));
        }

        public async Task<ListInstanceTypesResponse> ListInstanceTypesWithOptionsAsync(ListInstanceTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceleratorType))
            {
                query["AcceleratorType"] = request.AcceleratorType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceTypesResponse>(await DoROARequestAsync("ListInstanceTypes", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instanceTypes", "json", req, runtime));
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
            return TeaModel.ToObject<ListInstancesResponse>(DoROARequest("ListInstances", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances", "json", req, runtime));
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
            return TeaModel.ToObject<ListInstancesResponse>(await DoROARequestAsync("ListInstances", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/instances", "json", req, runtime));
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
            return TeaModel.ToObject<ListInstancesStatusResponse>(DoROARequest("ListInstancesStatus", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/statuses/instances", "json", req, runtime));
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
            return TeaModel.ToObject<ListInstancesStatusResponse>(await DoROARequestAsync("ListInstancesStatus", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/statuses/instances", "json", req, runtime));
        }

        public ListNamespacesResponse ListNamespaces()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNamespacesWithOptions(headers, runtime);
        }

        public async Task<ListNamespacesResponse> ListNamespacesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNamespacesWithOptionsAsync(headers, runtime);
        }

        public ListNamespacesResponse ListNamespacesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNamespacesResponse>(DoROARequest("ListNamespaces", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/imageRegistry/namespaces", "json", req, runtime));
        }

        public async Task<ListNamespacesResponse> ListNamespacesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNamespacesResponse>(await DoROARequestAsync("ListNamespaces", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/imageRegistry/namespaces", "json", req, runtime));
        }

        public ListNasesResponse ListNases()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNasesWithOptions(headers, runtime);
        }

        public async Task<ListNasesResponse> ListNasesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNasesWithOptionsAsync(headers, runtime);
        }

        public ListNasesResponse ListNasesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNasesResponse>(DoROARequest("ListNases", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/nases", "json", req, runtime));
        }

        public async Task<ListNasesResponse> ListNasesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNasesResponse>(await DoROARequestAsync("ListNases", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/nases", "json", req, runtime));
        }

        public ListNetworkSecurityGroupsResponse ListNetworkSecurityGroups(string VpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNetworkSecurityGroupsWithOptions(VpcId, headers, runtime);
        }

        public async Task<ListNetworkSecurityGroupsResponse> ListNetworkSecurityGroupsAsync(string VpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNetworkSecurityGroupsWithOptionsAsync(VpcId, headers, runtime);
        }

        public ListNetworkSecurityGroupsResponse ListNetworkSecurityGroupsWithOptions(string VpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            VpcId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VpcId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNetworkSecurityGroupsResponse>(DoROARequest("ListNetworkSecurityGroups", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/network/vpcs/" + VpcId + "/securityGroups", "json", req, runtime));
        }

        public async Task<ListNetworkSecurityGroupsResponse> ListNetworkSecurityGroupsWithOptionsAsync(string VpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            VpcId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VpcId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNetworkSecurityGroupsResponse>(await DoROARequestAsync("ListNetworkSecurityGroups", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/network/vpcs/" + VpcId + "/securityGroups", "json", req, runtime));
        }

        public ListNetworkVSwitchesResponse ListNetworkVSwitches(string VpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNetworkVSwitchesWithOptions(VpcId, headers, runtime);
        }

        public async Task<ListNetworkVSwitchesResponse> ListNetworkVSwitchesAsync(string VpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNetworkVSwitchesWithOptionsAsync(VpcId, headers, runtime);
        }

        public ListNetworkVSwitchesResponse ListNetworkVSwitchesWithOptions(string VpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            VpcId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VpcId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNetworkVSwitchesResponse>(DoROARequest("ListNetworkVSwitches", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/network/vpcs/" + VpcId + "/vSwitches", "json", req, runtime));
        }

        public async Task<ListNetworkVSwitchesResponse> ListNetworkVSwitchesWithOptionsAsync(string VpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            VpcId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VpcId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNetworkVSwitchesResponse>(await DoROARequestAsync("ListNetworkVSwitches", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/network/vpcs/" + VpcId + "/vSwitches", "json", req, runtime));
        }

        public ListNetworkVpcsResponse ListNetworkVpcs()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNetworkVpcsWithOptions(headers, runtime);
        }

        public async Task<ListNetworkVpcsResponse> ListNetworkVpcsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNetworkVpcsWithOptionsAsync(headers, runtime);
        }

        public ListNetworkVpcsResponse ListNetworkVpcsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNetworkVpcsResponse>(DoROARequest("ListNetworkVpcs", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/network/vpcs", "json", req, runtime));
        }

        public async Task<ListNetworkVpcsResponse> ListNetworkVpcsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListNetworkVpcsResponse>(await DoROARequestAsync("ListNetworkVpcs", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/network/vpcs", "json", req, runtime));
        }

        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRegionsWithOptions(headers, runtime);
        }

        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRegionsWithOptionsAsync(headers, runtime);
        }

        public ListRegionsResponse ListRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListRegionsResponse>(DoROARequest("ListRegions", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/configs/regions", "json", req, runtime));
        }

        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListRegionsResponse>(await DoROARequestAsync("ListRegions", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/configs/regions", "json", req, runtime));
        }

        public ListRepositoriesResponse ListRepositories(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoriesWithOptions(Namespace, headers, runtime);
        }

        public async Task<ListRepositoriesResponse> ListRepositoriesAsync(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoriesWithOptionsAsync(Namespace, headers, runtime);
        }

        public ListRepositoriesResponse ListRepositoriesWithOptions(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(DoROARequest("ListRepositories", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/imageRegistry/namespaces/" + Namespace + "/repositories", "json", req, runtime));
        }

        public async Task<ListRepositoriesResponse> ListRepositoriesWithOptionsAsync(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(await DoROARequestAsync("ListRepositories", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/imageRegistry/namespaces/" + Namespace + "/repositories", "json", req, runtime));
        }

        public ListUserClustersResponse ListUserClusters()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserClustersWithOptions(headers, runtime);
        }

        public async Task<ListUserClustersResponse> ListUserClustersAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserClustersWithOptionsAsync(headers, runtime);
        }

        public ListUserClustersResponse ListUserClustersWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListUserClustersResponse>(DoROARequest("ListUserClusters", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/clusters", "json", req, runtime));
        }

        public async Task<ListUserClustersResponse> ListUserClustersWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListUserClustersResponse>(await DoROARequestAsync("ListUserClusters", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/clusters", "json", req, runtime));
        }

        public ListUserWorkNodesResponse ListUserWorkNodes(ListUserWorkNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserWorkNodesWithOptions(request, headers, runtime);
        }

        public async Task<ListUserWorkNodesResponse> ListUserWorkNodesAsync(ListUserWorkNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserWorkNodesWithOptionsAsync(request, headers, runtime);
        }

        public ListUserWorkNodesResponse ListUserWorkNodesWithOptions(ListUserWorkNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListUserWorkNodesResponse>(DoROARequest("ListUserWorkNodes", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/workerNodes", "json", req, runtime));
        }

        public async Task<ListUserWorkNodesResponse> ListUserWorkNodesWithOptionsAsync(ListUserWorkNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListUserWorkNodesResponse>(await DoROARequestAsync("ListUserWorkNodes", "2021-02-26", "HTTPS", "GET", "AK", "/api/v1/users/workerNodes", "json", req, runtime));
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
            return TeaModel.ToObject<StartInstanceResponse>(DoROARequest("StartInstance", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId + "/start", "json", req, runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<StartInstanceResponse>(await DoROARequestAsync("StartInstance", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId + "/start", "json", req, runtime));
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
            return TeaModel.ToObject<StopInstanceResponse>(DoROARequest("StopInstance", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId + "/stop", "json", req, runtime));
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
            return TeaModel.ToObject<StopInstanceResponse>(await DoROARequestAsync("StopInstance", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId + "/stop", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateInstanceResponse>(DoROARequest("UpdateInstance", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId, "json", req, runtime));
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
            return TeaModel.ToObject<UpdateInstanceResponse>(await DoROARequestAsync("UpdateInstance", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId, "json", req, runtime));
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
            return TeaModel.ToObject<UpdateInstanceSnapshotResponse>(DoROARequest("UpdateInstanceSnapshot", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId, "json", req, runtime));
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
            return TeaModel.ToObject<UpdateInstanceSnapshotResponse>(await DoROARequestAsync("UpdateInstanceSnapshot", "2021-02-26", "HTTPS", "PUT", "AK", "/api/v1/instances/" + InstanceId + "/snapshots/" + InstanceSnapshotId, "json", req, runtime));
        }

    }
}
