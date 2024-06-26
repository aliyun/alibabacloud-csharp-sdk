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
         * @summary Deletes multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Deletes multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Deletes multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Deletes multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary The additional information that is returned.
         *
         * @param request BatchDeleteRouteStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteRouteStrategyResponse
         */
        public BatchDeleteRouteStrategyResponse BatchDeleteRouteStrategyWithOptions(BatchDeleteRouteStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchDeleteRouteStrategy",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteRouteStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request BatchDeleteRouteStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteRouteStrategyResponse
         */
        public async Task<BatchDeleteRouteStrategyResponse> BatchDeleteRouteStrategyWithOptionsAsync(BatchDeleteRouteStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "BatchDeleteRouteStrategy",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteRouteStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request BatchDeleteRouteStrategyRequest
         * @return BatchDeleteRouteStrategyResponse
         */
        public BatchDeleteRouteStrategyResponse BatchDeleteRouteStrategy(BatchDeleteRouteStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteRouteStrategyWithOptions(request, runtime);
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request BatchDeleteRouteStrategyRequest
         * @return BatchDeleteRouteStrategyResponse
         */
        public async Task<BatchDeleteRouteStrategyResponse> BatchDeleteRouteStrategyAsync(BatchDeleteRouteStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteRouteStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Disables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Disables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Disables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Enables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Enables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Enables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Enables multiple jobs at a time.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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

        /**
         * @summary Creates an application group. The AppKey is returned.
         *
         * @param request CreateAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppGroupResponse
         */
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

        /**
         * @summary Creates an application group. The AppKey is returned.
         *
         * @param request CreateAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppGroupResponse
         */
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

        /**
         * @summary Creates an application group. The AppKey is returned.
         *
         * @param request CreateAppGroupRequest
         * @return CreateAppGroupResponse
         */
        public CreateAppGroupResponse CreateAppGroup(CreateAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates an application group. The AppKey is returned.
         *
         * @param request CreateAppGroupRequest
         * @return CreateAppGroupResponse
         */
        public async Task<CreateAppGroupResponse> CreateAppGroupAsync(CreateAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a job and obtains the job ID.
         *
         * @param request CreateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateJobResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
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

        /**
         * @summary Creates a job and obtains the job ID.
         *
         * @param request CreateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateJobResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
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

        /**
         * @summary Creates a job and obtains the job ID.
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
         * @summary Creates a job and obtains the job ID.
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
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNamespaceResponse
         */
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

        /**
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNamespaceResponse
         */
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

        /**
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @return CreateNamespaceResponse
         */
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        /**
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @return CreateNamespaceResponse
         */
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a routing policy.
         *
         * @param request CreateRouteStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRouteStrategyResponse
         */
        public CreateRouteStrategyResponse CreateRouteStrategyWithOptions(CreateRouteStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                query["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRouteStrategy",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRouteStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a routing policy.
         *
         * @param request CreateRouteStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRouteStrategyResponse
         */
        public async Task<CreateRouteStrategyResponse> CreateRouteStrategyWithOptionsAsync(CreateRouteStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyContent))
            {
                query["StrategyContent"] = request.StrategyContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRouteStrategy",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRouteStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a routing policy.
         *
         * @param request CreateRouteStrategyRequest
         * @return CreateRouteStrategyResponse
         */
        public CreateRouteStrategyResponse CreateRouteStrategy(CreateRouteStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRouteStrategyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a routing policy.
         *
         * @param request CreateRouteStrategyRequest
         * @return CreateRouteStrategyResponse
         */
        public async Task<CreateRouteStrategyResponse> CreateRouteStrategyAsync(CreateRouteStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRouteStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a workflow. By default, the created workflow is disabled. After you update the directed acyclic graph (DAG) of the workflow, you must manually or call the corresponding operation to enable the workflow. You can call this operation only in the professional edition.
         *
         * @param request CreateWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkflowResponse
         */
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

        /**
         * @summary Creates a workflow. By default, the created workflow is disabled. After you update the directed acyclic graph (DAG) of the workflow, you must manually or call the corresponding operation to enable the workflow. You can call this operation only in the professional edition.
         *
         * @param request CreateWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkflowResponse
         */
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

        /**
         * @summary Creates a workflow. By default, the created workflow is disabled. After you update the directed acyclic graph (DAG) of the workflow, you must manually or call the corresponding operation to enable the workflow. You can call this operation only in the professional edition.
         *
         * @param request CreateWorkflowRequest
         * @return CreateWorkflowResponse
         */
        public CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkflowWithOptions(request, runtime);
        }

        /**
         * @summary Creates a workflow. By default, the created workflow is disabled. After you update the directed acyclic graph (DAG) of the workflow, you must manually or call the corresponding operation to enable the workflow. You can call this operation only in the professional edition.
         *
         * @param request CreateWorkflowRequest
         * @return CreateWorkflowResponse
         */
        public async Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkflowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request DeleteAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppGroupResponse
         */
        public DeleteAppGroupResponse DeleteAppGroupWithOptions(DeleteAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteJobs))
            {
                query["DeleteJobs"] = request.DeleteJobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "DeleteAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request DeleteAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppGroupResponse
         */
        public async Task<DeleteAppGroupResponse> DeleteAppGroupWithOptionsAsync(DeleteAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteJobs))
            {
                query["DeleteJobs"] = request.DeleteJobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "DeleteAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request DeleteAppGroupRequest
         * @return DeleteAppGroupResponse
         */
        public DeleteAppGroupResponse DeleteAppGroup(DeleteAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppGroupWithOptions(request, runtime);
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request DeleteAppGroupRequest
         * @return DeleteAppGroupResponse
         */
        public async Task<DeleteAppGroupResponse> DeleteAppGroupAsync(DeleteAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a specified job.
         *
         * @param request DeleteJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
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

        /**
         * @summary Deletes a specified job.
         *
         * @param request DeleteJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
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

        /**
         * @summary Deletes a specified job.
         *
         * @param request DeleteJobRequest
         * @return DeleteJobResponse
         */
        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a specified job.
         *
         * @param request DeleteJobRequest
         * @return DeleteJobResponse
         */
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a routing policy.
         *
         * @param request DeleteRouteStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRouteStrategyResponse
         */
        public DeleteRouteStrategyResponse DeleteRouteStrategyWithOptions(DeleteRouteStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "DeleteRouteStrategy",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a routing policy.
         *
         * @param request DeleteRouteStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRouteStrategyResponse
         */
        public async Task<DeleteRouteStrategyResponse> DeleteRouteStrategyWithOptionsAsync(DeleteRouteStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "DeleteRouteStrategy",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a routing policy.
         *
         * @param request DeleteRouteStrategyRequest
         * @return DeleteRouteStrategyResponse
         */
        public DeleteRouteStrategyResponse DeleteRouteStrategy(DeleteRouteStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteStrategyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a routing policy.
         *
         * @param request DeleteRouteStrategyRequest
         * @return DeleteRouteStrategyResponse
         */
        public async Task<DeleteRouteStrategyResponse> DeleteRouteStrategyAsync(DeleteRouteStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a workflow.
         *
         * @param request DeleteWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkflowResponse
         */
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

        /**
         * @summary Deletes a workflow.
         *
         * @param request DeleteWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkflowResponse
         */
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

        /**
         * @summary Deletes a workflow.
         *
         * @param request DeleteWorkflowRequest
         * @return DeleteWorkflowResponse
         */
        public DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkflowWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a workflow.
         *
         * @param request DeleteWorkflowRequest
         * @return DeleteWorkflowResponse
         */
        public async Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkflowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Returns available regions.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary Returns available regions.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary Returns available regions.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @summary Returns available regions.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Designates machines.
         *
         * @param request DesignateWorkersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DesignateWorkersResponse
         */
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

        /**
         * @summary Designates machines.
         *
         * @param request DesignateWorkersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DesignateWorkersResponse
         */
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

        /**
         * @summary Designates machines.
         *
         * @param request DesignateWorkersRequest
         * @return DesignateWorkersResponse
         */
        public DesignateWorkersResponse DesignateWorkers(DesignateWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DesignateWorkersWithOptions(request, runtime);
        }

        /**
         * @summary Designates machines.
         *
         * @param request DesignateWorkersRequest
         * @return DesignateWorkersResponse
         */
        public async Task<DesignateWorkersResponse> DesignateWorkersAsync(DesignateWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DesignateWorkersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a job.
         *
         * @param request DisableJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableJobResponse
         */
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

        /**
         * @summary Disables a job.
         *
         * @param request DisableJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableJobResponse
         */
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

        /**
         * @summary Disables a job.
         *
         * @param request DisableJobRequest
         * @return DisableJobResponse
         */
        public DisableJobResponse DisableJob(DisableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableJobWithOptions(request, runtime);
        }

        /**
         * @summary Disables a job.
         *
         * @param request DisableJobRequest
         * @return DisableJobResponse
         */
        public async Task<DisableJobResponse> DisableJobAsync(DisableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a specified workflow.
         *
         * @param request DisableWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableWorkflowResponse
         */
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

        /**
         * @summary Disables a specified workflow.
         *
         * @param request DisableWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableWorkflowResponse
         */
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

        /**
         * @summary Disables a specified workflow.
         *
         * @param request DisableWorkflowRequest
         * @return DisableWorkflowResponse
         */
        public DisableWorkflowResponse DisableWorkflow(DisableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableWorkflowWithOptions(request, runtime);
        }

        /**
         * @summary Disables a specified workflow.
         *
         * @param request DisableWorkflowRequest
         * @return DisableWorkflowResponse
         */
        public async Task<DisableWorkflowResponse> DisableWorkflowAsync(DisableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableWorkflowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a job.
         *
         * @param request EnableJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableJobResponse
         */
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

        /**
         * @summary Enables a job.
         *
         * @param request EnableJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableJobResponse
         */
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

        /**
         * @summary Enables a job.
         *
         * @param request EnableJobRequest
         * @return EnableJobResponse
         */
        public EnableJobResponse EnableJob(EnableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableJobWithOptions(request, runtime);
        }

        /**
         * @summary Enables a job.
         *
         * @param request EnableJobRequest
         * @return EnableJobResponse
         */
        public async Task<EnableJobResponse> EnableJobAsync(EnableJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a specified workflow.
         *
         * @param request EnableWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableWorkflowResponse
         */
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

        /**
         * @summary Enables a specified workflow.
         *
         * @param request EnableWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableWorkflowResponse
         */
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

        /**
         * @summary Enables a specified workflow.
         *
         * @param request EnableWorkflowRequest
         * @return EnableWorkflowResponse
         */
        public EnableWorkflowResponse EnableWorkflow(EnableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableWorkflowWithOptions(request, runtime);
        }

        /**
         * @summary Enables a specified workflow.
         *
         * @param request EnableWorkflowRequest
         * @return EnableWorkflowResponse
         */
        public async Task<EnableWorkflowResponse> EnableWorkflowAsync(EnableWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableWorkflowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Triggers a job to immediately run once.
         *
         * @description > The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
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
         * @summary Triggers a job to immediately run once.
         *
         * @description > The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
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
         * @summary Triggers a job to immediately run once.
         *
         * @description > The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
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
         * @summary Triggers a job to immediately run once.
         *
         * @description > The combination of the `JobID` and `ScheduleTime` parameters serves as a unique index. Therefore, after the ExecuteJob operation is called to run a job once, a sleep for one second is required before the ExecuteJob operation is called to run the job again. Otherwise, the job may fail.
         *
         * @param request ExecuteJobRequest
         * @return ExecuteJobResponse
         */
        public async Task<ExecuteJobResponse> ExecuteJobAsync(ExecuteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Immediately triggers a workflow.
         *
         * @param request ExecuteWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteWorkflowResponse
         */
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

        /**
         * @summary Immediately triggers a workflow.
         *
         * @param request ExecuteWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteWorkflowResponse
         */
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

        /**
         * @summary Immediately triggers a workflow.
         *
         * @param request ExecuteWorkflowRequest
         * @return ExecuteWorkflowResponse
         */
        public ExecuteWorkflowResponse ExecuteWorkflow(ExecuteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteWorkflowWithOptions(request, runtime);
        }

        /**
         * @summary Immediately triggers a workflow.
         *
         * @param request ExecuteWorkflowRequest
         * @return ExecuteWorkflowResponse
         */
        public async Task<ExecuteWorkflowResponse> ExecuteWorkflowAsync(ExecuteWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteWorkflowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The configuration of the alert. The value is a JSON string. For more information, see **the additional information about response parameters below this table**.
         *
         * @param request GetAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppGroupResponse
         */
        public GetAppGroupResponse GetAppGroupWithOptions(GetAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The configuration of the alert. The value is a JSON string. For more information, see **the additional information about response parameters below this table**.
         *
         * @param request GetAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppGroupResponse
         */
        public async Task<GetAppGroupResponse> GetAppGroupWithOptionsAsync(GetAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The configuration of the alert. The value is a JSON string. For more information, see **the additional information about response parameters below this table**.
         *
         * @param request GetAppGroupRequest
         * @return GetAppGroupResponse
         */
        public GetAppGroupResponse GetAppGroup(GetAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppGroupWithOptions(request, runtime);
        }

        /**
         * @summary The configuration of the alert. The value is a JSON string. For more information, see **the additional information about response parameters below this table**.
         *
         * @param request GetAppGroupRequest
         * @return GetAppGroupResponse
         */
        public async Task<GetAppGroupResponse> GetAppGroupAsync(GetAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a job based on the job ID. In most cases, the obtained information is used to update jobs.
         *
         * @param request GetJobInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInfoResponse
         */
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

        /**
         * @summary Queries the details of a job based on the job ID. In most cases, the obtained information is used to update jobs.
         *
         * @param request GetJobInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInfoResponse
         */
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

        /**
         * @summary Queries the details of a job based on the job ID. In most cases, the obtained information is used to update jobs.
         *
         * @param request GetJobInfoRequest
         * @return GetJobInfoResponse
         */
        public GetJobInfoResponse GetJobInfo(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a job based on the job ID. In most cases, the obtained information is used to update jobs.
         *
         * @param request GetJobInfoRequest
         * @return GetJobInfoResponse
         */
        public async Task<GetJobInfoResponse> GetJobInfoAsync(GetJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a job instance. You can view the status and progress of the job instance.
         *
         * @param request GetJobInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInstanceResponse
         */
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

        /**
         * @summary Queries the information about a job instance. You can view the status and progress of the job instance.
         *
         * @param request GetJobInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInstanceResponse
         */
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

        /**
         * @summary Queries the information about a job instance. You can view the status and progress of the job instance.
         *
         * @param request GetJobInstanceRequest
         * @return GetJobInstanceResponse
         */
        public GetJobInstanceResponse GetJobInstance(GetJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a job instance. You can view the status and progress of the job instance.
         *
         * @param request GetJobInstanceRequest
         * @return GetJobInstanceResponse
         */
        public async Task<GetJobInstanceResponse> GetJobInstanceAsync(GetJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the most recent 10 execution instances of a job.
         *
         * @param request GetJobInstanceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInstanceListResponse
         */
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

        /**
         * @summary Queries the most recent 10 execution instances of a job.
         *
         * @param request GetJobInstanceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobInstanceListResponse
         */
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

        /**
         * @summary Queries the most recent 10 execution instances of a job.
         *
         * @param request GetJobInstanceListRequest
         * @return GetJobInstanceListResponse
         */
        public GetJobInstanceListResponse GetJobInstanceList(GetJobInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInstanceListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the most recent 10 execution instances of a job.
         *
         * @param request GetJobInstanceListRequest
         * @return GetJobInstanceListResponse
         */
        public async Task<GetJobInstanceListResponse> GetJobInstanceListAsync(GetJobInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInstanceListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the operational logs of a job. You can call this operation only in the professional edition.
         *
         * @param request GetLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogResponse
         */
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

        /**
         * @summary Queries the operational logs of a job. You can call this operation only in the professional edition.
         *
         * @param request GetLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogResponse
         */
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

        /**
         * @summary Queries the operational logs of a job. You can call this operation only in the professional edition.
         *
         * @param request GetLogRequest
         * @return GetLogResponse
         */
        public GetLogResponse GetLog(GetLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the operational logs of a job. You can call this operation only in the professional edition.
         *
         * @param request GetLogRequest
         * @return GetLogResponse
         */
        public async Task<GetLogResponse> GetLogAsync(GetLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询概览数据信息
         *
         * @param request GetOverviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOverviewResponse
         */
        public GetOverviewResponse GetOverviewWithOptions(GetOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOverview",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOverviewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询概览数据信息
         *
         * @param request GetOverviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOverviewResponse
         */
        public async Task<GetOverviewResponse> GetOverviewWithOptionsAsync(GetOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceSource))
            {
                query["NamespaceSource"] = request.NamespaceSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOverview",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询概览数据信息
         *
         * @param request GetOverviewRequest
         * @return GetOverviewResponse
         */
        public GetOverviewResponse GetOverview(GetOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOverviewWithOptions(request, runtime);
        }

        /**
         * @summary 查询概览数据信息
         *
         * @param request GetOverviewRequest
         * @return GetOverviewResponse
         */
        public async Task<GetOverviewResponse> GetOverviewAsync(GetOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOverviewWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about a workflow.
         *
         * @param request GetWorkFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkFlowResponse
         */
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

        /**
         * @summary Obtains the information about a workflow.
         *
         * @param request GetWorkFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkFlowResponse
         */
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

        /**
         * @summary Obtains the information about a workflow.
         *
         * @param request GetWorkFlowRequest
         * @return GetWorkFlowResponse
         */
        public GetWorkFlowResponse GetWorkFlow(GetWorkFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkFlowWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about a workflow.
         *
         * @param request GetWorkFlowRequest
         * @return GetWorkFlowResponse
         */
        public async Task<GetWorkFlowResponse> GetWorkFlowAsync(GetWorkFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the list of workers that are connected to an application.
         *
         * @param request GetWorkerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkerListResponse
         */
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

        /**
         * @summary Obtains the list of workers that are connected to an application.
         *
         * @param request GetWorkerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkerListResponse
         */
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

        /**
         * @summary Obtains the list of workers that are connected to an application.
         *
         * @param request GetWorkerListRequest
         * @return GetWorkerListResponse
         */
        public GetWorkerListResponse GetWorkerList(GetWorkerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkerListWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the list of workers that are connected to an application.
         *
         * @param request GetWorkerListRequest
         * @return GetWorkerListResponse
         */
        public async Task<GetWorkerListResponse> GetWorkerListAsync(GetWorkerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkerListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a specified workflow instance, including the state of the workflow instance, the state of each job instance, and the dependencies between job instances. You can call this operation only in the professional edition.
         *
         * @param request GetWorkflowInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkflowInstanceResponse
         */
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

        /**
         * @summary Queries the details of a specified workflow instance, including the state of the workflow instance, the state of each job instance, and the dependencies between job instances. You can call this operation only in the professional edition.
         *
         * @param request GetWorkflowInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkflowInstanceResponse
         */
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

        /**
         * @summary Queries the details of a specified workflow instance, including the state of the workflow instance, the state of each job instance, and the dependencies between job instances. You can call this operation only in the professional edition.
         *
         * @param request GetWorkflowInstanceRequest
         * @return GetWorkflowInstanceResponse
         */
        public GetWorkflowInstanceResponse GetWorkflowInstance(GetWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkflowInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a specified workflow instance, including the state of the workflow instance, the state of each job instance, and the dependencies between job instances. You can call this operation only in the professional edition.
         *
         * @param request GetWorkflowInstanceRequest
         * @return GetWorkflowInstanceResponse
         */
        public async Task<GetWorkflowInstanceResponse> GetWorkflowInstanceAsync(GetWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkflowInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Grants permissions to an application group.
         *
         * @param request GrantPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantPermissionResponse
         */
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

        /**
         * @summary Grants permissions to an application group.
         *
         * @param request GrantPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantPermissionResponse
         */
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

        /**
         * @summary Grants permissions to an application group.
         *
         * @param request GrantPermissionRequest
         * @return GrantPermissionResponse
         */
        public GrantPermissionResponse GrantPermission(GrantPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Grants permissions to an application group.
         *
         * @param request GrantPermissionRequest
         * @return GrantPermissionResponse
         */
        public async Task<GrantPermissionResponse> GrantPermissionAsync(GrantPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantPermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of applications.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
         * ```xml
         * <dependency>
         *     <groupId>com.aliyun</groupId>
         *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
         *     <version>1.0.5</version>
         * </dependency>
         * ```
         *
         * @param request ListGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppGroupName))
            {
                query["AppGroupName"] = request.AppGroupName;
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
                Action = "ListGroups",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of applications.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
         * ```xml
         * <dependency>
         *     <groupId>com.aliyun</groupId>
         *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
         *     <version>1.0.5</version>
         * </dependency>
         * ```
         *
         * @param request ListGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppGroupName))
            {
                query["AppGroupName"] = request.AppGroupName;
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
                Action = "ListGroups",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of applications.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
         * ```xml
         * <dependency>
         *     <groupId>com.aliyun</groupId>
         *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
         *     <version>1.0.5</version>
         * </dependency>
         * ```
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
         * @summary Queries a list of applications.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
         * ```xml
         * <dependency>
         *     <groupId>com.aliyun</groupId>
         *     <artifactId>aliyun-java-sdk-schedulerx2</artifactId>
         *     <version>1.0.5</version>
         * </dependency>
         * ```
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
         * @summary Queries jobs.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Queries jobs.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Queries jobs.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Queries jobs.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Queries namespaces.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
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
                Action = "ListNamespaces",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries namespaces.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
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
                Action = "ListNamespaces",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries namespaces.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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
         * @summary Queries namespaces.
         *
         * @description Before you call this operation, you must add the following dependency to the pom.xml file:
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

        /**
         * @summary Queries the execution history of a workflow. You can call this operation only in the professional edition.
         *
         * @param request ListWorkflowInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkflowInstanceResponse
         */
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

        /**
         * @summary Queries the execution history of a workflow. You can call this operation only in the professional edition.
         *
         * @param request ListWorkflowInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkflowInstanceResponse
         */
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

        /**
         * @summary Queries the execution history of a workflow. You can call this operation only in the professional edition.
         *
         * @param request ListWorkflowInstanceRequest
         * @return ListWorkflowInstanceResponse
         */
        public ListWorkflowInstanceResponse ListWorkflowInstance(ListWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkflowInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the execution history of a workflow. You can call this operation only in the professional edition.
         *
         * @param request ListWorkflowInstanceRequest
         * @return ListWorkflowInstanceResponse
         */
        public async Task<ListWorkflowInstanceResponse> ListWorkflowInstanceAsync(ListWorkflowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkflowInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Reruns a job to obtain the historical data of the job. You can call this operation only in the professional edition.
         *
         * @param request RerunJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RerunJobResponse
         */
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

        /**
         * @summary Reruns a job to obtain the historical data of the job. You can call this operation only in the professional edition.
         *
         * @param request RerunJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RerunJobResponse
         */
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

        /**
         * @summary Reruns a job to obtain the historical data of the job. You can call this operation only in the professional edition.
         *
         * @param request RerunJobRequest
         * @return RerunJobResponse
         */
        public RerunJobResponse RerunJob(RerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RerunJobWithOptions(request, runtime);
        }

        /**
         * @summary Reruns a job to obtain the historical data of the job. You can call this operation only in the professional edition.
         *
         * @param request RerunJobRequest
         * @return RerunJobResponse
         */
        public async Task<RerunJobResponse> RerunJobAsync(RerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RerunJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Reruns a successful or failed job instance. You can call this operation only in the professional edition.
         *
         * @param request RetryJobInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryJobInstanceResponse
         */
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

        /**
         * @summary Reruns a successful or failed job instance. You can call this operation only in the professional edition.
         *
         * @param request RetryJobInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryJobInstanceResponse
         */
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

        /**
         * @summary Reruns a successful or failed job instance. You can call this operation only in the professional edition.
         *
         * @param request RetryJobInstanceRequest
         * @return RetryJobInstanceResponse
         */
        public RetryJobInstanceResponse RetryJobInstance(RetryJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryJobInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Reruns a successful or failed job instance. You can call this operation only in the professional edition.
         *
         * @param request RetryJobInstanceRequest
         * @return RetryJobInstanceResponse
         */
        public async Task<RetryJobInstanceResponse> RetryJobInstanceAsync(RetryJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryJobInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Revokes the permissions that are granted to an Alibaba Cloud Resource Access Management (RAM) user.
         *
         * @param request RevokePermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokePermissionResponse
         */
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

        /**
         * @summary Revokes the permissions that are granted to an Alibaba Cloud Resource Access Management (RAM) user.
         *
         * @param request RevokePermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokePermissionResponse
         */
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

        /**
         * @summary Revokes the permissions that are granted to an Alibaba Cloud Resource Access Management (RAM) user.
         *
         * @param request RevokePermissionRequest
         * @return RevokePermissionResponse
         */
        public RevokePermissionResponse RevokePermission(RevokePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokePermissionWithOptions(request, runtime);
        }

        /**
         * @summary Revokes the permissions that are granted to an Alibaba Cloud Resource Access Management (RAM) user.
         *
         * @param request RevokePermissionRequest
         * @return RevokePermissionResponse
         */
        public async Task<RevokePermissionResponse> RevokePermissionAsync(RevokePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokePermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Forcibly sets the state of a job instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetJobInstanceSuccessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetJobInstanceSuccessResponse
         */
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

        /**
         * @summary Forcibly sets the state of a job instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetJobInstanceSuccessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetJobInstanceSuccessResponse
         */
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

        /**
         * @summary Forcibly sets the state of a job instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetJobInstanceSuccessRequest
         * @return SetJobInstanceSuccessResponse
         */
        public SetJobInstanceSuccessResponse SetJobInstanceSuccess(SetJobInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetJobInstanceSuccessWithOptions(request, runtime);
        }

        /**
         * @summary Forcibly sets the state of a job instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetJobInstanceSuccessRequest
         * @return SetJobInstanceSuccessResponse
         */
        public async Task<SetJobInstanceSuccessResponse> SetJobInstanceSuccessAsync(SetJobInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetJobInstanceSuccessWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Forcibly sets the state of a workflow instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetWfInstanceSuccessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetWfInstanceSuccessResponse
         */
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

        /**
         * @summary Forcibly sets the state of a workflow instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetWfInstanceSuccessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetWfInstanceSuccessResponse
         */
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

        /**
         * @summary Forcibly sets the state of a workflow instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetWfInstanceSuccessRequest
         * @return SetWfInstanceSuccessResponse
         */
        public SetWfInstanceSuccessResponse SetWfInstanceSuccess(SetWfInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWfInstanceSuccessWithOptions(request, runtime);
        }

        /**
         * @summary Forcibly sets the state of a workflow instance to successful. You can call this operation only in the professional edition.
         *
         * @param request SetWfInstanceSuccessRequest
         * @return SetWfInstanceSuccessResponse
         */
        public async Task<SetWfInstanceSuccessResponse> SetWfInstanceSuccessAsync(SetWfInstanceSuccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWfInstanceSuccessWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Stops a job instance in the running state.
         *
         * @param request StopInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopInstanceResponse
         */
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

        /**
         * @summary Stops a job instance in the running state.
         *
         * @param request StopInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopInstanceResponse
         */
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

        /**
         * @summary Stops a job instance in the running state.
         *
         * @param request StopInstanceRequest
         * @return StopInstanceResponse
         */
        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Stops a job instance in the running state.
         *
         * @param request StopInstanceRequest
         * @return StopInstanceResponse
         */
        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request UpdateAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppGroupResponse
         */
        public UpdateAppGroupResponse UpdateAppGroupWithOptions(UpdateAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "UpdateAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request UpdateAppGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppGroupResponse
         */
        public async Task<UpdateAppGroupResponse> UpdateAppGroupWithOptionsAsync(UpdateAppGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
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
                Action = "UpdateAppGroup",
                Version = "2019-04-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request UpdateAppGroupRequest
         * @return UpdateAppGroupResponse
         */
        public UpdateAppGroupResponse UpdateAppGroup(UpdateAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppGroupWithOptions(request, runtime);
        }

        /**
         * @summary The additional information that is returned.
         *
         * @param request UpdateAppGroupRequest
         * @return UpdateAppGroupResponse
         */
        public async Task<UpdateAppGroupResponse> UpdateAppGroupAsync(UpdateAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the configuration information about a job. By default, you need to call the GetJobInfo operation to obtain the original configuration of the job before you call this operation to modify the configuration as required.
         *
         * @param request UpdateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateJobResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDispatchMode))
            {
                body["TaskDispatchMode"] = request.TaskDispatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMaxAttempt))
            {
                body["TaskMaxAttempt"] = request.TaskMaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["Template"] = request.Template;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
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

        /**
         * @summary Updates the configuration information about a job. By default, you need to call the GetJobInfo operation to obtain the original configuration of the job before you call this operation to modify the configuration as required.
         *
         * @param request UpdateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateJobResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDispatchMode))
            {
                body["TaskDispatchMode"] = request.TaskDispatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMaxAttempt))
            {
                body["TaskMaxAttempt"] = request.TaskMaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["Template"] = request.Template;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
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

        /**
         * @summary Updates the configuration information about a job. By default, you need to call the GetJobInfo operation to obtain the original configuration of the job before you call this operation to modify the configuration as required.
         *
         * @param request UpdateJobRequest
         * @return UpdateJobResponse
         */
        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateJobWithOptions(request, runtime);
        }

        /**
         * @summary Updates the configuration information about a job. By default, you need to call the GetJobInfo operation to obtain the original configuration of the job before you call this operation to modify the configuration as required.
         *
         * @param request UpdateJobRequest
         * @return UpdateJobResponse
         */
        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the basic information about a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkflowResponse
         */
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

        /**
         * @summary Updates the basic information about a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkflowResponse
         */
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

        /**
         * @summary Updates the basic information about a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowRequest
         * @return UpdateWorkflowResponse
         */
        public UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkflowWithOptions(request, runtime);
        }

        /**
         * @summary Updates the basic information about a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowRequest
         * @return UpdateWorkflowResponse
         */
        public async Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkflowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the nodes and dependencies of a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowDagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkflowDagResponse
         */
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

        /**
         * @summary Modifies the nodes and dependencies of a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowDagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkflowDagResponse
         */
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

        /**
         * @summary Modifies the nodes and dependencies of a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowDagRequest
         * @return UpdateWorkflowDagResponse
         */
        public UpdateWorkflowDagResponse UpdateWorkflowDag(UpdateWorkflowDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkflowDagWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the nodes and dependencies of a workflow. You can call this operation only in the professional edition.
         *
         * @param request UpdateWorkflowDagRequest
         * @return UpdateWorkflowDagResponse
         */
        public async Task<UpdateWorkflowDagResponse> UpdateWorkflowDagAsync(UpdateWorkflowDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkflowDagWithOptionsAsync(request, runtime);
        }

    }
}
