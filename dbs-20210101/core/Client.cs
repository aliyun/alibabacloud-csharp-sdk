// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dbs20210101.Models;

namespace AlibabaCloud.SDK.Dbs20210101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-chengdu", "dbs-api.cn-chengdu.aliyuncs.com"},
                {"cn-zhangjiakou", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-huhehaote", "dbs-api.cn-huhehaote.aliyuncs.com"},
                {"cn-hangzhou", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"ap-southeast-1", "dbs-api.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "dbs-api.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "dbs-api.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "dbs-api.ap-southeast-5.aliyuncs.com"},
                {"ap-northeast-1", "dbs-api.ap-northeast-1.aliyuncs.com"},
                {"us-west-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"us-east-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"eu-central-1", "dbs-api.eu-central-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dbs-api.cn-hangzhou.aliyuncs.com"},
                {"ap-south-1", "dbs-api.ap-south-1.aliyuncs.com"},
                {"eu-west-1", "dbs-api.eu-west-1.aliyuncs.com"},
                {"me-east-1", "dbs-api.me-east-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dbs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Moves a resource from one resource group to another.
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Moves a resource from one resource group to another.
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Moves a resource from one resource group to another.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Moves a resource from one resource group to another.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request CreateDownloadRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadResponse
         */
        public CreateDownloadResponse CreateDownloadWithOptions(CreateDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetId))
            {
                query["BakSetId"] = request.BakSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetSize))
            {
                query["BakSetSize"] = request.BakSetSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetType))
            {
                query["BakSetType"] = request.BakSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadPointInTime))
            {
                query["DownloadPointInTime"] = request.DownloadPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                query["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBucket))
            {
                query["TargetBucket"] = request.TargetBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssRegion))
            {
                query["TargetOssRegion"] = request.TargetOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPath))
            {
                query["TargetPath"] = request.TargetPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request CreateDownloadRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadResponse
         */
        public async Task<CreateDownloadResponse> CreateDownloadWithOptionsAsync(CreateDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetId))
            {
                query["BakSetId"] = request.BakSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetSize))
            {
                query["BakSetSize"] = request.BakSetSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BakSetType))
            {
                query["BakSetType"] = request.BakSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadPointInTime))
            {
                query["DownloadPointInTime"] = request.DownloadPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                query["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBucket))
            {
                query["TargetBucket"] = request.TargetBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOssRegion))
            {
                query["TargetOssRegion"] = request.TargetOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPath))
            {
                query["TargetPath"] = request.TargetPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request CreateDownloadRequest
         * @return CreateDownloadResponse
         */
        public CreateDownloadResponse CreateDownload(CreateDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDownloadWithOptions(request, runtime);
        }

        /**
         * @summary Creates an advanced download task for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * For the instances that meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request CreateDownloadRequest
         * @return CreateDownloadResponse
         */
        public async Task<CreateDownloadResponse> CreateDownloadAsync(CreateDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDownloadWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases a sandbox instance.
         *
         * @description This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DeleteSandboxInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSandboxInstanceResponse
         */
        public DeleteSandboxInstanceResponse DeleteSandboxInstanceWithOptions(DeleteSandboxInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSandboxInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases a sandbox instance.
         *
         * @description This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DeleteSandboxInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSandboxInstanceResponse
         */
        public async Task<DeleteSandboxInstanceResponse> DeleteSandboxInstanceWithOptionsAsync(DeleteSandboxInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSandboxInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases a sandbox instance.
         *
         * @description This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DeleteSandboxInstanceRequest
         * @return DeleteSandboxInstanceResponse
         */
        public DeleteSandboxInstanceResponse DeleteSandboxInstance(DeleteSandboxInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSandboxInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Releases a sandbox instance.
         *
         * @description This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DeleteSandboxInstanceRequest
         * @return DeleteSandboxInstanceResponse
         */
        public async Task<DeleteSandboxInstanceResponse> DeleteSandboxInstanceAsync(DeleteSandboxInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSandboxInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 备份数据列表查询接口
         *
         * @param request DescribeBackupDataListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupDataListResponse
         */
        public DescribeBackupDataListResponse DescribeBackupDataListWithOptions(DescribeBackupDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMode))
            {
                query["BackupMode"] = request.BackupMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupScale))
            {
                query["BackupScale"] = request.BackupScale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStatus))
            {
                query["BackupStatus"] = request.BackupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIsDeleted))
            {
                query["InstanceIsDeleted"] = request.InstanceIsDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegion))
            {
                query["InstanceRegion"] = request.InstanceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
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
                Action = "DescribeBackupDataList",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDataListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 备份数据列表查询接口
         *
         * @param request DescribeBackupDataListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupDataListResponse
         */
        public async Task<DescribeBackupDataListResponse> DescribeBackupDataListWithOptionsAsync(DescribeBackupDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMode))
            {
                query["BackupMode"] = request.BackupMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupScale))
            {
                query["BackupScale"] = request.BackupScale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStatus))
            {
                query["BackupStatus"] = request.BackupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIsDeleted))
            {
                query["InstanceIsDeleted"] = request.InstanceIsDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegion))
            {
                query["InstanceRegion"] = request.InstanceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
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
                Action = "DescribeBackupDataList",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDataListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 备份数据列表查询接口
         *
         * @param request DescribeBackupDataListRequest
         * @return DescribeBackupDataListResponse
         */
        public DescribeBackupDataListResponse DescribeBackupDataList(DescribeBackupDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupDataListWithOptions(request, runtime);
        }

        /**
         * @summary 备份数据列表查询接口
         *
         * @param request DescribeBackupDataListRequest
         * @return DescribeBackupDataListResponse
         */
        public async Task<DescribeBackupDataListResponse> DescribeBackupDataListAsync(DescribeBackupDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupDataListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取备份策略接口
         *
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取备份策略接口
         *
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取备份策略接口
         *
         * @param request DescribeBackupPolicyRequest
         * @return DescribeBackupPolicyResponse
         */
        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 获取备份策略接口
         *
         * @param request DescribeBackupPolicyRequest
         * @return DescribeBackupPolicyResponse
         */
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyAsync(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDBTablesRecoveryBackupSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBTablesRecoveryBackupSetResponse
         */
        public DescribeDBTablesRecoveryBackupSetResponse DescribeDBTablesRecoveryBackupSetWithOptions(DescribeDBTablesRecoveryBackupSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryBackupSet",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryBackupSetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDBTablesRecoveryBackupSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBTablesRecoveryBackupSetResponse
         */
        public async Task<DescribeDBTablesRecoveryBackupSetResponse> DescribeDBTablesRecoveryBackupSetWithOptionsAsync(DescribeDBTablesRecoveryBackupSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryBackupSet",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryBackupSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDBTablesRecoveryBackupSetRequest
         * @return DescribeDBTablesRecoveryBackupSetResponse
         */
        public DescribeDBTablesRecoveryBackupSetResponse DescribeDBTablesRecoveryBackupSet(DescribeDBTablesRecoveryBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryBackupSetWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDBTablesRecoveryBackupSetRequest
         * @return DescribeDBTablesRecoveryBackupSetResponse
         */
        public async Task<DescribeDBTablesRecoveryBackupSetResponse> DescribeDBTablesRecoveryBackupSetAsync(DescribeDBTablesRecoveryBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryBackupSetWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDBTablesRecoveryStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBTablesRecoveryStateResponse
         */
        public DescribeDBTablesRecoveryStateResponse DescribeDBTablesRecoveryStateWithOptions(DescribeDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDBTablesRecoveryStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBTablesRecoveryStateResponse
         */
        public async Task<DescribeDBTablesRecoveryStateResponse> DescribeDBTablesRecoveryStateWithOptionsAsync(DescribeDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDBTablesRecoveryStateRequest
         * @return DescribeDBTablesRecoveryStateResponse
         */
        public DescribeDBTablesRecoveryStateResponse DescribeDBTablesRecoveryState(DescribeDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryStateWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDBTablesRecoveryStateRequest
         * @return DescribeDBTablesRecoveryStateResponse
         */
        public async Task<DescribeDBTablesRecoveryStateResponse> DescribeDBTablesRecoveryStateAsync(DescribeDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryStateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDBTablesRecoveryTimeRangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBTablesRecoveryTimeRangeResponse
         */
        public DescribeDBTablesRecoveryTimeRangeResponse DescribeDBTablesRecoveryTimeRangeWithOptions(DescribeDBTablesRecoveryTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryTimeRange",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryTimeRangeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDBTablesRecoveryTimeRangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBTablesRecoveryTimeRangeResponse
         */
        public async Task<DescribeDBTablesRecoveryTimeRangeResponse> DescribeDBTablesRecoveryTimeRangeWithOptionsAsync(DescribeDBTablesRecoveryTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBTablesRecoveryTimeRange",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBTablesRecoveryTimeRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDBTablesRecoveryTimeRangeRequest
         * @return DescribeDBTablesRecoveryTimeRangeResponse
         */
        public DescribeDBTablesRecoveryTimeRangeResponse DescribeDBTablesRecoveryTimeRange(DescribeDBTablesRecoveryTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryTimeRangeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDBTablesRecoveryTimeRangeRequest
         * @return DescribeDBTablesRecoveryTimeRangeResponse
         */
        public async Task<DescribeDBTablesRecoveryTimeRangeResponse> DescribeDBTablesRecoveryTimeRangeAsync(DescribeDBTablesRecoveryTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryTimeRangeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the storage information of a downloaded backup set.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadBackupSetStorageInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadBackupSetStorageInfoResponse
         */
        public DescribeDownloadBackupSetStorageInfoResponse DescribeDownloadBackupSetStorageInfoWithOptions(DescribeDownloadBackupSetStorageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
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
                Action = "DescribeDownloadBackupSetStorageInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadBackupSetStorageInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the storage information of a downloaded backup set.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadBackupSetStorageInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadBackupSetStorageInfoResponse
         */
        public async Task<DescribeDownloadBackupSetStorageInfoResponse> DescribeDownloadBackupSetStorageInfoWithOptionsAsync(DescribeDownloadBackupSetStorageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
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
                Action = "DescribeDownloadBackupSetStorageInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadBackupSetStorageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the storage information of a downloaded backup set.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadBackupSetStorageInfoRequest
         * @return DescribeDownloadBackupSetStorageInfoResponse
         */
        public DescribeDownloadBackupSetStorageInfoResponse DescribeDownloadBackupSetStorageInfo(DescribeDownloadBackupSetStorageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadBackupSetStorageInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the storage information of a downloaded backup set.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadBackupSetStorageInfoRequest
         * @return DescribeDownloadBackupSetStorageInfoResponse
         */
        public async Task<DescribeDownloadBackupSetStorageInfoResponse> DescribeDownloadBackupSetStorageInfoAsync(DescribeDownloadBackupSetStorageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadBackupSetStorageInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether an instance supports the advanced download feature.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadSupportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadSupportResponse
         */
        public DescribeDownloadSupportResponse DescribeDownloadSupportWithOptions(DescribeDownloadSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadSupport",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadSupportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether an instance supports the advanced download feature.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadSupportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadSupportResponse
         */
        public async Task<DescribeDownloadSupportResponse> DescribeDownloadSupportWithOptionsAsync(DescribeDownloadSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDownloadSupport",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether an instance supports the advanced download feature.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadSupportRequest
         * @return DescribeDownloadSupportResponse
         */
        public DescribeDownloadSupportResponse DescribeDownloadSupport(DescribeDownloadSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadSupportWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether an instance supports the advanced download feature.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * You can create an advanced download task by point in time or backup set. You can set the download destination to a URL or directly upload the downloaded backup set to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving.
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadSupportRequest
         * @return DescribeDownloadSupportResponse
         */
        public async Task<DescribeDownloadSupportResponse> DescribeDownloadSupportAsync(DescribeDownloadSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadSupportWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadTaskResponse
         */
        public DescribeDownloadTaskResponse DescribeDownloadTaskWithOptions(DescribeDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                query["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirect))
            {
                query["OrderDirect"] = request.OrderDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
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
                Action = "DescribeDownloadTask",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadTaskResponse
         */
        public async Task<DescribeDownloadTaskResponse> DescribeDownloadTaskWithOptionsAsync(DescribeDownloadTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                query["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirect))
            {
                query["OrderDirect"] = request.OrderDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
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
                Action = "DescribeDownloadTask",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadTaskRequest
         * @return DescribeDownloadTaskResponse
         */
        public DescribeDownloadTaskResponse DescribeDownloadTask(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadTaskWithOptions(request, runtime);
        }

        /**
         * @summary Queries the advanced download tasks for an ApsaraDB RDS for MySQL instance, an ApsaraDB RDS for PostgreSQL instance, or a PolarDB for MySQL cluster.
         *
         * @description ### [](#)Supported database engines
         * *   ApsaraDB RDS for MySQL
         * *   ApsaraDB RDS for PostgreSQL
         * *   PolarDB for MySQL
         * ### [](#)References
         * *   [Download the backup files of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/98819.html)
         * *   [Download the backup files of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96774.html)
         * *   [Download the backup files of a PolarDB for MySQL cluster](https://help.aliyun.com/document_detail/2627635.html)
         *
         * @param request DescribeDownloadTaskRequest
         * @return DescribeDownloadTaskResponse
         */
        public async Task<DescribeDownloadTaskResponse> DescribeDownloadTaskAsync(DescribeDownloadTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the snapshots of an instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxBackupSetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSandboxBackupSetsResponse
         */
        public DescribeSandboxBackupSetsResponse DescribeSandboxBackupSetsWithOptions(DescribeSandboxBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
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
                Action = "DescribeSandboxBackupSets",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxBackupSetsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the snapshots of an instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxBackupSetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSandboxBackupSetsResponse
         */
        public async Task<DescribeSandboxBackupSetsResponse> DescribeSandboxBackupSetsWithOptionsAsync(DescribeSandboxBackupSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
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
                Action = "DescribeSandboxBackupSets",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxBackupSetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the snapshots of an instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxBackupSetsRequest
         * @return DescribeSandboxBackupSetsResponse
         */
        public DescribeSandboxBackupSetsResponse DescribeSandboxBackupSets(DescribeSandboxBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSandboxBackupSetsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the snapshots of an instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxBackupSetsRequest
         * @return DescribeSandboxBackupSetsResponse
         */
        public async Task<DescribeSandboxBackupSetsResponse> DescribeSandboxBackupSetsAsync(DescribeSandboxBackupSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxBackupSetsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries sandbox instances that are created within an account.
         *
         * @description This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSandboxInstancesResponse
         */
        public DescribeSandboxInstancesResponse DescribeSandboxInstancesWithOptions(DescribeSandboxInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxInstances",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries sandbox instances that are created within an account.
         *
         * @description This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSandboxInstancesResponse
         */
        public async Task<DescribeSandboxInstancesResponse> DescribeSandboxInstancesWithOptionsAsync(DescribeSandboxInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxInstances",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries sandbox instances that are created within an account.
         *
         * @description This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxInstancesRequest
         * @return DescribeSandboxInstancesResponse
         */
        public DescribeSandboxInstancesResponse DescribeSandboxInstances(DescribeSandboxInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSandboxInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries sandbox instances that are created within an account.
         *
         * @description This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxInstancesRequest
         * @return DescribeSandboxInstancesResponse
         */
        public async Task<DescribeSandboxInstancesResponse> DescribeSandboxInstancesAsync(DescribeSandboxInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the recoverable time range of a sandbox instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxRecoveryTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSandboxRecoveryTimeResponse
         */
        public DescribeSandboxRecoveryTimeResponse DescribeSandboxRecoveryTimeWithOptions(DescribeSandboxRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxRecoveryTime",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxRecoveryTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the recoverable time range of a sandbox instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxRecoveryTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSandboxRecoveryTimeResponse
         */
        public async Task<DescribeSandboxRecoveryTimeResponse> DescribeSandboxRecoveryTimeWithOptionsAsync(DescribeSandboxRecoveryTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxRecoveryTime",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxRecoveryTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the recoverable time range of a sandbox instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxRecoveryTimeRequest
         * @return DescribeSandboxRecoveryTimeResponse
         */
        public DescribeSandboxRecoveryTimeResponse DescribeSandboxRecoveryTime(DescribeSandboxRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSandboxRecoveryTimeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the recoverable time range of a sandbox instance.
         *
         * @description Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/203154.html) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](https://help.aliyun.com/document_detail/185577.html). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
         *
         * @param request DescribeSandboxRecoveryTimeRequest
         * @return DescribeSandboxRecoveryTimeResponse
         */
        public async Task<DescribeSandboxRecoveryTimeResponse> DescribeSandboxRecoveryTimeAsync(DescribeSandboxRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxRecoveryTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyDBTablesRecoveryStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBTablesRecoveryStateResponse
         */
        public ModifyDBTablesRecoveryStateResponse ModifyDBTablesRecoveryStateWithOptions(ModifyDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBTablesRecoveryStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyDBTablesRecoveryStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBTablesRecoveryStateResponse
         */
        public async Task<ModifyDBTablesRecoveryStateResponse> ModifyDBTablesRecoveryStateWithOptionsAsync(ModifyDBTablesRecoveryStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBTablesRecoveryState",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBTablesRecoveryStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyDBTablesRecoveryStateRequest
         * @return ModifyDBTablesRecoveryStateResponse
         */
        public ModifyDBTablesRecoveryStateResponse ModifyDBTablesRecoveryState(ModifyDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBTablesRecoveryStateWithOptions(request, runtime);
        }

        /**
         * @param request ModifyDBTablesRecoveryStateRequest
         * @return ModifyDBTablesRecoveryStateResponse
         */
        public async Task<ModifyDBTablesRecoveryStateResponse> ModifyDBTablesRecoveryStateAsync(ModifyDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBTablesRecoveryStateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SupportDBTableRecoveryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupportDBTableRecoveryResponse
         */
        public SupportDBTableRecoveryResponse SupportDBTableRecoveryWithOptions(SupportDBTableRecoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SupportDBTableRecovery",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupportDBTableRecoveryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SupportDBTableRecoveryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupportDBTableRecoveryResponse
         */
        public async Task<SupportDBTableRecoveryResponse> SupportDBTableRecoveryWithOptionsAsync(SupportDBTableRecoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionCode))
            {
                query["RegionCode"] = request.RegionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SupportDBTableRecovery",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupportDBTableRecoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SupportDBTableRecoveryRequest
         * @return SupportDBTableRecoveryResponse
         */
        public SupportDBTableRecoveryResponse SupportDBTableRecovery(SupportDBTableRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SupportDBTableRecoveryWithOptions(request, runtime);
        }

        /**
         * @param request SupportDBTableRecoveryRequest
         * @return SupportDBTableRecoveryResponse
         */
        public async Task<SupportDBTableRecoveryResponse> SupportDBTableRecoveryAsync(SupportDBTableRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SupportDBTableRecoveryWithOptionsAsync(request, runtime);
        }

    }
}
