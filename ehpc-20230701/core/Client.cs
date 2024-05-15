// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EHPC20230701.Models;

namespace AlibabaCloud.SDK.EHPC20230701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ehpc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 添加托管侧用户自定义镜像
         *
         * @param tmpReq AddImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImageResponse
         */
        public AddImageResponse AddImageWithOptions(AddImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddImageShrinkRequest request = new AddImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContainerImageSpec))
            {
                request.ContainerImageSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContainerImageSpec, "ContainerImageSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VMImageSpec))
            {
                request.VMImageSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VMImageSpec, "VMImageSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerImageSpecShrink))
            {
                query["ContainerImageSpec"] = request.ContainerImageSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageVersion))
            {
                query["ImageVersion"] = request.ImageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VMImageSpecShrink))
            {
                query["VMImageSpec"] = request.VMImageSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImage",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加托管侧用户自定义镜像
         *
         * @param tmpReq AddImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImageResponse
         */
        public async Task<AddImageResponse> AddImageWithOptionsAsync(AddImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddImageShrinkRequest request = new AddImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContainerImageSpec))
            {
                request.ContainerImageSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContainerImageSpec, "ContainerImageSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VMImageSpec))
            {
                request.VMImageSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VMImageSpec, "VMImageSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerImageSpecShrink))
            {
                query["ContainerImageSpec"] = request.ContainerImageSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageVersion))
            {
                query["ImageVersion"] = request.ImageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VMImageSpecShrink))
            {
                query["VMImageSpec"] = request.VMImageSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImage",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加托管侧用户自定义镜像
         *
         * @param request AddImageRequest
         * @return AddImageResponse
         */
        public AddImageResponse AddImage(AddImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddImageWithOptions(request, runtime);
        }

        /**
         * @summary 添加托管侧用户自定义镜像
         *
         * @param request AddImageRequest
         * @return AddImageResponse
         */
        public async Task<AddImageResponse> AddImageAsync(AddImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddImageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交任务
         *
         * @param tmpReq CreateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateJobResponse
         */
        public CreateJobResponse CreateJobWithOptions(CreateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentPolicy))
            {
                request.DeploymentPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentPolicy, "DeploymentPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tasks))
            {
                request.TasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tasks, "Tasks", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentPolicyShrink))
            {
                query["DeploymentPolicy"] = request.DeploymentPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDescription))
            {
                query["JobDescription"] = request.JobDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TasksShrink))
            {
                query["Tasks"] = request.TasksShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交任务
         *
         * @param tmpReq CreateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateJobResponse
         */
        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentPolicy))
            {
                request.DeploymentPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentPolicy, "DeploymentPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tasks))
            {
                request.TasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tasks, "Tasks", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentPolicyShrink))
            {
                query["DeploymentPolicy"] = request.DeploymentPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDescription))
            {
                query["JobDescription"] = request.JobDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TasksShrink))
            {
                query["Tasks"] = request.TasksShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交任务
         *
         * @param request CreateJobRequest
         * @return CreateJobResponse
         */
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交任务
         *
         * @param request CreateJobRequest
         * @return CreateJobResponse
         */
        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除作业
         *
         * @param tmpReq DeleteJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobsResponse
         */
        public DeleteJobsResponse DeleteJobsWithOptions(DeleteJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteJobsShrinkRequest request = new DeleteJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorIds))
            {
                request.ExecutorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorIds, "ExecutorIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobSpec))
            {
                request.JobSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobSpec, "JobSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIdsShrink))
            {
                query["ExecutorIds"] = request.ExecutorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpecShrink))
            {
                query["JobSpec"] = request.JobSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobs",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除作业
         *
         * @param tmpReq DeleteJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobsResponse
         */
        public async Task<DeleteJobsResponse> DeleteJobsWithOptionsAsync(DeleteJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteJobsShrinkRequest request = new DeleteJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutorIds))
            {
                request.ExecutorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutorIds, "ExecutorIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobSpec))
            {
                request.JobSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobSpec, "JobSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIdsShrink))
            {
                query["ExecutorIds"] = request.ExecutorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpecShrink))
            {
                query["JobSpec"] = request.JobSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobs",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除作业
         *
         * @param request DeleteJobsRequest
         * @return DeleteJobsResponse
         */
        public DeleteJobsResponse DeleteJobs(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobsWithOptions(request, runtime);
        }

        /**
         * @summary 删除作业
         *
         * @param request DeleteJobsRequest
         * @return DeleteJobsResponse
         */
        public async Task<DeleteJobsResponse> DeleteJobsAsync(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询作业性能数据
         *
         * @param tmpReq DescribeJobMetricDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobMetricDataResponse
         */
        public DescribeJobMetricDataResponse DescribeJobMetricDataWithOptions(DescribeJobMetricDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeJobMetricDataShrinkRequest request = new DescribeJobMetricDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArrayIndex))
            {
                request.ArrayIndexShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArrayIndex, "ArrayIndex", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrayIndexShrink))
            {
                query["ArrayIndex"] = request.ArrayIndexShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobMetricData",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobMetricDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询作业性能数据
         *
         * @param tmpReq DescribeJobMetricDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobMetricDataResponse
         */
        public async Task<DescribeJobMetricDataResponse> DescribeJobMetricDataWithOptionsAsync(DescribeJobMetricDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeJobMetricDataShrinkRequest request = new DescribeJobMetricDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArrayIndex))
            {
                request.ArrayIndexShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArrayIndex, "ArrayIndex", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrayIndexShrink))
            {
                query["ArrayIndex"] = request.ArrayIndexShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobMetricData",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询作业性能数据
         *
         * @param request DescribeJobMetricDataRequest
         * @return DescribeJobMetricDataResponse
         */
        public DescribeJobMetricDataResponse DescribeJobMetricData(DescribeJobMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobMetricDataWithOptions(request, runtime);
        }

        /**
         * @summary 查询作业性能数据
         *
         * @param request DescribeJobMetricDataRequest
         * @return DescribeJobMetricDataResponse
         */
        public async Task<DescribeJobMetricDataResponse> DescribeJobMetricDataAsync(DescribeJobMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobMetricDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询作业即时监控项
         *
         * @param tmpReq DescribeJobMetricLastRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobMetricLastResponse
         */
        public DescribeJobMetricLastResponse DescribeJobMetricLastWithOptions(DescribeJobMetricLastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeJobMetricLastShrinkRequest request = new DescribeJobMetricLastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArrayIndex))
            {
                request.ArrayIndexShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArrayIndex, "ArrayIndex", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrayIndexShrink))
            {
                query["ArrayIndex"] = request.ArrayIndexShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobMetricLast",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobMetricLastResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询作业即时监控项
         *
         * @param tmpReq DescribeJobMetricLastRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobMetricLastResponse
         */
        public async Task<DescribeJobMetricLastResponse> DescribeJobMetricLastWithOptionsAsync(DescribeJobMetricLastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeJobMetricLastShrinkRequest request = new DescribeJobMetricLastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArrayIndex))
            {
                request.ArrayIndexShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArrayIndex, "ArrayIndex", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArrayIndexShrink))
            {
                query["ArrayIndex"] = request.ArrayIndexShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobMetricLast",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobMetricLastResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询作业即时监控项
         *
         * @param request DescribeJobMetricLastRequest
         * @return DescribeJobMetricLastResponse
         */
        public DescribeJobMetricLastResponse DescribeJobMetricLast(DescribeJobMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobMetricLastWithOptions(request, runtime);
        }

        /**
         * @summary 查询作业即时监控项
         *
         * @param request DescribeJobMetricLastRequest
         * @return DescribeJobMetricLastResponse
         */
        public async Task<DescribeJobMetricLastResponse> DescribeJobMetricLastAsync(DescribeJobMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobMetricLastWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询托管侧镜像详情。
         *
         * @param request GetImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageResponse
         */
        public GetImageResponse GetImageWithOptions(GetImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImage",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询托管侧镜像详情。
         *
         * @param request GetImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageResponse
         */
        public async Task<GetImageResponse> GetImageWithOptionsAsync(GetImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImage",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询托管侧镜像详情。
         *
         * @param request GetImageRequest
         * @return GetImageResponse
         */
        public GetImageResponse GetImage(GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageWithOptions(request, runtime);
        }

        /**
         * @summary 查询托管侧镜像详情。
         *
         * @param request GetImageRequest
         * @return GetImageResponse
         */
        public async Task<GetImageResponse> GetImageAsync(GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询作业详情
         *
         * @param request GetJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public GetJobResponse GetJobWithOptions(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询作业详情
         *
         * @param request GetJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobWithOptionsAsync(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询作业详情
         *
         * @param request GetJobRequest
         * @return GetJobResponse
         */
        public GetJobResponse GetJob(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询作业详情
         *
         * @param request GetJobRequest
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobAsync(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询全局Executor信息
         *
         * @param tmpReq ListExecutorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExecutorsResponse
         */
        public ListExecutorsResponse ListExecutorsWithOptions(ListExecutorsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExecutorsShrinkRequest request = new ListExecutorsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutors",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutorsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询全局Executor信息
         *
         * @param tmpReq ListExecutorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExecutorsResponse
         */
        public async Task<ListExecutorsResponse> ListExecutorsWithOptionsAsync(ListExecutorsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExecutorsShrinkRequest request = new ListExecutorsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutors",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询全局Executor信息
         *
         * @param request ListExecutorsRequest
         * @return ListExecutorsResponse
         */
        public ListExecutorsResponse ListExecutors(ListExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutorsWithOptions(request, runtime);
        }

        /**
         * @summary 查询全局Executor信息
         *
         * @param request ListExecutorsRequest
         * @return ListExecutorsResponse
         */
        public async Task<ListExecutorsResponse> ListExecutorsAsync(ListExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutorsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看托管侧镜像列表
         *
         * @param tmpReq ListImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListImagesResponse
         */
        public ListImagesResponse ListImagesWithOptions(ListImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListImagesShrinkRequest request = new ListImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageIds))
            {
                request.ImageIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageIds, "ImageIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIdsShrink))
            {
                query["ImageIds"] = request.ImageIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看托管侧镜像列表
         *
         * @param tmpReq ListImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListImagesResponse
         */
        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListImagesShrinkRequest request = new ListImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageIds))
            {
                request.ImageIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageIds, "ImageIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIdsShrink))
            {
                query["ImageIds"] = request.ImageIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看托管侧镜像列表
         *
         * @param request ListImagesRequest
         * @return ListImagesResponse
         */
        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImagesWithOptions(request, runtime);
        }

        /**
         * @summary 查看托管侧镜像列表
         *
         * @param request ListImagesRequest
         * @return ListImagesResponse
         */
        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询作业Executor信息
         *
         * @param request ListJobExecutorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobExecutorsResponse
         */
        public ListJobExecutorsResponse ListJobExecutorsWithOptions(ListJobExecutorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutors",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutorsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询作业Executor信息
         *
         * @param request ListJobExecutorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobExecutorsResponse
         */
        public async Task<ListJobExecutorsResponse> ListJobExecutorsWithOptionsAsync(ListJobExecutorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutors",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询作业Executor信息
         *
         * @param request ListJobExecutorsRequest
         * @return ListJobExecutorsResponse
         */
        public ListJobExecutorsResponse ListJobExecutors(ListJobExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobExecutorsWithOptions(request, runtime);
        }

        /**
         * @summary 查询作业Executor信息
         *
         * @param request ListJobExecutorsRequest
         * @return ListJobExecutorsResponse
         */
        public async Task<ListJobExecutorsResponse> ListJobExecutorsAsync(ListJobExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobExecutorsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询作业列表
         *
         * @param tmpReq ListJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobsWithOptions(ListJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobsShrinkRequest request = new ListJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SortBy))
            {
                request.SortByShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SortBy, "SortBy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByShrink))
            {
                query["SortBy"] = request.SortByShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询作业列表
         *
         * @param tmpReq ListJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobsShrinkRequest request = new ListJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SortBy))
            {
                request.SortByShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SortBy, "SortBy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByShrink))
            {
                query["SortBy"] = request.SortByShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询作业列表
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询作业列表
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 移除托管侧镜像信息。
         *
         * @param request RemoveImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveImageResponse
         */
        public RemoveImageResponse RemoveImageWithOptions(RemoveImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveImage",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 移除托管侧镜像信息。
         *
         * @param request RemoveImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveImageResponse
         */
        public async Task<RemoveImageResponse> RemoveImageWithOptionsAsync(RemoveImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveImage",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 移除托管侧镜像信息。
         *
         * @param request RemoveImageRequest
         * @return RemoveImageResponse
         */
        public RemoveImageResponse RemoveImage(RemoveImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveImageWithOptions(request, runtime);
        }

        /**
         * @summary 移除托管侧镜像信息。
         *
         * @param request RemoveImageRequest
         * @return RemoveImageResponse
         */
        public async Task<RemoveImageResponse> RemoveImageAsync(RemoveImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveImageWithOptionsAsync(request, runtime);
        }

    }
}
