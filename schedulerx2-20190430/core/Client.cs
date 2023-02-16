// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Schedulerx220190430.Models;

namespace AlibabaCloud.SDK.Schedulerx220190430
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "schedulerx.cn-beijing.aliyuncs.com"},
                {"cn-hangzhou", "schedulerx.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "schedulerx.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "schedulerx.cn-shenzhen.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("schedulerx2", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDeleteJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchDeleteJobsResponse
         */
        public BatchDeleteJobsResponse BatchDeleteJobsWithOptions(BatchDeleteJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdList))
            {
                body["JobIdList"] = request.JobIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDeleteJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchDeleteJobsResponse
         */
        public async Task<BatchDeleteJobsResponse> BatchDeleteJobsWithOptionsAsync(BatchDeleteJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdList))
            {
                body["JobIdList"] = request.JobIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDeleteJobsRequest
          * @return BatchDeleteJobsResponse
         */
        public BatchDeleteJobsResponse BatchDeleteJobs(BatchDeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteJobsWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDeleteJobsRequest
          * @return BatchDeleteJobsResponse
         */
        public async Task<BatchDeleteJobsResponse> BatchDeleteJobsAsync(BatchDeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteJobsWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDisableJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchDisableJobsResponse
         */
        public BatchDisableJobsResponse BatchDisableJobsWithOptions(BatchDisableJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdList))
            {
                body["JobIdList"] = request.JobIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDisableJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDisableJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDisableJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchDisableJobsResponse
         */
        public async Task<BatchDisableJobsResponse> BatchDisableJobsWithOptionsAsync(BatchDisableJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdList))
            {
                body["JobIdList"] = request.JobIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDisableJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDisableJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDisableJobsRequest
          * @return BatchDisableJobsResponse
         */
        public BatchDisableJobsResponse BatchDisableJobs(BatchDisableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDisableJobsWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchDisableJobsRequest
          * @return BatchDisableJobsResponse
         */
        public async Task<BatchDisableJobsResponse> BatchDisableJobsAsync(BatchDisableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDisableJobsWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchEnableJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchEnableJobsResponse
         */
        public BatchEnableJobsResponse BatchEnableJobsWithOptions(BatchEnableJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdList))
            {
                body["JobIdList"] = request.JobIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchEnableJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchEnableJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchEnableJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchEnableJobsResponse
         */
        public async Task<BatchEnableJobsResponse> BatchEnableJobsWithOptionsAsync(BatchEnableJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdList))
            {
                body["JobIdList"] = request.JobIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchEnableJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchEnableJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchEnableJobsRequest
          * @return BatchEnableJobsResponse
         */
        public BatchEnableJobsResponse BatchEnableJobs(BatchEnableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchEnableJobsWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          * ```xml
          * <dependency>
          *     <groupId>com.aliyun</groupId>
          *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *     <version>1.0.4</version>
          * </dependency>
          * ```
          *
          * @param request BatchEnableJobsRequest
          * @return BatchEnableJobsResponse
         */
        public async Task<BatchEnableJobsResponse> BatchEnableJobsAsync(BatchEnableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchEnableJobsWithOptionsAsync(request, runtime);
        }

        public CreateAppGroupResponse CreateAppGroupWithOptions(CreateAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAppGroupResponse> CreateAppGroupWithOptionsAsync(CreateAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAppGroupResponse CreateAppGroup(CreateAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppGroupWithOptions(request, runtime);
        }

        public async Task<CreateAppGroupResponse> CreateAppGroupAsync(CreateAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppGroupWithOptionsAsync(request, runtime);
        }

        public CreateJobResponse CreateJobWithOptions(CreateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["ClassName"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerSize))
            {
                body["ConsumerSize"] = request.ConsumerSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["ContactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataOffset))
            {
                body["DataOffset"] = request.DataOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatcherSize))
            {
                body["DispatcherSize"] = request.DispatcherSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteMode))
            {
                body["ExecuteMode"] = request.ExecuteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailEnable))
            {
                body["FailEnable"] = request.FailEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailTimes))
            {
                body["FailTimes"] = request.FailTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissWorkerEnable))
            {
                body["MissWorkerEnable"] = request.MissWorkerEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueSize))
            {
                body["QueueSize"] = request.QueueSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannel))
            {
                body["SendChannel"] = request.SendChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessNoticeEnable))
            {
                body["SuccessNoticeEnable"] = request.SuccessNoticeEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAttemptInterval))
            {
                body["TaskAttemptInterval"] = request.TaskAttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMaxAttempt))
            {
                body["TaskMaxAttempt"] = request.TaskMaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutEnable))
            {
                body["TimeoutEnable"] = request.TimeoutEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutKillEnable))
            {
                body["TimeoutKillEnable"] = request.TimeoutKillEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XAttrs))
            {
                body["XAttrs"] = request.XAttrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2019-04-30",
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

        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["ClassName"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerSize))
            {
                body["ConsumerSize"] = request.ConsumerSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["ContactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataOffset))
            {
                body["DataOffset"] = request.DataOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatcherSize))
            {
                body["DispatcherSize"] = request.DispatcherSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteMode))
            {
                body["ExecuteMode"] = request.ExecuteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailEnable))
            {
                body["FailEnable"] = request.FailEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailTimes))
            {
                body["FailTimes"] = request.FailTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissWorkerEnable))
            {
                body["MissWorkerEnable"] = request.MissWorkerEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueSize))
            {
                body["QueueSize"] = request.QueueSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannel))
            {
                body["SendChannel"] = request.SendChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessNoticeEnable))
            {
                body["SuccessNoticeEnable"] = request.SuccessNoticeEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAttemptInterval))
            {
                body["TaskAttemptInterval"] = request.TaskAttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMaxAttempt))
            {
                body["TaskMaxAttempt"] = request.TaskMaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutEnable))
            {
                body["TimeoutEnable"] = request.TimeoutEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutKillEnable))
            {
                body["TimeoutKillEnable"] = request.TimeoutKillEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XAttrs))
            {
                body["XAttrs"] = request.XAttrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2019-04-30",
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

        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        public CreateWorkflowResponse CreateWorkflowWithOptions(CreateWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateWorkflowResponse> CreateWorkflowWithOptionsAsync(CreateWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkflowWithOptions(request, runtime);
        }

        public async Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkflowWithOptionsAsync(request, runtime);
        }

        public DeleteJobResponse DeleteJobWithOptions(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobWithOptions(request, runtime);
        }

        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobWithOptionsAsync(request, runtime);
        }

        public DeleteWorkflowResponse DeleteWorkflowWithOptions(DeleteWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteWorkflowResponse> DeleteWorkflowWithOptionsAsync(DeleteWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkflowWithOptions(request, runtime);
        }

        public async Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkflowWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        public DesignateWorkersResponse DesignateWorkersWithOptions(DesignateWorkersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DesignateWorkers",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DesignateWorkersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DesignateWorkersResponse> DesignateWorkersWithOptionsAsync(DesignateWorkersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DesignateWorkers",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DesignateWorkersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DesignateWorkersResponse DesignateWorkers(DesignateWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DesignateWorkersWithOptions(request, runtime);
        }

        public async Task<DesignateWorkersResponse> DesignateWorkersAsync(DesignateWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DesignateWorkersWithOptionsAsync(request, runtime);
        }

        public DisableJobResponse DisableJobWithOptions(DisableJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableJobResponse> DisableJobWithOptionsAsync(DisableJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableJobResponse DisableJob(DisableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableJobWithOptions(request, runtime);
        }

        public async Task<DisableJobResponse> DisableJobAsync(DisableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableJobWithOptionsAsync(request, runtime);
        }

        public DisableWorkflowResponse DisableWorkflowWithOptions(DisableWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableWorkflowResponse> DisableWorkflowWithOptionsAsync(DisableWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableWorkflowResponse DisableWorkflow(DisableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableWorkflowWithOptions(request, runtime);
        }

        public async Task<DisableWorkflowResponse> DisableWorkflowAsync(DisableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableWorkflowWithOptionsAsync(request, runtime);
        }

        public EnableJobResponse EnableJobWithOptions(EnableJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableJobResponse> EnableJobWithOptionsAsync(EnableJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableJobResponse EnableJob(EnableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableJobWithOptions(request, runtime);
        }

        public async Task<EnableJobResponse> EnableJobAsync(EnableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableJobWithOptionsAsync(request, runtime);
        }

        public EnableWorkflowResponse EnableWorkflowWithOptions(EnableWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableWorkflowResponse> EnableWorkflowWithOptionsAsync(EnableWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableWorkflowResponse EnableWorkflow(EnableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableWorkflowWithOptions(request, runtime);
        }

        public async Task<EnableWorkflowResponse> EnableWorkflowAsync(EnableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableWorkflowWithOptionsAsync(request, runtime);
        }

        /**
          * > : The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
          *
          * @param request ExecuteJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ExecuteJobResponse
         */
        public ExecuteJobResponse ExecuteJobWithOptions(ExecuteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
          *
          * @param request ExecuteJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ExecuteJobResponse
         */
        public async Task<ExecuteJobResponse> ExecuteJobWithOptionsAsync(ExecuteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
          *
          * @param request ExecuteJobRequest
          * @return ExecuteJobResponse
         */
        public ExecuteJobResponse ExecuteJob(ExecuteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteJobWithOptions(request, runtime);
        }

        /**
          * > : The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
          *
          * @param request ExecuteJobRequest
          * @return ExecuteJobResponse
         */
        public async Task<ExecuteJobResponse> ExecuteJobAsync(ExecuteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteJobWithOptionsAsync(request, runtime);
        }

        public ExecuteWorkflowResponse ExecuteWorkflowWithOptions(ExecuteWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExecuteWorkflowResponse> ExecuteWorkflowWithOptionsAsync(ExecuteWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExecuteWorkflowResponse ExecuteWorkflow(ExecuteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteWorkflowWithOptions(request, runtime);
        }

        public async Task<ExecuteWorkflowResponse> ExecuteWorkflowAsync(ExecuteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteWorkflowWithOptionsAsync(request, runtime);
        }

        public GetJobInfoResponse GetJobInfoWithOptions(GetJobInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInfo",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobInfoResponse> GetJobInfoWithOptionsAsync(GetJobInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInfo",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobInfoResponse GetJobInfo(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInfoWithOptions(request, runtime);
        }

        public async Task<GetJobInfoResponse> GetJobInfoAsync(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInfoWithOptionsAsync(request, runtime);
        }

        public GetJobInstanceResponse GetJobInstanceWithOptions(GetJobInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobInstanceResponse> GetJobInstanceWithOptionsAsync(GetJobInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobInstanceResponse GetJobInstance(GetJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInstanceWithOptions(request, runtime);
        }

        public async Task<GetJobInstanceResponse> GetJobInstanceAsync(GetJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInstanceWithOptionsAsync(request, runtime);
        }

        public GetJobInstanceListResponse GetJobInstanceListWithOptions(GetJobInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInstanceList",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInstanceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetJobInstanceListResponse> GetJobInstanceListWithOptionsAsync(GetJobInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInstanceList",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetJobInstanceListResponse GetJobInstanceList(GetJobInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInstanceListWithOptions(request, runtime);
        }

        public async Task<GetJobInstanceListResponse> GetJobInstanceListAsync(GetJobInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInstanceListWithOptionsAsync(request, runtime);
        }

        public GetLogResponse GetLogWithOptions(GetLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLog",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLogResponse> GetLogWithOptionsAsync(GetLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLog",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLogResponse GetLog(GetLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogWithOptions(request, runtime);
        }

        public async Task<GetLogResponse> GetLogAsync(GetLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogWithOptionsAsync(request, runtime);
        }

        public GetWorkFlowResponse GetWorkFlowWithOptions(GetWorkFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkFlow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkFlowResponse> GetWorkFlowWithOptionsAsync(GetWorkFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkFlow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkFlowResponse GetWorkFlow(GetWorkFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkFlowWithOptions(request, runtime);
        }

        public async Task<GetWorkFlowResponse> GetWorkFlowAsync(GetWorkFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkFlowWithOptionsAsync(request, runtime);
        }

        public GetWorkerListResponse GetWorkerListWithOptions(GetWorkerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkerList",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkerListResponse> GetWorkerListWithOptionsAsync(GetWorkerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkerList",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkerListResponse GetWorkerList(GetWorkerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkerListWithOptions(request, runtime);
        }

        public async Task<GetWorkerListResponse> GetWorkerListAsync(GetWorkerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkerListWithOptionsAsync(request, runtime);
        }

        public GetWorkflowInstanceResponse GetWorkflowInstanceWithOptions(GetWorkflowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkflowInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkflowInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkflowInstanceResponse> GetWorkflowInstanceWithOptionsAsync(GetWorkflowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkflowInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkflowInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkflowInstanceResponse GetWorkflowInstance(GetWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkflowInstanceWithOptions(request, runtime);
        }

        public async Task<GetWorkflowInstanceResponse> GetWorkflowInstanceAsync(GetWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkflowInstanceWithOptionsAsync(request, runtime);
        }

        public GrantPermissionResponse GrantPermissionWithOptions(GrantPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantOption))
            {
                query["GrantOption"] = request.GrantOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPermission",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantPermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantPermissionResponse> GrantPermissionWithOptionsAsync(GrantPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantOption))
            {
                query["GrantOption"] = request.GrantOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPermission",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantPermissionResponse GrantPermission(GrantPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantPermissionWithOptions(request, runtime);
        }

        public async Task<GrantPermissionResponse> GrantPermissionAsync(GrantPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantPermissionWithOptionsAsync(request, runtime);
        }

        /**
          * >  Before you call this operation, you must add the following dependency to the pom.xml file:
          *       <groupId>com.aliyun</groupId>
          *       <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *       <version>1.0.5</version>
          *
          * @param request ListGroupsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  Before you call this operation, you must add the following dependency to the pom.xml file:
          *       <groupId>com.aliyun</groupId>
          *       <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *       <version>1.0.5</version>
          *
          * @param request ListGroupsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  Before you call this operation, you must add the following dependency to the pom.xml file:
          *       <groupId>com.aliyun</groupId>
          *       <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *       <version>1.0.5</version>
          *
          * @param request ListGroupsRequest
          * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsWithOptions(request, runtime);
        }

        /**
          * >  Before you call this operation, you must add the following dependency to the pom.xml file:
          *       <groupId>com.aliyun</groupId>
          *       <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *       <version>1.0.5</version>
          *
          * @param request ListGroupsRequest
          * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *           <groupId>com.aliyun</groupId>
          *           <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *           <version>1.0.5</version>
          *     </dependency>
          *
          * @param request ListJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListJobsResponse
         */
        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *           <groupId>com.aliyun</groupId>
          *           <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *           <version>1.0.5</version>
          *     </dependency>
          *
          * @param request ListJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *           <groupId>com.aliyun</groupId>
          *           <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *           <version>1.0.5</version>
          *     </dependency>
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
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *           <groupId>com.aliyun</groupId>
          *           <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *           <version>1.0.5</version>
          *     </dependency>
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
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *         <groupId>com.aliyun</groupId>
          *         <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *         <version>1.0.5</version>
          *     </dependency>
          *
          * @param request ListNamespacesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListNamespacesResponse
         */
        public ListNamespacesResponse ListNamespacesWithOptions(ListNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespaces",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *         <groupId>com.aliyun</groupId>
          *         <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *         <version>1.0.5</version>
          *     </dependency>
          *
          * @param request ListNamespacesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListNamespacesResponse
         */
        public async Task<ListNamespacesResponse> ListNamespacesWithOptionsAsync(ListNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespaces",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *         <groupId>com.aliyun</groupId>
          *         <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *         <version>1.0.5</version>
          *     </dependency>
          *
          * @param request ListNamespacesRequest
          * @return ListNamespacesResponse
         */
        public ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNamespacesWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must add the following dependency to the pom.xml file:
          *     <dependency>
          *         <groupId>com.aliyun</groupId>
          *         <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
          *         <version>1.0.5</version>
          *     </dependency>
          *
          * @param request ListNamespacesRequest
          * @return ListNamespacesResponse
         */
        public async Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNamespacesWithOptionsAsync(request, runtime);
        }

        public ListWorkflowInstanceResponse ListWorkflowInstanceWithOptions(ListWorkflowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflowInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkflowInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkflowInstanceResponse> ListWorkflowInstanceWithOptionsAsync(ListWorkflowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflowInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkflowInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkflowInstanceResponse ListWorkflowInstance(ListWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkflowInstanceWithOptions(request, runtime);
        }

        public async Task<ListWorkflowInstanceResponse> ListWorkflowInstanceAsync(ListWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkflowInstanceWithOptionsAsync(request, runtime);
        }

        public RerunJobResponse RerunJobWithOptions(RerunJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTime))
            {
                body["DataTime"] = request.DataTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RerunJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RerunJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RerunJobResponse> RerunJobWithOptionsAsync(RerunJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTime))
            {
                body["DataTime"] = request.DataTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RerunJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RerunJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RerunJobResponse RerunJob(RerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RerunJobWithOptions(request, runtime);
        }

        public async Task<RerunJobResponse> RerunJobAsync(RerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RerunJobWithOptionsAsync(request, runtime);
        }

        public RetryJobInstanceResponse RetryJobInstanceWithOptions(RetryJobInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobInstanceId))
            {
                query["JobInstanceId"] = request.JobInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryJobInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryJobInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RetryJobInstanceResponse> RetryJobInstanceWithOptionsAsync(RetryJobInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobInstanceId))
            {
                query["JobInstanceId"] = request.JobInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryJobInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryJobInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RetryJobInstanceResponse RetryJobInstance(RetryJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryJobInstanceWithOptions(request, runtime);
        }

        public async Task<RetryJobInstanceResponse> RetryJobInstanceAsync(RetryJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryJobInstanceWithOptionsAsync(request, runtime);
        }

        public RevokePermissionResponse RevokePermissionWithOptions(RevokePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePermission",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokePermissionResponse> RevokePermissionWithOptionsAsync(RevokePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePermission",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokePermissionResponse RevokePermission(RevokePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokePermissionWithOptions(request, runtime);
        }

        public async Task<RevokePermissionResponse> RevokePermissionAsync(RevokePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokePermissionWithOptionsAsync(request, runtime);
        }

        public SetJobInstanceSuccessResponse SetJobInstanceSuccessWithOptions(SetJobInstanceSuccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobInstanceId))
            {
                query["JobInstanceId"] = request.JobInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetJobInstanceSuccess",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetJobInstanceSuccessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetJobInstanceSuccessResponse> SetJobInstanceSuccessWithOptionsAsync(SetJobInstanceSuccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobInstanceId))
            {
                query["JobInstanceId"] = request.JobInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetJobInstanceSuccess",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetJobInstanceSuccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetJobInstanceSuccessResponse SetJobInstanceSuccess(SetJobInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetJobInstanceSuccessWithOptions(request, runtime);
        }

        public async Task<SetJobInstanceSuccessResponse> SetJobInstanceSuccessAsync(SetJobInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetJobInstanceSuccessWithOptionsAsync(request, runtime);
        }

        public SetWfInstanceSuccessResponse SetWfInstanceSuccessWithOptions(SetWfInstanceSuccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WfInstanceId))
            {
                query["WfInstanceId"] = request.WfInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWfInstanceSuccess",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWfInstanceSuccessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetWfInstanceSuccessResponse> SetWfInstanceSuccessWithOptionsAsync(SetWfInstanceSuccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WfInstanceId))
            {
                query["WfInstanceId"] = request.WfInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWfInstanceSuccess",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWfInstanceSuccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetWfInstanceSuccessResponse SetWfInstanceSuccess(SetWfInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWfInstanceSuccessWithOptions(request, runtime);
        }

        public async Task<SetWfInstanceSuccessResponse> SetWfInstanceSuccessAsync(SetWfInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWfInstanceSuccessWithOptionsAsync(request, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateJobResponse UpdateJobWithOptions(UpdateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["ClassName"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerSize))
            {
                body["ConsumerSize"] = request.ConsumerSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["ContactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataOffset))
            {
                body["DataOffset"] = request.DataOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatcherSize))
            {
                body["DispatcherSize"] = request.DispatcherSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteMode))
            {
                body["ExecuteMode"] = request.ExecuteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailEnable))
            {
                body["FailEnable"] = request.FailEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailTimes))
            {
                body["FailTimes"] = request.FailTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissWorkerEnable))
            {
                body["MissWorkerEnable"] = request.MissWorkerEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueSize))
            {
                body["QueueSize"] = request.QueueSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannel))
            {
                body["SendChannel"] = request.SendChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessNoticeEnable))
            {
                body["SuccessNoticeEnable"] = request.SuccessNoticeEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAttemptInterval))
            {
                body["TaskAttemptInterval"] = request.TaskAttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMaxAttempt))
            {
                body["TaskMaxAttempt"] = request.TaskMaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutEnable))
            {
                body["TimeoutEnable"] = request.TimeoutEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutKillEnable))
            {
                body["TimeoutKillEnable"] = request.TimeoutKillEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateJobResponse> UpdateJobWithOptionsAsync(UpdateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                body["ClassName"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerSize))
            {
                body["ConsumerSize"] = request.ConsumerSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["ContactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataOffset))
            {
                body["DataOffset"] = request.DataOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatcherSize))
            {
                body["DispatcherSize"] = request.DispatcherSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteMode))
            {
                body["ExecuteMode"] = request.ExecuteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailEnable))
            {
                body["FailEnable"] = request.FailEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailTimes))
            {
                body["FailTimes"] = request.FailTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissWorkerEnable))
            {
                body["MissWorkerEnable"] = request.MissWorkerEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueSize))
            {
                body["QueueSize"] = request.QueueSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannel))
            {
                body["SendChannel"] = request.SendChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuccessNoticeEnable))
            {
                body["SuccessNoticeEnable"] = request.SuccessNoticeEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAttemptInterval))
            {
                body["TaskAttemptInterval"] = request.TaskAttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMaxAttempt))
            {
                body["TaskMaxAttempt"] = request.TaskMaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutEnable))
            {
                body["TimeoutEnable"] = request.TimeoutEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutKillEnable))
            {
                body["TimeoutKillEnable"] = request.TimeoutKillEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateJobWithOptions(request, runtime);
        }

        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateJobWithOptionsAsync(request, runtime);
        }

        public UpdateWorkflowResponse UpdateWorkflowWithOptions(UpdateWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                body["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateWorkflowResponse> UpdateWorkflowWithOptionsAsync(UpdateWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                body["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkflow",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkflowWithOptions(request, runtime);
        }

        public async Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkflowWithOptionsAsync(request, runtime);
        }

        public UpdateWorkflowDagResponse UpdateWorkflowDagWithOptions(UpdateWorkflowDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagJson))
            {
                body["DagJson"] = request.DagJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                body["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkflowDag",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkflowDagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateWorkflowDagResponse> UpdateWorkflowDagWithOptionsAsync(UpdateWorkflowDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagJson))
            {
                body["DagJson"] = request.DagJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                body["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                body["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkflowDag",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkflowDagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateWorkflowDagResponse UpdateWorkflowDag(UpdateWorkflowDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkflowDagWithOptions(request, runtime);
        }

        public async Task<UpdateWorkflowDagResponse> UpdateWorkflowDagAsync(UpdateWorkflowDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkflowDagWithOptionsAsync(request, runtime);
        }

    }
}
