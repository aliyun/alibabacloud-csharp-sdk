// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Emr_serverless_spark20230808.Models;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("emr-serverless-spark", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a RAM user or RAM role to a workspace as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMembersResponse
        /// </returns>
        public AddMembersResponse AddMembersWithOptions(AddMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberArns))
            {
                body["memberArns"] = request.MemberArns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMembers",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/auth/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a RAM user or RAM role to a workspace as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMembersResponse
        /// </returns>
        public async Task<AddMembersResponse> AddMembersWithOptionsAsync(AddMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberArns))
            {
                body["memberArns"] = request.MemberArns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMembers",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/auth/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a RAM user or RAM role to a workspace as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMembersResponse
        /// </returns>
        public AddMembersResponse AddMembers(AddMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddMembersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a RAM user or RAM role to a workspace as a member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMembersResponse
        /// </returns>
        public async Task<AddMembersResponse> AddMembersAsync(AddMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddMembersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelJobRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelJobRunResponse
        /// </returns>
        public CancelJobRunResponse CancelJobRunWithOptions(string workspaceId, string jobRunId, CancelJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelJobRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelJobRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelJobRunResponse
        /// </returns>
        public async Task<CancelJobRunResponse> CancelJobRunWithOptionsAsync(string workspaceId, string jobRunId, CancelJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelJobRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelJobRunResponse
        /// </returns>
        public CancelJobRunResponse CancelJobRun(string workspaceId, string jobRunId, CancelJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelJobRunWithOptions(workspaceId, jobRunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelJobRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelJobRunResponse
        /// </returns>
        public async Task<CancelJobRunResponse> CancelJobRunAsync(string workspaceId, string jobRunId, CancelJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelJobRunWithOptionsAsync(workspaceId, jobRunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CancelKyuubiSparkApplication</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelKyuubiSparkApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelKyuubiSparkApplicationResponse
        /// </returns>
        public CancelKyuubiSparkApplicationResponse CancelKyuubiSparkApplicationWithOptions(string workspaceId, string kyuubiServiceId, string applicationId, CancelKyuubiSparkApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelKyuubiSparkApplication",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/application/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelKyuubiSparkApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CancelKyuubiSparkApplication</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelKyuubiSparkApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelKyuubiSparkApplicationResponse
        /// </returns>
        public async Task<CancelKyuubiSparkApplicationResponse> CancelKyuubiSparkApplicationWithOptionsAsync(string workspaceId, string kyuubiServiceId, string applicationId, CancelKyuubiSparkApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelKyuubiSparkApplication",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/application/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelKyuubiSparkApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CancelKyuubiSparkApplication</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelKyuubiSparkApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelKyuubiSparkApplicationResponse
        /// </returns>
        public CancelKyuubiSparkApplicationResponse CancelKyuubiSparkApplication(string workspaceId, string kyuubiServiceId, string applicationId, CancelKyuubiSparkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelKyuubiSparkApplicationWithOptions(workspaceId, kyuubiServiceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CancelKyuubiSparkApplication</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelKyuubiSparkApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelKyuubiSparkApplicationResponse
        /// </returns>
        public async Task<CancelKyuubiSparkApplicationResponse> CancelKyuubiSparkApplicationAsync(string workspaceId, string kyuubiServiceId, string applicationId, CancelKyuubiSparkApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelKyuubiSparkApplicationWithOptionsAsync(workspaceId, kyuubiServiceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiServiceResponse
        /// </returns>
        public CreateKyuubiServiceResponse CreateKyuubiServiceWithOptions(string workspaceId, CreateKyuubiServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeInstance))
            {
                body["computeInstance"] = request.ComputeInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiConfigs))
            {
                body["kyuubiConfigs"] = request.KyuubiConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiReleaseVersion))
            {
                body["kyuubiReleaseVersion"] = request.KyuubiReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                body["publicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queue))
            {
                body["queue"] = request.Queue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replica))
            {
                body["replica"] = request.Replica;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparkConfigs))
            {
                body["sparkConfigs"] = request.SparkConfigs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKyuubiServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiServiceResponse
        /// </returns>
        public async Task<CreateKyuubiServiceResponse> CreateKyuubiServiceWithOptionsAsync(string workspaceId, CreateKyuubiServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeInstance))
            {
                body["computeInstance"] = request.ComputeInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiConfigs))
            {
                body["kyuubiConfigs"] = request.KyuubiConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiReleaseVersion))
            {
                body["kyuubiReleaseVersion"] = request.KyuubiReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                body["publicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queue))
            {
                body["queue"] = request.Queue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replica))
            {
                body["replica"] = request.Replica;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparkConfigs))
            {
                body["sparkConfigs"] = request.SparkConfigs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKyuubiServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiServiceResponse
        /// </returns>
        public CreateKyuubiServiceResponse CreateKyuubiService(string workspaceId, CreateKyuubiServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKyuubiServiceWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiServiceResponse
        /// </returns>
        public async Task<CreateKyuubiServiceResponse> CreateKyuubiServiceAsync(string workspaceId, CreateKyuubiServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKyuubiServiceWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiTokenResponse
        /// </returns>
        public CreateKyuubiTokenResponse CreateKyuubiTokenWithOptions(string workspaceId, string kyuubiServiceId, CreateKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberArns))
            {
                body["memberArns"] = request.MemberArns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKyuubiTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiTokenResponse
        /// </returns>
        public async Task<CreateKyuubiTokenResponse> CreateKyuubiTokenWithOptionsAsync(string workspaceId, string kyuubiServiceId, CreateKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberArns))
            {
                body["memberArns"] = request.MemberArns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKyuubiTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiTokenResponse
        /// </returns>
        public CreateKyuubiTokenResponse CreateKyuubiToken(string workspaceId, string kyuubiServiceId, CreateKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKyuubiTokenWithOptions(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKyuubiTokenResponse
        /// </returns>
        public async Task<CreateKyuubiTokenResponse> CreateKyuubiTokenAsync(string workspaceId, string kyuubiServiceId, CreateKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKyuubiTokenWithOptionsAsync(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeResponse
        /// </returns>
        public CreateLivyComputeResponse CreateLivyComputeWithOptions(string workspaceBizId, CreateLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                body["authType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartConfiguration))
            {
                body["autoStartConfiguration"] = request.AutoStartConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopConfiguration))
            {
                body["autoStopConfiguration"] = request.AutoStopConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                body["cpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublic))
            {
                body["enablePublic"] = request.EnablePublic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyServerConf))
            {
                body["livyServerConf"] = request.LivyServerConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyVersion))
            {
                body["livyVersion"] = request.LivyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                body["memoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkName))
            {
                body["networkName"] = request.NetworkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLivyComputeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeResponse
        /// </returns>
        public async Task<CreateLivyComputeResponse> CreateLivyComputeWithOptionsAsync(string workspaceBizId, CreateLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                body["authType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartConfiguration))
            {
                body["autoStartConfiguration"] = request.AutoStartConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopConfiguration))
            {
                body["autoStopConfiguration"] = request.AutoStopConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                body["cpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublic))
            {
                body["enablePublic"] = request.EnablePublic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyServerConf))
            {
                body["livyServerConf"] = request.LivyServerConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyVersion))
            {
                body["livyVersion"] = request.LivyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                body["memoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkName))
            {
                body["networkName"] = request.NetworkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLivyComputeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeResponse
        /// </returns>
        public CreateLivyComputeResponse CreateLivyCompute(string workspaceBizId, CreateLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLivyComputeWithOptions(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeResponse
        /// </returns>
        public async Task<CreateLivyComputeResponse> CreateLivyComputeAsync(string workspaceBizId, CreateLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLivyComputeWithOptionsAsync(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeTokenResponse
        /// </returns>
        public CreateLivyComputeTokenResponse CreateLivyComputeTokenWithOptions(string workspaceBizId, string livyComputeId, CreateLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLivyComputeTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeTokenResponse
        /// </returns>
        public async Task<CreateLivyComputeTokenResponse> CreateLivyComputeTokenWithOptionsAsync(string workspaceBizId, string livyComputeId, CreateLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLivyComputeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeTokenResponse
        /// </returns>
        public CreateLivyComputeTokenResponse CreateLivyComputeToken(string workspaceBizId, string livyComputeId, CreateLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLivyComputeTokenWithOptions(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLivyComputeTokenResponse
        /// </returns>
        public async Task<CreateLivyComputeTokenResponse> CreateLivyComputeTokenAsync(string workspaceBizId, string livyComputeId, CreateLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLivyComputeTokenWithOptionsAsync(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateProcessDefinitionWithScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessDefinitionWithScheduleResponse
        /// </returns>
        public CreateProcessDefinitionWithScheduleResponse CreateProcessDefinitionWithScheduleWithOptions(string bizId, CreateProcessDefinitionWithScheduleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProcessDefinitionWithScheduleShrinkRequest request = new CreateProcessDefinitionWithScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalParams))
            {
                request.GlobalParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalParams, "globalParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDefinitionJson))
            {
                request.TaskDefinitionJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDefinitionJson, "taskDefinitionJson", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskRelationJson))
            {
                request.TaskRelationJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskRelationJson, "taskRelationJson", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertEmailAddress))
            {
                query["alertEmailAddress"] = request.AlertEmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParamsShrink))
            {
                query["globalParams"] = request.GlobalParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Publish))
            {
                query["publish"] = request.Publish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueue))
            {
                query["resourceQueue"] = request.ResourceQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryTimes))
            {
                query["retryTimes"] = request.RetryTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunAs))
            {
                query["runAs"] = request.RunAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonShrink))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParallelism))
            {
                query["taskParallelism"] = request.TaskParallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonShrink))
            {
                query["taskRelationJson"] = request.TaskRelationJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProcessDefinitionWithSchedule",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/process-definition",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProcessDefinitionWithScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateProcessDefinitionWithScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessDefinitionWithScheduleResponse
        /// </returns>
        public async Task<CreateProcessDefinitionWithScheduleResponse> CreateProcessDefinitionWithScheduleWithOptionsAsync(string bizId, CreateProcessDefinitionWithScheduleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProcessDefinitionWithScheduleShrinkRequest request = new CreateProcessDefinitionWithScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalParams))
            {
                request.GlobalParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalParams, "globalParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDefinitionJson))
            {
                request.TaskDefinitionJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDefinitionJson, "taskDefinitionJson", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskRelationJson))
            {
                request.TaskRelationJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskRelationJson, "taskRelationJson", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertEmailAddress))
            {
                query["alertEmailAddress"] = request.AlertEmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParamsShrink))
            {
                query["globalParams"] = request.GlobalParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Publish))
            {
                query["publish"] = request.Publish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueue))
            {
                query["resourceQueue"] = request.ResourceQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryTimes))
            {
                query["retryTimes"] = request.RetryTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunAs))
            {
                query["runAs"] = request.RunAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonShrink))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParallelism))
            {
                query["taskParallelism"] = request.TaskParallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonShrink))
            {
                query["taskRelationJson"] = request.TaskRelationJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProcessDefinitionWithSchedule",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/process-definition",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProcessDefinitionWithScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessDefinitionWithScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessDefinitionWithScheduleResponse
        /// </returns>
        public CreateProcessDefinitionWithScheduleResponse CreateProcessDefinitionWithSchedule(string bizId, CreateProcessDefinitionWithScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProcessDefinitionWithScheduleWithOptions(bizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessDefinitionWithScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessDefinitionWithScheduleResponse
        /// </returns>
        public async Task<CreateProcessDefinitionWithScheduleResponse> CreateProcessDefinitionWithScheduleAsync(string bizId, CreateProcessDefinitionWithScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProcessDefinitionWithScheduleWithOptionsAsync(bizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public CreateSessionClusterResponse CreateSessionClusterWithOptions(string workspaceId, CreateSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                body["applicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartConfiguration))
            {
                body["autoStartConfiguration"] = request.AutoStartConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopConfiguration))
            {
                body["autoStopConfiguration"] = request.AutoStopConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                body["publicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public async Task<CreateSessionClusterResponse> CreateSessionClusterWithOptionsAsync(string workspaceId, CreateSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                body["applicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartConfiguration))
            {
                body["autoStartConfiguration"] = request.AutoStartConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopConfiguration))
            {
                body["autoStopConfiguration"] = request.AutoStopConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                body["publicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public CreateSessionClusterResponse CreateSessionCluster(string workspaceId, CreateSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSessionClusterWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public async Task<CreateSessionClusterResponse> CreateSessionClusterAsync(string workspaceId, CreateSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSessionClusterWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlStatementResponse
        /// </returns>
        public CreateSqlStatementResponse CreateSqlStatementWithOptions(string workspaceId, CreateSqlStatementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeContent))
            {
                body["codeContent"] = request.CodeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCatalog))
            {
                body["defaultCatalog"] = request.DefaultCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDatabase))
            {
                body["defaultDatabase"] = request.DefaultDatabase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlComputeId))
            {
                body["sqlComputeId"] = request.SqlComputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizId))
            {
                body["taskBizId"] = request.TaskBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlStatement",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/statement",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlStatementResponse
        /// </returns>
        public async Task<CreateSqlStatementResponse> CreateSqlStatementWithOptionsAsync(string workspaceId, CreateSqlStatementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeContent))
            {
                body["codeContent"] = request.CodeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCatalog))
            {
                body["defaultCatalog"] = request.DefaultCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDatabase))
            {
                body["defaultDatabase"] = request.DefaultDatabase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlComputeId))
            {
                body["sqlComputeId"] = request.SqlComputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBizId))
            {
                body["taskBizId"] = request.TaskBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlStatement",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/statement",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlStatementResponse
        /// </returns>
        public CreateSqlStatementResponse CreateSqlStatement(string workspaceId, CreateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSqlStatementWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlStatementResponse
        /// </returns>
        public async Task<CreateSqlStatementResponse> CreateSqlStatementAsync(string workspaceId, CreateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSqlStatementWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["autoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriodUnit))
            {
                body["autoRenewPeriodUnit"] = request.AutoRenewPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartSessionCluster))
            {
                body["autoStartSessionCluster"] = request.AutoStartSessionCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfCatalogId))
            {
                body["dlfCatalogId"] = request.DlfCatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfType))
            {
                body["dlfType"] = request.DlfType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                body["ossBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                body["paymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                body["ramRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                body["releaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpec))
            {
                body["resourceSpec"] = request.ResourceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                body["workspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["autoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriodUnit))
            {
                body["autoRenewPeriodUnit"] = request.AutoRenewPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartSessionCluster))
            {
                body["autoStartSessionCluster"] = request.AutoStartSessionCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfCatalogId))
            {
                body["dlfCatalogId"] = request.DlfCatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlfType))
            {
                body["dlfType"] = request.DlfType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                body["ossBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                body["paymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                body["ramRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                body["releaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpec))
            {
                body["resourceSpec"] = request.ResourceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                body["workspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKyuubiServiceResponse
        /// </returns>
        public DeleteKyuubiServiceResponse DeleteKyuubiServiceWithOptions(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKyuubiServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKyuubiServiceResponse
        /// </returns>
        public async Task<DeleteKyuubiServiceResponse> DeleteKyuubiServiceWithOptionsAsync(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKyuubiServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteKyuubiServiceResponse
        /// </returns>
        public DeleteKyuubiServiceResponse DeleteKyuubiService(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKyuubiServiceWithOptions(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteKyuubiServiceResponse
        /// </returns>
        public async Task<DeleteKyuubiServiceResponse> DeleteKyuubiServiceAsync(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKyuubiServiceWithOptionsAsync(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKyuubiTokenResponse
        /// </returns>
        public DeleteKyuubiTokenResponse DeleteKyuubiTokenWithOptions(string workspaceId, string kyuubiServiceId, string tokenId, DeleteKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKyuubiTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKyuubiTokenResponse
        /// </returns>
        public async Task<DeleteKyuubiTokenResponse> DeleteKyuubiTokenWithOptionsAsync(string workspaceId, string kyuubiServiceId, string tokenId, DeleteKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKyuubiTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKyuubiTokenResponse
        /// </returns>
        public DeleteKyuubiTokenResponse DeleteKyuubiToken(string workspaceId, string kyuubiServiceId, string tokenId, DeleteKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKyuubiTokenWithOptions(workspaceId, kyuubiServiceId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKyuubiTokenResponse
        /// </returns>
        public async Task<DeleteKyuubiTokenResponse> DeleteKyuubiTokenAsync(string workspaceId, string kyuubiServiceId, string tokenId, DeleteKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKyuubiTokenWithOptionsAsync(workspaceId, kyuubiServiceId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeResponse
        /// </returns>
        public DeleteLivyComputeResponse DeleteLivyComputeWithOptions(string workspaceBizId, string livyComputeId, DeleteLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLivyComputeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeResponse
        /// </returns>
        public async Task<DeleteLivyComputeResponse> DeleteLivyComputeWithOptionsAsync(string workspaceBizId, string livyComputeId, DeleteLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLivyComputeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeResponse
        /// </returns>
        public DeleteLivyComputeResponse DeleteLivyCompute(string workspaceBizId, string livyComputeId, DeleteLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLivyComputeWithOptions(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeResponse
        /// </returns>
        public async Task<DeleteLivyComputeResponse> DeleteLivyComputeAsync(string workspaceBizId, string livyComputeId, DeleteLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLivyComputeWithOptionsAsync(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeTokenResponse
        /// </returns>
        public DeleteLivyComputeTokenResponse DeleteLivyComputeTokenWithOptions(string workspaceBizId, string livyComputeId, string tokenId, DeleteLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLivyComputeTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeTokenResponse
        /// </returns>
        public async Task<DeleteLivyComputeTokenResponse> DeleteLivyComputeTokenWithOptionsAsync(string workspaceBizId, string livyComputeId, string tokenId, DeleteLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLivyComputeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeTokenResponse
        /// </returns>
        public DeleteLivyComputeTokenResponse DeleteLivyComputeToken(string workspaceBizId, string livyComputeId, string tokenId, DeleteLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLivyComputeTokenWithOptions(workspaceBizId, livyComputeId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLivyComputeTokenResponse
        /// </returns>
        public async Task<DeleteLivyComputeTokenResponse> DeleteLivyComputeTokenAsync(string workspaceBizId, string livyComputeId, string tokenId, DeleteLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLivyComputeTokenWithOptionsAsync(workspaceBizId, livyComputeId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the queue of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditWorkspaceQueueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditWorkspaceQueueResponse
        /// </returns>
        public EditWorkspaceQueueResponse EditWorkspaceQueueWithOptions(EditWorkspaceQueueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environments))
            {
                body["environments"] = request.Environments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpec))
            {
                body["resourceSpec"] = request.ResourceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceQueueName))
            {
                body["workspaceQueueName"] = request.WorkspaceQueueName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditWorkspaceQueue",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/queues/action/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditWorkspaceQueueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the queue of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditWorkspaceQueueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditWorkspaceQueueResponse
        /// </returns>
        public async Task<EditWorkspaceQueueResponse> EditWorkspaceQueueWithOptionsAsync(EditWorkspaceQueueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environments))
            {
                body["environments"] = request.Environments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpec))
            {
                body["resourceSpec"] = request.ResourceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceQueueName))
            {
                body["workspaceQueueName"] = request.WorkspaceQueueName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditWorkspaceQueue",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/queues/action/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditWorkspaceQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the queue of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditWorkspaceQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// EditWorkspaceQueueResponse
        /// </returns>
        public EditWorkspaceQueueResponse EditWorkspaceQueue(EditWorkspaceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EditWorkspaceQueueWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the queue of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditWorkspaceQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// EditWorkspaceQueueResponse
        /// </returns>
        public async Task<EditWorkspaceQueueResponse> EditWorkspaceQueueAsync(EditWorkspaceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EditWorkspaceQueueWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线工作流及其调度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTaskCodesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTaskCodesResponse
        /// </returns>
        public GenerateTaskCodesResponse GenerateTaskCodesWithOptions(string bizId, GenerateTaskCodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenNum))
            {
                query["genNum"] = request.GenNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTaskCodes",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/task-definition/gen-task-codes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTaskCodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线工作流及其调度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTaskCodesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTaskCodesResponse
        /// </returns>
        public async Task<GenerateTaskCodesResponse> GenerateTaskCodesWithOptionsAsync(string bizId, GenerateTaskCodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenNum))
            {
                query["genNum"] = request.GenNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTaskCodes",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/task-definition/gen-task-codes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTaskCodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线工作流及其调度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTaskCodesRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTaskCodesResponse
        /// </returns>
        public GenerateTaskCodesResponse GenerateTaskCodes(string bizId, GenerateTaskCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateTaskCodesWithOptions(bizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线工作流及其调度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTaskCodesRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTaskCodesResponse
        /// </returns>
        public async Task<GenerateTaskCodesResponse> GenerateTaskCodesAsync(string bizId, GenerateTaskCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateTaskCodesWithOptionsAsync(bizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of CU-hours consumed by a queue during a specified cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCuHoursRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCuHoursResponse
        /// </returns>
        public GetCuHoursResponse GetCuHoursWithOptions(string workspaceId, string queue, GetCuHoursRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCuHours",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/metric/cuHours/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(queue),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCuHoursResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of CU-hours consumed by a queue during a specified cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCuHoursRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCuHoursResponse
        /// </returns>
        public async Task<GetCuHoursResponse> GetCuHoursWithOptionsAsync(string workspaceId, string queue, GetCuHoursRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCuHours",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/metric/cuHours/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(queue),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCuHoursResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of CU-hours consumed by a queue during a specified cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCuHoursRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCuHoursResponse
        /// </returns>
        public GetCuHoursResponse GetCuHours(string workspaceId, string queue, GetCuHoursRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCuHoursWithOptions(workspaceId, queue, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of CU-hours consumed by a queue during a specified cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCuHoursRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCuHoursResponse
        /// </returns>
        public async Task<GetCuHoursResponse> GetCuHoursAsync(string workspaceId, string queue, GetCuHoursRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCuHoursWithOptionsAsync(workspaceId, queue, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains job analysis information on E-MapReduce (EMR) Doctor.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoctorApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDoctorApplicationResponse
        /// </returns>
        public GetDoctorApplicationResponse GetDoctorApplicationWithOptions(string workspaceId, string runId, GetDoctorApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTime))
            {
                query["queryTime"] = request.QueryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorApplication",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/action/getDoctorApplication",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains job analysis information on E-MapReduce (EMR) Doctor.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoctorApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDoctorApplicationResponse
        /// </returns>
        public async Task<GetDoctorApplicationResponse> GetDoctorApplicationWithOptionsAsync(string workspaceId, string runId, GetDoctorApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTime))
            {
                query["queryTime"] = request.QueryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorApplication",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/action/getDoctorApplication",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains job analysis information on E-MapReduce (EMR) Doctor.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoctorApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDoctorApplicationResponse
        /// </returns>
        public GetDoctorApplicationResponse GetDoctorApplication(string workspaceId, string runId, GetDoctorApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDoctorApplicationWithOptions(workspaceId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains job analysis information on E-MapReduce (EMR) Doctor.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDoctorApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDoctorApplicationResponse
        /// </returns>
        public async Task<GetDoctorApplicationResponse> GetDoctorApplicationAsync(string workspaceId, string runId, GetDoctorApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDoctorApplicationWithOptionsAsync(workspaceId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the job details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobRunResponse
        /// </returns>
        public GetJobRunResponse GetJobRunWithOptions(string workspaceId, string jobRunId, GetJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the job details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobRunResponse
        /// </returns>
        public async Task<GetJobRunResponse> GetJobRunWithOptionsAsync(string workspaceId, string jobRunId, GetJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the job details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobRunResponse
        /// </returns>
        public GetJobRunResponse GetJobRun(string workspaceId, string jobRunId, GetJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobRunWithOptions(workspaceId, jobRunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the job details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobRunResponse
        /// </returns>
        public async Task<GetJobRunResponse> GetJobRunAsync(string workspaceId, string jobRunId, GetJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobRunWithOptionsAsync(workspaceId, jobRunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKyuubiServiceResponse
        /// </returns>
        public GetKyuubiServiceResponse GetKyuubiServiceWithOptions(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKyuubiServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKyuubiServiceResponse
        /// </returns>
        public async Task<GetKyuubiServiceResponse> GetKyuubiServiceWithOptionsAsync(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKyuubiServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetKyuubiServiceResponse
        /// </returns>
        public GetKyuubiServiceResponse GetKyuubiService(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKyuubiServiceWithOptions(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetKyuubiServiceResponse
        /// </returns>
        public async Task<GetKyuubiServiceResponse> GetKyuubiServiceAsync(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKyuubiServiceWithOptionsAsync(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKyuubiTokenResponse
        /// </returns>
        public GetKyuubiTokenResponse GetKyuubiTokenWithOptions(string workspaceId, string kyuubiServiceId, string tokenId, GetKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKyuubiTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKyuubiTokenResponse
        /// </returns>
        public async Task<GetKyuubiTokenResponse> GetKyuubiTokenWithOptionsAsync(string workspaceId, string kyuubiServiceId, string tokenId, GetKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKyuubiTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKyuubiTokenResponse
        /// </returns>
        public GetKyuubiTokenResponse GetKyuubiToken(string workspaceId, string kyuubiServiceId, string tokenId, GetKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKyuubiTokenWithOptions(workspaceId, kyuubiServiceId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKyuubiTokenResponse
        /// </returns>
        public async Task<GetKyuubiTokenResponse> GetKyuubiTokenAsync(string workspaceId, string kyuubiServiceId, string tokenId, GetKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKyuubiTokenWithOptionsAsync(workspaceId, kyuubiServiceId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeResponse
        /// </returns>
        public GetLivyComputeResponse GetLivyComputeWithOptions(string workspaceBizId, string livyComputeId, GetLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLivyComputeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeResponse
        /// </returns>
        public async Task<GetLivyComputeResponse> GetLivyComputeWithOptionsAsync(string workspaceBizId, string livyComputeId, GetLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLivyComputeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeResponse
        /// </returns>
        public GetLivyComputeResponse GetLivyCompute(string workspaceBizId, string livyComputeId, GetLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLivyComputeWithOptions(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeResponse
        /// </returns>
        public async Task<GetLivyComputeResponse> GetLivyComputeAsync(string workspaceBizId, string livyComputeId, GetLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLivyComputeWithOptionsAsync(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeTokenResponse
        /// </returns>
        public GetLivyComputeTokenResponse GetLivyComputeTokenWithOptions(string workspaceBizId, string livyComputeId, string tokenId, GetLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLivyComputeTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeTokenResponse
        /// </returns>
        public async Task<GetLivyComputeTokenResponse> GetLivyComputeTokenWithOptionsAsync(string workspaceBizId, string livyComputeId, string tokenId, GetLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLivyComputeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeTokenResponse
        /// </returns>
        public GetLivyComputeTokenResponse GetLivyComputeToken(string workspaceBizId, string livyComputeId, string tokenId, GetLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLivyComputeTokenWithOptions(workspaceBizId, livyComputeId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLivyComputeTokenResponse
        /// </returns>
        public async Task<GetLivyComputeTokenResponse> GetLivyComputeTokenAsync(string workspaceBizId, string livyComputeId, string tokenId, GetLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLivyComputeTokenWithOptionsAsync(workspaceBizId, livyComputeId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunConfigurationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunConfigurationResponse
        /// </returns>
        public GetRunConfigurationResponse GetRunConfigurationWithOptions(string workspaceId, string runId, GetRunConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRunConfiguration",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/action/getRunConfiguration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunConfigurationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunConfigurationResponse
        /// </returns>
        public async Task<GetRunConfigurationResponse> GetRunConfigurationWithOptionsAsync(string workspaceId, string runId, GetRunConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRunConfiguration",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/action/getRunConfiguration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunConfigurationResponse
        /// </returns>
        public GetRunConfigurationResponse GetRunConfiguration(string workspaceId, string runId, GetRunConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRunConfigurationWithOptions(workspaceId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunConfigurationResponse
        /// </returns>
        public async Task<GetRunConfigurationResponse> GetRunConfigurationAsync(string workspaceId, string runId, GetRunConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRunConfigurationWithOptionsAsync(workspaceId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public GetSessionClusterResponse GetSessionClusterWithOptions(string workspaceId, string sessionClusterId, GetSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public async Task<GetSessionClusterResponse> GetSessionClusterWithOptionsAsync(string workspaceId, string sessionClusterId, GetSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public GetSessionClusterResponse GetSessionCluster(string workspaceId, string sessionClusterId, GetSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSessionClusterWithOptions(workspaceId, sessionClusterId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public async Task<GetSessionClusterResponse> GetSessionClusterAsync(string workspaceId, string sessionClusterId, GetSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSessionClusterWithOptionsAsync(workspaceId, sessionClusterId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlStatementResponse
        /// </returns>
        public GetSqlStatementResponse GetSqlStatementWithOptions(string workspaceId, string statementId, GetSqlStatementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlStatement",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/statement/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(statementId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlStatementResponse
        /// </returns>
        public async Task<GetSqlStatementResponse> GetSqlStatementWithOptionsAsync(string workspaceId, string statementId, GetSqlStatementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlStatement",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/statement/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(statementId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlStatementResponse
        /// </returns>
        public GetSqlStatementResponse GetSqlStatement(string workspaceId, string statementId, GetSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlStatementWithOptions(workspaceId, statementId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlStatementResponse
        /// </returns>
        public async Task<GetSqlStatementResponse> GetSqlStatementAsync(string workspaceId, string statementId, GetSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlStatementWithOptionsAsync(workspaceId, statementId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(string workspaceBizId, GetTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBizId))
            {
                query["templateBizId"] = request.TemplateBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(string workspaceBizId, GetTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBizId))
            {
                query["templateBizId"] = request.TemplateBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/template",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(string workspaceBizId, GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateWithOptions(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(string workspaceBizId, GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateWithOptionsAsync(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns a specified role to users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public GrantRoleToUsersResponse GrantRoleToUsersWithOptions(GrantRoleToUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["roleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserArns))
            {
                body["userArns"] = request.UserArns;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRoleToUsers",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/auth/roles/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantRoleToUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns a specified role to users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public async Task<GrantRoleToUsersResponse> GrantRoleToUsersWithOptionsAsync(GrantRoleToUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["roleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserArns))
            {
                body["userArns"] = request.UserArns;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRoleToUsers",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/auth/roles/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantRoleToUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns a specified role to users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public GrantRoleToUsersResponse GrantRoleToUsers(GrantRoleToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantRoleToUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns a specified role to users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public async Task<GrantRoleToUsersResponse> GrantRoleToUsersAsync(GrantRoleToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantRoleToUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public ListCatalogsResponse ListCatalogsWithOptions(string workspaceId, ListCatalogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public async Task<ListCatalogsResponse> ListCatalogsWithOptionsAsync(string workspaceId, ListCatalogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public ListCatalogsResponse ListCatalogs(string workspaceId, ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCatalogsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public async Task<ListCatalogsResponse> ListCatalogsAsync(string workspaceId, ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCatalogsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出作业的executors</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutorsResponse
        /// </returns>
        public ListJobExecutorsResponse ListJobExecutorsWithOptions(string workspaceId, string jobRunId, ListJobExecutorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorType))
            {
                query["executorType"] = request.ExecutorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutors",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId) + "/executors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出作业的executors</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutorsResponse
        /// </returns>
        public async Task<ListJobExecutorsResponse> ListJobExecutorsWithOptionsAsync(string workspaceId, string jobRunId, ListJobExecutorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorType))
            {
                query["executorType"] = request.ExecutorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutors",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId) + "/executors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出作业的executors</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutorsResponse
        /// </returns>
        public ListJobExecutorsResponse ListJobExecutors(string workspaceId, string jobRunId, ListJobExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobExecutorsWithOptions(workspaceId, jobRunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出作业的executors</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutorsResponse
        /// </returns>
        public async Task<ListJobExecutorsResponse> ListJobExecutorsAsync(string workspaceId, string jobRunId, ListJobExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobExecutorsWithOptionsAsync(workspaceId, jobRunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Spark jobs.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListJobRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobRunsResponse
        /// </returns>
        public ListJobRunsResponse ListJobRunsWithOptions(string workspaceId, ListJobRunsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobRunsShrinkRequest request = new ListJobRunsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EndTime))
            {
                request.EndTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EndTime, "endTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTime))
            {
                request.StartTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTime, "startTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.States))
            {
                request.StatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.States, "states", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["applicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeShrink))
            {
                query["endTime"] = request.EndTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsWorkflow))
            {
                query["isWorkflow"] = request.IsWorkflow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobRunDeploymentId))
            {
                query["jobRunDeploymentId"] = request.JobRunDeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobRunId))
            {
                query["jobRunId"] = request.JobRunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDuration))
            {
                query["minDuration"] = request.MinDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                query["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeConfigs))
            {
                query["runtimeConfigs"] = request.RuntimeConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeShrink))
            {
                query["startTime"] = request.StartTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatesShrink))
            {
                query["states"] = request.StatesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobRuns",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobRunsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Spark jobs.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListJobRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobRunsResponse
        /// </returns>
        public async Task<ListJobRunsResponse> ListJobRunsWithOptionsAsync(string workspaceId, ListJobRunsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobRunsShrinkRequest request = new ListJobRunsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EndTime))
            {
                request.EndTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EndTime, "endTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTime))
            {
                request.StartTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTime, "startTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.States))
            {
                request.StatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.States, "states", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["applicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeShrink))
            {
                query["endTime"] = request.EndTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsWorkflow))
            {
                query["isWorkflow"] = request.IsWorkflow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobRunDeploymentId))
            {
                query["jobRunDeploymentId"] = request.JobRunDeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobRunId))
            {
                query["jobRunId"] = request.JobRunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDuration))
            {
                query["minDuration"] = request.MinDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                query["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeConfigs))
            {
                query["runtimeConfigs"] = request.RuntimeConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeShrink))
            {
                query["startTime"] = request.StartTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatesShrink))
            {
                query["states"] = request.StatesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobRuns",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Spark jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobRunsResponse
        /// </returns>
        public ListJobRunsResponse ListJobRuns(string workspaceId, ListJobRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobRunsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Spark jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobRunsResponse
        /// </returns>
        public async Task<ListJobRunsResponse> ListJobRunsAsync(string workspaceId, ListJobRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobRunsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListKyuubiServices</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiServicesResponse
        /// </returns>
        public ListKyuubiServicesResponse ListKyuubiServicesWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKyuubiServices",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKyuubiServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListKyuubiServices</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiServicesResponse
        /// </returns>
        public async Task<ListKyuubiServicesResponse> ListKyuubiServicesWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKyuubiServices",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKyuubiServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListKyuubiServices</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListKyuubiServicesResponse
        /// </returns>
        public ListKyuubiServicesResponse ListKyuubiServices(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKyuubiServicesWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListKyuubiServices</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListKyuubiServicesResponse
        /// </returns>
        public async Task<ListKyuubiServicesResponse> ListKyuubiServicesAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKyuubiServicesWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications that are submitted by using a Kyuubi gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListKyuubiSparkApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiSparkApplicationsResponse
        /// </returns>
        public ListKyuubiSparkApplicationsResponse ListKyuubiSparkApplicationsWithOptions(string workspaceId, string kyuubiServiceId, ListKyuubiSparkApplicationsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListKyuubiSparkApplicationsShrinkRequest request = new ListKyuubiSparkApplicationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderBy))
            {
                request.OrderByShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderBy, "orderBy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTime))
            {
                request.StartTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTime, "startTime", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["applicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["applicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDuration))
            {
                query["minDuration"] = request.MinDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByShrink))
            {
                query["orderBy"] = request.OrderByShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                query["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeShrink))
            {
                query["startTime"] = request.StartTimeShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKyuubiSparkApplications",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/applications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKyuubiSparkApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications that are submitted by using a Kyuubi gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListKyuubiSparkApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiSparkApplicationsResponse
        /// </returns>
        public async Task<ListKyuubiSparkApplicationsResponse> ListKyuubiSparkApplicationsWithOptionsAsync(string workspaceId, string kyuubiServiceId, ListKyuubiSparkApplicationsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListKyuubiSparkApplicationsShrinkRequest request = new ListKyuubiSparkApplicationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderBy))
            {
                request.OrderByShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderBy, "orderBy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTime))
            {
                request.StartTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTime, "startTime", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["applicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["applicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDuration))
            {
                query["minDuration"] = request.MinDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByShrink))
            {
                query["orderBy"] = request.OrderByShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                query["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeShrink))
            {
                query["startTime"] = request.StartTimeShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKyuubiSparkApplications",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/applications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKyuubiSparkApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications that are submitted by using a Kyuubi gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKyuubiSparkApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiSparkApplicationsResponse
        /// </returns>
        public ListKyuubiSparkApplicationsResponse ListKyuubiSparkApplications(string workspaceId, string kyuubiServiceId, ListKyuubiSparkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKyuubiSparkApplicationsWithOptions(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the applications that are submitted by using a Kyuubi gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKyuubiSparkApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiSparkApplicationsResponse
        /// </returns>
        public async Task<ListKyuubiSparkApplicationsResponse> ListKyuubiSparkApplicationsAsync(string workspaceId, string kyuubiServiceId, ListKyuubiSparkApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKyuubiSparkApplicationsWithOptionsAsync(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiTokenResponse
        /// </returns>
        public ListKyuubiTokenResponse ListKyuubiTokenWithOptions(string workspaceId, string kyuubiServiceId, ListKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKyuubiTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiTokenResponse
        /// </returns>
        public async Task<ListKyuubiTokenResponse> ListKyuubiTokenWithOptionsAsync(string workspaceId, string kyuubiServiceId, ListKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKyuubiTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiTokenResponse
        /// </returns>
        public ListKyuubiTokenResponse ListKyuubiToken(string workspaceId, string kyuubiServiceId, ListKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKyuubiTokenWithOptions(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKyuubiTokenResponse
        /// </returns>
        public async Task<ListKyuubiTokenResponse> ListKyuubiTokenAsync(string workspaceId, string kyuubiServiceId, ListKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKyuubiTokenWithOptionsAsync(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeResponse
        /// </returns>
        public ListLivyComputeResponse ListLivyComputeWithOptions(string workspaceBizId, ListLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLivyComputeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeResponse
        /// </returns>
        public async Task<ListLivyComputeResponse> ListLivyComputeWithOptionsAsync(string workspaceBizId, ListLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                query["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLivyComputeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeResponse
        /// </returns>
        public ListLivyComputeResponse ListLivyCompute(string workspaceBizId, ListLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLivyComputeWithOptions(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeResponse
        /// </returns>
        public async Task<ListLivyComputeResponse> ListLivyComputeAsync(string workspaceBizId, ListLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLivyComputeWithOptionsAsync(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeTokenResponse
        /// </returns>
        public ListLivyComputeTokenResponse ListLivyComputeTokenWithOptions(string workspaceBizId, string livyComputeId, ListLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLivyComputeTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeTokenResponse
        /// </returns>
        public async Task<ListLivyComputeTokenResponse> ListLivyComputeTokenWithOptionsAsync(string workspaceBizId, string livyComputeId, ListLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLivyComputeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeTokenResponse
        /// </returns>
        public ListLivyComputeTokenResponse ListLivyComputeToken(string workspaceBizId, string livyComputeId, ListLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLivyComputeTokenWithOptions(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出livy compute token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLivyComputeTokenResponse
        /// </returns>
        public async Task<ListLivyComputeTokenResponse> ListLivyComputeTokenAsync(string workspaceBizId, string livyComputeId, ListLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLivyComputeTokenWithOptionsAsync(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Log Content</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogContentsResponse
        /// </returns>
        public ListLogContentsResponse ListLogContentsWithOptions(string workspaceId, ListLogContentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogContents",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/action/listLogContents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogContentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Log Content</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogContentsResponse
        /// </returns>
        public async Task<ListLogContentsResponse> ListLogContentsWithOptionsAsync(string workspaceId, ListLogContentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogContents",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/action/listLogContents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogContentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Log Content</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogContentsResponse
        /// </returns>
        public ListLogContentsResponse ListLogContents(string workspaceId, ListLogContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogContentsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Log Content</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogContentsResponse
        /// </returns>
        public async Task<ListLogContentsResponse> ListLogContentsAsync(string workspaceId, ListLogContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogContentsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public ListMembersResponse ListMembersWithOptions(string workspaceId, ListMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/auth/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public async Task<ListMembersResponse> ListMembersWithOptionsAsync(string workspaceId, ListMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/auth/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public ListMembersResponse ListMembers(string workspaceId, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMembersWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public async Task<ListMembersResponse> ListMembersAsync(string workspaceId, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMembersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of published versions of E-MapReduce (EMR) Serverless Spark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReleaseVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReleaseVersionsResponse
        /// </returns>
        public ListReleaseVersionsResponse ListReleaseVersionsWithOptions(ListReleaseVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                query["releaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                query["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersionStatus))
            {
                query["releaseVersionStatus"] = request.ReleaseVersionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceFilter))
            {
                query["serviceFilter"] = request.ServiceFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReleaseVersions",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/releaseVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReleaseVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of published versions of E-MapReduce (EMR) Serverless Spark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReleaseVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReleaseVersionsResponse
        /// </returns>
        public async Task<ListReleaseVersionsResponse> ListReleaseVersionsWithOptionsAsync(ListReleaseVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseType))
            {
                query["releaseType"] = request.ReleaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                query["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersionStatus))
            {
                query["releaseVersionStatus"] = request.ReleaseVersionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceFilter))
            {
                query["serviceFilter"] = request.ServiceFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReleaseVersions",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/releaseVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReleaseVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of published versions of E-MapReduce (EMR) Serverless Spark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReleaseVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReleaseVersionsResponse
        /// </returns>
        public ListReleaseVersionsResponse ListReleaseVersions(ListReleaseVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListReleaseVersionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of published versions of E-MapReduce (EMR) Serverless Spark.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReleaseVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReleaseVersionsResponse
        /// </returns>
        public async Task<ListReleaseVersionsResponse> ListReleaseVersionsAsync(ListReleaseVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListReleaseVersionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sessions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionClustersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public ListSessionClustersResponse ListSessionClustersWithOptions(string workspaceId, ListSessionClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterId))
            {
                query["sessionClusterId"] = request.SessionClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionClusters",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionClustersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sessions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionClustersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public async Task<ListSessionClustersResponse> ListSessionClustersWithOptionsAsync(string workspaceId, ListSessionClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterId))
            {
                query["sessionClusterId"] = request.SessionClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionClusters",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sessions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public ListSessionClustersResponse ListSessionClusters(string workspaceId, ListSessionClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSessionClustersWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sessions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public async Task<ListSessionClustersResponse> ListSessionClustersAsync(string workspaceId, ListSessionClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSessionClustersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取sql statement内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSqlStatementContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSqlStatementContentsResponse
        /// </returns>
        public ListSqlStatementContentsResponse ListSqlStatementContentsWithOptions(string workspaceId, ListSqlStatementContentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSqlStatementContents",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/action/listSqlStatementContents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSqlStatementContentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取sql statement内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSqlStatementContentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSqlStatementContentsResponse
        /// </returns>
        public async Task<ListSqlStatementContentsResponse> ListSqlStatementContentsWithOptionsAsync(string workspaceId, ListSqlStatementContentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSqlStatementContents",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/action/listSqlStatementContents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSqlStatementContentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取sql statement内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSqlStatementContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSqlStatementContentsResponse
        /// </returns>
        public ListSqlStatementContentsResponse ListSqlStatementContents(string workspaceId, ListSqlStatementContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSqlStatementContentsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取sql statement内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSqlStatementContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSqlStatementContentsResponse
        /// </returns>
        public async Task<ListSqlStatementContentsResponse> ListSqlStatementContentsAsync(string workspaceId, ListSqlStatementContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSqlStatementContentsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public ListTemplateResponse ListTemplateWithOptions(string workspaceBizId, ListTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplate",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/template/listing",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public async Task<ListTemplateResponse> ListTemplateWithOptionsAsync(string workspaceBizId, ListTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplate",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/template/listing",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public ListTemplateResponse ListTemplate(string workspaceBizId, ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplateWithOptions(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public async Task<ListTemplateResponse> ListTemplateAsync(string workspaceBizId, ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplateWithOptionsAsync(workspaceBizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of queues in a Spark workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceQueuesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceQueuesResponse
        /// </returns>
        public ListWorkspaceQueuesResponse ListWorkspaceQueuesWithOptions(string workspaceId, ListWorkspaceQueuesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceQueues",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/queues",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceQueuesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of queues in a Spark workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceQueuesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceQueuesResponse
        /// </returns>
        public async Task<ListWorkspaceQueuesResponse> ListWorkspaceQueuesWithOptionsAsync(string workspaceId, ListWorkspaceQueuesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceQueues",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/queues",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceQueuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of queues in a Spark workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceQueuesResponse
        /// </returns>
        public ListWorkspaceQueuesResponse ListWorkspaceQueues(string workspaceId, ListWorkspaceQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspaceQueuesWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of queues in a Spark workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceQueuesResponse
        /// </returns>
        public async Task<ListWorkspaceQueuesResponse> ListWorkspaceQueuesAsync(string workspaceId, ListWorkspaceQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspaceQueuesWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshLivyComputeTokenResponse
        /// </returns>
        public RefreshLivyComputeTokenResponse RefreshLivyComputeTokenWithOptions(string workspaceBizId, string livyComputeId, string tokenId, RefreshLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLivyComputeTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshLivyComputeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshLivyComputeTokenResponse
        /// </returns>
        public async Task<RefreshLivyComputeTokenResponse> RefreshLivyComputeTokenWithOptionsAsync(string workspaceBizId, string livyComputeId, string tokenId, RefreshLivyComputeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshLivyComputeToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLivyComputeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshLivyComputeTokenResponse
        /// </returns>
        public RefreshLivyComputeTokenResponse RefreshLivyComputeToken(string workspaceBizId, string livyComputeId, string tokenId, RefreshLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshLivyComputeTokenWithOptions(workspaceBizId, livyComputeId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Livy Compute的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshLivyComputeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshLivyComputeTokenResponse
        /// </returns>
        public async Task<RefreshLivyComputeTokenResponse> RefreshLivyComputeTokenAsync(string workspaceBizId, string livyComputeId, string tokenId, RefreshLivyComputeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshLivyComputeTokenWithOptionsAsync(workspaceBizId, livyComputeId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobRunResponse
        /// </returns>
        public StartJobRunResponse StartJobRunWithOptions(string workspaceId, StartJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                body["codeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationOverrides))
            {
                body["configurationOverrides"] = request.ConfigurationOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTimeoutSeconds))
            {
                body["executionTimeoutSeconds"] = request.ExecutionTimeoutSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDriver))
            {
                body["jobDriver"] = request.JobDriver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                body["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobRunResponse
        /// </returns>
        public async Task<StartJobRunResponse> StartJobRunWithOptionsAsync(string workspaceId, StartJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                body["codeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationOverrides))
            {
                body["configurationOverrides"] = request.ConfigurationOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTimeoutSeconds))
            {
                body["executionTimeoutSeconds"] = request.ExecutionTimeoutSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDriver))
            {
                body["jobDriver"] = request.JobDriver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                body["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRunRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobRunResponse
        /// </returns>
        public StartJobRunResponse StartJobRun(string workspaceId, StartJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartJobRunWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Spark job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRunRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobRunResponse
        /// </returns>
        public async Task<StartJobRunResponse> StartJobRunAsync(string workspaceId, StartJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartJobRunWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartKyuubiServiceResponse
        /// </returns>
        public StartKyuubiServiceResponse StartKyuubiServiceWithOptions(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartKyuubiServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartKyuubiServiceResponse
        /// </returns>
        public async Task<StartKyuubiServiceResponse> StartKyuubiServiceWithOptionsAsync(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartKyuubiServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartKyuubiServiceResponse
        /// </returns>
        public StartKyuubiServiceResponse StartKyuubiService(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartKyuubiServiceWithOptions(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartKyuubiServiceResponse
        /// </returns>
        public async Task<StartKyuubiServiceResponse> StartKyuubiServiceAsync(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartKyuubiServiceWithOptionsAsync(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLivyComputeResponse
        /// </returns>
        public StartLivyComputeResponse StartLivyComputeWithOptions(string workspaceBizId, string livyComputeId, StartLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLivyComputeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLivyComputeResponse
        /// </returns>
        public async Task<StartLivyComputeResponse> StartLivyComputeWithOptionsAsync(string workspaceBizId, string livyComputeId, StartLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLivyComputeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLivyComputeResponse
        /// </returns>
        public StartLivyComputeResponse StartLivyCompute(string workspaceBizId, string livyComputeId, StartLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartLivyComputeWithOptions(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLivyComputeResponse
        /// </returns>
        public async Task<StartLivyComputeResponse> StartLivyComputeAsync(string workspaceBizId, string livyComputeId, StartLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartLivyComputeWithOptionsAsync(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually runs a workflow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public StartProcessInstanceResponse StartProcessInstanceWithOptions(string bizId, StartProcessInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProd))
            {
                query["isProd"] = request.IsProd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessDefinitionCode))
            {
                query["processDefinitionCode"] = request.ProcessDefinitionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeQueue))
            {
                query["runtimeQueue"] = request.RuntimeQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionHashCode))
            {
                query["versionHashCode"] = request.VersionHashCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionNumber))
            {
                query["versionNumber"] = request.VersionNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartProcessInstance",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/executors/start-process-instance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProcessInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually runs a workflow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public async Task<StartProcessInstanceResponse> StartProcessInstanceWithOptionsAsync(string bizId, StartProcessInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProd))
            {
                query["isProd"] = request.IsProd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessDefinitionCode))
            {
                query["processDefinitionCode"] = request.ProcessDefinitionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeQueue))
            {
                query["runtimeQueue"] = request.RuntimeQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionHashCode))
            {
                query["versionHashCode"] = request.VersionHashCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionNumber))
            {
                query["versionNumber"] = request.VersionNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartProcessInstance",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/executors/start-process-instance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProcessInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually runs a workflow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public StartProcessInstanceResponse StartProcessInstance(string bizId, StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartProcessInstanceWithOptions(bizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually runs a workflow.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartProcessInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartProcessInstanceResponse
        /// </returns>
        public async Task<StartProcessInstanceResponse> StartProcessInstanceAsync(string bizId, StartProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartProcessInstanceWithOptionsAsync(bizId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public StartSessionClusterResponse StartSessionClusterWithOptions(string workspaceId, StartSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterId))
            {
                body["sessionClusterId"] = request.SessionClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters/action/startSessionCluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public async Task<StartSessionClusterResponse> StartSessionClusterWithOptionsAsync(string workspaceId, StartSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterId))
            {
                body["sessionClusterId"] = request.SessionClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters/action/startSessionCluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public StartSessionClusterResponse StartSessionCluster(string workspaceId, StartSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartSessionClusterWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public async Task<StartSessionClusterResponse> StartSessionClusterAsync(string workspaceId, StartSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartSessionClusterWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopKyuubiServiceResponse
        /// </returns>
        public StopKyuubiServiceResponse StopKyuubiServiceWithOptions(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopKyuubiServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopKyuubiServiceResponse
        /// </returns>
        public async Task<StopKyuubiServiceResponse> StopKyuubiServiceWithOptionsAsync(string workspaceId, string kyuubiServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopKyuubiServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopKyuubiServiceResponse
        /// </returns>
        public StopKyuubiServiceResponse StopKyuubiService(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopKyuubiServiceWithOptions(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopKyuubiService</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopKyuubiServiceResponse
        /// </returns>
        public async Task<StopKyuubiServiceResponse> StopKyuubiServiceAsync(string workspaceId, string kyuubiServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopKyuubiServiceWithOptionsAsync(workspaceId, kyuubiServiceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLivyComputeResponse
        /// </returns>
        public StopLivyComputeResponse StopLivyComputeWithOptions(string workspaceBizId, string livyComputeId, StopLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLivyComputeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLivyComputeResponse
        /// </returns>
        public async Task<StopLivyComputeResponse> StopLivyComputeWithOptionsAsync(string workspaceBizId, string livyComputeId, StopLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLivyComputeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLivyComputeResponse
        /// </returns>
        public StopLivyComputeResponse StopLivyCompute(string workspaceBizId, string livyComputeId, StopLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopLivyComputeWithOptions(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLivyComputeResponse
        /// </returns>
        public async Task<StopLivyComputeResponse> StopLivyComputeAsync(string workspaceBizId, string livyComputeId, StopLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopLivyComputeWithOptionsAsync(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public StopSessionClusterResponse StopSessionClusterWithOptions(string workspaceId, StopSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterId))
            {
                body["sessionClusterId"] = request.SessionClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters/action/stopSessionCluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public async Task<StopSessionClusterResponse> StopSessionClusterWithOptionsAsync(string workspaceId, StopSessionClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterId))
            {
                body["sessionClusterId"] = request.SessionClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSessionCluster",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/sessionClusters/action/stopSessionCluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public StopSessionClusterResponse StopSessionCluster(string workspaceId, StopSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopSessionClusterWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public async Task<StopSessionClusterResponse> StopSessionClusterAsync(string workspaceId, StopSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopSessionClusterWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateSqlStatementResponse
        /// </returns>
        public TerminateSqlStatementResponse TerminateSqlStatementWithOptions(string workspaceId, string statementId, TerminateSqlStatementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateSqlStatement",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/statement/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(statementId) + "/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateSqlStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateSqlStatementResponse
        /// </returns>
        public async Task<TerminateSqlStatementResponse> TerminateSqlStatementWithOptionsAsync(string workspaceId, string statementId, TerminateSqlStatementRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateSqlStatement",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/statement/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(statementId) + "/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateSqlStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateSqlStatementResponse
        /// </returns>
        public TerminateSqlStatementResponse TerminateSqlStatement(string workspaceId, string statementId, TerminateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TerminateSqlStatementWithOptions(workspaceId, statementId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates an SQL query task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateSqlStatementResponse
        /// </returns>
        public async Task<TerminateSqlStatementResponse> TerminateSqlStatementAsync(string workspaceId, string statementId, TerminateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TerminateSqlStatementWithOptionsAsync(workspaceId, statementId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiServiceResponse
        /// </returns>
        public UpdateKyuubiServiceResponse UpdateKyuubiServiceWithOptions(string workspaceId, string kyuubiServiceId, UpdateKyuubiServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeInstance))
            {
                body["computeInstance"] = request.ComputeInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiConfigs))
            {
                body["kyuubiConfigs"] = request.KyuubiConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiReleaseVersion))
            {
                body["kyuubiReleaseVersion"] = request.KyuubiReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                body["publicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queue))
            {
                body["queue"] = request.Queue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replica))
            {
                body["replica"] = request.Replica;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                body["restart"] = request.Restart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparkConfigs))
            {
                body["sparkConfigs"] = request.SparkConfigs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKyuubiServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiServiceResponse
        /// </returns>
        public async Task<UpdateKyuubiServiceResponse> UpdateKyuubiServiceWithOptionsAsync(string workspaceId, string kyuubiServiceId, UpdateKyuubiServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeInstance))
            {
                body["computeInstance"] = request.ComputeInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiConfigs))
            {
                body["kyuubiConfigs"] = request.KyuubiConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KyuubiReleaseVersion))
            {
                body["kyuubiReleaseVersion"] = request.KyuubiReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                body["publicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queue))
            {
                body["queue"] = request.Queue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replica))
            {
                body["replica"] = request.Replica;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                body["restart"] = request.Restart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparkConfigs))
            {
                body["sparkConfigs"] = request.SparkConfigs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKyuubiService",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/kyuubi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKyuubiServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiServiceResponse
        /// </returns>
        public UpdateKyuubiServiceResponse UpdateKyuubiService(string workspaceId, string kyuubiServiceId, UpdateKyuubiServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKyuubiServiceWithOptions(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateKyuubiService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiServiceResponse
        /// </returns>
        public async Task<UpdateKyuubiServiceResponse> UpdateKyuubiServiceAsync(string workspaceId, string kyuubiServiceId, UpdateKyuubiServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKyuubiServiceWithOptionsAsync(workspaceId, kyuubiServiceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiTokenResponse
        /// </returns>
        public UpdateKyuubiTokenResponse UpdateKyuubiTokenWithOptions(string workspaceId, string kyuubiServiceId, string tokenId, UpdateKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberArns))
            {
                body["memberArns"] = request.MemberArns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKyuubiTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiTokenResponse
        /// </returns>
        public async Task<UpdateKyuubiTokenResponse> UpdateKyuubiTokenWithOptionsAsync(string workspaceId, string kyuubiServiceId, string tokenId, UpdateKyuubiTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireConfiguration))
            {
                body["autoExpireConfiguration"] = request.AutoExpireConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberArns))
            {
                body["memberArns"] = request.MemberArns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKyuubiToken",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/kyuubiService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(kyuubiServiceId) + "/token/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tokenId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKyuubiTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiTokenResponse
        /// </returns>
        public UpdateKyuubiTokenResponse UpdateKyuubiToken(string workspaceId, string kyuubiServiceId, string tokenId, UpdateKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKyuubiTokenWithOptions(workspaceId, kyuubiServiceId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新kyuubi的token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKyuubiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKyuubiTokenResponse
        /// </returns>
        public async Task<UpdateKyuubiTokenResponse> UpdateKyuubiTokenAsync(string workspaceId, string kyuubiServiceId, string tokenId, UpdateKyuubiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKyuubiTokenWithOptionsAsync(workspaceId, kyuubiServiceId, tokenId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLivyComputeResponse
        /// </returns>
        public UpdateLivyComputeResponse UpdateLivyComputeWithOptions(string workspaceBizId, string livyComputeId, UpdateLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                body["authType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartConfiguration))
            {
                body["autoStartConfiguration"] = request.AutoStartConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopConfiguration))
            {
                body["autoStopConfiguration"] = request.AutoStopConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                body["cpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublic))
            {
                body["enablePublic"] = request.EnablePublic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyServerConf))
            {
                body["livyServerConf"] = request.LivyServerConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyVersion))
            {
                body["livyVersion"] = request.LivyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                body["memoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkName))
            {
                body["networkName"] = request.NetworkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLivyComputeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLivyComputeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLivyComputeResponse
        /// </returns>
        public async Task<UpdateLivyComputeResponse> UpdateLivyComputeWithOptionsAsync(string workspaceBizId, string livyComputeId, UpdateLivyComputeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                body["authType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartConfiguration))
            {
                body["autoStartConfiguration"] = request.AutoStartConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopConfiguration))
            {
                body["autoStopConfiguration"] = request.AutoStopConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuLimit))
            {
                body["cpuLimit"] = request.CpuLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayReleaseVersion))
            {
                body["displayReleaseVersion"] = request.DisplayReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublic))
            {
                body["enablePublic"] = request.EnablePublic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fusion))
            {
                body["fusion"] = request.Fusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyServerConf))
            {
                body["livyServerConf"] = request.LivyServerConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LivyVersion))
            {
                body["livyVersion"] = request.LivyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                body["memoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkName))
            {
                body["networkName"] = request.NetworkName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["queueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLivyCompute",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/interactive/v1/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceBizId) + "/livycompute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(livyComputeId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLivyComputeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLivyComputeResponse
        /// </returns>
        public UpdateLivyComputeResponse UpdateLivyCompute(string workspaceBizId, string livyComputeId, UpdateLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLivyComputeWithOptions(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新livy compute</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLivyComputeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLivyComputeResponse
        /// </returns>
        public async Task<UpdateLivyComputeResponse> UpdateLivyComputeAsync(string workspaceBizId, string livyComputeId, UpdateLivyComputeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLivyComputeWithOptionsAsync(workspaceBizId, livyComputeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the workflow and time-based scheduling configurations.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateProcessDefinitionWithScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessDefinitionWithScheduleResponse
        /// </returns>
        public UpdateProcessDefinitionWithScheduleResponse UpdateProcessDefinitionWithScheduleWithOptions(string bizId, string code, UpdateProcessDefinitionWithScheduleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProcessDefinitionWithScheduleShrinkRequest request = new UpdateProcessDefinitionWithScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalParams))
            {
                request.GlobalParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalParams, "globalParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDefinitionJson))
            {
                request.TaskDefinitionJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDefinitionJson, "taskDefinitionJson", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskRelationJson))
            {
                request.TaskRelationJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskRelationJson, "taskRelationJson", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertEmailAddress))
            {
                query["alertEmailAddress"] = request.AlertEmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParamsShrink))
            {
                query["globalParams"] = request.GlobalParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Publish))
            {
                query["publish"] = request.Publish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseState))
            {
                query["releaseState"] = request.ReleaseState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueue))
            {
                query["resourceQueue"] = request.ResourceQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryTimes))
            {
                query["retryTimes"] = request.RetryTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunAs))
            {
                query["runAs"] = request.RunAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonShrink))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParallelism))
            {
                query["taskParallelism"] = request.TaskParallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonShrink))
            {
                query["taskRelationJson"] = request.TaskRelationJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProcessDefinitionWithSchedule",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/process-definition/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(code),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProcessDefinitionWithScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the workflow and time-based scheduling configurations.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateProcessDefinitionWithScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessDefinitionWithScheduleResponse
        /// </returns>
        public async Task<UpdateProcessDefinitionWithScheduleResponse> UpdateProcessDefinitionWithScheduleWithOptionsAsync(string bizId, string code, UpdateProcessDefinitionWithScheduleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProcessDefinitionWithScheduleShrinkRequest request = new UpdateProcessDefinitionWithScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalParams))
            {
                request.GlobalParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalParams, "globalParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Schedule))
            {
                request.ScheduleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Schedule, "schedule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskDefinitionJson))
            {
                request.TaskDefinitionJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskDefinitionJson, "taskDefinitionJson", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskRelationJson))
            {
                request.TaskRelationJsonShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskRelationJson, "taskRelationJson", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertEmailAddress))
            {
                query["alertEmailAddress"] = request.AlertEmailAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionType))
            {
                query["executionType"] = request.ExecutionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParamsShrink))
            {
                query["globalParams"] = request.GlobalParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductNamespace))
            {
                query["productNamespace"] = request.ProductNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Publish))
            {
                query["publish"] = request.Publish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseState))
            {
                query["releaseState"] = request.ReleaseState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueue))
            {
                query["resourceQueue"] = request.ResourceQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryTimes))
            {
                query["retryTimes"] = request.RetryTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunAs))
            {
                query["runAs"] = request.RunAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleShrink))
            {
                query["schedule"] = request.ScheduleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDefinitionJsonShrink))
            {
                query["taskDefinitionJson"] = request.TaskDefinitionJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParallelism))
            {
                query["taskParallelism"] = request.TaskParallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskRelationJsonShrink))
            {
                query["taskRelationJson"] = request.TaskRelationJsonShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProcessDefinitionWithSchedule",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/dolphinscheduler/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(bizId) + "/process-definition/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(code),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProcessDefinitionWithScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the workflow and time-based scheduling configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProcessDefinitionWithScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessDefinitionWithScheduleResponse
        /// </returns>
        public UpdateProcessDefinitionWithScheduleResponse UpdateProcessDefinitionWithSchedule(string bizId, string code, UpdateProcessDefinitionWithScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProcessDefinitionWithScheduleWithOptions(bizId, code, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the workflow and time-based scheduling configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProcessDefinitionWithScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProcessDefinitionWithScheduleResponse
        /// </returns>
        public async Task<UpdateProcessDefinitionWithScheduleResponse> UpdateProcessDefinitionWithScheduleAsync(string bizId, string code, UpdateProcessDefinitionWithScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProcessDefinitionWithScheduleWithOptionsAsync(bizId, code, request, headers, runtime);
        }

    }
}
