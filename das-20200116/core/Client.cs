// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DAS20200116.Models;

namespace AlibabaCloud.SDK.DAS20200116
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "das.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("das", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request AddHDMInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddHDMInstanceResponse
         */
        public AddHDMInstanceResponse AddHDMInstanceWithOptions(AddHDMInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlushAccount))
            {
                query["FlushAccount"] = request.FlushAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAlias))
            {
                query["InstanceAlias"] = request.InstanceAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddHDMInstance",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHDMInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request AddHDMInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddHDMInstanceResponse
         */
        public async Task<AddHDMInstanceResponse> AddHDMInstanceWithOptionsAsync(AddHDMInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlushAccount))
            {
                query["FlushAccount"] = request.FlushAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAlias))
            {
                query["InstanceAlias"] = request.InstanceAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddHDMInstance",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHDMInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request AddHDMInstanceRequest
          * @return AddHDMInstanceResponse
         */
        public AddHDMInstanceResponse AddHDMInstance(AddHDMInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddHDMInstanceWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request AddHDMInstanceRequest
          * @return AddHDMInstanceResponse
         */
        public async Task<AddHDMInstanceResponse> AddHDMInstanceAsync(AddHDMInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddHDMInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. You use an ADAM stress testing task to check whether you need to scale up or scale out your database instance to handle workloads during peak hours. For more information, see [Intelligent Stress Testing](~~155068~~).
          * Make sure that your database instances meet the following requirements:
          * *   The source instance supports the following database engines: ApsaraDB RDS for MySQL on High-availability Edition or Enterprise Edition, and PolarDB for MySQL on Cluster Edition or X-Engine.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The database instance is connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is activated for the source and destination database instances. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateAdamBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAdamBenchTaskResponse
         */
        public CreateAdamBenchTaskResponse CreateAdamBenchTaskWithOptions(CreateAdamBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstInstanceId))
            {
                query["DstInstanceId"] = request.DstInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperAccount))
            {
                query["DstSuperAccount"] = request.DstSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperPassword))
            {
                query["DstSuperPassword"] = request.DstSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDuration))
            {
                query["RequestDuration"] = request.RequestDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestStartTime))
            {
                query["RequestStartTime"] = request.RequestStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngine))
            {
                query["SrcEngine"] = request.SrcEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineVersion))
            {
                query["SrcEngineVersion"] = request.SrcEngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcMaxQps))
            {
                query["SrcMaxQps"] = request.SrcMaxQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcMeanQps))
            {
                query["SrcMeanQps"] = request.SrcMeanQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSqlOssAddr))
            {
                query["SrcSqlOssAddr"] = request.SrcSqlOssAddr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdamBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdamBenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. You use an ADAM stress testing task to check whether you need to scale up or scale out your database instance to handle workloads during peak hours. For more information, see [Intelligent Stress Testing](~~155068~~).
          * Make sure that your database instances meet the following requirements:
          * *   The source instance supports the following database engines: ApsaraDB RDS for MySQL on High-availability Edition or Enterprise Edition, and PolarDB for MySQL on Cluster Edition or X-Engine.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The database instance is connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is activated for the source and destination database instances. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateAdamBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAdamBenchTaskResponse
         */
        public async Task<CreateAdamBenchTaskResponse> CreateAdamBenchTaskWithOptionsAsync(CreateAdamBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstInstanceId))
            {
                query["DstInstanceId"] = request.DstInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperAccount))
            {
                query["DstSuperAccount"] = request.DstSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperPassword))
            {
                query["DstSuperPassword"] = request.DstSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDuration))
            {
                query["RequestDuration"] = request.RequestDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestStartTime))
            {
                query["RequestStartTime"] = request.RequestStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngine))
            {
                query["SrcEngine"] = request.SrcEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcEngineVersion))
            {
                query["SrcEngineVersion"] = request.SrcEngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcMaxQps))
            {
                query["SrcMaxQps"] = request.SrcMaxQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcMeanQps))
            {
                query["SrcMeanQps"] = request.SrcMeanQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSqlOssAddr))
            {
                query["SrcSqlOssAddr"] = request.SrcSqlOssAddr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdamBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdamBenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. You use an ADAM stress testing task to check whether you need to scale up or scale out your database instance to handle workloads during peak hours. For more information, see [Intelligent Stress Testing](~~155068~~).
          * Make sure that your database instances meet the following requirements:
          * *   The source instance supports the following database engines: ApsaraDB RDS for MySQL on High-availability Edition or Enterprise Edition, and PolarDB for MySQL on Cluster Edition or X-Engine.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The database instance is connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is activated for the source and destination database instances. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateAdamBenchTaskRequest
          * @return CreateAdamBenchTaskResponse
         */
        public CreateAdamBenchTaskResponse CreateAdamBenchTask(CreateAdamBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAdamBenchTaskWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. You use an ADAM stress testing task to check whether you need to scale up or scale out your database instance to handle workloads during peak hours. For more information, see [Intelligent Stress Testing](~~155068~~).
          * Make sure that your database instances meet the following requirements:
          * *   The source instance supports the following database engines: ApsaraDB RDS for MySQL on High-availability Edition or Enterprise Edition, and PolarDB for MySQL on Cluster Edition or X-Engine.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The database instance is connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is activated for the source and destination database instances. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateAdamBenchTaskRequest
          * @return CreateAdamBenchTaskResponse
         */
        public async Task<CreateAdamBenchTaskResponse> CreateAdamBenchTaskAsync(CreateAdamBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAdamBenchTaskWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis Community Edition instances and performance-enhanced instances of the ApsaraDB for Redis Enhanced Edition (Tair).
          * >  Redis 7.0 is not supported. You are not allowed to use custom modules.
          *
          * @param request CreateCacheAnalysisJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCacheAnalysisJobResponse
         */
        public CreateCacheAnalysisJobResponse CreateCacheAnalysisJobWithOptions(CreateCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separators))
            {
                query["Separators"] = request.Separators;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCacheAnalysisJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis Community Edition instances and performance-enhanced instances of the ApsaraDB for Redis Enhanced Edition (Tair).
          * >  Redis 7.0 is not supported. You are not allowed to use custom modules.
          *
          * @param request CreateCacheAnalysisJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCacheAnalysisJobResponse
         */
        public async Task<CreateCacheAnalysisJobResponse> CreateCacheAnalysisJobWithOptionsAsync(CreateCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separators))
            {
                query["Separators"] = request.Separators;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCacheAnalysisJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis Community Edition instances and performance-enhanced instances of the ApsaraDB for Redis Enhanced Edition (Tair).
          * >  Redis 7.0 is not supported. You are not allowed to use custom modules.
          *
          * @param request CreateCacheAnalysisJobRequest
          * @return CreateCacheAnalysisJobResponse
         */
        public CreateCacheAnalysisJobResponse CreateCacheAnalysisJob(CreateCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCacheAnalysisJobWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis Community Edition instances and performance-enhanced instances of the ApsaraDB for Redis Enhanced Edition (Tair).
          * >  Redis 7.0 is not supported. You are not allowed to use custom modules.
          *
          * @param request CreateCacheAnalysisJobRequest
          * @return CreateCacheAnalysisJobResponse
         */
        public async Task<CreateCacheAnalysisJobResponse> CreateCacheAnalysisJobAsync(CreateCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCacheAnalysisJobWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~). Before you call this API operation, make sure that your database instances meet the following requirements:
          * *   The source database instance must be an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition instance.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The source instance and the destination instance are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is enabled for the source instance and the destination instance. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateCloudBenchTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCloudBenchTasksResponse
         */
        public CreateCloudBenchTasksResponse CreateCloudBenchTasksWithOptions(CreateCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTime))
            {
                query["BackupTime"] = request.BackupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstConnectionString))
            {
                query["DstConnectionString"] = request.DstConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstInstanceId))
            {
                query["DstInstanceId"] = request.DstInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstPort))
            {
                query["DstPort"] = request.DstPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperAccount))
            {
                query["DstSuperAccount"] = request.DstSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperPassword))
            {
                query["DstSuperPassword"] = request.DstSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobClass))
            {
                query["DtsJobClass"] = request.DtsJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndState))
            {
                query["EndState"] = request.EndState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcId))
            {
                query["GatewayVpcId"] = request.GatewayVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcIp))
            {
                query["GatewayVpcIp"] = request.GatewayVpcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDuration))
            {
                query["RequestDuration"] = request.RequestDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEndTime))
            {
                query["RequestEndTime"] = request.RequestEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestStartTime))
            {
                query["RequestStartTime"] = request.RequestStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartPressureTime))
            {
                query["SmartPressureTime"] = request.SmartPressureTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcInstanceId))
            {
                query["SrcInstanceId"] = request.SrcInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPublicIp))
            {
                query["SrcPublicIp"] = request.SrcPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperAccount))
            {
                query["SrcSuperAccount"] = request.SrcSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperPassword))
            {
                query["SrcSuperPassword"] = request.SrcSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDir))
            {
                query["WorkDir"] = request.WorkDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudBenchTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~). Before you call this API operation, make sure that your database instances meet the following requirements:
          * *   The source database instance must be an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition instance.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The source instance and the destination instance are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is enabled for the source instance and the destination instance. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateCloudBenchTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateCloudBenchTasksResponse
         */
        public async Task<CreateCloudBenchTasksResponse> CreateCloudBenchTasksWithOptionsAsync(CreateCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTime))
            {
                query["BackupTime"] = request.BackupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstConnectionString))
            {
                query["DstConnectionString"] = request.DstConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstInstanceId))
            {
                query["DstInstanceId"] = request.DstInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstPort))
            {
                query["DstPort"] = request.DstPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperAccount))
            {
                query["DstSuperAccount"] = request.DstSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperPassword))
            {
                query["DstSuperPassword"] = request.DstSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobClass))
            {
                query["DtsJobClass"] = request.DtsJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndState))
            {
                query["EndState"] = request.EndState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcId))
            {
                query["GatewayVpcId"] = request.GatewayVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcIp))
            {
                query["GatewayVpcIp"] = request.GatewayVpcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDuration))
            {
                query["RequestDuration"] = request.RequestDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEndTime))
            {
                query["RequestEndTime"] = request.RequestEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestStartTime))
            {
                query["RequestStartTime"] = request.RequestStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartPressureTime))
            {
                query["SmartPressureTime"] = request.SmartPressureTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcInstanceId))
            {
                query["SrcInstanceId"] = request.SrcInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPublicIp))
            {
                query["SrcPublicIp"] = request.SrcPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperAccount))
            {
                query["SrcSuperAccount"] = request.SrcSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperPassword))
            {
                query["SrcSuperPassword"] = request.SrcSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDir))
            {
                query["WorkDir"] = request.WorkDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudBenchTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~). Before you call this API operation, make sure that your database instances meet the following requirements:
          * *   The source database instance must be an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition instance.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The source instance and the destination instance are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is enabled for the source instance and the destination instance. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateCloudBenchTasksRequest
          * @return CreateCloudBenchTasksResponse
         */
        public CreateCloudBenchTasksResponse CreateCloudBenchTasks(CreateCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCloudBenchTasksWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~). Before you call this API operation, make sure that your database instances meet the following requirements:
          * *   The source database instance must be an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition instance.
          * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
          * *   The source instance and the destination instance are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](~~65405~~).
          * *   DAS Professional Edition is enabled for the source instance and the destination instance. For more information, see [DAS Professional Edition](~~190912~~).
          *
          * @param request CreateCloudBenchTasksRequest
          * @return CreateCloudBenchTasksResponse
         */
        public async Task<CreateCloudBenchTasksResponse> CreateCloudBenchTasksAsync(CreateCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCloudBenchTasksWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   RDS MySQL
          *     *   PolarDB for MySQL
          *     *   Redis
          *
          * @param request CreateDiagnosticReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDiagnosticReportResponse
         */
        public CreateDiagnosticReportResponse CreateDiagnosticReportWithOptions(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "CreateDiagnosticReport",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   RDS MySQL
          *     *   PolarDB for MySQL
          *     *   Redis
          *
          * @param request CreateDiagnosticReportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDiagnosticReportResponse
         */
        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportWithOptionsAsync(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "CreateDiagnosticReport",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   RDS MySQL
          *     *   PolarDB for MySQL
          *     *   Redis
          *
          * @param request CreateDiagnosticReportRequest
          * @return CreateDiagnosticReportResponse
         */
        public CreateDiagnosticReportResponse CreateDiagnosticReport(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiagnosticReportWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   RDS MySQL
          *     *   PolarDB for MySQL
          *     *   Redis
          *
          * @param request CreateDiagnosticReportRequest
          * @return CreateDiagnosticReportResponse
         */
        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportAsync(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiagnosticReportWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request CreateKillInstanceSessionTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateKillInstanceSessionTaskResponse
         */
        public CreateKillInstanceSessionTaskResponse CreateKillInstanceSessionTaskWithOptions(CreateKillInstanceSessionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUser))
            {
                query["DbUser"] = request.DbUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserPassword))
            {
                query["DbUserPassword"] = request.DbUserPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request CreateKillInstanceSessionTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateKillInstanceSessionTaskResponse
         */
        public async Task<CreateKillInstanceSessionTaskResponse> CreateKillInstanceSessionTaskWithOptionsAsync(CreateKillInstanceSessionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUser))
            {
                query["DbUser"] = request.DbUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserPassword))
            {
                query["DbUserPassword"] = request.DbUserPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request CreateKillInstanceSessionTaskRequest
          * @return CreateKillInstanceSessionTaskResponse
         */
        public CreateKillInstanceSessionTaskResponse CreateKillInstanceSessionTask(CreateKillInstanceSessionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKillInstanceSessionTaskWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request CreateKillInstanceSessionTaskRequest
          * @return CreateKillInstanceSessionTaskResponse
         */
        public async Task<CreateKillInstanceSessionTaskResponse> CreateKillInstanceSessionTaskAsync(CreateKillInstanceSessionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKillInstanceSessionTaskWithOptionsAsync(request, runtime);
        }

        public CreateKillInstanceSessionTaskWithMaintainUserResponse CreateKillInstanceSessionTaskWithMaintainUserWithOptions(CreateKillInstanceSessionTaskWithMaintainUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTaskWithMaintainUser",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskWithMaintainUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateKillInstanceSessionTaskWithMaintainUserResponse> CreateKillInstanceSessionTaskWithMaintainUserWithOptionsAsync(CreateKillInstanceSessionTaskWithMaintainUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTaskWithMaintainUser",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskWithMaintainUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateKillInstanceSessionTaskWithMaintainUserResponse CreateKillInstanceSessionTaskWithMaintainUser(CreateKillInstanceSessionTaskWithMaintainUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKillInstanceSessionTaskWithMaintainUserWithOptions(request, runtime);
        }

        public async Task<CreateKillInstanceSessionTaskWithMaintainUserResponse> CreateKillInstanceSessionTaskWithMaintainUserAsync(CreateKillInstanceSessionTaskWithMaintainUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKillInstanceSessionTaskWithMaintainUserWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request CreateQueryOptimizeTagRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateQueryOptimizeTagResponse
         */
        public CreateQueryOptimizeTagResponse CreateQueryOptimizeTagWithOptions(CreateQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIds))
            {
                query["SqlIds"] = request.SqlIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueryOptimizeTagResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request CreateQueryOptimizeTagRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateQueryOptimizeTagResponse
         */
        public async Task<CreateQueryOptimizeTagResponse> CreateQueryOptimizeTagWithOptionsAsync(CreateQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIds))
            {
                query["SqlIds"] = request.SqlIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueryOptimizeTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request CreateQueryOptimizeTagRequest
          * @return CreateQueryOptimizeTagResponse
         */
        public CreateQueryOptimizeTagResponse CreateQueryOptimizeTag(CreateQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQueryOptimizeTagWithOptions(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request CreateQueryOptimizeTagRequest
          * @return CreateQueryOptimizeTagResponse
         */
        public async Task<CreateQueryOptimizeTagResponse> CreateQueryOptimizeTagAsync(CreateQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQueryOptimizeTagWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request CreateRequestDiagnosisRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRequestDiagnosisResponse
         */
        public CreateRequestDiagnosisResponse CreateRequestDiagnosisWithOptions(CreateRequestDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRequestDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRequestDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request CreateRequestDiagnosisRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRequestDiagnosisResponse
         */
        public async Task<CreateRequestDiagnosisResponse> CreateRequestDiagnosisWithOptionsAsync(CreateRequestDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRequestDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRequestDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request CreateRequestDiagnosisRequest
          * @return CreateRequestDiagnosisResponse
         */
        public CreateRequestDiagnosisResponse CreateRequestDiagnosis(CreateRequestDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRequestDiagnosisWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request CreateRequestDiagnosisRequest
          * @return CreateRequestDiagnosisResponse
         */
        public async Task<CreateRequestDiagnosisResponse> CreateRequestDiagnosisAsync(CreateRequestDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRequestDiagnosisWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request CreateStorageAnalysisTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStorageAnalysisTaskResponse
         */
        public CreateStorageAnalysisTaskResponse CreateStorageAnalysisTaskWithOptions(CreateStorageAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStorageAnalysisTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStorageAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request CreateStorageAnalysisTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStorageAnalysisTaskResponse
         */
        public async Task<CreateStorageAnalysisTaskResponse> CreateStorageAnalysisTaskWithOptionsAsync(CreateStorageAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStorageAnalysisTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStorageAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request CreateStorageAnalysisTaskRequest
          * @return CreateStorageAnalysisTaskResponse
         */
        public CreateStorageAnalysisTaskResponse CreateStorageAnalysisTask(CreateStorageAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStorageAnalysisTaskWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request CreateStorageAnalysisTaskRequest
          * @return CreateStorageAnalysisTaskResponse
         */
        public async Task<CreateStorageAnalysisTaskResponse> CreateStorageAnalysisTaskAsync(CreateStorageAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStorageAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DeleteCloudBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCloudBenchTaskResponse
         */
        public DeleteCloudBenchTaskResponse DeleteCloudBenchTaskWithOptions(DeleteCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudBenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DeleteCloudBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteCloudBenchTaskResponse
         */
        public async Task<DeleteCloudBenchTaskResponse> DeleteCloudBenchTaskWithOptionsAsync(DeleteCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudBenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DeleteCloudBenchTaskRequest
          * @return DeleteCloudBenchTaskResponse
         */
        public DeleteCloudBenchTaskResponse DeleteCloudBenchTask(DeleteCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCloudBenchTaskWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DeleteCloudBenchTaskRequest
          * @return DeleteCloudBenchTaskResponse
         */
        public async Task<DeleteCloudBenchTaskResponse> DeleteCloudBenchTaskAsync(DeleteCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCloudBenchTaskWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](~~230665~~) operation.
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.
          *
          * @param request DeleteStopGatewayRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteStopGatewayResponse
         */
        public DeleteStopGatewayResponse DeleteStopGatewayWithOptions(DeleteStopGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStopGateway",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStopGatewayResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](~~230665~~) operation.
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.
          *
          * @param request DeleteStopGatewayRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteStopGatewayResponse
         */
        public async Task<DeleteStopGatewayResponse> DeleteStopGatewayWithOptionsAsync(DeleteStopGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStopGateway",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStopGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](~~230665~~) operation.
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.
          *
          * @param request DeleteStopGatewayRequest
          * @return DeleteStopGatewayResponse
         */
        public DeleteStopGatewayResponse DeleteStopGateway(DeleteStopGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStopGatewayWithOptions(request, runtime);
        }

        /**
          * *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](~~230665~~) operation.
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.
          *
          * @param request DeleteStopGatewayRequest
          * @return DeleteStopGatewayResponse
         */
        public async Task<DeleteStopGatewayResponse> DeleteStopGatewayAsync(DeleteStopGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStopGatewayWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeAutoScalingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAutoScalingConfigResponse
         */
        public DescribeAutoScalingConfigResponse DescribeAutoScalingConfigWithOptions(DescribeAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeAutoScalingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAutoScalingConfigResponse
         */
        public async Task<DescribeAutoScalingConfigResponse> DescribeAutoScalingConfigWithOptionsAsync(DescribeAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeAutoScalingConfigRequest
          * @return DescribeAutoScalingConfigResponse
         */
        public DescribeAutoScalingConfigResponse DescribeAutoScalingConfig(DescribeAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoScalingConfigWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeAutoScalingConfigRequest
          * @return DescribeAutoScalingConfigResponse
         */
        public async Task<DescribeAutoScalingConfigResponse> DescribeAutoScalingConfigAsync(DescribeAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoScalingConfigWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can query only the history of automatic performance scaling of ApsaraDB RDS for MySQL instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request DescribeAutoScalingHistoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAutoScalingHistoryResponse
         */
        public DescribeAutoScalingHistoryResponse DescribeAutoScalingHistoryWithOptions(DescribeAutoScalingHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can query only the history of automatic performance scaling of ApsaraDB RDS for MySQL instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request DescribeAutoScalingHistoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAutoScalingHistoryResponse
         */
        public async Task<DescribeAutoScalingHistoryResponse> DescribeAutoScalingHistoryWithOptionsAsync(DescribeAutoScalingHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can query only the history of automatic performance scaling of ApsaraDB RDS for MySQL instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request DescribeAutoScalingHistoryRequest
          * @return DescribeAutoScalingHistoryResponse
         */
        public DescribeAutoScalingHistoryResponse DescribeAutoScalingHistory(DescribeAutoScalingHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoScalingHistoryWithOptions(request, runtime);
        }

        /**
          * *   You can query only the history of automatic performance scaling of ApsaraDB RDS for MySQL instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request DescribeAutoScalingHistoryRequest
          * @return DescribeAutoScalingHistoryResponse
         */
        public async Task<DescribeAutoScalingHistoryResponse> DescribeAutoScalingHistoryAsync(DescribeAutoScalingHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoScalingHistoryWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCacheAnalysisJobResponse
         */
        public DescribeCacheAnalysisJobResponse DescribeCacheAnalysisJobWithOptions(DescribeCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "DescribeCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCacheAnalysisJobResponse
         */
        public async Task<DescribeCacheAnalysisJobResponse> DescribeCacheAnalysisJobWithOptionsAsync(DescribeCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "DescribeCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobRequest
          * @return DescribeCacheAnalysisJobResponse
         */
        public DescribeCacheAnalysisJobResponse DescribeCacheAnalysisJob(DescribeCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCacheAnalysisJobWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobRequest
          * @return DescribeCacheAnalysisJobResponse
         */
        public async Task<DescribeCacheAnalysisJobResponse> DescribeCacheAnalysisJobAsync(DescribeCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCacheAnalysisJobWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCacheAnalysisJobsResponse
         */
        public DescribeCacheAnalysisJobsResponse DescribeCacheAnalysisJobsWithOptions(DescribeCacheAnalysisJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCacheAnalysisJobs",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCacheAnalysisJobsResponse
         */
        public async Task<DescribeCacheAnalysisJobsResponse> DescribeCacheAnalysisJobsWithOptionsAsync(DescribeCacheAnalysisJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCacheAnalysisJobs",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobsRequest
          * @return DescribeCacheAnalysisJobsResponse
         */
        public DescribeCacheAnalysisJobsResponse DescribeCacheAnalysisJobs(DescribeCacheAnalysisJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCacheAnalysisJobsWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis.
          *
          * @param request DescribeCacheAnalysisJobsRequest
          * @return DescribeCacheAnalysisJobsResponse
         */
        public async Task<DescribeCacheAnalysisJobsResponse> DescribeCacheAnalysisJobsAsync(DescribeCacheAnalysisJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCacheAnalysisJobsWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudBenchTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCloudBenchTasksResponse
         */
        public DescribeCloudBenchTasksResponse DescribeCloudBenchTasksWithOptions(DescribeCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudBenchTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudBenchTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCloudBenchTasksResponse
         */
        public async Task<DescribeCloudBenchTasksResponse> DescribeCloudBenchTasksWithOptionsAsync(DescribeCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudBenchTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudBenchTasksRequest
          * @return DescribeCloudBenchTasksResponse
         */
        public DescribeCloudBenchTasksResponse DescribeCloudBenchTasks(DescribeCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudBenchTasksWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudBenchTasksRequest
          * @return DescribeCloudBenchTasksResponse
         */
        public async Task<DescribeCloudBenchTasksResponse> DescribeCloudBenchTasksAsync(DescribeCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudBenchTasksWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCloudbenchTaskResponse
         */
        public DescribeCloudbenchTaskResponse DescribeCloudbenchTaskWithOptions(DescribeCloudbenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudbenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCloudbenchTaskResponse
         */
        public async Task<DescribeCloudbenchTaskResponse> DescribeCloudbenchTaskWithOptionsAsync(DescribeCloudbenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudbenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskRequest
          * @return DescribeCloudbenchTaskResponse
         */
        public DescribeCloudbenchTaskResponse DescribeCloudbenchTask(DescribeCloudbenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudbenchTaskWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskRequest
          * @return DescribeCloudbenchTaskResponse
         */
        public async Task<DescribeCloudbenchTaskResponse> DescribeCloudbenchTaskAsync(DescribeCloudbenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudbenchTaskWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCloudbenchTaskConfigResponse
         */
        public DescribeCloudbenchTaskConfigResponse DescribeCloudbenchTaskConfigWithOptions(DescribeCloudbenchTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudbenchTaskConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCloudbenchTaskConfigResponse
         */
        public async Task<DescribeCloudbenchTaskConfigResponse> DescribeCloudbenchTaskConfigWithOptionsAsync(DescribeCloudbenchTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudbenchTaskConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskConfigRequest
          * @return DescribeCloudbenchTaskConfigResponse
         */
        public DescribeCloudbenchTaskConfigResponse DescribeCloudbenchTaskConfig(DescribeCloudbenchTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudbenchTaskConfigWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request DescribeCloudbenchTaskConfigRequest
          * @return DescribeCloudbenchTaskConfigResponse
         */
        public async Task<DescribeCloudbenchTaskConfigResponse> DescribeCloudbenchTaskConfigAsync(DescribeCloudbenchTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudbenchTaskConfigWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable to the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB for Redis
          *
          * @param request DescribeDiagnosticReportListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDiagnosticReportListResponse
         */
        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportListWithOptions(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosticReportList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable to the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB for Redis
          *
          * @param request DescribeDiagnosticReportListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDiagnosticReportListResponse
         */
        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListWithOptionsAsync(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosticReportList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable to the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB for Redis
          *
          * @param request DescribeDiagnosticReportListRequest
          * @return DescribeDiagnosticReportListResponse
         */
        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportList(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiagnosticReportListWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable to the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB for Redis
          *
          * @param request DescribeDiagnosticReportListRequest
          * @return DescribeDiagnosticReportListResponse
         */
        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListAsync(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiagnosticReportListWithOptionsAsync(request, runtime);
        }

        /**
          * This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
          *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotBigKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHotBigKeysResponse
         */
        public DescribeHotBigKeysResponse DescribeHotBigKeysWithOptions(DescribeHotBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotBigKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
          *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotBigKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHotBigKeysResponse
         */
        public async Task<DescribeHotBigKeysResponse> DescribeHotBigKeysWithOptionsAsync(DescribeHotBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotBigKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
          *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotBigKeysRequest
          * @return DescribeHotBigKeysResponse
         */
        public DescribeHotBigKeysResponse DescribeHotBigKeys(DescribeHotBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHotBigKeysWithOptions(request, runtime);
        }

        /**
          * This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
          *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotBigKeysRequest
          * @return DescribeHotBigKeysResponse
         */
        public async Task<DescribeHotBigKeysResponse> DescribeHotBigKeysAsync(DescribeHotBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHotBigKeysWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
          *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHotKeysResponse
         */
        public DescribeHotKeysResponse DescribeHotKeysWithOptions(DescribeHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
          *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHotKeysResponse
         */
        public async Task<DescribeHotKeysResponse> DescribeHotKeysWithOptionsAsync(DescribeHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
          *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotKeysRequest
          * @return DescribeHotKeysResponse
         */
        public DescribeHotKeysResponse DescribeHotKeys(DescribeHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHotKeysWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
          *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeHotKeysRequest
          * @return DescribeHotKeysResponse
         */
        public async Task<DescribeHotKeysResponse> DescribeHotKeysAsync(DescribeHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHotKeysWithOptionsAsync(request, runtime);
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeInstanceDasProRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeInstanceDasProResponse
         */
        public DescribeInstanceDasProResponse DescribeInstanceDasProWithOptions(DescribeInstanceDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDasProResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeInstanceDasProRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeInstanceDasProResponse
         */
        public async Task<DescribeInstanceDasProResponse> DescribeInstanceDasProWithOptionsAsync(DescribeInstanceDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDasProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeInstanceDasProRequest
          * @return DescribeInstanceDasProResponse
         */
        public DescribeInstanceDasProResponse DescribeInstanceDasPro(DescribeInstanceDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDasProWithOptions(request, runtime);
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DescribeInstanceDasProRequest
          * @return DescribeInstanceDasProResponse
         */
        public async Task<DescribeInstanceDasProResponse> DescribeInstanceDasProAsync(DescribeInstanceDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDasProWithOptionsAsync(request, runtime);
        }

        /**
          * The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeTopBigKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTopBigKeysResponse
         */
        public DescribeTopBigKeysResponse DescribeTopBigKeysWithOptions(DescribeTopBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopBigKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeTopBigKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTopBigKeysResponse
         */
        public async Task<DescribeTopBigKeysResponse> DescribeTopBigKeysWithOptionsAsync(DescribeTopBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopBigKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeTopBigKeysRequest
          * @return DescribeTopBigKeysResponse
         */
        public DescribeTopBigKeysResponse DescribeTopBigKeys(DescribeTopBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopBigKeysWithOptions(request, runtime);
        }

        /**
          * The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](~~129381~~) and [DescribeEngineVersion](~~95268~~).
          *
          * @param request DescribeTopBigKeysRequest
          * @return DescribeTopBigKeysResponse
         */
        public async Task<DescribeTopBigKeysResponse> DescribeTopBigKeysAsync(DescribeTopBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopBigKeysWithOptionsAsync(request, runtime);
        }

        /**
          * If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](~~95268~~) and [ModifyInstanceMinorVersion](~~129381~~).
          *
          * @param request DescribeTopHotKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTopHotKeysResponse
         */
        public DescribeTopHotKeysResponse DescribeTopHotKeysWithOptions(DescribeTopHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopHotKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](~~95268~~) and [ModifyInstanceMinorVersion](~~129381~~).
          *
          * @param request DescribeTopHotKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTopHotKeysResponse
         */
        public async Task<DescribeTopHotKeysResponse> DescribeTopHotKeysWithOptionsAsync(DescribeTopHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopHotKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](~~95268~~) and [ModifyInstanceMinorVersion](~~129381~~).
          *
          * @param request DescribeTopHotKeysRequest
          * @return DescribeTopHotKeysResponse
         */
        public DescribeTopHotKeysResponse DescribeTopHotKeys(DescribeTopHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopHotKeysWithOptions(request, runtime);
        }

        /**
          * If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
          * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
          *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
          *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
          * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](~~95268~~) and [ModifyInstanceMinorVersion](~~129381~~).
          *
          * @param request DescribeTopHotKeysRequest
          * @return DescribeTopHotKeysResponse
         */
        public async Task<DescribeTopHotKeysResponse> DescribeTopHotKeysAsync(DescribeTopHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopHotKeysWithOptionsAsync(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableAllSqlConcurrencyControlRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableAllSqlConcurrencyControlRulesResponse
         */
        public DisableAllSqlConcurrencyControlRulesResponse DisableAllSqlConcurrencyControlRulesWithOptions(DisableAllSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAllSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAllSqlConcurrencyControlRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableAllSqlConcurrencyControlRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableAllSqlConcurrencyControlRulesResponse
         */
        public async Task<DisableAllSqlConcurrencyControlRulesResponse> DisableAllSqlConcurrencyControlRulesWithOptionsAsync(DisableAllSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAllSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAllSqlConcurrencyControlRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableAllSqlConcurrencyControlRulesRequest
          * @return DisableAllSqlConcurrencyControlRulesResponse
         */
        public DisableAllSqlConcurrencyControlRulesResponse DisableAllSqlConcurrencyControlRules(DisableAllSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAllSqlConcurrencyControlRulesWithOptions(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableAllSqlConcurrencyControlRulesRequest
          * @return DisableAllSqlConcurrencyControlRulesResponse
         */
        public async Task<DisableAllSqlConcurrencyControlRulesResponse> DisableAllSqlConcurrencyControlRulesAsync(DisableAllSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAllSqlConcurrencyControlRulesWithOptionsAsync(request, runtime);
        }

        /**
          * If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoResourceOptimizeRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableAutoResourceOptimizeRulesResponse
         */
        public DisableAutoResourceOptimizeRulesResponse DisableAutoResourceOptimizeRulesWithOptions(DisableAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoResourceOptimizeRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoResourceOptimizeRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableAutoResourceOptimizeRulesResponse
         */
        public async Task<DisableAutoResourceOptimizeRulesResponse> DisableAutoResourceOptimizeRulesWithOptionsAsync(DisableAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoResourceOptimizeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoResourceOptimizeRulesRequest
          * @return DisableAutoResourceOptimizeRulesResponse
         */
        public DisableAutoResourceOptimizeRulesResponse DisableAutoResourceOptimizeRules(DisableAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoResourceOptimizeRulesWithOptions(request, runtime);
        }

        /**
          * If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoResourceOptimizeRulesRequest
          * @return DisableAutoResourceOptimizeRulesResponse
         */
        public async Task<DisableAutoResourceOptimizeRulesResponse> DisableAutoResourceOptimizeRulesAsync(DisableAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoResourceOptimizeRulesWithOptionsAsync(request, runtime);
        }

        /**
          * If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoThrottleRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableAutoThrottleRulesResponse
         */
        public DisableAutoThrottleRulesResponse DisableAutoThrottleRulesWithOptions(DisableAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoThrottleRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoThrottleRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableAutoThrottleRulesResponse
         */
        public async Task<DisableAutoThrottleRulesResponse> DisableAutoThrottleRulesWithOptionsAsync(DisableAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoThrottleRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoThrottleRulesRequest
          * @return DisableAutoThrottleRulesResponse
         */
        public DisableAutoThrottleRulesResponse DisableAutoThrottleRules(DisableAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoThrottleRulesWithOptions(request, runtime);
        }

        /**
          * If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request DisableAutoThrottleRulesRequest
          * @return DisableAutoThrottleRulesResponse
         */
        public async Task<DisableAutoThrottleRulesResponse> DisableAutoThrottleRulesAsync(DisableAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoThrottleRulesWithOptionsAsync(request, runtime);
        }

        /**
          * *   For information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DisableDasProRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableDasProResponse
         */
        public DisableDasProResponse DisableDasProWithOptions(DisableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DisableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDasProResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   For information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DisableDasProRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableDasProResponse
         */
        public async Task<DisableDasProResponse> DisableDasProWithOptionsAsync(DisableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DisableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDasProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   For information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DisableDasProRequest
          * @return DisableDasProResponse
         */
        public DisableDasProResponse DisableDasPro(DisableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDasProWithOptions(request, runtime);
        }

        /**
          * *   For information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request DisableDasProRequest
          * @return DisableDasProResponse
         */
        public async Task<DisableDasProResponse> DisableDasProAsync(DisableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDasProWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          *
          * @param request DisableInstanceDasConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableInstanceDasConfigResponse
         */
        public DisableInstanceDasConfigResponse DisableInstanceDasConfigWithOptions(DisableInstanceDasConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                query["ScaleType"] = request.ScaleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableInstanceDasConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInstanceDasConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          *
          * @param request DisableInstanceDasConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableInstanceDasConfigResponse
         */
        public async Task<DisableInstanceDasConfigResponse> DisableInstanceDasConfigWithOptionsAsync(DisableInstanceDasConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                query["ScaleType"] = request.ScaleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableInstanceDasConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInstanceDasConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          *
          * @param request DisableInstanceDasConfigRequest
          * @return DisableInstanceDasConfigResponse
         */
        public DisableInstanceDasConfigResponse DisableInstanceDasConfig(DisableInstanceDasConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableInstanceDasConfigWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          *
          * @param request DisableInstanceDasConfigRequest
          * @return DisableInstanceDasConfigResponse
         */
        public async Task<DisableInstanceDasConfigResponse> DisableInstanceDasConfigAsync(DisableInstanceDasConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableInstanceDasConfigWithOptionsAsync(request, runtime);
        }

        /**
          * This operation is applicable to the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableSqlConcurrencyControlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableSqlConcurrencyControlResponse
         */
        public DisableSqlConcurrencyControlResponse DisableSqlConcurrencyControlWithOptions(DisableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSqlConcurrencyControlResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation is applicable to the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableSqlConcurrencyControlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableSqlConcurrencyControlResponse
         */
        public async Task<DisableSqlConcurrencyControlResponse> DisableSqlConcurrencyControlWithOptionsAsync(DisableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSqlConcurrencyControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation is applicable to the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableSqlConcurrencyControlRequest
          * @return DisableSqlConcurrencyControlResponse
         */
        public DisableSqlConcurrencyControlResponse DisableSqlConcurrencyControl(DisableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSqlConcurrencyControlWithOptions(request, runtime);
        }

        /**
          * This operation is applicable to the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request DisableSqlConcurrencyControlRequest
          * @return DisableSqlConcurrencyControlResponse
         */
        public async Task<DisableSqlConcurrencyControlResponse> DisableSqlConcurrencyControlAsync(DisableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSqlConcurrencyControlWithOptionsAsync(request, runtime);
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request EnableDasProRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableDasProResponse
         */
        public EnableDasProResponse EnableDasProWithOptions(EnableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlRetention))
            {
                query["SqlRetention"] = request.SqlRetention;
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
                Action = "EnableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDasProResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request EnableDasProRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableDasProResponse
         */
        public async Task<EnableDasProResponse> EnableDasProWithOptionsAsync(EnableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlRetention))
            {
                query["SqlRetention"] = request.SqlRetention;
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
                Action = "EnableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDasProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request EnableDasProRequest
          * @return EnableDasProResponse
         */
        public EnableDasProResponse EnableDasPro(EnableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDasProWithOptions(request, runtime);
        }

        /**
          * *   For more information about database instances that support DAS Professional Edition, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request EnableDasProRequest
          * @return EnableDasProResponse
         */
        public async Task<EnableDasProResponse> EnableDasProAsync(EnableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDasProWithOptionsAsync(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request EnableSqlConcurrencyControlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableSqlConcurrencyControlResponse
         */
        public EnableSqlConcurrencyControlResponse EnableSqlConcurrencyControlWithOptions(EnableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyControlTime))
            {
                query["ConcurrencyControlTime"] = request.ConcurrencyControlTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlKeywords))
            {
                query["SqlKeywords"] = request.SqlKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlConcurrencyControlResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request EnableSqlConcurrencyControlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableSqlConcurrencyControlResponse
         */
        public async Task<EnableSqlConcurrencyControlResponse> EnableSqlConcurrencyControlWithOptionsAsync(EnableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyControlTime))
            {
                query["ConcurrencyControlTime"] = request.ConcurrencyControlTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlKeywords))
            {
                query["SqlKeywords"] = request.SqlKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlConcurrencyControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request EnableSqlConcurrencyControlRequest
          * @return EnableSqlConcurrencyControlResponse
         */
        public EnableSqlConcurrencyControlResponse EnableSqlConcurrencyControl(EnableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSqlConcurrencyControlWithOptions(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request EnableSqlConcurrencyControlRequest
          * @return EnableSqlConcurrencyControlResponse
         */
        public async Task<EnableSqlConcurrencyControlResponse> EnableSqlConcurrencyControlAsync(EnableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSqlConcurrencyControlWithOptionsAsync(request, runtime);
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not immediately returned. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which DAS Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestListByCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAsyncErrorRequestListByCodeResponse
         */
        public GetAsyncErrorRequestListByCodeResponse GetAsyncErrorRequestListByCodeWithOptions(GetAsyncErrorRequestListByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestListByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestListByCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not immediately returned. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which DAS Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestListByCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAsyncErrorRequestListByCodeResponse
         */
        public async Task<GetAsyncErrorRequestListByCodeResponse> GetAsyncErrorRequestListByCodeWithOptionsAsync(GetAsyncErrorRequestListByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestListByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestListByCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not immediately returned. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which DAS Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestListByCodeRequest
          * @return GetAsyncErrorRequestListByCodeResponse
         */
        public GetAsyncErrorRequestListByCodeResponse GetAsyncErrorRequestListByCode(GetAsyncErrorRequestListByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncErrorRequestListByCodeWithOptions(request, runtime);
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not immediately returned. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which DAS Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestListByCodeRequest
          * @return GetAsyncErrorRequestListByCodeResponse
         */
        public async Task<GetAsyncErrorRequestListByCodeResponse> GetAsyncErrorRequestListByCodeAsync(GetAsyncErrorRequestListByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncErrorRequestListByCodeWithOptionsAsync(request, runtime);
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatByCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAsyncErrorRequestStatByCodeResponse
         */
        public GetAsyncErrorRequestStatByCodeResponse GetAsyncErrorRequestStatByCodeWithOptions(GetAsyncErrorRequestStatByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatByCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatByCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAsyncErrorRequestStatByCodeResponse
         */
        public async Task<GetAsyncErrorRequestStatByCodeResponse> GetAsyncErrorRequestStatByCodeWithOptionsAsync(GetAsyncErrorRequestStatByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatByCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatByCodeRequest
          * @return GetAsyncErrorRequestStatByCodeResponse
         */
        public GetAsyncErrorRequestStatByCodeResponse GetAsyncErrorRequestStatByCode(GetAsyncErrorRequestStatByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncErrorRequestStatByCodeWithOptions(request, runtime);
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatByCodeRequest
          * @return GetAsyncErrorRequestStatByCodeResponse
         */
        public async Task<GetAsyncErrorRequestStatByCodeResponse> GetAsyncErrorRequestStatByCodeAsync(GetAsyncErrorRequestStatByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncErrorRequestStatByCodeWithOptionsAsync(request, runtime);
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAsyncErrorRequestStatResultResponse
         */
        public GetAsyncErrorRequestStatResultResponse GetAsyncErrorRequestStatResultWithOptions(GetAsyncErrorRequestStatResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIdList))
            {
                query["SqlIdList"] = request.SqlIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAsyncErrorRequestStatResultResponse
         */
        public async Task<GetAsyncErrorRequestStatResultResponse> GetAsyncErrorRequestStatResultWithOptionsAsync(GetAsyncErrorRequestStatResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIdList))
            {
                query["SqlIdList"] = request.SqlIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatResultRequest
          * @return GetAsyncErrorRequestStatResultResponse
         */
        public GetAsyncErrorRequestStatResultResponse GetAsyncErrorRequestStatResult(GetAsyncErrorRequestStatResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncErrorRequestStatResultWithOptions(request, runtime);
        }

        /**
          * >  When an asynchronous call is made, the complete query results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetAsyncErrorRequestStatResultRequest
          * @return GetAsyncErrorRequestStatResultResponse
         */
        public async Task<GetAsyncErrorRequestStatResultResponse> GetAsyncErrorRequestStatResultAsync(GetAsyncErrorRequestStatResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncErrorRequestStatResultWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request GetAutoIncrementUsageStatisticRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutoIncrementUsageStatisticResponse
         */
        public GetAutoIncrementUsageStatisticResponse GetAutoIncrementUsageStatisticWithOptions(GetAutoIncrementUsageStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNames))
            {
                query["DbNames"] = request.DbNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatioFilter))
            {
                query["RatioFilter"] = request.RatioFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTime))
            {
                query["RealTime"] = request.RealTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoIncrementUsageStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoIncrementUsageStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request GetAutoIncrementUsageStatisticRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutoIncrementUsageStatisticResponse
         */
        public async Task<GetAutoIncrementUsageStatisticResponse> GetAutoIncrementUsageStatisticWithOptionsAsync(GetAutoIncrementUsageStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNames))
            {
                query["DbNames"] = request.DbNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatioFilter))
            {
                query["RatioFilter"] = request.RatioFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTime))
            {
                query["RealTime"] = request.RealTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoIncrementUsageStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoIncrementUsageStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request GetAutoIncrementUsageStatisticRequest
          * @return GetAutoIncrementUsageStatisticResponse
         */
        public GetAutoIncrementUsageStatisticResponse GetAutoIncrementUsageStatistic(GetAutoIncrementUsageStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoIncrementUsageStatisticWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call DAS, you must set the region to cn-shanghai.
          *
          * @param request GetAutoIncrementUsageStatisticRequest
          * @return GetAutoIncrementUsageStatisticResponse
         */
        public async Task<GetAutoIncrementUsageStatisticResponse> GetAutoIncrementUsageStatisticAsync(GetAutoIncrementUsageStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoIncrementUsageStatisticWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request GetAutoResourceOptimizeRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutoResourceOptimizeRulesResponse
         */
        public GetAutoResourceOptimizeRulesResponse GetAutoResourceOptimizeRulesWithOptions(GetAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoResourceOptimizeRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request GetAutoResourceOptimizeRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutoResourceOptimizeRulesResponse
         */
        public async Task<GetAutoResourceOptimizeRulesResponse> GetAutoResourceOptimizeRulesWithOptionsAsync(GetAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoResourceOptimizeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request GetAutoResourceOptimizeRulesRequest
          * @return GetAutoResourceOptimizeRulesResponse
         */
        public GetAutoResourceOptimizeRulesResponse GetAutoResourceOptimizeRules(GetAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoResourceOptimizeRulesWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request GetAutoResourceOptimizeRulesRequest
          * @return GetAutoResourceOptimizeRulesResponse
         */
        public async Task<GetAutoResourceOptimizeRulesResponse> GetAutoResourceOptimizeRulesAsync(GetAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoResourceOptimizeRulesWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0.
          *     *   PolarDB for MySQL Cluster Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, or PolarDB for MySQL X-Engine Edition instance that runs MySQL 8.0.
          *
          * @param request GetAutoThrottleRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutoThrottleRulesResponse
         */
        public GetAutoThrottleRulesResponse GetAutoThrottleRulesWithOptions(GetAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoThrottleRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0.
          *     *   PolarDB for MySQL Cluster Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, or PolarDB for MySQL X-Engine Edition instance that runs MySQL 8.0.
          *
          * @param request GetAutoThrottleRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutoThrottleRulesResponse
         */
        public async Task<GetAutoThrottleRulesResponse> GetAutoThrottleRulesWithOptionsAsync(GetAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoThrottleRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0.
          *     *   PolarDB for MySQL Cluster Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, or PolarDB for MySQL X-Engine Edition instance that runs MySQL 8.0.
          *
          * @param request GetAutoThrottleRulesRequest
          * @return GetAutoThrottleRulesResponse
         */
        public GetAutoThrottleRulesResponse GetAutoThrottleRules(GetAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoThrottleRulesWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0.
          *     *   PolarDB for MySQL Cluster Edition instance that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, or PolarDB for MySQL X-Engine Edition instance that runs MySQL 8.0.
          *
          * @param request GetAutoThrottleRulesRequest
          * @return GetAutoThrottleRulesResponse
         */
        public async Task<GetAutoThrottleRulesResponse> GetAutoThrottleRulesAsync(GetAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoThrottleRulesWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventContentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutonomousNotifyEventContentResponse
         */
        public GetAutonomousNotifyEventContentResponse GetAutonomousNotifyEventContentWithOptions(GetAutonomousNotifyEventContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanId))
            {
                query["SpanId"] = request.SpanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventContent",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventContentResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventContentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutonomousNotifyEventContentResponse
         */
        public async Task<GetAutonomousNotifyEventContentResponse> GetAutonomousNotifyEventContentWithOptionsAsync(GetAutonomousNotifyEventContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanId))
            {
                query["SpanId"] = request.SpanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventContent",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventContentRequest
          * @return GetAutonomousNotifyEventContentResponse
         */
        public GetAutonomousNotifyEventContentResponse GetAutonomousNotifyEventContent(GetAutonomousNotifyEventContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutonomousNotifyEventContentWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventContentRequest
          * @return GetAutonomousNotifyEventContentResponse
         */
        public async Task<GetAutonomousNotifyEventContentResponse> GetAutonomousNotifyEventContentAsync(GetAutonomousNotifyEventContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutonomousNotifyEventContentWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventsInRangeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutonomousNotifyEventsInRangeResponse
         */
        public GetAutonomousNotifyEventsInRangeResponse GetAutonomousNotifyEventsInRangeWithOptions(GetAutonomousNotifyEventsInRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLevel))
            {
                query["MinLevel"] = request.MinLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOffset))
            {
                query["PageOffset"] = request.PageOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventsInRange",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventsInRangeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventsInRangeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAutonomousNotifyEventsInRangeResponse
         */
        public async Task<GetAutonomousNotifyEventsInRangeResponse> GetAutonomousNotifyEventsInRangeWithOptionsAsync(GetAutonomousNotifyEventsInRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLevel))
            {
                query["MinLevel"] = request.MinLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOffset))
            {
                query["PageOffset"] = request.PageOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventsInRange",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventsInRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventsInRangeRequest
          * @return GetAutonomousNotifyEventsInRangeResponse
         */
        public GetAutonomousNotifyEventsInRangeResponse GetAutonomousNotifyEventsInRange(GetAutonomousNotifyEventsInRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutonomousNotifyEventsInRangeWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
          * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](~~152139~~).
          *
          * @param request GetAutonomousNotifyEventsInRangeRequest
          * @return GetAutonomousNotifyEventsInRangeResponse
         */
        public async Task<GetAutonomousNotifyEventsInRangeResponse> GetAutonomousNotifyEventsInRangeAsync(GetAutonomousNotifyEventsInRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutonomousNotifyEventsInRangeWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetBlockingDetailListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetBlockingDetailListResponse
         */
        public GetBlockingDetailListResponse GetBlockingDetailListWithOptions(GetBlockingDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryHash))
            {
                query["QueryHash"] = request.QueryHash;
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
                Action = "GetBlockingDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlockingDetailListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetBlockingDetailListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetBlockingDetailListResponse
         */
        public async Task<GetBlockingDetailListResponse> GetBlockingDetailListWithOptionsAsync(GetBlockingDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryHash))
            {
                query["QueryHash"] = request.QueryHash;
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
                Action = "GetBlockingDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlockingDetailListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetBlockingDetailListRequest
          * @return GetBlockingDetailListResponse
         */
        public GetBlockingDetailListResponse GetBlockingDetailList(GetBlockingDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBlockingDetailListWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetBlockingDetailListRequest
          * @return GetBlockingDetailListResponse
         */
        public async Task<GetBlockingDetailListResponse> GetBlockingDetailListAsync(GetBlockingDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBlockingDetailListWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetDBInstanceConnectivityDiagnosisRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDBInstanceConnectivityDiagnosisResponse
         */
        public GetDBInstanceConnectivityDiagnosisResponse GetDBInstanceConnectivityDiagnosisWithOptions(GetDBInstanceConnectivityDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDBInstanceConnectivityDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDBInstanceConnectivityDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetDBInstanceConnectivityDiagnosisRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDBInstanceConnectivityDiagnosisResponse
         */
        public async Task<GetDBInstanceConnectivityDiagnosisResponse> GetDBInstanceConnectivityDiagnosisWithOptionsAsync(GetDBInstanceConnectivityDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDBInstanceConnectivityDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDBInstanceConnectivityDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetDBInstanceConnectivityDiagnosisRequest
          * @return GetDBInstanceConnectivityDiagnosisResponse
         */
        public GetDBInstanceConnectivityDiagnosisResponse GetDBInstanceConnectivityDiagnosis(GetDBInstanceConnectivityDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDBInstanceConnectivityDiagnosisWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetDBInstanceConnectivityDiagnosisRequest
          * @return GetDBInstanceConnectivityDiagnosisResponse
         */
        public async Task<GetDBInstanceConnectivityDiagnosisResponse> GetDBInstanceConnectivityDiagnosisAsync(GetDBInstanceConnectivityDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDBInstanceConnectivityDiagnosisWithOptionsAsync(request, runtime);
        }

        /**
          * *   For information about databases that are supported, see [Overview](~~190912~~).
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDasProServiceUsageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDasProServiceUsageResponse
         */
        public GetDasProServiceUsageResponse GetDasProServiceUsageWithOptions(GetDasProServiceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetDasProServiceUsage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasProServiceUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   For information about databases that are supported, see [Overview](~~190912~~).
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDasProServiceUsageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDasProServiceUsageResponse
         */
        public async Task<GetDasProServiceUsageResponse> GetDasProServiceUsageWithOptionsAsync(GetDasProServiceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetDasProServiceUsage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasProServiceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   For information about databases that are supported, see [Overview](~~190912~~).
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDasProServiceUsageRequest
          * @return GetDasProServiceUsageResponse
         */
        public GetDasProServiceUsageResponse GetDasProServiceUsage(GetDasProServiceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDasProServiceUsageWithOptions(request, runtime);
        }

        /**
          * *   For information about databases that are supported, see [Overview](~~190912~~).
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDasProServiceUsageRequest
          * @return GetDasProServiceUsageResponse
         */
        public async Task<GetDasProServiceUsageResponse> GetDasProServiceUsageAsync(GetDasProServiceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDasProServiceUsageWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
          * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](~~92561~~) section of the "Overview" topic.
          * >  You can query only the data that is generated after the new SQL Explorer and Audit feature is enabled. The start time can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed 24 hours.
          *
          * @param request GetDasSQLLogHotDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDasSQLLogHotDataResponse
         */
        public GetDasSQLLogHotDataResponse GetDasSQLLogHotDataWithOptions(GetDasSQLLogHotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildDBInstanceIDs))
            {
                body["ChildDBInstanceIDs"] = request.ChildDBInstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                body["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fail))
            {
                body["Fail"] = request.Fail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAddress))
            {
                body["HostAddress"] = request.HostAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                body["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLatancy))
            {
                body["MaxLatancy"] = request.MaxLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordsPerPage))
            {
                body["MaxRecordsPerPage"] = request.MaxRecordsPerPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanRows))
            {
                body["MaxScanRows"] = request.MaxScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSpillCnt))
            {
                body["MaxSpillCnt"] = request.MaxSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLatancy))
            {
                body["MinLatancy"] = request.MinLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinRows))
            {
                body["MinRows"] = request.MinRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanRows))
            {
                body["MinScanRows"] = request.MinScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSpillCnt))
            {
                body["MinSpillCnt"] = request.MinSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumbers))
            {
                body["PageNumbers"] = request.PageNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                body["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                body["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortMethod))
            {
                body["SortMethod"] = request.SortMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                body["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadID))
            {
                body["ThreadID"] = request.ThreadID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                body["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDasSQLLogHotData",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasSQLLogHotDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
          * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](~~92561~~) section of the "Overview" topic.
          * >  You can query only the data that is generated after the new SQL Explorer and Audit feature is enabled. The start time can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed 24 hours.
          *
          * @param request GetDasSQLLogHotDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDasSQLLogHotDataResponse
         */
        public async Task<GetDasSQLLogHotDataResponse> GetDasSQLLogHotDataWithOptionsAsync(GetDasSQLLogHotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildDBInstanceIDs))
            {
                body["ChildDBInstanceIDs"] = request.ChildDBInstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                body["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fail))
            {
                body["Fail"] = request.Fail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAddress))
            {
                body["HostAddress"] = request.HostAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                body["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLatancy))
            {
                body["MaxLatancy"] = request.MaxLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordsPerPage))
            {
                body["MaxRecordsPerPage"] = request.MaxRecordsPerPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanRows))
            {
                body["MaxScanRows"] = request.MaxScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSpillCnt))
            {
                body["MaxSpillCnt"] = request.MaxSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLatancy))
            {
                body["MinLatancy"] = request.MinLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinRows))
            {
                body["MinRows"] = request.MinRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanRows))
            {
                body["MinScanRows"] = request.MinScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSpillCnt))
            {
                body["MinSpillCnt"] = request.MinSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumbers))
            {
                body["PageNumbers"] = request.PageNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                body["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                body["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortMethod))
            {
                body["SortMethod"] = request.SortMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                body["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadID))
            {
                body["ThreadID"] = request.ThreadID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                body["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDasSQLLogHotData",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasSQLLogHotDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
          * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](~~92561~~) section of the "Overview" topic.
          * >  You can query only the data that is generated after the new SQL Explorer and Audit feature is enabled. The start time can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed 24 hours.
          *
          * @param request GetDasSQLLogHotDataRequest
          * @return GetDasSQLLogHotDataResponse
         */
        public GetDasSQLLogHotDataResponse GetDasSQLLogHotData(GetDasSQLLogHotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDasSQLLogHotDataWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
          * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](~~92561~~) section of the "Overview" topic.
          * >  You can query only the data that is generated after the new SQL Explorer and Audit feature is enabled. The start time can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed 24 hours.
          *
          * @param request GetDasSQLLogHotDataRequest
          * @return GetDasSQLLogHotDataResponse
         */
        public async Task<GetDasSQLLogHotDataResponse> GetDasSQLLogHotDataAsync(GetDasSQLLogHotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDasSQLLogHotDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDeadLockDetailListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeadLockDetailListResponse
         */
        public GetDeadLockDetailListResponse GetDeadLockDetailListWithOptions(GetDeadLockDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeadLockDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockDetailListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDeadLockDetailListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeadLockDetailListResponse
         */
        public async Task<GetDeadLockDetailListResponse> GetDeadLockDetailListWithOptionsAsync(GetDeadLockDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeadLockDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockDetailListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDeadLockDetailListRequest
          * @return GetDeadLockDetailListResponse
         */
        public GetDeadLockDetailListResponse GetDeadLockDetailList(GetDeadLockDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeadLockDetailListWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetDeadLockDetailListRequest
          * @return GetDeadLockDetailListResponse
         */
        public async Task<GetDeadLockDetailListResponse> GetDeadLockDetailListAsync(GetDeadLockDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeadLockDetailListWithOptionsAsync(request, runtime);
        }

        public GetEndpointSwitchTaskResponse GetEndpointSwitchTaskWithOptions(GetEndpointSwitchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEndpointSwitchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEndpointSwitchTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEndpointSwitchTaskResponse> GetEndpointSwitchTaskWithOptionsAsync(GetEndpointSwitchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEndpointSwitchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEndpointSwitchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEndpointSwitchTaskResponse GetEndpointSwitchTask(GetEndpointSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEndpointSwitchTaskWithOptions(request, runtime);
        }

        public async Task<GetEndpointSwitchTaskResponse> GetEndpointSwitchTaskAsync(GetEndpointSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEndpointSwitchTaskWithOptionsAsync(request, runtime);
        }

        /**
          * >  The complete query results are not immediately returned after an asynchronous request is sent. If the value of **isFinish** is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetErrorRequestSampleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetErrorRequestSampleResponse
         */
        public GetErrorRequestSampleResponse GetErrorRequestSampleWithOptions(GetErrorRequestSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorRequestSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErrorRequestSampleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  The complete query results are not immediately returned after an asynchronous request is sent. If the value of **isFinish** is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetErrorRequestSampleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetErrorRequestSampleResponse
         */
        public async Task<GetErrorRequestSampleResponse> GetErrorRequestSampleWithOptionsAsync(GetErrorRequestSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorRequestSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErrorRequestSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  The complete query results are not immediately returned after an asynchronous request is sent. If the value of **isFinish** is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetErrorRequestSampleRequest
          * @return GetErrorRequestSampleResponse
         */
        public GetErrorRequestSampleResponse GetErrorRequestSample(GetErrorRequestSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetErrorRequestSampleWithOptions(request, runtime);
        }

        /**
          * >  The complete query results are not immediately returned after an asynchronous request is sent. If the value of **isFinish** is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of **isFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Professional Edition is enabled. For more information, see [Purchase DAS Professional Edition](~~163298~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetErrorRequestSampleRequest
          * @return GetErrorRequestSampleResponse
         */
        public async Task<GetErrorRequestSampleResponse> GetErrorRequestSampleAsync(GetErrorRequestSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetErrorRequestSampleWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetEventSubscriptionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEventSubscriptionResponse
         */
        public GetEventSubscriptionResponse GetEventSubscriptionWithOptions(GetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetEventSubscriptionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEventSubscriptionResponse
         */
        public async Task<GetEventSubscriptionResponse> GetEventSubscriptionWithOptionsAsync(GetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetEventSubscriptionRequest
          * @return GetEventSubscriptionResponse
         */
        public GetEventSubscriptionResponse GetEventSubscription(GetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventSubscriptionWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request GetEventSubscriptionRequest
          * @return GetEventSubscriptionResponse
         */
        public async Task<GetEventSubscriptionResponse> GetEventSubscriptionAsync(GetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventSubscriptionWithOptionsAsync(request, runtime);
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestOriginStatByInstanceIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFullRequestOriginStatByInstanceIdResponse
         */
        public GetFullRequestOriginStatByInstanceIdResponse GetFullRequestOriginStatByInstanceIdWithOptions(GetFullRequestOriginStatByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestOriginStatByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestOriginStatByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestOriginStatByInstanceIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFullRequestOriginStatByInstanceIdResponse
         */
        public async Task<GetFullRequestOriginStatByInstanceIdResponse> GetFullRequestOriginStatByInstanceIdWithOptionsAsync(GetFullRequestOriginStatByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestOriginStatByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestOriginStatByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestOriginStatByInstanceIdRequest
          * @return GetFullRequestOriginStatByInstanceIdResponse
         */
        public GetFullRequestOriginStatByInstanceIdResponse GetFullRequestOriginStatByInstanceId(GetFullRequestOriginStatByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFullRequestOriginStatByInstanceIdWithOptions(request, runtime);
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestOriginStatByInstanceIdRequest
          * @return GetFullRequestOriginStatByInstanceIdResponse
         */
        public async Task<GetFullRequestOriginStatByInstanceIdResponse> GetFullRequestOriginStatByInstanceIdAsync(GetFullRequestOriginStatByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFullRequestOriginStatByInstanceIdWithOptionsAsync(request, runtime);
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](~~204096~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestSampleByInstanceIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFullRequestSampleByInstanceIdResponse
         */
        public GetFullRequestSampleByInstanceIdResponse GetFullRequestSampleByInstanceIdWithOptions(GetFullRequestSampleByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFullRequestSampleByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestSampleByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](~~204096~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestSampleByInstanceIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFullRequestSampleByInstanceIdResponse
         */
        public async Task<GetFullRequestSampleByInstanceIdResponse> GetFullRequestSampleByInstanceIdWithOptionsAsync(GetFullRequestSampleByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFullRequestSampleByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestSampleByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](~~204096~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestSampleByInstanceIdRequest
          * @return GetFullRequestSampleByInstanceIdResponse
         */
        public GetFullRequestSampleByInstanceIdResponse GetFullRequestSampleByInstanceId(GetFullRequestSampleByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFullRequestSampleByInstanceIdWithOptions(request, runtime);
        }

        /**
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](~~204096~~).
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestSampleByInstanceIdRequest
          * @return GetFullRequestSampleByInstanceIdResponse
         */
        public async Task<GetFullRequestSampleByInstanceIdResponse> GetFullRequestSampleByInstanceIdAsync(GetFullRequestSampleByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFullRequestSampleByInstanceIdWithOptionsAsync(request, runtime);
        }

        /**
          * >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestStatResultByInstanceIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFullRequestStatResultByInstanceIdResponse
         */
        public GetFullRequestStatResultByInstanceIdResponse GetFullRequestStatResultByInstanceIdWithOptions(GetFullRequestStatResultByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginHost))
            {
                query["OriginHost"] = request.OriginHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestStatResultByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestStatResultByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestStatResultByInstanceIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFullRequestStatResultByInstanceIdResponse
         */
        public async Task<GetFullRequestStatResultByInstanceIdResponse> GetFullRequestStatResultByInstanceIdWithOptionsAsync(GetFullRequestStatResultByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginHost))
            {
                query["OriginHost"] = request.OriginHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestStatResultByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestStatResultByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestStatResultByInstanceIdRequest
          * @return GetFullRequestStatResultByInstanceIdResponse
         */
        public GetFullRequestStatResultByInstanceIdResponse GetFullRequestStatResultByInstanceId(GetFullRequestStatResultByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFullRequestStatResultByInstanceIdWithOptions(request, runtime);
        }

        /**
          * >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
          * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](~~204096~~).
          * *   For more information about database instances that support SQL Explorer, see [Overview](~~190912~~).
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          *
          * @param request GetFullRequestStatResultByInstanceIdRequest
          * @return GetFullRequestStatResultByInstanceIdResponse
         */
        public async Task<GetFullRequestStatResultByInstanceIdResponse> GetFullRequestStatResultByInstanceIdAsync(GetFullRequestStatResultByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFullRequestStatResultByInstanceIdWithOptionsAsync(request, runtime);
        }

        public GetHDMAliyunResourceSyncResultResponse GetHDMAliyunResourceSyncResultWithOptions(GetHDMAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMAliyunResourceSyncResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHDMAliyunResourceSyncResultResponse> GetHDMAliyunResourceSyncResultWithOptionsAsync(GetHDMAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMAliyunResourceSyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHDMAliyunResourceSyncResultResponse GetHDMAliyunResourceSyncResult(GetHDMAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHDMAliyunResourceSyncResultWithOptions(request, runtime);
        }

        public async Task<GetHDMAliyunResourceSyncResultResponse> GetHDMAliyunResourceSyncResultAsync(GetHDMAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHDMAliyunResourceSyncResultWithOptionsAsync(request, runtime);
        }

        public GetHDMLastAliyunResourceSyncResultResponse GetHDMLastAliyunResourceSyncResultWithOptions(GetHDMLastAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMLastAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMLastAliyunResourceSyncResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHDMLastAliyunResourceSyncResultResponse> GetHDMLastAliyunResourceSyncResultWithOptionsAsync(GetHDMLastAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMLastAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMLastAliyunResourceSyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHDMLastAliyunResourceSyncResultResponse GetHDMLastAliyunResourceSyncResult(GetHDMLastAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHDMLastAliyunResourceSyncResultWithOptions(request, runtime);
        }

        public async Task<GetHDMLastAliyunResourceSyncResultResponse> GetHDMLastAliyunResourceSyncResultAsync(GetHDMLastAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHDMLastAliyunResourceSyncResultWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](~~205659~~).
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of DAS SDK must be V1.0.3 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceInspectionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceInspectionsResponse
         */
        public GetInstanceInspectionsResponse GetInstanceInspectionsWithOptions(GetInstanceInspectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMap))
            {
                query["SearchMap"] = request.SearchMap;
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
                Action = "GetInstanceInspections",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceInspectionsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](~~205659~~).
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of DAS SDK must be V1.0.3 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceInspectionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceInspectionsResponse
         */
        public async Task<GetInstanceInspectionsResponse> GetInstanceInspectionsWithOptionsAsync(GetInstanceInspectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMap))
            {
                query["SearchMap"] = request.SearchMap;
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
                Action = "GetInstanceInspections",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceInspectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](~~205659~~).
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of DAS SDK must be V1.0.3 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceInspectionsRequest
          * @return GetInstanceInspectionsResponse
         */
        public GetInstanceInspectionsResponse GetInstanceInspections(GetInstanceInspectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceInspectionsWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](~~205659~~).
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of DAS SDK must be V1.0.3 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceInspectionsRequest
          * @return GetInstanceInspectionsResponse
         */
        public async Task<GetInstanceInspectionsResponse> GetInstanceInspectionsAsync(GetInstanceInspectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceInspectionsWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceMissingIndexListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceMissingIndexListResponse
         */
        public GetInstanceMissingIndexListResponse GetInstanceMissingIndexListWithOptions(GetInstanceMissingIndexListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgTotalUserCost))
            {
                query["AvgTotalUserCost"] = request.AvgTotalUserCost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgUserImpact))
            {
                query["AvgUserImpact"] = request.AvgUserImpact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexCount))
            {
                query["IndexCount"] = request.IndexCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPages))
            {
                query["ReservedPages"] = request.ReservedPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSize))
            {
                query["ReservedSize"] = request.ReservedSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                query["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueCompiles))
            {
                query["UniqueCompiles"] = request.UniqueCompiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserScans))
            {
                query["UserScans"] = request.UserScans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSeeks))
            {
                query["UserSeeks"] = request.UserSeeks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceMissingIndexList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceMissingIndexListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceMissingIndexListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceMissingIndexListResponse
         */
        public async Task<GetInstanceMissingIndexListResponse> GetInstanceMissingIndexListWithOptionsAsync(GetInstanceMissingIndexListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgTotalUserCost))
            {
                query["AvgTotalUserCost"] = request.AvgTotalUserCost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgUserImpact))
            {
                query["AvgUserImpact"] = request.AvgUserImpact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexCount))
            {
                query["IndexCount"] = request.IndexCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPages))
            {
                query["ReservedPages"] = request.ReservedPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSize))
            {
                query["ReservedSize"] = request.ReservedSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                query["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueCompiles))
            {
                query["UniqueCompiles"] = request.UniqueCompiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserScans))
            {
                query["UserScans"] = request.UserScans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSeeks))
            {
                query["UserSeeks"] = request.UserSeeks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceMissingIndexList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceMissingIndexListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceMissingIndexListRequest
          * @return GetInstanceMissingIndexListResponse
         */
        public GetInstanceMissingIndexListResponse GetInstanceMissingIndexList(GetInstanceMissingIndexListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceMissingIndexListWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetInstanceMissingIndexListRequest
          * @return GetInstanceMissingIndexListResponse
         */
        public async Task<GetInstanceMissingIndexListResponse> GetInstanceMissingIndexListAsync(GetInstanceMissingIndexListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceMissingIndexListWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.
          *
          * @param request GetInstanceSqlOptimizeStatisticRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceSqlOptimizeStatisticResponse
         */
        public GetInstanceSqlOptimizeStatisticResponse GetInstanceSqlOptimizeStatisticWithOptions(GetInstanceSqlOptimizeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterEnable))
            {
                query["FilterEnable"] = request.FilterEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMerging))
            {
                query["UseMerging"] = request.UseMerging;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSqlOptimizeStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSqlOptimizeStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.
          *
          * @param request GetInstanceSqlOptimizeStatisticRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceSqlOptimizeStatisticResponse
         */
        public async Task<GetInstanceSqlOptimizeStatisticResponse> GetInstanceSqlOptimizeStatisticWithOptionsAsync(GetInstanceSqlOptimizeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterEnable))
            {
                query["FilterEnable"] = request.FilterEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMerging))
            {
                query["UseMerging"] = request.UseMerging;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSqlOptimizeStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSqlOptimizeStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.
          *
          * @param request GetInstanceSqlOptimizeStatisticRequest
          * @return GetInstanceSqlOptimizeStatisticResponse
         */
        public GetInstanceSqlOptimizeStatisticResponse GetInstanceSqlOptimizeStatistic(GetInstanceSqlOptimizeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceSqlOptimizeStatisticWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.
          *
          * @param request GetInstanceSqlOptimizeStatisticRequest
          * @return GetInstanceSqlOptimizeStatisticResponse
         */
        public async Task<GetInstanceSqlOptimizeStatisticResponse> GetInstanceSqlOptimizeStatisticAsync(GetInstanceSqlOptimizeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceSqlOptimizeStatisticWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetKillInstanceSessionTaskResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetKillInstanceSessionTaskResultResponse
         */
        public GetKillInstanceSessionTaskResultResponse GetKillInstanceSessionTaskResultWithOptions(GetKillInstanceSessionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKillInstanceSessionTaskResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKillInstanceSessionTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetKillInstanceSessionTaskResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetKillInstanceSessionTaskResultResponse
         */
        public async Task<GetKillInstanceSessionTaskResultResponse> GetKillInstanceSessionTaskResultWithOptionsAsync(GetKillInstanceSessionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKillInstanceSessionTaskResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKillInstanceSessionTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetKillInstanceSessionTaskResultRequest
          * @return GetKillInstanceSessionTaskResultResponse
         */
        public GetKillInstanceSessionTaskResultResponse GetKillInstanceSessionTaskResult(GetKillInstanceSessionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKillInstanceSessionTaskResultWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetKillInstanceSessionTaskResultRequest
          * @return GetKillInstanceSessionTaskResultResponse
         */
        public async Task<GetKillInstanceSessionTaskResultResponse> GetKillInstanceSessionTaskResultAsync(GetKillInstanceSessionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKillInstanceSessionTaskResultWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to MongoDB instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request GetMongoDBCurrentOpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMongoDBCurrentOpResponse
         */
        public GetMongoDBCurrentOpResponse GetMongoDBCurrentOpWithOptions(GetMongoDBCurrentOpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterDoc))
            {
                query["FilterDoc"] = request.FilterDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMongoDBCurrentOp",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMongoDBCurrentOpResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to MongoDB instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request GetMongoDBCurrentOpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMongoDBCurrentOpResponse
         */
        public async Task<GetMongoDBCurrentOpResponse> GetMongoDBCurrentOpWithOptionsAsync(GetMongoDBCurrentOpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterDoc))
            {
                query["FilterDoc"] = request.FilterDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMongoDBCurrentOp",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMongoDBCurrentOpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to MongoDB instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request GetMongoDBCurrentOpRequest
          * @return GetMongoDBCurrentOpResponse
         */
        public GetMongoDBCurrentOpResponse GetMongoDBCurrentOp(GetMongoDBCurrentOpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMongoDBCurrentOpWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to MongoDB instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.
          *
          * @param request GetMongoDBCurrentOpRequest
          * @return GetMongoDBCurrentOpResponse
         */
        public async Task<GetMongoDBCurrentOpResponse> GetMongoDBCurrentOpAsync(GetMongoDBCurrentOpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMongoDBCurrentOpWithOptionsAsync(request, runtime);
        }

        /**
          * >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL, PolarDB for MySQL, and PolarDB-X 2.0 instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetMySQLAllSessionAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMySQLAllSessionAsyncResponse
         */
        public GetMySQLAllSessionAsyncResponse GetMySQLAllSessionAsyncWithOptions(GetMySQLAllSessionAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMySQLAllSessionAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySQLAllSessionAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL, PolarDB for MySQL, and PolarDB-X 2.0 instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetMySQLAllSessionAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMySQLAllSessionAsyncResponse
         */
        public async Task<GetMySQLAllSessionAsyncResponse> GetMySQLAllSessionAsyncWithOptionsAsync(GetMySQLAllSessionAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMySQLAllSessionAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySQLAllSessionAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL, PolarDB for MySQL, and PolarDB-X 2.0 instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetMySQLAllSessionAsyncRequest
          * @return GetMySQLAllSessionAsyncResponse
         */
        public GetMySQLAllSessionAsyncResponse GetMySQLAllSessionAsync(GetMySQLAllSessionAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMySQLAllSessionAsyncWithOptions(request, runtime);
        }

        /**
          * >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
          * *   This operation is applicable only to ApsaraDB RDS for MySQL, PolarDB for MySQL, and PolarDB-X 2.0 instances.
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetMySQLAllSessionAsyncRequest
          * @return GetMySQLAllSessionAsyncResponse
         */
        public async Task<GetMySQLAllSessionAsyncResponse> GetMySQLAllSessionAsyncAsync(GetMySQLAllSessionAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMySQLAllSessionAsyncWithOptionsAsync(request, runtime);
        }

        /**
          * We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](~~470302~~) feature of Database Autonomy Service (DAS) to query the data.
          *
          * @param request GetPartitionsHeatmapRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPartitionsHeatmapResponse
         */
        public GetPartitionsHeatmapResponse GetPartitionsHeatmapWithOptions(GetPartitionsHeatmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
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
                Action = "GetPartitionsHeatmap",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionsHeatmapResponse>(CallApi(params_, req, runtime));
        }

        /**
          * We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](~~470302~~) feature of Database Autonomy Service (DAS) to query the data.
          *
          * @param request GetPartitionsHeatmapRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPartitionsHeatmapResponse
         */
        public async Task<GetPartitionsHeatmapResponse> GetPartitionsHeatmapWithOptionsAsync(GetPartitionsHeatmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
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
                Action = "GetPartitionsHeatmap",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionsHeatmapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](~~470302~~) feature of Database Autonomy Service (DAS) to query the data.
          *
          * @param request GetPartitionsHeatmapRequest
          * @return GetPartitionsHeatmapResponse
         */
        public GetPartitionsHeatmapResponse GetPartitionsHeatmap(GetPartitionsHeatmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPartitionsHeatmapWithOptions(request, runtime);
        }

        /**
          * We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](~~470302~~) feature of Database Autonomy Service (DAS) to query the data.
          *
          * @param request GetPartitionsHeatmapRequest
          * @return GetPartitionsHeatmapResponse
         */
        public async Task<GetPartitionsHeatmapResponse> GetPartitionsHeatmapAsync(GetPartitionsHeatmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPartitionsHeatmapWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsMetricTrendsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPfsMetricTrendsResponse
         */
        public GetPfsMetricTrendsResponse GetPfsMetricTrendsWithOptions(GetPfsMetricTrendsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsMetricTrends",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsMetricTrendsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsMetricTrendsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPfsMetricTrendsResponse
         */
        public async Task<GetPfsMetricTrendsResponse> GetPfsMetricTrendsWithOptionsAsync(GetPfsMetricTrendsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsMetricTrends",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsMetricTrendsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsMetricTrendsRequest
          * @return GetPfsMetricTrendsResponse
         */
        public GetPfsMetricTrendsResponse GetPfsMetricTrends(GetPfsMetricTrendsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPfsMetricTrendsWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsMetricTrendsRequest
          * @return GetPfsMetricTrendsResponse
         */
        public async Task<GetPfsMetricTrendsResponse> GetPfsMetricTrendsAsync(GetPfsMetricTrendsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPfsMetricTrendsWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSampleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPfsSqlSampleResponse
         */
        public GetPfsSqlSampleResponse GetPfsSqlSampleWithOptions(GetPfsSqlSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSampleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSampleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPfsSqlSampleResponse
         */
        public async Task<GetPfsSqlSampleResponse> GetPfsSqlSampleWithOptionsAsync(GetPfsSqlSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSampleRequest
          * @return GetPfsSqlSampleResponse
         */
        public GetPfsSqlSampleResponse GetPfsSqlSample(GetPfsSqlSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPfsSqlSampleWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSampleRequest
          * @return GetPfsSqlSampleResponse
         */
        public async Task<GetPfsSqlSampleResponse> GetPfsSqlSampleAsync(GetPfsSqlSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPfsSqlSampleWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSummariesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPfsSqlSummariesResponse
         */
        public GetPfsSqlSummariesResponse GetPfsSqlSummariesWithOptions(GetPfsSqlSummariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSummaries",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSummariesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSummariesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPfsSqlSummariesResponse
         */
        public async Task<GetPfsSqlSummariesResponse> GetPfsSqlSummariesWithOptionsAsync(GetPfsSqlSummariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSummaries",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSummariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSummariesRequest
          * @return GetPfsSqlSummariesResponse
         */
        public GetPfsSqlSummariesResponse GetPfsSqlSummaries(GetPfsSqlSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPfsSqlSummariesWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
          * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](~~469117~~).
          *
          * @param request GetPfsSqlSummariesRequest
          * @return GetPfsSqlSummariesResponse
         */
        public async Task<GetPfsSqlSummariesResponse> GetPfsSqlSummariesAsync(GetPfsSqlSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPfsSqlSummariesWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataStatsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeDataStatsResponse
         */
        public GetQueryOptimizeDataStatsResponse GetQueryOptimizeDataStatsWithOptions(GetQueryOptimizeDataStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataStatsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataStatsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeDataStatsResponse
         */
        public async Task<GetQueryOptimizeDataStatsResponse> GetQueryOptimizeDataStatsWithOptionsAsync(GetQueryOptimizeDataStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataStatsRequest
          * @return GetQueryOptimizeDataStatsResponse
         */
        public GetQueryOptimizeDataStatsResponse GetQueryOptimizeDataStats(GetQueryOptimizeDataStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeDataStatsWithOptions(request, runtime);
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataStatsRequest
          * @return GetQueryOptimizeDataStatsResponse
         */
        public async Task<GetQueryOptimizeDataStatsResponse> GetQueryOptimizeDataStatsAsync(GetQueryOptimizeDataStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeDataStatsWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTopRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeDataTopResponse
         */
        public GetQueryOptimizeDataTopResponse GetQueryOptimizeDataTopWithOptions(GetQueryOptimizeDataTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTop",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTopResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTopRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeDataTopResponse
         */
        public async Task<GetQueryOptimizeDataTopResponse> GetQueryOptimizeDataTopWithOptionsAsync(GetQueryOptimizeDataTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTop",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTopRequest
          * @return GetQueryOptimizeDataTopResponse
         */
        public GetQueryOptimizeDataTopResponse GetQueryOptimizeDataTop(GetQueryOptimizeDataTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeDataTopWithOptions(request, runtime);
        }

        /**
          * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTopRequest
          * @return GetQueryOptimizeDataTopResponse
         */
        public async Task<GetQueryOptimizeDataTopResponse> GetQueryOptimizeDataTopAsync(GetQueryOptimizeDataTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeDataTopWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTrendRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeDataTrendResponse
         */
        public GetQueryOptimizeDataTrendResponse GetQueryOptimizeDataTrendWithOptions(GetQueryOptimizeDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTrend",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTrendResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTrendRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeDataTrendResponse
         */
        public async Task<GetQueryOptimizeDataTrendResponse> GetQueryOptimizeDataTrendWithOptionsAsync(GetQueryOptimizeDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTrend",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTrendRequest
          * @return GetQueryOptimizeDataTrendResponse
         */
        public GetQueryOptimizeDataTrendResponse GetQueryOptimizeDataTrend(GetQueryOptimizeDataTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeDataTrendWithOptions(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeDataTrendRequest
          * @return GetQueryOptimizeDataTrendResponse
         */
        public async Task<GetQueryOptimizeDataTrendResponse> GetQueryOptimizeDataTrendAsync(GetQueryOptimizeDataTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeDataTrendWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorSampleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeExecErrorSampleResponse
         */
        public GetQueryOptimizeExecErrorSampleResponse GetQueryOptimizeExecErrorSampleWithOptions(GetQueryOptimizeExecErrorSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorSampleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorSampleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeExecErrorSampleResponse
         */
        public async Task<GetQueryOptimizeExecErrorSampleResponse> GetQueryOptimizeExecErrorSampleWithOptionsAsync(GetQueryOptimizeExecErrorSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorSampleRequest
          * @return GetQueryOptimizeExecErrorSampleResponse
         */
        public GetQueryOptimizeExecErrorSampleResponse GetQueryOptimizeExecErrorSample(GetQueryOptimizeExecErrorSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeExecErrorSampleWithOptions(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorSampleRequest
          * @return GetQueryOptimizeExecErrorSampleResponse
         */
        public async Task<GetQueryOptimizeExecErrorSampleResponse> GetQueryOptimizeExecErrorSampleAsync(GetQueryOptimizeExecErrorSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeExecErrorSampleWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorStatsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeExecErrorStatsResponse
         */
        public GetQueryOptimizeExecErrorStatsResponse GetQueryOptimizeExecErrorStatsWithOptions(GetQueryOptimizeExecErrorStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorStatsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorStatsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeExecErrorStatsResponse
         */
        public async Task<GetQueryOptimizeExecErrorStatsResponse> GetQueryOptimizeExecErrorStatsWithOptionsAsync(GetQueryOptimizeExecErrorStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorStatsRequest
          * @return GetQueryOptimizeExecErrorStatsResponse
         */
        public GetQueryOptimizeExecErrorStatsResponse GetQueryOptimizeExecErrorStats(GetQueryOptimizeExecErrorStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeExecErrorStatsWithOptions(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeExecErrorStatsRequest
          * @return GetQueryOptimizeExecErrorStatsResponse
         */
        public async Task<GetQueryOptimizeExecErrorStatsResponse> GetQueryOptimizeExecErrorStatsAsync(GetQueryOptimizeExecErrorStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeExecErrorStatsWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeRuleListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeRuleListResponse
         */
        public GetQueryOptimizeRuleListResponse GetQueryOptimizeRuleListWithOptions(GetQueryOptimizeRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeRuleList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeRuleListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeRuleListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeRuleListResponse
         */
        public async Task<GetQueryOptimizeRuleListResponse> GetQueryOptimizeRuleListWithOptionsAsync(GetQueryOptimizeRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeRuleList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeRuleListRequest
          * @return GetQueryOptimizeRuleListResponse
         */
        public GetQueryOptimizeRuleListResponse GetQueryOptimizeRuleList(GetQueryOptimizeRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeRuleListWithOptions(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeRuleListRequest
          * @return GetQueryOptimizeRuleListResponse
         */
        public async Task<GetQueryOptimizeRuleListResponse> GetQueryOptimizeRuleListAsync(GetQueryOptimizeRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeRuleListWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeShareUrlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeShareUrlResponse
         */
        public GetQueryOptimizeShareUrlResponse GetQueryOptimizeShareUrlWithOptions(GetQueryOptimizeShareUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeShareUrl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeShareUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeShareUrlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeShareUrlResponse
         */
        public async Task<GetQueryOptimizeShareUrlResponse> GetQueryOptimizeShareUrlWithOptionsAsync(GetQueryOptimizeShareUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeShareUrl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeShareUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeShareUrlRequest
          * @return GetQueryOptimizeShareUrlResponse
         */
        public GetQueryOptimizeShareUrlResponse GetQueryOptimizeShareUrl(GetQueryOptimizeShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeShareUrlWithOptions(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeShareUrlRequest
          * @return GetQueryOptimizeShareUrlResponse
         */
        public async Task<GetQueryOptimizeShareUrlResponse> GetQueryOptimizeShareUrlAsync(GetQueryOptimizeShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeShareUrlWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeSolutionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeSolutionResponse
         */
        public GetQueryOptimizeSolutionResponse GetQueryOptimizeSolutionWithOptions(GetQueryOptimizeSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeSolution",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeSolutionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeSolutionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeSolutionResponse
         */
        public async Task<GetQueryOptimizeSolutionResponse> GetQueryOptimizeSolutionWithOptionsAsync(GetQueryOptimizeSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeSolution",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeSolutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeSolutionRequest
          * @return GetQueryOptimizeSolutionResponse
         */
        public GetQueryOptimizeSolutionResponse GetQueryOptimizeSolution(GetQueryOptimizeSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeSolutionWithOptions(request, runtime);
        }

        /**
          * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeSolutionRequest
          * @return GetQueryOptimizeSolutionResponse
         */
        public async Task<GetQueryOptimizeSolutionResponse> GetQueryOptimizeSolutionAsync(GetQueryOptimizeSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeSolutionWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeTagRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeTagResponse
         */
        public GetQueryOptimizeTagResponse GetQueryOptimizeTagWithOptions(GetQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeTagResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeTagRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetQueryOptimizeTagResponse
         */
        public async Task<GetQueryOptimizeTagResponse> GetQueryOptimizeTagWithOptionsAsync(GetQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeTagRequest
          * @return GetQueryOptimizeTagResponse
         */
        public GetQueryOptimizeTagResponse GetQueryOptimizeTag(GetQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeTagWithOptions(request, runtime);
        }

        /**
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   PolarDB for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *
          * @param request GetQueryOptimizeTagRequest
          * @return GetQueryOptimizeTagResponse
         */
        public async Task<GetQueryOptimizeTagResponse> GetQueryOptimizeTagAsync(GetQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeTagWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.
          *
          * @param request GetRedisAllSessionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRedisAllSessionResponse
         */
        public GetRedisAllSessionResponse GetRedisAllSessionWithOptions(GetRedisAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRedisAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRedisAllSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.
          *
          * @param request GetRedisAllSessionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRedisAllSessionResponse
         */
        public async Task<GetRedisAllSessionResponse> GetRedisAllSessionWithOptionsAsync(GetRedisAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRedisAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRedisAllSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.
          *
          * @param request GetRedisAllSessionRequest
          * @return GetRedisAllSessionResponse
         */
        public GetRedisAllSessionResponse GetRedisAllSession(GetRedisAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRedisAllSessionWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis instances.
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * >  This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.
          *
          * @param request GetRedisAllSessionRequest
          * @return GetRedisAllSessionResponse
         */
        public async Task<GetRedisAllSessionResponse> GetRedisAllSessionAsync(GetRedisAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRedisAllSessionWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (Compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisPageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRequestDiagnosisPageResponse
         */
        public GetRequestDiagnosisPageResponse GetRequestDiagnosisPageWithOptions(GetRequestDiagnosisPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestDiagnosisPage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisPageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (Compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisPageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRequestDiagnosisPageResponse
         */
        public async Task<GetRequestDiagnosisPageResponse> GetRequestDiagnosisPageWithOptionsAsync(GetRequestDiagnosisPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestDiagnosisPage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (Compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisPageRequest
          * @return GetRequestDiagnosisPageResponse
         */
        public GetRequestDiagnosisPageResponse GetRequestDiagnosisPage(GetRequestDiagnosisPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRequestDiagnosisPageWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (Compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisPageRequest
          * @return GetRequestDiagnosisPageResponse
         */
        public async Task<GetRequestDiagnosisPageResponse> GetRequestDiagnosisPageAsync(GetRequestDiagnosisPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRequestDiagnosisPageWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRequestDiagnosisResultResponse
         */
        public GetRequestDiagnosisResultResponse GetRequestDiagnosisResultWithOptions(GetRequestDiagnosisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestDiagnosisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRequestDiagnosisResultResponse
         */
        public async Task<GetRequestDiagnosisResultResponse> GetRequestDiagnosisResultWithOptionsAsync(GetRequestDiagnosisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestDiagnosisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisResultRequest
          * @return GetRequestDiagnosisResultResponse
         */
        public GetRequestDiagnosisResultResponse GetRequestDiagnosisResult(GetRequestDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRequestDiagnosisResultWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL
          *     *   ApsaraDB RDS for PostgreSQL
          *     *   ApsaraDB RDS for SQL Server
          *     *   PolarDB for MySQL
          *     *   PolarDB for PostgreSQL (compatible with Oracle)
          *     *   ApsaraDB for MongoDB
          * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](~~146895~~).
          *
          * @param request GetRequestDiagnosisResultRequest
          * @return GetRequestDiagnosisResultResponse
         */
        public async Task<GetRequestDiagnosisResultResponse> GetRequestDiagnosisResultAsync(GetRequestDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRequestDiagnosisResultWithOptionsAsync(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetRunningSqlConcurrencyControlRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRunningSqlConcurrencyControlRulesResponse
         */
        public GetRunningSqlConcurrencyControlRulesResponse GetRunningSqlConcurrencyControlRulesWithOptions(GetRunningSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetRunningSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningSqlConcurrencyControlRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetRunningSqlConcurrencyControlRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRunningSqlConcurrencyControlRulesResponse
         */
        public async Task<GetRunningSqlConcurrencyControlRulesResponse> GetRunningSqlConcurrencyControlRulesWithOptionsAsync(GetRunningSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetRunningSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningSqlConcurrencyControlRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetRunningSqlConcurrencyControlRulesRequest
          * @return GetRunningSqlConcurrencyControlRulesResponse
         */
        public GetRunningSqlConcurrencyControlRulesResponse GetRunningSqlConcurrencyControlRules(GetRunningSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRunningSqlConcurrencyControlRulesWithOptions(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetRunningSqlConcurrencyControlRulesRequest
          * @return GetRunningSqlConcurrencyControlRulesResponse
         */
        public async Task<GetRunningSqlConcurrencyControlRulesResponse> GetRunningSqlConcurrencyControlRulesAsync(GetRunningSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRunningSqlConcurrencyControlRulesWithOptionsAsync(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlKeywordsFromSqlTextRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSqlConcurrencyControlKeywordsFromSqlTextResponse
         */
        public GetSqlConcurrencyControlKeywordsFromSqlTextResponse GetSqlConcurrencyControlKeywordsFromSqlTextWithOptions(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlText))
            {
                query["SqlText"] = request.SqlText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConcurrencyControlKeywordsFromSqlText",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlKeywordsFromSqlTextResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlKeywordsFromSqlTextRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSqlConcurrencyControlKeywordsFromSqlTextResponse
         */
        public async Task<GetSqlConcurrencyControlKeywordsFromSqlTextResponse> GetSqlConcurrencyControlKeywordsFromSqlTextWithOptionsAsync(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlText))
            {
                query["SqlText"] = request.SqlText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConcurrencyControlKeywordsFromSqlText",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlKeywordsFromSqlTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlKeywordsFromSqlTextRequest
          * @return GetSqlConcurrencyControlKeywordsFromSqlTextResponse
         */
        public GetSqlConcurrencyControlKeywordsFromSqlTextResponse GetSqlConcurrencyControlKeywordsFromSqlText(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSqlConcurrencyControlKeywordsFromSqlTextWithOptions(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlKeywordsFromSqlTextRequest
          * @return GetSqlConcurrencyControlKeywordsFromSqlTextResponse
         */
        public async Task<GetSqlConcurrencyControlKeywordsFromSqlTextResponse> GetSqlConcurrencyControlKeywordsFromSqlTextAsync(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSqlConcurrencyControlKeywordsFromSqlTextWithOptionsAsync(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlRulesHistoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSqlConcurrencyControlRulesHistoryResponse
         */
        public GetSqlConcurrencyControlRulesHistoryResponse GetSqlConcurrencyControlRulesHistoryWithOptions(GetSqlConcurrencyControlRulesHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetSqlConcurrencyControlRulesHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlRulesHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlRulesHistoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSqlConcurrencyControlRulesHistoryResponse
         */
        public async Task<GetSqlConcurrencyControlRulesHistoryResponse> GetSqlConcurrencyControlRulesHistoryWithOptionsAsync(GetSqlConcurrencyControlRulesHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetSqlConcurrencyControlRulesHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlRulesHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlRulesHistoryRequest
          * @return GetSqlConcurrencyControlRulesHistoryResponse
         */
        public GetSqlConcurrencyControlRulesHistoryResponse GetSqlConcurrencyControlRulesHistory(GetSqlConcurrencyControlRulesHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSqlConcurrencyControlRulesHistoryWithOptions(request, runtime);
        }

        /**
          * This operation supports the following database engines:
          * *   ApsaraDB RDS for MySQL
          * *   PolarDB for MySQL
          *
          * @param request GetSqlConcurrencyControlRulesHistoryRequest
          * @return GetSqlConcurrencyControlRulesHistoryResponse
         */
        public async Task<GetSqlConcurrencyControlRulesHistoryResponse> GetSqlConcurrencyControlRulesHistoryAsync(GetSqlConcurrencyControlRulesHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSqlConcurrencyControlRulesHistoryWithOptionsAsync(request, runtime);
        }

        /**
          * The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](~~167895~~).
          * >  You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetSqlOptimizeAdviceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSqlOptimizeAdviceResponse
         */
        public GetSqlOptimizeAdviceResponse GetSqlOptimizeAdviceWithOptions(GetSqlOptimizeAdviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDt))
            {
                query["EndDt"] = request.EndDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDt))
            {
                query["StartDt"] = request.StartDt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlOptimizeAdvice",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlOptimizeAdviceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](~~167895~~).
          * >  You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetSqlOptimizeAdviceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSqlOptimizeAdviceResponse
         */
        public async Task<GetSqlOptimizeAdviceResponse> GetSqlOptimizeAdviceWithOptionsAsync(GetSqlOptimizeAdviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDt))
            {
                query["EndDt"] = request.EndDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDt))
            {
                query["StartDt"] = request.StartDt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlOptimizeAdvice",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlOptimizeAdviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](~~167895~~).
          * >  You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetSqlOptimizeAdviceRequest
          * @return GetSqlOptimizeAdviceResponse
         */
        public GetSqlOptimizeAdviceResponse GetSqlOptimizeAdvice(GetSqlOptimizeAdviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSqlOptimizeAdviceWithOptions(request, runtime);
        }

        /**
          * The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](~~167895~~).
          * >  You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
          * Before you call this operation, take note of the following items:
          * *   This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request GetSqlOptimizeAdviceRequest
          * @return GetSqlOptimizeAdviceResponse
         */
        public async Task<GetSqlOptimizeAdviceResponse> GetSqlOptimizeAdviceAsync(GetSqlOptimizeAdviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSqlOptimizeAdviceWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from information_schema.tables. Due to the asynchronicity of the statistics update mechanism in MySQL, statistics and analysis results may not be perfectly accurate. You can execute the ANALYZE TABLE statement on related tables during off-peak hours to obtain the latest information.
          *
          * @param request GetStorageAnalysisResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStorageAnalysisResultResponse
         */
        public GetStorageAnalysisResultResponse GetStorageAnalysisResultWithOptions(GetStorageAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStorageAnalysisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageAnalysisResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from information_schema.tables. Due to the asynchronicity of the statistics update mechanism in MySQL, statistics and analysis results may not be perfectly accurate. You can execute the ANALYZE TABLE statement on related tables during off-peak hours to obtain the latest information.
          *
          * @param request GetStorageAnalysisResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStorageAnalysisResultResponse
         */
        public async Task<GetStorageAnalysisResultResponse> GetStorageAnalysisResultWithOptionsAsync(GetStorageAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStorageAnalysisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageAnalysisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from information_schema.tables. Due to the asynchronicity of the statistics update mechanism in MySQL, statistics and analysis results may not be perfectly accurate. You can execute the ANALYZE TABLE statement on related tables during off-peak hours to obtain the latest information.
          *
          * @param request GetStorageAnalysisResultRequest
          * @return GetStorageAnalysisResultResponse
         */
        public GetStorageAnalysisResultResponse GetStorageAnalysisResult(GetStorageAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStorageAnalysisResultWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
          * *   The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from information_schema.tables. Due to the asynchronicity of the statistics update mechanism in MySQL, statistics and analysis results may not be perfectly accurate. You can execute the ANALYZE TABLE statement on related tables during off-peak hours to obtain the latest information.
          *
          * @param request GetStorageAnalysisResultRequest
          * @return GetStorageAnalysisResultResponse
         */
        public async Task<GetStorageAnalysisResultResponse> GetStorageAnalysisResultAsync(GetStorageAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStorageAnalysisResultWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis.
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request KillInstanceAllSessionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return KillInstanceAllSessionResponse
         */
        public KillInstanceAllSessionResponse KillInstanceAllSessionWithOptions(KillInstanceAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillInstanceAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillInstanceAllSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis.
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request KillInstanceAllSessionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return KillInstanceAllSessionResponse
         */
        public async Task<KillInstanceAllSessionResponse> KillInstanceAllSessionWithOptionsAsync(KillInstanceAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillInstanceAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillInstanceAllSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis.
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request KillInstanceAllSessionRequest
          * @return KillInstanceAllSessionResponse
         */
        public KillInstanceAllSessionResponse KillInstanceAllSession(KillInstanceAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillInstanceAllSessionWithOptions(request, runtime);
        }

        /**
          * *   This operation is applicable only to ApsaraDB for Redis.
          * *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
          * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request KillInstanceAllSessionRequest
          * @return KillInstanceAllSessionResponse
         */
        public async Task<KillInstanceAllSessionResponse> KillInstanceAllSessionAsync(KillInstanceAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillInstanceAllSessionWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
          * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
          *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](~~173345~~).
          * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
          *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](~~216312~~).
          * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
          *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request ModifyAutoScalingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyAutoScalingConfigResponse
         */
        public ModifyAutoScalingConfigResponse ModifyAutoScalingConfigWithOptions(ModifyAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                query["Shard"] = request.Shard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoScalingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
          * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
          *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](~~173345~~).
          * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
          *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](~~216312~~).
          * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
          *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request ModifyAutoScalingConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyAutoScalingConfigResponse
         */
        public async Task<ModifyAutoScalingConfigResponse> ModifyAutoScalingConfigWithOptionsAsync(ModifyAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                query["Shard"] = request.Shard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoScalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
          * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
          *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](~~173345~~).
          * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
          *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](~~216312~~).
          * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
          *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request ModifyAutoScalingConfigRequest
          * @return ModifyAutoScalingConfigResponse
         */
        public ModifyAutoScalingConfigResponse ModifyAutoScalingConfig(ModifyAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoScalingConfigWithOptions(request, runtime);
        }

        /**
          * You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
          * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
          *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
          *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](~~173345~~).
          * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
          *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](~~216312~~).
          * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
          *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](~~169686~~).
          * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
          *
          * @param request ModifyAutoScalingConfigRequest
          * @return ModifyAutoScalingConfigResponse
         */
        public async Task<ModifyAutoScalingConfigResponse> ModifyAutoScalingConfigAsync(ModifyAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoScalingConfigWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request RunCloudBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RunCloudBenchTaskResponse
         */
        public RunCloudBenchTaskResponse RunCloudBenchTaskWithOptions(RunCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCloudBenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request RunCloudBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RunCloudBenchTaskResponse
         */
        public async Task<RunCloudBenchTaskResponse> RunCloudBenchTaskWithOptionsAsync(RunCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCloudBenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request RunCloudBenchTaskRequest
          * @return RunCloudBenchTaskResponse
         */
        public RunCloudBenchTaskResponse RunCloudBenchTask(RunCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCloudBenchTaskWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request RunCloudBenchTaskRequest
          * @return RunCloudBenchTaskResponse
         */
        public async Task<RunCloudBenchTaskResponse> RunCloudBenchTaskAsync(RunCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCloudBenchTaskWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request SetEventSubscriptionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetEventSubscriptionResponse
         */
        public SetEventSubscriptionResponse SetEventSubscriptionWithOptions(SetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchRule))
            {
                query["DispatchRule"] = request.DispatchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInterval))
            {
                query["MinInterval"] = request.MinInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEventSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request SetEventSubscriptionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetEventSubscriptionResponse
         */
        public async Task<SetEventSubscriptionResponse> SetEventSubscriptionWithOptionsAsync(SetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchRule))
            {
                query["DispatchRule"] = request.DispatchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInterval))
            {
                query["MinInterval"] = request.MinInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEventSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request SetEventSubscriptionRequest
          * @return SetEventSubscriptionResponse
         */
        public SetEventSubscriptionResponse SetEventSubscription(SetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEventSubscriptionWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
          * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
          * *   The database instance that you want to manage is connected to DAS.
          *
          * @param request SetEventSubscriptionRequest
          * @return SetEventSubscriptionResponse
         */
        public async Task<SetEventSubscriptionResponse> SetEventSubscriptionAsync(SetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEventSubscriptionWithOptionsAsync(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request StopCloudBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopCloudBenchTaskResponse
         */
        public StopCloudBenchTaskResponse StopCloudBenchTaskWithOptions(StopCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudBenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request StopCloudBenchTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopCloudBenchTaskResponse
         */
        public async Task<StopCloudBenchTaskResponse> StopCloudBenchTaskWithOptionsAsync(StopCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCloudBenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request StopCloudBenchTaskRequest
          * @return StopCloudBenchTaskResponse
         */
        public StopCloudBenchTaskResponse StopCloudBenchTask(StopCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCloudBenchTaskWithOptions(request, runtime);
        }

        /**
          * Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](~~155068~~).
          *
          * @param request StopCloudBenchTaskRequest
          * @return StopCloudBenchTaskResponse
         */
        public async Task<StopCloudBenchTaskResponse> StopCloudBenchTaskAsync(StopCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCloudBenchTaskWithOptionsAsync(request, runtime);
        }

        public SyncHDMAliyunResourceResponse SyncHDMAliyunResourceWithOptions(SyncHDMAliyunResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForModifySecurityIps))
            {
                query["WaitForModifySecurityIps"] = request.WaitForModifySecurityIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncHDMAliyunResource",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncHDMAliyunResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncHDMAliyunResourceResponse> SyncHDMAliyunResourceWithOptionsAsync(SyncHDMAliyunResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForModifySecurityIps))
            {
                query["WaitForModifySecurityIps"] = request.WaitForModifySecurityIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncHDMAliyunResource",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncHDMAliyunResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SyncHDMAliyunResourceResponse SyncHDMAliyunResource(SyncHDMAliyunResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncHDMAliyunResourceWithOptions(request, runtime);
        }

        public async Task<SyncHDMAliyunResourceResponse> SyncHDMAliyunResourceAsync(SyncHDMAliyunResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncHDMAliyunResourceWithOptionsAsync(request, runtime);
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   DAS Professional Edition is enabled for the database instance. You can call the [DescribeInstanceDasPro](~~413866~~) operation to check whether DAS Professional Edition is enabled for a database instance.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request UpdateAutoResourceOptimizeRulesAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAutoResourceOptimizeRulesAsyncResponse
         */
        public UpdateAutoResourceOptimizeRulesAsyncResponse UpdateAutoResourceOptimizeRulesAsyncWithOptions(UpdateAutoResourceOptimizeRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableFragmentationRatio))
            {
                query["TableFragmentationRatio"] = request.TableFragmentationRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableSpaceSize))
            {
                query["TableSpaceSize"] = request.TableSpaceSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoResourceOptimizeRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoResourceOptimizeRulesAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   DAS Professional Edition is enabled for the database instance. You can call the [DescribeInstanceDasPro](~~413866~~) operation to check whether DAS Professional Edition is enabled for a database instance.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request UpdateAutoResourceOptimizeRulesAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAutoResourceOptimizeRulesAsyncResponse
         */
        public async Task<UpdateAutoResourceOptimizeRulesAsyncResponse> UpdateAutoResourceOptimizeRulesAsyncWithOptionsAsync(UpdateAutoResourceOptimizeRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableFragmentationRatio))
            {
                query["TableFragmentationRatio"] = request.TableFragmentationRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableSpaceSize))
            {
                query["TableSpaceSize"] = request.TableSpaceSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoResourceOptimizeRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoResourceOptimizeRulesAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   DAS Professional Edition is enabled for the database instance. You can call the [DescribeInstanceDasPro](~~413866~~) operation to check whether DAS Professional Edition is enabled for a database instance.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request UpdateAutoResourceOptimizeRulesAsyncRequest
          * @return UpdateAutoResourceOptimizeRulesAsyncResponse
         */
        public UpdateAutoResourceOptimizeRulesAsyncResponse UpdateAutoResourceOptimizeRulesAsync(UpdateAutoResourceOptimizeRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoResourceOptimizeRulesAsyncWithOptions(request, runtime);
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.
          * *   DAS Professional Edition is enabled for the database instance. You can call the [DescribeInstanceDasPro](~~413866~~) operation to check whether DAS Professional Edition is enabled for a database instance.
          * *   The database instance has four or more cores, and **innodb_file_per_table** is set to **ON**.
          *
          * @param request UpdateAutoResourceOptimizeRulesAsyncRequest
          * @return UpdateAutoResourceOptimizeRulesAsyncResponse
         */
        public async Task<UpdateAutoResourceOptimizeRulesAsyncResponse> UpdateAutoResourceOptimizeRulesAsyncAsync(UpdateAutoResourceOptimizeRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoResourceOptimizeRulesAsyncWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   DAS Professional Edition is enabled for the database instance that you want to manage. To enable DAS Professional Edition for a database instance, you can call the [EnableDasPro](~~411645~~) operation.
          * *   The autonomy service is enabled for the database instance. For more information, see [Autonomy center](~~152139~~).
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL High-availability Edition and Enterprise Edition
          *     *   PolarDB for MySQL Cluster Edition and X-Engine Edition
          *
          * @param request UpdateAutoSqlOptimizeStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAutoSqlOptimizeStatusResponse
         */
        public UpdateAutoSqlOptimizeStatusResponse UpdateAutoSqlOptimizeStatusWithOptions(UpdateAutoSqlOptimizeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoSqlOptimizeStatus",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoSqlOptimizeStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   DAS Professional Edition is enabled for the database instance that you want to manage. To enable DAS Professional Edition for a database instance, you can call the [EnableDasPro](~~411645~~) operation.
          * *   The autonomy service is enabled for the database instance. For more information, see [Autonomy center](~~152139~~).
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL High-availability Edition and Enterprise Edition
          *     *   PolarDB for MySQL Cluster Edition and X-Engine Edition
          *
          * @param request UpdateAutoSqlOptimizeStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAutoSqlOptimizeStatusResponse
         */
        public async Task<UpdateAutoSqlOptimizeStatusResponse> UpdateAutoSqlOptimizeStatusWithOptionsAsync(UpdateAutoSqlOptimizeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoSqlOptimizeStatus",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoSqlOptimizeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   DAS Professional Edition is enabled for the database instance that you want to manage. To enable DAS Professional Edition for a database instance, you can call the [EnableDasPro](~~411645~~) operation.
          * *   The autonomy service is enabled for the database instance. For more information, see [Autonomy center](~~152139~~).
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL High-availability Edition and Enterprise Edition
          *     *   PolarDB for MySQL Cluster Edition and X-Engine Edition
          *
          * @param request UpdateAutoSqlOptimizeStatusRequest
          * @return UpdateAutoSqlOptimizeStatusResponse
         */
        public UpdateAutoSqlOptimizeStatusResponse UpdateAutoSqlOptimizeStatus(UpdateAutoSqlOptimizeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoSqlOptimizeStatusWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   DAS Professional Edition is enabled for the database instance that you want to manage. To enable DAS Professional Edition for a database instance, you can call the [EnableDasPro](~~411645~~) operation.
          * *   The autonomy service is enabled for the database instance. For more information, see [Autonomy center](~~152139~~).
          * *   This operation supports the following database engines:
          *     *   ApsaraDB RDS for MySQL High-availability Edition and Enterprise Edition
          *     *   PolarDB for MySQL Cluster Edition and X-Engine Edition
          *
          * @param request UpdateAutoSqlOptimizeStatusRequest
          * @return UpdateAutoSqlOptimizeStatusResponse
         */
        public async Task<UpdateAutoSqlOptimizeStatusResponse> UpdateAutoSqlOptimizeStatusAsync(UpdateAutoSqlOptimizeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoSqlOptimizeStatusWithOptionsAsync(request, runtime);
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](~~152139~~).
          * *   The database instance that you want to manage must be of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0
          *     *   PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, and PolarDB for MySQL X-Engine Edition that runs MySQL 8.0
          *
          * @param request UpdateAutoThrottleRulesAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAutoThrottleRulesAsyncResponse
         */
        public UpdateAutoThrottleRulesAsyncResponse UpdateAutoThrottleRulesAsyncWithOptions(UpdateAutoThrottleRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbnormalDuration))
            {
                query["AbnormalDuration"] = request.AbnormalDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveSessions))
            {
                query["ActiveSessions"] = request.ActiveSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleEndTime))
            {
                query["AllowThrottleEndTime"] = request.AllowThrottleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleStartTime))
            {
                query["AllowThrottleStartTime"] = request.AllowThrottleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoKillSession))
            {
                query["AutoKillSession"] = request.AutoKillSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuSessionRelation))
            {
                query["CpuSessionRelation"] = request.CpuSessionRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuUsage))
            {
                query["CpuUsage"] = request.CpuUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxThrottleTime))
            {
                query["MaxThrottleTime"] = request.MaxThrottleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoThrottleRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoThrottleRulesAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](~~152139~~).
          * *   The database instance that you want to manage must be of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0
          *     *   PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, and PolarDB for MySQL X-Engine Edition that runs MySQL 8.0
          *
          * @param request UpdateAutoThrottleRulesAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAutoThrottleRulesAsyncResponse
         */
        public async Task<UpdateAutoThrottleRulesAsyncResponse> UpdateAutoThrottleRulesAsyncWithOptionsAsync(UpdateAutoThrottleRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbnormalDuration))
            {
                query["AbnormalDuration"] = request.AbnormalDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveSessions))
            {
                query["ActiveSessions"] = request.ActiveSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleEndTime))
            {
                query["AllowThrottleEndTime"] = request.AllowThrottleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleStartTime))
            {
                query["AllowThrottleStartTime"] = request.AllowThrottleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoKillSession))
            {
                query["AutoKillSession"] = request.AutoKillSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuSessionRelation))
            {
                query["CpuSessionRelation"] = request.CpuSessionRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuUsage))
            {
                query["CpuUsage"] = request.CpuUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxThrottleTime))
            {
                query["MaxThrottleTime"] = request.MaxThrottleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoThrottleRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoThrottleRulesAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](~~152139~~).
          * *   The database instance that you want to manage must be of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0
          *     *   PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, and PolarDB for MySQL X-Engine Edition that runs MySQL 8.0
          *
          * @param request UpdateAutoThrottleRulesAsyncRequest
          * @return UpdateAutoThrottleRulesAsyncResponse
         */
        public UpdateAutoThrottleRulesAsyncResponse UpdateAutoThrottleRulesAsync(UpdateAutoThrottleRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoThrottleRulesAsyncWithOptions(request, runtime);
        }

        /**
          * >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
          * Before you call this operation, take note of the following items:
          * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
          * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](~~152139~~).
          * *   The database instance that you want to manage must be of one of the following types:
          *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0
          *     *   PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0, and PolarDB for MySQL X-Engine Edition that runs MySQL 8.0
          *
          * @param request UpdateAutoThrottleRulesAsyncRequest
          * @return UpdateAutoThrottleRulesAsyncResponse
         */
        public async Task<UpdateAutoThrottleRulesAsyncResponse> UpdateAutoThrottleRulesAsyncAsync(UpdateAutoThrottleRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoThrottleRulesAsyncWithOptionsAsync(request, runtime);
        }

    }
}
