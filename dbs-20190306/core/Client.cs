// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dbs20190306.Models;

namespace AlibabaCloud.SDK.Dbs20190306
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a DBS backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupPlanResponse
        /// </returns>
        public ConfigureBackupPlanResponse ConfigureBackupPlanWithOptions(ConfigureBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartBackup))
            {
                query["AutoStartBackup"] = request.AutoStartBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupLogIntervalSeconds))
            {
                query["BackupLogIntervalSeconds"] = request.BackupLogIntervalSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPeriod))
            {
                query["BackupPeriod"] = request.BackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRateLimit))
            {
                query["BackupRateLimit"] = request.BackupRateLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSpeedLimit))
            {
                query["BackupSpeedLimit"] = request.BackupSpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStartTime))
            {
                query["BackupStartTime"] = request.BackupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStorageType))
            {
                query["BackupStorageType"] = request.BackupStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStrategyType))
            {
                query["BackupStrategyType"] = request.BackupStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationArchivePeriod))
            {
                query["DuplicationArchivePeriod"] = request.DuplicationArchivePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationInfrequentAccessPeriod))
            {
                query["DuplicationInfrequentAccessPeriod"] = request.DuplicationInfrequentAccessPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucketName))
            {
                query["OSSBucketName"] = request.OSSBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceID))
            {
                query["SourceEndpointInstanceID"] = request.SourceEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceType))
            {
                query["SourceEndpointInstanceType"] = request.SourceEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOracleSID))
            {
                query["SourceEndpointOracleSID"] = request.SourceEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPassword))
            {
                query["SourceEndpointPassword"] = request.SourceEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a DBS backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupPlanResponse
        /// </returns>
        public async Task<ConfigureBackupPlanResponse> ConfigureBackupPlanWithOptionsAsync(ConfigureBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartBackup))
            {
                query["AutoStartBackup"] = request.AutoStartBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupLogIntervalSeconds))
            {
                query["BackupLogIntervalSeconds"] = request.BackupLogIntervalSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPeriod))
            {
                query["BackupPeriod"] = request.BackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRateLimit))
            {
                query["BackupRateLimit"] = request.BackupRateLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSpeedLimit))
            {
                query["BackupSpeedLimit"] = request.BackupSpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStartTime))
            {
                query["BackupStartTime"] = request.BackupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStorageType))
            {
                query["BackupStorageType"] = request.BackupStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStrategyType))
            {
                query["BackupStrategyType"] = request.BackupStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationArchivePeriod))
            {
                query["DuplicationArchivePeriod"] = request.DuplicationArchivePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationInfrequentAccessPeriod))
            {
                query["DuplicationInfrequentAccessPeriod"] = request.DuplicationInfrequentAccessPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucketName))
            {
                query["OSSBucketName"] = request.OSSBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceID))
            {
                query["SourceEndpointInstanceID"] = request.SourceEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceType))
            {
                query["SourceEndpointInstanceType"] = request.SourceEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOracleSID))
            {
                query["SourceEndpointOracleSID"] = request.SourceEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPassword))
            {
                query["SourceEndpointPassword"] = request.SourceEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigureBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigureBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a DBS backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupPlanResponse
        /// </returns>
        public ConfigureBackupPlanResponse ConfigureBackupPlan(ConfigureBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a DBS backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfigureBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigureBackupPlanResponse
        /// </returns>
        public async Task<ConfigureBackupPlanResponse> ConfigureBackupPlanAsync(ConfigureBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates, configures, and starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/70005.html">pricing</a> of Database Backup (DBS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndStartBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndStartBackupPlanResponse
        /// </returns>
        public CreateAndStartBackupPlanResponse CreateAndStartBackupPlanWithOptions(CreateAndStartBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupLogIntervalSeconds))
            {
                query["BackupLogIntervalSeconds"] = request.BackupLogIntervalSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPeriod))
            {
                query["BackupPeriod"] = request.BackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRateLimit))
            {
                query["BackupRateLimit"] = request.BackupRateLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSpeedLimit))
            {
                query["BackupSpeedLimit"] = request.BackupSpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStartTime))
            {
                query["BackupStartTime"] = request.BackupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStorageType))
            {
                query["BackupStorageType"] = request.BackupStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStrategyType))
            {
                query["BackupStrategyType"] = request.BackupStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseRegion))
            {
                query["DatabaseRegion"] = request.DatabaseRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseType))
            {
                query["DatabaseType"] = request.DatabaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationArchivePeriod))
            {
                query["DuplicationArchivePeriod"] = request.DuplicationArchivePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationInfrequentAccessPeriod))
            {
                query["DuplicationInfrequentAccessPeriod"] = request.DuplicationInfrequentAccessPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucketName))
            {
                query["OSSBucketName"] = request.OSSBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceID))
            {
                query["SourceEndpointInstanceID"] = request.SourceEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceType))
            {
                query["SourceEndpointInstanceType"] = request.SourceEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOracleSID))
            {
                query["SourceEndpointOracleSID"] = request.SourceEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPassword))
            {
                query["SourceEndpointPassword"] = request.SourceEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRegion))
            {
                query["StorageRegion"] = request.StorageRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndStartBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndStartBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates, configures, and starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/70005.html">pricing</a> of Database Backup (DBS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndStartBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndStartBackupPlanResponse
        /// </returns>
        public async Task<CreateAndStartBackupPlanResponse> CreateAndStartBackupPlanWithOptionsAsync(CreateAndStartBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupLogIntervalSeconds))
            {
                query["BackupLogIntervalSeconds"] = request.BackupLogIntervalSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPeriod))
            {
                query["BackupPeriod"] = request.BackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRateLimit))
            {
                query["BackupRateLimit"] = request.BackupRateLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSpeedLimit))
            {
                query["BackupSpeedLimit"] = request.BackupSpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStartTime))
            {
                query["BackupStartTime"] = request.BackupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStorageType))
            {
                query["BackupStorageType"] = request.BackupStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStrategyType))
            {
                query["BackupStrategyType"] = request.BackupStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseRegion))
            {
                query["DatabaseRegion"] = request.DatabaseRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseType))
            {
                query["DatabaseType"] = request.DatabaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationArchivePeriod))
            {
                query["DuplicationArchivePeriod"] = request.DuplicationArchivePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationInfrequentAccessPeriod))
            {
                query["DuplicationInfrequentAccessPeriod"] = request.DuplicationInfrequentAccessPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucketName))
            {
                query["OSSBucketName"] = request.OSSBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceID))
            {
                query["SourceEndpointInstanceID"] = request.SourceEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceType))
            {
                query["SourceEndpointInstanceType"] = request.SourceEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOracleSID))
            {
                query["SourceEndpointOracleSID"] = request.SourceEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPassword))
            {
                query["SourceEndpointPassword"] = request.SourceEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRegion))
            {
                query["StorageRegion"] = request.StorageRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndStartBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndStartBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates, configures, and starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/70005.html">pricing</a> of Database Backup (DBS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndStartBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndStartBackupPlanResponse
        /// </returns>
        public CreateAndStartBackupPlanResponse CreateAndStartBackupPlan(CreateAndStartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAndStartBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates, configures, and starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and <a href="https://help.aliyun.com/document_detail/70005.html">pricing</a> of Database Backup (DBS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndStartBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndStartBackupPlanResponse
        /// </returns>
        public async Task<CreateAndStartBackupPlanResponse> CreateAndStartBackupPlanAsync(CreateAndStartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAndStartBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about how to create a backup schedule in the Database Backup (DBS) console, see <a href="https://help.aliyun.com/document_detail/65909.html">Purchase a backup schedule</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
        public CreateBackupPlanResponse CreateBackupPlanWithOptions(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseRegion))
            {
                query["DatabaseRegion"] = request.DatabaseRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseType))
            {
                query["DatabaseType"] = request.DatabaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRegion))
            {
                query["StorageRegion"] = request.StorageRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about how to create a backup schedule in the Database Backup (DBS) console, see <a href="https://help.aliyun.com/document_detail/65909.html">Purchase a backup schedule</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
        public async Task<CreateBackupPlanResponse> CreateBackupPlanWithOptionsAsync(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseRegion))
            {
                query["DatabaseRegion"] = request.DatabaseRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseType))
            {
                query["DatabaseType"] = request.DatabaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRegion))
            {
                query["StorageRegion"] = request.StorageRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about how to create a backup schedule in the Database Backup (DBS) console, see <a href="https://help.aliyun.com/document_detail/65909.html">Purchase a backup schedule</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about how to create a backup schedule in the Database Backup (DBS) console, see <a href="https://help.aliyun.com/document_detail/65909.html">Purchase a backup schedule</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a full backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFullBackupSetDownloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFullBackupSetDownloadResponse
        /// </returns>
        public CreateFullBackupSetDownloadResponse CreateFullBackupSetDownloadWithOptions(CreateFullBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDataFormat))
            {
                query["BackupSetDataFormat"] = request.BackupSetDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFullBackupSetDownload",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFullBackupSetDownloadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a full backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFullBackupSetDownloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFullBackupSetDownloadResponse
        /// </returns>
        public async Task<CreateFullBackupSetDownloadResponse> CreateFullBackupSetDownloadWithOptionsAsync(CreateFullBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDataFormat))
            {
                query["BackupSetDataFormat"] = request.BackupSetDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFullBackupSetDownload",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFullBackupSetDownloadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a full backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFullBackupSetDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFullBackupSetDownloadResponse
        /// </returns>
        public CreateFullBackupSetDownloadResponse CreateFullBackupSetDownload(CreateFullBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFullBackupSetDownloadWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a full backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFullBackupSetDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFullBackupSetDownloadResponse
        /// </returns>
        public async Task<CreateFullBackupSetDownloadResponse> CreateFullBackupSetDownloadAsync(CreateFullBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFullBackupSetDownloadWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task to obtain a database list by using a backup gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation returns a task ID. You can call the <a href="https://help.aliyun.com/document_detail/2869852.html">GetDBListFromAgent</a> operation to query the task result based on the task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGetDBListFromAgentTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGetDBListFromAgentTaskResponse
        /// </returns>
        public CreateGetDBListFromAgentTaskResponse CreateGetDBListFromAgentTaskWithOptions(CreateGetDBListFromAgentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseType))
            {
                query["DatabaseType"] = request.DatabaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGetDBListFromAgentTask",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGetDBListFromAgentTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task to obtain a database list by using a backup gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation returns a task ID. You can call the <a href="https://help.aliyun.com/document_detail/2869852.html">GetDBListFromAgent</a> operation to query the task result based on the task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGetDBListFromAgentTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGetDBListFromAgentTaskResponse
        /// </returns>
        public async Task<CreateGetDBListFromAgentTaskResponse> CreateGetDBListFromAgentTaskWithOptionsAsync(CreateGetDBListFromAgentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseType))
            {
                query["DatabaseType"] = request.DatabaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGetDBListFromAgentTask",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGetDBListFromAgentTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task to obtain a database list by using a backup gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation returns a task ID. You can call the <a href="https://help.aliyun.com/document_detail/2869852.html">GetDBListFromAgent</a> operation to query the task result based on the task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGetDBListFromAgentTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGetDBListFromAgentTaskResponse
        /// </returns>
        public CreateGetDBListFromAgentTaskResponse CreateGetDBListFromAgentTask(CreateGetDBListFromAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGetDBListFromAgentTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task to obtain a database list by using a backup gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation returns a task ID. You can call the <a href="https://help.aliyun.com/document_detail/2869852.html">GetDBListFromAgent</a> operation to query the task result based on the task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGetDBListFromAgentTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGetDBListFromAgentTaskResponse
        /// </returns>
        public async Task<CreateGetDBListFromAgentTaskResponse> CreateGetDBListFromAgentTaskAsync(CreateGetDBListFromAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGetDBListFromAgentTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts an incremental backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIncrementBackupSetDownloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIncrementBackupSetDownloadResponse
        /// </returns>
        public CreateIncrementBackupSetDownloadResponse CreateIncrementBackupSetDownloadWithOptions(CreateIncrementBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDataFormat))
            {
                query["BackupSetDataFormat"] = request.BackupSetDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetName))
            {
                query["BackupSetName"] = request.BackupSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIncrementBackupSetDownload",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIncrementBackupSetDownloadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts an incremental backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIncrementBackupSetDownloadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIncrementBackupSetDownloadResponse
        /// </returns>
        public async Task<CreateIncrementBackupSetDownloadResponse> CreateIncrementBackupSetDownloadWithOptionsAsync(CreateIncrementBackupSetDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDataFormat))
            {
                query["BackupSetDataFormat"] = request.BackupSetDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetName))
            {
                query["BackupSetName"] = request.BackupSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIncrementBackupSetDownload",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIncrementBackupSetDownloadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts an incremental backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIncrementBackupSetDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIncrementBackupSetDownloadResponse
        /// </returns>
        public CreateIncrementBackupSetDownloadResponse CreateIncrementBackupSetDownload(CreateIncrementBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIncrementBackupSetDownloadWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts an incremental backup set download task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIncrementBackupSetDownloadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIncrementBackupSetDownloadResponse
        /// </returns>
        public async Task<CreateIncrementBackupSetDownloadResponse> CreateIncrementBackupSetDownloadAsync(CreateIncrementBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIncrementBackupSetDownloadWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restoration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRestoreTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreTaskResponse
        /// </returns>
        public CreateRestoreTaskResponse CreateRestoreTaskWithOptions(CreateRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointDatabaseName))
            {
                query["DestinationEndpointDatabaseName"] = request.DestinationEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointIP))
            {
                query["DestinationEndpointIP"] = request.DestinationEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointInstanceID))
            {
                query["DestinationEndpointInstanceID"] = request.DestinationEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointInstanceType))
            {
                query["DestinationEndpointInstanceType"] = request.DestinationEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointOracleSID))
            {
                query["DestinationEndpointOracleSID"] = request.DestinationEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointPassword))
            {
                query["DestinationEndpointPassword"] = request.DestinationEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointPort))
            {
                query["DestinationEndpointPort"] = request.DestinationEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointRegion))
            {
                query["DestinationEndpointRegion"] = request.DestinationEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointUserName))
            {
                query["DestinationEndpointUserName"] = request.DestinationEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicateConflict))
            {
                query["DuplicateConflict"] = request.DuplicateConflict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreDir))
            {
                query["RestoreDir"] = request.RestoreDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreHome))
            {
                query["RestoreHome"] = request.RestoreHome;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreObjects))
            {
                query["RestoreObjects"] = request.RestoreObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskName))
            {
                query["RestoreTaskName"] = request.RestoreTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRestoreTask",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRestoreTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restoration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRestoreTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreTaskResponse
        /// </returns>
        public async Task<CreateRestoreTaskResponse> CreateRestoreTaskWithOptionsAsync(CreateRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointDatabaseName))
            {
                query["DestinationEndpointDatabaseName"] = request.DestinationEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointIP))
            {
                query["DestinationEndpointIP"] = request.DestinationEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointInstanceID))
            {
                query["DestinationEndpointInstanceID"] = request.DestinationEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointInstanceType))
            {
                query["DestinationEndpointInstanceType"] = request.DestinationEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointOracleSID))
            {
                query["DestinationEndpointOracleSID"] = request.DestinationEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointPassword))
            {
                query["DestinationEndpointPassword"] = request.DestinationEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointPort))
            {
                query["DestinationEndpointPort"] = request.DestinationEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointRegion))
            {
                query["DestinationEndpointRegion"] = request.DestinationEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEndpointUserName))
            {
                query["DestinationEndpointUserName"] = request.DestinationEndpointUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicateConflict))
            {
                query["DuplicateConflict"] = request.DuplicateConflict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreDir))
            {
                query["RestoreDir"] = request.RestoreDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreHome))
            {
                query["RestoreHome"] = request.RestoreHome;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreObjects))
            {
                query["RestoreObjects"] = request.RestoreObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskName))
            {
                query["RestoreTaskName"] = request.RestoreTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRestoreTask",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRestoreTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restoration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRestoreTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreTaskResponse
        /// </returns>
        public CreateRestoreTaskResponse CreateRestoreTask(CreateRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRestoreTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restoration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRestoreTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreTaskResponse
        /// </returns>
        public async Task<CreateRestoreTaskResponse> CreateRestoreTaskAsync(CreateRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRestoreTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupGatewayListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupGatewayListResponse
        /// </returns>
        public DescribeBackupGatewayListResponse DescribeBackupGatewayListWithOptions(DescribeBackupGatewayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupGatewayList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupGatewayListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupGatewayListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupGatewayListResponse
        /// </returns>
        public async Task<DescribeBackupGatewayListResponse> DescribeBackupGatewayListWithOptionsAsync(DescribeBackupGatewayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupGatewayList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupGatewayListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupGatewayListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupGatewayListResponse
        /// </returns>
        public DescribeBackupGatewayListResponse DescribeBackupGatewayList(DescribeBackupGatewayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupGatewayListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupGatewayListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupGatewayListResponse
        /// </returns>
        public async Task<DescribeBackupGatewayListResponse> DescribeBackupGatewayListAsync(DescribeBackupGatewayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupGatewayListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the billing information of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanBillingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanBillingResponse
        /// </returns>
        public DescribeBackupPlanBillingResponse DescribeBackupPlanBillingWithOptions(DescribeBackupPlanBillingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStorageType))
            {
                query["ShowStorageType"] = request.ShowStorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlanBilling",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlanBillingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the billing information of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanBillingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanBillingResponse
        /// </returns>
        public async Task<DescribeBackupPlanBillingResponse> DescribeBackupPlanBillingWithOptionsAsync(DescribeBackupPlanBillingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStorageType))
            {
                query["ShowStorageType"] = request.ShowStorageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlanBilling",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlanBillingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the billing information of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanBillingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanBillingResponse
        /// </returns>
        public DescribeBackupPlanBillingResponse DescribeBackupPlanBilling(DescribeBackupPlanBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanBillingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the billing information of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanBillingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanBillingResponse
        /// </returns>
        public async Task<DescribeBackupPlanBillingResponse> DescribeBackupPlanBillingAsync(DescribeBackupPlanBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanBillingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of backup plans</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this interface, please activate the OSS service in advance. For more information, see <a href="https://help.aliyun.com/document_detail/31817.html">Object Storage Service (OSS)</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanListResponse
        /// </returns>
        public DescribeBackupPlanListResponse DescribeBackupPlanListWithOptions(DescribeBackupPlanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanStatus))
            {
                query["BackupPlanStatus"] = request.BackupPlanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlanList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlanListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of backup plans</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this interface, please activate the OSS service in advance. For more information, see <a href="https://help.aliyun.com/document_detail/31817.html">Object Storage Service (OSS)</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanListResponse
        /// </returns>
        public async Task<DescribeBackupPlanListResponse> DescribeBackupPlanListWithOptionsAsync(DescribeBackupPlanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanStatus))
            {
                query["BackupPlanStatus"] = request.BackupPlanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlanList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlanListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of backup plans</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this interface, please activate the OSS service in advance. For more information, see <a href="https://help.aliyun.com/document_detail/31817.html">Object Storage Service (OSS)</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanListResponse
        /// </returns>
        public DescribeBackupPlanListResponse DescribeBackupPlanList(DescribeBackupPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of backup plans</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this interface, please activate the OSS service in advance. For more information, see <a href="https://help.aliyun.com/document_detail/31817.html">Object Storage Service (OSS)</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBackupPlanListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlanListResponse
        /// </returns>
        public async Task<DescribeBackupPlanListResponse> DescribeBackupPlanListAsync(DescribeBackupPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup set download tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupSetDownloadTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupSetDownloadTaskListResponse
        /// </returns>
        public DescribeBackupSetDownloadTaskListResponse DescribeBackupSetDownloadTaskListWithOptions(DescribeBackupSetDownloadTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadTaskId))
            {
                query["BackupSetDownloadTaskId"] = request.BackupSetDownloadTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "DescribeBackupSetDownloadTaskList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSetDownloadTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup set download tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupSetDownloadTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupSetDownloadTaskListResponse
        /// </returns>
        public async Task<DescribeBackupSetDownloadTaskListResponse> DescribeBackupSetDownloadTaskListWithOptionsAsync(DescribeBackupSetDownloadTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadTaskId))
            {
                query["BackupSetDownloadTaskId"] = request.BackupSetDownloadTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
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
                Action = "DescribeBackupSetDownloadTaskList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSetDownloadTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup set download tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupSetDownloadTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupSetDownloadTaskListResponse
        /// </returns>
        public DescribeBackupSetDownloadTaskListResponse DescribeBackupSetDownloadTaskList(DescribeBackupSetDownloadTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSetDownloadTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries backup set download tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupSetDownloadTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupSetDownloadTaskListResponse
        /// </returns>
        public async Task<DescribeBackupSetDownloadTaskListResponse> DescribeBackupSetDownloadTaskListAsync(DescribeBackupSetDownloadTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSetDownloadTaskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Data Lake Analytics (DLA) service for a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDLAServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDLAServiceResponse
        /// </returns>
        public DescribeDLAServiceResponse DescribeDLAServiceWithOptions(DescribeDLAServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDLAService",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDLAServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Data Lake Analytics (DLA) service for a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDLAServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDLAServiceResponse
        /// </returns>
        public async Task<DescribeDLAServiceResponse> DescribeDLAServiceWithOptionsAsync(DescribeDLAServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDLAService",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDLAServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Data Lake Analytics (DLA) service for a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDLAServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDLAServiceResponse
        /// </returns>
        public DescribeDLAServiceResponse DescribeDLAService(DescribeDLAServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDLAServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Data Lake Analytics (DLA) service for a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDLAServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDLAServiceResponse
        /// </returns>
        public async Task<DescribeDLAServiceResponse> DescribeDLAServiceAsync(DescribeDLAServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDLAServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-hangzhou</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFullBackupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFullBackupListResponse
        /// </returns>
        public DescribeFullBackupListResponse DescribeFullBackupListWithOptions(DescribeFullBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStorageType))
            {
                query["ShowStorageType"] = request.ShowStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFullBackupList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFullBackupListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-hangzhou</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFullBackupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFullBackupListResponse
        /// </returns>
        public async Task<DescribeFullBackupListResponse> DescribeFullBackupListWithOptionsAsync(DescribeFullBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStorageType))
            {
                query["ShowStorageType"] = request.ShowStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFullBackupList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFullBackupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-hangzhou</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFullBackupListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFullBackupListResponse
        /// </returns>
        public DescribeFullBackupListResponse DescribeFullBackupList(DescribeFullBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFullBackupListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-hangzhou</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFullBackupListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFullBackupListResponse
        /// </returns>
        public async Task<DescribeFullBackupListResponse> DescribeFullBackupListAsync(DescribeFullBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFullBackupListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries incremental backup tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIncrementBackupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIncrementBackupListResponse
        /// </returns>
        public DescribeIncrementBackupListResponse DescribeIncrementBackupListWithOptions(DescribeIncrementBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStorageType))
            {
                query["ShowStorageType"] = request.ShowStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIncrementBackupList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIncrementBackupListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries incremental backup tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIncrementBackupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIncrementBackupListResponse
        /// </returns>
        public async Task<DescribeIncrementBackupListResponse> DescribeIncrementBackupListWithOptionsAsync(DescribeIncrementBackupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowStorageType))
            {
                query["ShowStorageType"] = request.ShowStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIncrementBackupList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIncrementBackupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries incremental backup tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIncrementBackupListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIncrementBackupListResponse
        /// </returns>
        public DescribeIncrementBackupListResponse DescribeIncrementBackupList(DescribeIncrementBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIncrementBackupListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries incremental backup tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIncrementBackupListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIncrementBackupListResponse
        /// </returns>
        public async Task<DescribeIncrementBackupListResponse> DescribeIncrementBackupListAsync(DescribeIncrementBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIncrementBackupListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error information of a Database Backup (DBS) task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobErrorCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobErrorCodeResponse
        /// </returns>
        public DescribeJobErrorCodeResponse DescribeJobErrorCodeWithOptions(DescribeJobErrorCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeJobErrorCode",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobErrorCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error information of a Database Backup (DBS) task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobErrorCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobErrorCodeResponse
        /// </returns>
        public async Task<DescribeJobErrorCodeResponse> DescribeJobErrorCodeWithOptionsAsync(DescribeJobErrorCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribeJobErrorCode",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobErrorCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error information of a Database Backup (DBS) task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobErrorCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobErrorCodeResponse
        /// </returns>
        public DescribeJobErrorCodeResponse DescribeJobErrorCode(DescribeJobErrorCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobErrorCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error information of a Database Backup (DBS) task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobErrorCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobErrorCodeResponse
        /// </returns>
        public async Task<DescribeJobErrorCodeResponse> DescribeJobErrorCodeAsync(DescribeJobErrorCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobErrorCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the CIDR blocks of nodes on which Database Backup (DBS) is running.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeCidrListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeCidrListResponse
        /// </returns>
        public DescribeNodeCidrListResponse DescribeNodeCidrListWithOptions(DescribeNodeCidrListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeCidrList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeCidrListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the CIDR blocks of nodes on which Database Backup (DBS) is running.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeCidrListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeCidrListResponse
        /// </returns>
        public async Task<DescribeNodeCidrListResponse> DescribeNodeCidrListWithOptionsAsync(DescribeNodeCidrListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeCidrList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeCidrListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the CIDR blocks of nodes on which Database Backup (DBS) is running.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeCidrListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeCidrListResponse
        /// </returns>
        public DescribeNodeCidrListResponse DescribeNodeCidrList(DescribeNodeCidrListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeCidrListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the CIDR blocks of nodes on which Database Backup (DBS) is running.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeCidrListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeCidrListResponse
        /// </returns>
        public async Task<DescribeNodeCidrListResponse> DescribeNodeCidrListAsync(DescribeNodeCidrListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeCidrListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the precheck progress of a backup schedule or a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreCheckProgressListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePreCheckProgressListResponse
        /// </returns>
        public DescribePreCheckProgressListResponse DescribePreCheckProgressListWithOptions(DescribePreCheckProgressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskId))
            {
                query["RestoreTaskId"] = request.RestoreTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreCheckProgressList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreCheckProgressListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the precheck progress of a backup schedule or a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreCheckProgressListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePreCheckProgressListResponse
        /// </returns>
        public async Task<DescribePreCheckProgressListResponse> DescribePreCheckProgressListWithOptionsAsync(DescribePreCheckProgressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskId))
            {
                query["RestoreTaskId"] = request.RestoreTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePreCheckProgressList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePreCheckProgressListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the precheck progress of a backup schedule or a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreCheckProgressListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePreCheckProgressListResponse
        /// </returns>
        public DescribePreCheckProgressListResponse DescribePreCheckProgressList(DescribePreCheckProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreCheckProgressListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the precheck progress of a backup schedule or a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePreCheckProgressListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePreCheckProgressListResponse
        /// </returns>
        public async Task<DescribePreCheckProgressListResponse> DescribePreCheckProgressListAsync(DescribePreCheckProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreCheckProgressListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that Database Backup (DBS) supports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-03-06",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that Database Backup (DBS) supports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-03-06",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that Database Backup (DBS) supports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that Database Backup (DBS) supports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the range of time to which you can restore data in a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreRangeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreRangeInfoResponse
        /// </returns>
        public DescribeRestoreRangeInfoResponse DescribeRestoreRangeInfoWithOptions(DescribeRestoreRangeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimestampForRestore))
            {
                query["BeginTimestampForRestore"] = request.BeginTimestampForRestore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestampForRestore))
            {
                query["EndTimestampForRestore"] = request.EndTimestampForRestore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentlyRestore))
            {
                query["RecentlyRestore"] = request.RecentlyRestore;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreRangeInfo",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreRangeInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the range of time to which you can restore data in a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreRangeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreRangeInfoResponse
        /// </returns>
        public async Task<DescribeRestoreRangeInfoResponse> DescribeRestoreRangeInfoWithOptionsAsync(DescribeRestoreRangeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimestampForRestore))
            {
                query["BeginTimestampForRestore"] = request.BeginTimestampForRestore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestampForRestore))
            {
                query["EndTimestampForRestore"] = request.EndTimestampForRestore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentlyRestore))
            {
                query["RecentlyRestore"] = request.RecentlyRestore;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreRangeInfo",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreRangeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the range of time to which you can restore data in a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreRangeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreRangeInfoResponse
        /// </returns>
        public DescribeRestoreRangeInfoResponse DescribeRestoreRangeInfo(DescribeRestoreRangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreRangeInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the range of time to which you can restore data in a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreRangeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreRangeInfoResponse
        /// </returns>
        public async Task<DescribeRestoreRangeInfoResponse> DescribeRestoreRangeInfoAsync(DescribeRestoreRangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreRangeInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries restore tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreTaskListResponse
        /// </returns>
        public DescribeRestoreTaskListResponse DescribeRestoreTaskListWithOptions(DescribeRestoreTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskId))
            {
                query["RestoreTaskId"] = request.RestoreTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreTaskList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries restore tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreTaskListResponse
        /// </returns>
        public async Task<DescribeRestoreTaskListResponse> DescribeRestoreTaskListWithOptionsAsync(DescribeRestoreTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskId))
            {
                query["RestoreTaskId"] = request.RestoreTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreTaskList",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries restore tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreTaskListResponse
        /// </returns>
        public DescribeRestoreTaskListResponse DescribeRestoreTaskList(DescribeRestoreTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries restore tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreTaskListResponse
        /// </returns>
        public async Task<DescribeRestoreTaskListResponse> DescribeRestoreTaskListAsync(DescribeRestoreTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreTaskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Impact</h3>
        /// <para>After you disable the incremental log backup feature, your backup schedule no longer performs incremental log backups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupLogResponse
        /// </returns>
        public DisableBackupLogResponse DisableBackupLogWithOptions(DisableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableBackupLog",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableBackupLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Impact</h3>
        /// <para>After you disable the incremental log backup feature, your backup schedule no longer performs incremental log backups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupLogResponse
        /// </returns>
        public async Task<DisableBackupLogResponse> DisableBackupLogWithOptionsAsync(DisableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableBackupLog",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableBackupLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Impact</h3>
        /// <para>After you disable the incremental log backup feature, your backup schedule no longer performs incremental log backups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupLogResponse
        /// </returns>
        public DisableBackupLogResponse DisableBackupLog(DisableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableBackupLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Impact</h3>
        /// <para>After you disable the incremental log backup feature, your backup schedule no longer performs incremental log backups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupLogResponse
        /// </returns>
        public async Task<DisableBackupLogResponse> DisableBackupLogAsync(DisableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableBackupLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impact</h2>
        /// <para>It is free to enable the incremental log backup feature. However, the backup traffic and storage capacity generated by the feature are billed in the same way as the full backup feature, and can be offset by the free quota of backup schedules or storage plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupLogResponse
        /// </returns>
        public EnableBackupLogResponse EnableBackupLogWithOptions(EnableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableBackupLog",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableBackupLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impact</h2>
        /// <para>It is free to enable the incremental log backup feature. However, the backup traffic and storage capacity generated by the feature are billed in the same way as the full backup feature, and can be offset by the free quota of backup schedules or storage plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupLogResponse
        /// </returns>
        public async Task<EnableBackupLogResponse> EnableBackupLogWithOptionsAsync(EnableBackupLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableBackupLog",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableBackupLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impact</h2>
        /// <para>It is free to enable the incremental log backup feature. However, the backup traffic and storage capacity generated by the feature are billed in the same way as the full backup feature, and can be offset by the free quota of backup schedules or storage plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupLogRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupLogResponse
        /// </returns>
        public EnableBackupLogResponse EnableBackupLog(EnableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableBackupLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables incremental backup for a backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impact</h2>
        /// <para>It is free to enable the incremental log backup feature. However, the backup traffic and storage capacity generated by the feature are billed in the same way as the full backup feature, and can be offset by the free quota of backup schedules or storage plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupLogRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupLogResponse
        /// </returns>
        public async Task<EnableBackupLogResponse> EnableBackupLogAsync(EnableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableBackupLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a task that is used to query a database list by using a backup gateway based on the ID of the task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDBListFromAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDBListFromAgentResponse
        /// </returns>
        public GetDBListFromAgentResponse GetDBListFromAgentWithOptions(GetDBListFromAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
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
                Action = "GetDBListFromAgent",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDBListFromAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a task that is used to query a database list by using a backup gateway based on the ID of the task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDBListFromAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDBListFromAgentResponse
        /// </returns>
        public async Task<GetDBListFromAgentResponse> GetDBListFromAgentWithOptionsAsync(GetDBListFromAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
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
                Action = "GetDBListFromAgent",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDBListFromAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a task that is used to query a database list by using a backup gateway based on the ID of the task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDBListFromAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDBListFromAgentResponse
        /// </returns>
        public GetDBListFromAgentResponse GetDBListFromAgent(GetDBListFromAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDBListFromAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a task that is used to query a database list by using a backup gateway based on the ID of the task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDBListFromAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDBListFromAgentResponse
        /// </returns>
        public async Task<GetDBListFromAgentResponse> GetDBListFromAgentAsync(GetDBListFromAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDBListFromAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants the AliyunServiceRoleForDBS role to Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeDbsServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeDbsServiceLinkedRoleResponse
        /// </returns>
        public InitializeDbsServiceLinkedRoleResponse InitializeDbsServiceLinkedRoleWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitializeDbsServiceLinkedRole",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeDbsServiceLinkedRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants the AliyunServiceRoleForDBS role to Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeDbsServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeDbsServiceLinkedRoleResponse
        /// </returns>
        public async Task<InitializeDbsServiceLinkedRoleResponse> InitializeDbsServiceLinkedRoleWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitializeDbsServiceLinkedRole",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeDbsServiceLinkedRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants the AliyunServiceRoleForDBS role to Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <returns>
        /// InitializeDbsServiceLinkedRoleResponse
        /// </returns>
        public InitializeDbsServiceLinkedRoleResponse InitializeDbsServiceLinkedRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeDbsServiceLinkedRoleWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants the AliyunServiceRoleForDBS role to Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <returns>
        /// InitializeDbsServiceLinkedRoleResponse
        /// </returns>
        public async Task<InitializeDbsServiceLinkedRoleResponse> InitializeDbsServiceLinkedRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeDbsServiceLinkedRoleWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies backup objects of a backup schedule in Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupObjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupObjectsResponse
        /// </returns>
        public ModifyBackupObjectsResponse ModifyBackupObjectsWithOptions(ModifyBackupObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupObjects",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupObjectsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies backup objects of a backup schedule in Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupObjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupObjectsResponse
        /// </returns>
        public async Task<ModifyBackupObjectsResponse> ModifyBackupObjectsWithOptionsAsync(ModifyBackupObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupObjects",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupObjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies backup objects of a backup schedule in Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupObjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupObjectsResponse
        /// </returns>
        public ModifyBackupObjectsResponse ModifyBackupObjects(ModifyBackupObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupObjectsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies backup objects of a backup schedule in Database Backup (DBS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupObjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupObjectsResponse
        /// </returns>
        public async Task<ModifyBackupObjectsResponse> ModifyBackupObjectsAsync(ModifyBackupObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupObjectsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupPlanNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPlanNameResponse
        /// </returns>
        public ModifyBackupPlanNameResponse ModifyBackupPlanNameWithOptions(ModifyBackupPlanNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPlanName",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPlanNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupPlanNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPlanNameResponse
        /// </returns>
        public async Task<ModifyBackupPlanNameResponse> ModifyBackupPlanNameWithOptionsAsync(ModifyBackupPlanNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanName))
            {
                query["BackupPlanName"] = request.BackupPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPlanName",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPlanNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupPlanNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPlanNameResponse
        /// </returns>
        public ModifyBackupPlanNameResponse ModifyBackupPlanName(ModifyBackupPlanNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPlanNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupPlanNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupPlanNameResponse
        /// </returns>
        public async Task<ModifyBackupPlanNameResponse> ModifyBackupPlanNameAsync(ModifyBackupPlanNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPlanNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, configures, or disables the automatic download feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSetDownloadRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSetDownloadRulesResponse
        /// </returns>
        public ModifyBackupSetDownloadRulesResponse ModifyBackupSetDownloadRulesWithOptions(ModifyBackupSetDownloadRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadDir))
            {
                query["BackupSetDownloadDir"] = request.BackupSetDownloadDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadTargetType))
            {
                query["BackupSetDownloadTargetType"] = request.BackupSetDownloadTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadTargetTypeLocation))
            {
                query["BackupSetDownloadTargetTypeLocation"] = request.BackupSetDownloadTargetTypeLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullDataFormat))
            {
                query["FullDataFormat"] = request.FullDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncrementDataFormat))
            {
                query["IncrementDataFormat"] = request.IncrementDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAutoDownload))
            {
                query["OpenAutoDownload"] = request.OpenAutoDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupSetDownloadRules",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupSetDownloadRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, configures, or disables the automatic download feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSetDownloadRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSetDownloadRulesResponse
        /// </returns>
        public async Task<ModifyBackupSetDownloadRulesResponse> ModifyBackupSetDownloadRulesWithOptionsAsync(ModifyBackupSetDownloadRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadDir))
            {
                query["BackupSetDownloadDir"] = request.BackupSetDownloadDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadTargetType))
            {
                query["BackupSetDownloadTargetType"] = request.BackupSetDownloadTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetDownloadTargetTypeLocation))
            {
                query["BackupSetDownloadTargetTypeLocation"] = request.BackupSetDownloadTargetTypeLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullDataFormat))
            {
                query["FullDataFormat"] = request.FullDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncrementDataFormat))
            {
                query["IncrementDataFormat"] = request.IncrementDataFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAutoDownload))
            {
                query["OpenAutoDownload"] = request.OpenAutoDownload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupSetDownloadRules",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupSetDownloadRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, configures, or disables the automatic download feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSetDownloadRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSetDownloadRulesResponse
        /// </returns>
        public ModifyBackupSetDownloadRulesResponse ModifyBackupSetDownloadRules(ModifyBackupSetDownloadRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupSetDownloadRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, configures, or disables the automatic download feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSetDownloadRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSetDownloadRulesResponse
        /// </returns>
        public async Task<ModifyBackupSetDownloadRulesResponse> ModifyBackupSetDownloadRulesAsync(ModifyBackupSetDownloadRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupSetDownloadRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the data source of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSourceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSourceEndpointResponse
        /// </returns>
        public ModifyBackupSourceEndpointResponse ModifyBackupSourceEndpointWithOptions(ModifyBackupSourceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceID))
            {
                query["SourceEndpointInstanceID"] = request.SourceEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceType))
            {
                query["SourceEndpointInstanceType"] = request.SourceEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOracleSID))
            {
                query["SourceEndpointOracleSID"] = request.SourceEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPassword))
            {
                query["SourceEndpointPassword"] = request.SourceEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupSourceEndpoint",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupSourceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the data source of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSourceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSourceEndpointResponse
        /// </returns>
        public async Task<ModifyBackupSourceEndpointResponse> ModifyBackupSourceEndpointWithOptionsAsync(ModifyBackupSourceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupGatewayId))
            {
                query["BackupGatewayId"] = request.BackupGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjects))
            {
                query["BackupObjects"] = request.BackupObjects;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAliyunId))
            {
                query["CrossAliyunId"] = request.CrossAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRoleName))
            {
                query["CrossRoleName"] = request.CrossRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointDatabaseName))
            {
                query["SourceEndpointDatabaseName"] = request.SourceEndpointDatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointIP))
            {
                query["SourceEndpointIP"] = request.SourceEndpointIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceID))
            {
                query["SourceEndpointInstanceID"] = request.SourceEndpointInstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointInstanceType))
            {
                query["SourceEndpointInstanceType"] = request.SourceEndpointInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointOracleSID))
            {
                query["SourceEndpointOracleSID"] = request.SourceEndpointOracleSID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPassword))
            {
                query["SourceEndpointPassword"] = request.SourceEndpointPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointPort))
            {
                query["SourceEndpointPort"] = request.SourceEndpointPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointRegion))
            {
                query["SourceEndpointRegion"] = request.SourceEndpointRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointUserName))
            {
                query["SourceEndpointUserName"] = request.SourceEndpointUserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupSourceEndpoint",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupSourceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the data source of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSourceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSourceEndpointResponse
        /// </returns>
        public ModifyBackupSourceEndpointResponse ModifyBackupSourceEndpoint(ModifyBackupSourceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupSourceEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the data source of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupSourceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupSourceEndpointResponse
        /// </returns>
        public async Task<ModifyBackupSourceEndpointResponse> ModifyBackupSourceEndpointAsync(ModifyBackupSourceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupSourceEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup time of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupStrategyResponse
        /// </returns>
        public ModifyBackupStrategyResponse ModifyBackupStrategyWithOptions(ModifyBackupStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupLogIntervalSeconds))
            {
                query["BackupLogIntervalSeconds"] = request.BackupLogIntervalSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPeriod))
            {
                query["BackupPeriod"] = request.BackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStartTime))
            {
                query["BackupStartTime"] = request.BackupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStrategyType))
            {
                query["BackupStrategyType"] = request.BackupStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupStrategy",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup time of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupStrategyResponse
        /// </returns>
        public async Task<ModifyBackupStrategyResponse> ModifyBackupStrategyWithOptionsAsync(ModifyBackupStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupLogIntervalSeconds))
            {
                query["BackupLogIntervalSeconds"] = request.BackupLogIntervalSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPeriod))
            {
                query["BackupPeriod"] = request.BackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStartTime))
            {
                query["BackupStartTime"] = request.BackupStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupStrategyType))
            {
                query["BackupStrategyType"] = request.BackupStrategyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupStrategy",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup time of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupStrategyResponse
        /// </returns>
        public ModifyBackupStrategyResponse ModifyBackupStrategy(ModifyBackupStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupStrategyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the backup time of a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBackupStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBackupStrategyResponse
        /// </returns>
        public async Task<ModifyBackupStrategyResponse> ModifyBackupStrategyAsync(ModifyBackupStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupStrategyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the lifecycle of data that is backed up based on a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyStorageStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyStorageStrategyResponse
        /// </returns>
        public ModifyStorageStrategyResponse ModifyStorageStrategyWithOptions(ModifyStorageStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationArchivePeriod))
            {
                query["DuplicationArchivePeriod"] = request.DuplicationArchivePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationInfrequentAccessPeriod))
            {
                query["DuplicationInfrequentAccessPeriod"] = request.DuplicationInfrequentAccessPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyStorageStrategy",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyStorageStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the lifecycle of data that is backed up based on a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyStorageStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyStorageStrategyResponse
        /// </returns>
        public async Task<ModifyStorageStrategyResponse> ModifyStorageStrategyWithOptionsAsync(ModifyStorageStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationArchivePeriod))
            {
                query["DuplicationArchivePeriod"] = request.DuplicationArchivePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationInfrequentAccessPeriod))
            {
                query["DuplicationInfrequentAccessPeriod"] = request.DuplicationInfrequentAccessPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyStorageStrategy",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyStorageStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the lifecycle of data that is backed up based on a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyStorageStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyStorageStrategyResponse
        /// </returns>
        public ModifyStorageStrategyResponse ModifyStorageStrategy(ModifyStorageStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStorageStrategyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the lifecycle of data that is backed up based on a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyStorageStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyStorageStrategyResponse
        /// </returns>
        public async Task<ModifyStorageStrategyResponse> ModifyStorageStrategyAsync(ModifyStorageStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStorageStrategyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impacts</h2>
        /// <para>After a pay-as-you-go backup schedule is released, it stops providing services. Database Backup (DBS) no longer charges you fees for this backup schedule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseBackupPlanResponse
        /// </returns>
        public ReleaseBackupPlanResponse ReleaseBackupPlanWithOptions(ReleaseBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impacts</h2>
        /// <para>After a pay-as-you-go backup schedule is released, it stops providing services. Database Backup (DBS) no longer charges you fees for this backup schedule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseBackupPlanResponse
        /// </returns>
        public async Task<ReleaseBackupPlanResponse> ReleaseBackupPlanWithOptionsAsync(ReleaseBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impacts</h2>
        /// <para>After a pay-as-you-go backup schedule is released, it stops providing services. Database Backup (DBS) no longer charges you fees for this backup schedule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseBackupPlanResponse
        /// </returns>
        public ReleaseBackupPlanResponse ReleaseBackupPlan(ReleaseBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go backup schedule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Impacts</h2>
        /// <para>After a pay-as-you-go backup schedule is released, it stops providing services. Database Backup (DBS) no longer charges you fees for this backup schedule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseBackupPlanResponse
        /// </returns>
        public async Task<ReleaseBackupPlanResponse> ReleaseBackupPlanAsync(ReleaseBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewBackupPlanResponse
        /// </returns>
        public RenewBackupPlanResponse RenewBackupPlanWithOptions(RenewBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewBackupPlanResponse
        /// </returns>
        public async Task<RenewBackupPlanResponse> RenewBackupPlanWithOptionsAsync(RenewBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewBackupPlanResponse
        /// </returns>
        public RenewBackupPlanResponse RenewBackupPlan(RenewBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewBackupPlanResponse
        /// </returns>
        public async Task<RenewBackupPlanResponse> RenewBackupPlanAsync(RenewBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBackupPlanResponse
        /// </returns>
        public StartBackupPlanResponse StartBackupPlanWithOptions(StartBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBackupPlanResponse
        /// </returns>
        public async Task<StartBackupPlanResponse> StartBackupPlanWithOptionsAsync(StartBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// StartBackupPlanResponse
        /// </returns>
        public StartBackupPlanResponse StartBackupPlan(StartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// StartBackupPlanResponse
        /// </returns>
        public async Task<StartBackupPlanResponse> StartBackupPlanAsync(StartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartRestoreTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRestoreTaskResponse
        /// </returns>
        public StartRestoreTaskResponse StartRestoreTaskWithOptions(StartRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskId))
            {
                query["RestoreTaskId"] = request.RestoreTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRestoreTask",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRestoreTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartRestoreTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRestoreTaskResponse
        /// </returns>
        public async Task<StartRestoreTaskResponse> StartRestoreTaskWithOptionsAsync(StartRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTaskId))
            {
                query["RestoreTaskId"] = request.RestoreTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRestoreTask",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRestoreTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartRestoreTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRestoreTaskResponse
        /// </returns>
        public StartRestoreTaskResponse StartRestoreTask(StartRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRestoreTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a restore task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartRestoreTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRestoreTaskResponse
        /// </returns>
        public async Task<StartRestoreTaskResponse> StartRestoreTaskAsync(StartRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRestoreTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopBackupPlanResponse
        /// </returns>
        public StopBackupPlanResponse StopBackupPlanWithOptions(StopBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopMethod))
            {
                query["StopMethod"] = request.StopMethod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopBackupPlanResponse
        /// </returns>
        public async Task<StopBackupPlanResponse> StopBackupPlanWithOptionsAsync(StopBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopMethod))
            {
                query["StopMethod"] = request.StopMethod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// StopBackupPlanResponse
        /// </returns>
        public StopBackupPlanResponse StopBackupPlan(StopBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// StopBackupPlanResponse
        /// </returns>
        public async Task<StopBackupPlanResponse> StopBackupPlanAsync(StopBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupPlanResponse
        /// </returns>
        public UpgradeBackupPlanResponse UpgradeBackupPlanWithOptions(UpgradeBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupPlanResponse
        /// </returns>
        public async Task<UpgradeBackupPlanResponse> UpgradeBackupPlanWithOptionsAsync(UpgradeBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPlanId))
            {
                query["BackupPlanId"] = request.BackupPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeBackupPlan",
                Version = "2019-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupPlanResponse
        /// </returns>
        public UpgradeBackupPlanResponse UpgradeBackupPlan(UpgradeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a backup schedule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupPlanResponse
        /// </returns>
        public async Task<UpgradeBackupPlanResponse> UpgradeBackupPlanAsync(UpgradeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeBackupPlanWithOptionsAsync(request, runtime);
        }

    }
}
