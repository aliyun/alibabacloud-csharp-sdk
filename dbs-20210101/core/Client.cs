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

        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
          * For ApsaraDB RDS for MySQL instances that use standard SSDs or enhanced SSDs (ESSDs) and meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * For ApsaraDB RDS for MySQL instances that use standard SSDs or enhanced SSDs (ESSDs) and meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * For ApsaraDB RDS for MySQL instances that use standard SSDs or enhanced SSDs (ESSDs) and meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * For ApsaraDB RDS for MySQL instances that use standard SSDs or enhanced SSDs (ESSDs) and meet your business requirements, you can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
          *
          * @param request CreateSandboxInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSandboxInstanceResponse
         */
        public CreateSandboxInstanceResponse CreateSandboxInstanceWithOptions(CreateSandboxInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxInstanceName))
            {
                query["SandboxInstanceName"] = request.SandboxInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxPassword))
            {
                query["SandboxPassword"] = request.SandboxPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxSpecification))
            {
                query["SandboxSpecification"] = request.SandboxSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxType))
            {
                query["SandboxType"] = request.SandboxType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxUser))
            {
                query["SandboxUser"] = request.SandboxUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcSwitchId))
            {
                query["VpcSwitchId"] = request.VpcSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSandboxInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSandboxInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
          *
          * @param request CreateSandboxInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSandboxInstanceResponse
         */
        public async Task<CreateSandboxInstanceResponse> CreateSandboxInstanceWithOptionsAsync(CreateSandboxInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxInstanceName))
            {
                query["SandboxInstanceName"] = request.SandboxInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxPassword))
            {
                query["SandboxPassword"] = request.SandboxPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxSpecification))
            {
                query["SandboxSpecification"] = request.SandboxSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxType))
            {
                query["SandboxType"] = request.SandboxType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxUser))
            {
                query["SandboxUser"] = request.SandboxUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcSwitchId))
            {
                query["VpcSwitchId"] = request.VpcSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSandboxInstance",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSandboxInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
          *
          * @param request CreateSandboxInstanceRequest
          * @return CreateSandboxInstanceResponse
         */
        public CreateSandboxInstanceResponse CreateSandboxInstance(CreateSandboxInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSandboxInstanceWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
          *
          * @param request CreateSandboxInstanceRequest
          * @return CreateSandboxInstanceResponse
         */
        public async Task<CreateSandboxInstanceResponse> CreateSandboxInstanceAsync(CreateSandboxInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSandboxInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
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
          * This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
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
          * This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
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
          * This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
          *
          * @param request DeleteSandboxInstanceRequest
          * @return DeleteSandboxInstanceResponse
         */
        public async Task<DeleteSandboxInstanceResponse> DeleteSandboxInstanceAsync(DeleteSandboxInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSandboxInstanceWithOptionsAsync(request, runtime);
        }

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

        public DescribeDBTablesRecoveryBackupSetResponse DescribeDBTablesRecoveryBackupSet(DescribeDBTablesRecoveryBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryBackupSetWithOptions(request, runtime);
        }

        public async Task<DescribeDBTablesRecoveryBackupSetResponse> DescribeDBTablesRecoveryBackupSetAsync(DescribeDBTablesRecoveryBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryBackupSetWithOptionsAsync(request, runtime);
        }

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

        public DescribeDBTablesRecoveryStateResponse DescribeDBTablesRecoveryState(DescribeDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryStateWithOptions(request, runtime);
        }

        public async Task<DescribeDBTablesRecoveryStateResponse> DescribeDBTablesRecoveryStateAsync(DescribeDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryStateWithOptionsAsync(request, runtime);
        }

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

        public DescribeDBTablesRecoveryTimeRangeResponse DescribeDBTablesRecoveryTimeRange(DescribeDBTablesRecoveryTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBTablesRecoveryTimeRangeWithOptions(request, runtime);
        }

        public async Task<DescribeDBTablesRecoveryTimeRangeResponse> DescribeDBTablesRecoveryTimeRangeAsync(DescribeDBTablesRecoveryTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBTablesRecoveryTimeRangeWithOptionsAsync(request, runtime);
        }

        /**
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the download destination to an URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the Download Destination parameter to URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the Download Destination parameter to URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the Download Destination parameter to URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * You can create an advanced download task by point in time or backup set. You can set the Download Destination parameter to URL or directly upload the downloaded data to your Object Storage Service (OSS) bucket to facilitate data analysis and offline archiving. For more information, see [Download the backup files of an ApsaraDB RDS for MySQL instance](~~98819~~).
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only for the Database Backup (DBS) API of the 2021-01-01 version.
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
          * This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
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
          * This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
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
          * This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
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
          * This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
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
          * Before you call this operation, you must enable the sandbox feature for the database instance. For more information, see [Use the emergency recovery feature of an ApsaraDB RDS for MySQL instance](~~203154~~) or [Create a sandbox instance for emergency disaster recovery of a self-managed MySQL database](~~185577~~). This operation is available only in Database Backup (DBS) API of the 2021-01-01 version.
          *
          * @param request DescribeSandboxRecoveryTimeRequest
          * @return DescribeSandboxRecoveryTimeResponse
         */
        public async Task<DescribeSandboxRecoveryTimeResponse> DescribeSandboxRecoveryTimeAsync(DescribeSandboxRecoveryTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxRecoveryTimeWithOptionsAsync(request, runtime);
        }

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

        public ModifyDBTablesRecoveryStateResponse ModifyDBTablesRecoveryState(ModifyDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBTablesRecoveryStateWithOptions(request, runtime);
        }

        public async Task<ModifyDBTablesRecoveryStateResponse> ModifyDBTablesRecoveryStateAsync(ModifyDBTablesRecoveryStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBTablesRecoveryStateWithOptionsAsync(request, runtime);
        }

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

        public SupportDBTableRecoveryResponse SupportDBTableRecovery(SupportDBTableRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SupportDBTableRecoveryWithOptions(request, runtime);
        }

        public async Task<SupportDBTableRecoveryResponse> SupportDBTableRecoveryAsync(SupportDBTableRecoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SupportDBTableRecoveryWithOptionsAsync(request, runtime);
        }

    }
}
