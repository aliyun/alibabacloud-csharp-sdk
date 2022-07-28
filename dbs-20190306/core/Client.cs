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

        public ConfigureBackupPlanResponse ConfigureBackupPlan(ConfigureBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigureBackupPlanWithOptions(request, runtime);
        }

        public async Task<ConfigureBackupPlanResponse> ConfigureBackupPlanAsync(ConfigureBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigureBackupPlanWithOptionsAsync(request, runtime);
        }

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

        public CreateAndStartBackupPlanResponse CreateAndStartBackupPlan(CreateAndStartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAndStartBackupPlanWithOptions(request, runtime);
        }

        public async Task<CreateAndStartBackupPlanResponse> CreateAndStartBackupPlanAsync(CreateAndStartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAndStartBackupPlanWithOptionsAsync(request, runtime);
        }

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

        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

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

        public CreateFullBackupSetDownloadResponse CreateFullBackupSetDownload(CreateFullBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFullBackupSetDownloadWithOptions(request, runtime);
        }

        public async Task<CreateFullBackupSetDownloadResponse> CreateFullBackupSetDownloadAsync(CreateFullBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFullBackupSetDownloadWithOptionsAsync(request, runtime);
        }

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

        public CreateGetDBListFromAgentTaskResponse CreateGetDBListFromAgentTask(CreateGetDBListFromAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGetDBListFromAgentTaskWithOptions(request, runtime);
        }

        public async Task<CreateGetDBListFromAgentTaskResponse> CreateGetDBListFromAgentTaskAsync(CreateGetDBListFromAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGetDBListFromAgentTaskWithOptionsAsync(request, runtime);
        }

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

        public CreateIncrementBackupSetDownloadResponse CreateIncrementBackupSetDownload(CreateIncrementBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIncrementBackupSetDownloadWithOptions(request, runtime);
        }

        public async Task<CreateIncrementBackupSetDownloadResponse> CreateIncrementBackupSetDownloadAsync(CreateIncrementBackupSetDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIncrementBackupSetDownloadWithOptionsAsync(request, runtime);
        }

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

        public CreateRestoreTaskResponse CreateRestoreTask(CreateRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRestoreTaskWithOptions(request, runtime);
        }

        public async Task<CreateRestoreTaskResponse> CreateRestoreTaskAsync(CreateRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRestoreTaskWithOptionsAsync(request, runtime);
        }

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

        public DescribeBackupGatewayListResponse DescribeBackupGatewayList(DescribeBackupGatewayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupGatewayListWithOptions(request, runtime);
        }

        public async Task<DescribeBackupGatewayListResponse> DescribeBackupGatewayListAsync(DescribeBackupGatewayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupGatewayListWithOptionsAsync(request, runtime);
        }

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

        public DescribeBackupPlanBillingResponse DescribeBackupPlanBilling(DescribeBackupPlanBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanBillingWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlanBillingResponse> DescribeBackupPlanBillingAsync(DescribeBackupPlanBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanBillingWithOptionsAsync(request, runtime);
        }

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

        public DescribeBackupPlanListResponse DescribeBackupPlanList(DescribeBackupPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanListWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlanListResponse> DescribeBackupPlanListAsync(DescribeBackupPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanListWithOptionsAsync(request, runtime);
        }

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

        public DescribeBackupSetDownloadTaskListResponse DescribeBackupSetDownloadTaskList(DescribeBackupSetDownloadTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSetDownloadTaskListWithOptions(request, runtime);
        }

        public async Task<DescribeBackupSetDownloadTaskListResponse> DescribeBackupSetDownloadTaskListAsync(DescribeBackupSetDownloadTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSetDownloadTaskListWithOptionsAsync(request, runtime);
        }

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

        public DescribeDLAServiceResponse DescribeDLAService(DescribeDLAServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDLAServiceWithOptions(request, runtime);
        }

        public async Task<DescribeDLAServiceResponse> DescribeDLAServiceAsync(DescribeDLAServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDLAServiceWithOptionsAsync(request, runtime);
        }

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

        public DescribeFullBackupListResponse DescribeFullBackupList(DescribeFullBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFullBackupListWithOptions(request, runtime);
        }

        public async Task<DescribeFullBackupListResponse> DescribeFullBackupListAsync(DescribeFullBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFullBackupListWithOptionsAsync(request, runtime);
        }

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

        public DescribeIncrementBackupListResponse DescribeIncrementBackupList(DescribeIncrementBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIncrementBackupListWithOptions(request, runtime);
        }

        public async Task<DescribeIncrementBackupListResponse> DescribeIncrementBackupListAsync(DescribeIncrementBackupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIncrementBackupListWithOptionsAsync(request, runtime);
        }

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

        public DescribeJobErrorCodeResponse DescribeJobErrorCode(DescribeJobErrorCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobErrorCodeWithOptions(request, runtime);
        }

        public async Task<DescribeJobErrorCodeResponse> DescribeJobErrorCodeAsync(DescribeJobErrorCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobErrorCodeWithOptionsAsync(request, runtime);
        }

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

        public DescribeNodeCidrListResponse DescribeNodeCidrList(DescribeNodeCidrListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeCidrListWithOptions(request, runtime);
        }

        public async Task<DescribeNodeCidrListResponse> DescribeNodeCidrListAsync(DescribeNodeCidrListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeCidrListWithOptionsAsync(request, runtime);
        }

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

        public DescribePreCheckProgressListResponse DescribePreCheckProgressList(DescribePreCheckProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePreCheckProgressListWithOptions(request, runtime);
        }

        public async Task<DescribePreCheckProgressListResponse> DescribePreCheckProgressListAsync(DescribePreCheckProgressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePreCheckProgressListWithOptionsAsync(request, runtime);
        }

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

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

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

        public DescribeRestoreRangeInfoResponse DescribeRestoreRangeInfo(DescribeRestoreRangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreRangeInfoWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreRangeInfoResponse> DescribeRestoreRangeInfoAsync(DescribeRestoreRangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreRangeInfoWithOptionsAsync(request, runtime);
        }

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

        public DescribeRestoreTaskListResponse DescribeRestoreTaskList(DescribeRestoreTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreTaskListWithOptions(request, runtime);
        }

        public async Task<DescribeRestoreTaskListResponse> DescribeRestoreTaskListAsync(DescribeRestoreTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreTaskListWithOptionsAsync(request, runtime);
        }

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

        public DisableBackupLogResponse DisableBackupLog(DisableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableBackupLogWithOptions(request, runtime);
        }

        public async Task<DisableBackupLogResponse> DisableBackupLogAsync(DisableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableBackupLogWithOptionsAsync(request, runtime);
        }

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

        public EnableBackupLogResponse EnableBackupLog(EnableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableBackupLogWithOptions(request, runtime);
        }

        public async Task<EnableBackupLogResponse> EnableBackupLogAsync(EnableBackupLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableBackupLogWithOptionsAsync(request, runtime);
        }

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

        public GetDBListFromAgentResponse GetDBListFromAgent(GetDBListFromAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDBListFromAgentWithOptions(request, runtime);
        }

        public async Task<GetDBListFromAgentResponse> GetDBListFromAgentAsync(GetDBListFromAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDBListFromAgentWithOptionsAsync(request, runtime);
        }

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

        public InitializeDbsServiceLinkedRoleResponse InitializeDbsServiceLinkedRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeDbsServiceLinkedRoleWithOptions(runtime);
        }

        public async Task<InitializeDbsServiceLinkedRoleResponse> InitializeDbsServiceLinkedRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeDbsServiceLinkedRoleWithOptionsAsync(runtime);
        }

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

        public ModifyBackupObjectsResponse ModifyBackupObjects(ModifyBackupObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupObjectsWithOptions(request, runtime);
        }

        public async Task<ModifyBackupObjectsResponse> ModifyBackupObjectsAsync(ModifyBackupObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupObjectsWithOptionsAsync(request, runtime);
        }

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

        public ModifyBackupPlanNameResponse ModifyBackupPlanName(ModifyBackupPlanNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPlanNameWithOptions(request, runtime);
        }

        public async Task<ModifyBackupPlanNameResponse> ModifyBackupPlanNameAsync(ModifyBackupPlanNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPlanNameWithOptionsAsync(request, runtime);
        }

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

        public ModifyBackupSetDownloadRulesResponse ModifyBackupSetDownloadRules(ModifyBackupSetDownloadRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupSetDownloadRulesWithOptions(request, runtime);
        }

        public async Task<ModifyBackupSetDownloadRulesResponse> ModifyBackupSetDownloadRulesAsync(ModifyBackupSetDownloadRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupSetDownloadRulesWithOptionsAsync(request, runtime);
        }

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

        public ModifyBackupSourceEndpointResponse ModifyBackupSourceEndpoint(ModifyBackupSourceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupSourceEndpointWithOptions(request, runtime);
        }

        public async Task<ModifyBackupSourceEndpointResponse> ModifyBackupSourceEndpointAsync(ModifyBackupSourceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupSourceEndpointWithOptionsAsync(request, runtime);
        }

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

        public ModifyBackupStrategyResponse ModifyBackupStrategy(ModifyBackupStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupStrategyWithOptions(request, runtime);
        }

        public async Task<ModifyBackupStrategyResponse> ModifyBackupStrategyAsync(ModifyBackupStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupStrategyWithOptionsAsync(request, runtime);
        }

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

        public ModifyStorageStrategyResponse ModifyStorageStrategy(ModifyStorageStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStorageStrategyWithOptions(request, runtime);
        }

        public async Task<ModifyStorageStrategyResponse> ModifyStorageStrategyAsync(ModifyStorageStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStorageStrategyWithOptionsAsync(request, runtime);
        }

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

        public ReleaseBackupPlanResponse ReleaseBackupPlan(ReleaseBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseBackupPlanWithOptions(request, runtime);
        }

        public async Task<ReleaseBackupPlanResponse> ReleaseBackupPlanAsync(ReleaseBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseBackupPlanWithOptionsAsync(request, runtime);
        }

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

        public RenewBackupPlanResponse RenewBackupPlan(RenewBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewBackupPlanWithOptions(request, runtime);
        }

        public async Task<RenewBackupPlanResponse> RenewBackupPlanAsync(RenewBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewBackupPlanWithOptionsAsync(request, runtime);
        }

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

        public StartBackupPlanResponse StartBackupPlan(StartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBackupPlanWithOptions(request, runtime);
        }

        public async Task<StartBackupPlanResponse> StartBackupPlanAsync(StartBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBackupPlanWithOptionsAsync(request, runtime);
        }

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

        public StartRestoreTaskResponse StartRestoreTask(StartRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRestoreTaskWithOptions(request, runtime);
        }

        public async Task<StartRestoreTaskResponse> StartRestoreTaskAsync(StartRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRestoreTaskWithOptionsAsync(request, runtime);
        }

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

        public StopBackupPlanResponse StopBackupPlan(StopBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopBackupPlanWithOptions(request, runtime);
        }

        public async Task<StopBackupPlanResponse> StopBackupPlanAsync(StopBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopBackupPlanWithOptionsAsync(request, runtime);
        }

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

        public UpgradeBackupPlanResponse UpgradeBackupPlan(UpgradeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeBackupPlanWithOptions(request, runtime);
        }

        public async Task<UpgradeBackupPlanResponse> UpgradeBackupPlanAsync(UpgradeBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeBackupPlanWithOptionsAsync(request, runtime);
        }

    }
}
