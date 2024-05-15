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
         * @summary Adds a database instance to Database Autonomy Service (DAS).
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Adds a database instance to Database Autonomy Service (DAS).
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Adds a database instance to Database Autonomy Service (DAS).
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Adds a database instance to Database Autonomy Service (DAS).
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a stress testing task on Advanced Database & Application Migration (ADAM).
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. You can create an Advanced Database & Application Migration (ADAM) stress testing task to check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
         * Make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates a stress testing task on Advanced Database & Application Migration (ADAM).
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. You can create an Advanced Database & Application Migration (ADAM) stress testing task to check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
         * Make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates a stress testing task on Advanced Database & Application Migration (ADAM).
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. You can create an Advanced Database & Application Migration (ADAM) stress testing task to check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
         * Make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates a stress testing task on Advanced Database & Application Migration (ADAM).
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. You can create an Advanced Database & Application Migration (ADAM) stress testing task to check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
         * Make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html). Before you call this API operation, make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html). Before you call this API operation, make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html). Before you call this API operation, make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html). Before you call this API operation, make sure that your database instances meet the following requirements:
         * *   The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition or X-Engine Edition cluster.
         * *   The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
         * *   The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see [Connect an Alibaba Cloud database instance to DAS](https://help.aliyun.com/document_detail/65405.html).
         * *   DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Creates a diagnostic report.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a diagnostic report.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a diagnostic report.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a diagnostic report.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Creates a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Creates a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Creates a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Creates a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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

        /**
         * @summary 创建结束会话的任务
         *
         * @param request CreateKillInstanceSessionTaskWithMaintainUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKillInstanceSessionTaskWithMaintainUserResponse
         */
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

        /**
         * @summary 创建结束会话的任务
         *
         * @param request CreateKillInstanceSessionTaskWithMaintainUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKillInstanceSessionTaskWithMaintainUserResponse
         */
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

        /**
         * @summary 创建结束会话的任务
         *
         * @param request CreateKillInstanceSessionTaskWithMaintainUserRequest
         * @return CreateKillInstanceSessionTaskWithMaintainUserResponse
         */
        public CreateKillInstanceSessionTaskWithMaintainUserResponse CreateKillInstanceSessionTaskWithMaintainUser(CreateKillInstanceSessionTaskWithMaintainUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKillInstanceSessionTaskWithMaintainUserWithOptions(request, runtime);
        }

        /**
         * @summary 创建结束会话的任务
         *
         * @param request CreateKillInstanceSessionTaskWithMaintainUserRequest
         * @return CreateKillInstanceSessionTaskWithMaintainUserResponse
         */
        public async Task<CreateKillInstanceSessionTaskWithMaintainUserResponse> CreateKillInstanceSessionTaskWithMaintainUserAsync(CreateKillInstanceSessionTaskWithMaintainUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKillInstanceSessionTaskWithMaintainUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a tag to a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Adds a tag to a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Adds a tag to a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Adds a tag to a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Initiates an SQL statement diagnostics request.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Initiates an SQL statement diagnostics request.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Initiates an SQL statement diagnostics request.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Initiates an SQL statement diagnostics request.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Creates an SQL Explorer and Audit task.
         *
         * @param request CreateSqlLogTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSqlLogTaskResponse
         */
        public CreateSqlLogTaskResponse CreateSqlLogTaskWithOptions(CreateSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlLogTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an SQL Explorer and Audit task.
         *
         * @param request CreateSqlLogTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSqlLogTaskResponse
         */
        public async Task<CreateSqlLogTaskResponse> CreateSqlLogTaskWithOptionsAsync(CreateSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlLogTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an SQL Explorer and Audit task.
         *
         * @param request CreateSqlLogTaskRequest
         * @return CreateSqlLogTaskResponse
         */
        public CreateSqlLogTaskResponse CreateSqlLogTask(CreateSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSqlLogTaskWithOptions(request, runtime);
        }

        /**
         * @summary Creates an SQL Explorer and Audit task.
         *
         * @param request CreateSqlLogTaskRequest
         * @return CreateSqlLogTaskResponse
         */
        public async Task<CreateSqlLogTaskResponse> CreateSqlLogTaskAsync(CreateSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSqlLogTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a storage analysis task to query the usage details of one or more databases and tables.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Creates a storage analysis task to query the usage details of one or more databases and tables.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Creates a storage analysis task to query the usage details of one or more databases and tables.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Creates a storage analysis task to query the usage details of one or more databases and tables.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Deletes a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Deletes a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Deletes a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Deletes a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Deletes the metadata of a stopped DBGateway.
         *
         * @description *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](https://help.aliyun.com/document_detail/230665.html) operation.
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
         * @summary Deletes the metadata of a stopped DBGateway.
         *
         * @description *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](https://help.aliyun.com/document_detail/230665.html) operation.
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
         * @summary Deletes the metadata of a stopped DBGateway.
         *
         * @description *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](https://help.aliyun.com/document_detail/230665.html) operation.
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
         * @summary Deletes the metadata of a stopped DBGateway.
         *
         * @description *   This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the [CreateCloudBenchTasks](https://help.aliyun.com/document_detail/230665.html) operation.
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
         * @summary Queries the configurations of the auto scaling feature for an instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the configurations of the auto scaling feature for an instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the configurations of the auto scaling feature for an instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the configurations of the auto scaling feature for an instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the auto scaling history of an instance.
         *
         * @description *   You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Queries the auto scaling history of an instance.
         *
         * @description *   You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Queries the auto scaling history of an instance.
         *
         * @description *   You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Queries the auto scaling history of an instance.
         *
         * @description *   You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Queries the details of a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the details of a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the details of a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the details of a cache analysis task.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries a list of cache analysis tasks.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries a list of cache analysis tasks.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries a list of cache analysis tasks.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries a list of cache analysis tasks.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries stress testing tasks.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries the configurations of a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries the configurations of a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries the configurations of a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries the configurations of a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Queries diagnostics reports.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries diagnostics reports.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries diagnostics reports.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries diagnostics reports.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the hot keys and the large keys in the memory in real time.
         *
         * @description This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
         *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the hot keys and the large keys in the memory in real time.
         *
         * @description This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
         *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the hot keys and the large keys in the memory in real time.
         *
         * @description This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
         *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the hot keys and the large keys in the memory in real time.
         *
         * @description This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for ApsaraDB for Redis instances that meet the following requirements:
         *     *   The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the hot keys of an ApsaraDB for Redis instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
         * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
         *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the hot keys of an ApsaraDB for Redis instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
         * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
         *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the hot keys of an ApsaraDB for Redis instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
         * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
         *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the hot keys of an ApsaraDB for Redis instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.
         * *   The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:
         *     *   The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For more information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries whether Database Autonomy Service (DAS) Enterprise Edition is enabled for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries whether Database Autonomy Service (DAS) Enterprise Edition is enabled for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries whether Database Autonomy Service (DAS) Enterprise Edition is enabled for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries whether Database Autonomy Service (DAS) Enterprise Edition is enabled for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries the configurations of SQL Explorer and Audit.
         *
         * @param request DescribeSqlLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogConfigResponse
         */
        public DescribeSqlLogConfigResponse DescribeSqlLogConfigWithOptions(DescribeSqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the configurations of SQL Explorer and Audit.
         *
         * @param request DescribeSqlLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogConfigResponse
         */
        public async Task<DescribeSqlLogConfigResponse> DescribeSqlLogConfigWithOptionsAsync(DescribeSqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the configurations of SQL Explorer and Audit.
         *
         * @param request DescribeSqlLogConfigRequest
         * @return DescribeSqlLogConfigResponse
         */
        public DescribeSqlLogConfigResponse DescribeSqlLogConfig(DescribeSqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of SQL Explorer and Audit.
         *
         * @param request DescribeSqlLogConfigRequest
         * @return DescribeSqlLogConfigResponse
         */
        public async Task<DescribeSqlLogConfigResponse> DescribeSqlLogConfigAsync(DescribeSqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询明细数据列表
         *
         * @param request DescribeSqlLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogRecordsResponse
         */
        public DescribeSqlLogRecordsResponse DescribeSqlLogRecordsWithOptions(DescribeSqlLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogRecords",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询明细数据列表
         *
         * @param request DescribeSqlLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogRecordsResponse
         */
        public async Task<DescribeSqlLogRecordsResponse> DescribeSqlLogRecordsWithOptionsAsync(DescribeSqlLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogRecords",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询明细数据列表
         *
         * @param request DescribeSqlLogRecordsRequest
         * @return DescribeSqlLogRecordsResponse
         */
        public DescribeSqlLogRecordsResponse DescribeSqlLogRecords(DescribeSqlLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 查询明细数据列表
         *
         * @param request DescribeSqlLogRecordsRequest
         * @return DescribeSqlLogRecordsResponse
         */
        public async Task<DescribeSqlLogRecordsResponse> DescribeSqlLogRecordsAsync(DescribeSqlLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数据量统计接口
         *
         * @param request DescribeSqlLogStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogStatisticResponse
         */
        public DescribeSqlLogStatisticResponse DescribeSqlLogStatisticWithOptions(DescribeSqlLogStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数据量统计接口
         *
         * @param request DescribeSqlLogStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogStatisticResponse
         */
        public async Task<DescribeSqlLogStatisticResponse> DescribeSqlLogStatisticWithOptionsAsync(DescribeSqlLogStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数据量统计接口
         *
         * @param request DescribeSqlLogStatisticRequest
         * @return DescribeSqlLogStatisticResponse
         */
        public DescribeSqlLogStatisticResponse DescribeSqlLogStatistic(DescribeSqlLogStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogStatisticWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据量统计接口
         *
         * @param request DescribeSqlLogStatisticRequest
         * @return DescribeSqlLogStatisticResponse
         */
        public async Task<DescribeSqlLogStatisticResponse> DescribeSqlLogStatisticAsync(DescribeSqlLogStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogStatisticWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询离线任务详情
         *
         * @param request DescribeSqlLogTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogTaskResponse
         */
        public DescribeSqlLogTaskResponse DescribeSqlLogTaskWithOptions(DescribeSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询离线任务详情
         *
         * @param request DescribeSqlLogTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogTaskResponse
         */
        public async Task<DescribeSqlLogTaskResponse> DescribeSqlLogTaskWithOptionsAsync(DescribeSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询离线任务详情
         *
         * @param request DescribeSqlLogTaskRequest
         * @return DescribeSqlLogTaskResponse
         */
        public DescribeSqlLogTaskResponse DescribeSqlLogTask(DescribeSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogTaskWithOptions(request, runtime);
        }

        /**
         * @summary 查询离线任务详情
         *
         * @param request DescribeSqlLogTaskRequest
         * @return DescribeSqlLogTaskResponse
         */
        public async Task<DescribeSqlLogTaskResponse> DescribeSqlLogTaskAsync(DescribeSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the SQL Explorer and Audit tasks.
         *
         * @param request DescribeSqlLogTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogTasksResponse
         */
        public DescribeSqlLogTasksResponse DescribeSqlLogTasksWithOptions(DescribeSqlLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
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
                Action = "DescribeSqlLogTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the SQL Explorer and Audit tasks.
         *
         * @param request DescribeSqlLogTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlLogTasksResponse
         */
        public async Task<DescribeSqlLogTasksResponse> DescribeSqlLogTasksWithOptionsAsync(DescribeSqlLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
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
                Action = "DescribeSqlLogTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the SQL Explorer and Audit tasks.
         *
         * @param request DescribeSqlLogTasksRequest
         * @return DescribeSqlLogTasksResponse
         */
        public DescribeSqlLogTasksResponse DescribeSqlLogTasks(DescribeSqlLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries the SQL Explorer and Audit tasks.
         *
         * @param request DescribeSqlLogTasksRequest
         * @return DescribeSqlLogTasksResponse
         */
        public async Task<DescribeSqlLogTasksResponse> DescribeSqlLogTasksAsync(DescribeSqlLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 100 large keys over a period of time.
         *
         * @description The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the top 100 large keys over a period of time.
         *
         * @description The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the top 100 large keys over a period of time.
         *
         * @description The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the top 100 large keys over a period of time.
         *
         * @description The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) and [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html).
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
         * @summary Queries the top 100 hot keys over a period of time.
         *
         * @description If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html) and [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html).
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
         * @summary Queries the top 100 hot keys over a period of time.
         *
         * @description If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html) and [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html).
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
         * @summary Queries the top 100 hot keys over a period of time.
         *
         * @description If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html) and [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html).
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
         * @summary Queries the top 100 hot keys over a period of time.
         *
         * @description If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.
         * *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.
         * *   The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is available only for an ApsaraDB for Redis instance of one of the following versions:
         *     *   The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).
         *     *   The ApsaraDB for Redis instance is updated to the latest minor version.
         * >  For information about how to query and update the minor version of an instance, see [DescribeEngineVersion](https://help.aliyun.com/document_detail/95268.html) and [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html).
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
         * @summary Disables all throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Disables all throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Disables all throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Disables all throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Disables the automatic tablespace fragment recycling feature for database instances at a time.
         *
         * @description If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables the automatic tablespace fragment recycling feature for database instances at a time.
         *
         * @description If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables the automatic tablespace fragment recycling feature for database instances at a time.
         *
         * @description If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables the automatic tablespace fragment recycling feature for database instances at a time.
         *
         * @description If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Disables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Disables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Disables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Disables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Disables the auto scaling feature for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Disables the auto scaling feature for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Disables the auto scaling feature for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Disables the auto scaling feature for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Disables a throttling rule.
         *
         * @description This operation is applicable to the following database engines:
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
         * @summary Disables a throttling rule.
         *
         * @description This operation is applicable to the following database engines:
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
         * @summary Disables a throttling rule.
         *
         * @description This operation is applicable to the following database engines:
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
         * @summary Disables a throttling rule.
         *
         * @description This operation is applicable to the following database engines:
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
         * @summary Enables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Enables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Enables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Enables Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @description *   For more information about database instances that support DAS Enterprise Edition, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1.
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
         * @summary Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.
         *
         * @description This operation supports the following database engines:
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
         * @summary Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.
         *
         * @description This operation supports the following database engines:
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
         * @summary Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.
         *
         * @description This operation supports the following database engines:
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
         * @summary Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.
         *
         * @description This operation supports the following database engines:
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
         * @summary Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.
         *
         * @description >  GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.
         *
         * @description >  GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.
         *
         * @description >  GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.
         *
         * @description >  GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.
         *
         * @description >  GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.
         *
         * @description >  GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.
         *
         * @description >  GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.
         *
         * @description >  GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.
         *
         * @description >  GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.
         *
         * @description >  GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.
         *
         * @description >  GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.
         *
         * @description >  GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
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
         * @summary Queries the usage of auto-increment table IDs.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the usage of auto-increment table IDs.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the usage of auto-increment table IDs.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the usage of auto-increment table IDs.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the automatic fragment recycling rules of database instances.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the automatic fragment recycling rules of database instances.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the automatic fragment recycling rules of database instances.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the automatic fragment recycling rules of database instances.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the automatic SQL throttling rules of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the automatic SQL throttling rules of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the automatic SQL throttling rules of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the automatic SQL throttling rules of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the details of notification events of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the details of notification events of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the details of notification events of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the details of notification events of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the notification events of one or more urgency levels within a period.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the notification events of one or more urgency levels within a period.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the notification events of one or more urgency levels within a period.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the notification events of one or more urgency levels within a period.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.
         * >  You can query the details of notification events only if the autonomy center is enabled. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Queries the blocking statistics of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the blocking statistics of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the blocking statistics of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the blocking statistics of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the storage usage of SQL Explorer of a database instance.
         *
         * @description *   For information about database instances that support this operation, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries the storage usage of SQL Explorer of a database instance.
         *
         * @description *   For information about database instances that support this operation, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries the storage usage of SQL Explorer of a database instance.
         *
         * @description *   For information about database instances that support this operation, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries the storage usage of SQL Explorer of a database instance.
         *
         * @description *   For information about database instances that support this operation, see [Overview of DAS Enterprise Edition](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   This operation is applicable only to DAS Enterprise Edition V1 and V2.
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
         * @summary Queries the details of the hot storage data that the new SQL Explorer and Audit feature generates for a database instance within the last seven days.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
         * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](https://help.aliyun.com/document_detail/92561.html) section of the "Overview" topic.
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
         * @summary Queries the details of the hot storage data that the new SQL Explorer and Audit feature generates for a database instance within the last seven days.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
         * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](https://help.aliyun.com/document_detail/92561.html) section of the "Overview" topic.
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
         * @summary Queries the details of the hot storage data that the new SQL Explorer and Audit feature generates for a database instance within the last seven days.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
         * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](https://help.aliyun.com/document_detail/92561.html) section of the "Overview" topic.
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
         * @summary Queries the details of the hot storage data that the new SQL Explorer and Audit feature generates for a database instance within the last seven days.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL database or a PolarDB for MySQL database in the China (Shanghai) region is connected to DAS.
         * *   The new SQL Explorer and Audit feature is enabled for the database instance. For more information, see the [Enable the SQL Explorer and Audit feature](https://help.aliyun.com/document_detail/92561.html) section of the "Overview" topic.
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
         * @summary Queries the deadlock details of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the deadlock details of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the deadlock details of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the deadlock details of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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

        /**
         * @param request GetEndpointSwitchTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEndpointSwitchTaskResponse
         */
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

        /**
         * @param request GetEndpointSwitchTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEndpointSwitchTaskResponse
         */
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

        /**
         * @param request GetEndpointSwitchTaskRequest
         * @return GetEndpointSwitchTaskResponse
         */
        public GetEndpointSwitchTaskResponse GetEndpointSwitchTask(GetEndpointSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEndpointSwitchTaskWithOptions(request, runtime);
        }

        /**
         * @param request GetEndpointSwitchTaskRequest
         * @return GetEndpointSwitchTaskResponse
         */
        public async Task<GetEndpointSwitchTaskResponse> GetEndpointSwitchTaskAsync(GetEndpointSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEndpointSwitchTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.
         *
         * @description >  GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.
         *
         * @description >  GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.
         *
         * @description >  GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.
         *
         * @description >  GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * *   This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see [Purchase DAS Enterprise Edition](https://help.aliyun.com/document_detail/163298.html).
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Queries the event subscription settings of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the event subscription settings of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the event subscription settings of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the event subscription settings of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Collects the full request statistics in the SQL Explorer results of a database instance by access source.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support this feature, see [Overview](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Collects the full request statistics in the SQL Explorer results of a database instance by access source.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support this feature, see [Overview](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Collects the full request statistics in the SQL Explorer results of a database instance by access source.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support this feature, see [Overview](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Collects the full request statistics in the SQL Explorer results of a database instance by access source.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support this feature, see [Overview](https://help.aliyun.com/document_detail/190912.html).
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
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
         * @summary Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
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
         * @summary Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
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
         * @summary Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
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
         * @summary Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.
         *
         * @description The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about the database engines that support SQL Explorer, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
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
         * @summary Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.
         *
         * @description >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
         * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support SQL Explorer, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.
         *
         * @description >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
         * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support SQL Explorer, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.
         *
         * @description >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
         * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support SQL Explorer, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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
         * @summary Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.
         *
         * @description >  The complete query results are not returned immediately after an asynchronous request is sent. If the value of isFinish is **false** in the response, wait for 1 second and send the request again. The complete query results are returned until the value of isFinish is **true**.
         * The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see [SQL Explorer](https://help.aliyun.com/document_detail/204096.html).
         * *   For more information about database instances that support SQL Explorer, see [Overview](https://help.aliyun.com/document_detail/190912.html).
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

        /**
         * @param request GetHDMAliyunResourceSyncResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHDMAliyunResourceSyncResultResponse
         */
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

        /**
         * @param request GetHDMAliyunResourceSyncResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHDMAliyunResourceSyncResultResponse
         */
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

        /**
         * @param request GetHDMAliyunResourceSyncResultRequest
         * @return GetHDMAliyunResourceSyncResultResponse
         */
        public GetHDMAliyunResourceSyncResultResponse GetHDMAliyunResourceSyncResult(GetHDMAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHDMAliyunResourceSyncResultWithOptions(request, runtime);
        }

        /**
         * @param request GetHDMAliyunResourceSyncResultRequest
         * @return GetHDMAliyunResourceSyncResultResponse
         */
        public async Task<GetHDMAliyunResourceSyncResultResponse> GetHDMAliyunResourceSyncResultAsync(GetHDMAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHDMAliyunResourceSyncResultWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetHDMLastAliyunResourceSyncResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHDMLastAliyunResourceSyncResultResponse
         */
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

        /**
         * @param request GetHDMLastAliyunResourceSyncResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHDMLastAliyunResourceSyncResultResponse
         */
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

        /**
         * @param request GetHDMLastAliyunResourceSyncResultRequest
         * @return GetHDMLastAliyunResourceSyncResultResponse
         */
        public GetHDMLastAliyunResourceSyncResultResponse GetHDMLastAliyunResourceSyncResult(GetHDMLastAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHDMLastAliyunResourceSyncResultWithOptions(request, runtime);
        }

        /**
         * @param request GetHDMLastAliyunResourceSyncResultRequest
         * @return GetHDMLastAliyunResourceSyncResultResponse
         */
        public async Task<GetHDMLastAliyunResourceSyncResultResponse> GetHDMLastAliyunResourceSyncResultAsync(GetHDMLastAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHDMLastAliyunResourceSyncResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.
         *
         * @description Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](https://help.aliyun.com/document_detail/205659.html).
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
         * @summary Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.
         *
         * @description Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](https://help.aliyun.com/document_detail/205659.html).
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
         * @summary Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.
         *
         * @description Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](https://help.aliyun.com/document_detail/205659.html).
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
         * @summary Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.
         *
         * @description Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see [Inspection and scoring](https://help.aliyun.com/document_detail/205659.html).
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
         * @summary Queries the details of all missing indexes of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the details of all missing indexes of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the details of all missing indexes of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries the details of all missing indexes of an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for SQL Server instances.
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
         * @summary Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Queries the results of a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the results of a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the results of a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the results of a task that terminates sessions.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.
         *
         * @description *   This operation is applicable only to MongoDB instances.
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
         * @summary Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.
         *
         * @description *   This operation is applicable only to MongoDB instances.
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
         * @summary Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.
         *
         * @description *   This operation is applicable only to MongoDB instances.
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
         * @summary Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.
         *
         * @description *   This operation is applicable only to MongoDB instances.
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
         * @summary Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.
         *
         * @description >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
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
         * @summary Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.
         *
         * @description >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
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
         * @summary Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.
         *
         * @description >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
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
         * @summary Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.
         *
         * @description >  Asynchronous calls do not immediately return the complete results. You must use the value of **ResultId** returned in the response to re-initiate the call. The complete results are returned only if the value of **IsFinish** is **true**.
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
         * @summary Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.
         *
         * @description We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](https://help.aliyun.com/document_detail/470302.html) feature of Database Autonomy Service (DAS) to query the data.
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
         * @summary Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.
         *
         * @description We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](https://help.aliyun.com/document_detail/470302.html) feature of Database Autonomy Service (DAS) to query the data.
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
         * @summary Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.
         *
         * @description We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](https://help.aliyun.com/document_detail/470302.html) feature of Database Autonomy Service (DAS) to query the data.
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
         * @summary Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.
         *
         * @description We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the [heatmap](https://help.aliyun.com/document_detail/470302.html) feature of Database Autonomy Service (DAS) to query the data.
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
         * @summary Queries the trend of a metric for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the trend of a metric for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the trend of a metric for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the trend of a metric for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the SQL sample data for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the SQL sample data for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the SQL sample data for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the SQL sample data for the new version of the performance insight feature of a database instance.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.
         * *   An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.
         * *   The new version of the performance insight feature is enabled for the database instance. For more information, see [Performance insight (new version)](https://help.aliyun.com/document_detail/469117.html).
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
         * @summary Queries information about SQL templates based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries information about SQL templates based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries information about SQL templates based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries information about SQL templates based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries information about the best-performing and worst-performing instances based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries information about the best-performing and worst-performing instances based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries information about the best-performing and worst-performing instances based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries information about the best-performing and worst-performing instances based on query governance data.
         *
         * @description *   If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries query governance trend data.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries query governance trend data.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries query governance trend data.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries query governance trend data.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries the failed SQL statements under a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries the failed SQL statements under a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries the failed SQL statements under a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries the failed SQL statements under a SQL template.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries SQL templates that failed to be executed.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries SQL templates that failed to be executed.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries SQL templates that failed to be executed.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries SQL templates that failed to be executed.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries the tags added by the query governance feature to specified database instances.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries the tags added by the query governance feature to specified database instances.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries the tags added by the query governance feature to specified database instances.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries the tags added by the query governance feature to specified database instances.
         *
         * @description *   If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.
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
         * @summary Queries a share URL provided by the query governance feature.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries a share URL provided by the query governance feature.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries a share URL provided by the query governance feature.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries a share URL provided by the query governance feature.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries suggestions provided by query governance for optimizing an SQL template.
         *
         * @description *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries suggestions provided by query governance for optimizing an SQL template.
         *
         * @description *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries suggestions provided by query governance for optimizing an SQL template.
         *
         * @description *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries suggestions provided by query governance for optimizing an SQL template.
         *
         * @description *   If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries the tags of a SQL statement.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries the tags of a SQL statement.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries the tags of a SQL statement.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries the tags of a SQL statement.
         *
         * @description *   If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
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
         * @summary Queries the current session on an ApsaraDB for Redis instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis instances.
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
         * @summary Queries the current session on an ApsaraDB for Redis instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis instances.
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
         * @summary Queries the current session on an ApsaraDB for Redis instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis instances.
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
         * @summary Queries the current session on an ApsaraDB for Redis instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis instances.
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
         * @summary Queries SQL diagnostics records by pages.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (Compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries SQL diagnostics records by pages.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (Compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries SQL diagnostics records by pages.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (Compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries SQL diagnostics records by pages.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (Compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries the results of an SQL diagnostics task.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries the results of an SQL diagnostics task.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries the results of an SQL diagnostics task.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries the results of an SQL diagnostics task.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL
         *     *   ApsaraDB RDS for PostgreSQL
         *     *   ApsaraDB RDS for SQL Server
         *     *   PolarDB for MySQL
         *     *   PolarDB for PostgreSQL (compatible with Oracle)
         *     *   ApsaraDB for MongoDB
         * >  The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see [Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/146895.html).
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
         * @summary Queries the throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries the throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries the throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries the throttling rules that are in effect.
         *
         * @description This operation supports the following database engines:
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
         * @summary Generates a throttling keyword string based on an SQL statement.
         *
         * @description This operation supports the following database engines:
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
         * @summary Generates a throttling keyword string based on an SQL statement.
         *
         * @description This operation supports the following database engines:
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
         * @summary Generates a throttling keyword string based on an SQL statement.
         *
         * @description This operation supports the following database engines:
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
         * @summary Generates a throttling keyword string based on an SQL statement.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries the throttling rules that are being executed or have been triggered.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries the throttling rules that are being executed or have been triggered.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries the throttling rules that are being executed or have been triggered.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries the throttling rules that are being executed or have been triggered.
         *
         * @description This operation supports the following database engines:
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
         * @summary Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).
         *
         * @description The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](https://help.aliyun.com/document_detail/167895.html).
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
         * @summary Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).
         *
         * @description The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](https://help.aliyun.com/document_detail/167895.html).
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
         * @summary Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).
         *
         * @description The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](https://help.aliyun.com/document_detail/167895.html).
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
         * @summary Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).
         *
         * @description The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see [Automatic SQL optimization](https://help.aliyun.com/document_detail/167895.html).
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
         * @summary Queries the status and results of a storage analysis task.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the status and results of a storage analysis task.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the status and results of a storage analysis task.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Queries the status and results of a storage analysis task.
         *
         * @description *   This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.
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
         * @summary Terminates all sessions on an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis.
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
         * @summary Terminates all sessions on an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis.
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
         * @summary Terminates all sessions on an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis.
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
         * @summary Terminates all sessions on an instance.
         *
         * @description *   This operation is applicable only to ApsaraDB for Redis.
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
         * @summary Modifies the auto scaling configurations of an instance.
         *
         * @description You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
         * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
         *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](https://help.aliyun.com/document_detail/173345.html).
         * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
         *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](https://help.aliyun.com/document_detail/216312.html).
         * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
         *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Modifies the auto scaling configurations of an instance.
         *
         * @description You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
         * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
         *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](https://help.aliyun.com/document_detail/173345.html).
         * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
         *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](https://help.aliyun.com/document_detail/216312.html).
         * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
         *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Modifies the auto scaling configurations of an instance.
         *
         * @description You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
         * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
         *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](https://help.aliyun.com/document_detail/173345.html).
         * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
         *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](https://help.aliyun.com/document_detail/216312.html).
         * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
         *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Modifies the auto scaling configurations of an instance.
         *
         * @description You can call this operation to modify the following auto scaling configurations of an instance: **auto scaling for specifications**, **automatic storage expansion**, **automatic bandwidth adjustment**, and **auto scaling for resources**.
         * *   You can modify the configurations of the **auto scaling feature for specifications** for the following types of database instances:
         *     *   PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   You can modify the configurations of the **automatic storage expansion** feature for the following types of database instances:
         *     *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see [Automatic space expansion](https://help.aliyun.com/document_detail/173345.html).
         * *   You can modify the configurations of the **automatic bandwidth adjustment** feature for the following types of database instances:
         *     *   ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see [Automatic bandwidth adjustment](https://help.aliyun.com/document_detail/216312.html).
         * *   You can modify the configurations of the **auto scaling feature for resources** for the following types of database instances:
         *     *   General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see [Automatic performance scaling](https://help.aliyun.com/document_detail/169686.html).
         * *   If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.
         * *   If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.
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
         * @summary Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @param request ModifySqlLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySqlLogConfigResponse
         */
        public ModifySqlLogConfigResponse ModifySqlLogConfigWithOptions(ModifySqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotRetention))
            {
                body["HotRetention"] = request.HotRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEnable))
            {
                body["RequestEnable"] = request.RequestEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                body["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySqlLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @param request ModifySqlLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySqlLogConfigResponse
         */
        public async Task<ModifySqlLogConfigResponse> ModifySqlLogConfigWithOptionsAsync(ModifySqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotRetention))
            {
                body["HotRetention"] = request.HotRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEnable))
            {
                body["RequestEnable"] = request.RequestEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                body["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySqlLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @param request ModifySqlLogConfigRequest
         * @return ModifySqlLogConfigResponse
         */
        public ModifySqlLogConfigResponse ModifySqlLogConfig(ModifySqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySqlLogConfigWithOptions(request, runtime);
        }

        /**
         * @summary Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.
         *
         * @param request ModifySqlLogConfigRequest
         * @return ModifySqlLogConfigResponse
         */
        public async Task<ModifySqlLogConfigResponse> ModifySqlLogConfigAsync(ModifySqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySqlLogConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Runs a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Runs a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Runs a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Runs a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Configures the event subscription settings for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Configures the event subscription settings for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Configures the event subscription settings for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Configures the event subscription settings for a database instance.
         *
         * @description Before you call this operation, take note of the following items:
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
         * @summary Stops a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Stops a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Stops a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
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
         * @summary Stops a stress testing task.
         *
         * @description Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see [Intelligent stress testing](https://help.aliyun.com/document_detail/155068.html).
         *
         * @param request StopCloudBenchTaskRequest
         * @return StopCloudBenchTaskResponse
         */
        public async Task<StopCloudBenchTaskResponse> StopCloudBenchTaskAsync(StopCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCloudBenchTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SyncHDMAliyunResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncHDMAliyunResourceResponse
         */
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

        /**
         * @param request SyncHDMAliyunResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncHDMAliyunResourceResponse
         */
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

        /**
         * @param request SyncHDMAliyunResourceRequest
         * @return SyncHDMAliyunResourceResponse
         */
        public SyncHDMAliyunResourceResponse SyncHDMAliyunResource(SyncHDMAliyunResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncHDMAliyunResourceWithOptions(request, runtime);
        }

        /**
         * @param request SyncHDMAliyunResourceRequest
         * @return SyncHDMAliyunResourceResponse
         */
        public async Task<SyncHDMAliyunResourceResponse> SyncHDMAliyunResourceAsync(SyncHDMAliyunResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncHDMAliyunResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.
         *
         * @description >  UpdateAutoResourceOptimizeRulesAsync is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.
         * *   DAS Enterprise Edition must be enabled for the database instance. You can call the call [DescribeInstanceDasPro](https://help.aliyun.com/document_detail/413866.html) operation to query whether DAS Enterprise Edition is enabled.
         * *   The database instance has four or more CPU cores, and **innodb_file_per_table** is set to **ON**.
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
         * @summary Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.
         *
         * @description >  UpdateAutoResourceOptimizeRulesAsync is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.
         * *   DAS Enterprise Edition must be enabled for the database instance. You can call the call [DescribeInstanceDasPro](https://help.aliyun.com/document_detail/413866.html) operation to query whether DAS Enterprise Edition is enabled.
         * *   The database instance has four or more CPU cores, and **innodb_file_per_table** is set to **ON**.
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
         * @summary Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.
         *
         * @description >  UpdateAutoResourceOptimizeRulesAsync is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.
         * *   DAS Enterprise Edition must be enabled for the database instance. You can call the call [DescribeInstanceDasPro](https://help.aliyun.com/document_detail/413866.html) operation to query whether DAS Enterprise Edition is enabled.
         * *   The database instance has four or more CPU cores, and **innodb_file_per_table** is set to **ON**.
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
         * @summary Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.
         *
         * @description >  UpdateAutoResourceOptimizeRulesAsync is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of **isFinish** is **false** in the response, wait for 1 second and then send a request again. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.
         * *   DAS Enterprise Edition must be enabled for the database instance. You can call the call [DescribeInstanceDasPro](https://help.aliyun.com/document_detail/413866.html) operation to query whether DAS Enterprise Edition is enabled.
         * *   The database instance has four or more CPU cores, and **innodb_file_per_table** is set to **ON**.
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
         * @summary Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the [EnableDasPro](https://help.aliyun.com/document_detail/411645.html) operation.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition
         *     *   PolarDB for MySQL Cluster Edition or X-Engine Edition
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
         * @summary Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the [EnableDasPro](https://help.aliyun.com/document_detail/411645.html) operation.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition
         *     *   PolarDB for MySQL Cluster Edition or X-Engine Edition
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
         * @summary Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the [EnableDasPro](https://help.aliyun.com/document_detail/411645.html) operation.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition
         *     *   PolarDB for MySQL Cluster Edition or X-Engine Edition
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
         * @summary Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.
         *
         * @description Before you call this operation, take note of the following items:
         * *   If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the [EnableDasPro](https://help.aliyun.com/document_detail/411645.html) operation.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
         * *   This operation supports the following database engines:
         *     *   ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition
         *     *   PolarDB for MySQL Cluster Edition or X-Engine Edition
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
         * @summary Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
         * @summary Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.
         *
         * @description >  An asynchronous call does not immediately return complete results. If the value of **isFinish** is **false** in the response, wait for 1 second and then re-initiate the call. If the value of **isFinish** is **true**, the complete results are returned.
         * Before you call this operation, take note of the following items:
         * *   If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.
         * *   The autonomy service must be enabled for the database instance that you want to manage. For more information, see [Autonomy center](https://help.aliyun.com/document_detail/152139.html).
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
